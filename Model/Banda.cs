using SoundTrack.Interface;

namespace SoundTrack.Model;

public class Banda: IBanda
{
    public Banda() { }

    public Banda(string nome, List<int> nota)
    {
        Nome = nome;
        Nota = nota;
        musicaList = new List<Musica>();
    }

    public string Nome { get; set; }
    public List<int> Nota = new();

    public List<Musica> musicaList = new();

    public int CalcularMedia(List<int> nota)
    {
        double soma = 0;

        for (int i = 0; i < nota.Count; i++)
        {
            soma += nota[i];
        }

        var media = soma / nota.Count;
        //Convert.ToInt32(media)

        return (int)media;
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
