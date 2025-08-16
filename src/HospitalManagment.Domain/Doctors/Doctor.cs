using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace HospitalManagement.Doctors
{
    public class Doctor : AuditedAggregateRoot<Guid>
    {
        public Guid DepartmentId { get; set; }
        public Departments.Department Department { get; set; }

        public ICollection<Appointments.Appointment> Appointments { get; set; } = new List<Appointments.Appointment>();

        protected Doctor() { }

        public Doctor(Guid id, string userName, string email, Guid departmentId)
            : base()
        {
            DepartmentId = departmentId;
        }
    }
}
