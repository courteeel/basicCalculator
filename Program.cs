namespace basicCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input block
            Console.Write("enter first number > ");
            string userFirstNumber = Console.ReadLine();

            Console.Write("enter second number > ");
            string userSecondNumber = Console.ReadLine();

            // conversion block
            double parsedUserFirstNumber; // declare a variable to store the parsed double

            if (double.TryParse(userFirstNumber, out parsedUserFirstNumber))
            {
                // conversion succeeded
                Console.WriteLine("parsed userFirstNumber: " + parsedUserFirstNumber);
            }
            else
            {
                // conversion failed
                Console.WriteLine("invalid input for userFirstNumber");
            }

            double parsedUserSecondNumber; // declare a variable to store the second parsed double

            if (double.TryParse(userSecondNumber, out parsedUserSecondNumber))
            {
                // Conversion succeeded
                Console.WriteLine("parsed userFirstNumber: " + parsedUserSecondNumber);
            }
            else
            {
                // Conversion failed
                Console.WriteLine("invalid input for userFirstNumber");
            }

            // init block
            bool operationMultiply = false;
            bool operationDiv = false;
            bool operationAdd = false;
            bool operationSubtract = false;
            bool operationError = false;

            // second input block
            Console.Write("what operation would you like the program to execute? > ");
            string userOperationInput = Console.ReadLine();

            if (userOperationInput == "multiply")
            {
                operationMultiply = true;
            }
            else if (userOperationInput == "divide")
            {
                operationDiv = true;
            }
            else if (userOperationInput == "add")
            {
                operationAdd = true;
            }
            else if (userOperationInput == "subtract")
            {
                operationSubtract = true;
            }
            else
            {
                Console.WriteLine("that's not a valid input :(");
                operationError = true;
            }

            if (operationMultiply == true)
            {
                Console.WriteLine(parsedUserFirstNumber * parsedUserSecondNumber);
            }
            else if (operationDiv == true)
            {
                Console.WriteLine((double)parsedUserFirstNumber/(double)parsedUserSecondNumber);
            }
            else if (operationAdd == true)
            {
                Console.WriteLine(parsedUserFirstNumber + parsedUserSecondNumber);
            }
            else if (operationSubtract == true)
            {
                Console.WriteLine(parsedUserFirstNumber - parsedUserSecondNumber);
            }

        }
    }
}