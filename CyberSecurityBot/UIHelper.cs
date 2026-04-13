using System;

namespace CyberSecurityBot
{
    public static class UIHelper
    {
        public static void DisplayHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("===============================================");
            Console.WriteLine(@"
    ______ ____    ____ .______    _______ .______         .______     ______   .___________.
 /      |\   \  /   / |   _  \  |   ____||   _  \        |   _  \   /  __  \  |           |
|  ,----' \   \/   /  |  |_)  | |  |__   |  |_)  |       |  |_)  | |  |  |  | `---|  |----`
|  |       \_    _/   |   _  <  |   __|  |      /        |   _  <  |  |  |  |     |  |     
|  `----.    |  |     |  |_)  | |  |____ |  |\  \----.   |  |_)  | |  `--'  |     |  |     
 \______|    |__|     |______/  |_______|| _| `._____|   |______/   \______/      |__|     
                                                                                           

    Cybersecurity Awareness Bot 
");
            Console.WriteLine("===============================================");

            Console.ResetColor();
        }
    }
}