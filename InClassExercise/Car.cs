using System;

namespace InClassExercise
{
    class Car
    {
        public string model;
        public string color;
        public int year;
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
        private Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
    }
}
