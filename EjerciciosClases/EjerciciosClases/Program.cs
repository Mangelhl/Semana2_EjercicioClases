using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while(continuar)
        {
            Console.WriteLine("Elige una figura:");
            Console.WriteLine("1. Rectangulo");
            Console.WriteLine("2. Cuadrado");
            Console.WriteLine("3. Circulo");
            Console.WriteLine("4. Triangulo");
            Console.WriteLine("5. Salir");
            Console.Write("Opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese la base del rectángulo: ");
                    int baseRectangulo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese la altura del rectángulo: ");
                    int alturaRectangulo = Convert.ToInt32((Console.ReadLine());
                    EjercicioFigura rectangulo = new Rectangulo(baseRectangulo, alturaRectangulo);
                    Console.WriteLine($"El área del rectángulo es: {rectangulo.CalculaArea()}");
                    break;
                case "2":
                    Console.Write("Ingrese el lado del cuadrado: ");
                    int ladoCuadrado = Convert.ToInt32((Console.ReadLine());
                    EjercicioFigura cuadrado = new Cuadrado(ladoCuadrado);
                    Console.WriteLine($"El área del cuadrado es: {cuadrado.CalculaArea()}");
                    break;
                case "3":
                    Console.Write("Ingrese el radio del círculo: ");
                    int radioCirculo = Convert.ToInt32((Console.ReadLine());
                    EjercicioFigura circulo = new Circulo(radioCirculo);
                    Console.WriteLine($"El área del círculo es: {circulo.CalculaArea()}");
                    break;
                case "4":
                    Console.Write("Ingrese la base del triángulo: ");
                    int baseTriangulo = Convert.ToInt32((Console.ReadLine());
                    Console.Write("Ingrese la altura del triángulo: ");
                    int alturaTriangulo = Convert.ToInt32(Console.ReadLine());
                    EjercicioFigura triangulo = new Triangulo(baseTriangulo, alturaTriangulo);
                    Console.WriteLine($"El área del triángulo es: {triangulo.CalculaArea()}");
                    break;
                case "5":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            if (continuar)
            {
                Console.Write("¿Quieres seleccionar otra figura? (s/n): ");
                string respuesta = Console.ReadLine();
                continuar = respuesta.ToLower() == "s";
            }
        }
    }

}

