using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace IBLL
{
    /// <summary>
    /// 用户业务逻辑接口
    /// 日期：2013-5-12
    /// 创建人：杨良斌
    /// </summary>
    public interface IUserBLL : IBaseBLL<t_Users>
    {
        /// <summary>
        /// 根据条件获取所有用户数量
        /// </summary>
        /// <returns></returns>
        int GetUsersCount();
        /// <summary>
        /// 根据条件获取所有用户
        /// </summary>
        /// <returns></returns>
        List<t_Users> GetAllUsers();
        /// <summary>
        /// 获取用户
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        t_Users GetUsers(int userID);
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        bool DeleteUser(int userID);
    }
}
