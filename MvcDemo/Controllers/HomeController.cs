using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDemo.Models;
using Ninject;

namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// GET: /Home/
        /// </summary>
        /// <returns></returns>
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Message = hour < 12 ? "good morning" : "good afternoon";
            return View();
        }
        /// <summary>
        /// GET:RsvpForm
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)//实例的模型状态是否验证
                return View("Thanks", guestResponse);//指定视图，并把对象传递给视图
            else
                return View();
        }
        public ViewResult Add()
        {
            using (IKernel kernel = new StandardKernel(new Test1IOC()))
            {
                TestHelper t = kernel.Get<TestHelper>();
                ViewBag.Res1 = t.Add(1, 2);
            }
            using (IKernel kernel = new StandardKernel(new Test2IOC()))
            {
                TestHelper t = kernel.Get<TestHelper>();
                ViewBag.Res2 = t.Add(1, 2);
            }
            return View();
        }
    }
}
