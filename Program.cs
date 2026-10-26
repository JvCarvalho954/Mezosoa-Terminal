/*   _______     __      _____  ___        __       ______    _______   __          __      
  |   __ "\   /""\    (\"   \|"  \      /""\     /" _  "\  /"     "| |" \        /""\     
  (. |__) :) /    \   |.\\   \    |    /    \   (: ( \___)(: ______) ||  |      /    \    
  |:  ____/ /' /\  \  |: \.   \\  |   /' /\  \   \/ \      \/    |   |:  |     /' /\  \   
  (|  /    //  __'  \ |.  \    \. |  //  __'  \  //  \ _   // ___)_  |.  |    //  __'  \  
 /|__/ \  /   /  \\  \|    \    \ | /   /  \\  \(:   _) \ (:      "| /\  |\  /   /  \\  \ 
(_______)(___/    \___)\___|\____\)(___/    \___)\_______) \_______)(__\_|_)(___/    \___)
                                                                                          */
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

class MezosoaTerminal
{
    static void Main(string[] args)
    {
        ConsoleController cmd = new ConsoleController();
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.Black;

        cmd.WriteLine("   _______     __      _____  ___        __       ______    _______       __      ");
        Thread.Sleep(1000);
        cmd.WriteLine("  |   __  \\   /  \\    (\\    \\|   \\      /  \\     /  _   \\  /       |     /  \\     ");
        Thread.Sleep(1000);
        cmd.WriteLine("  (. |__) :) /    \\   |.\\\\   \\    |    /    \\   (: ( \\___)(: ______)    /    \\    ");
        Thread.Sleep(1000);
        cmd.WriteLine("  |:  ____/ /' /\\  \\  |: \\.   \\\\  |   /' /\\  \\   \\/ \\      \\/    |     /' /\\  \\   ");
        Thread.Sleep(1000);
        cmd.WriteLine("  (|  /    //  __'  \\ |.  \\    \\. |  //  __'  \\  //  \\ _   // ___)_   //  __'  \\  ");
        Thread.Sleep(1000);
        cmd.WriteLine(" /|__/ \\  /   /  \\\\  \\|    \\    \\ | /   /  \\\\  \\(:   _) \\ (:       | /   /  \\\\  \\ ");
        Thread.Sleep(1000);
        cmd.WriteLine("(_______)(___/    \\___)\\___|\\____\\)(___/    \\___)\\_______) \\_______)(___/    \\___)");
        Thread.Sleep(1000);
    }
}