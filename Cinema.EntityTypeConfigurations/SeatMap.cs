using Cinema.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.EntityTypeConfigurations
{
    public class SeatMap:EntityTypeConfiguration<Seat>
    {
        public SeatMap()
        {
            HasKey(s => s.Id);

            Property(s => s.SeatNo)
                 .IsRequired();

            Property(s => s.CreatedDate)
               .HasColumnName("CreatedDate")
               .HasColumnType("date")
               .IsRequired();

            Property(s => s.IsDeleted)
                .HasColumnName("IsDeleted");

            Property(s => s.UpdatedDate)
                .HasColumnName("UpdatedDate")
                .IsOptional();

            Property(s => s.UserId)
                .HasColumnName("UserId");

            Property(s => s.IsActive)
                .HasColumnName("IsActive");
            //Theater
            HasMany(u => u.Theaters)
               .WithMany(r => r.Seats)
               .Map(m =>
               {
                   m.ToTable("TheaterSeat");
                   m.MapLeftKey("SeatId");
                   m.MapRightKey("TheaterId");
               });
            //SeatSale
            HasMany(s => s.SeatSales)
                .WithRequired(ss => ss.Seat)
                .HasForeignKey(ss => ss.SeatId)
                .WillCascadeOnDelete(false);

            
        }
    }
}
