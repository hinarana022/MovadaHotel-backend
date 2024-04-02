using Application.DTOs;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<RoomCategoryDTO, TblRoomTypeMaster>();
            CreateMap<TblRoomTypeMaster, RoomCategoryDTO>();
            //  CreateMap<List<TblRoomTypeMaster>, List<RoomCategoryDTO>>();
            // CreateMap<List<RoomCategoryDTO>, List<TblRoomTypeMaster>>();
            CreateMap<TblAccountLedger, UserDTO>();
            CreateMap<TblAccountLedger, userProfileDTO>();
            CreateMap<UserDTO, TblAccountLedger>();
            
        }
    }
}
