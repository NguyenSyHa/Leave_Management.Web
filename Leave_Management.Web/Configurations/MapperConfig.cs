using AutoMapper;
using Leave_Management.Web.Data;
using Leave_Management.Web.Models;

namespace Leave_Management.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveTypeVM, LeaveType>().ReverseMap();
        }
    }
}
