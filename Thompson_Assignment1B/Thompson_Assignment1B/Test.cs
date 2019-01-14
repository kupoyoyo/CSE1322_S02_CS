using System;

public class Test
{
    private string firstName, lastName;
    private int[] test = new int[5];
    private int testAvg;
    private char grade;

    public string FirstName
    {
        get { return firstName; }
    }
    public string LastName
    {
        get { return lastName; }
    }
    public int[] Test
    {
        get { return test; }
    }
    public int TestAvg
    {
        get { return testAvg; }
    }
    public char Grade
    {
        get { return grade; }
    }

    public Test (string fn, string ln, int tst, int tstavg, char grd)
    {
        FirstName = fn;
        LastName = ln;
        Test = tst;
        TestAvg = tstavg;
        Grade = grd;
    }

    public Test()
	{
        FirstName = "Steve";
        LastName = "Stevenson";
        Test = 0; //Need to edit a proper array value
        Grade = 'F';
	}

    public ComputeAverage (int tst)
    {

    }

    public override string ToString()
    {
        return FirstName + " " + LastName + " " + Test[0] + " " + Test[1] + " " + Test[2] + " " + Test[3] + " " + Test[4] + " " + TestAvg + " " + Grade;
    }
}
