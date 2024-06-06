
class Challenge3{
public static Boolean CheckFor30(){
    // Prompt user to give 2 numbers
    Console.WriteLine("Enter two numbers: ");
    int x = Convert.ToInt32(Console.ReadLine());
    int y = Convert.ToInt32(Console.ReadLine());
    
    // Calculate the sum
    int sum = x + y;
    
    // Check if one of the num == 30 or sum == 30
    if(x == 30 || y == 30 || sum == 30){
        return true;
    }
    
    else{
        return false;
    }
}
}
