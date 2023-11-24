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