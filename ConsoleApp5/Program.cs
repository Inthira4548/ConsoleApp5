using System.Text.RegularExpressions;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int height = 0;
            double weight = 0;
            string gender = "";

            Console.WriteLine();
            while (true)
            {
                Console.Write("Please input your full name : ");
                name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name) && Regex.IsMatch(name, @"^[a-zA-Zก-ฮะ-์]+$"))
                    break;

                Console.WriteLine("กรุณากรอกชื่อเป็น 'ตัวอักษร' เท่านั้น");
            }

            while (true)
            {
                Console.Write("Please fill in your gender (M/F) : ");
                gender = Console.ReadLine().ToUpper();

                if (gender == "M" || gender == "F")
                    break;

                Console.WriteLine("กรุณากรอกเพศเป็น 'M' หรือ 'F' เท่านั้น");
            }

            Console.WriteLine("Hello, welcome " + name);
            while (true)
            {
                Console.Write("Please fill in your height (cm) : ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out height) && height > 0)
                    break;

                Console.WriteLine("กรอกส่วนสูงเป็น 'ตัวเลข' เท่านั้น");
            }

            while (true)
            {
                Console.Write("Please fill in your weight (kg) : ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out weight) && weight > 0)
                    break;

                Console.WriteLine("กรอกน้ำหนักเป็น 'ตัวเลข' เท่านั้น");
            }

            double heightMeter = height / 100.0;
            double bmi = weight / (heightMeter * heightMeter);

            Console.WriteLine();
            Console.WriteLine("Your BMI is: " + bmi.ToString("0.00"));

            // ประเมินผล BMI
            if (bmi < 18.5)
                Console.WriteLine("สถานะ: ผอมเกินไป");
            else if (bmi < 23)
                Console.WriteLine("สถานะ: น้ำหนักปกติ");
            else if (bmi < 25)
                Console.WriteLine("สถานะ: น้ำหนักเกิน");
            else if (bmi < 30)
                Console.WriteLine("สถานะ: โรคอ้วนระดับ 1");
            else
                Console.WriteLine("สถานะ: โรคอ้วนระดับ 2");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
