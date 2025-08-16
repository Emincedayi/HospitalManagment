using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HospitalManagement.Patients;

public class Patient : FullAuditedAggregateRoot<Guid>
{
    public Guid UserId { get; private set; } // FK → IdentityUser.Id
    public DateTime? DateOfBirth { get; private set; }
    public string? Notes { get; private set; }

    private Patient() { }

    public Patient(Guid id, Guid userId, DateTime? dateOfBirth = null, string? notes = null) : base(id)
    {
        UserId = userId;
        DateOfBirth = dateOfBirth;
        Notes = notes;
    }

    public Patient SetNotes(string? notes)
    {
        Notes = notes;
        return this;
    }
}








//using Microsoft.AspNetCore.Identity;
//using System;
//using System.Collections.Generic;
//using Volo.Abp.Domain.Entities.Auditing;
//using Volo.Abp.Identity;

//namespace HospitalManagement.Patients
//{
//    public class Patient : AuditedAggregateRoot<Guid>
//    {
//        public ICollection<Appointments.Appointment> Appointments { get; set; } = new List<Appointments.Appointment>();

//        protected Patient() { }

//        public Patient(Guid id, string userName, string email)
//            : base() //omer abiye sor buranın içi id username email dolmamalı mı hata veriyor
//        {
//        }
//    }
//}
