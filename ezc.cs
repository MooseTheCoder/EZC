using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;

namespace YOUR_PROJECT_NAMESPACE
{
    class ezc
    {
        //User console interaction
        public static void echo(string tOut, [Optional] bool read)
        {
            Console.WriteLine(tOut);
            if (read == true)
            {
                Console.ReadLine();
            }
        }
        public static string readUserInput()
        {
            string stringFromUser = Console.ReadLine();
            return stringFromUser;
        }
        public static string[] arrayFromDelimiter(int type, [Optional] char CharDelimiter,[Optional] string stringDelimiter, string toParse)
        {
            //1 = single char
            //2 = string delimiter
            if (type == 1)
            {
                string[] parsed_1 = toParse.Split(CharDelimiter);
                return parsed_1;
            }
            else
            {
                string[] parsed_2 = toParse.Split(new[] {stringDelimiter}, StringSplitOptions.None);
                return parsed_2;
            }
        }
        //user system interaction
        public static string readFile(string fileLocation)
        {
            string f = File.ReadAllText(fileLocation);
            return f;
        }
        public static void writeToFile(string fileLocation, string newFileName, string stringToWrite)
        {
            File.Create(fileLocation + newFileName).Close();
            File.WriteAllText(fileLocation + newFileName, stringToWrite);
        }
        public static bool deleteFile(string fileLocation)
        {
            if (!File.Exists(fileLocation))
            {
                return false;
            }
            else
            {
                File.Delete(fileLocation);
                if (!File.Exists(fileLocation))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        } 
    }
}
