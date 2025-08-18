using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HospitalManagement.Doctors;

public class Doctor : FullAuditedAggregateRoot<Guid>
{
    public Guid UserId { get; private set; } // FK → IdentityUser.Id
    public Guid DepartmentId { get; private set; }
    public string? Specialty { get; private set; }

    // Optional simple availability flags/notes
    public string? AvailabilityNotes { get; private set; }

    private Doctor() { }

    public Doctor(Guid id, Guid userId, Guid departmentId, string? specialty = null) : base(id)
    {
        UserId = userId;
        DepartmentId = departmentId;
        Specialty = specialty; 
      
    }

    public Doctor SetSpecialty(string? specialty)
    {
        Specialty = specialty;
        return this;
    }

    public Doctor SetAvailabilityNotes(string? notes)
    {
        AvailabilityNotes = notes;
        return this;
    }
}
















//using Microsoft.AspNetCore.Identity;
//using System;
//using System.Collections.Generic;
//using Volo.Abp.Domain.Entities.Auditing;
//using Volo.Abp.Identity;

//namespace HospitalManagement.Doctors
//{
//    public class Doctor : AuditedAggregateRoot<Guid>
//    {
//        public Guid DepartmentId { get; set; }
//        public Departments.Department Department { get; set; }

//        public ICollection<Appointments.Appointment> Appointments { get; set; } = new List<Appointments.Appointment>();

//        protected Doctor() { }

//        public Doctor(Guid id, string userName, string email, Guid departmentId)
//            : base()
//        {
//            DepartmentId = departmentId;
//        }
//    }
//}
