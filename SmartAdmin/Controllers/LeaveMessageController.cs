﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart.Admin.Controllers
{
    /// <summary>
    /// 门户基础模块:留言管理
    /// </summary>
    public class LeaveMessageController : Controller
    {
        //
        // GET: /LeaveMessage/

        public ActionResult Index()
        {
            return View();
        }

    }
}
