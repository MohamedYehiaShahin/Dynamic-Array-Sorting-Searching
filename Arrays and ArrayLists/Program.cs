

internal class Program
{
    private static void Main(string[] args)
    {
      Grades grades = new Grades(5);
        grades.FillArray();
       Console.WriteLine("Avarege is : {0}", grades.Average());
        Console.WriteLine("Highest grade is : {0}", grades.higest());
        Console.WriteLine("Lowest grade is : {0}", grades.Lowest());
        Console.WriteLine("Number of students with Highest grade is : {0}", grades.numOfHigest());
        Console.WriteLine("Number of students with Lowest grade is : {0}", grades.numOfLowest());



    }
}
internal class Grades
{
    private int HighestCount =0 , LowestCount =0;
    private int[] grades;
    public int numOfHigest()
    {
        int higestGrade = higest();
        for (int i = 0; i < grades.Length; i++)
        {
            if(grades[i] == higestGrade)
            {
                HighestCount++;
            }
        }
        return HighestCount;
    }
      
    public int numOfLowest()
    {
        int LowestGrade = Lowest();
        for (int i = 0; i<grades.Length; i++)
        {
            if(grades[i] == LowestGrade)
            {
                LowestCount++;
            }
        }
        return LowestCount;
    }
    public Grades()
    {
        grades = new int[20];
    }

    public Grades(int size)
    {
        grades = new int[size];
    }


    public decimal Average()
    {
        int sum = 0;
        for (int i = 0; i < grades.Length; i++)
            sum += grades[i];
        decimal avg = sum/grades.GetLength(0);
        return avg;
    }

    public int higest()
    {
        int higest = grades[0];
        for (int i = 1; i < grades.Length; i++)
            if(higest <= grades[i])
            {
                higest = grades[i]; 
            }
        return higest;
    }

    public int Lowest()
    {
        int lowest = grades[0];
        for (int i = 1; i < grades.Length; i++)
            if (lowest >= grades[i])
            {
                lowest = grades[i];
            }
        return lowest;
    }
    public void FillArray()
    {
        Console.WriteLine("-------------------------------------\n" +
            "     Please Fill Grades\n " +
                          "-------------------------------------");
        for (int i = 0; i < grades.Length; i++)
            grades[i] = int.Parse(Console.ReadLine()!);
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Thanks for Filling Grades Table ... \n" +
            "if you want to add any Grade please choose a or finish choose x:");
        if (Console.ReadLine() == "a")
            RepeatInput();

    }

   private void RepeatInput()
    {
            Resize();
            grades[grades.GetUpperBound(0)] = int.Parse(Console.ReadLine()!);
        Console.Write("Choose a to continue adding grade or press any key to show output: ");
            if (Console.ReadLine() == "a")
                RepeatInput();
        
    }

    private void Resize()
    {
        int[] ints = new int[grades.Length+1];
        for(int i = 0;i < grades.Length;i++)
        {
            ints[i] = grades[i];
        }

        grades = new int[ints.Length];
        for (int i = 0; i < ints.Length; i++)
        {
             grades[i] = ints[i];
        }
    }
}

