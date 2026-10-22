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
        public List<string> buffer = [];
        
        public void WriteLine(string str)
        {
            Console.Clear(); //dá clear na tela inteira
            List<string> tbuffer = this.buffer;
            tbuffer.Add(str);//pega o buffer, soma com o str
            short c = (short)tbuffer.Count;
            if (c > 50)//checa se o buffer tem 50+ linhas, se sim tira as primeiras linhas do buffer, se não, faz nada
            {
                for(int i = c-50; i>0; i++)
                {
                    tbuffer.RemoveAt(0);
                }
            }
            foreach(string i in tbuffer)//e depois dá console write line com o buffer inteiro
            {
               Console.WriteLine(i);
            }
        }
        public void Clear()//limpa a tela inteira
        {
            this.buffer.Clear();
            Console.Clear();
        }
        public void Clear(int line)//limpa apenas 1 linha
        {
            List<string> buffertemp = this.buffer;
            buffertemp.Reverse();
            buffertemp.RemoveAt(line);
            buffertemp.Reverse();
            this.buffer = buffertemp;
            this.WriteLine("");
        }
    }

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
        
    }
}