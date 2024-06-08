
class Problem12_2{
    public static void RollNo(){
    
        string name, division;
        double roll, phy, che, comp, total, percentage;


        Console.Write("Input the Roll Number of the student :");
        roll = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the Name of the Student :");
        name = Console.ReadLine();

        Console.Write("Input  the marks of Physics : ");
        phy = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input  the marks of Chemistry : ");
        che = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input  the marks of Computer Application : ");
        comp = Convert.ToInt32(Console.ReadLine());

        // Calculate the total marks and percentage
        total = phy + che + comp;
        percentage = total / 3.0;

        //Determining division based on percentage calculated
        if (percentage >= 70)
            division = "First";
        else if (percentage < 70 && percentage >= 50)
            division = "Second";
        else if (percentage < 50 && percentage >= 40)
            division = "Pass";
        else
            division = "Fail";


    Console.WriteLine("Roll No: "+roll);
    Console.WriteLine("Marks in Physics: " + phy);
    Console.WriteLine("Marks in Chemistry: "+ che);
    Console.WriteLine("Marks in Computer Application: " + comp);
    Console.WriteLine("Percentage: " + percentage);
    Console.WriteLine("Division: " + division);

}
}

