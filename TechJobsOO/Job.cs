using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }
        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        // ToString Method
        public override string ToString()
        {
            string str = "Id: " + this.Id+"\n";
            if(this.Name == null)
            {
                str += "Name: " + "Data not available\n";
            }
            else
                str += "Name: " + this.Name+"\n";
            if(this.EmployerName == null)
            {
                str += "Employer: " + "Data not available\n";
            }
            else
                str += "Employer: " + this.EmployerName+"\n";
            if(this.EmployerLocation == null)
            {
                str += "Location: " + "Data not available\n";
            }
            else
                str += "Location: " + this.EmployerLocation+"\n";
            if(this.JobType == null)
            {
                str += "Position Type: " + "Data not available\n";
            }
            else
                str += "Position Type: " + this.JobType+"\n";
            if(this.JobCoreCompetency == null)
            {
                str += "Core Competency: " + "Data not available\n";
            }
            else
                str += "Core Competency: " + this.JobCoreCompetency+"\n";
            return "\n"+str;
        }



    }
}
