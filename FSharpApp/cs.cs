using System;
using System.Windows.Forms;
using System.Drawing;


namespace Sud
{
    public static class Sudoku
    {
        public static void Main()
        {
            Form f = new Form();
            TextBox tb = new TextBox();
            tb.TextAlign = HorizontalAlignment.Center;
            goto fuck;
            int n = 5;
            switch (n)
            {
                case 1:
                    cost += 25;
                    break;
                case 2:
                    cost += 25;
                case 3:
                    cost += 50;
                    goto case 1;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }
        
    }
}

