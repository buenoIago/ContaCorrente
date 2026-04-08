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

        TelaPrincipal tela = new TelaPrincipal();
        ContaCorrente contaAcessada = contaUm;

        while(true)
        { 

            string? opcaoMenu = tela.ApresentarOpcoesMenu(contaAcessada);

            switch (opcaoMenu)
            {
                case "S":
                return;

                case "1":
                tela.ApresentarOperacaoSaque(contaAcessada);
                continue;

                case "2":
                tela.ApresentarOperacaoDeposito(contaAcessada);
                continue;

                case "3":
                tela.ApresentarOperacaoTransferencia(contaAcessada, contaDestino: ContaDois);
                continue;

                case "4":
                tela.ApresentarOperacaoObterSaldo(contaAcessada);
                continue;
            }
        }
    }
}