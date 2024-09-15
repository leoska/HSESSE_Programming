using System.Collections;

class Program
{
    static void Main()
    {
        string month = Console.ReadLine();
        string output;
        switch (month)
        {
            case "January": 
            case "Январь": output = "1"; break;
            case "February":
            case "Февраль": output = "2"; break;
            case "March":
            case "Март": output = "3"; break;
            case "April":
            case "Апрель": output = "4"; break;
            case "May":
            case "Май": output = "5"; break;
            case "June":
            case "Июнь": output = "6"; break;
            case "July":
            case "Июль": output = "7"; break;
            case "August":
            case "Август": output = "8"; break;
            case "September":
            case "Сентябрь": output = "9"; break;
            case "october":
            case "Октябрь": output = "10"; break;
            case "November":
            case "Ноябрь": output = "11"; break;
            case "December":
            case "Декабрь": output = "12"; break;
            default: output = "В году такой месяц отсутствует."; break;
        }
        Console.WriteLine(output);
    }
}