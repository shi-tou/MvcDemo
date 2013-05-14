using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;

namespace MvcDemo.Models
{
    public class TestHelper
    {
         //以构造函数方式. 实现依赖注入.
        private readonly ITest  test;

        public TestHelper(ITest t)
        {
            if (t == null)
                throw new Exception("Error");
            test = t;
        }
        public int Add(int a,int b)
        {
            
            return test.Add(a,b);
        }
    }
}