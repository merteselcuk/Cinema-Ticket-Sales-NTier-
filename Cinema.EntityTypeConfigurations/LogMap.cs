using Cinema.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTypeConfigurations
{
    public class LogMap : EntityTypeConfiguration<Log>
    {
        public LogMap()
        {
            HasKey(l => l.Id);            

            Property(l => l.Table)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsRequired();
            
            Property(l => l.Data)
                .IsUnicode(false)
           .IsRequired();

            Property(l => l.DateTime)
                .HasColumnName("CreatedDate")
                .HasColumnType("datetime")
                .IsRequired();

            Property(l => l.UserId)
                .HasColumnName("UserId")
                .IsRequired();

        }
    }
}
