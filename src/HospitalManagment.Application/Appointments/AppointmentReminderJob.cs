//using System;
//using System.Threading.Tasks;
//using Volo.Abp.BackgroundJobs;
//using Volo.Abp.DependencyInjection;
//using Volo.Abp.Emailing;
//using Volo.Abp.Domain.Repositories;
//using HospitalManagement.Appointments;

//public class AppointmentReminderJobArgs
//{
//    public Guid AppointmentId { get; set; }
//}

//public class AppointmentReminderJob : AsyncBackgroundJob<AppointmentReminderJobArgs>, ITransientDependency
//{
//    private readonly IRepository<Appointment, Guid> _appointmentRepository;
//    private readonly IEmailSender _emailSender;

//    public AppointmentReminderJob(
//        IRepository<Appointment, Guid> appointmentRepository,
//        IEmailSender emailSender)
//    {
//        _appointmentRepository = appointmentRepository;
//        _emailSender = emailSender;
//    }

//    public override async Task ExecuteAsync(AppointmentReminderJobArgs args)
//    {
//        var appointment = await _appointmentRepository.GetAsync(args.AppointmentId);
//        var patientEmail = appointment.PatientId; // IdentityUser’dan gelecek PatientId.Email hata veriyordu sildim

//        await _emailSender.SendAsync(
//            patientEmail,
//            "Appointment Reminder",
//            $"Dear {appointment.PatientId}, you have an appointment with Dr. {appointment.DoctorId} on {appointment.StartTime:dd MMM yyyy HH:mm}.",
//            true
//        );
//    }
//}