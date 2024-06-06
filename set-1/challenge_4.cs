
class Challenge4{
public static Boolean Whithin10(){
    // Prompt user to give a number
    Console.WriteLine("Enter a number: ");
    int n = Convert.ToInt32(Console.ReadLine());

    // Check  if it is within 10 of 100 or 200
    if(Math.Abs(n-100) <= 10 || Math.Abs(n-200) <= 10){
        return true;
    }
    
    else{
        return false;
    }
}
}
