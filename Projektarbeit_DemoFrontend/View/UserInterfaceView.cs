using Projektarbeit_DemoFrontend.Interface;

namespace Projektarbeit_DemoFrontend.Controller
{
    public class UserInterfaceView : IUserInterfaceView
    {
        public void Print(string message, params object[] args)
        {
            Console.WriteLine(message, args);
        }

        public void PrintList(string message, List<string> list)
        {
            Console.WriteLine(message);

            foreach (var item in list) Console.WriteLine(item);
        }

        public void PrintTable(string message, string[] headings, List<string[]> list)
        {
            Console.WriteLine(message);
            Console.WriteLine(new string('=', message.Length));

            if (headings == null || headings.Length == 0)
            {
                Console.WriteLine("(No headings provided)");
                return;
            }

            // Determine max width for each column
            int[] columnWidths = new int[headings.Length];
            for (int i = 0; i < headings.Length; i++)
            {
                int maxWidth = headings[i].Length;
                foreach (var row in list)
                {
                    if (i < row.Length)
                    {
                        maxWidth = Math.Max(maxWidth, row[i]?.Length ?? 0);
                    }
                }
                columnWidths[i] = maxWidth + 2; // add padding
            }

            // Print headings
            for (int i = 0; i < headings.Length; i++)
            {
                Console.Write(headings[i].PadRight(columnWidths[i]));
            }
            Console.WriteLine();

            // Print separator line
            for (int i = 0; i < headings.Length; i++)
            {
                Console.Write(new string('-', columnWidths[i]));
            }
            Console.WriteLine();

            // Print rows
            foreach (var row in list)
            {
                for (int i = 0; i < headings.Length; i++)
                {
                    string cell = i < row.Length ? row[i] ?? "" : "";
                    Console.Write(cell.PadRight(columnWidths[i]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\r\n\r");
        }

        public int GetSelection(List<string> options, string message = "Bitte eine Option auswählen:")
        {
            Console.WriteLine(message);

            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine("{0}: {1}", i + 1, options[i]);
            }

            int selectedValue = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out selectedValue) && selectedValue > 0 && selectedValue <= options.Count)
                {
                    break;
                }
                Console.WriteLine("Bitte eine Zahl im gültigen Bereich eingeben:");
            }

            ClearConsole();

            return selectedValue - 1;
        }

        public void ClearConsole()
        {
            Console.WriteLine("\x1b[2J\x1b[H"); // ANSI escape codes to clear terminal and move cursor to home
        }

        public void ClearConsoleOnButtonPress()
        {
            Console.WriteLine("Drücke eine beliebige Taste um zum Menü zurück zu kehren...");
            Console.ReadKey();
            ClearConsole();
        }
    }
}
