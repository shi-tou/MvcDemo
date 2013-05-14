using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEFDao
{
    /// <summary>
    /// 用户数据访问接口
    /// 日期：2013-5-12
    /// 创建人：杨良斌
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IUserEFDao<T> : IBaseEFDao<T> where T : class
    {

    }
}
