
class Problem4_2{
public static String LeapYear(){
    
    Console.Write("Enter a year: ");
    int x = Convert.ToInt32(Console.ReadLine());


    if(x % 4 == 0){
        return x + " is a leap year";
    }   
    else{
        return x + " is not a leap year";
    }


}
}
