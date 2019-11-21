using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DTO
{
    public class SessionDTO
    {
        public SessionDTO()
        {
            SeatSales = new List<SeatSaleDTO>();
        }
        public Guid Id { get; set; }
        public Guid MovieId { get; set; }
        public Guid TheaterId { get; set; }
        public Guid SeanceId { get; set; }
        public DateTime ShowDate { get; set; }
        public string MovieName { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan FinishTime { get; set; }
        public string SeanceInformation { get { return "Bas:" + StartTime + "     Bit:" + FinishTime; } }
        public bool IsActive { get; set; }

        public string TheaterName { get; set; }
        public string SessionInformation { get { return  "Bas : "+StartTime+" - Bit : "+FinishTime+ " - " + TheaterName+" - "+ MovieName; } }



        public SeanceDTO Seance { get; set; }
        public TheaterDTO Theater { get; set; }
        public MovieDTO Movie { get; set; }
        public List<SeatSaleDTO> SeatSales { get; set; }
    }
}
