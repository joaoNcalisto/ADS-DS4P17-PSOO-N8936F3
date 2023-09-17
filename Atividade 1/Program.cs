using System;

class Pessoa
{
    public string Nome { get; set; }
    public string RA { get; set; }

    public Pessoa(string nome, string ra)
    {
        Nome = nome;
        RA = ra;
    }

    public virtual string Apresentar()
    {
        return $"Meu nome é {Nome} e meu RA é {RA}.";
    }
}

class Aluno : Pessoa
{
    public Aluno(string nome, string ra) : base(nome, ra)
    {
    }

    public override string Apresentar()
    {
        return $"Sou o aluno {Nome} e meu RA é {RA}.";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno("Joao Vitor Nardini Calisto", "N8936F3");

        Console.WriteLine(aluno.Apresentar());
    }
}