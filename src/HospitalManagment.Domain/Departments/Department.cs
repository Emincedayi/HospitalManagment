using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace HospitalManagement.Departments
{
    public class Department : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        // One-to-Many: Bir Department'ın birden fazla Doctor'u olabilir
        public ICollection<Doctors.Doctor> Doctors { get; set; } = new List<Doctors.Doctor>();

        protected Department() { }

        public Department(Guid id,string title, string name) : base(id)
        {
            Name = name; 

        }
    }
}
