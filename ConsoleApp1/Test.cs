using System;
using System.Collections.Generic;

namespace WebApplication2
{
    public class Test
    {
        public IEnumerable<TestHist> Hist = new[]
        {
            new TestHist {From = DateTime.Now.AddDays(1), Value = 1},
            new TestHist {From = DateTime.Now.AddDays(2), Value = 2},
            new TestHist {From = DateTime.Now.AddDays(3), Value = 3},
            new TestHist {From = DateTime.Now.AddDays(4), Value = 4},
            new TestHist {From = DateTime.Now.AddDays(5), Value = 5},
        };
    }
}