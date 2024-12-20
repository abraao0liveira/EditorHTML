namespace EditorHTML
{
  public static class Menu
  {
    public static void Show()
    {
      Console.Clear();

      DrawScreen();
      WriteOptions();

      var option = short.Parse(Console.ReadLine() ?? "0");	// ?? "0" -> Se o valor for nulo, atribui 0
      HandleMenuOption(option);
    }

    public static void DrawScreen()
    {
      Console.Write("+");
      for (int i = 0; i <= 30; i++)
      {
        Console.Write("-");
      }
      Console.Write("+");
      Console.Write("\n");

      for (int lines = 0; lines <= 10; lines++)
      {
        Console.Write("|");

        for (int e = 0; e <= 30; e++)
        {
          Console.Write(" ");
        }
        Console.Write("|");
        Console.Write("\n");
      }

      Console.Write("+");
      for (int i = 0; i <= 30; i++)
      {
        Console.Write("-");
      }
      Console.Write("+");
      Console.Write("\n");
    }

    public static void WriteOptions()
    {
      Console.SetCursorPosition(3, 1); //Coloca o cursor na posição 3, 2 (coluna, linha)
      Console.WriteLine("Editor HTML");
      Console.SetCursorPosition(3, 2);
      Console.WriteLine("==========");
      Console.SetCursorPosition(3, 3);
      Console.WriteLine("Selecione uma opção abaixo:");

      Console.SetCursorPosition(3, 5);
      Console.WriteLine("1 - Novo arquivo");
      Console.SetCursorPosition(3, 6);
      Console.WriteLine("0 - Sair");

      Console.SetCursorPosition(3, 8);
      Console.Write("Opção: ");
    }

    public static void HandleMenuOption(short option)
    {
      switch (option)
      {
        case 1: Editor.Show(); break;
        case 0:
          {
            Console.Clear();
            Environment.Exit(0);
            break;
          }
        default: Show(); break;
      }
    }
  }
}