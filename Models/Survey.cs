using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Surveymb.Models
{
    public class Survey
    {
        public Survey()
        {
        }
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_modified { get; set; }
        public Guid rowguid { get; set; }
    }
}
