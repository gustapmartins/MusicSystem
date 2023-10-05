using SoundTrack.Model;
using SoundTrack.Utils;

namespace SoundTrack.Menu;

public class MenuMostrarBandas: Menu<Banda>
{
    public override void Executar(List<Banda> bandasRegistradas)
    {
        string menuPrincipal = "Digite o nome da banda que deseja exibir a média: ";

        base.Executar(bandasRegistradas);
        ExibirTitutoOpcao("Exibindo todas as bandas registradas na nossa aplicação");

        for (int i = 0; i < bandasRegistradas.Count; i++)
        {
            bandasRegistradas[i].ExibirDetalhes();
        }

        Console.WriteLine($"\n\n{Constants.menuPrincipal}");
        Console.ReadKey();
        Console.Clear();
    }
}