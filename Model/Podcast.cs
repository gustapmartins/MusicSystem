using SoundTrack.Interface;

namespace SoundTrack.Model;

public class Podcast: IPodcast
{
    public Podcast() { }

    public Podcast(string host, string nome) 
    { 
        Host = host;
        Nome = nome;
    }

    public string Host { get; set; }

    public string Nome { get; set; }

    public readonly List<Episodio> listaEpisodios = new();

    public int TotalDeEpisodios
    {
        get
        {
            int totalDeEpisodios = 0;
            if(listaEpisodios.Count != 0)
            {
                totalDeEpisodios += listaEpisodios.Count;
            }
            return totalDeEpisodios;
        }
    }


    public void AddEpisodio(Episodio episodio)
    {
        listaEpisodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}, Host: {Host}, Total de episodios: {TotalDeEpisodios}");

        for (int i = 0; i < listaEpisodios.Count; i++)
        {
            var listaEpisodio = listaEpisodios[i];

            Console.WriteLine(listaEpisodio.Resumo);
        }
    }
}
