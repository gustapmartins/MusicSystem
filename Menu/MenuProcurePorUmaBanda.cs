using SoundTrack.Model;

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
            }
        }
    }
}