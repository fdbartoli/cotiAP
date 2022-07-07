using CotiAP.Entities;
using CotiAP.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotiAP.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CategoriaLogic categoriaLogic = new CategoriaLogic();
            CondicionLogic condicionLogic = new CondicionLogic();

            foreach(Categoria categoria in categoriaLogic.GetAll())
            {
                Console.WriteLine($"Categoria: {categoria.numeroCategoria}\nTasa: {categoria.tasa}\nTasa Asistencia médica {categoria.tasaAsitencia}");
            }

            //Console.ReadKey();
            //Console.Clear();

            //foreach (Condicion condicion in condicionLogic.GetAll())
            //{
            //    Console.WriteLine($"Condicion: {condicion.nombre}\nTasa: {condicion.tasa}");
            //}

            //Console.ReadKey();


            //categoriaLogic.Add(new Categoria
            //{
            //    IdCategoria = 11,
            //    numeroCategoria = "11",
            //    tasa = 10,
            //    tasaAsitencia= 11.2

            //});


            //categoriaLogic.Delete(11);

            //foreach (Categoria categoria in categoriaLogic.GetAll())
            //{
            //    Console.WriteLine($"Categoria: {categoria.numeroCategoria}\nTasa: {categoria.tasa}\nTasa Asistencia médica {categoria.tasaAsitencia}");
            //}

            //Console.ReadKey();

        }
    }
}
