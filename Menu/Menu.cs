using SoundTrack.Interface;

namespace SoundTrack.Menu;

public class Menu<T> where T : class
{
    public static void ExibirTitutoOpcao(string titulo)
    {
        string asteriscos = string.Empty.PadLeft(titulo.Length, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine($"{asteriscos} \n");
    }

    public virtual void Executar(List<T> bandasRegistradas)
    {
        Console.Clear();
       
    }
}