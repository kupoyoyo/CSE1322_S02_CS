using System;

public class Test
{
    private string firstName, lastName;
    private float[] test = new float[5];
    private float testAvg;
    private char grade;

    public string FirstName
    {
        get { return firstName; }
    }
    public string LastName
    {
        get { return lastName; }
    }
    public float[] Test
    {
        get { return test; }
    }
    public float TestAvg
    {
        get { return testAvg; }
    }
    public char Grade
    {
        get { return grade; }
    }

    public Test (string fn, string ln, float tst, float tstavg, char grd)
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
        Test = (0,0,0,0,0);
        Grade = 'F';
	}

    public float ComputeAverage ()
    {
        float testSum = 0f;
        for (int i = 0; i < Test.Length; i++)
        {
            testSum += Test[i];
        }

        TestAvg = testSum / Test.Length;

        if (TestAvg >= 90)
        {
            Grade = 'A';
        }
        else if (TestAvg >= 80)
        {
            Grade = 'B';
        }
        else if (TestAvg >= 70)
        {
            Grade = 'C';
        }
        else if (TestAvg >= 60)
        {
            Grade = 'D';
        }
        else
        {
            Grade = 'F';
        }
    }

    public override string ToString()
    {
        return FirstName + " " + LastName + " " + Test[0] + " " + Test[1] + " " + Test[2] + " " + Test[3] + " " + Test[4] + " " + TestAvg + " " + Grade;
    }
}
