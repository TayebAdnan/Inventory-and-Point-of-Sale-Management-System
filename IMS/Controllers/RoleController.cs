﻿using IMS.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IMS.Controllers
{
    public class RoleController : Controller
    {
        public ActionResult Index()
        {
            IMSEntities3 entities = new IMSEntities3();
            return View(entities.Roles);
        }

        }
    }
