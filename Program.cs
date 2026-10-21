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
    class ConsoleController()
    {
        public string[] buffer;
        public void WriteLine(string str)
        {
            //dá clear na tela inteira
            //pega o buffer, soma com o str
            //checa se o buffer tem 50+ linhas, se sim tira as primeiras linhas do buffer, se não, faz nada
            //e depois dá console write line com o buffer inteiro
        }
    }

    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("   _______     __      _____  ___        __       ______    _______       __      ");
        Thread.Sleep(1000);
        Console.WriteLine("  |   __  \\   /  \\    (\\    \\|   \\      /  \\     /  _   \\  /       |     /  \\     ");
        Thread.Sleep(1000);
        Console.WriteLine("  (. |__) :) /    \\   |.\\\\   \\    |    /    \\   (: ( \\___)(: ______)    /    \\    ");
        Thread.Sleep(1000);
        Console.WriteLine("  |:  ____/ /' /\\  \\  |: \\.   \\\\  |   /' /\\  \\   \\/ \\      \\/    |     /' /\\  \\   ");
        Thread.Sleep(1000);
        Console.WriteLine("  (|  /    //  __'  \\ |.  \\    \\. |  //  __'  \\  //  \\ _   // ___)_   //  __'  \\  ");
        Thread.Sleep(1000);
        Console.WriteLine(" /|__/ \\  /   /  \\\\  \\|    \\    \\ | /   /  \\\\  \\(:   _) \\ (:       | /   /  \\\\  \\ ");
        Thread.Sleep(1000);
        Console.WriteLine("(_______)(___/    \\___)\\___|\\____\\)(___/    \\___)\\_______) \\_______)(___/    \\___)");
    }
}