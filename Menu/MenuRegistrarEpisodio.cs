using SoundTrack.Model;
using SoundTrack.Utils;

namespace SoundTrack.Menu;

public class MenuRegistrarEpisodio: Menu<Podcast>
{
    public override void Executar(List<Podcast> podcastList)
    {
        base.Executar(podcastList);

        ExibirTitutoOpcao("Registrar uma musica para banda");

        Console.WriteLine("Digite o nome do podcast que deseja registrar o episodio: ");
        string nomeDoPodcast = Console.ReadLine()!;

        for (int i = 0; i < podcastList.Count; i++)
        {
            Podcast podcast = podcastList[i];

            if (nomeDoPodcast.Equals(podcast.Nome))
            {
                Console.WriteLine("Digite a ordem do episodio que deseja registrar: ");
                int ordem = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Digite o titulo do episodio que deseja registrar: ");
                string titulo = Console.ReadLine()!;

                Console.WriteLine("Digite a duração do episodio: ");
                double duracao = int.Parse(Console.ReadLine()!);

                Episodio episodio = new(ordem, titulo, duracao);
                podcast.AddEpisodio(episodio);

                Console.WriteLine($"O episodio {titulo} foi registrada com sucesso para o podcast {nomeDoPodcast} ");
                Thread.Sleep(2000);
                Console.Clear();
                return;
            }
        }

        Console.WriteLine($"O podcast {nomeDoPodcast} não foi encontrado");
        Console.WriteLine($"\n{Constants.menuPrincipal}");
        Console.ReadKey();
        Console.Clear();
    }
}
