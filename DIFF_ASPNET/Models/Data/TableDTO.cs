using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DIFF_ASPNET.Models.Data
{
    [Table("Table")]
    public class TableDTO
    {
        public int StationId { get; set; }
        public string Name { get; set; }
        public string Adres { get; set; }
    }
}