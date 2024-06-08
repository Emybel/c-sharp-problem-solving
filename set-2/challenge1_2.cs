
class Problem1_2{
public static String IsEqual(){
    
    Console.Write("Input first number: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input second number: ");
    int y = Convert.ToInt32(Console.ReadLine());

    if(x == y){
        return x + " and " + y + " are equal";
    }   
    else{
        return x + " and " + y + " are not equal";
    }


}
}
