using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace WPF_Study
{
    class Model : Abstractions.IModel
    {
        //public int firstValue;
        //public int secondValue;
        //public int result;
        //public void ShowIn(string message)
        //{
        //    Debug.WriteLine(message);
        //}

        //public void SaveIn(string message)
        //{
        //    Debug.WriteLine(message);
        //    if (firstValue == 0)
        //        firstValue = Int32.Parse(message);
        //    else
        //        secondValue = Int32.Parse(message);
        //}
        //public string Operation()
        //{
        //    result = firstValue + secondValue;
        //    return result.ToString();
        //}

        public string ReadFile(string path)
        {
            if(path == null)
                 path = "text.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string text = reader.ReadToEnd();
                return text;
            }
        }

        
    }
}
