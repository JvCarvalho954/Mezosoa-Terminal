class ConsoleController()
    {
        public List<string> buffer = [];
        
        public void WriteLine(string str)
        {
            Console.Clear(); //dá clear na tela inteira
            buffer.Add(str);//pega o buffer, soma com o str
            short c = (short)buffer.Count;
            if (c > 50)//checa se o buffer tem 50+ linhas, se sim tira as primeiras linhas do buffer, se não, faz nada
            {
                for(int i = c-50; i>0; i--)
                {
                    buffer.RemoveAt(0);
                }
            }
            foreach(string i in buffer)//e depois dá console write line com o buffer inteiro
            {
               Console.WriteLine(i);
            }
        }
        public void WriteLine(int line)//overload para dar Writeline com números
        {
            string str = ""+line;
            WriteLine(str);
        }
        public void WriteLine(bool line)//overload para dar Writeline com booleanos
        {
            string str = line ? "True" : "False";
            WriteLine(str);
        }
        public void Clear()//limpa a tela inteira
        {
            this.buffer.Clear();
            Console.Clear();
        }
        public void Clear(int line)//limpa apenas 1 linha
        {
            buffer.RemoveAt(buffer.Count-line-1); 
            Console.Clear();
            foreach(string i in buffer)
            {
                Console.WriteLine(i);
            }
        }
        public string ReadLine(string mesage="")
        {
            Console.Write(mesage);
            string? input = Console.ReadLine();
            WriteLine(mesage+input);
            if(input == null)
            {
                input = "";
            }
            return input;
        }
    }