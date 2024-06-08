
using System.Security.Cryptography.X509Certificates;

class Problem19_2{
    public static String EquivalentDesc(){
    
    char c = 'E';

    if(c == 'E'){
        return "Excellent";
    }
    else if(c == 'V'){
        return "Very Good";
    }
    else if(c == 'G'){
        return "Good";  
    }
    else if(c == 'A'){
        return "Average";  
    }
    else{
        return "Fail";
    }
}   
}

