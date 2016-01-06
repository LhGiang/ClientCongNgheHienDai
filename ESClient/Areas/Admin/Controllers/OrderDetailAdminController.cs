﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ESClient.Areas.Admin.Controllers
{
    public class OrderDetailAdminController : Controller
    {
        // GET: Admin/OderDetail
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit(string id)
        {
            ViewBag.Ma ="'" + id + "'";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit()
        {
            ViewBag.Info = "Cập nhật thành công";
            return RedirectToAction("Index", "OrderDetailAdmin");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            ViewBag.Info = "Thêm mới thành công";
            return RedirectToAction("Index", "OrderDetailAdmin");
        }
    }
}