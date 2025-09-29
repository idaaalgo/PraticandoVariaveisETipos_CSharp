public class Program
{
    private static void Main(string[] args)
    {
        CalcularIdadePeloAnoDeNascimento(1997);
        Console.WriteLine();
        Doacao(500, true, 'P');
        Console.WriteLine();
        MilhasParaQuilometros(10);
        Console.WriteLine();
        MinutosEmHoras(250);
        Console.WriteLine();
        AreaRetangulo(10.5, 20.3);
        Console.WriteLine();
        CalcularMedia(7.2, 8.3, 9.1);
        Console.WriteLine();
        VeiculosParaTransporte(18.75);
        Console.WriteLine();
        SimulacaoVidasEmJoguinho();
        Console.WriteLine();
        AumentoSalarial(1500, 10);
        Console.WriteLine();
        AreaEPerimetro(5.0);
    }

    private static void AreaEPerimetro(double raio)
    {
        double area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;

        Console.WriteLine($"Raio: {raio:F2}");
        Console.WriteLine($"Área do círuclo: {area:F2}");
        Console.WriteLine($"Perímetro do círculo:{perimetro:F2}");
    }

    private static void AumentoSalarial(double salarioAtual, double percentualAumento)
    {
        double novoSalario = salarioAtual + (salarioAtual * percentualAumento / 100);
        Console.WriteLine($"O novo salário é de {novoSalario:C}");
    }

    private static void SimulacaoVidasEmJoguinho()
    {
        int vidas = 5;
        vidas--;
        vidas++;
        vidas++;
        int vidasFinais = vidas;
        Console.WriteLine("Vidas finais: " + vidasFinais);
    }

    private static void VeiculosParaTransporte(double pesoContainer)
    {
        int veiculosNecessarios = (int)pesoContainer;
        Console.WriteLine($"Veículos necessários: {veiculosNecessarios}");
    }

    private static void CalcularMedia(double n1, double n2, double n3)
    {
        double media = (n1 + n2 + n3) / 3;
        Console.WriteLine($"A média das notas é: {media:F2}");
    }

    private static void AreaRetangulo(double largura, double altura)
    {
        double area = largura * altura;
        Console.WriteLine($"A área do terreno é: {area} metros quadrados.");
    }

    private static void MinutosEmHoras(int minutos)
    {
        int horas = minutos / 60;
        int restanteEmMinutos = minutos % 60;
        Console.WriteLine($"Tempo: {horas} horas e {restanteEmMinutos} minutos");
    }

    private static void MilhasParaQuilometros(double milhas)
    {
        const double MILHA_EM_KM = 1.60934;
        double totalEmQuilometros = milhas * MILHA_EM_KM;
        Console.WriteLine($"{milhas} milhas equivalem a {totalEmQuilometros}KMs");
    }

    private static void Doacao(double valorDoacao, bool doacaoAnonima, char tipoContaDoacao)
    {
        Console.WriteLine($"Valor recebido: {valorDoacao:C}");
        Console.WriteLine($"Doação anônima: {doacaoAnonima}");
        Console.WriteLine($"Tipo conta: {tipoContaDoacao}");
    }

    private static void CalcularIdadePeloAnoDeNascimento(int anoNascimento)
    {
        const int ANO_ATUAL = 2025;
        int idade = ANO_ATUAL - anoNascimento;
        Console.WriteLine($"Sua idade é {idade} anos");
    }
}