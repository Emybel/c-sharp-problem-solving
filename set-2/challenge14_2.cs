
using System.Security.Cryptography.X509Certificates;

class Problem14_2{
    public static String TringleType(){
        
        int a,b,c;

        Console.Write("Input (a) value: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input (b) value: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input (c) value: ");
        c = Convert.ToInt32(Console.ReadLine());

    if(a == b && a == c){
        return "This is an equilateral triangle";
    }
    else if(a == b){
        return "This is an isosceles triangle";
    }
    else{
        return "This is an scalene triangle";
    }
}   
}

