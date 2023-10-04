using SoundTrack.Model;

namespace SoundTrack.Menu;

public class MenuRegistrarBanda: Menu<Banda>
{
    public override void Executar(List<Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        ExibirTitutoOpcao("Registro das bandas");

        Console.WriteLine("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;

        Banda banda = new(nomeDaBanda, new List<int> { });
        bandasRegistradas.Add(banda);

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso! ");
        Thread.Sleep(1000);
        Console.Clear();
    }
}