using System;

namespace Library
{
    public class Calculate
    {

        #region " Edad "

        public void Edad()
        {
            Console.WriteLine("Enter year: ");

            var StrYear = Console.ReadLine(); //Input
            var Age = DateTime.Now.Year - Convert.ToInt32(StrYear);

            Console.WriteLine("Your age: " + Age);
        }

        #endregion

        public void PasarKaba()
        {

            Console.WriteLine("Enter Grade: ");

            var StrGrade = Console.ReadLine();
            var Grade = Convert.ToInt32(StrGrade);

            PasarKaba_Switch(Grade);
            //PasarKaba_IfElse(Grade);
        }

        void PasarKaba_Switch(int Grade)
        {
            switch (Grade)
            {
                case 100:
                case 85:
                    Console.WriteLine("Your grade is: {0}, {1}", Grade, "Pasar");
                    break;
                case 84:
                case 80:
                    Console.WriteLine("Your grade is: {0}, {1}", Grade, "Sabit");
                    break;
                case 79:
                case 0:
                    Console.WriteLine("Your grade is: {0}, {1}", Grade, "Bagsak");
                    break;
                default:
                    Console.WriteLine("Your grade is: {0}, {1}", Grade, "Bagos");
                    break;
            }

        }

        void PasarKaba_IfElse(int Grade)
        {
            if (Grade <= 100 && Grade >= 85)
            {
                Console.WriteLine("Your grade is: {0}, {1}", Grade, "Pasar");
            }
            else if (Grade <= 84 && Grade >= 80)
            {
                Console.WriteLine("Your grade is: {0}, {1}", Grade, "Sabit");
            }
            else if (Grade <= 79 && Grade >= 0)
            {
                Console.WriteLine("Your grade is: {0}, {1}", Grade, "Bagsak");
            }
            else
            {
                Console.WriteLine("Your grade is: {0}, {1}", Grade, "Bagos");
            }
        }
    }

}