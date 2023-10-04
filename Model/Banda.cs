using SoundTrack.Interface;

namespace SoundTrack.Model;

public class Banda: IBanda
{
    private readonly List<Musica> musicaList = new();

    public Banda(string nome, List<int> nota)
    {
        Nome = nome;
        Nota = nota;
    }

    public string Nome { get; set; }
    public List<int> Nota { get; set; }

    public double CalcularMedia(List<int> nota)
    {
        int soma = 0;

        for (int i = 0; i < nota.Count; i++)
        {
            soma += nota[i];
        }

        return soma;
    }

    public void AddMusic(Musica musica)
    {
        musicaList.Add(musica);
    }

    public void AddNota(int nota)
    {
        Nota.Add(nota);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"\n\nNome banda: {Nome} \n ");

        for (int i = 0; i < musicaList.Count; i++)
        {
            Musica musica = musicaList[i];

            Console.WriteLine($"Nome da musica: {musica.Nome}, Duração {musica.Duracao} min \n");
        }

        for (int i = 0; i < Nota.Count; i++)
        {
            if(i == 0)
            {
                Console.Write("Notas da banda: ");
            }
            Console.Write($"{Nota[i]},");
        }
    }
}
