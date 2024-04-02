using Application.DTOs;
using Application.Interface.Custom;
using Domain.Entities;
using Domain.SP;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using System.Runtime.CompilerServices;

namespace Application.Services.Custom
{
    public class CustomBookingListService : ICustomBookingListService
    {
        private readonly dbHMSContext _dbContext;
        private readonly IRepository<TblRoomBookingMaster> _repository;
        private readonly IRepository<TblRoomBookingScheduleDetail> _rep_RoomBookingScheduleDetail;
        private readonly IRepository<TblLedgerPosting> _rep_TblLedgerPosting;
        private readonly IRepository<TblRoomBookingTimelineDetail> _rep_TRoomBookingTimelineDetail;


        public CustomBookingListService(dbHMSContext dbContext, IRepository<TblRoomBookingMaster> repository, IRepository<TblLedgerPosting> rep_TblLedgerPosting, IRepository<TblRoomBookingScheduleDetail> rep_RoomBookingScheduleDetail, IRepository<TblRoomBookingTimelineDetail> rep_TRoomBookingTimelineDetail)
        {
            _dbContext = dbContext;
            _repository = repository;
            _rep_RoomBookingScheduleDetail = rep_RoomBookingScheduleDetail;
            _rep_TRoomBookingTimelineDetail = rep_TRoomBookingTimelineDetail;
            _rep_TblLedgerPosting= rep_TblLedgerPosting;
        }

        public Task<bookinRoomStatusDTO> booknow(bookingDTO dTO)
        {
            List<decimal> availableRoomIds = new List<decimal>();
            List<decimal> BookedRoomIds = new List<decimal>();
            var totalRoomsOfCategory = _dbContext.TblRooms.Where(x => x.RoomTypeId == dTO.RoomTypeId).Count();
            var totalRooms = _dbContext.TblRooms.Where(x => x.RoomTypeId == dTO.RoomTypeId).Select(r => r.RoomId).ToList();
            bool roomAvailable = true;
            spnNoOfNights = Convert.ToInt32((dTO.CheckOut - dTO.CheckIn).TotalDays);
            int RequiredRooms = 1;
            foreach (var roomid in totalRooms)
            {
                for (DateTime Date = dTO.CheckIn; Date <= dTO.CheckOut; Date = Date.AddDays(1))
                {
                    // Check if there are any bookings that conflict with the current date
                    var isBooked = _dbContext.TblRoomBookingMasters
                         .Where(rb => rb.RoomId == roomid &&
                                rb.ReservationDate >= Date && rb.ReservationDate <=  Date).Any();
                   
                    // If there are any conflicting bookings for the current date, mark the room as unavailable
                    // Print the availability status for each date
                    if (isBooked)
                    {
                        roomAvailable = false;
                        BookedRoomIds.Add(roomid);
                        break;
                        //Console.WriteLine($"Room is already booked on {Date.ToShortDateString()}.");
                    }
                    else
                    {
                        availableRoomIds.Add(roomid);
                        break;

                    }
                    //if (conflictingBookings.Any())
                    //{
                    //    

                    //    break; // No need to continue checking for this room if it's already booked for any date
                    //}
                    //;

                }
            }
            availableRoomIds = totalRooms.Except(BookedRoomIds).ToList();
            if (availableRoomIds.Count > 0)
            {
                LoadSeason(dTO.CheckIn);
                RoomTypeId = dTO.RoomTypeId;
                StayType = "Days";
                if(dTO.guests!="")
                spnNoOfAdults = Convert.ToInt32(dTO.guests);
                LoadRateType(StayType);
                CalculateRoomTariff();
                var bookinRoomStatusdto = new bookinRoomStatusDTO
                {
                ReservationNo = "RB-" + (MaxID_FormatedfourDigits((_dbContext.TblRoomBookingMasters.Max(x => x.ReservationId) + 1).ToString())).ToString(),
                    RoomId = availableRoomIds[0],
                    status = "available",
                    Rate = RoomCharges
                };
                return Task.FromResult(bookinRoomStatusdto);
            }
            else
            {
                //not available
                var bookinRoomStatusdto1 = new bookinRoomStatusDTO
                { ReservationNo = "",
                    RoomId = 0,
                    status = "",
                    Rate = 0
                };
                return Task.FromResult(bookinRoomStatusdto1);
            }
        }
        //=====check consective rooms availibilty
        //    if (!roomAvailable)
        //{
        //    var query = (from r in _dbContext.TblRoomBookingMasters
        //                 where r.RoomTypeId == dTO.RoomTypeId
        //                 group r by r.RoomId into g
        //                 select new bookingDTOGroup
        //                 {
        //                     RoomId = Convert.ToInt32(g.Key),
        //                     total = g.Count()
        //                 }).ToList();
        //    if (query.Count() > 0)
        //    {
        //        var checkAvailibilty = query.Where(x => x.total >= noofdays).FirstOrDefault();
        //        if (checkAvailibilty != null)
        //        {
        //            int rmid = checkAvailibilty.RoomId;
        //        }
        //        if (checkAvailibilty == null)
        //        {
        //            var bookinRoomStatusdto = new bookinRoomStatusDTO
        //            {
        //                RoomId = 0,
        //                status = ""
        //            };
        //            return Task.FromResult(bookinRoomStatusdto);
        //        }
        //        else
        //        {
        //            var RoomStatusdto1 = roomBooking(dTO.RoomTypeId);

        //            return Task.FromResult(RoomStatusdto1);
        //        }
        //    }
        //    else
        //    {//if room booking not available in roombookingMaster
        //        var RoomStatusdto1 = roomBooking(dTO.RoomTypeId);
        //        return Task.FromResult(RoomStatusdto1);
        //    }
        //}
        //else
        //{//if room booking not available in roombookingMaster
        //    var RoomStatusdto1 = roomBooking(dTO.RoomTypeId);
        //    return Task.FromResult(RoomStatusdto1);
        //}




        bookinRoomStatusDTO roomBooking(int roomtypeId)
        {
            var roomdetails = (from t1 in _dbContext.TblRooms
                               join t2 in _dbContext.TblRoomTypeMasters on t1.RoomTypeId equals Convert.ToInt32(t2.RoomTypeId)
                               where t1.RoomTypeId == roomtypeId
                               select new bookinRoomStatusDTO
                               {
                                   RoomId = t1.RoomId,
                                   Rate = t2.Rate,
                                   status = "available",
                               }).FirstOrDefault();
            if (roomdetails != null)
            {
                return roomdetails;
            }
            else
            {
                var bookinRoomStatusdto = new bookinRoomStatusDTO
                {
                    RoomId = 0,
                    status = ""
                };
                return bookinRoomStatusdto;
            }
        }
        public IQueryable<TblRoomBookingMasterDTO> GetAllAsync(int id)
        {
            var query = from t1 in _dbContext.TblRoomBookingMasters
                        join t2 in _dbContext.TblRoomTypeMasters on t1.RoomId equals t2.RoomTypeId
                        where t1.LedgerId == id
                        select new TblRoomBookingMasterDTO
                        {
                            ReservationStatus = t1.ReservationStatus,
                            ReservationDate = t1.ReservationDate,
                            ReservationTime = t1.ReservationTime,
                            ArrivalDate = t1.ArrivalDate,
                            ArrivalTime = t1.ArrivalTime,
                            DepartureDate = t1.DepartureDate,
                            guests = Convert.ToInt32(t1.NoOfAdults + t1.NoOfChilds),
                            GrandTotal = t1.GrandTotal,
                            ReservationNo = t1.ReservationNo,
                            RoomTypeName = t2.RoomTypeName,
                            RoomId = t1.RoomId,
                            RoomTypeId = t1.RoomTypeId,
                            roomName = t1.roomName
                        };

            return query;
        }
        #region Variables
        bool GetDataOnBarcodeBasis = true;
        int discountTOAddInTotal = 0;
        int AssetAmountTobeSubstracted = 0;
        string TotalToSentInLedger = "0";
        string SubTotalToSentInLedger = "0";
        int financialYearId;
        decimal SubTotal; 
        decimal GrandTotal;
        decimal Balance;
        decimal Discount;
        decimal Taxes;
        decimal PaidAmount;
        int SeasonId;
        decimal ReservationId;
        string ReservationNo = "";
        string FolioNo = "";
        decimal ReservationValue;
        int spnNoOfHours = 0;
        int spnNoOfNights = 0;
        int spnNoOfMonths = 0;
        int spnNoOfChilds = 0;
        int spnNoOfAdults = 0;
        string StayType;
        decimal RoomCharges;

        TimeSpan ArrivalTime , ReservationTime, DepartureTime;
        decimal TaxRate = 0;
        decimal Finalrate = 0;

        Dictionary<string, string> dicForTaxes1 = new Dictionary<string, string>();
        Dictionary<string, string> dicForTaxes2 = new Dictionary<string, string>();
        Dictionary<string, string> dicForBill1 = new Dictionary<string, string>();
        Dictionary<string, string> dicForBill2 = new Dictionary<string, string>();
        string RoomName, RoomTypeName ,SeasonType, SeasonName = "";
        int seasonTypeId;

        decimal rateTypeId;string RateTypeName;
        decimal RoomTypeId;
        decimal ledgerId;
        string LedgerBalance;
        DateTime ReservationDate;

