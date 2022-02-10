using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice
{

    public class Class1
    {
        static void Main(string [] args)
        {
            string str = "World Wide Web";
            string str2 = "FarhatVAIMuhibVAIErajVAI";

            Console.WriteLine(Split(str,' '));
        }

        static string Split(string str, char toSplit)
        {
            //string str = "World Wide Web";

            StringBuilder subs = new StringBuilder();
            StringBuilder sb = new StringBuilder();
            sb.Append(str[0]);

            for (int i = 0; i < str.Length; i++)
            {
                subs.Append(str[i]);
                if (str[i] == toSplit)
                {
                    sb.Append(subs[0]);
                    subs.Clear();
                }
            }
            return sb.ToString();
        }


        /*static string Split(string str, string subToSplit)
        {

            StringBuilder subs = new StringBuilder();
            StringBuilder sb = new StringBuilder();
            sb.Append(str[0]);

            for (int i = 0; i < str.Length; i++)
            {
                subs.Append(str[i]);
                if (str[i] == toSplit)
                {
                    sb.Append(subs[0]);
                    subs.Clear();
                }
            }
            return sb.ToString();
        }*/

    }
}
