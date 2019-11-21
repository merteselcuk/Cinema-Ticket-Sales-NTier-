using Cinema.DAL;
using Cinema.DAL.Abstract;
using Cinema.DTO;
using Cinema.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BLL
{
    public class TicketController
    {
        IUnitOfWork _uow;
        public TicketController()
        {
            _uow = Singleton.Uow;
        }

        public bool AddTicket(List<SeatSaleDTO> dtos)
        {
            Ticket ticket = new Ticket()
            {
                Id = Guid.NewGuid(),
                Date = DateTime.Now,
                Cost=dtos.Count*12,
                CreatedDate = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                UserId = SessionHelper.CurrentUser.Id
            };
            Ticket AddedTicket = _uow.GetRepository<Ticket>().Add(ticket);
            if (AddedTicket != null)
            {
                foreach (var seatSaledto in dtos)
                {
                    SeatSale seatSale = new SeatSale();
                    seatSale.Id = Guid.NewGuid();
                    seatSale.Price = seatSaledto.Price;
                    seatSale.SessionId = seatSaledto.SessionId;
                    seatSale.SeatId = seatSaledto.SeatId;
                    seatSale.IsDeleted = false;
                    seatSale.UserId = SessionHelper.CurrentUser.Id;
                    seatSale.CreatedDate = DateTime.Now;
                    seatSale.TicketId = ticket.Id;
                    SeatSale sale = _uow.GetRepository<SeatSale>().Add(seatSale);
                    if (sale == null)
                    {
                        return false;
                    }
                }
                return true;
            }            
            return false;

        }
    }
}