        #endregion
        static TimeSpan ConvertToTimeSpan(string timeString)
        {
            DateTime dateTime = DateTime.ParseExact(timeString, "h:mm tt", null);
            return dateTime.TimeOfDay;
        }
        private void ResetFunction( CheckoutDTO DTO)
        {
            LoadSeason(DTO.CheckIn);

            // for cash payment for now
            DTO.PaymentMethodId = 1;
            if (DTO.PaymentMethodId == 1)
            {
                Balance = DTO.GrandTotal;
            }
            DTO.StayType = "Days";
            DTO.ReservationStatus = "Check In";
            ledgerId = DTO.LedgerId;
            spnNoOfHours = 0;
            spnNoOfNights = Convert.ToInt32((DTO.CheckOut - DTO.CheckIn).Value.TotalDays);
            spnNoOfMonths = 0;
            spnNoOfChilds = 0;
            spnNoOfAdults = DTO.guests;
            financialYearId = 1;
            RoomTypeId = DTO.RoomTypeId;
            ReservationDate = DTO.ReservationDate;
            StayType = DTO.StayType;
            var dep_time= _dbContext.TblGeneralSettings.Select(s => s.DepartureTime).FirstOrDefault();
            DepartureTime = ConvertToTimeSpan(dep_time);
            ArrivalTime = ConvertToTimeSpan(DateTime.Now.ToShortTimeString());
            ReservationTime = ConvertToTimeSpan(DateTime.Now.ToShortTimeString());
            LoadRateType(DTO.StayType);
            CalculateLedgerBalance();
            LoadroomTypeName();
            DTO.RoomTypeName = RoomTypeName;
            LoadSerialNo();
                CalculateRoomTariff();
            CalculateSubTotal();



        }
        public async Task<string> checkout(CheckoutDTO DTO)
        {
            ResetFunction(DTO);
            bool isMasterInserted = await RoomBookingMasterInsertion(DTO);
            bool isScheduleDetailInserted = await RoomBookingScheduleDetailInsertion(DTO);
            bool isTimelineDetailInserted = await RoomBookingTimelineDetailInsertion(DTO);
            bool isLedgerPosted = await RoomBookingLedgerPosting(DTO);

            if (isMasterInserted && isScheduleDetailInserted && isTimelineDetailInserted && isLedgerPosted)
            {
                // All insertions were successful
                return "Successfully added.";
            }
            else
            {
                // At least one insertion failed
                return "Failed to add some entries.";
            }
        }

        private string MaxID_FormatedfourDigits(string idname)
        {
            return string.Format("{0000:0000}", Convert.ToDouble(idname));
        }

