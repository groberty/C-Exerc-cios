using System;
using System.Globalization;

namespace projeto_1 {
    class Program {
        static void Main(string[] args) {
            /*Console.WriteLine("Hello World! Digite alguma coisa");
            String[] frase = Console.ReadLine().Split(' ');
            String a = frase[0];
            String b = frase[1];
            String c = frase[2];

            Console.WriteLine(a+" - "+b+"-"+c);

            Console.WriteLine("Digite um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um char: ");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite um double: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            */

            string[] vet= Console.ReadLine().Split(' ');

            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


            Console.WriteLine("Você digitou: "); 
            Console.WriteLine(nome); 
            Console.WriteLine(sexo); 
            Console.WriteLine(idade); 
            Console.WriteLine(altura); 
        }
    }
}