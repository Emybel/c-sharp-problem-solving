
class Problem3_2{
public static String PositiveOrNegative(){
    
    Console.Write("Input a number: ");
    int x = Convert.ToInt32(Console.ReadLine());


    if(x >= 0){
        return x + " is a positive integer";
    }   
    else{
        return x + " is a negative integer";
    }


}
}
