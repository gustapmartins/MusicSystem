using SoundTrack.Utils;
using SoundTrack.Model;

namespace SoundTrack.Menu;

public class MenuExibirMedia: Menu<Banda>
{
    public override void Executar(List<Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTitutoOpcao("Exibir média da banda");

        Console.Write(Constants.menuPrincipal);
        string nomeDaBanda = Console.ReadLine()!;

        for (int i = 0; i < bandasRegistradas.Count; i++)
        {
            Banda banda = bandasRegistradas[i];

            if (nomeDaBanda.Equals(banda.Nome))
            {
                double media = banda.CalcularMedia(banda.Nota);
                Console.WriteLine($"\na média da banda {nomeDaBanda} é {media}");
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal: ");
                Console.ReadKey();
                Console.Clear();
                return;
            }
        }

        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine(Constants.menuPrincipal);
        Console.ReadKey();
        Console.Clear();
    }
}