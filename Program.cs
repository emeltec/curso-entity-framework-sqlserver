using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Collections.Generic;
using System.Linq;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* using( var db = new AppVentaCursosContext()){
                var cursos = db.Curso.AsNoTracking();
                foreach(var curso in cursos){
                    Console.WriteLine(curso.Titulo + curso.Descripcion);
                }
            } */
            /* using( var db = new AppVentaCursosContext()){
                var cursos = db.Curso.Include(p => p.PrecioPromocion).AsNoTracking();
                foreach(var curso in cursos){
                    Console.WriteLine(curso.Titulo +" "+ curso.PrecioPromocion.PrecioActual);
                }
            } */

            /* using( var db = new AppVentaCursosContext()){
                var cursos = db.Curso.Include(c => c.ComentarioLista).AsNoTracking();
                foreach(var curso in cursos){
                    Console.WriteLine(curso.Titulo);
                    foreach(var comentario in curso.ComentarioLista){
                        Console.WriteLine("\t"+comentario.ComentarioTexto +" -->"+ comentario.Alumno);
                    }
                }
            } */

            /* using( var db = new AppVentaCursosContext()){
                var cursos = db.Curso.Include(c => c.InstructorLink).ThenInclude(ci => ci.Instructor);
                foreach(var curso in cursos){
                    Console.WriteLine(curso.Titulo);
                    foreach(var insLink in curso.InstructorLink){
                        Console.WriteLine("*******"+insLink.Instructor.Nombre);
                    }
                }
            } */

            /* using( var db = new AppVentaCursosContext()){
                var nuevoInstructor1 = new Instructor{
                    Nombre = "Adelina",
                    Apellidos = "Perez",
                    Grado = "Expert UI"
                };
                db.Add(nuevoInstructor1);
                var nuevoInstructor2 = new Instructor{
                    Nombre = "Delia",
                    Apellidos = "De Melgarejo",
                    Grado = "Master en Informatica"
                };
                db.Add(nuevoInstructor2);

                var estadoTransaccion = db.SaveChanges();
                Console.WriteLine(estadoTransaccion);
            } */

            /* using(var db = new AppVentaCursosContext()){
                var instructor = db.Instructor.Single(p => p.Nombre == "Angela");
                if(instructor != null){
                    instructor.Nombre = "Sandra";
                    instructor.Apellidos = "Alvarado";
                    instructor.Grado = "Procesos de pagos";
                    var estadoTransaccion = db.SaveChanges();
                    Console.WriteLine("El estado de la transaccion es: " + estadoTransaccion);
                }
            } */

            using(var db = new AppVentaCursosContext()){
                var instructor = db.Instructor.Single(p => p.InstructorId == 7);
                if(instructor != null){
                    db.Remove(instructor);
                    var estadoTransaccion = db.SaveChanges();
                    Console.WriteLine("El estado de la transaccion es: " + estadoTransaccion);
                }
            }

        }
    }
}
