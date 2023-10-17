using SoundTrack.Model;

namespace SoundTrack.Menu;

public class MenuRegistrarPodcast: Menu<Podcast>
{
    public override void Executar(List<Podcast> podcastList)
    {
        base.Executar(podcastList);
        ExibirTitutoOpcao("Registro dos Poscast");

        Console.WriteLine("Digite o nome do seu Podcast que deseja registrar");
        string nomeDoPodcast = Console.ReadLine()!;

        Console.WriteLine("Digite o host do seu Podcast");
        string nomeDoHost = Console.ReadLine()!;

        Podcast podcast = new(nomeDoHost, nomeDoPodcast);
        podcastList.Add(podcast);

        Console.WriteLine($"O Podcast {nomeDoPodcast} foi registrado com sucesso !");
        Thread.Sleep(1000);
        Console.Clear();
    }
}