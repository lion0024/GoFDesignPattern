using System;
namespace GoFDesignPattern.Adapter.TransferPattern
{
    public class PrintBanner : APrint
    {
        private Banner banner;
        public PrintBanner(string str)
        {
            banner = new Banner(str);
        }

        public override void PrintStrong()
        {
            banner.ShowWithParen();
        }

        public override void PrintWeak()
        {
            banner.ShowWithAster();
        }
    }
}
