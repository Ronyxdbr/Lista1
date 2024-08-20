/*-------------------------------------------------------------------
Questão 8: Cálculo de Pontos de Habilidade
• Contextualização: Ao subir de nível, um jogador recebe pontos de habilidade que podem ser
distribuídos entre força, agilidade, inteligência e dois atributos adicionais.
• Comando: Desenvolva um programa que receba a quantidade de pontos de habilidade
atribuídos a cada uma das cinco características e calcule o total de pontos distribuídos.

@Lista: 01 - Lógica de Programação
@Autor: Milton Roney de Oliveira Nobre
@Data: 19/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        int forc, agi, inte, des, vit;

        
        Console.Write("Força: ");
        int.TryParse(Console.ReadLine(), out forc);
        Console.Write("Agilidade: ");
        int.TryParse(Console.ReadLine(), out agi);
        Console.Write("Inteligência: ");
        int.TryParse(Console.ReadLine(), out inte);
        Console.Write("Destreza: ");
        int.TryParse(Console.ReadLine(), out des);
        Console.Write("Vitalidade: ");
        int.TryParse(Console.ReadLine(), out vit);
        
        System.Console.WriteLine($"Total de pontos: {(forc + agi + inte + des + vit)}");
       
        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }
}