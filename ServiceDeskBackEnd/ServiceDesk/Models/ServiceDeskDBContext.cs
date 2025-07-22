using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ServiceDesk
{
    public partial class ServiceDeskDBContext : DbContext
    {
        public ServiceDeskDBContext() {}

        public ServiceDeskDBContext(DbContextOptions<ServiceDeskDBContext> options): base(options){}        

        public virtual DbSet<BookMarked> BookMarkeds { get; set; }
        public virtual DbSet<Resolution> Resolutions { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=ServiceDeskDB; Integrated Security=SSPI;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BookMarked>(entity =>
            {
                entity.ToTable("BookMarked");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BookMarkedBy).HasMaxLength(50);

                entity.Property(e => e.TicketId).HasColumnName("TicketID");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.BookMarkeds)
                    .HasForeignKey(d => d.TicketId)
                    .HasConstraintName("FK__BookMarke__Ticke__49C3F6B7");
            });

            modelBuilder.Entity<Resolution>(entity =>
            {
                entity.ToTable("Resolution");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}