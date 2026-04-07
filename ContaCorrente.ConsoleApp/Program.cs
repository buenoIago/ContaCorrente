/*
    pilar da programação orientada á objetos -> abstração

    uma conta corrente é composta por diversos atributos essenciais para sua operação.
    Ela possui um número de identificação único, um saldo disponível e um limite de
    débito estabelecido.

    saque: permite a retirada de valores, respeitando o limite máximo permitido.
    depósito: possibilita a adição de fundos á conta.
    consulta de saldo: fornece informações atualizadas sobre o montante disponível.
*/

using System.Security.Cryptography;

class Program
{
    static void Main (string[] args)
    {      

        //conta corrente 1
        ContaCorrente contaUm = new ContaCorrente();
        contaUm.numeroIdentificacao = RandomNumberGenerator.GetInt32(1, 101);
        contaUm.titular = "Iago";
        contaUm.saldo  = 400;
        contaUm.limiteDebito = 1200;

        //conta corrente 2
        ContaCorrente ContaDois = new ContaCorrente();
        ContaDois.numeroIdentificacao = RandomNumberGenerator.GetInt32(1, 101);
        ContaDois.titular = "Yuri";
        ContaDois.saldo = 12000;
        ContaDois.limiteDebito = 6000;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Conta Corrente #{contaUm.numeroIdentificacao} de {contaUm.titular}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1 - Saque");
            Console.WriteLine("2 - Depósito");
            Console.WriteLine("3 - Transferência");
            Console.WriteLine("4 - Consulta de Saldo");
            Console.WriteLine("S - Sair");
            Console.WriteLine("-------------------------------------");
            Console.Write("Digite uma opção válida: ");
            string? opcaoMenu = Console.ReadLine()?.ToUpper();

            if (opcaoMenu == "S")
                break;

            if (opcaoMenu == "1")
            {
                Console.WriteLine("-------------------------------------");
                Console.Write("Digite o valor que deseja sacar (R$): ");
                decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

                bool conseguiuSacar = contaUm.Sacar(valorSaque);

                if (!conseguiuSacar)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("O valor do limite de débito foi ultrapassado!");
                }
                else
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("O valor foi sacado com sucesso!");
                }

                Console.WriteLine("-------------------------------------");
                Console.Write("Digite ENTER para continuar...");
                Console.ReadLine();
            }
            else if (opcaoMenu == "2")
            {
                Console.WriteLine("-------------------------------------");
                Console.Write("Digite o valor que deseja depositar (R$): ");
                decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

                contaUm.Depositar(valorDeposito);

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("O valor foi depositado com sucesso!");
                Console.WriteLine("-------------------------------------");
                Console.Write("Digite ENTER para continuar...");
                Console.ReadLine();
            }
            else if (opcaoMenu == "3")
            {
                Console.WriteLine("-------------------------------------");
                Console.Write("Digite o valor que deseja transferir (R$): ");
                decimal valorTransferencia = Convert.ToDecimal(Console.ReadLine());

                bool conseguiuTransferir = contaUm.TransferirPara(ContaDois, valorTransferencia);

                if (!conseguiuTransferir)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine($"Não foi possível transferir o valor de R${valorTransferencia}!");
                }
                else
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine($"O valor de R${valorTransferencia} foi tranferido com sucesso!");
                }

                Console.WriteLine("-------------------------------------");
                Console.Write("Digite ENTER para continuar...");
                Console.ReadLine();
            }
            else if (opcaoMenu == "4")
            {
                decimal saldo = contaUm.ObterSaldo();

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("O valor do saldo da conta é de (R$): " + saldo);
                Console.WriteLine("-------------------------------------");
                Console.Write("Digite ENTER para continuar...");
                Console.ReadLine();
            }
        }
    }
}