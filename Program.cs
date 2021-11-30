namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to calculate BMI. Press 2 to view membership rates:");
            char selection = Console.ReadKey().KeyChar;
            if (selection == '1')
            {
                Console.WriteLine("\nPlease enter your weight in kilograms:");
                var weightInput = Console.ReadLine();
                double weight = 0;

                // Handle error re-prompt user for input
                while (!double.TryParse(weightInput, out weight))
                {
                    Console.WriteLine("Incorrect input please re-enter weight:");
                    weightInput = Console.ReadLine();
                    weight = 0;
                }

                Console.WriteLine("Please enter your height in meters:");
                var heightInput = Console.ReadLine();
                double height = 0;

                // Handle error re-prompt user for input
                while (!double.TryParse(heightInput, out height))
                {
                    Console.WriteLine("Incorrect input please re-enter height:");
                    heightInput = Console.ReadLine();
                    height = 0;
                }

                double BMI = weight / (height * height);
                Console.WriteLine($"Your BMI is: {BMI:0.##}");

                if (BMI < 18.5)
                {
                    Console.WriteLine("You are underweight!");
                }

                else if (BMI <= 25)
                {
                    Console.WriteLine("You are normal weight!");
                }

                else if (BMI <= 30)
                {
                    Console.WriteLine("You are overweight!");
                }

                else
                {
                    Console.WriteLine("You are obese!");
                }


            }
            else if (selection == '2')
            {
                throw new NotImplementedException();
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}