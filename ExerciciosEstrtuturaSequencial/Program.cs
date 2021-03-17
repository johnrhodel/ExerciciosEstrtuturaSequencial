using System;
using System.Globalization;
namespace ExerciciosEstrtuturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {

             //Exercicio 1
            int soma;

            Console.WriteLine("Entre com o valor de A: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de B: ");
            int B = int.Parse(Console.ReadLine());

            soma = A + B;

            Console.WriteLine("A soma é : " + soma);

            // Exercicio 2

            double area;
            Console.WriteLine("Entre com o valor de r: ");
            double R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;
            Console.WriteLine("Entre com o valor de PI: ");
            double Pi = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = Pi * (Math.Pow(R, 2.0));

            Console.WriteLine("O valor da área é : " + area.ToString("f4", CultureInfo.InvariantCulture));

            // Exercicio 3

            int dif;

            Console.WriteLine("Entre com o valor de A: ");
            int AA = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de B: ");
            int BB = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de C: ");
            int CC = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de D: ");
            int DD = int.Parse(Console.ReadLine());

            dif = AA*BB-CC*DD;

            Console.WriteLine("A diferença dos produtos é : " + dif);

            //Exercicio 4


            double  totalsalary;

            Console.WriteLine("Enter with number : ");
            int NUMBER = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter with hours : ");
            int HOURS = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter with Salary per hour : ");
            double SALARYPERHOUR = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            totalsalary = HOURS * SALARYPERHOUR;

            Console.WriteLine("The number is : " + NUMBER);

            Console.WriteLine("Total salary is : u$ " + totalsalary.ToString("f2", CultureInfo.InvariantCulture));

            // Exercicio 5

             double valorapagar;

            String[] vet1 = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(vet1[0]);
             int qtdade1 = int.Parse(vet1[1]);
              double valor1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            String[] vet2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(vet2[0]);
            int qtdade2= int.Parse(vet2[1]);
            double valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            valorapagar = qtdade1 * valor1 + qtdade2 * valor2;

            Console.WriteLine("o valor a pagar é: " + valorapagar.ToString("F2", CultureInfo.InvariantCulture) + " R$ .");


            // Exercicio 6

            double Atriangulo, Acirculo, Atrapezio, Aquadrado, Aretangulo, PI = 3.14159;

            Console.WriteLine("Entre com os valores de Aa, Bb e Cb: ");
            string[] vet = Console.ReadLine().Split(' ');
            double Aa = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double Bb = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double Cc = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Atriangulo = Aa * Cc / 2;
            Acirculo = PI * (Math.Pow(Cc, 2));
            Atrapezio = ((Aa + Bb) * Cc) / 2;
            Aquadrado = Math.Pow(Bb, 2);
            Aretangulo = Aa * Bb;

            Console.WriteLine("A área do triangulo e: " + Atriangulo.ToString("F3", CultureInfo.InvariantCulture) + " U.M.");
            Console.WriteLine("A área do circulo e: " + Acirculo.ToString("F3", CultureInfo.InvariantCulture) + " U.M.");
            Console.WriteLine("A área do trapezio e: " + Atrapezio.ToString("F3", CultureInfo.InvariantCulture) + " U.M.");
            Console.WriteLine("A área do quadrado e: " + Aquadrado.ToString("F3", CultureInfo.InvariantCulture) + " U.M.");
            Console.WriteLine("A área do retangulo e: " + Aretangulo.ToString("F3", CultureInfo.InvariantCulture) + " U.M.");

        }


    }
}
