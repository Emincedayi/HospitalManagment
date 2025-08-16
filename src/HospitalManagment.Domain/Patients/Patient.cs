using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace HospitalManagement.Patients
{
    public class Patient : AuditedAggregateRoot<Guid>
    {
        public ICollection<Appointments.Appointment> Appointments { get; set; } = new List<Appointments.Appointment>();

        protected Patient() { }

        public Patient(Guid id, string userName, string email)
            : base() //omer abiye sor buranın içi id username email dolmamalı mı hata veriyor
        {
        }
    }
}
