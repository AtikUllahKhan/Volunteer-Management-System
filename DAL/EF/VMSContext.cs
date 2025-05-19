using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class VMSContext: DbContext
    {
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<TokenVol> TokenVols { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Volunteer>()
                .HasRequired(v => v.Admin)
                .WithMany(a => a.Volunteers)
                .HasForeignKey(v => v.AdminId)
                .WillCascadeOnDelete(false);  // Prevents multiple cascade paths

            base.OnModelCreating(modelBuilder);
        }
    }
}
