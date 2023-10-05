using SoundTrack.Model;
using SoundTrack.Utils;

namespace SoundTrack.Menu;

public class MenuProcurePorUmaBanda: Menu<Banda>
{
    public override void Executar(List<Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTitutoOpcao("Procure por uma banda");

        Console.WriteLine("Digite o nome da banda que deseja procurar: ");
        string nomeDaBanda = Console.ReadLine()!;

        foreach(var banda in bandasRegistradas)
        {
            if(nomeDaBanda.Equals(banda.Nome))
            {
                banda.ExibirDetalhes();
                Console.WriteLine($"\n{Constants.menuPrincipal}");
                Console.ReadKey();
                Console.Clear();
                return;
            }
        }

        Console.WriteLine($"O Podcast {nomeDaBanda} não existe");
        Console.WriteLine($"\n{Constants.menuPrincipal}");
        Console.ReadKey();
        Console.Clear();
    }
}