using SoundTrack.Model;

namespace SoundTrack.Menu;

public class MenuMostrarPodcast: Menu<Podcast>
{
    public override void Executar(List<Podcast> ListaPodcast)
    {
        base.Executar(ListaPodcast);
        ExibirTitutoOpcao("Exibindo todas os podcasts registrados na nossa aplicação");

        for (int i = 0; i < ListaPodcast.Count; i++)
        {
            ListaPodcast[i].ExibirDetalhes();
        }

        Console.WriteLine("\n Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
