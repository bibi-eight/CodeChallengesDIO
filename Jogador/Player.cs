using System;

class Player
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    public Player(string nome, string nacionalidade, int idade, string posicao)
    {
        Nome = nome;
        Nacionalidade = nacionalidade;
        Idade = idade;
        Posicao = posicao;
    }

    public string GetNome()
    {
        return Nome;
    }
    
    public int GetIdade()
    {
        return Idade;
    }
    
    public string GetNacionalidade()
    {
        return Nacionalidade;
    }
    
    public string GetPosicao()
    {
        return Posicao;
    }

}

class Execute 
{
    static void Main (string[] args)
    {
        string NomeEntrada = Console.ReadLine();

        int IdadeEntrada = Convert.ToInt32(Console.ReadLine());

        string NacionalidadeEntrada = Console.ReadLine();

        string PosicaoEntrada = Console.ReadLine();

        Player player = new Player(NomeEntrada, NacionalidadeEntrada, IdadeEntrada, PosicaoEntrada);

        string Nome = player.GetNome();
        int Idade = player.GetIdade();
        string Nacionalidade = player.GetNacionalidade();
        string Posicao = player.GetPosicao();

        Console.WriteLine($"Jogador criado!\n{Nome}\n{Nacionalidade}\n{Idade}\n Posição: {Posicao}");
    }
}