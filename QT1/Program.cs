/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
•   Contextualização: Em um jogo de RPG, o jogador precisa inserir as informações básicas do
    personagem antes de começar a aventura.

•   Comando: Crie um programa que receba o nome, idade, nível inicial, classe, e raça do
    personagem e exiba esses dados no console.

@Lista: 01 - Lógica de Programação
@Autor: Milton Roney de Oliveira Nobre
@Data: 19/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        string? nome, classe, raca;
        int idade, nivel;

        Console.Write("Nome: ");
        nome = Console.ReadLine();
        Console.Write("Idade: ");
        int.TryParse(Console.ReadLine(), out idade);
        Console.Write("Nivel: ");
        int.TryParse(Console.ReadLine(), out nivel);
        Console.Write("Classe: ");
        classe = Console.ReadLine();
        Console.Write("Raça: ");
        raca = Console.ReadLine();

        System.Console.WriteLine("FICHA DO JOGADOR:");
        System.Console.WriteLine($"Nome: {nome}");
        System.Console.WriteLine($"Idade: {idade} anos");
        System.Console.WriteLine($"Nivel: LV {nivel}");
        System.Console.WriteLine($"Classe: {classe}");
        System.Console.WriteLine($"Raça: {raca}");

        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }
}