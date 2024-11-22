using System.Text.RegularExpressions;

namespace EditorHTML
{
  public class Viewer
  {
    public static void Show(string text)
    {
      Console.Clear();

      Console.WriteLine("MODO VISUALIZAÇÃO");
      Console.WriteLine("------------");

      Replace(text);

      Console.ReadKey();
      Menu.Show();
    }

    public static void Replace(string text)
    {
      var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>"); // Expressão regular para negrito
      var words = text.Split(' '); // Separa o texto em palavras

      for (var i = 0; i < words.Length; i++)
      {
        if (strong.IsMatch(words[i])) // Verifica se a palavra é negrito
        {
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.Write(
            words[i].Substring(
              words[i].IndexOf('>') + 1,
              (words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>')
            )
          );
          Console.Write(" ");
        }
        else
        {
          Console.Write(words[i]);
          Console.Write(" ");
        }
      }
    }
  }
}