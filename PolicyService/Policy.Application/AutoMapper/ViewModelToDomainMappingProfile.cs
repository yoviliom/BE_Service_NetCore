using AutoMapper;
using Policy.Application.DTOs;
using Policy.Data.Entities;

namespace Policy.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ContractDTO, Contract>().ForMember(x => x.Id, opt => opt.Ignore());
            CreateMap<ProvinceDTO, Province>().ForMember(x => x.Id, opt => opt.Ignore());
            CreateMap<StudentDTO, Student>().ForMember(x => x.Id, opt => opt.Ignore());
            CreateMap<TeacherDTO, Teacher>().ForMember(x => x.Id, opt => opt.Ignore());
            CreateMap<PermissionDTO, Permission>().ForMember(x => x.Code, opt => opt.Ignore());
        }
    }
}