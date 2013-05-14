using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using Ninject.Modules;//引用Ninject组件使用IOC进行反转控制/DI依赖注入

namespace MvcDemo.Models
{
    public class Test1IOC : NinjectModule
    {
        public override void Load()
        {
            Bind<ITest>().To<Test1>();
        }
    }
    public class Test2IOC : NinjectModule
    {
        public override void Load()
        {
            Bind<ITest>().To<Test2>();
        }
    }
}