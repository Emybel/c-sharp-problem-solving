
class Problem11_2{
    public static void QuadraticEquationRoot(){
    

    int a, b, c; 
    double d, x1, x2;  

    Console.Write("Input the value of a : "); 
    a = Convert.ToInt32(Console.ReadLine());  
    Console.Write("Input the value of b : "); 
    b = Convert.ToInt32(Console.ReadLine());  
    Console.Write("Input the value of c : ");  
    c = Convert.ToInt32(Console.ReadLine());

    d = (b*b) - (4*a*c);

    x1 = (b + Math.Sqrt(d)/(2*a));
    x2 = (b - Math.Sqrt(d)/(2*a));

    Console.Write("First Root Root1= {0}\n", x1);
    Console.Write("Second Root Root2= {0}\n", x2);
}
}

