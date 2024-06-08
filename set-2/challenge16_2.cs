
using System.Security.Cryptography.X509Certificates;

class Problem16_2{
    public static String IsVowel(){
        
    char c = 'k';

    if(c == 'a' ||c == 'e' ||c == 'i' ||c == 'o' ||c == 'u'){
        return "The alphabet is a vowel";
    }
    else{
        return "The alphabet is a consonant";
    }
}   
}

