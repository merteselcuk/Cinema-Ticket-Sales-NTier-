using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.DAL;
using Cinema.DAL.Abstract;
using Cinema.DTO;
using Cinema.Entity.Concrete;
using Cinema.Enums;
using Framework.Core;
using Newtonsoft.Json;

namespace Cinema.BLL
{
    public class TheaterController
    {
        IUnitOfWork _uow;
        LogController _lc;
        public TheaterController()
        {
            _uow = Singleton.Uow;
            _lc = new LogController();
        }
        public ServiceResult AddTheater(TheaterDTO dto)
        {
            ServiceResult serviceResult;
            _uow.BeginTran();
            try
            {
                #region Validation
                Theater validation = _uow.GetRepository<Theater>().GetSpesific(t => t.TheaterName == dto.TheaterName && t.IsDeleted == false);
                if (validation != null)
                {
                    serviceResult = new ServiceResult("Aynı isimde bir salon eklenemez.", ResultState.Warning);
                    return serviceResult;
                }
                #endregion
                Theater theater = new Theater()
                {
                    Id = Guid.NewGuid(),
                    TheaterName = dto.TheaterName,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    UserId = SessionHelper.CurrentUser.Id,

                };
                ICollection<Seat> seats = _uow.GetRepository<Seat>().Get(s => s.IsDeleted == false);
                if (seats.Count == 0)
                {
                    List<Seat> newseats = new List<Seat>();
                    //A
                    for (int i = 1; i < 9; i++)
                    {
                        Seat seat = new Seat();
                        seat.Id = Guid.NewGuid();
                        seat.SeatTypeNo = SeatTypeEnum.A;
                        seat.SeatNo = i;
                        seat.CreatedDate = DateTime.Now;
                        seat.IsActive = true;
                        seat.IsDeleted = false;
                        newseats.Add(seat);
                    }
                    //B
                    for (int i = 1; i < 9; i++)
                    {
                        Seat seat = new Seat();
                        seat.Id = Guid.NewGuid();
                        seat.SeatTypeNo = SeatTypeEnum.B;
                        seat.SeatNo = i;
                        seat.CreatedDate = DateTime.Now;
                        seat.IsActive = true;
                        seat.IsDeleted = false;
                        newseats.Add(seat);
                    }
                    //C
                    for (int i = 1; i < 9; i++)
                    {
                        Seat seat = new Seat();
                        seat.Id = Guid.NewGuid();
                        seat.SeatTypeNo = SeatTypeEnum.C;
                        seat.SeatNo = i;
                        seat.CreatedDate = DateTime.Now;
                        seat.IsActive = true;
                        seat.IsDeleted = false;
                        newseats.Add(seat);
                    }
                    //D
                    for (int i = 1; i < 9; i++)
                    {
                        Seat seat = new Seat();
                        seat.Id = Guid.NewGuid();
                        seat.SeatTypeNo = SeatTypeEnum.D;
                        seat.SeatNo = i;
                        seat.CreatedDate = DateTime.Now;
                        seat.IsActive = true;
                        seat.IsDeleted = false;
                        newseats.Add(seat);
                    }
                    //E
                    for (int i = 1; i < 9; i++)
                    {
                        Seat seat = new Seat();
                        seat.Id = Guid.NewGuid();
                        seat.SeatTypeNo = SeatTypeEnum.E;
                        seat.SeatNo = i;
                        seat.CreatedDate = DateTime.Now;
                        seat.IsActive = true;
                        seat.IsDeleted = false;
                        newseats.Add(seat);
                    }
                    foreach (var seat in newseats)
                    {
                        _uow.GetRepository<Seat>().Add(seat);
                    }
                    seats = _uow.GetRepository<Seat>().Get(s => s.IsDeleted == false);
                }
                foreach (var item in seats)
                {
                    theater.Seats.Add(item);
                }
                Theater addedTheater = _uow.GetRepository<Theater>().Add(theater);
                if (addedTheater != null)
                {
                    _lc.AddLog<Theater>(theater, ProcessTypeEnum.Add, theater.Id);
                    _uow.Commit();
                    serviceResult = new ServiceResult("Salon başarıyla eklendi.", ResultState.Success);
                }
                else
                {
                    serviceResult = new ServiceResult("Yapılacak bir işlem kaydına rastlanamadı.", ResultState.Warning);
                }
            }
            catch (Exception ex)
            {
                _uow.Rollback();
                serviceResult = new ServiceResult("Hata..", ResultState.Error);
            }
            return serviceResult;
        }

