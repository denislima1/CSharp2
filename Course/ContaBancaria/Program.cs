//using System;
//using System.Globalization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ContaBancaria conta;

//            Console.Write("Digite o número da conta: ");
//            int numero = int.Parse(Console.ReadLine());

//            Console.Write("Digite o titular da Conta: ");
//            string titular = Console.ReadLine();

//            Console.Write("Haverá depósito inicial (S/N) ? ");
//            char resp = char.Parse(Console.ReadLine());

//            if (resp == 's' || resp == 'S')
//            {
//                Console.Write("Digite o valor de depósito incial: ");
//                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                conta = new ContaBancaria(numero, titular, depositoInicial);
//            }
//            else
//            {
//                conta = new ContaBancaria(numero, titular);
//            }

//            Console.WriteLine();
//            Console.WriteLine("Dados da Conta: ");
//            Console.WriteLine(conta);

//            Console.WriteLine();

//            Console.Write("Entre um valor para depósito: ");
//            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            conta.Deposito(quantia);

//            Console.WriteLine("Dados da conta atualizados: ");
//            Console.WriteLine(conta);

//            Console.WriteLine();

//            Console.Write("Entre um valor para saque: ");
//            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            conta.Saque(quantia);

//            Console.WriteLine();

//            Console.WriteLine("Dados da conta atualizados: ");
//            Console.WriteLine(conta);



//            Console.ReadLine();
//        }
//    }
//}