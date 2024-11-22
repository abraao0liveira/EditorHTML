using System.Text;

namespace EditorHTML
{
  public static class Editor
  {
    public static void Show()
    {
      Console.Clear();

      Console.WriteLine("MODO EDITOR");
      Console.WriteLine("------------");
      Start();
    }

    public static void Start()
    {
      var file = new StringBuilder();

      do
      {
        file.Append(Console.ReadLine()); // Adiciona o texto digitado ao arquivo
        file.Append(Environment.NewLine); // Adiciona uma nova linha ao arquivo
      } while (Console.ReadKey().Key != ConsoleKey.Escape);

      Console.WriteLine("------------");
      Console.WriteLine(" Deseja salvar o arquivo?");
      Viewer.Show(file.ToString());
    }
  }
}