using System;
using System.IO;

string nome = string.Empty;
bool premiun = false;
int dia = -1;
int mes = -1;
int ano = -1;
// TODO

//Vou completar esta bela obra semana que vem,
//se não for demitido né vai que kkkk
//caracteres úteis: ─│┌┐└┘├┤┬┴┼
Console.WriteLine("┌───┐ ┌───┐");
Console.WriteLine("│┌─┐│ │┌─┐│");
Console.WriteLine("│└─┘│ ││ ││");
Console.WriteLine("│ ┌─┘ ││ ││");
Console.WriteLine("│ └─┐ ││ ││");
Console.WriteLine("│┌─┐│ ││ ││");
Console.WriteLine("│└─┘│ │└─┘│");
Console.WriteLine("└───┘ └───┘");
Console.WriteLine("\t\tTecnologia para a vida");
Console.WriteLine("");
Console.WriteLine("Pressione qualquer tecla para começar...");
Console.ReadKey(true);
bool signal = true;
while (signal)
{
    Console.Clear();
    Console.WriteLine("O que você quer fazer?");
    Console.WriteLine("1 - Cadastrar Novo cliente");
    Console.WriteLine("2 - Ler dados do cliente");
    Console.WriteLine("3 - Cadastrar Novo produto");
    Console.WriteLine("4 - Ler dados do produto");
    Console.WriteLine("5 - Sair");
    int id = int.Parse(Console.ReadLine());
    switch(id)
    {
        case 1:
            Console.Write("Digite o nome do Cliente:");
            nome = Console.ReadLine();
            Console.Write("O Cliente é premiun? (s/n)");
            string premium = Console.ReadLine();
            if (premium == "s")
                premiun = true;
            else if (premium == "n")
                premiun = false;

            Console.Write("Dia de nascimento: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Mes de nascimento: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Ano de nascimento: ");
            ano = int.Parse(Console.ReadLine());

            
            // TODO

            Cliente cliente = new Cliente(nome, premiun, dia, mes, ano);
            cliente.Save();
            break;
        
        // TODO
        case 2:
            Console.Write("Digite o nome do Cliente:");
            nome = Console.ReadLine();
            Cliente.Load(nome);
            System.Threading.Thread.Sleep(4000);
            break;
        
        case 3:
            Console.WriteLine("Insira o codigo do produto: ");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o nome do produto: ");
            string nameProduto = Console.ReadLine();

            Produto produto = new Produto(code, nameProduto);
            produto.Save();
            System.Threading.Thread.Sleep(500);

            break;

        case 4:
            Console.Write("Digite o Codigo do Produto:");
            string codePesquisa = Console.ReadLine();
            Produto.Load(codePesquisa);
            System.Threading.Thread.Sleep(4000);
            break;


        case 5:
            signal = false;
            break;
    }
}

public class Cliente
{
    public Cliente(string nome, bool premium, int dia, int mes, int ano)
    {
        this.Nome = nome;
        this.Premium = premium;
        this.DiaNascimento = dia;
        this.MesNascimento = mes;
        this.AnoNascimento = ano;
    }

    public string Nome { get; set; }
    public bool Premium { get; set; }
    public int DiaNascimento { get; set; }
    public int MesNascimento { get; set; }
    public int AnoNascimento { get; set; }

    public void Save()
    {
        StreamWriter writer = new StreamWriter(this.Nome + ".txt");

        writer.WriteLine(this.Nome);
        writer.WriteLine(this.Premium);
        writer.WriteLine(this.DiaNascimento);
        writer.WriteLine(this.MesNascimento);
        writer.WriteLine(this.AnoNascimento);

        writer.Close();
    }

    public static Cliente Load(string nome)
    {
        StreamReader reader = new StreamReader(nome + ".txt");

        nome = reader.ReadLine();
        bool premiun = bool.Parse(reader.ReadLine());
        int dia = int.Parse(reader.ReadLine());
        int mes = int.Parse(reader.ReadLine());
        int ano = int.Parse(reader.ReadLine());

        // TODO
        Console.WriteLine($"Nome: {nome}\nPremiun: {premiun}\nNascimento: {dia}/{mes}/{ano}");
        Cliente cliente = new Cliente(nome, premiun, -1, -1, -1);
        return cliente;
    }
}

public class Produto
{
    public Produto(int code, string nome )
    {
        this.Code = code;
        this.Nome = nome;
    }

    public int Code { get; set; } 
    public string Nome { get; set; } 


    public void Save()
    {
        StreamWriter writer = new StreamWriter(this.Code + ".txt");

        writer.WriteLine(this.Nome);
        writer.WriteLine(this.Code);
        
        writer.Close();
    }


    public static Produto Load(string codigo)
    {
        StreamReader reader = new StreamReader(codigo + ".txt");

        string nome = reader.ReadLine();
        int code = int.Parse(reader.ReadLine());
        
        // TODO
        Produto produto = new Produto(code, nome);
        Console.WriteLine($"Nome: {nome}\nCodigo: {code}");
        return produto;
    }
}