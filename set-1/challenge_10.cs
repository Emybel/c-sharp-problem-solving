
class Challenge10{
public static Boolean MultipleOf(){
    // Prompt user to give a number
    Console.WriteLine("Enter a number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    // Check if the number is multiple of 3 or 7
    if(n % 3 == 0 || n % 7 == 0){
        return true;
    }
    else{
        return false;
    }

}
}
