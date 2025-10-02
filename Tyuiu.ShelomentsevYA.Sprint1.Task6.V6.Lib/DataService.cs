using tyuiu.cources.programming.interfaces.Sprint1;
using System;

namespace Tyuiu.ShelomentsevYA.Sprint1.Task6.V6.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {
            
            string[] words = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 1)
                {
                    
                    words[i] = words[i].Substring(1);
                }
                else
                {
                    
                    words[i] = "";
                }
            }

            
            return string.Join(" ", words);
        }
    }
}
