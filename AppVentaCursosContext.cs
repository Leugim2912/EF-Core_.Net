using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace LeerData
{
    public class AppVentaCursosContext : DbContext
    {
        public AppVentaCursosContext(){
            DatabaseGeneratedAttribute.SetCommandTimeout(150000);
        }
        private const string connection = @"Data Source=LAPTOP-KP0BTVE0;Initial Catalog=CursoUdemyNet;Integrated Security=True";
        private const string connectionMySql = @"server=db4free.net;port=3306;database=margred7334;user=margred;password=password1234;old guids=true;default command timeout=800";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            //optionsBuilder.UseSqlServer(connection);
            optionsBuilder.UseMySQL(connectionMySql);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<CursoInstructor>().HasKey(ci => new {ci.CursoId, ci.InstructorId});
        }

        public DbSet<Curso> Curso{get;set;}
        public DbSet<Precio> Precio{get;set;}
        public DbSet<Comentario> Comentario{get;set;}
        public DbSet<Instructor> Instructor{get;set;}
        public DbSet<CursoInstructor> CursoInstructor{get;set;}

        
    }
}