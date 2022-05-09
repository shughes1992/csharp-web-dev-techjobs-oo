using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JobTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, 10, .001);

        }
    }
}


//4 tests for ToString
//job test needs ot connect to job class
//3  can be  completed w.o TDD & ONE REQUIRES TDD
//very robust & our JOB is supposed to return (example picture)