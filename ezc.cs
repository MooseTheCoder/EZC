using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;

namespace ezSharp
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
        //user system interaction
            //file interaction
                //read
        public static string readFile(string fileLocation)
        {
            string f = File.ReadAllText(fileLocation);
            return f;
        }
        public static string[] readFileLinesToArray(string fileLocation)
        {
            string[] contentsArray = File.ReadAllLines(fileLocation);
            return contentsArray;
        }
                //write
        public static void writeToFile(string fileLocation, string newFileName, string stringToWrite)
        {
            File.Create(fileLocation + newFileName).Close();
            File.WriteAllText(fileLocation + newFileName, stringToWrite);
        }
                //Important alter
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
        public static bool copyFile(string source, string destination)
        {
            string sourceContents = File.ReadAllText(source);
            File.Create(destination).Close();
            File.WriteAllText(destination, sourceContents);
            if (File.Exists(destination))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //data
            //create / parse
        public static string[] arrayFromDelimiter(int type, [Optional] char CharDelimiter, [Optional] string stringDelimiter, string toParse)
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
                string[] parsed_2 = toParse.Split(new[] { stringDelimiter }, StringSplitOptions.None);
                return parsed_2;
            }
        }
            //convet
        public static string toString(object toConvert)
        {
            return Convert.ToString(toConvert);
        }
        public static object toInt(int type,object toConvert)
        {
            /*
             * 1=16
             * 2=32
             * 3=64
            */

            if (type == 1)
            {
                return Convert.ToInt16(toConvert);
            }
            else if (type == 2)
            {
                return Convert.ToInt32(toConvert);
            }
            else if (type == 3)
            {
                return Convert.ToInt64(toConvert);
            }
            else
            {
                return 0;
            }
        }
    }
}
