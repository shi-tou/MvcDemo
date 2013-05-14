using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBLL
{
    /// <summary>
    /// 业务逻辑公共接口(实现基本的增删改查)
    /// 日期：2013-5-12
    /// 创建人：杨良斌
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseBLL<T>
    {
        /// <summary>
        /// 获取记录数
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        int GetCount(Func<T,bool> exp);
        /// <summary>
        /// 获取Entities（列表）
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        IEnumerable<T> GetEntities(Func<T, bool> exp);
        /// <summary>
        /// 查询Entity（单个）
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        T GetEntity(Func<T, bool> exp);
        /// <summary>
        /// 新增Entity
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        bool Insert(T t);
        /// <summary>
        /// 更新Entity
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        bool Update(T t);
        /// <summary>
        /// 删除Entity
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        bool Delete(T t);
    }
}
