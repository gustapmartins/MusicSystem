
using SoundTrack.Model;

namespace SoundTrack.Menu;


public class MenuAvaliarUmaBanda : Menu<Banda>
{
    public override void Executar(List<Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        ExibirTitutoOpcao("Avaliar banda");
        Console.WriteLine("Digite o nome da banda que deseja avaliar");
        string nomeDaBanda = Console.ReadLine()!;

        for (int i = 0; i < bandasRegistradas.Count; i++)
        {
            Banda banda = bandasRegistradas[i];

            if (nomeDaBanda.Equals(banda.Nome))
            {
                Console.WriteLine($"Qual é a nota que a banda {nomeDaBanda} merece: ");
                int nota = int.Parse(Console.ReadLine()!);
                banda.AddNota(nota);
                Console.WriteLine($"A {nota} foi registrada com sucesso para a banda {nomeDaBanda}: ");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }

        Console.WriteLine($"\n A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
