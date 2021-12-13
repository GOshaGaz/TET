using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DIFF_ASPNET.Models.Data
{
    [Table("tbData")]
    public class DataDTO
    {
        public int DataId { get; set; }
        public int Name { get; set; }
        public bool Price {get;set;}
        public int AmountOfFuel { get; set; }
        
        public int StationId { get; set; }
        [ForeignKey("Table")]
        public virtual TableDTO Table { get; set; }
    }
}