using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using BLL;
using Entity;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{
    /// <summary>
    /// 用户控制器
    /// 日期：2013-5-12
    /// 创建人：杨良斌
    /// </summary>
    public class UsersController : Controller
    {
        /// <summary>
        /// 用户接口
        /// </summary>
        public IUserBLL userBLL = new UserBLL();
        /// <summary>
        /// 用户列表
        /// </summary>
        public ViewResult Index()
        {
            List<t_Users> u = userBLL.GetAllUsers();
            return View(u);
        }
        /// <summary>
        /// 呈现新增用户表单
        /// </summary>
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        /// <summary>
        /// 新增用户操作
        /// </summary>
        [HttpPost]
        public ActionResult Create(t_Users u, FormCollection form)
        {
            if (ModelState.IsValid)//实例的模型状态是否验证
            {
                userBLL.Insert(u);
                return RedirectToAction("Index");
            }
            else
                return View();
        }
        /// <summary>
        /// 显示修改的用户信息
        /// 注意：这里的【userID】一写要与动作连接的参数名一致 @Html.ActionLink("Edit", "Edit", new { 【userID】 = item.UserID })
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public ActionResult Edit(int userID)
        {
            t_Users u = userBLL.GetUsers(userID);
            return View(u);
        }
        /// <summary>
        /// 修改用户操作
        /// </summary>
        [HttpPost]
        public ActionResult Edit(int userID, t_Users u)
        {
            userBLL.Update(u);
            return RedirectToAction("Index");
        }
        /// <summary>
        /// 删除用户操作
        /// </summary>
        public ActionResult Delete(int userID)
        {
            userBLL.DeleteUser(userID);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int userID)
        {
            t_Users u = userBLL.GetUsers(userID);
            return View(u);
        }

    }
}
