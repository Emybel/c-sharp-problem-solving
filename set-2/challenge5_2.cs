
class Problem5_2{
public static String CandidateAge(){
    
    Console.Write("Enter an age: ");
    int x = Convert.ToInt32(Console.ReadLine());


    if(x > 18){
        return "Congratulation! You are eligible for casting your vote.";
    }   
    else{
        return "Sorry! You are not eligible for casting your vote.";
    }


}
}
