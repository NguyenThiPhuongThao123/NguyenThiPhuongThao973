using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenThiPhuongThao973.Models
{
    public class PersonNTPT973
    {
        [Key]
        public int PersonId { get; set; }
        public string PersonName { get; set; }
    }
}
