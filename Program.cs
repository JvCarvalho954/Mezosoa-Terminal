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
        static void LoadingAnim(string mesage, ConsoleController console, int cycles = 1)
        {
            string[] anim = ["\\","|","/","-"];
            for(byte i = 0; i<cycles-1; i++)
            {
                foreach(string icon in anim)
                {
                    console.WriteLine(mesage+icon);
                    Thread.Sleep(750);
                    console.Clear(0);
                }
            }
        }
        ConsoleController cmd = new ConsoleController();
        string SystemName = "Mezosoa";
        //Console.BackgroundColor = ConsoleColor.DarkGreen;
        //Console.ForegroundColor = ConsoleColor.Black;
        
        LoadingAnim("System initializing...", cmd,3);
        cmd.WriteLine("System initialized.");
        Thread.Sleep(1000);
        LoadingAnim("Loading Panacea Archive files... ", cmd,4);
        cmd.WriteLine("Files loaded.");
        Thread.Sleep(1000);

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
        
        cmd.WriteLine("Welcome to "+SystemName+" Terminal");
        cmd.WriteLine("Panacea Archive");
    }
}