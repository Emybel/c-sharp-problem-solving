
class Problem13_2{
    public static void TempDescription(){
        
        int temp = 20;
        switch (temp)
        {
            case < 0:
                Console.WriteLine("Freezing weather");
            break;
            case <10:
                Console.WriteLine("Very Cold weather");
            break;
            case < 20:
                Console.WriteLine("Cold weather");
            break;
            case <30:
                Console.WriteLine("Normal in Temp");
            break;
            case < 40:
                Console.WriteLine("Hot");
            break;
            case > 40:
                Console.WriteLine("Very Hot");
            break;

        }
}
}

