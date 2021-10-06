using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenThiPhuongThao973.Models
{
    public class NTPT0973
    {
        [Key]
        public int NTPTId { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string NTPTName { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string NTPTGender { get; set; }

    }
}
