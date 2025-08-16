using AutoMapper.Internal.Mappers;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.ObjectMapping;

namespace HospitalManagement.Departments
{
    public class DepartmentAppService : ApplicationService, IDepartmentAppService
    {
       private readonly IDepartmentRepository _departmentsRepository;
        public DepartmentAppService(IDepartmentRepository departmentsRepository)
        {
            _departmentsRepository = departmentsRepository;
        }


        public async Task<DepartmentDto> CreateAsync( string title, string name)
        {
            var department = new Department(
        id: GuidGenerator.Create(), // ABP'nin built-in servisi
        title: title,
        name: name
    );

            await _departmentsRepository.InsertAsync(department);
            return ObjectMapper.Map<Department, DepartmentDto>(department);
        }

       

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Department>> GetListAsync(Guid id, string title, string name)
        {
            throw new NotImplementedException();
        }

        //public async Task<PagedResultDto<DepartmentDto>> GetListAsync(Guid id, string title, string name)
        //{
        //    var department = await _departmentsRepository.GetListAsync(

        //    );

        //    var totalCount = await _departmentsRepository.GetCountAsync();

        //    return new PagedResultDto<DepartmentDto>(
        //        totalCount,
        //        ObjectMapper.Map<List<Department>, List<DepartmentDto>>(department)
        //    );

    }
}
