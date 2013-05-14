using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDemo.Models
{
    public class Test2 : ITest
    {
        public int Add(int a, int b)
        {
            return a * 10 + b * 10;
        }
    }
}