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
 //Conta corrente 
 
int numeroIdentificacao = RandomNumberGenerator.GetInt32(1, 101);
string titular = "Iago";
decimal saldo = 1000;
decimal limiteDebito  = 1200;

while(true)
{
    Console.Clear();
    System.Console.WriteLine("-----------------------------------");
    System.Console.WriteLine($"Conta Corrente de {titular}");
    System.Console.WriteLine("-----------------------------------");
    System.Console.WriteLine("1 - Saque\n2 - Depósito\n3 - Consulta de saldo\n4 - Sair");
    string opcaoMenu = Console.ReadLine()?.ToUpper();

    if (opcaoMenu == "S")
        break;

    switch (opcaoMenu)
    {
        case "1":
            System.Console.Write("Digite o valor que deseja sacar (R$): ");
            decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

            if (saldo <= limiteDebito)
            {
                System.Console.WriteLine("O valor do limite do débito ja foi ultrapassado!");
                Console.ReadLine();
                return;
            }
            else
            {
                saldo -= valorSaque;  
                System.Console.WriteLine("O valor foi sacado com sucesso!");  
                Console.ReadLine();       
            }

        break;

        case "2":
            System.Console.Write("Digite o valor que deseja depositar (R$): ");
            decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

            saldo += valorDeposito;
            System.Console.WriteLine("O valor foi depositado com sucesso!");  
            Console.ReadLine();   

        break;

        case "3":
            System.Console.Write($"O valor do saldo da conta é de (R$) é {saldo}");
            Console.ReadLine();
        break;

        case "4":
            System.Console.Write("");
        break;
    }
}