﻿using SupperSlonicWebSite.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SupperSlonicWebSite.Controllers
{
    public class SocialNetworksController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OwinAuthentication()
        {
            List<TabWidgetModel> model = new List<TabWidgetModel>(4);
            model.Add(new TabWidgetModel("description"));
            model.Add(new TabWidgetModel("demo"));
            model.Add(new TabWidgetModel("owin"));
            model.Add(new TabWidgetModel("facebook"));
            model.Add(new TabWidgetModel("google"));
            model.Add(new TabWidgetModel("microsoft"));

            return View(model);
        }
    }
}
