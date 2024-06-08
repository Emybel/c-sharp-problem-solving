
class Problem6_2{
public static int BiPolarValues(){
    
    Console.Write("Enter a Number: ");
    int x = Convert.ToInt32(Console.ReadLine());

    int n = 0;
    if(x > 0){
        n = 1;
    }   
    else if(x < 0){
        n = -1;
    }
    else{
        n = 0;
    }

    return n;

}
}
