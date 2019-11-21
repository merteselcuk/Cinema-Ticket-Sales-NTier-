using Cinema.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DTO
{
    public class SeatDTO
    {
        public SeatDTO()
        {
            SeatSales = new List<SeatSaleDTO>();
            Theaters = new List<TheaterDTO>();
        }
        public Guid Id { get; set; }
        public SeatTypeEnum SeatTypeNo { get; set; }
        public int SeatNo { get; set; }
        public string SeatName { get { return  SeatTypeNo + "" + SeatNo; } }


        public List<SeatSaleDTO> SeatSales { get; set; }
        public List<TheaterDTO> Theaters { get; set; }
    }
}
