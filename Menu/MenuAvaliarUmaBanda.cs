using SoundTrack.Model;
using SoundTrack.Utils;

namespace SoundTrack.Menu;


public class MenuAvaliarUmaBanda : Menu<Banda>
{
    public override void Executar(List<Banda> bandasRegistradas)
    {
        

        base.Executar(bandasRegistradas);
        ExibirTitutoOpcao("Avaliar banda");
        Console.Write(Constants.menuPrincipal);
        string nomeDaBanda = Console.ReadLine()!;

        for (int i = 0; i < bandasRegistradas.Count; i++)
        {
            Banda banda = bandasRegistradas[i];

            if (nomeDaBanda.Equals(banda.Nome))
            {
                Console.Write($"Qual é a nota que a banda {nomeDaBanda} merece: ");
                int nota = int.Parse(Console.ReadLine()!);
                banda.AddNota(nota);
                Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}: ");
                Thread.Sleep(2000);
                Console.Clear();
                return;
            }
        }

        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine($"\n{Constants.menuPrincipal}");
        Console.ReadKey();
        Console.Clear();
    }
}
