using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApiWebApplication.Extensions
{
    public static class ControllerExtensions
    {
        public static string RenderRazorViewToString(this Controller controller, string viewName, object model)
        {
            controller.ViewData.Model = model;
            string convert;
            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(controller.ControllerContext,
                                                                         viewName);
                var viewContext = new ViewContext(controller.ControllerContext, viewResult.View,
                                            controller.ViewData, controller.TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(controller.ControllerContext, viewResult.View);
                convert = sw.GetStringBuilder().ToString();
            }
            return convert;
        }
    }
}