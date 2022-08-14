class StudentDataAnalysis
{
    public void printData()
    {
        Console.WriteLine("Data Analysed");
    }
}

class StudentDataProcessing
{
    public static void printData()
    {
        Console.WriteLine("Data Processed");
    }
}

class Student
{
    public static void Main(string[] args)
    {
        StudentDataAnalysis analysis = new StudentDataAnalysis();
        analysis.printData();
        StudentDataProcessing.printData();
    }
}