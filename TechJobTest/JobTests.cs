using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTest
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.AreNotEqual(job1.Id,job2.Id);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Employer ACME = new Employer("ACME");
            Location Desert = new Location("Desert");
            PositionType QualityControl = new PositionType("Quality Control");
            CoreCompetency Persistence = new CoreCompetency("Persistence");
            Job job1 = new Job("Product Tester", ACME, Desert, QualityControl, Persistence);
            Assert.AreEqual("Product Tester", job1.Name);
            Assert.AreEqual(Desert.ToString(), job1.EmployerLocation.ToString());
            Assert.AreEqual(QualityControl.ToString(), job1.JobType.ToString());
            Assert.AreEqual(Persistence.ToString(), job1.JobCoreCompetency.ToString());
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.IsFalse(job1.Equals(job2));
        }
        [TestMethod]
        public void TestToStringMethod()
        {
            Job job1 = new Job();
            string str = job1.ToString();
            Assert.AreEqual('\n', str[0]);
        }
        [TestMethod]
        public void TestToStringReturnsId()
        {
            Employer ACME = new Employer("ACME");
            Location Desert = new Location("Desert");
            PositionType QualityControl = new PositionType("Quality Control");
            CoreCompetency Persistence = new CoreCompetency("Persistence");
            Job job1 = new Job("Product Tester", ACME, Desert, QualityControl, Persistence);
            string str = job1.ToString();
            Assert.AreEqual("\n"+"Id: " + job1.Id+"\n", str.Substring(0,7));
            Assert.AreEqual("\n" + "Name: " + job1.Name + "\n", str.Substring(6, 22));
        }
    }
}
