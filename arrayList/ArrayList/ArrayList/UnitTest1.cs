using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Array_List_Cleaner
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CleanLeast()
        {
            ArrayList dataList = new ArrayList();
            dataList.Add("Someday");
            dataList.Add(2);
            dataList.Add("App");
            dataList.Add(13.5);
            dataList.Add("red");
            dataList.Add(8);
            dataList.Add(99);
            dataList.Add("6");
            dataList.Add("Meatball soap");
            dataList.Add(18M);
            dataList.Add("pieces");
            dataList.Add("14");



            // processing all List values
            for (int i = 0; i < dataList.Count; i++)
            {

                if (dataList[i].GetType() == typeof(int))
                {
                    Console.WriteLine($"{dataList[i]} is an integer. Skipping.");
                }

                else if (dataList[i].GetType() == typeof(double))
                {
                    //Console.WriteLine($"{dataList[i]} is an double. Zeroing value.");
                    dataList[i] = 0;
                }

                else if (dataList[i].GetType() == typeof(decimal))
                {

                    decimal valueDecimal = (decimal)dataList[i];
                    if (valueDecimal % 1 == 0)
                    {
                        dataList[i] = Convert.ToInt16((decimal)dataList[i]);
                    }
                    else
                    {
                       // Console.WriteLine($"{dataList[i]} is an decimal with floatin point. Zeroing value.");
                        dataList[i] = 0;

                    }
                }




                else
                {
                    if (dataList[i].GetType() == typeof(string))
                    {
                      //  Console.WriteLine($"{dataList[i]} is a string, converting to integer.");
                        if (int.TryParse((string)dataList[i], out int convertedValue) == true)
                        {
                            dataList[i] = convertedValue;
                           // Console.WriteLine($" {convertedValue} is successfully converted to integer.");
                        }
                        else
                        {
                           // Console.WriteLine($" {dataList[i]} convertion to integer is impossible, Zeroing value.");
                            dataList[i] = 0;

                        }
                    }
                    else
                    {
                        dataList[i] = 0;
                    }

                }


            }
            Console.WriteLine($"Processing is finished.");



            // removing values with 0
            Console.WriteLine($"Removing 0 values.");
            int allvalues = 0;
            for (int i = dataList.Count - 1; i >= 0; i--)
            {
                allvalues = Convert.ToInt16(dataList[i]);
                if (allvalues != 0)
                {
                    Console.WriteLine($"{dataList[i]} is an integer. Skipping.");
                }

                else
                {
                    dataList.RemoveAt(i);
                }

            }

            int valueEntity = 0;
            Console.Write($"List of elements: ");
            for (int i = 0; i < dataList.Count; i++)
            {
                valueEntity += Convert.ToInt16(dataList[i]);
                Console.Write($" {dataList[i]}");
            }
            Console.WriteLine();
            Console.WriteLine($"Total sum of integer values is: {valueEntity} ");


            Assert.AreEqual(147, valueEntity);

        }
    }
}

