
using System.Security.Cryptography.X509Certificates;

class Problem23_2{
    public static String NumberOfDays(){
    
    Console.WriteLine("Enter the number of month");
    int m = Convert.ToInt32(Console.ReadLine());

    if(m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12){
        return "Month have 31 days";
    }
    else if(m == 4 || m == 6 || m == 9 || m == 11){
        return "Month have 30 days";
    }
    else{
        return "Month have 28 or  days";
    }
}
}
