
using System.Text;

namespace Arrays_and_Lists;

class Program
{
    static void Main(string[] args)
    {
        var board = new Board();
        Console.OutputEncoding = UTF8Encoding.UTF8;
        for (int row = 0; row < 10; row++)
        {
            for (int column = 0; column < 10; column++)
            {
                Console.ForegroundColor = board[row, column].GetColor(); 
                System.Console.Write($"{board[row, column].GetChar()} ");
            }
            System.Console.WriteLine();
        }

        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
