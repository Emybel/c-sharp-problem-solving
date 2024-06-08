
using System.Security.Cryptography.X509Certificates;

class Problem20_2{
    public static void NameOfDay(){
    
    Console.WriteLine("Enter the number");
    int d = Convert.ToInt32(Console.ReadLine());

       switch(d)
        {
            case 1:
                Console.Write("Sunday"); 
                break;
            case 2:
                Console.Write("Monday");                  
                break;
            case 3:
                Console.Write("Tuesday"); 
                break;
            case 4:
                Console.Write("Wednesday");
                break;
            case 5:
                Console.Write("Thursday");
                break;
            case 6:
                Console.Write("Friday");  
                break;
            case 7:
                Console.Write("Saturday"); 
                break;
            default:
                Console.Write("Invalid day number"); 
                break;
        }
}
}
