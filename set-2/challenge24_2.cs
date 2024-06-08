
using System.Security.Cryptography.X509Certificates;

class Problem24_2{
    public static Double MenuDrivenApproach(){
    
    Console.WriteLine("Enter The Shape to Calculate (1-Circle , 2-Tringle , 3-Square)");
    int shape = Convert.ToInt32(Console.ReadLine());

    if(shape == 1){
        Console.WriteLine("Enter The Radias");
        double r = Convert.ToDouble(Console.ReadLine());
        return 3.14 * r * r;
    }
    else if(shape == 2){
        Console.WriteLine("Enter The Base");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter The Height");
        double h = Convert.ToDouble(Console.ReadLine());

        return 0.5 * b * h;
    }
    else{
        Console.WriteLine("Enter The side length");
        double s = Convert.ToDouble(Console.ReadLine());
        return Math.Pow(s,2);
    }

}
}
