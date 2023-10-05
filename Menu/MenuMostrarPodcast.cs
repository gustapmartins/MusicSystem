using SoundTrack.Model;
using SoundTrack.Utils;

namespace SoundTrack.Menu;

public class MenuMostrarPodcast: Menu<Podcast>
{
    public override void Executar(List<Podcast> ListaPodcast)
    {
        string menuPrincipal = "Digite o nome da banda que deseja exibir a média: ";
        base.Executar(ListaPodcast);
        ExibirTitutoOpcao("Exibindo todas os podcasts registrados na nossa aplicação");

        for (int i = 0; i < ListaPodcast.Count; i++)
        {
            ListaPodcast[i].ExibirDetalhes();
        }

        Console.WriteLine($"\n{Constants.menuPrincipal}");
        Console.ReadKey();
        Console.Clear();
    }
}
