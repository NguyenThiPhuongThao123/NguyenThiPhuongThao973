using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenThiPhuongThao973.Models;

namespace NguyenThiPhuongThao973.Data
{
    public class NguyenThiPhuongThao973Context : DbContext
    {
        public NguyenThiPhuongThao973Context (DbContextOptions<NguyenThiPhuongThao973Context> options)
            : base(options)
        {
        }

        public DbSet<NguyenThiPhuongThao973.Models.PersonNTPT973> PersonNTPT973 { get; set; }

        public DbSet<NguyenThiPhuongThao973.Models.NTPT0973> NTPT0973 { get; set; }
    }
}
