using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using MySQL.Data.EntityFrameworkCore;

namespace LeerData
{
    public class AppVentaCursosContext : DbContext
    {
        public AppVentaCursosContext(){
            Database.SetCommandTimeout(150000);
        }
        //private const string connectionString = @"Data Source=DESKTOP-G3IBS3P\SQLEXPRESS;Initial Catalog=CursosOnline;Integrated Security=True"; 
        private const string connectionStringMysql = @"server=db4free.net;port=3306;database=emeltec001db;user=emelgarejo;password=emeltec001;old guids=true;default command timeout=800";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            //optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.UseMySQL(connectionStringMysql);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<CursoInstructor>().HasKey(ci => new {ci.CursoId, ci.InstructorId});
        }

        public DbSet<Curso> Curso {get; set;}
        public DbSet<Precio> Precio {get; set;}
        public DbSet<Comentario> Comentario {get; set;}
        public DbSet<Instructor> Instructor {get; set;}
        public DbSet<CursoInstructor> CursoInstructor {get; set;}

    }
}