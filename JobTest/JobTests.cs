using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

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

        [TestMethod]
        public void TestSettingJobId()
        {
            Job idTestJob1 = new Job();
            Job idTestJob2 = new Job();

            Assert.AreNotEqual(idTestJob1, idTestJob2);
            Assert.IsTrue(idTestJob1.Id == idTestJob2.Id - 1);
        }


        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {


        }
    }
}


//4 tests for ToString
//job test needs ot connect to job class
//3  can be  completed w.o TDD & ONE REQUIRES TDD
//very robust & our JOB is supposed to return (example picture)