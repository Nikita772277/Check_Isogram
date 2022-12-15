using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Isogram
    {
        public bool CheckingTheIsogram(string word)
        {
            var result = CheckNumber(word);
            if (result)
            {
                var resultEmpty = CheckEmpty(word);
                if (resultEmpty)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        int counter = 0;
                        for (int j = 0; j < word.Length; j++)
                        {
                            if (word[j] == word[i])
                            {
                                counter++;
                                if (counter > 1)
                                {
                                    Console.WriteLine($"Слово не изограмма");
                                    return false;
                                }
                            }
                        }
                    }
                    Console.WriteLine($"Слово изограмма");
                    return true;
                }
                Console.WriteLine($"Вы ничего не ввели");
                return false;
            }
            Console.WriteLine($"Вы ввели не слово");
            return false;
        }
        public bool CheckNumber(string word)
        {
            foreach (var i in word)
            {
                if (char.IsNumber(i) == true)
                {
                    return false;
                }
            }
            return true;
        }
        public bool CheckEmpty(string word)
        {
            var chek = string.IsNullOrEmpty(word);
            if (chek)
            {
                return false;
            }
            return true;
        }
    }
}
