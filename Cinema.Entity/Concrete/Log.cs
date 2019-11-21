using Cinema.Enums;
using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entity.Concrete
{
    public class Log:IEntity
    {
        public Guid Id { get; set; }
        public string Table { get; set; }
        public ProcessTypeEnum ProcessType { get; set; }
        public string Data { get; set; }
        public DateTime DateTime { get; set; }
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public Guid RowGuid { get; set; }
        //* public string Ip {get;set;}
    }
}
