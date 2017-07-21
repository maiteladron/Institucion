using Institucion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion
{
    class Program
    {
        static void Main(string[] args)
        {
            public void Rutina1()
            {
                Console.WriteLine("GESTIÓN DE INSTITUCION:");
                Persona[] lista = new Persona[3];
                lista[0] = new Alumno("Tere", "Asurmendi");

                var alumno1 = new Alumno("maite", "ladron")
                {
                    Id = 1,
                    Edad = 31,
                    Telefono = "123456789",
                    Email = "mai@maite.com"
                };
                /* var persona1 = new Persona()
                 {
                     Id = 2,
                     Nombre = "Maite",
                     Apellido = "Ladron",
                     Edad = 31,
                     Telefono = "123456789"
                 };*/

                Persona pe = new Profesor()
                {
                    Id = 2,
                    Nombre = "Maite",
                    Apellido = "Ladron",
                    Edad = 31,
                    Telefono = "123456789",
                    Catedra = "programación"
                };
                //persona1 = alumno1;
                //persona1.Telefono = "987654321";

                //Persona a = profesor1;
                //Persona b = alumno1;

                //alumno1.
                Console.WriteLine(Persona.ContadorPersonas);
                Console.WriteLine("RESUMENES");
                /*
                            foreach (Persona p in lista)
                            {
                                //Console.WriteLine($"Tipo {p.GetTipe()}"};
                                //Console.WriteLine
                                IEnteInstituto ente = p;
                                ente.ConstruirLlaveSecreta("Hola");
                            }

                          Console.WriteLine("S T R U C T S");
                           CursoStruct c = new CursoStruc(70);
                           char.Curso = "101-B";

                           CursoStruc newC = new CursoStruct();
                           newC = "564-A";

                           var cursoFreak = char;
                           cursoFreak.Curso = "666-G";

                           Console.writeline($"Curso c = {c.Curso}");
                           Console.writeline($"Curso Freak = {cursoFreak.Curso}");
                           Console.ReadLine();



                            Console.WriteLine("C L A S S");
                           CursoClass c_class = new CursoClass(70);
                           char.CursoClass = "101-B";

                           Cursoclass newC_class = new CursoClass();
                           newC_class = "564-A";

                           var cursoFreak_class = char;
                           cursoFreak_CLASS.Curso = "666-G";

                           Console.writeline($"Curso c_class = {c_class.Curso}");
                           Console.writeline($"Curso Freak = {cursoFreak_class.Curso}");*/

                Console.WriteLine("ENUMERACIONES");
                var alumnoEst = new Alumno("Fredy", "Vega")
                {
                    Id = 22,
                    Edad = 31,
                    Telefono = "123456789",
                    //Estado = (EstadosAlumno) 89
                    Estado = EstadosAlumno.Activo
                };
                Console.WriteLine($"Tipo{ typeof(EstadosAlumno)} ");
                Console.WriteLine($"Tipo{ typeof(Alumno)} ");
                Console.WriteLine($"Tipo{ alumnnoEst.GetType() } ");

                Console.WriteLine($"Tipo{ nameof(Alumno)} ");
                Console.WriteLine($"Tipo{ sizeof(int)} "); 
            }

            Console.ReadLine();
        }
    }
}
