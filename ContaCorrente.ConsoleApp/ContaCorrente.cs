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
    public int numeroIdentificacao;
    public string titular;
    public decimal saldo;
    public decimal limiteDebito;

    public bool Sacar(decimal valorSaque)
    {
        if (valorSaque > saldo + limiteDebito)
            return false;

        saldo -= valorSaque;

        return true;
    }

    public void Depositar(decimal valorDeposito)
    {
        saldo += valorDeposito;
    }

    public bool TransferirPara(ContaCorrente contaDestino, decimal valorTransferencia)
    {
        bool conseguiuSacar = this.Sacar(valorTransferencia);

        if (!conseguiuSacar)
            return false;

        contaDestino.Depositar(valorTransferencia);

        return true;
    }

    public decimal ObterSaldo()
    {
        return saldo;
    }
}