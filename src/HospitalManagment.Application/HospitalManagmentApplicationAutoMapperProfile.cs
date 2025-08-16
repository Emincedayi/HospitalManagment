using AutoMapper;
using HospitalManagement.Appointments;
using HospitalManagement.Departments;
using HospitalManagement.Doctors;
using HospitalManagement.Patients;

namespace HospitalManagment;

public class HospitalManagmentApplicationAutoMapperProfile : Profile
{
    public HospitalManagmentApplicationAutoMapperProfile()
    {
        CreateMap<Department, DepartmentDto>();
        CreateMap<CreateUpdateDepartmentDto, Department>();

        CreateMap<Doctor, DoctorDto>();
        CreateMap<CreateUpdateDoctorDto, Doctor>();

        CreateMap<Patient, PatientDto>();
        CreateMap<CreateUpdatePatientDto, Patient>();

        CreateMap<Appointment, AppointmentDto>();



        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
