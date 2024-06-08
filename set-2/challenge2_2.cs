
class Problem2_2{
public static String OddOrEven(){
    
    Console.Write("Input a number: ");
    int x = Convert.ToInt32(Console.ReadLine());


    if(x % 2 == 0){
        return x + " is an even integer";
    }   
    else{
        return x + " is an odd integer";
    }


}
}
