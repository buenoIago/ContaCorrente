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

class ContaCorrente
{
    public int numeroIdentificacao = RandomNumberGenerator.GetInt32(1, 101);
    public string titular;
    public decimal saldo;
    public decimal limiteDebito;

    public void Sacar()
    {
        System.Console.Write("Digite o valor que deseja sacar (R$): ");
        decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

        if (saldo <= limiteDebito)
        {
            System.Console.WriteLine("O valor do limite do débito ja foi ultrapassado!");
            Console.ReadLine();
        }
        else
        {
            saldo -= valorSaque;  
            System.Console.WriteLine("O valor foi sacado com sucesso!");  
            Console.ReadLine();       
        }     
    }
    public void Despositar()
    {
        System.Console.Write("Digite o valor que deseja depositar (R$): ");
        decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

        saldo += valorDeposito;
        System.Console.WriteLine("O valor foi depositado com sucesso!");  
        Console.ReadLine();          
    }
    public void TransferirPara(ContaCorrente contaDestino)
    {
        System.Console.Write($"Digite o valor que deseja transferir (R$):");
        decimal valorTranferencia = Convert.ToDecimal(Console.ReadLine());

        saldo -= valorTranferencia;
        contaDestino.saldo += valorTranferencia; 

        System.Console.WriteLine($"O valor de R${valorTranferencia} foi tranferido com sucesso!");
        Console.ReadLine();     
    }
    public void ObterSaldo()
    {
        System.Console.Write($"O valor do saldo é R${saldo}.");
        Console.ReadLine();        
    }
}

