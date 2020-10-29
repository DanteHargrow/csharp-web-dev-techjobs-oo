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
            Assert.AreEqual(Desert.Value, job1.EmployerLocation.Value);
            Assert.AreEqual(QualityControl.Value, job1.JobType.Value);
            Assert.AreEqual(Persistence.ToString(), job1.JobCoreCompetency.ToString());
        }
    }
}
