class Program 
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