using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Surveymb.Models
{
    public class Question
    {
        public Question()
        {
        }
        [Key]
        public int id { get; set; }
        public int question_type { get; set; }
        public string title { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_modified { get; set; }
        public Guid rowguid { get; set; }
    }
}
