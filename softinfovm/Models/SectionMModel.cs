using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace softinfovm.Models
{
    [Table("sectionM")]
    public class SectionMModel
    {
        [Key]
        public string sectionCode { get; set; }
        public string sectionName { get; set; }
    }
}