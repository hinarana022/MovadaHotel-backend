using Application.DTOs;
using Application.Interface;
using Application.Interface.Custom;
using AutoMapper;
using Domain.Entities;
using Infrastructure;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application
{
    public class TblRoomBookingMasterService 
    {
        private readonly IRepository<TblRoomBookingMaster> repository;
        private readonly IRepository<TblRoom> repositoryRoom;
        private readonly IMapper _mapper;

        public TblRoomBookingMasterService(IRepository<TblRoomBookingMaster> repository,IMapper mapper , IRepository<TblRoom> _repositoryRoom)
        {
            this.repository = repository;
            this._mapper = mapper;
            this.repositoryRoom = _repositoryRoom;
           
        }

       

        //public async Task<IEnumerable<TblRoomBookingMasterDTO>> GetAllAsync()
        //{
        //    var bookinglist = await repository.GetAllAsync();
        //    if (bookinglist != null)
        //    {
        //        foreach (var item in bookinglist)
        //        {
        //            item.roomName=repositoryRoom.GetByIdAsync(i)
        //        }
        //    }
        //var dtos = _mapper.Map<IEnumerable<TblRoomBookingMasterDTO>>(bookinglist); // Map entities to DTOs
        //return dtos;
        
        //}

        //IQueryable<UserDTO> ICustomBookingList.GetAllAsync()
        //{
        //    throw new NotImplementedException();
        //}
    }
}