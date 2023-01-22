using System;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LessonTAsk
            //task1
            //string[] names = { "amil", "rahim", "samir", "nuru" };
            //Console.WriteLine(namefinder(names, "amil"));
            //task2
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            //Console.WriteLine(numfinder(numbers, 10));
            //task3
            //int[] number2 = { 1, 2, 3, 4, 5, 6, 7, };
            //int[] value = { 7 };
            //Console.WriteLine(Ikireqemtapan(number2, value));
            //task4
            //Console.WriteLine(Charchecker('7'));
            //task5
            //var result = Console.WriteLine(charreqemdir());
            //task6
            //Console.WriteLine(findcahrindex("Vuqar", 'r'));
            //task7
            //Console.WriteLine(kesqaytar("vuqar", 2));
            //Task8
            //string[] wordlist = { "F1gma", "Ad0be", "Vi2ual", "3ode" };
            //var result4 = stringfindnumebr(wordlist);
            //Console.WriteLine($"Reqem olan yazilarin sayi: {result4} ");

            //-------------------------------------------------------------------------------------------------------------------

            //HomeTask
            //task1 Verilmiş string dəyərindəki ilk sözü tapan metod (ilk söz ilk boşluğa qədərki ifadədir)

            //Console.WriteLine("Yazini daxil edin: ");
            //string text = Console.ReadLine();
            //var result1 = findfirstword(text);
            //Console.WriteLine($"Yazidaki ilk soz: {result1} ");

            //task2 Verilmiş string dəyərindəki sözlərin sayını tapan metod (boşluqlarla ayrılan bütün ifadələri söz kimi nəzərə alın)

            //Console.Write("Yazi daxil edin :  ");
            //string sentence1 = Console.ReadLine();
            //var result2 = findword(sentence1);
            //Console.WriteLine($"Yazidaki sozlerin sayi : {result2}");

            ///task3 Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod
            //Misalçün verilmiş arraydə {4, -3, 10, -24}  dəyərləridirsə methoddan geriyə {4, 10} dəyərli array qayıdır.

            //int[] num2 = { -345, 4, -6, 24, 65, -9 };
            //var result3 = findarray(num2);
            //for (int i = 0; i < result1.Length; i++)
            //{
            //    Console.WriteLine(result3[i]);
            //
            //Taks5 Verilmiş yazıdaki ilk boşluq olmayan index - i qaytaran metod. Misalçun "  Salam" yazısında S ilk boşluq olmayan char-dır.

            //Console.WriteLine("Yazi daxil edin : ");
            //string word5 = Console.ReadLine();
            //var result6 = fisrtemptynonindexword(word5);
            //Console.WriteLine($"Yazida ilk boslugu olmayan char : {result6}");

            //Task6 Verilmiş yazını sol tərəfində boşluq olmayan vəziyyətdə qaytaran metod

            //Console.WriteLine("Yazini daxil edin:");
            //string word6 = Console.ReadLine();
            //Console.WriteLine(textleftemptynon(word6));
            //-------------------------------------------------------------------------------------------------------------------
        }
        //task1
        static string findfirstword(string word ) 
        {
            string str = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    str += word[i];
                }
                else
                {
                    break;
                }
            }
            return str;
        }
        //task2
        static int findword(string word)
        {
            int count = 1;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    count++;
                    
                }
                
            }
            return count;
        }
        //task3
        static int[] findarray(int[] num1)
        {
            int counter = 0;
            int count = 0;
            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i] > 0)
                {
                    count++;
                }
            }
            
            int[] numf = new int[count];
            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i]>0)
                {
                    numf[counter] = num1[i];
                    counter++;
                }
            }
            return numf;
        }
        //task4
        static bool IsDigit(char symbol)
        {           
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == symbol)
                    return true;
            }
            return false;
        }
        static bool HasChar(char ch)
        {
            char[] cr = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            for (int i = 0; i < cr.Length; i++)
            {
                if (ch == cr[i])
                {
                    return true;
                }
            }
            return false;
        }


        static bool HasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (IsDigit(str[i]))
                    return true;
            }

            return false;
        }



        static int findwordnum(string[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (HasDigit(arr[i]))
                {
                    count++;
                }
            }
            return count;
           
        }
        static bool HasNumber(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (HasChar(str[i]))
                {
                    return true;
                }

            }
            return false;

        }
        static int stringfindnumebr(string[] str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (HasNumber(str[i]))
                {
                    count++;
                }
            }
            return count;
        }
        static int fisrtemptynonindexword(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    return i;
                    break;
                }
            }
            return -1;

        }
        static string textleftemptynon(string str)
        {
            int count = 0;
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
                if (i >= count)
                {
                    newStr += str[i];
                }
            }
            return newStr;



        }
        static bool namefinder(string[] name, string value)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
        static bool numfinder(int[] num1, int value1)
        {
            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i] == value1)
                {
                    return true;
                }
            }
            return false;
        }
        static bool Ikireqemtapan(int[] number2, int[] value)
        {
            for (int i = 0; i < number2.Length; i++)
            {
                for (int j = 0; j < value.Length; j++)
                {
                    if (number2[i] == value[j])
                    {
                        return true;
                    }
                }

            }
            return false;
        }
        static bool Charchecker(char cr)
        {

            bool reqemdir = true;
            bool reqemdeyil = false;
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == cr)
                {
                    return reqemdir;
                }
            }
            return reqemdeyil;
        }
        static bool charreqemdir(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (Charchecker(word[i]))
                {
                    return true;
                }
            }
            return false;
        }
        static int findcahrindex(string word, char cr)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == cr)
                {
                    return i;
                }
            }
            return -1;
        }
        static string kesqaytar(string words, int index)
        {
            string newword = "";
            for (int i = 0; i < index; i++)
            {
                newword += words[i];

            }
            return newword;
        }
        //Lesson Task
        //---------------------------------------------------------------------------------------------------------------
        static bool Namefinder(string[] arr, string value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                    return true;
            }

            return false;
        }
        static bool NumberFinder(int[] arr,int value)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                    return true;
            }

            return false;
        }        
        static bool Ikireqemtapan(int[] number2, int[] value)
        {
            for (int i = 0; i < number2.Length; i++)
            {
                for (int j = 0; j < value.Length; j++)
                {
                    if (number2[i] == value[j])
                    {
                        return true;
                    }
                }

            }
            return false;
        }


    }
}
