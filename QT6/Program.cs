/*-------------------------------------------------------------------
Questão 6: Conversão de Moeda do Jogo
• Contextualização: O jogo possui uma loja onde os jogadores podem trocar moedas de ouro por
cristais.
• Comando: Desenvolva um programa que receba o valor de moedas de ouro, o valor da taxa de
conversão (1 cristal = X moedas de ouro), e dois bônus de conversão (um baseado em eventos
e outro em habilidades), e calcule o número de cristais que o jogador pode obter.
@Lista: 01 - Lógica de Programação
@Autor: Milton Roney de Oliveira Nobre
@Data: 19/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        double ouro, taxa, evento, habilidade;

        Console.Write("Moedas de ouro: ");
        double.TryParse(Console.ReadLine(), out ouro);
        Console.Write("Taxa de conversão: ");
        double.TryParse(Console.ReadLine(), out taxa);
       Console.Write("Bônus de evento: ");
        double.TryParse(Console.ReadLine(), out evento);
        Console.Write("Bônus de habilidade: ");
        double.TryParse(Console.ReadLine(), out habilidade);

        System.Console.WriteLine($"Cristais obtidos: {(ouro / taxa) * evento * habilidade}");

        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }
}