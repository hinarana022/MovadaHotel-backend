using Application.DTOs;
using Application.Interface;
using Application.Interface.Custom;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Custom
{
    public class CustomRoomCategoryService : ICustomRoomCategoryService
    {
        private readonly IMapper _mapper;
      //  private readonly IRepository<TblRoomTypeMaster> _repository;
        private readonly dbHMSContext _dbContext;

        public CustomRoomCategoryService( IMapper mapper, dbHMSContext dbContext)
        {
            //_repository = repository;
            _mapper = mapper;
            _dbContext = dbContext;
        }

    
        public async Task<List<RoomCategoryDTO>> GetAllRoomsCategory()
        {

            var categories = await _dbContext.TblRoomTypeMasters.ToListAsync();
            foreach (var item in categories)
            {
                item.tblRoomTypeImage = await _dbContext.TblRoomTypeImages
                    .Where(a => a.RoomTypeId == item.RoomTypeId)
                    .FirstOrDefaultAsync();

                var amenityIds = await _dbContext.TblRoomTypeAmentiesDetails
                    .Where(a => a.RoomTypeId == item.RoomTypeId)
                    .Select(a => a.AmentiesId)
                    .ToListAsync();
                item.tblAmenties = new List<TblAmenty>();
                foreach (var amenityId in amenityIds)
                {
                    var amenity = await _dbContext.TblAmenties
                        .Where(a => a.AmentiesId == amenityId)
                        .FirstOrDefaultAsync();
                    var amenityimg = await _dbContext.TblAmentiesImages
                        .Where(a => a.amentiesId == amenityId)
                        .FirstOrDefaultAsync();
                    amenity.TblAmentiesImage = amenityimg;
                    item.tblAmenties.Add(amenity);
                }
            }
            var roomCategoryDTO = _mapper.Map<List<RoomCategoryDTO>>(categories);

            return roomCategoryDTO;
        }


        public async Task<List<RoomCategoryDTO>> GetAllRoomsCategorybyId(int id)
        {
            var categories = _dbContext.TblRoomTypeMasters.Where(a => a.RoomTypeId == id).ToList();
            foreach (var item in categories)
            {
                item.tblRoomTypeImage = await _dbContext.TblRoomTypeImages
                    .Where(a => a.RoomTypeId == item.RoomTypeId)
                    .FirstOrDefaultAsync();

                var amenityIds = await _dbContext.TblRoomTypeAmentiesDetails
                    .Where(a => a.RoomTypeId == item.RoomTypeId)
                    .Select(a => a.AmentiesId)
                    .ToListAsync();
                item.tblAmenties = new List<TblAmenty>();
                foreach (var amenityId in amenityIds)
                {
                    var amenity = await _dbContext.TblAmenties
                        .Where(a => a.AmentiesId == amenityId)
                        .FirstOrDefaultAsync();
                    var amenityimg = await _dbContext.TblAmentiesImages
                        .Where(a => a.amentiesId == amenityId)
                        .FirstOrDefaultAsync();
                    amenity.TblAmentiesImage = amenityimg;
                    item.tblAmenties.Add(amenity);
                }
            }
            var roomCategoryDTO = _mapper.Map<List<RoomCategoryDTO>>(categories);

            return roomCategoryDTO;
        }

    }
}
