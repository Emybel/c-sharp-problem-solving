class Challenge22{ 
  public static Boolean CheckForZ(){
        string str = "Jizz";
        int count = 0;
        for(int i =0; i<str.Length; i++){
            if(str[i] == 'z'){
                count++;
            }
            
        }
        if(count>=2 && count<4){
            return true;
        }
        else{
            return false;
        }


    }
}