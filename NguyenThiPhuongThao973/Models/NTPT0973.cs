using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenThiPhuongThao973.Models
{
    public class NTPT0973
    {
        [Key]
        public int NTPTId { get; set; }
        public string NTPTName { get; set; }
        public string NTPTGender { get; set; }
    }
}
