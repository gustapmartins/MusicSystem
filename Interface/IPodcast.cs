using SoundTrack.Model;

namespace SoundTrack.Interface;

public interface IPodcast
{
    void AddEpisodio(Episodio episodio);

    void ExibirDetalhes();

    int TotalDeEpisodios { get; }
}
