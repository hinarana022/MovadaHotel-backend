using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public  class userProfileDTO:UserDTO
    {
        public List<TblRoomBookingMasterDTO>? tblbookinglist { get; set; }
        public TblVoucherAttachment? tblVoucherAttachment  { get; set; }

    }
}
