using Exemplo_OO2;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa("Chris", "981108180", "Rua Carlos do amanaral sampaio");
        Professor professor = new Professor("Prof. Pardal", "190", "Rua Copacabana", 1234.56);
        Professor professor2 = new Professor(pessoa, 2345.67);

        Console.WriteLine(pessoa.ToString());
        Console.WriteLine(professor);

        Estudante estudante = new Estudante("Chris", "981108180", "Rua Carlos do amanaral sampaio", 5);

        Console.WriteLine("digite a primeira nota: ");
        double nota1=double.Parse(Console.ReadLine());

        Console.WriteLine("digite a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("digite o peso da primeira nota: ");
        double peso1 = double.Parse(Console.ReadLine());

        Console.WriteLine("digite o peso da segunda nota: ");
        double peso2 = double.Parse(Console.ReadLine());

        Console.WriteLine(estudante.ToString()+ "\nsua media aritmetica eh: " + estudante.CalcularMedia(nota1, nota2));

        Console.WriteLine(estudante.ToString() + "\nsua media ponderada eh: " + estudante.CalcularMedia(nota1, nota2, peso1, peso2));
    }
}