
using System.Security.Cryptography.X509Certificates;

class Problem15_2{
    public static String TringleValid(){
        
        int a,b,c;

        Console.Write("Input (a) value: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input (b) value: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input (c) value: ");
        c = Convert.ToInt32(Console.ReadLine());


    int r = a + b + c;

    if (r == 180){
        return "The triangle is valid";
    }
    else{
        return "The triangle is not valid";
    }
}   
}

