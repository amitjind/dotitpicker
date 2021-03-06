﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DotIt.AutoPicker.Models;
using DotIt.AutoPicker.Service;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Hosting;

namespace DotIt.AutoPicker.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public static List<OrderHedModel> SaleOrderList;
        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            if (SaleOrderList == null)
            {
                GetOrders();
            }
            ViewBag.OrderList = SaleOrderList.Where(o => o.TotalLines < 50).Take(Constant.NumberOfOrdersToShow);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult PickOrder(string id)
        {
            int OrderNum = int.Parse(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(id)));

            ViewBag.OrderDetails = GetOrderDetails(OrderNum);
            OrderHedModel ObjModel = new OrderHedModel();
            ObjModel.TotalLines = ViewBag.OrderDetails.Count;
            ObjModel.OrderNum = OrderNum;
            return View(ObjModel);
        }

        public JsonResult PickLineItem(int id, int orderline)
        {
            var Order = SaleOrderList.Where(o => o.OrderNum == id).Single();
            Order.OrderLine = orderline.ToString();
            Order.PickTime = DateTime.Now.ToString();
            SaleOrderList.ElementAt(SaleOrderList.IndexOf(SaleOrderList.Where(o => o.OrderNum == id).Single())).OrderPickStatus = "Processing";

            WriteToFile(Order);
            return Json("Order in  Pick Process");
        }

        public JsonResult UnPickLineItem(int id)
        {
            SaleOrderList.ElementAt(SaleOrderList.IndexOf(SaleOrderList.Where(o => o.OrderNum == id).Single())).OrderPickStatus = "";
            return Json("Order unpicked");
        }
        public IActionResult MoveToQuarantine(string id)
        {

            int Id = int.Parse(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(id)));
            SaleOrderList.ElementAt(SaleOrderList.IndexOf(SaleOrderList.Where(o => o.OrderNum == Id).Single())).OrderPickStatus = "Quarantined";
            ViewBag.OrderList = SaleOrderList.Take(Constant.NumberOfOrdersToShow);
            return View("Index");
        }

        public IActionResult CancelOrderPick(string id)
        {
            int Id = int.Parse(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(id)));
            SaleOrderList.ElementAt(SaleOrderList.IndexOf(SaleOrderList.Where(o => o.OrderNum == Id).Single())).OrderPickStatus = "";
            ViewBag.OrderList = SaleOrderList.Take(Constant.NumberOfOrdersToShow);
            return View("Index");
        }

        public IActionResult CompleteOrder(string id)
        {
            int OrderNum = int.Parse(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(id)));
            SaleOrderList.ElementAt(SaleOrderList.IndexOf(SaleOrderList.Where(o => o.OrderNum == OrderNum).Single())).OrderPickStatus = "Completed";
            ViewBag.OrderList = SaleOrderList;
            return View("Index");
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
        public OrderHedModel GetOrderbyordernum()
        {
            string url = string.Format(Constant.EpicorApi_SalesOrderByOrdernum, "DIRF", "210847");
            ApiResponse apiResponse = new ApiResponse();
            ResponseModel ObjResponse = apiResponse.GetApiResponse(url, "GET");
            var OrderList = JsonConvert.DeserializeObject<Dictionary<string, object>>(ObjResponse.Response);
            if (OrderList.ContainsKey("value"))
            {
                if (!String.IsNullOrEmpty(OrderList["value"].ToString()))
                {
                    var list = JsonConvert.DeserializeObject<OrderHedModel>(OrderList["value"].ToString());
                    return list;
                }
            }
            return null;
        }

        public List<OrderHedModel> GetOrderDetails(int ordernum)
        {
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
                    return _result.OrderBy(o => o.OrderDateTime).Where(o => o.OrderNum == ordernum).ToList();
                }
            }
            return null;
        }

        public void WriteToFile(OrderHedModel ObjModel)
        {
            string WebRootPath = _hostingEnvironment.WebRootPath;
            var logPath =  WebRootPath+Constant.LogFilePath;
            var LogWriter = System.IO.File.AppendText(logPath);
            LogWriter.WriteLine(ObjModel.OrderNum + "," + ObjModel.OrderLine + "," + ObjModel.Company + "," + ObjModel.CustNum + "," + ObjModel.OrderDateTime + "," + ObjModel.AllocPriorityCode + "," + ObjModel.ReservePriorityCode + "," + ObjModel.TotalLines + "," + ObjModel.PONum + "," + ObjModel.PickTime + "," + ObjModel.UserId);
            LogWriter.Dispose();
        }
    }
}
