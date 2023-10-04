namespace SoundTrack.Model;

public class Episodio
{
    private readonly List<string> Convidados = new();

    public Episodio(int ordem, string titulo, double duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get; set; }

    public string Titulo { get; set;}

    public double Duracao { get; set;}

    public string Resumo => $"Ordem: {Ordem} - Titulo: {Titulo} ({Duracao} min) - {string.Join(", ", Convidados)}";

    public void AddConvidados(string convidados)
    {
        Convidados.Add(convidados);
    }
}
