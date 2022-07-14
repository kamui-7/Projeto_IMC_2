using System;

namespace IMC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Entre com a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com o Peso: ");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com o Altura: ");
            float altura = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O seu nome é : " + nome);
            Console.WriteLine("A sua idade é de :" + idade + " anos.");
            Console.WriteLine("Seu peso é de :" + peso + " kg.");
            Console.WriteLine("Sua altura é de :" + altura + " m.");

            float imc = peso / (altura * altura);

            Console.WriteLine("O seu IMC é de :" + imc + " kg/m2");

            if (imc < 18.5)
            {
                Console.WriteLine("Você esta Abaixo do Peso.");
            }
            else if (imc > 18.5 && imc < 25)
            {
                Console.WriteLine("Você esta com Peso Normal.");
            }
            else if (imc > 25 && imc < 30)
            {
                Console.WriteLine("Você esta com Sobrepeso.");
            }
            else
            {
                Console.WriteLine("Você esta com Obesidade.");
            }
        }
    }
}
