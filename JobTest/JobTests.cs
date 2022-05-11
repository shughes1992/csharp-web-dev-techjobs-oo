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


            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsTrue("Product tester" == job1.Name);
            Assert.IsTrue("ACME" == job1.EmployerName.Value);
            Assert.IsTrue("Desert" == job1.EmployerLocation.Value);
            Assert.IsTrue("Quality control" == job1.JobType.Value);
            Assert.IsTrue("Persistence" == job1.JobCoreCompetency.Value);
        }



        [TestMethod]
        public void TestJobsForEquality()
        {
            Job equality1 = new Job("TA", new Employer("LaunchCode"), new Location("Space"), new PositionType("JAVA"), new CoreCompetency("Fun"));
            Job equality2 = new Job("TA", new Employer("LaunchCode"), new Location("Space"), new PositionType("JAVA"), new CoreCompetency("Fun"));

            Assert.IsFalse(equality1 == equality2);

        }

        [TestMethod]
        public void TestToString()
        {
            Job job3 = new Job("Ice cream taster", new Employer("Bassetts"), new Location("Philadelphia"), new PositionType("reviewer"), new CoreCompetency("yum"));

            Assert.AreEqual(job3.ToString(),
                $"ID:{job3.Id}\n" +
                $"Name: {job3.Name}\n" +
                $"Employer: {job3.EmployerName}\n" +
                $"Location: {job3.EmployerLocation}\n" +
                $"Position Type: {job3.JobType}\n" +
                $"Core Competency: {job3.JobCoreCompetency}\n");

        }

    }
}


//4 tests for ToString
//job test needs ot connect to job class
//3  can be  completed w.o TDD & ONE REQUIRES TDD
//very robust & our JOB is supposed to return (example picture)