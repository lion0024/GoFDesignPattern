using System;
using System.Text;

namespace GoFDesignPattern.TemplateMethod
{
    public class StringDisplay : AbstractDisplay
    {
        private string str;
        private int width;
        public StringDisplay(string str)
        {
            this.str = str;
            Encoding UniEnc = Encoding.GetEncoding("UTF-8");
            width = UniEnc.GetByteCount(str);
        }

        public override void Open()
        {
            PrintLine();
        }

        public override void Print()
        {
            Console.WriteLine("|" + str + "|");
        }

        public override void Close()
        {
            PrintLine();
        }

        private void PrintLine()
        {
            Console.Write("+");
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
