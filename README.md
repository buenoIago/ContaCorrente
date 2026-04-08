# CONTA CORRENTE

## Projeto

Desenvolvido por **Iago** durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net) 2026

## INTRODUÇÃO

Este projeto foi desenvolvido em C# com execução via Console, com o objetivo de simular um sistema bancário simples de contas correntes.

O sistema permite realizar operações como saque, depósito, transferência entre contas e consulta de saldo, aplicando conceitos fundamentais de programação orientada a objetos e lógica de negócios.


## FUNCIONALIDADES
* Criação de múltiplas contas correntes.
* Geração automática de número de identificação.
* Sistema de saque com limite de débito.
* Depósito de valores na conta.
* Transferência entre contas.
* Consulta de saldo em tempo real.
* Interface interativa via console.
* Validação de operações (ex: limite excedido).
* Estrutura modular com separação de responsabilidades (Program, TelaPrincipal, ContaCorrente).

## REGRAS DE NEGÓCIO
O saque só é permitido se o valor não ultrapassar o saldo + limite de débito
Transferências utilizam a mesma validação de saque
Depósitos aumentam diretamente o saldo da conta
Cada conta possui:
* Número de identificação
* Titular
* Saldo
* Limite de débito

## Como utilizar

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.

   ```
   dotnet restore
   ```

4. Para executar o projeto compilando em tempo real

   ```bash
   dotnet run --project ContaCorrente.ConsoleApp
   ```

## Requisitos

- .NET 10.0 SDK