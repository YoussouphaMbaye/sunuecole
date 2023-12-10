
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Diagnostics.Metrics;


namespace sunuecole.models
{
    public class CatalogDbContext: IdentityDbContext<IdentityUser>
    {
        public DbSet<Students> Students { get; set; }
        public DbSet<Classe> Classes { get; set; }
        
        public DbSet<Lesson> Lesson { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<RegisterClasse> RegisterClasse { get; set; }
        public DbSet<SchoolYear> SchoolYear { get; set; }
        public DbSet<Note> Note { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Hours> Hours { get; set; }
        public DbSet<DoClasse> DoClasses { get; set; }
        public DbSet<Evaluation> Evaluation { get; set; }
        public DbSet<MissOrHier> MissOrHier { get; set; }
        public DbSet<Supplies> Supplies { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<Agents> Agents { get; set; }
        public DbSet<InfSubscribe> InfSubscribe { get; set; }
        public DbSet<PaidSubscribe> PaidSubscribes { get; set; }
        //public DbSet<Login> Logins { get; set; }
        // public DbSet<PublicHolidays> PublicHolidays { get; set; }
        public CatalogDbContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);

            configurationBuilder.Properties<DateOnly>()
                                .HaveConversion<DateOnlyEFConverter>()
                                .HaveColumnType("date");

            configurationBuilder.Properties<TimeOnly>()
                      .HaveConversion<TimeOnlyEFConverter>()
                      .HaveColumnType("time");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //timeOnly conversion
            //Matiere prof evaluation
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Students>().HasMany(g => g.rClasse).WithOne(e => e.students).HasForeignKey(e => e.studentsId);
            modelBuilder.Entity<SchoolYear>().HasMany(g => g.rClasse).WithOne(e => e.schoolYear).HasForeignKey(e => e.schoolYearID);
            modelBuilder.Entity<Classe>().HasMany(g => g.rClasse).WithOne(e => e.classe).HasForeignKey(e => e.classeID);
           // modelBuilder.Entity<RegisterClasse>().HasIndex(i => new { i.studentsId, i.schoolYearID,i.classeID });
            modelBuilder.Entity<RegisterClasse>().HasIndex(i => new { i.studentsId, i.schoolYearID }).IsUnique();

            modelBuilder.Entity<Teacher>().HasMany(t => t.lessons).WithOne(l => l.teacher).HasForeignKey(t => t.idTeacher);
            modelBuilder.Entity<Lesson>().HasMany(t => t.evaluations).WithOne(e => e.lesson).HasForeignKey(e => e.lessonId);
            modelBuilder.Entity<Classe>().HasMany(l => l.lessons).WithOne(e => e.classe).HasForeignKey(e => e.classeId);
            modelBuilder.Entity<Evaluation>().HasMany(n => n.notes).WithOne(e => e.evaluation).HasForeignKey(e => e.evaluationId);
            modelBuilder.Entity<SchoolYear>().HasMany(g => g.evaluations).WithOne(e => e.schoolYear).HasForeignKey(e => e.schoolYearID);
            modelBuilder.Entity<SchoolYear>().HasMany(g => g.infSubscribes).WithOne(e => e.schoolYear).HasForeignKey(e => e.schoolYearID);
            modelBuilder.Entity<Students>().HasMany(n => n.notes).WithOne(e => e.student).HasForeignKey(e => e.studentId);

            modelBuilder.Entity<Room>().HasMany(n => n.doClasse).WithOne(e => e.room).HasForeignKey(e => e.roomId);
            //modelBuilder.Entity<Classe>().HasMany(n => n.doClasse).WithOne(e => e.classe).HasForeignKey(e => e.ClasseId);
            modelBuilder.Entity<Hours>().HasMany(n => n.doClasse).WithOne(e => e.hour).HasForeignKey(e => e.hourId);
            modelBuilder.Entity<Lesson>().HasMany(n => n.doClasse).WithOne(e => e.lesson).HasForeignKey(e => e.lessonId);
            //modelBuilder.Entity<DoClasse>().HasKey(i => new { i.weekDay, i.roomId, i.hourId });
            modelBuilder.Entity<DoClasse>().HasIndex(d => new { d.weekDay, d.roomId,d.hourId }).IsUnique(true);
            //infSubscribe annee et classe unique
            modelBuilder.Entity<InfSubscribe>().HasIndex(i => new { i.schoolYearID, i.classeID}).IsUnique(true);

            modelBuilder.Entity<Students>().HasMany(n => n.missOrHiers).WithOne(e => e.student).HasForeignKey(e => e.studentId);
            modelBuilder.Entity<DoClasse>().HasMany(n => n.missOrHiers).WithOne(e => e.doClasse).HasForeignKey(e => e.doClasseId);
            
            modelBuilder.Entity<Classe>().HasMany(n => n.infSubscribes).WithOne(e => e.classe).HasForeignKey(e => e.classeID);
            modelBuilder.Entity<Tutor>().HasMany(n => n.students).WithOne(e => e.Tutor).HasForeignKey(e => e.TutorID);
            //for paid subscriber
            modelBuilder.Entity<Students>().HasMany(n => n.paidSubscribes).WithOne(e => e.student).HasForeignKey(e => e.studentsID);
            modelBuilder.Entity<InfSubscribe>().HasMany(n => n.paidSubscribes).WithOne(e => e.infSubscribe).HasForeignKey(e => e.InfSubscribeID);




            //Entity<Employer>().Property(p => p.BirthDay).HasConversion<DateOnlyConverter>().HaveColumnType("date");


        }
        public override int SaveChanges()
        {
            try {
                var entries = ChangeTracker.Entries()

            .Where(e => e.Entity is BaseEntity && (
                    e.State == EntityState.Added
                    || e.State == EntityState.Modified));

                foreach (var entityEntry in entries)
                {
                    ((BaseEntity)entityEntry.Entity).UpdatedDate = DateTime.Now;

                    if (entityEntry.State == EntityState.Added)
                    {
                        ((BaseEntity)entityEntry.Entity).CreatedDate = DateTime.Now;
                    }
                }
                return base.SaveChanges();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return 0;
            

        }


    }
    public class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
    {
        /// <summary>
        /// Creates a new instance of this converter.
        /// </summary>
        public DateOnlyConverter() : base(
                d => d.ToDateTime(TimeOnly.MinValue),
                d => DateOnly.FromDateTime(d))
        { }
    }
    
}
