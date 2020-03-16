using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            // add logic to calculate the average
            int sumOfTemps = 0;
            foreach (int temp in _temperatures)
            {
                sumOfTemps += temp;
            }
            int averageTemps = sumOfTemps / _temperatures.Count;
            return averageTemps; // <-- Replace this with the actual average
        }

        public int TempsAboveThreshold(int threshold)
        {
            // add logic to calculate temps above the threshold
            int countOfTemps = 0;
            foreach (int temp in _temperatures)
            {
                
                if (temp > threshold)
                {
                    countOfTemps += 1;
                    //countOfTemps = countOfTemps + 1;
                }
            }


            return countOfTemps; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            // add logic to calculate and return temps below the threshold
            int tempCount = 0;
            foreach (int temp in _temperatures)
            {
                if (temp < threshold)
                {
                    tempCount += 1;
                }
            }


            return tempCount; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            // add logic to calculate and return temps at the threshold
            int countTemp = 0;
            foreach (int temp in _temperatures)
            {
                if (temp == threshold)
                {
                    countTemp += 1;
                }
            }


            return countTemp; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            int totalTemps = 0;
            foreach (int temp in _temperatures)
            {
                totalTemps += 1;
            }


            return totalTemps; // <-- Replace this with the number
        }
    }
}
