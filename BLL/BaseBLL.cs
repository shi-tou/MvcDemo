using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBLL;
using IEFDao;
namespace BLL
{
    /// <summary>
    /// 实现业务逻辑基类（基类只实现增删改查逻辑）
    /// 日期：2013-5-12
    /// 创建人：杨良斌
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseBLL<T> : IBaseBLL<T> where T : class, new()
    {
        private IBaseEFDao<T> dao = null;
        public IBaseEFDao<T> Dao
        {
            get { return dao; }
            set { this.dao = (IBaseEFDao<T>)value; }
        }
        /// <summary>
        /// 获取记录数
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public virtual int GetCount(Func<T, bool> exp)
        {
            return dao.GetCount(exp);
        }
        /// <summary>
        /// 获取Entities（列表）
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public virtual IEnumerable<T> GetEntities(Func<T, bool> exp)
        {
            return dao.GetEntities(exp);
        }
        /// <summary>
        /// 查询Entity（单个）
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public virtual T GetEntity(Func<T, bool> exp)
        {
            return dao.GetEntity(exp);
        }
        /// <summary>
        /// 新增Entity
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public virtual bool Insert(T t)
        {
            return dao.Insert(t);
        }
        /// <summary>
        /// 更新Entity
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public virtual bool Update(T t)
        {
            return dao.Update(t);
        }
        /// <summary>
        /// 删除Entity
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public virtual bool Delete(T t) 
        {
            return dao.Delete(t);
        }
    }
}
