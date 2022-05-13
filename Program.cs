
public class Program
{
  static void Demo5()
  {
    int[] pares = new int[] { 0, 2, 4, 6, 8 };

    MudarParaImpar(pares);
    System.Console.WriteLine($"Os numeros impares {string.Join(",", pares)}");
  }
  static void Demo4()
  {
    string nome = "Cassiano";

    Trocarnome(nome, "Rodrigo");

    System.Console.WriteLine($"O novo nome é: {nome}");
  }
  static void Demo3()
  {
    Structpessoa p1 = new Structpessoa()
    {
      Documento = "1223",
      Idade = 30,
      Nome = "Cassiano"
    };

    var p2 = p1;

    p1 = Trocanome(p1, "Joao");

    System.Console.WriteLine($@"
    Nome do p1 é:{p1.Nome}
    Nome do p2 é:{p2.Nome}
    ");

  }
  static void Demo2()
  {
    Pessoa p1 = new Pessoa();
    p1.Nome = "Cassiano";
    p1.Idade = 30;
    p1.Documento = "1234";

    Pessoa p2 = p1.Clone();


    TrocarNome(p1, "Carlos");

    System.Console.WriteLine($@"
    O nome de p1  é: {p1.Nome}
    O nome de p2 é: {p2.Nome}
    ");
  }
  public void Demo1()
  {
    int a = 2;
    a = Adicionar20(a);

    System.Console.WriteLine($"O valor da variavel é {a} ");
  }

  static int Adicionar20(int x)
  {
    return x + 20;
  }

  static void TrocarNome(Pessoa p1, string nomeNovo)
  {
    p1.Nome = nomeNovo;
  }

  static Structpessoa Trocanome(Structpessoa p1, string NomeNovo)
  {
    p1.Nome = NomeNovo;
    return p1;
  }

  static void Trocarnome(string nome, string NomeNovo)
  {
    nome = NomeNovo;
  }

  static void MudarParaImpar(int[] pares)
  {
    for (int i = 0; i < pares.Length; i++)
    {
      pares[i] = pares[i] + 1;
    }
  }

  static int EncontrarNumero(int[] numeros, int numero)
  {
    for (int i = 0; i < numeros.Length; i++)
    {
      if (numeros[i] == numero)
      {
        return i;
      }
    }
    return -1;
  }

  public static void Main()
  {
    int[] numeros = new int[] { 0, 2, 4, 6, 8 };
    System.Console.WriteLine($"Digite o número que gostaria de encontrar");
    int numero = int.Parse(System.Console.ReadLine());

    int idxEncontrado = EncontrarNumero(numeros, numero);

    if (idxEncontrado >= 0)
    {
      System.Console.WriteLine($"O número digitado está na posição {idxEncontrado}");
    }
    else
    {
      System.Console.WriteLine("O número digitado não foi encontrado");
    }



  }
}