        public TheaterDTO GetOneTheater(Guid Id)
        {
            Theater theater = _uow.GetRepository<Theater>().Get(Id);
            TheaterDTO dto = new TheaterDTO();
            TheaterToDto(theater, dto);
            return dto;
        }

        public ServiceResult UpdateTheater(TheaterDTO dto)
        {
            ServiceResult serviceResult;
            _uow.BeginTran();
            try
            {
                Theater theater = _uow.GetRepository<Theater>().Get(dto.Id);
                DtoToTheater(dto, theater);
                theater.UpdatedDate = DateTime.Now;
                Theater updatedTheater = _uow.GetRepository<Theater>().Update(theater);
                if (updatedTheater != null)
                {
                    _lc.AddLog<Theater>(theater, ProcessTypeEnum.Update, theater.Id);
                    _uow.Commit();
                    serviceResult = new ServiceResult("Salon başarıyla güncellendi.", ResultState.Success);
                }
                else
                {
                    serviceResult = new ServiceResult("Yapılacak bir işlem kaydına rastlanamadı.", ResultState.Warning);
                }
            }
            catch (Exception ex)
            {
                _uow.Rollback();
                serviceResult = new ServiceResult("Hata..", ResultState.Error);
            }
            return serviceResult;
        }

        public ServiceResult DeleteTheater(TheaterDTO dto)
        {
            ServiceResult serviceResult;
            _uow.BeginTran();
            try
            {
                Theater theater = _uow.GetRepository<Theater>().Get(dto.Id);
                DtoToTheater(dto, theater);
                theater.IsDeleted = true;
                Theater deletedTheater = _uow.GetRepository<Theater>().Update(theater);
                if (deletedTheater != null)
                {
                    _lc.AddLog<Theater>(theater, ProcessTypeEnum.Delete, theater.Id);
                    _uow.Commit();
                    serviceResult = new ServiceResult("Salon başarıyla silindi.", ResultState.Success);
                }
                else
                {
                    serviceResult = new ServiceResult("Yapılacak bir işlem kaydına rastlanamadı.", ResultState.Warning);
                }
            }
            catch (Exception ex)
            {
                _uow.Rollback();
                serviceResult = new ServiceResult("Hata..", ResultState.Error);
            }
            return serviceResult;
        }

        private void DtoToTheater(TheaterDTO dto, Theater theater)
        {
            theater.Id = dto.Id;
            theater.TheaterName = dto.TheaterName;
            theater.IsActive = dto.IsActive;

        }

        public List<TheaterDTO> GetAllTheaters()
        {
            ICollection<Theater> theaters = _uow.GetRepository<Theater>().Get(t => t.IsDeleted == false);
            return TheaterToDto(theaters);
        }
        private void TheaterToDto(Theater theater, TheaterDTO dto)
        {
            dto.Id = theater.Id;
            dto.TheaterName = theater.TheaterName;
            dto.IsActive = theater.IsActive;
            foreach (var item in theater.Seats)
            {
                SeatDTO dtoSeat = new SeatDTO();
                dtoSeat.Id = item.Id;
                dtoSeat.SeatNo = item.SeatNo;
                dtoSeat.SeatTypeNo = item.SeatTypeNo;
                dto.Seats.Add(dtoSeat);
            }
        }
        private List<TheaterDTO> TheaterToDto(IEnumerable<Theater> theaters)
        {
            List<TheaterDTO> result = new List<TheaterDTO>();
            foreach (var theater in theaters)
            {
                TheaterDTO dto = new TheaterDTO();
                TheaterToDto(theater, dto);
                result.Add(dto);
            }
            return result;
        }
    }
}
