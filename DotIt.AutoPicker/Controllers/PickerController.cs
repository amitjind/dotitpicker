using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using DotIt.AutoPicker.Models;
using DotIt.AutoPicker.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DotIt.AutoPicker.Controllers
{
    public class PickerController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public static List<OrderHedModel> SaleOrderList;
        public static List<PickersModel> PickersList;
        public PickerController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            TextReader reader = new StreamReader(_hostingEnvironment.WebRootPath + Constant.PickersFilePath);
            var CSVReader = new CsvReader(reader);
            var records = CSVReader.GetRecords<PickersModel>();
            ViewBag.Pickers = records.ToList();
            PickersList = records.ToList();
            return View();
        }

        public IActionResult Orders()
        {
            if (SaleOrderList == null)
            {
                GetOrders();
            }
            ViewBag.OrderList = SaleOrderList.Take(6);
            IEnumerable<OrderHedModel> Orders = SaleOrderList.Take(6);
            SaleOrderList = Orders.ToList();
            return View();
        }

        public IActionResult Pick()
        {

            ViewBag.OrderLineItems=GetOrderDetails(SaleOrderList);
            return View();
        }

        public List<OrderHedModel> GetOrders()
        {
            ApiResponse apiResponse = new ApiResponse();
            ResponseModel ObjResponse = apiResponse.GetApiResponse(Constant.EpicorApi_SalesOrder, "GET");
            var OrderList = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);
            if (OrderList.ContainsKey("value"))
            {
                if (!String.IsNullOrEmpty(OrderList["value"].ToString()))
                {
                    SaleOrderList = JsonConvert.DeserializeObject<List<OrderHedModel>>(OrderList["value"].ToString());
                    foreach (var OrderDate in SaleOrderList)
                    {
                        OrderDate.OrderDateTime = Convert.ToDateTime(OrderDate.OrderDate);
                    }
                    return SaleOrderList.Where(o => o.OrderDateTime < (DateTime.Now)).OrderBy(o => o.OrderDateTime).ToList();
                }
            }
            return null;
        }

        public List<OrderHedModel> GetOrderDetails(List<OrderHedModel> Orders)
        {
            List<OrderHedModel> OrderLineItems = new List<OrderHedModel>();
            ApiResponse apiResponse = new ApiResponse();
            ResponseModel ObjResponse = apiResponse.GetApiResponse(Constant.EpicorApi_OrderDetails, "GET");
            var OrderDetails = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);
            if (OrderDetails.ContainsKey("value"))
            {

                if (!String.IsNullOrEmpty(OrderDetails["value"].ToString()))
                {
                    var _result = JsonConvert.DeserializeObject<List<OrderHedModel>>(OrderDetails["value"].ToString());
                    foreach (var OrderDate in _result)
                    {
                        OrderDate.OrderDateTime = Convert.ToDateTime(OrderDate.OrderDate);
                    }
                    foreach (var order in Orders)
                    {
                        foreach (var Od in _result)
                        {
                            if (Od.OrderNum == order.OrderNum)
                            {
                                OrderLineItems.Add(Od);
                            }
                        }

                    }
                    OrderLineItems.First().TotalLines = OrderLineItems.Count();
                    return OrderLineItems;
                }
            }
            return null;
        }

        public JsonResult PickLineItem(int id, int orderline)
        {
            var Order = SaleOrderList.Where(o => o.OrderNum == id).Single();
            Order.OrderLine = orderline.ToString();
            Order.PickTime = DateTime.Now.ToString();
            SaleOrderList.ElementAt(SaleOrderList.IndexOf(SaleOrderList.Where(o => o.OrderNum == id).Single())).OrderPickStatus = "Processing";
            WriteToFile(Order,"pick");
            return Json("Order in  Pick Process");
        }

        public void WriteToFile(OrderHedModel ObjModel,string whattowrite)
        {
            var LogWriter = System.IO.File.AppendText(_hostingEnvironment.WebRootPath + Constant.LogFilePath);
            if (whattowrite == "pick")
            {
                var PickWriter = System.IO.File.AppendText(_hostingEnvironment.WebRootPath + Constant.PickFilePath);
                PickWriter.WriteLine("Order Line " + ObjModel.OrderLine + " from order number " + ObjModel.OrderNum + " was picked by " + ObjModel.UserId + " at time " + ObjModel.PickTime);
                PickWriter.Dispose();
                LogWriter.WriteLine("Order Line " + ObjModel.OrderLine + " from order number " + ObjModel.OrderNum + " was picked by " + ObjModel.UserId + " at time " + ObjModel.PickTime);
                LogWriter.Dispose();
            }
            if (whattowrite == "quarantine")
            {
                var QuarantineWriter = System.IO.File.AppendText(_hostingEnvironment.WebRootPath + Constant.QuarantineFilePath);
                QuarantineWriter.WriteLine("Order Number " + ObjModel.OrderNum + " was Quarantined by " + ObjModel.UserId + " at " + ObjModel.PickTime);
                //QuarantineWriter.WriteLine("Problem at Order Line " + ObjModel.OrderLine + " from Order Number " + ObjModel.OrderNum);
                QuarantineWriter.Dispose();
                LogWriter.WriteLine("Order Number " + ObjModel.OrderNum + " was Quarantined by " + ObjModel.UserId + " at " + ObjModel.PickTime);
                LogWriter.Dispose();
            }
        }

        public IActionResult CompleteOrder(string id)
        {
            int OrderNum = int.Parse(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(id)));
            SaleOrderList.ElementAt(SaleOrderList.IndexOf(SaleOrderList.Where(o => o.OrderNum == OrderNum).Single())).OrderPickStatus = "Completed";
            ViewBag.OrderList = SaleOrderList;
            return View("Index");
        }

        public IActionResult MoveToQuarantine(string id)
        {
            int Id = int.Parse(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(id)));
            var Order = SaleOrderList.Where(o => o.OrderNum == Id).Single();
            //Order.OrderLine = orderline.ToString();
            Order.PickTime = DateTime.Now.ToString();
            SaleOrderList.ElementAt(SaleOrderList.IndexOf(SaleOrderList.Where(o => o.OrderNum == Id).Single())).OrderPickStatus = "Quarantined";
            WriteToFile(Order,"quarantine");
            //ViewBag.OrderList = SaleOrderList.Take(Constant.NumberOfOrdersToShow);
            ViewBag.OrderLineItems = GetOrderDetails(SaleOrderList).Where(x => x.OrderNum != Id);
            return View("Pick");
        }
    }
}