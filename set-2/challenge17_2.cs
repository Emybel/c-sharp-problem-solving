
using System.Security.Cryptography.X509Certificates;

class Problem17_2{
    public static String Trasaction(){
        
    int income = 500;
    int expense = 700;

    int amount = income - expense;

    if(amount<0){
        return "you lost " + Math.Abs(amount)+"$";
    }
    else{
        return "You can book your profit amount: " + amount;
    }
}   
}

