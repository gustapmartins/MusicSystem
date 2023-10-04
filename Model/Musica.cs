namespace SoundTrack.Model;

public class Musica
{
    public Musica(string nome, int duracao)
    {
        Nome = nome;
        Duracao = duracao;
    }

    public string Nome { get; set; }
    public int Duracao { get; set; }
}
