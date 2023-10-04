using SoundTrack.Model;

namespace SoundTrack.Menu;

public class MenuMostrarBandas: Menu<Banda>
{
    public override void Executar(List<Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTitutoOpcao("Exibindo todas as bandas registradas na nossa aplicação");

        for (int i = 0; i < bandasRegistradas.Count; i++)
        {
            bandasRegistradas[i].ExibirDetalhes();
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal ");
        Console.ReadKey();
        Console.Clear();
    }
}