using SoundTrack.Model;
using SoundTrack.Utils;

namespace SoundTrack.Menu;

public class MenuRegistrarMusica: Menu<Banda>
{
    public override void Executar(List<Banda> bandasList)
    {
        base.Executar(bandasList);
        ExibirTitutoOpcao("Registrar uma musica para banda");
        Console.WriteLine("Digite o nome da banda que deseja registrar a musica: ");

        string nomeDaBanda = Console.ReadLine()!;

        for (int i = 0; i < bandasList.Count; i++)
        {
            Banda banda = bandasList[i];

            if (nomeDaBanda.Equals(banda.Nome))
            {
                Console.WriteLine("Digite o nome da musica que deseja registrar: ");
                string nomeDaMusica = Console.ReadLine()!;

                Console.WriteLine("Digite a duração da musica: ");
                int duracao = int.Parse(Console.ReadLine()!);

                Musica musica = new(nomeDaMusica, duracao);
                banda.AddMusic(musica);

                Console.WriteLine($"A musica {nomeDaMusica} foi registrada com sucesso para a banda {nomeDaBanda}: ");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }

        Console.WriteLine($"A banda {nomeDaBanda} foi registrado com sucesso !");
        Console.WriteLine($"\n{Constants.menuPrincipal}");
        Console.ReadKey();
        Console.Clear();
    }
}
