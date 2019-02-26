using System;
using System.Collections.Generic;
namespace Delegates
{
    public class Sort

    {

     IList<string> strList  = new List<string>();

     public   void MakeList()
        { 
        strList.Add("Object 1");
            strList.Add("Object 2");
            strList.Add("third Object");
            strList.Add("fourth thing");
            strList.Add("Akshay Srikumar");
            strList.Add("C# Task");
            strList.Add("SSsSS");
        }
        public void DisplayList()
        {
            foreach(string item in strList)
            {
             Console.WriteLine(item);
            }
        }
        public Comparison<T> comparator;
    }
}
