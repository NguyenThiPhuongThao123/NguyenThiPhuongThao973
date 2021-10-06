using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenThiPhuongThao973.Models
{
    public class PersonNTPT973
    {
        [Key]
        public int PersonId { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string PersonName { get; set; }

    }
}

