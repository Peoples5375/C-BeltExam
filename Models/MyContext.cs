using Microsoft.EntityFrameworkCore;

namespace BeltExam.Models
{
    
        public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        
        // this is the variable we will use to connect to the MySQL table, Lizards
        public DbSet<User> Users { get; set; }
        public DbSet<DojoActivity> DojoActivities { get; set; }
        public DbSet<Invite> Invites { get; set; }

    }
}
