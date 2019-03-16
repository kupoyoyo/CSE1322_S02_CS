using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Lab5B
{
    class MyQueue
    {
        private List<Food> queueList;
        public MyQueue()
        {
            queueList = new List<Food>();
            queueList.Capacity = 20;
        }
        public Food peek()
        {
            Food temp = queueList[0];
            return temp;
        }
        public void enqueue(Food f)
        {
            queueList.Add(f);
        }
        public void dequeue()
        {
            queueList.RemoveAt(0);
        }
        public double averageCal()
        {
            int sum = 0;
            int count = 0;
            foreach (Food food in queueList)
            {
                sum += food.Calories;
                count++;
            }
            return sum / count;
        }
        public Food mostCalories()
        {
            Food maxCal = new Food();
            foreach (Food food in queueList)
            {
                if ((maxCal.Calories * maxCal.Servings) < (food.Calories * food.Servings))
                    maxCal = food;
            }
            return maxCal;
        }
    }
}
