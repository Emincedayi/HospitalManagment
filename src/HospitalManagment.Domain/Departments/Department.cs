using HospitalManagement.Doctors;
using System;
using System.Collections.Generic;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace HospitalManagement.Departments;

public class Department : FullAuditedAggregateRoot<Guid>
{
    public string Name { get; private set; }
    public string? Description { get; private set; }

    // Navigation
    public ICollection<Doctor> Doctors { get; private set; } = new List<Doctor>();

    private Department() { }

    public Department(Guid id, string name, string? description = null) : base(id)
    {
        SetName(name);
        Description = description;
    }

    public Department SetName(string name)
    {
        Name = Check.NotNullOrWhiteSpace(name, nameof(name), maxLength: 128);
        return this;
    }
} 


















//using System;
//using System.Collections.Generic;
//using Volo.Abp.Domain.Entities.Auditing;

//namespace HospitalManagement.Departments
//{
//    public class Department : FullAuditedAggregateRoot<Guid>
//    {
//        public string Name { get; set; }

//        // One-to-Many: Bir Department'ın birden fazla Doctor'u olabilir
//        public ICollection<Doctors.Doctor> Doctors { get; set; } = new List<Doctors.Doctor>();

//        protected Department() { }

//        public Department(Guid id,string title, string name) : base(id)
//        {
//            Name = name; 

//        }
//    } 
//}
