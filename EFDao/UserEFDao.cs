using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using IEFDao;

namespace EFDao
{
    /// <summary>
    /// 用户数据访问类
    /// 日期：2013-5-12
    /// 创建人：杨良斌
    /// </summary>
    class UserEFDao : BaseEFDao<t_Users>, IUserEFDao<t_Users>
    {
    }
}
