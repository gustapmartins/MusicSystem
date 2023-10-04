namespace SoundTrack.Interface;

public interface IBanda
{
    void ExibirDetalhes();

    void AddNota(int nota);

    double CalcularMedia(List<int> nota);
}