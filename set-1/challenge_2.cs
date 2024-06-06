
class Challenge2{
public static void AbsDiff(){
    // Prompt user to give a number
    Console.WriteLine("Enter a number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int r = 51;

    // Calculate the absolute difference
    int diff = Math.Abs(n - r);
    
    // Check if the number is greater than r then 3*diff
    if(n > r){
        Console.WriteLine(3*diff);
    }
    else{
        Console.WriteLine(diff);
    }
}
}
