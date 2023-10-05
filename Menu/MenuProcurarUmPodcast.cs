using SoundTrack.Model;
using SoundTrack.Utils;

namespace SoundTrack.Menu;
public class MenuProcurarUmPodcast : Menu<Podcast>
{
    public override void Executar(List<Podcast> podcastList)
    {
        base.Executar(podcastList);
        ExibirTitutoOpcao("Procure por um podcast");

        Console.WriteLine("Digite o nome do poscast que deseja procurar: ");
        string nomeDoPodcast = Console.ReadLine()!;

        foreach (var podcast in podcastList)
        {
            if (nomeDoPodcast.Equals(podcast.Nome))
            {
                podcast.ExibirDetalhes();
                Console.WriteLine($"\n{Constants.menuPrincipal}");
                Console.ReadKey();
                Console.Clear();
                return;
            }
        }
        Console.WriteLine($"O Podcast {nomeDoPodcast} não existe");
        Console.WriteLine($"\n{Constants.menuPrincipal}");
        Console.ReadKey();
        Console.Clear();
    }

}