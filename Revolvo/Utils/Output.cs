using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Revolvo
{
    internal class Output
    {
        /// <summary>
        /// Time added
        /// </summary>
        public DateTime Time { get; }
        /// <summary>
        /// Output text
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Output color
        /// </summary>
        public Color Color { get; }
        public Output(string text, Color color)
        {
            Time = DateTime.Now;
            Text = text;
            Color = color;
        }

        public static List<Output> Log = new List<Output>();

        public static int MaxLenght = 30;

        public static void WriteLine(string text, Color color)
        {
            if (text.Length < MaxLenght)
            {
                Log.Add(new Output(text, color));
            }
            else
            {
                var texts = SplitText(text, MaxLenght);
                foreach (var _text in texts)
                {
                    Log.Add(new Output(_text, color));
                }
            }
        }

        public static void WriteLine(string text)
        {
            WriteLine(text, Color.White);
        }

        public static string[] SplitText(string text, int length)
        {
            return Regex.Matches(text, ".{1," + length + "}").Cast<Match>().Select(m => m.Value).ToArray();
        }
    }

    public class ConsoleRewrite : TextWriter
    {
        internal ConsoleRewrite(TextWriter consoleOut) { ConsoleOut = consoleOut; }

        public override Encoding Encoding => Console.OutputEncoding;

        public TextWriter ConsoleOut { get; }

        public override void WriteLine(string text)
        {
            Output.WriteLine(text);
            ConsoleOut.WriteLine(text);
        }
    }
}
