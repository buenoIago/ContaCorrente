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
        ContaCorrente contaUm = new ContaCorrente();
        //conta corrente 1
        contaUm.numeroIdentificacao = RandomNumberGenerator.GetInt32(1, 101);
        contaUm.titular = "Iago";
        contaUm.saldo = 1000;
        contaUm.limiteDebito = 1200;

        //conta corrente 2
        ContaCorrente ContaDois = new ContaCorrente();
        ContaDois.numeroIdentificacao = RandomNumberGenerator.GetInt32(1, 101);
        ContaDois.titular = "Yuri";
        ContaDois.saldo = 12000;
        ContaDois.limiteDebito = 6000;

    while(true)
    {   
        //Conta corrente 
        Console.Clear();
        System.Console.WriteLine("-----------------------------------");
        System.Console.WriteLine($"Conta Corrente de {contaUm.titular} - {contaUm.numeroIdentificacao}");
        System.Console.WriteLine("-----------------------------------");
        System.Console.WriteLine("1 - Saque\n2 - Depósito\n3 - Transferir\n4 - Consulta de saldo\n5 - Sair");
        string opcaoMenu = Console.ReadLine()?.ToUpper();

        if (opcaoMenu == "S")
            break;

            switch (opcaoMenu)
            {
                case "1":
                    contaUm.Sacar();
                break;

                case "2": 
                    contaUm.Despositar();
                break;

                case "3":
                    contaUm.TransferirPara(ContaDois);
                break;

                case "4":
                    contaUm.ObterSaldo();
                break;

                default:
                System.Console.WriteLine("Selecione uma opção válida!");
                return;
            }
        }
    }
}

