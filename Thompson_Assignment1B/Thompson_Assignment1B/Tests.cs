using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Assignment1B
{
    class Tests
    {
        private string firstName, lastName;
        private float[] test = new float[5];
        private float testAvg;
        private char grade;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public float[] Test
        {
            get { return test; }
            set { test = value; }
        }
        public float TestAvg
        {
            get { return testAvg; }
            set { testAvg = value; }
        }
        public char Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public Tests(string fn, string ln, float[] tst)
        {
            FirstName = fn;
            LastName = ln;
            Test = tst;
        }

        public Tests()
        {
            FirstName = "Steve";
            LastName = "Stevenson";
            Test = (0f, 0f, 0f, 0f, 0f);
        }

        public float ComputeAverage()
        {
            float testSum = 0f;
            for (int i = 0; i < Test.Length; i++)
            {
                testSum += Test[i];
            }

            TestAvg = testSum / Test.Length;

            return TestAvg;
        }

        public char GetGrade()
        {
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
            return Grade;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Test[0] + " " + Test[1] + " " + Test[2] + " " + Test[3] + " " + Test[4] + " " + TestAvg + " " + Grade;
        }
    }
}
