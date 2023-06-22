using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace softinfovm.Models
{
    [Table("sectionD")]
    public class SectionDModel
    {
        public string sectionCode { get; set; }
        [Key]
        public string subsectionCode { get; set; }
        public string subsectionName { get; set; }
    }
}