using System;
namespace GoFDesignPattern.TemplateMethod
{
    public class CharDisplay : AbstractDisplay
    {
        private char ch;
        public CharDisplay(char ch)
        {
            this.ch = ch;
        }

        public override void Open()
        {
            Console.Write("<<");
        }

        public override void Print()
        {
            Console.Write(ch);
        }

        public override void Close()
        {
            Console.WriteLine(">>");
        }
    }
}
