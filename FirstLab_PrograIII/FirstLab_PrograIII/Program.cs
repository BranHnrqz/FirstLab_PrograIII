/* Autor: Brandon Rodrigo Henríquez Mejía
   Materia: Programación III

Requerimientos: Elaborar una aplicación de consola con los siguientes datos:
                   1. Se ingresarán 4 datos nombres, edad, departamento y municipio.
                   2. Los municipios (8 por departamento) deberán estar en lasados al departamento seleccionado.
                   3. Al darle agregar el dato se guardarán en un arreglo.
                   4. Recorrer el arreglo y mostrar la edad.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLab_PrograIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarando Variables
            string nombre;
            string department; 
            string municipality;
            int age;

            //Declarando Arreglo
            string[] municipalityInDepartment;
            string[,] datos = new string[3, 4];

            //Ciclo para Agregar Datos de las Personas
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("¡Bienvenido! \nPorfavor, Ingresa los Siguientes Datos: " + (i + 1));
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Edad: ");
                age = int.Parse(Console.ReadLine());
                Console.Write("Departamento: ");
                department = Console.ReadLine();
                Console.Write("Municipio: ");
                municipality = Console.ReadLine();

                
                municipalityInDepartment = ExtractMunicipality(department);

                while (!Array.Exists(municipalityInDepartment, element => element == municipality))
                {
                    Console.WriteLine("Has Seleccionado un Municipio no Válido.");
                    Console.Write("Municipio: ");
                    municipality = Console.ReadLine();
                }


                datos[i, 0] = nombre;
                datos[i, 1] = age.ToString();
                datos[i, 2] = department;
                datos[i, 3] = municipality;
            }


            Console.WriteLine("Edades de las Personas Ingresadas: ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(datos[i, 1]);
            }

            Console.ReadKey();
        }

    }


    static string[] ExtractMunicipality(string department)
    {
            string[] municipality;

            switch (department)
            {
            case "Chalatengo":
                municipality = new string[] { "Nueva Concepción", "Tejutla", "Chalatengo", "Agua Caliente", "Arcatao", "Citalá", "La Palma", "San Ignacio" };
                break;

            case "San Salvador":
                municipality = new string[] { "San Salvador", "Aguilares", "Apopa", "Cuscatansingo", "Guazapa", "Ilopango", "Soyapango", "San Martín" };
                break;

            case "Usulután":
                municipality = new string[] { "Usulután", "Alegría", "Berlín", "California", "Concepción Batres", "El Triunfo", "Jiquilisco", "Jucuapa" };
                break;

            case "Sonsonate":
                municipality = new string[] { "Sonsonate", "Acajutla", "Armenia", "Caluco", "Izalco", "Juayúa", "Sonzacate", "Salcoatitán" };
                break;

            case "Santa Ana":
                municipality = new string[] { "Santa Ana", "Candelaria de la Frontera", "halchuapa", "Coatepeque", "El Congo", "El Porvenir", "Masahuat", "Metapán" };
                break;

            case "San Vicente":
                municipality = new string[] { "San Vicente", "Apastepeque", "Guadalupe", "San Cayetano Istepeque", "San Esteban Catarina", "San Esteban Catarina", "San Lorenzo", "San Sebastián" };
                break;

            case "San Miguel":
                municipality = new string[] { "San Miguel", "Chinameca", "Chapeltique", "Ciudad Barrios", "Nuevo Edén de San Juan", "El Tránsito", "El Tránsito", "San Sebastián" };
                break;

            default:
                    municipality = new string[] { };
                    break;
            }

            return municipality;
    }
}
