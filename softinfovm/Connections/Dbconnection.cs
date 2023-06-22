using softinfovm.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace softinfovm.Connections
{
    public class Dbconnection : DbContext
    {
        public DbSet<SectionMModel> sectionMModels { get; set; }
        public DbSet<SectionDModel> SectionDModels { get; set; }
    }
}