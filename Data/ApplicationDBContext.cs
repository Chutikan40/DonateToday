using DonateToday.Models;
using Microsoft.EntityFrameworkCore;

namespace DonateToday.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }    //เป็นการนำตัว model student มาใช้งานเพื่อพร้อมาสำหรับการทำ data base
    }
}
