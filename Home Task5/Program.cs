using System.Security.Cryptography;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)

        {


        }
        #region Task1
        // 1.  Bir int parametr qəbul edən və o ədədə qədər bütün cüt ədədlərin cəmini ekrana yazdıran, həm return type-ı olan bir method, həm də void bir method yazırsız
        static void Sum(int number) 
        {
            int sum = 0;
            for (int i = 0; i <= number; i += 2)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        static int SumofNumber(int number1)
        {
            int result = 0;
            for (int i = 0; i <= number1; i += 2)
            {
                result += i;
            }

            return result;

        }
        #endregion
        #region Task 2
        // 2.Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.Misal olaraq, name = "  Code  Acacemy   " deyə bir variable - mız varsa onu yaratdigimiz metoda göndərdikdə variable-daki dəyər "CodeAcademy" olmalıdır

        static string WordConseder(string word)
        {
            string result = "";

            foreach (char L in word)
            {
                if (L != ' ')
                {
                    result += L;

                }
            }
            return result;

        }
        #endregion




    }
}









