using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class TblRoomBookingMasterRepository :ITblRoomBookingMasterRepository
    {
        private readonly dbHMSContext _context;

        public TblRoomBookingMasterRepository(dbHMSContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TblRoomBookingMaster>> GetAllAsync()
        {
            var roombookinglst= _context.TblRoomBookingMasters.ToList();
            if (roombookinglst != null)
            {
                foreach (var item in roombookinglst) 
                {
                    item.roomName=_context.TblRooms.Where(a=>a.RoomId==item.RoomId).Select(a=>a.RoomName).FirstOrDefault();
                }
            }
            return  roombookinglst;
        }

        
    }
}
