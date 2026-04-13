using CyberSecurityBot;

class Program
{
    static void Main(string[] args)
    {
        UIHelper.DisplayHeader();
        AudioPlayer.PlayWelcome();
        
        ChatBot bot = new ChatBot();
        bot.Start();
    }
}
