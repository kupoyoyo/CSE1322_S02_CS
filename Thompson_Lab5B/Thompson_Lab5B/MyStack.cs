using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Lab5B
{
    class MyStack
    {
        private ArrayList stackArray;
        private int count = 0;
        public MyStack()
        {
            stackArray = new ArrayList();
            stackArray.Capacity = 20;
        }
        public void push (Clothes c)
        {
            stackArray.Add(c);
            count++;
        }
        public Clothes pop()
        {
            Clothes temp = (Clothes)stackArray[count - 1];
            stackArray.RemoveAt(count - 1);
            count--;
            return temp;
        }
        public Clothes peek ()
        {
            Clothes temp = (Clothes) stackArray[count - 1];
            return temp;
        }
        public ArrayList returnColor (string c)
        {
            ArrayList clothesColor = new ArrayList();
            foreach (Clothes clothes in stackArray)
            {
                if (clothes.EqualsColor(c) == true)
                {
                    clothesColor.Add(clothes);
                }
            }
            return clothesColor;
        }
        public int highTempOnly ()
        {
            int numHighTemp = 0;
            foreach (Clothes clothes in stackArray)
            {
                if (clothes.HighTempWash == true)
                    numHighTemp++;
            }
            return numHighTemp;
        }
    }
}
