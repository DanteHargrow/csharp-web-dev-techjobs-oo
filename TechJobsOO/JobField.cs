using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        int Id { get; }
        static int nextId = 1;
        string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }
        public JobField(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is JobField jobField &&
                   Id == jobField.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override string ToString()
        {
            return Value;
        }
    }
}
