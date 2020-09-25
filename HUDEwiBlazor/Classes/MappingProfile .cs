using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HUDEwiBlazor.Classes.Mapped;
using HUDEwiBlazor.Data.Models;

namespace HUDEwiBlazor.Classes
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Employee, MappedEmployee>();
            CreateMap<MappedEmployee, Employee>();

            CreateMap<MenuItem, MappedMenuItem>();
            CreateMap<Roles, MappedRoles>();

        }
    }
}
