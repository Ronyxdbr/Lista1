/*-------------------------------------------------------------------
Questão 3: Cálculo de Vida Restante
• Contextualização: Durante um combate, o jogador recebe dano e a vida do personagem
diminui.
• Comando: Crie um programa que receba o valor da vida inicial, o dano recebido, o bônus de
regeneração, do atacado, e dois modificadores, do atacante, (um para equipamentos e outro
para habilidades), e calcule a vida restante.

@Lista: 01 - Lógica de Programação
@Autor: Milton Roney de Oliveira Nobre
@Data: 19/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        double vida, dano, reg, modequip, modhab;

        
        Console.Write("Vida inicial: ");
        double.TryParse(Console.ReadLine(), out vida);
        Console.Write("Dano recebido: ");
        double.TryParse(Console.ReadLine(), out dano);
        Console.Write("Bônus de regeneração: ");
        double.TryParse(Console.ReadLine(), out reg);
        Console.Write("Modificador equipamento: ");
        double.TryParse(Console.ReadLine(), out modequip);
        Console.Write("Modificador habilidade: ");
        double.TryParse(Console.ReadLine(), out modhab);
        
        System.Console.WriteLine($"Vida restante: {(vida - (dano * modequip * modhab)) + reg}");
       
        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }
}