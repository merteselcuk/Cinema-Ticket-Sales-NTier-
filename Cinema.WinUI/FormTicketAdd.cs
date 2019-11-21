using Cinema.BLL;
using Cinema.DTO;
using Cinema.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSeans.UI
{
    public partial class FormTicketAdd : Form
    {
        SessionController _sc;
        TheaterController _tc;
        List<SeatDTO> dtoSeats;
        TicketController _tcc;
        public FormTicketAdd()
        {
            InitializeComponent();
            _sc = new SessionController();
            _tc = new TheaterController();
            _tcc = new TicketController();
            dtoSeats = new List<SeatDTO>();
        }

        private void FormTicketAdd_Load(object sender, EventArgs e)
        {
            lstSaleSeats.Items.Clear();
            List<SessionDTO> dtos = _sc.GetAllSession();
            ListBoxExtension.DataSourceMember<List<SessionDTO>>(cmbSession, "SessionInformation", "Id", dtos);
            LoadSaleSeats();
        }

        private void BtnSaleSeats_Click(object sender, EventArgs e)
        {
            List<SeatSaleDTO> dtos = new List<SeatSaleDTO>();
            SessionDTO dtoSession = cmbSession.SelectedItem as SessionDTO;
            foreach (var item in dtoSeats)
            {
                SeatSaleDTO dto = new SeatSaleDTO()
                {
                    SeatId = item.Id,
                    SessionId = dtoSession.Id,
                    Price = 12
                };
                dtos.Add(dto);
            }
            bool result = _tcc.AddTicket(dtos);
            if (result == true)
            {
                MessageBox.Show("Okay");
            }
        }

        private void LoadSaleSeats()
        {
            ListBoxExtension.DataSourceMember<List<SeatDTO>>(lstSaleSeats, "SeatName", "Id", dtoSeats);
        }

        private void SelectionSeat(SeatTypeEnum seatTypeEnum,int No)
        {
            SessionDTO dtoSession = cmbSession.SelectedItem as SessionDTO;
            TheaterDTO dtoTheater = _tc.GetOneTheater(dtoSession.TheaterId);
            foreach (var item in dtoTheater.Seats)
            {
                if (item.SeatTypeNo == seatTypeEnum && item.SeatNo == No)
                {
                    dtoSeats.Add(item);
                }
            }
            LoadSaleSeats();
            
        }

        private void BtnA1_Click(object sender, EventArgs e)

        {
            if (btnA1.BackColor == Color.Green)
            {
                btnA1.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.A, 1);
            }
        }

        private void BtnA2_Click(object sender, EventArgs e)
        {
            if (btnA2.BackColor == Color.Green)
            {
                 btnA2.BackColor = Color.Blue;
                 SelectionSeat(SeatTypeEnum.A, 2);
            }
        }

        private void BtnA3_Click(object sender, EventArgs e)
        {
            if (btnA3.BackColor == Color.Green)
            {
                btnA3.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.A, 3);
            }
        }

        private void BtnA4_Click(object sender, EventArgs e)
        {
            if (btnA4.BackColor == Color.Green)
            {
                btnA4.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.A, 4);
            }
        }

        private void BtnA5_Click(object sender, EventArgs e)
        {
            if (btnA5.BackColor == Color.Green)
            {
                btnA5.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.A, 5);
            }
        }

        private void BtnA6_Click(object sender, EventArgs e)
        {
            if (btnA6.BackColor == Color.Green)
            {
                btnA6.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.A, 6);
            }
        }

        private void BtnA7_Click(object sender, EventArgs e)
        {
            if (btnA7.BackColor == Color.Green)
            {
                btnA7.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.A, 7);
            }
        }

        private void BtnA8_Click(object sender, EventArgs e)
        {
            if (btnA8.BackColor == Color.Green)
            {
                btnA8.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.A, 8);
            }
        }

        private void BtnB1_Click(object sender, EventArgs e)
        {
            if (btnB1.BackColor == Color.Green)
            {
                btnB1.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.B, 1);
            }
        }

        private void BtnB2_Click(object sender, EventArgs e)
        {
            if (btnB2.BackColor == Color.Green)
            {
                btnB2.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.B, 2);
            }
        }

        private void BtnB3_Click(object sender, EventArgs e)
        {
            if (btnB3.BackColor == Color.Green)
            {
                btnB3.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.B, 3);
            }
        }

        private void BtnB4_Click(object sender, EventArgs e)
        {
            if (btnB4.BackColor == Color.Green)
            {
                btnB4.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.B, 4);
            }
        }

        private void BtnB5_Click(object sender, EventArgs e)
        {
            if (btnB5.BackColor == Color.Green)
            {
                btnB5.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.B, 5);
            }
        }

        private void BtnB6_Click(object sender, EventArgs e)
        {
            if (btnB6.BackColor == Color.Green)
            {
                btnB6.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.B, 6);
            }
        }

        private void BtnB7_Click(object sender, EventArgs e)
        {
            if (btnB7.BackColor == Color.Green)
            {
                btnB7.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.B, 7);
            }
        }

        private void BtnB8_Click(object sender, EventArgs e)
        {
            if (btnB8.BackColor == Color.Green)
            {
                btnB8.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.B, 8);
            }
        }

        private void BtnC1_Click(object sender, EventArgs e)
        {
            if (btnC1.BackColor == Color.Green)
            {
                btnC1.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.C, 1);
            }
        }

        private void BtnC2_Click(object sender, EventArgs e)
        {
            if (btnC2.BackColor == Color.Green)
            {
                btnC2.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.C, 2);
            }
        }

        private void BtnC3_Click(object sender, EventArgs e)
        {
            if (btnC3.BackColor == Color.Green)
            {
                btnC3.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.C, 3);
            }
        }

        private void BtnC4_Click(object sender, EventArgs e)
        {
            if (btnC4.BackColor == Color.Green)
            {
                btnC4.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.C, 4);
            }
        }

        private void BtnC5_Click(object sender, EventArgs e)
        {
            if (btnC5.BackColor == Color.Green)
            {
                btnC5.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.C, 5);
            }
        }

        private void BtnC6_Click(object sender, EventArgs e)
        {
            if (btnC6.BackColor == Color.Green)
            {
                btnC6.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.C, 6);
            }
        }

        private void BtnC7_Click(object sender, EventArgs e)
        {
            if (btnC7.BackColor == Color.Green)
            {
                btnC7.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.C, 7);
            }
        }

        private void BtnC8_Click(object sender, EventArgs e)
        {
            if (btnC8.BackColor == Color.Green)
            {
                btnC8.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.C, 8);
            }
        }

        private void BtnD1_Click(object sender, EventArgs e)
        {
            if (btnD1.BackColor == Color.Green)
            {
                btnD1.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.D, 1);
            }
        }

        private void BtnD2_Click(object sender, EventArgs e)
        {
            if (btnD2.BackColor == Color.Green)
            {
                btnD2.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.D, 2);
            }
        }

        private void BtnD3_Click(object sender, EventArgs e)
        {
            if (btnD3.BackColor == Color.Green)
            {
                btnD3.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.D, 3);
            }
        }

        private void BtnD4_Click(object sender, EventArgs e)
        {
            if (btnD4.BackColor == Color.Green)
            {
                btnD4.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.D, 4);
            }
        }

        private void BtnD5_Click(object sender, EventArgs e)
        {
            if (btnD5.BackColor == Color.Green)
            {
                btnD5.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.D, 5);
            }
        }

        private void BtnD6_Click(object sender, EventArgs e)
        {
            if (btnD6.BackColor == Color.Green)
            {
                btnD6.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.D, 6);
            }
        }

        private void BtnD7_Click(object sender, EventArgs e)
        {
            if (btnD7.BackColor == Color.Green)
            {
                btnD7.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.D, 7);
            }
        }

        private void BtnD8_Click(object sender, EventArgs e)
        {
            if (btnD8.BackColor == Color.Green)
            {
                btnD8.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.D, 8);
            }
        }

        private void BtnE1_Click(object sender, EventArgs e)
        {
            if (btnE1.BackColor == Color.Green)
            {
                btnE1.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.E, 1);
            }
        }

        private void BtnE2_Click(object sender, EventArgs e)
        {
            if (btnE2.BackColor == Color.Green)
            {
                btnE2.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.E, 2);
            }
        }

        private void BtnE3_Click(object sender, EventArgs e)
        {
            if (btnE3.BackColor == Color.Green)
            {
                btnE3.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.E, 3);
            }
        }

        private void BtnE4_Click(object sender, EventArgs e)
        {
            if (btnE4.BackColor == Color.Green)
            {
                btnE4.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.E, 4);
            }
        }

        private void BtnE5_Click(object sender, EventArgs e)
        {
            if (btnE5.BackColor == Color.Green)
            {
                btnE5.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.E, 5);
            }
        }

        private void BtnE6_Click(object sender, EventArgs e)
        {
            if (btnE6.BackColor == Color.Green)
            {
                btnE6.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.E, 6);
            }
        }

        private void BtnE7_Click(object sender, EventArgs e)
        {
            if (btnE7.BackColor == Color.Green)
            {
                btnE7.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.E, 7);
            }
        }

        private void BtnE8_Click(object sender, EventArgs e)
        {
            if (btnE8.BackColor == Color.Green)
            {
                btnE8.BackColor = Color.Blue;
                SelectionSeat(SeatTypeEnum.E, 8);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            dtoSeats.Clear();
            LoadSaleSeats();
            btnA1.BackColor = Color.Green;
            btnA2.BackColor = Color.Green;
            btnA3.BackColor = Color.Green;
            btnA4.BackColor = Color.Green;
            btnA5.BackColor = Color.Green;
            btnA6.BackColor = Color.Green;
            btnA7.BackColor = Color.Green;
            btnA8.BackColor = Color.Green;

            btnB1.BackColor = Color.Green;
            btnB2.BackColor = Color.Green;
            btnB3.BackColor = Color.Green;
            btnB4.BackColor = Color.Green;
            btnB5.BackColor = Color.Green;
            btnB6.BackColor = Color.Green;
            btnB7.BackColor = Color.Green;
            btnB8.BackColor = Color.Green;

            btnC1.BackColor = Color.Green;
            btnC2.BackColor = Color.Green;
            btnC3.BackColor = Color.Green;
            btnC4.BackColor = Color.Green;
            btnC5.BackColor = Color.Green;
            btnC6.BackColor = Color.Green;
            btnC7.BackColor = Color.Green;
            btnC8.BackColor = Color.Green;

            btnD1.BackColor = Color.Green;
            btnD2.BackColor = Color.Green;
            btnD3.BackColor = Color.Green;
            btnD4.BackColor = Color.Green;
            btnD5.BackColor = Color.Green;
            btnD6.BackColor = Color.Green;
            btnD7.BackColor = Color.Green;
            btnD8.BackColor = Color.Green;

            btnE1.BackColor = Color.Green;
            btnE2.BackColor = Color.Green;
            btnE3.BackColor = Color.Green;
            btnE4.BackColor = Color.Green;
            btnE5.BackColor = Color.Green;
            btnE6.BackColor = Color.Green;
            btnE7.BackColor = Color.Green;
            btnE8.BackColor = Color.Green;
        }
    }
}
