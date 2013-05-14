using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using IBLL;
using IEFDao;
using Spring.Context;
using Spring.Context.Support;

namespace BLL
{
    /// <summary>
    /// 用户业务类
    /// 日期：2013-5-12
    /// 创建人：杨良斌
    /// </summary>
    public class UserBLL : BaseBLL<t_Users>, IUserBLL
    {
        #region 依赖注入
        /// <summary>
        /// 该接口负责用户自定义的功能实现
        /// </summary>
        private IUserEFDao<t_Users> myDao = null;
        /// <summary>
        /// 构造函数(接口转换,Dao只负责基类的增删改查)
        /// </summary>
        public UserBLL()
        {
            //spring.net注入
            IApplicationContext ctx = ContextRegistry.GetContext();
            myDao = ctx.GetObject("UserEFDao") as IUserEFDao<t_Users>;
            Dao = myDao;
        }
        #endregion
        /// <summary>
        /// 根据条件获取所有用户数量
        /// </summary>
        /// <returns></returns>
        public int GetUsersCount()
        {
            return Dao.GetCount(u => u.UserID > 0);
        }
        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>
        public List<t_Users> GetAllUsers()
        {
            return Dao.GetEntities(u => u.UserID > 0).ToList<t_Users>();
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public t_Users GetUsers(int userID)
        {
            return Dao.GetEntity(u => u.UserID == userID);
        }
        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public bool InsertUser(t_Users u)
        {
            return Dao.Insert(u);
        }/// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public bool UpdateUser(t_Users u)
        {
            return Dao.Update(u);
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public bool DeleteUser(t_Users u)
        {
            return Dao.Delete(u);
        }
        /// <summary>
        /// 删除用户ByID
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public bool DeleteUser(int userID)
        {
            t_Users user = Dao.GetEntity(u => u.UserID == userID && u.Name=="");
            return Dao.Delete(user);
        }

    }
}
