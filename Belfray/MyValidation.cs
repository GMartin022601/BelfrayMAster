using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belfray
{
    class MyValidation
    {
        //Length
        public static bool validLength(string txt, int min, int max)
        {
            bool ok = true;

            if (string.IsNullOrEmpty(txt))
            {
                ok = false;
            }

            else if (txt.Length < min || txt.Length > max)
            {
                ok = false;
            }
            return ok;
        }
        //Valid Number
        public static bool validNumber(string txt)
        {
            bool ok = true;

            for (int x = 0; x < txt.Length; x++)
            {
                if (!(char.IsNumber(txt[x])))
                {
                    ok = false;
                }
            }
            return ok;
        }
        //Valid Letter
        public static bool validLetter(string txt)  //allows alphabetic characters
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])))
                        ok = false;
                }
            }
            return ok;
        }
        //Valid letter with whitespace
        public static bool validLetterWhiteSpace(string txt)  //allows alphabetic characters and whitespace
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])))
                        ok = false;
                }
            }
            return ok;
        }
        //Valid letter number with whitespace
        public static bool validLetterNumberWhiteSpace(string txt)  //allows alphabetic characters and whitespace
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsNumber(txt[x])) && !(char.IsWhiteSpace(txt[x])))
                        ok = false;
                }
            }
            return ok;
        }
        //Valid Forename
        public static bool validForename(string txt) //allows aphatbetic, dash and whitespace
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])) && !(txt[x].Equals('-')))
                        ok = false;
                }
            }
            return ok;
        }
        //Valid Surname
        public static bool validSurname(string txt)
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])) && !(txt[x].Equals('-')))
                    {
                        ok = false;
                    }
                }
            }

            return ok;
        }
        //Valid Desc **NEEDS TO BE EDITED**
        public static bool validDesc(string txt) //allows aphatbetic, dash and whitespace
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsNumber(txt[x])) && !(char.IsWhiteSpace(txt[x])) && !(txt[x].Equals('-')) && !(txt[x].Equals('.')))
                        ok = false;
                }
            }
            return ok;
        }
        //Valid Email
        public static bool validEmail(string txt) //allows alphanumeric and whitespace
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsNumber(txt[x])) && !((txt[x].Equals('@'))) && !((txt[x].Equals('-'))) && !((txt[x].Equals('_'))) && !((txt[x].Equals('.'))))
                    {
                        ok = false;
                    }
                }
            }
            return ok;
        }
        //Valid DOB
        public static bool validDogDOB(string txt)
        {
            DateTime currentDate = DateTime.Now;
            DateTime dogDOB = Convert.ToDateTime(txt);

            TimeSpan t = currentDate - dogDOB;
            double NoOfDays = t.TotalDays;

            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                if (NoOfDays <= 56)
                    ok = false;
            }
            return ok;
        }
        //First Letter to Uppercase
        public static string firstLetterEachWordToUpper(string word) // not? working??
        {
            Char[] array = word.ToCharArray();

            if (Char.IsLower(array[0]))
            {
                array[0] = Char.ToUpper(array[0]);
            }
            //go through array and check for spaces, make any lowercase letters after a space uppercase
            for (int x = 1; x < array.Length; x++)
            {
                if (array[x - 1] == ' ')
                {
                    if (Char.IsLower(array[x]))
                    {
                        array[x] = Char.ToUpper(array[x]);
                    }
                }
                else
                    array[x] = Char.ToLower(array[x]);
            }
            return new string(array);
        }
        //Each Letter to upper case
        public static string EachLetterToUpper(string word)
        {
            Char[] array = word.ToCharArray();

            for (int x = 0; x < array.Length; x++)
            {
                if (Char.IsLower(array[x]))
                {
                    array[x] = Char.ToUpper(array[x]);
                }
            }
            return new string(array);
        }

        public static bool validDogDOB2(DateTime dogDOB)
        {
            DateTime currentDate = DateTime.Now;

            TimeSpan t = currentDate - dogDOB;

            double noOfDays = t.TotalDays;
            bool ok = true;

            if (noOfDays <= 56)
                ok = false;

            return ok;
        }
    }
}