        private void LoadSerialNo()
        {

            ReservationId = _dbContext.TblRoomBookingMasters.Max(x => x.ReservationId) + 1;
            ReservationNo = "RB-" + (MaxID_FormatedfourDigits(ReservationId.ToString()).ToString());
            FolioNo = "F-" + MaxID_FormatedfourDigits(ReservationId.ToString()).ToString();
        }
        private void LoadroomTypeName()
        {

            var RoomTypeData = _dbContext.TblRoomTypeMasters.Where(x => x.RoomTypeId == RoomTypeId).FirstOrDefault();
            if (RoomTypeData != null)
            {
                RoomTypeName = RoomTypeData.RoomTypeName;
            }
            var RoomData = _dbContext.TblRooms.Where(x => x.RoomTypeId == RoomTypeId).FirstOrDefault();
            if (RoomData != null)
            {
                RoomName = RoomData.RoomName;
            }
            //DateTime reservationMonth = ReservationDate; // Set your desired reservation month here
            //var query = (from season in _dbContext.TblSeasons
            //             join seasonType in _dbContext.TblSeasonTypes on season.SeasonTypeId equals Convert.ToInt32(seasonType.SeasonTypeId)
            //             where reservationMonth >= season.StartDate && reservationMonth <= season.EndDate
            //             select new SeasonDTO
            //             {
            //                 SeasonID = season.SeasonId,
            //                 SeasonTypeId = season.SeasonTypeId,
            //                 SeasonType = seasonType.SeasonTypeName,
            //                 SeasonName = season.SeasonName
            //             }).FirstOrDefault();

            //if (query != null)
            //{
            //    seasonTypeId = Convert.ToInt32(query.SeasonTypeId);
            //    SeasonId = Convert.ToInt32(query.SeasonID);
            //    SeasonType = query.SeasonType;
            //    SeasonName = query.SeasonName;

            //}
        }
        private async Task<bool> RoomBookingMasterInsertion(CheckoutDTO dto)
        {
            TblRoomBookingMaster tblRoomBookingMaster = new TblRoomBookingMaster();
            //tbl_RoomBookingMaster.Operation = txtOperation .ToString();
            tblRoomBookingMaster.LedgerId = Convert.ToDecimal(dto.LedgerId);
            tblRoomBookingMaster.LedgerCode = Convert.ToDecimal(dto.LedgerCode);
            tblRoomBookingMaster.LedgerName = dto.LedgerName;
            tblRoomBookingMaster.FathersName = "";
            tblRoomBookingMaster.Cnic = "";
            tblRoomBookingMaster.Mobile = dto.Mobile;
            tblRoomBookingMaster.RoomTypeId = dto.RoomTypeId;
            tblRoomBookingMaster.RoomId = Convert.ToDecimal(dto.RoomId);
            tblRoomBookingMaster.RateTypeId = Convert.ToDecimal(rateTypeId);
            tblRoomBookingMaster.Shiftid =0 ;
            tblRoomBookingMaster.ShiftUserid = 0;
            tblRoomBookingMaster.SeasonId = SeasonId;
            tblRoomBookingMaster.ReservationStatus = dto.ReservationStatus;
            tblRoomBookingMaster.ReservationDate = dto.CheckIn;
            tblRoomBookingMaster.ReservationTime = ReservationTime;
            tblRoomBookingMaster.ReservationNo = ReservationNo;
            tblRoomBookingMaster.FolioNo = FolioNo;
            tblRoomBookingMaster.StayType = dto.StayType;
            tblRoomBookingMaster.NoOfHours = Convert.ToDecimal(spnNoOfHours);
            tblRoomBookingMaster.NoOfNights = Convert.ToDecimal(spnNoOfNights);
            tblRoomBookingMaster.NoOfMonths = Convert.ToDecimal(spnNoOfMonths);
            tblRoomBookingMaster.ArrivalDate = Convert.ToDateTime(dto.CheckIn);
            tblRoomBookingMaster.ArrivalTime = ArrivalTime;
            tblRoomBookingMaster.DepartureDate = Convert.ToDateTime(dto.DepartureDate);
            tblRoomBookingMaster.DepartureTime = DepartureTime;
            tblRoomBookingMaster.NoOfAdults = Convert.ToDecimal(dto.guests);
            tblRoomBookingMaster.NoOfChilds = 0;
            tblRoomBookingMaster.GuestRemarks = "";
            tblRoomBookingMaster.Reservation = "";
            tblRoomBookingMaster.CheckIn = "";
            tblRoomBookingMaster.CheckOut = "";
            tblRoomBookingMaster.Cancellation = "";
            tblRoomBookingMaster.HouseKeeping = "";
            tblRoomBookingMaster.EarlyCheckIn = "";
            tblRoomBookingMaster.EarlyCheckOut = "";
            tblRoomBookingMaster.SubTotal =SubTotal ;
            tblRoomBookingMaster.Discount = Discount;
            tblRoomBookingMaster.GrandTotal = GrandTotal;
            tblRoomBookingMaster.PaidAmount = dto.PaidAmount;
            tblRoomBookingMaster.PaymentMethodId = dto.PaymentMethodId;
            tblRoomBookingMaster.SalesmanId = dto.SalesmanId;
            tblRoomBookingMaster.CityId = dto.CityId;
            tblRoomBookingMaster.ReservationId = Convert.ToDecimal(ReservationId);
            try
            {
                await _repository.AddAsync(tblRoomBookingMaster);
                return true; // Return true if insertion is successful
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                return false; // Return false if insertion fails
            }

        }
        private Decimal LoadReservationValue(CheckoutDTO dto)
        {
            Decimal ReservationValue = 0;
            if (dto.StayType != null)
            {
                if (dto.StayType != "")
                {
                    if (dto.StayType == "Hours")
                    {
                        ReservationValue = Convert.ToDecimal(spnNoOfHours);
                    }
                    else if (dto.StayType == "Days")
                    {
                        ReservationValue = Convert.ToDecimal(spnNoOfNights);
                    }
                    else if (dto.StayType == "Months")
                    {
                        ReservationValue = Convert.ToDecimal(spnNoOfMonths);
                    }
                }
            }
            return ReservationValue;
        }
        public async Task<List<proc_LoadRoomTariff>> LoadReservationSeasonAsync()
        {
            //for testing
            string roomTypeId = "2"; string rateTypeId = "2"; string tariffType = "WeekDayRates"; //string seasonId = "2";

            var parameters = new[]
      {
            new SqlParameter("@RoomTypeID", roomTypeId),
            new SqlParameter("@RateTypeID", rateTypeId),
            new SqlParameter("@TariffType", tariffType),
            new SqlParameter("@SeasonID", SeasonId)
        };
            var results = _dbContext.proc_LoadRoomTariff.FromSqlRaw("proc_LoadRoomTariff @RoomTypeID, @RateTypeID, @TariffType, @SeasonID", parameters)
            .AsEnumerable()
            .ToList();

            return results;
        }
        private void CalculateRoomTariff()
        {  
            var parameters = new[]
              {
                new SqlParameter("@RoomTypeID", RoomTypeId),
                new SqlParameter("@RateTypeID", rateTypeId),
                new SqlParameter("@TariffType", "WeekDayRates"),
                 new SqlParameter("@SeasonID", SeasonId)
               };
                var WeekDaysRoomTariff = _dbContext.proc_LoadRoomTariff.FromSqlRaw("proc_LoadRoomTariff @RoomTypeID, @RateTypeID, @TariffType, @SeasonID", parameters)
                .AsEnumerable().FirstOrDefault();
                if (WeekDaysRoomTariff != null)
                {
                    ExactRoomTariff(WeekDaysRoomTariff.Tariff,Convert.ToDecimal( WeekDaysRoomTariff.BaseChild), Convert.ToDecimal(WeekDaysRoomTariff.BaseAdult), Convert.ToDecimal(WeekDaysRoomTariff.ExtraChild), Convert.ToDecimal(WeekDaysRoomTariff.ExtraAdult));
                }
        }
        private void LoadSeason(DateTime checkin)
        {
            string ReservationMonth = Convert.ToDateTime(checkin).ToShortDateString();
            var parameters = new[]
              {
                new SqlParameter("@ReservationMonth", ReservationMonth),

               };
            var seasondata = _dbContext.Proc_LoadReservationSeason.FromSqlRaw("Proc_LoadReservationSeason @ReservationMonth", parameters)
            .AsEnumerable().FirstOrDefault();
            if (seasondata != null)
            {
                SeasonId = Convert.ToInt32(seasondata.SeasonID);
            }
        }
        public decimal GetLedgerBalance(string id)
        {
            var balance = _dbContext.proc_customSupplierbalance
        .FromSqlRaw("EXEC dbo.proc_customSupplierbalance @id", new SqlParameter("@id", id))
        .AsEnumerable() // Execute the SQL query and bring data into memory
        .Select(s => s.Balance) // Project to retrieve the balance
        .FirstOrDefault();

            return balance;
        }
        private void CalculateLedgerBalance()
        {
            var val = GetLedgerBalance(ledgerId.ToString());
                    if (val >0)
                            {
                                if (val.ToString() != "")
                                {
                                    double abc = Math.Round(Convert.ToDouble(val.ToString()), 2);
                                    string abcd = "";
                                    if (abc < 0)
                                    {
                                        double myNegInt = abc * -1;
                                        abcd = myNegInt + "Cr";
                                    }
                                    else
                                    {
                                        abcd = abc + "Dr";
                                    }
                                      LedgerBalance = abcd;
                                }
                                else
                                {
                                 LedgerBalance = "0";
                                }
                            }
                            else
                            {
                                LedgerBalance = "0";
                            }
                
        }
        private void LoadRateType(string PlanType)
        {
                var RateTypeData = _dbContext.TblRateTypes.Where(x=>x.PlanType==PlanType).FirstOrDefault();
                if (RateTypeData!=null)
                {
                    rateTypeId = RateTypeData.RateTypeId;
                    RateTypeName = RateTypeData.RateTypeName;
                }
            
        }
        private void ExactRoomTariff(decimal RoomTariff, decimal Child, decimal Adult, decimal ExtraChildCharges, decimal ExtraAdultCharges)
        {
            decimal extraAdult, extrachild;
                if (StayType!= null)
                {
                    if (StayType!= "")
                    {
                        if (StayType== "Hours")
                        {
                            RoomTariff = RoomTariff * Convert.ToDecimal(spnNoOfHours );
                            //ExtraCharges
                            if (Convert.ToDecimal(spnNoOfChilds  ) > Child)
                            {
                                extrachild = Convert.ToDecimal(spnNoOfChilds ) - Child;

                                RoomTariff = RoomTariff + (ExtraChildCharges * extrachild);
                            }
                            if (Convert.ToDecimal(spnNoOfAdults ) > Adult)
                            {
                                extraAdult = Convert.ToDecimal(spnNoOfAdults ) - Adult;
                                RoomTariff = RoomTariff + (ExtraAdultCharges * extraAdult);
                            }
                        //
                        RoomCharges = RoomTariff;
                        }
                        else if (StayType == "Days")
                        {
                            RoomTariff = RoomTariff * Convert.ToDecimal(spnNoOfNights );
                            //ExtraCharges
                            if (Convert.ToDecimal(spnNoOfChilds ) > Child)
                            {
                                extrachild = Convert.ToDecimal(spnNoOfChilds ) - Child;

                                RoomTariff = RoomTariff + (ExtraChildCharges * extrachild);
                            }
                            if (Convert.ToDecimal(spnNoOfAdults ) > Adult)
                            {
                                extraAdult = Convert.ToDecimal(spnNoOfAdults ) - Adult;
                                RoomTariff = RoomTariff + (ExtraAdultCharges * extraAdult);
                            }
                            //
                            RoomCharges  = RoomTariff;
                        }

                        else if (StayType == "Months")
                        {
                            RoomTariff = RoomTariff * Convert.ToDecimal(spnNoOfMonths );
                            //ExtraCharges
                            if (Convert.ToDecimal(spnNoOfChilds ) > Child)
                            {
                                extrachild = Convert.ToDecimal(spnNoOfChilds ) - Child;

                                RoomTariff = RoomTariff + (ExtraChildCharges * extrachild);
                            }
                            if (Convert.ToDecimal(spnNoOfAdults ) > Adult)
                            {
                                extraAdult = Convert.ToDecimal(spnNoOfAdults ) - Adult;
                                RoomTariff = RoomTariff + (ExtraAdultCharges * extraAdult);
                            }
                            //
                            RoomCharges  = RoomTariff;
                        }

                    }
                }
          
        }
        private void CalculateBillTax()
        {
                if (GetDataOnBarcodeBasis == true)
                {
                    if (SubTotal != null)
                    {
                        if (SubTotal.ToString() != "")
                        {
                            decimal total_amount = Convert.ToDecimal(SubTotal);
                            dicForBill2.Clear();
                            Finalrate = 0;
                            foreach (KeyValuePair<string, string> kvp in dicForBill1)
                            {
                                if (total_amount > 0)
                                {
                                    decimal per = Convert.ToDecimal(kvp.Value);

                                    Finalrate = Math.Round(Finalrate + (per / 100) * Convert.ToDecimal(total_amount), 2);
                                    dicForBill2.Add(kvp.Key, Finalrate.ToString());
                                }
                                else if (total_amount == 0)
                                {
                                    Finalrate = 0;
                                    dicForBill2.Add(kvp.Key, Finalrate.ToString());
                                }
                            }
                            //foreach (KeyValuePair<string, string> kvp1 in dicForBill2)
                            //{
                            //    for (int k = 0; k < grdTaxes.Rows.Count; k++)
                            //    {
                            //        if (grdTaxes.Rows[k].Cells[1].Value.ToString() == kvp1.Key)
                            //        {
                            //            grdTaxes.Rows[k].Cells[3].Value = kvp1.Value;
                            //            break;
                            //        }
                            //    }
                            //}
                        }
                    }
                }
         
        }
        private void TotalTaxCalculation()
        {
            //try
            //{
            //    decimal totaltax = 0;
            //    for (int i = 0; i < grdTaxes.Rows.Count; i++)
            //    {
            //        totaltax = Math.Round(totaltax + Convert.ToDecimal(grdTaxes.Rows[i].Cells[3].Value), 2);
            //    }
            //    txtTaxes.Text = Math.Round(totaltax, 2).ToString();
            //}
            //catch (Exception ex)
            //{

            //    obj_msg.SingleMessageDetails(cls_Common.SomethingWentWrongMessage.ToString(), ex.Message);
            //}

        }
        private void CalculateSubTotal()
        {
          
                SubTotal = 0;
                if (RoomCharges.ToString() != "")
                {
                    SubTotal = Convert.ToDecimal(RoomCharges);
                }
                CalculateBillTax();
                TotalTaxCalculation();
                //if (Taxes != null)
                //{
                //    if (Taxes != "")
                //    {
                //        Taxes = Convert.ToDecimal(Taxes);
                //    }
                //}
                //decimal CancellationFee = TotalCancellationFee();
                //if (CancellationFee != 0)
                //{
                //    RoomCharges = CancellationFee.ToString();
                //    SubTotal = SubTotal + Taxes - CancellationFee;
                //}
                SubTotal = SubTotal + Taxes;
                GrandTotal= SubTotal;
                Balance= SubTotal;
            }
        private string GetLedgerIdBasedOnPM(decimal UOMId)
        {
            string id = "1";

            var dt4 = _dbContext.TblPaymentMethodMappings.Where(x => x.PaymentMethodId == UOMId).FirstOrDefault();
            if (dt4 != null)
            {
                id = (dt4.LedgerId).ToString();
            }
            return id;
        }
        string ShortDateTime(DateTime date, TimeSpan time)
        {
            DateTime dateTime = DateTime.Today.Add(time);

            string strigDateTime = Convert.ToDateTime(date).ToShortDateString() + " " + dateTime.ToShortTimeString();   
            return strigDateTime;
        }
        private async Task<bool> RoomBookingScheduleDetailInsertion(CheckoutDTO dto)
        {
            Int32 NoOfDays = LoadCaclulatedDays();
            spnNoOfNights = Convert.ToInt32(NoOfDays);
            ReservationValue = LoadReservationValue(dto);
            try
            {
                for (int i = 0; i < NoOfDays; i++)
                {
                    DateTime ShcheduleStartDate = Convert.ToDateTime(dto.ArrivalDate);
                    TblRoomBookingScheduleDetail tbl_RoomBookingScheduleDetails = new TblRoomBookingScheduleDetail();
                    //  decimal ScheduleDetailId = _dbContext.TblRoomBookingCancelScheduleDetails.Max(x => x.ScheduleDetailId) + 1;
                    tbl_RoomBookingScheduleDetails.ReservationId = Convert.ToDecimal(ReservationId);
                    tbl_RoomBookingScheduleDetails.ReservationType = dto.StayType;
                    tbl_RoomBookingScheduleDetails.ReservationValue = ReservationValue;
                    tbl_RoomBookingScheduleDetails.ReservationStatus = dto.ReservationStatus;
                    tbl_RoomBookingScheduleDetails.ReservationDate = ShortDateTime(dto.CheckIn, ReservationTime);
                    tbl_RoomBookingScheduleDetails.ScheduleStartDate = ShortDateTime(dto.CheckIn, ArrivalTime);
                    tbl_RoomBookingScheduleDetails.ScheduleEndDate = ShortDateTime(dto.DepartureDate, DepartureTime);
                    tbl_RoomBookingScheduleDetails.ScheduleDate = Convert.ToDateTime(ShcheduleStartDate.AddDays(i));
                    tbl_RoomBookingScheduleDetails.RoomId = Convert.ToDecimal(dto.RoomId);
                    decimal id = _dbContext.TblRoomBookingScheduleDetails.Max(x => x.ScheduleDetailId);
                    tbl_RoomBookingScheduleDetails.ScheduleDetailId = id + 1;
                    await _rep_RoomBookingScheduleDetail.AddAsync(tbl_RoomBookingScheduleDetails);
                }
                return true; // All insertions succeeded
            }
            catch (Exception ex)
            {
                // Handle exception if any insert fails
                // Log the exception for troubleshooting if needed
                return false;
            }

        }
        private async Task<bool> RoomBookingLedgerPosting(CheckoutDTO dto)
        {
            try
            {
                TblLedgerPosting infoLedgerPosting = new TblLedgerPosting();
                discountTOAddInTotal = 0;
                AssetAmountTobeSubstracted = 0;
                if (GrandTotal != null)
                {
                    if (Convert.ToDecimal(GrandTotal) > 0)
                    {
                        TotalToSentInLedger = GrandTotal.ToString();
                        SubTotalToSentInLedger = Convert.ToDecimal(SubTotal).ToString();
                        if (AssetAmountTobeSubstracted > 0)
                        {
                            SubTotalToSentInLedger = (Convert.ToDecimal(SubTotalToSentInLedger) - AssetAmountTobeSubstracted).ToString();
                        }
                        SubTotalToSentInLedger = (Convert.ToDecimal(SubTotalToSentInLedger) + discountTOAddInTotal).ToString();
                    }
                }
                decimal LedgerPostingId = 0;
                if (Convert.ToDecimal(Balance) == 0)
                {
                    //When Sold goods fully on cash basis
                    //Customer to Room Booking AC Entry

                    decimal decimalGrantTotal = 0;
                    LedgerPostingId = _dbContext.TblLedgerPostings.Max(x => x.LedgerPostingId);
                    infoLedgerPosting.LedgerPostingId = LedgerPostingId + 1;
                    decimalGrantTotal = Convert.ToDecimal(TotalToSentInLedger);
                    infoLedgerPosting.Debit = decimalGrantTotal;
                    infoLedgerPosting.Credit = 0;
                    infoLedgerPosting.Date = Convert.ToDateTime(dto.ReservationDate);
                    infoLedgerPosting.VoucherTypeId = Convert.ToDecimal(37);
                    infoLedgerPosting.InvoiceNo = ReservationNo;
                    infoLedgerPosting.VoucherNo = ReservationNo;
                    infoLedgerPosting.LedgerId = Convert.ToDecimal(dto.LedgerId);
                    infoLedgerPosting.YearId = Convert.ToDecimal(financialYearId);
                    infoLedgerPosting.DetailsId = 0;
                    infoLedgerPosting.ChequeNo = string.Empty;
                    infoLedgerPosting.ChequeDate = DateTime.Now;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    infoLedgerPosting.SalesmanId = dto.SalesmanId;
                    await _rep_TblLedgerPosting.AddAsync(infoLedgerPosting);


                    infoLedgerPosting.Debit = 0;
                    infoLedgerPosting.Credit = Convert.ToDecimal(SubTotalToSentInLedger);
                    infoLedgerPosting.Date = Convert.ToDateTime(dto.ReservationDate);
                    infoLedgerPosting.VoucherTypeId = Convert.ToDecimal(37);
                    infoLedgerPosting.InvoiceNo = ReservationNo;
                    infoLedgerPosting.VoucherNo = ReservationNo;
                    infoLedgerPosting.LedgerId = 27;
                    infoLedgerPosting.YearId = Convert.ToDecimal(financialYearId);
                    infoLedgerPosting.DetailsId = 0;
                    infoLedgerPosting.ChequeNo = string.Empty;
                    infoLedgerPosting.ChequeDate = DateTime.Now;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    infoLedgerPosting.SalesmanId = dto.SalesmanId;
                    LedgerPostingId = _dbContext.TblLedgerPostings.Max(x => x.LedgerPostingId);
                    infoLedgerPosting.LedgerPostingId = LedgerPostingId + 1;
                    await _rep_TblLedgerPosting.AddAsync(infoLedgerPosting);

                    if (dto.LedgerId != 1)
                    {
                        //Cash to Customer Entry
                        decimalGrantTotal = Convert.ToDecimal(TotalToSentInLedger);
                        infoLedgerPosting.Debit = 0;
                        infoLedgerPosting.Credit = decimalGrantTotal;
                        infoLedgerPosting.Date = Convert.ToDateTime(dto.ReservationDate);
                        infoLedgerPosting.VoucherTypeId = Convert.ToDecimal(37);
                        infoLedgerPosting.InvoiceNo = ReservationNo;
                        infoLedgerPosting.VoucherNo = ReservationNo;
                        infoLedgerPosting.LedgerId = Convert.ToDecimal(dto.LedgerId);
                        infoLedgerPosting.YearId = Convert.ToDecimal(financialYearId);
                        infoLedgerPosting.DetailsId = 0;
                        infoLedgerPosting.ChequeNo = string.Empty;
                        infoLedgerPosting.ChequeDate = DateTime.Now;
                        infoLedgerPosting.Extra1 = string.Empty;
                        infoLedgerPosting.Extra2 = string.Empty;
                        infoLedgerPosting.SalesmanId = dto.SalesmanId; LedgerPostingId = _dbContext.TblLedgerPostings.Max(x => x.LedgerPostingId);
                        infoLedgerPosting.LedgerPostingId = LedgerPostingId + 1;
                        await _rep_TblLedgerPosting.AddAsync(infoLedgerPosting);

                        infoLedgerPosting.Debit = Convert.ToDecimal(TotalToSentInLedger);
                        infoLedgerPosting.Credit = 0;
                        infoLedgerPosting.Date = Convert.ToDateTime(dto.ReservationDate);
                        infoLedgerPosting.VoucherTypeId = Convert.ToDecimal(37);
                        infoLedgerPosting.InvoiceNo = ReservationNo;
                        infoLedgerPosting.VoucherNo = ReservationNo;
                        infoLedgerPosting.LedgerId = infoLedgerPosting.LedgerId = Convert.ToDecimal(GetLedgerIdBasedOnPM(dto.PaymentMethodId)); //Cash Given by customer to us
                        infoLedgerPosting.YearId = Convert.ToDecimal(financialYearId);
                        infoLedgerPosting.DetailsId = 0;
                        infoLedgerPosting.ChequeNo = string.Empty;
                        infoLedgerPosting.ChequeDate = DateTime.Now;
                        infoLedgerPosting.Extra1 = string.Empty;
                        infoLedgerPosting.Extra2 = string.Empty;
                        LedgerPostingId = _dbContext.TblLedgerPostings.Max(x => x.LedgerPostingId);
                        infoLedgerPosting.LedgerPostingId = LedgerPostingId + 1; infoLedgerPosting.LedgerPostingId = _dbContext.TblLedgerPostings.Max(x => x.LedgerPostingId) + 1;
                        await _rep_TblLedgerPosting.AddAsync(infoLedgerPosting);
                    }
                }
                if (Convert.ToDecimal(Balance) == Convert.ToDecimal(TotalToSentInLedger))
                {
                    //When Sold goods fully on Credit basis
                    //Customer to Room Reservation Ac Entry 
                    decimal decimalGrantTotal = 0;
                    decimalGrantTotal = Convert.ToDecimal(TotalToSentInLedger);
                    infoLedgerPosting.Debit = decimalGrantTotal;
                    infoLedgerPosting.Credit = 0;
                    infoLedgerPosting.Date = Convert.ToDateTime(dto.ReservationDate);
                    infoLedgerPosting.VoucherTypeId = Convert.ToDecimal(37);
                    infoLedgerPosting.InvoiceNo = ReservationNo;
                    infoLedgerPosting.VoucherNo = ReservationNo;
                    infoLedgerPosting.LedgerId = Convert.ToDecimal(dto.LedgerId);
                    infoLedgerPosting.YearId = Convert.ToDecimal(financialYearId);
                    infoLedgerPosting.DetailsId = 0;
                    infoLedgerPosting.ChequeNo = string.Empty;
                    infoLedgerPosting.ChequeDate = DateTime.Now;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    infoLedgerPosting.SalesmanId = dto.SalesmanId;
                    LedgerPostingId = _dbContext.TblLedgerPostings.Max(x => x.LedgerPostingId);
                    infoLedgerPosting.LedgerPostingId = LedgerPostingId + 1; await _rep_TblLedgerPosting.AddAsync(infoLedgerPosting);

                    infoLedgerPosting.Debit = 0;
                    infoLedgerPosting.Credit = Convert.ToDecimal(SubTotalToSentInLedger);
                    infoLedgerPosting.Date = Convert.ToDateTime(dto.ReservationDate);
                    infoLedgerPosting.VoucherTypeId = Convert.ToDecimal(37);
                    infoLedgerPosting.InvoiceNo = ReservationNo;
                    infoLedgerPosting.VoucherNo = ReservationNo;
                    infoLedgerPosting.LedgerId = 27;
                    infoLedgerPosting.YearId = Convert.ToDecimal(financialYearId);
                    infoLedgerPosting.DetailsId = 0;
                    infoLedgerPosting.ChequeNo = string.Empty;
                    infoLedgerPosting.ChequeDate = DateTime.Now;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    infoLedgerPosting.SalesmanId = dto.SalesmanId;
                    LedgerPostingId = _dbContext.TblLedgerPostings.Max(x => x.LedgerPostingId);
                    infoLedgerPosting.LedgerPostingId = LedgerPostingId + 1;
                    await _rep_TblLedgerPosting.AddAsync(infoLedgerPosting);
                }

                if (Convert.ToDecimal(PaidAmount) > 0 && Convert.ToDecimal(Balance) > 0)
                {
                    //When Sold goods half on Credit and half on cash basis
                    //Customer to Room Reservation Ac Entry

                    decimal decimalGrantTotal = 0;
                    decimalGrantTotal = Convert.ToDecimal(TotalToSentInLedger);
                    infoLedgerPosting.Debit = decimalGrantTotal;
                    infoLedgerPosting.Credit = 0;
                    infoLedgerPosting.Date = Convert.ToDateTime(dto.ReservationDate);
                    infoLedgerPosting.VoucherTypeId = Convert.ToDecimal(37);
                    infoLedgerPosting.InvoiceNo = ReservationNo;
                    infoLedgerPosting.VoucherNo = ReservationNo;
                    infoLedgerPosting.LedgerId = Convert.ToDecimal(dto.LedgerId);
                    infoLedgerPosting.YearId = Convert.ToDecimal(financialYearId);
                    infoLedgerPosting.DetailsId = 0;
                    infoLedgerPosting.ChequeNo = string.Empty;
                    infoLedgerPosting.ChequeDate = DateTime.Now;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    infoLedgerPosting.SalesmanId = dto.SalesmanId;
                    LedgerPostingId = _dbContext.TblLedgerPostings.Max(x => x.LedgerPostingId);
                    infoLedgerPosting.LedgerPostingId = LedgerPostingId + 1;
                    await _rep_TblLedgerPosting.AddAsync(infoLedgerPosting);

                    infoLedgerPosting.Debit = 0;
                    infoLedgerPosting.Credit = Convert.ToDecimal(SubTotalToSentInLedger);
                    infoLedgerPosting.Date = Convert.ToDateTime(dto.ReservationDate);
                    infoLedgerPosting.VoucherTypeId = Convert.ToDecimal(37);
                    infoLedgerPosting.InvoiceNo = ReservationNo;
                    infoLedgerPosting.VoucherNo = ReservationNo;
                    infoLedgerPosting.LedgerId = 27;
                    infoLedgerPosting.YearId = Convert.ToDecimal(financialYearId);
                    infoLedgerPosting.DetailsId = 0;
                    infoLedgerPosting.ChequeNo = string.Empty;
                    infoLedgerPosting.ChequeDate = DateTime.Now;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    infoLedgerPosting.SalesmanId = dto.SalesmanId;
                    LedgerPostingId = _dbContext.TblLedgerPostings.Max(x => x.LedgerPostingId);
                    infoLedgerPosting.LedgerPostingId = LedgerPostingId + 1;
                    await _rep_TblLedgerPosting.AddAsync(infoLedgerPosting);

                    //Cash to Customer Entry
                    decimalGrantTotal = Convert.ToDecimal(PaidAmount);
                    infoLedgerPosting.Debit = 0;
                    infoLedgerPosting.Credit = decimalGrantTotal;
                    infoLedgerPosting.Date = Convert.ToDateTime(dto.ReservationDate);
                    infoLedgerPosting.VoucherTypeId = Convert.ToDecimal(37);
                    infoLedgerPosting.InvoiceNo = ReservationNo;
                    infoLedgerPosting.VoucherNo = ReservationNo;
                    infoLedgerPosting.LedgerId = Convert.ToDecimal(dto.LedgerId);
                    infoLedgerPosting.YearId = Convert.ToDecimal(financialYearId);
                    infoLedgerPosting.DetailsId = 0;
                    infoLedgerPosting.ChequeNo = string.Empty;
                    infoLedgerPosting.ChequeDate = DateTime.Now;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    infoLedgerPosting.SalesmanId = dto.SalesmanId;
                    LedgerPostingId = _dbContext.TblLedgerPostings.Max(x => x.LedgerPostingId);
                    infoLedgerPosting.LedgerPostingId = LedgerPostingId + 1;

                    await _rep_TblLedgerPosting.AddAsync(infoLedgerPosting);


                    infoLedgerPosting.Debit = Convert.ToDecimal(PaidAmount);
                    infoLedgerPosting.Credit = 0;
                    infoLedgerPosting.Date = Convert.ToDateTime(dto.ReservationDate);
                    infoLedgerPosting.VoucherTypeId = Convert.ToDecimal(37);
                    infoLedgerPosting.InvoiceNo = ReservationNo;
                    infoLedgerPosting.VoucherNo = ReservationNo;
                    infoLedgerPosting.LedgerId = Convert.ToDecimal(GetLedgerIdBasedOnPM(dto.PaymentMethodId));
                    infoLedgerPosting.YearId = Convert.ToDecimal(financialYearId);
                    infoLedgerPosting.DetailsId = 0;
                    infoLedgerPosting.ChequeNo = string.Empty;
                    infoLedgerPosting.ChequeDate = DateTime.Now;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    infoLedgerPosting.SalesmanId = dto.SalesmanId;
                    LedgerPostingId = _dbContext.TblLedgerPostings.Max(x => x.LedgerPostingId);
                    infoLedgerPosting.LedgerPostingId = LedgerPostingId + 1;

                    await _rep_TblLedgerPosting.AddAsync(infoLedgerPosting);
                }

                if (Convert.ToDecimal(PaidAmount) > 0 && Convert.ToDecimal(Balance) < 0)
                {
                    //When customer gave excess cash so it would be Credit to his account
                    //Customer to Room Booking Ac Entry

                    decimal decimalGrantTotal = 0;
                    decimalGrantTotal = Convert.ToDecimal(TotalToSentInLedger);
                    infoLedgerPosting.Debit = decimalGrantTotal;
                    infoLedgerPosting.Credit = 0;
                    infoLedgerPosting.Date = Convert.ToDateTime(dto.ReservationDate);
                    infoLedgerPosting.VoucherTypeId = Convert.ToDecimal(37);
                    infoLedgerPosting.InvoiceNo = ReservationNo;
                    infoLedgerPosting.VoucherNo = ReservationNo;
                    infoLedgerPosting.LedgerId = Convert.ToDecimal(dto.LedgerId);
                    infoLedgerPosting.YearId = Convert.ToDecimal(financialYearId);
                    infoLedgerPosting.DetailsId = 0;
                    infoLedgerPosting.ChequeNo = string.Empty;
                    infoLedgerPosting.ChequeDate = DateTime.Now;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    infoLedgerPosting.SalesmanId = dto.SalesmanId;
                    LedgerPostingId = _dbContext.TblLedgerPostings.Max(x => x.LedgerPostingId);
                    infoLedgerPosting.LedgerPostingId = LedgerPostingId + 1;

                    await _rep_TblLedgerPosting.AddAsync(infoLedgerPosting);

                    infoLedgerPosting.Debit = 0;
                    infoLedgerPosting.Credit = Convert.ToDecimal(SubTotalToSentInLedger);
                    infoLedgerPosting.Date = Convert.ToDateTime(dto.ReservationDate);
                    infoLedgerPosting.VoucherTypeId = Convert.ToDecimal(37);
                    infoLedgerPosting.InvoiceNo = ReservationNo;
                    infoLedgerPosting.VoucherNo = ReservationNo;
                    infoLedgerPosting.LedgerId = 27;
                    infoLedgerPosting.YearId = Convert.ToDecimal(financialYearId);
                    infoLedgerPosting.DetailsId = 0;
                    infoLedgerPosting.ChequeNo = string.Empty;
                    infoLedgerPosting.ChequeDate = DateTime.Now;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    infoLedgerPosting.SalesmanId = dto.SalesmanId;
                    LedgerPostingId = _dbContext.TblLedgerPostings.Max(x => x.LedgerPostingId);
                    infoLedgerPosting.LedgerPostingId = LedgerPostingId + 1;

                    await _rep_TblLedgerPosting.AddAsync(infoLedgerPosting);

                    //Cash to Customer Entry
                    decimalGrantTotal = Convert.ToDecimal(PaidAmount);
                    infoLedgerPosting.Debit = 0;
                    infoLedgerPosting.Credit = decimalGrantTotal;
                    infoLedgerPosting.Date = Convert.ToDateTime(dto.ReservationDate);
                    infoLedgerPosting.VoucherTypeId = Convert.ToDecimal(37);
                    infoLedgerPosting.InvoiceNo = ReservationNo;
                    infoLedgerPosting.VoucherNo = ReservationNo;
                    infoLedgerPosting.LedgerId = Convert.ToDecimal(dto.LedgerId);
                    infoLedgerPosting.YearId = Convert.ToDecimal(financialYearId);
                    infoLedgerPosting.DetailsId = 0;
                    infoLedgerPosting.ChequeNo = string.Empty;
                    infoLedgerPosting.ChequeDate = DateTime.Now;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    infoLedgerPosting.SalesmanId = dto.SalesmanId;
                    LedgerPostingId = _dbContext.TblLedgerPostings.Max(x => x.LedgerPostingId);
                    infoLedgerPosting.LedgerPostingId = LedgerPostingId + 1;

                    await _rep_TblLedgerPosting.AddAsync(infoLedgerPosting);

                    infoLedgerPosting.Debit = Convert.ToDecimal(PaidAmount);
                    infoLedgerPosting.Credit = 0;
                    infoLedgerPosting.Date = Convert.ToDateTime(dto.ReservationDate);
                    infoLedgerPosting.VoucherTypeId = Convert.ToDecimal(37);
                    infoLedgerPosting.InvoiceNo = ReservationNo;
                    infoLedgerPosting.VoucherNo = ReservationNo;
                    infoLedgerPosting.LedgerId = 1;
                    infoLedgerPosting.YearId = Convert.ToDecimal(financialYearId);
                    infoLedgerPosting.DetailsId = 0;
                    infoLedgerPosting.ChequeNo = string.Empty;
                    infoLedgerPosting.ChequeDate = DateTime.Now;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    infoLedgerPosting.SalesmanId = dto.SalesmanId;
                    LedgerPostingId = _dbContext.TblLedgerPostings.Max(x => x.LedgerPostingId);
                    infoLedgerPosting.LedgerPostingId = LedgerPostingId + 1;

                    await _rep_TblLedgerPosting.AddAsync(infoLedgerPosting);
                }
                //Discount Allowed Entry
                decimal decBillDis = 0;
                decBillDis = Convert.ToDecimal(Discount);
                if (decBillDis > 0)
                {
                    infoLedgerPosting.Debit = decBillDis;
                    infoLedgerPosting.Credit = 0;
                    infoLedgerPosting.Date = Convert.ToDateTime(dto.ReservationDate);
                    infoLedgerPosting.VoucherTypeId = Convert.ToDecimal(37);
                    infoLedgerPosting.InvoiceNo = ReservationNo;
                    infoLedgerPosting.VoucherNo = ReservationNo;
                    infoLedgerPosting.LedgerId = 8;
                    infoLedgerPosting.YearId = Convert.ToDecimal(financialYearId);
                    infoLedgerPosting.DetailsId = 0;
                    infoLedgerPosting.ChequeNo = string.Empty;
                    infoLedgerPosting.ChequeDate = DateTime.Now;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    infoLedgerPosting.SalesmanId = dto.SalesmanId;
                    LedgerPostingId = _dbContext.TblLedgerPostings.Max(x => x.LedgerPostingId);
                    infoLedgerPosting.LedgerPostingId = LedgerPostingId + 1;
                    await _rep_TblLedgerPosting.AddAsync(infoLedgerPosting);
                }
                //Tax Entry
                //foreach (DataGridViewRow dgvrow in grdTaxes.Rows)
                //{
                //    if (dgvrow.Cells["grdTaxId"].Value != null && dgvrow.Cells["grdTaxId"].Value.ToString() != string.Empty)
                //    {
                //        decimal decTaxAmount = 0;
                //        if (dgvrow.Cells["grdTaxAmount"].Value != null)
                //        {
                //            if (dgvrow.Cells["grdTaxAmount"].Value.ToString() != "")
                //            {
                //                decTaxAmount = Convert.ToDecimal(dgvrow.Cells["grdTaxAmount"].Value.ToString());
                //                if (decTaxAmount > 0)
                //                {
                //                    infoLedgerPosting.Debit = 0;
                //                    infoLedgerPosting.Credit = decTaxAmount;
                //                    infoLedgerPosting.Date = Convert.ToDateTime(ReservationDate);
                //                    infoLedgerPosting.VoucherTypeId = 37;
                //                    infoLedgerPosting.InvoiceNo = ReservationNo;
                //                    infoLedgerPosting.VoucherNo = ReservationNo;
                //                    infoLedgerPosting.LedgerId = Convert.ToDecimal(dgvrow.Cells["grdTaxLedgerId"].Value.ToString());
                //                    infoLedgerPosting.YearId = Convert.ToDecimal(financialYearId);
                //                    infoLedgerPosting.DetailsId = 0;
                //                    infoLedgerPosting.ChequeNo = string.Empty;
                //                    infoLedgerPosting.ChequeDate = DateTime.Now;
                //                    infoLedgerPosting.Extra1 = string.Empty;
                //                    infoLedgerPosting.Extra2 = string.Empty;
                //                    infoLedgerPosting.SalesmanId = SalesmanId;
                //                    infoLedgerPosting.LedgerPostingId = _dbContext.TblLedgerPostings.Max(x => x.LedgerPostingId) + 1;
                //                    await _rep_TblLedgerPosting.AddAsync(infoLedgerPosting);

                //                }

                //            }
                //        }
                //    }
                //}
                return true; // Indicate success
            }
            catch (Exception ex)
            {
                // Handle exception if insertion fails
                // You may log the exception details here
                return false; // Indicate failure
            }
        }
        private async Task<bool> RoomBookingTimelineDetailInsertion(CheckoutDTO dto)
        {
            try
            {
                discountTOAddInTotal = 0;
                 AssetAmountTobeSubstracted = 0;
                if (GrandTotal != null)
                {
                    if (Convert.ToDecimal(GrandTotal) > 0)
                    {
                        TotalToSentInLedger = GrandTotal.ToString();
                        SubTotalToSentInLedger = Convert.ToDecimal(GrandTotal).ToString();
                        if (AssetAmountTobeSubstracted > 0)
                        {
                            SubTotalToSentInLedger = (Convert.ToDecimal(SubTotalToSentInLedger) - AssetAmountTobeSubstracted).ToString();
                        }
                        SubTotalToSentInLedger = ((Convert.ToDecimal(SubTotalToSentInLedger) + discountTOAddInTotal)).ToString();
                    }
                }
                TblRoomBookingTimelineDetail TblRoomBookingTimelineDetail = new TblRoomBookingTimelineDetail();
                if (Convert.ToDecimal(GrandTotal ) == 0)
                {
                    //When Sold goods fully on cash basis
                    //Customer to Room Booking AC Entry
                    decimal decimalGrantTotal = 0;
                    decimal id = _dbContext.TblRoomBookingTimelineDetails.Max(x => x.TimelineDetailId);
                    TblRoomBookingTimelineDetail.TimelineDetailId = id + 1;
                    decimalGrantTotal = Convert.ToDecimal(TotalToSentInLedger);
                    TblRoomBookingTimelineDetail.ReservationId = Convert.ToDecimal(ReservationId);
                    TblRoomBookingTimelineDetail.SalesmanId =Convert.ToInt32( dto.SalesmanId);
                    TblRoomBookingTimelineDetail.YearId = Convert.ToDecimal(financialYearId.ToString());
                    TblRoomBookingTimelineDetail.DocumentDate = Convert.ToDateTime(dto.ReservationDate);
                    TblRoomBookingTimelineDetail.VoucherTypeId = Convert.ToDecimal(37);
                    TblRoomBookingTimelineDetail.VoucherNo = ReservationNo;
                    //TblRoomBookingTimelineDetail.InvoiceNo = ReservationNo;
                    TblRoomBookingTimelineDetail.Refrence = RoomName;
                    TblRoomBookingTimelineDetail.LedgerId = Convert.ToDecimal(dto.LedgerId);
                    TblRoomBookingTimelineDetail.Description = "Room Booking Charges";
                    TblRoomBookingTimelineDetail.Debit = decimalGrantTotal;
                    TblRoomBookingTimelineDetail.Credit = 0;
                     await _rep_TRoomBookingTimelineDetail.AddAsync(TblRoomBookingTimelineDetail);
                    
                    id = _dbContext.TblRoomBookingTimelineDetails.Max(x => x.TimelineDetailId);
                    TblRoomBookingTimelineDetail.TimelineDetailId = id + 1;
                    TblRoomBookingTimelineDetail.ReservationId = Convert.ToDecimal(ReservationId);
                    TblRoomBookingTimelineDetail.SalesmanId = dto.SalesmanId;
                    TblRoomBookingTimelineDetail.YearId = Convert.ToDecimal(financialYearId.ToString());
                    TblRoomBookingTimelineDetail.DocumentDate = Convert.ToDateTime(dto.ReservationDate);
                    TblRoomBookingTimelineDetail.VoucherTypeId  = Convert.ToDecimal(37);
                    TblRoomBookingTimelineDetail.VoucherNo   = ReservationNo ;
                    //TblRoomBookingTimelineDetail.InvoiceNo  = ReservationNo ();
                    TblRoomBookingTimelineDetail.Refrence  = RoomName;
                    TblRoomBookingTimelineDetail.LedgerId = 27;
                    TblRoomBookingTimelineDetail.Description = "Room Booking Charges";
                    TblRoomBookingTimelineDetail.Debit = 0;
                    TblRoomBookingTimelineDetail.Credit = Convert.ToDecimal(SubTotalToSentInLedger);
                   await _rep_TRoomBookingTimelineDetail.AddAsync(TblRoomBookingTimelineDetail);

                    if (dto.LedgerId != 1)
                    {
                        //Cash to Customer Entry
                        decimalGrantTotal = Convert.ToDecimal(TotalToSentInLedger);
                        TblRoomBookingTimelineDetail.ReservationId = Convert.ToDecimal(ReservationId);
                        TblRoomBookingTimelineDetail.SalesmanId = dto.SalesmanId;
                        TblRoomBookingTimelineDetail.YearId = Convert.ToDecimal(financialYearId.ToString());
                        TblRoomBookingTimelineDetail.DocumentDate = Convert.ToDateTime(dto.ReservationDate);
                        TblRoomBookingTimelineDetail.VoucherTypeId = Convert.ToDecimal(37);
                        TblRoomBookingTimelineDetail.VoucherNo = ReservationNo ;
                        TblRoomBookingTimelineDetail.Refrence = RoomName;
                        TblRoomBookingTimelineDetail.LedgerId = Convert.ToDecimal(dto.LedgerId);
                        TblRoomBookingTimelineDetail.Description = "Room Booking Charges";
                        TblRoomBookingTimelineDetail.Debit = 0;
                        TblRoomBookingTimelineDetail.Credit = decimalGrantTotal;
                        id = _dbContext.TblRoomBookingTimelineDetails.Max(x => x.TimelineDetailId);
                        TblRoomBookingTimelineDetail.TimelineDetailId = id + 1;
                    await _rep_TRoomBookingTimelineDetail.AddAsync(TblRoomBookingTimelineDetail);

                        TblRoomBookingTimelineDetail.VoucherNo = ReservationNo ;
                        TblRoomBookingTimelineDetail.ReservationId = Convert.ToDecimal(ReservationId);
                        TblRoomBookingTimelineDetail.SalesmanId = dto.SalesmanId;
                        TblRoomBookingTimelineDetail.YearId = Convert.ToDecimal(financialYearId.ToString());
                        TblRoomBookingTimelineDetail.DocumentDate = Convert.ToDateTime(dto.ReservationDate);
                        TblRoomBookingTimelineDetail.VoucherTypeId = Convert.ToDecimal(37);
                        TblRoomBookingTimelineDetail.VoucherNo = ReservationNo ;
                    TblRoomBookingTimelineDetail.Refrence = RoomName;
                        TblRoomBookingTimelineDetail.LedgerId = 1;
                        TblRoomBookingTimelineDetail.Description = "Room Booking Charges";
                        TblRoomBookingTimelineDetail.Debit = Convert.ToDecimal(TotalToSentInLedger);
                        TblRoomBookingTimelineDetail.Credit = 0;
                    id = _dbContext.TblRoomBookingTimelineDetails.Max(x => x.TimelineDetailId);
                    TblRoomBookingTimelineDetail.TimelineDetailId = id + 1;
                    await _rep_TRoomBookingTimelineDetail.AddAsync(TblRoomBookingTimelineDetail);
                    }
                }

                if (Convert.ToDecimal(dto.Balance) == Convert.ToDecimal(TotalToSentInLedger))
                {
                    //When Sold goods fully on Credit basis
                    //Customer to Room Reservation Ac Entry 

                    decimal decimalGrantTotal = 0;
                    decimalGrantTotal = Convert.ToDecimal(TotalToSentInLedger);
                    TblRoomBookingTimelineDetail.ReservationId = Convert.ToDecimal(ReservationId);
                    TblRoomBookingTimelineDetail.SalesmanId = dto.SalesmanId;
                    TblRoomBookingTimelineDetail.YearId = Convert.ToDecimal(financialYearId.ToString());
                    TblRoomBookingTimelineDetail.DocumentDate = Convert.ToDateTime(dto.ReservationDate);
                    TblRoomBookingTimelineDetail.VoucherTypeId = Convert.ToDecimal(37);
                    TblRoomBookingTimelineDetail.VoucherNo = ReservationNo;
                    TblRoomBookingTimelineDetail.Refrence = RoomName;
                    TblRoomBookingTimelineDetail.LedgerId = Convert.ToDecimal(dto.LedgerId);
                    TblRoomBookingTimelineDetail.Description = "Room Booking Charges";
                    TblRoomBookingTimelineDetail.Debit = decimalGrantTotal;
                    TblRoomBookingTimelineDetail.Credit = 0;
                decimal id = _dbContext.TblRoomBookingTimelineDetails.Max(x => x.TimelineDetailId);
                TblRoomBookingTimelineDetail.TimelineDetailId = id + 1;
                await _rep_TRoomBookingTimelineDetail.AddAsync(TblRoomBookingTimelineDetail);
                
                    TblRoomBookingTimelineDetail.ReservationId = Convert.ToDecimal(ReservationId);
                    TblRoomBookingTimelineDetail.SalesmanId = dto.SalesmanId;
                    TblRoomBookingTimelineDetail.YearId = Convert.ToDecimal(financialYearId.ToString());
                    TblRoomBookingTimelineDetail.DocumentDate = Convert.ToDateTime(dto.ReservationDate);
                    TblRoomBookingTimelineDetail.VoucherTypeId = Convert.ToDecimal(37);
                    TblRoomBookingTimelineDetail.VoucherNo = ReservationNo;
                    //TblRoomBookingTimelineDetail.InvoiceNo = ReservationNo;
                    TblRoomBookingTimelineDetail.Refrence = RoomName;
                    TblRoomBookingTimelineDetail.LedgerId = 27;
                    TblRoomBookingTimelineDetail.Description = "Room Booking Charges";
                    TblRoomBookingTimelineDetail.Debit = 0;
                    TblRoomBookingTimelineDetail.Credit = Convert.ToDecimal(SubTotalToSentInLedger);
                id = _dbContext.TblRoomBookingTimelineDetails.Max(x => x.TimelineDetailId);
                TblRoomBookingTimelineDetail.TimelineDetailId = id + 1;
                await _rep_TRoomBookingTimelineDetail.AddAsync(TblRoomBookingTimelineDetail);
                }

                if (Convert.ToDecimal(dto.PaidAmount) > 0 && Convert.ToDecimal(dto.Balance) > 0)
                {
                    //When Sold goods half on Credit and half on cash basis
                    //Customer to Room Reservation Ac Entry

                    decimal decimalGrantTotal = 0;
                ;
                decimalGrantTotal = Convert.ToDecimal(TotalToSentInLedger);
                    TblRoomBookingTimelineDetail.ReservationId = Convert.ToDecimal(ReservationId);
                    TblRoomBookingTimelineDetail.SalesmanId = dto.SalesmanId;
                    TblRoomBookingTimelineDetail.YearId = Convert.ToDecimal(financialYearId.ToString());
                    TblRoomBookingTimelineDetail.DocumentDate = Convert.ToDateTime(dto.ReservationDate);
                    TblRoomBookingTimelineDetail.VoucherTypeId = Convert.ToDecimal(37);
                    TblRoomBookingTimelineDetail.VoucherNo = ReservationNo ;
                    //TblRoomBookingTimelineDetail.InvoiceNo = ReservationNo ;
                    TblRoomBookingTimelineDetail.Refrence = RoomName;
                    TblRoomBookingTimelineDetail.LedgerId = Convert.ToDecimal(dto.LedgerId);
                    TblRoomBookingTimelineDetail.Description = "Room Booking Charges";
                    TblRoomBookingTimelineDetail.Debit = decimalGrantTotal;
                    TblRoomBookingTimelineDetail.Credit = 0;
               decimal id = _dbContext.TblRoomBookingTimelineDetails.Max(x => x.TimelineDetailId);
                TblRoomBookingTimelineDetail.TimelineDetailId = id + 1;
                await _rep_TRoomBookingTimelineDetail.AddAsync(TblRoomBookingTimelineDetail);


                    TblRoomBookingTimelineDetail.ReservationId = Convert.ToDecimal(ReservationId);
                    TblRoomBookingTimelineDetail.SalesmanId = dto.SalesmanId;
                    TblRoomBookingTimelineDetail.YearId = Convert.ToDecimal(financialYearId.ToString());
                    TblRoomBookingTimelineDetail.DocumentDate = Convert.ToDateTime(dto.ReservationDate);
                    TblRoomBookingTimelineDetail.VoucherTypeId = Convert.ToDecimal(37);
                    TblRoomBookingTimelineDetail.VoucherNo = ReservationNo ;
                    //TblRoomBookingTimelineDetail.InvoiceNo = ReservationNo ;
                    TblRoomBookingTimelineDetail.Refrence = RoomName;
                    TblRoomBookingTimelineDetail.LedgerId = 27;
                    TblRoomBookingTimelineDetail.Description = "Room Booking Charges";
                    TblRoomBookingTimelineDetail.Debit = 0;
                    TblRoomBookingTimelineDetail.Credit = Convert.ToDecimal(SubTotalToSentInLedger);
                id = _dbContext.TblRoomBookingTimelineDetails.Max(x => x.TimelineDetailId);
                TblRoomBookingTimelineDetail.TimelineDetailId = id + 1;
                await _rep_TRoomBookingTimelineDetail.AddAsync(TblRoomBookingTimelineDetail);

                    //Cash to Customer Entry

                decimalGrantTotal = Convert.ToDecimal(dto.PaidAmount);
                    TblRoomBookingTimelineDetail.ReservationId = Convert.ToDecimal(ReservationId);
                    TblRoomBookingTimelineDetail.SalesmanId = dto.SalesmanId;
                    TblRoomBookingTimelineDetail.YearId = Convert.ToDecimal(financialYearId.ToString());
                    TblRoomBookingTimelineDetail.DocumentDate = Convert.ToDateTime(dto.ReservationDate);
                    TblRoomBookingTimelineDetail.VoucherTypeId = Convert.ToDecimal(37);
                    TblRoomBookingTimelineDetail.VoucherNo = ReservationNo ;
                    //TblRoomBookingTimelineDetail.InvoiceNo = ReservationNo ;
                    TblRoomBookingTimelineDetail.Refrence = RoomName;
                    TblRoomBookingTimelineDetail.LedgerId = Convert.ToDecimal(dto.LedgerId);
                    TblRoomBookingTimelineDetail.Description = "Room Booking Charges";
                    TblRoomBookingTimelineDetail.Debit = 0;
                    TblRoomBookingTimelineDetail.Credit = decimalGrantTotal;
                 id = _dbContext.TblRoomBookingTimelineDetails.Max(x => x.TimelineDetailId);
                TblRoomBookingTimelineDetail.TimelineDetailId = id + 1;
                await _rep_TRoomBookingTimelineDetail.AddAsync(TblRoomBookingTimelineDetail);

                TblRoomBookingTimelineDetail.ReservationId = Convert.ToDecimal(ReservationId);
                    TblRoomBookingTimelineDetail.SalesmanId = dto.SalesmanId;
                    TblRoomBookingTimelineDetail.YearId = Convert.ToDecimal(financialYearId.ToString());
                    TblRoomBookingTimelineDetail.DocumentDate = Convert.ToDateTime(dto.ReservationDate);
                    TblRoomBookingTimelineDetail.VoucherTypeId = Convert.ToDecimal(37);
                    TblRoomBookingTimelineDetail.VoucherNo = ReservationNo ;
                    //TblRoomBookingTimelineDetail.InvoiceNo = ReservationNo ();
                    TblRoomBookingTimelineDetail.Refrence = RoomName;
                    TblRoomBookingTimelineDetail.LedgerId = 1;
                    TblRoomBookingTimelineDetail.Description = "Room Booking Charges";
                    TblRoomBookingTimelineDetail.Debit = Convert.ToDecimal(dto.PaidAmount);
                    TblRoomBookingTimelineDetail.Credit = 0;
                id = _dbContext.TblRoomBookingTimelineDetails.Max(x => x.TimelineDetailId);
                TblRoomBookingTimelineDetail.TimelineDetailId = id + 1;
                await _rep_TRoomBookingTimelineDetail.AddAsync(TblRoomBookingTimelineDetail);

                }

                if (Convert.ToDecimal(dto.PaidAmount) > 0 && Convert.ToDecimal(dto.Balance) < 0)
                {
                    //When customer gave excess cash so it would be Credit to his account
                    //Customer to Room Booking Ac Entry

                    decimal decimalGrantTotal = 0;
                decimalGrantTotal = Convert.ToDecimal(TotalToSentInLedger);
                    TblRoomBookingTimelineDetail.ReservationId = Convert.ToDecimal(ReservationId);
                    TblRoomBookingTimelineDetail.SalesmanId = dto.SalesmanId;
                    TblRoomBookingTimelineDetail.YearId = Convert.ToDecimal(financialYearId.ToString());
                    TblRoomBookingTimelineDetail.DocumentDate = Convert.ToDateTime(dto.ReservationDate);
                    TblRoomBookingTimelineDetail.VoucherTypeId = Convert.ToDecimal(37);
                    TblRoomBookingTimelineDetail.VoucherNo = ReservationNo ;
                    //TblRoomBookingTimelineDetail.InvoiceNo = ReservationNo ;
                    TblRoomBookingTimelineDetail.Refrence = RoomName;
                    TblRoomBookingTimelineDetail.LedgerId = Convert.ToDecimal(dto.LedgerId);
                    TblRoomBookingTimelineDetail.Description = "Room Booking Charges";
                    TblRoomBookingTimelineDetail.Debit = decimalGrantTotal;
                    TblRoomBookingTimelineDetail.Credit = 0;
                decimal id = _dbContext.TblRoomBookingTimelineDetails.Max(x => x.TimelineDetailId);
                TblRoomBookingTimelineDetail.TimelineDetailId = id + 1;
                await _rep_TRoomBookingTimelineDetail.AddAsync(TblRoomBookingTimelineDetail);


                TblRoomBookingTimelineDetail.ReservationId = Convert.ToDecimal(ReservationId);
                    TblRoomBookingTimelineDetail.SalesmanId = dto.SalesmanId;
                    TblRoomBookingTimelineDetail.YearId = Convert.ToDecimal(financialYearId.ToString());
                    TblRoomBookingTimelineDetail.DocumentDate = Convert.ToDateTime(dto.ReservationDate);
                    TblRoomBookingTimelineDetail.VoucherTypeId = Convert.ToDecimal(37);
                    TblRoomBookingTimelineDetail.VoucherNo = ReservationNo ;
                //TblRoomBookingTimelineDetail.InvoiceNo = ReservationNo ();
                TblRoomBookingTimelineDetail.Refrence = RoomName;
                    TblRoomBookingTimelineDetail.LedgerId = 27;
                    TblRoomBookingTimelineDetail.Description = "Room Booking Charges";
                    TblRoomBookingTimelineDetail.Debit = 0;
                    TblRoomBookingTimelineDetail.Credit = Convert.ToDecimal(SubTotalToSentInLedger);
                id = _dbContext.TblRoomBookingTimelineDetails.Max(x => x.TimelineDetailId);
                TblRoomBookingTimelineDetail.TimelineDetailId = id + 1;
                await _rep_TRoomBookingTimelineDetail.AddAsync(TblRoomBookingTimelineDetail);

                //Cash to Customer Entry
                decimalGrantTotal = Convert.ToDecimal(dto.PaidAmount);
                    TblRoomBookingTimelineDetail.ReservationId = Convert.ToDecimal(ReservationId);
                    TblRoomBookingTimelineDetail.SalesmanId = dto.SalesmanId;
                    TblRoomBookingTimelineDetail.YearId = Convert.ToDecimal(financialYearId.ToString());
                    TblRoomBookingTimelineDetail.DocumentDate = Convert.ToDateTime(dto.ReservationDate);
                    TblRoomBookingTimelineDetail.VoucherTypeId = Convert.ToDecimal(37);
                    TblRoomBookingTimelineDetail.VoucherNo = ReservationNo ;
                    //TblRoomBookingTimelineDetail.InvoiceNo = ReservationNo ();
                    TblRoomBookingTimelineDetail.Refrence = RoomName;
                    TblRoomBookingTimelineDetail.LedgerId = Convert.ToDecimal(dto.LedgerId);
                    TblRoomBookingTimelineDetail.Description = "Room Booking Charges";
                    TblRoomBookingTimelineDetail.Debit = 0;
                    TblRoomBookingTimelineDetail.Credit = decimalGrantTotal;
                id = _dbContext.TblRoomBookingTimelineDetails.Max(x => x.TimelineDetailId);
                TblRoomBookingTimelineDetail.TimelineDetailId = id + 1;
                await _rep_TRoomBookingTimelineDetail.AddAsync(TblRoomBookingTimelineDetail);

                 id = _dbContext.TblRoomBookingTimelineDetails.Max(x => x.TimelineDetailId);
                TblRoomBookingTimelineDetail.TimelineDetailId = id + 1; 
                TblRoomBookingTimelineDetail.ReservationId = Convert.ToDecimal(ReservationId);
                    TblRoomBookingTimelineDetail.SalesmanId = dto.SalesmanId;
                    TblRoomBookingTimelineDetail.YearId = Convert.ToDecimal(financialYearId.ToString());
                    TblRoomBookingTimelineDetail.DocumentDate = Convert.ToDateTime(dto.ReservationDate);
                    TblRoomBookingTimelineDetail.VoucherTypeId = Convert.ToDecimal(37);
                    TblRoomBookingTimelineDetail.VoucherNo = ReservationNo ;
                    //TblRoomBookingTimelineDetail.InvoiceNo = ReservationNo ();
                    TblRoomBookingTimelineDetail.Refrence = RoomName;
                    TblRoomBookingTimelineDetail.LedgerId = 1;
                    TblRoomBookingTimelineDetail.Description = "Room Booking Charges";
                    TblRoomBookingTimelineDetail.Debit = Convert.ToDecimal(dto.PaidAmount);
                    TblRoomBookingTimelineDetail.Credit = 0;
                   await _rep_TRoomBookingTimelineDetail.AddAsync(TblRoomBookingTimelineDetail);
                }

                //Discount Allowed Entry
                decimal decBillDis = 0;
                decBillDis = Convert.ToDecimal(dto.Discount);
                if (decBillDis > 0)
                {
                decimal id = _dbContext.TblRoomBookingTimelineDetails.Max(x => x.TimelineDetailId);
                TblRoomBookingTimelineDetail.TimelineDetailId = id + 1;
                    
                TblRoomBookingTimelineDetail.ReservationId = Convert.ToDecimal(ReservationId);
                    TblRoomBookingTimelineDetail.SalesmanId = dto.SalesmanId;
                    TblRoomBookingTimelineDetail.YearId = Convert.ToDecimal(financialYearId.ToString());
                    TblRoomBookingTimelineDetail.DocumentDate = Convert.ToDateTime(dto.ReservationDate);
                    TblRoomBookingTimelineDetail.VoucherTypeId = Convert.ToDecimal(37);
                    TblRoomBookingTimelineDetail.VoucherNo = ReservationNo ;
                    //TblRoomBookingTimelineDetail.InvoiceNo = ReservationNo ();
                    TblRoomBookingTimelineDetail.Refrence = RoomName;
                    TblRoomBookingTimelineDetail.LedgerId = 8;
                    TblRoomBookingTimelineDetail.Description = "Room Booking Charges. Discount Allowed";
                    TblRoomBookingTimelineDetail.Debit = decBillDis;
                    TblRoomBookingTimelineDetail.Credit = 0;
                   await _rep_TRoomBookingTimelineDetail.AddAsync(TblRoomBookingTimelineDetail);
                }

                //Tax Entry
                //foreach (DataGridViewRow dgvrow in grdTaxes.Rows)
                //{
                //    if (dgvrow.Cells["grdTaxId"].Value != null && dgvrow.Cells["grdTaxId"].Value.ToString() != string.Empty)
                //    {
                //        decimal decTaxAmount = 0;
                //        if (dgvrow.Cells["grdTaxAmount"].Value != null)
                //        {
                //            if (dgvrow.Cells["grdTaxAmount"].Value.ToString() != "")
                //            {
                //                decTaxAmount = Convert.ToDecimal(dgvrow.Cells["grdTaxAmount"].Value.ToString());
                //                if (decTaxAmount > 0)
                //                {
                //                TblRoomBookingTimelineDetail.TimelineDetailId = _dbContext.TblRoomBookingTimelineDetails.Max-(x => x.TimelineDetailId) + 1;
                //                TblRoomBookingTimelineDetail.ReservationId = Convert.ToDecimal(ReservationId);
                //                    TblRoomBookingTimelineDetail.SalesmanId = dto.SalesmanId;
                //                    TblRoomBookingTimelineDetail.YearId = Convert.ToDecimal(financialYearId.ToString());
                //                    TblRoomBookingTimelineDetail.DocumentDate = Convert.ToDateTime(dto.ReservationDate());
                //                    TblRoomBookingTimelineDetail.VoucherTypeId = Convert.ToDecimal(37);
                //                    TblRoomBookingTimelineDetail.VoucherNo = ReservationNo ();
                //                    TblRoomBookingTimelineDetail.InvoiceNo = ReservationNo ();
                //                    TblRoomBookingTimelineDetail.Refrence = RoomName();
                //                    TblRoomBookingTimelineDetail.LedgerId = Convert.ToDecimal(dgvrow.Cells["grdTaxLedgerId"].Value.ToString());
                //                    TblRoomBookingTimelineDetail.Description = "Room Booking Charges. Discount Allowed";
                //                    TblRoomBookingTimelineDetail.Debit = 0;
                //                    TblRoomBookingTimelineDetail.Credit = decTaxAmount;
                //                   await _rep_TRoomBookingTimelineDetail.AddAsync(TblRoomBookingTimelineDetail);
                //                }
                //            }
                //        }
               return true; // Indicate success
            }
            catch (Exception ex)
            {
                // Handle exception if insertion fails
                // You may log the exception details here
                return false; // Indicate failure
            }
        }


        private Int32 LoadCaclulatedDays()
        {
            Int32 NoOfNights = 0;
            if (StayType!= null)
            {
                if (StayType != "")
                {
                    if (StayType== "Hours")
                    {
                        //  NoOfNights = Convert.ToInt32(spnNoOfHours.EditValue);
                        NoOfNights = Convert.ToInt32(spnNoOfNights) + 1;
                    }
                    else if (StayType== "Days")
                    {
                        NoOfNights = Convert.ToInt32(spnNoOfNights);
                    }
                    else if (StayType== "Months")
                    {
                        NoOfNights = Convert.ToInt32(spnNoOfMonths) * 30;
                    }
                }
            }
            return NoOfNights;
        }
        //public IQueryable<Product> GetProductsByCategory(string categoryName)
        //{
        //    return Products.FromSqlRaw("EXEC GetProductsByCategory @CategoryName", categoryName);
        //}
        //public Task<List<Season>> LoadReservationSeasonAsync()
        //{

        //}
    }
}
