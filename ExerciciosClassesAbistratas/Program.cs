using System;
using ExerciciosClassesAbistratas.Entidades.Enums;
using ExerciciosClassesAbistratas.Entidades;
using System.Collections.Generic;
using System.Globalization;

namespace ExerciciosClassesAbistratas {
    class Program {
        static void Main(string[] args) {

            List<Forma> lista = new List<Forma>();

            Console.Write("Entre com o número de Formas: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Dados da {i}º Área: ");
                Console.Write("Retangulo ou Circulo (r/c)? ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Color (Preto/Azul/Vermelho): ");
                Cores cores = Enum.Parse<Cores>(Console.ReadLine());
                if (tipo == 'r') {
                    Console.Write("Largura: " );
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Retangulo(largura, altura, cores));
                }
                else {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Circulo(raio, cores));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Áreas das Formas:");
            foreach (Forma forma in lista) {
                Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
