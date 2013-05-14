using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEFDao
{
    /// <summary>
    /// EFDao公共接口
    /// 日期：2013-5-12
    /// 创建人：杨良斌
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseEFDao<T>
    {
        /// <summary>
        /// 获取记录数
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        int GetCount(Func<T, bool> exp);
        /// <summary>
        /// 获取Entities（列表）
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        IEnumerable<T> GetEntities(Func<T, bool> exp);
        /// <summary>
        /// 获取Entity（单个）
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        T GetEntity(Func<T, bool> exp);
        /// <summary>
        /// 新增Entity
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        bool Insert(T t);
        /// <summary>
        /// 新增Entity
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        bool Update(T t);
        /// <summary>
        /// 新增Entity(单个)
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        bool Delete(T t);
    }
}
