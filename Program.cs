using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppVentaCursosContext()){
//             var cursos = db.Curso.AsNoTracking();
//             var cursos = db.Curso.Include(p=>p.Precio).AsNoTracking(); 
//             var cursos = db.Curso.Include(c => c.ComentarioLista).AsNoTracking();

//             var cursos = db.Curso.Include(ci => ci.InstructorLink).ThenInclude(i => i.Instructor);

               //el siguiente ciclo es para estructuras de uno a muchos
/*               foreach(var curso in cursos){
                   Console.WriteLine(curso.Titulo);
                   foreach(var inslink in curso.InstructorLink){
                       Console.WriteLine(" ***** "+inslink.Instructor.Nombre);
                   }
               } 
                //para insertar un nuevo registro a la BD
                var nuevoinst1 = new Instructor{
                    Nombre = "Juan",
                    Apellidos = "Perez",
                    Grado = "DB Admin"
                };
                db.Add(nuevoinst1);

                //Se crea una variable que almacene el estado de la transaccion
                var estado = db.SaveChanges();
                Console.WriteLine("Estado: "+estado);
                }

                //para actualizar un registro
                var inst = db.Instructor.Single(p => p.Nombre == "Lorenzo");
                if (inst!=null){
                    inst.Apellidos = "prueba";
                    inst.Grado = "biologo";
                    var estado = db.SaveChanges();
                    Console.WriteLine("Estado: "+estado);
                }else{
                    Console.WriteLine("Registro no encontrado");
                }
                //Eliminar un registro
                var inst = db.Instructor.Single(p=>p.InstructorId == 3);
                if(inst!=null){
                    db.Remove(inst);
                    var estado = db.SaveChanges();
                    Console.WriteLine("estado: "+estado);
                } 
*/           
                 db.Database.Migrate();                 
            }
        }
    }
}
