using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IEFDao;
using Entity;
using System.Data.Objects;
using System.Data;

namespace EFDao
{
    /// <summary>
    /// 实现EFDao公共接口基类
    /// 日期：2013-5-12
    /// 创建人：杨良斌
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseEFDao<T> : IBaseEFDao<T> where T : class, new()
    {       
        /// <summary>
        /// 获取记录数
        /// </summary>
        /// <param name="exp">Lambda表达条件</param>
        /// <returns></returns>
        public virtual int GetCount(Func<T, bool> exp)
        {
            using (MvcDemoEntities Entities = new MvcDemoEntities())
            {
                return Entities.CreateObjectSet<T>().Where(exp).ToList<T>().Count;
            }
        }
        /// <summary>
        /// 获取Entity(列表)
        /// </summary>
        /// <param name="exp">Lambda表达条件</param>
        /// <returns></returns>
        public virtual IEnumerable<T> GetEntities(Func<T, bool> exp)
        {
            using (MvcDemoEntities Entities = new MvcDemoEntities())
            {
                return Entities.CreateObjectSet<T>().Where(exp).ToList<T>();
            }
        }
        /// <summary>
        /// 获取Entity(单个)
        /// </summary>
        /// <param name="exp">Lambda表达条件</param>
        /// <returns></returns>
        public virtual T GetEntity(Func<T, bool> exp)
        {
            using (MvcDemoEntities Entities = new MvcDemoEntities())
            {
                return Entities.CreateObjectSet<T>().SingleOrDefault<T>(exp);
            }
        }
        /// <summary>
        /// 新增Entity
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public virtual bool Insert(T t)
        {
            using (MvcDemoEntities Entities = new MvcDemoEntities())
            {
                var obj = Entities.CreateObjectSet<T>();
                obj.AddObject(t);
                return Entities.SaveChanges() > 0;
            }
        }
        /// <summary>
        /// 更新Entity(注意这里使用的傻瓜式更新,可能性能略低)
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public virtual bool Update(T t)
        {
            using (MvcDemoEntities Entities = new MvcDemoEntities())
            {
                var obj = Entities.CreateObjectSet<T>();
                obj.Attach(t);
                Entities.ObjectStateManager.ChangeObjectState(t, EntityState.Modified);
                return Entities.SaveChanges() > 0;
            }
        }
        /// <summary>
        /// 删除Entity
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public virtual bool Delete(T t)
        {
            using (MvcDemoEntities Entities = new MvcDemoEntities())
            {
                var obj = Entities.CreateObjectSet<T>();
                if (t != null)
                {
                    obj.Attach(t);
                    Entities.ObjectStateManager.ChangeObjectState(t, EntityState.Deleted);
                    return Entities.SaveChanges() > 0;
                }
                return false;
            }
        }
    }
}
