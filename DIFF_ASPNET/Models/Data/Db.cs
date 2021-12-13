using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DIFF_ASPNET.Models.Data
{
    public class Db : DbContext
    {
        public DbSet<TableDTO> Tables { get; set; }
        public DbSet<DataDTO> Datas { get; set; }
    }
}