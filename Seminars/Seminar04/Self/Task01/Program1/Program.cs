using System;

class Program{
   static void Main(){
       string str = Console.ReadLine();
       char element = str[0];
       switch (element){
        case >= '0' and <= '9':
            Console.WriteLine("100");
            break;
        case  >= 'A' and  <= 'Z':
            Console.WriteLine("200");
            break;
        case >= 'a' and  <= 'z':
            Console.WriteLine("300");
            break;
        default:
            Console.WriteLine("400");
            break;
        }
   }
}
