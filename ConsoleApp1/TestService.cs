using System.Linq;

namespace WebApplication2
{
    public class TestService
    {
        public TestHist GetFirst(Test test) => test.Hist.First();

        public TestHist GetLast(Test test) => test.Hist.Last();
    }
}