namespace Task1_Week1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Q1

            //1- Write a program that allows the user to enter a number then print it
            /*
            Console.WriteLine("Enter a Number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your Number =  {userNumber}");
            */

            #endregion

            #region Q2
            /* 2- Write a program that takes a number from the user then print
            yes if that number can be divided by 3 and 4 otherwise print no.*/

            /*
            Console.WriteLine("Enter a Number :");
            int userNum = Convert.ToInt32(Console.ReadLine());
            if ((userNum % 3 == 0) && (userNum % 4 == 0))  
                Console.WriteLine($"Number {userNum} Divided By 3 and 4");

            */

            #endregion

            #region Q3

            /*
             3- Write a program that allows the user to insert 2 integers then print the max.

            Console.WriteLine("Enter Tow Numbers :");
            
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int resut= ((num1 > num2) ? num1 : num2);
            Console.WriteLine($"\n{resut}");

            */
            #endregion

            #region Q4
            /*
            4- Write a program that allows the user to insert an integer then 
            print negative if it is negative number otherwise print positive.

               
            Console.WriteLine("Enter a Numbers :");
            
            int num1 = Convert.ToInt32(Console.ReadLine());

            if(num1 < 0) Console.WriteLine("negative");
            else if (num1 > 0) Console.WriteLine("positive");
        
          */

            #endregion

            #region Q5
            /*
             5- Write a program that takes 3 integers from the user 
            then prints the max element and the min element.

                

            Console.WriteLine("Enter Three Numbers: ");

            int[] threeNumbers = new int[3];

            for (int i = 0; i < threeNumbers.Length; i++) threeNumbers[i]=Convert.ToInt32(Console.ReadLine());

            int temp = 0;

            foreach (int userInput in threeNumbers) if (userInput > temp) temp = userInput;

            Console.WriteLine($"max Number is = {temp}");

            foreach (int userInput in threeNumbers) if (userInput < temp) temp = userInput;

            Console.WriteLine($"min Number is = {temp}");

            */


            #endregion

            #region Q6
            /*
             6- Write a program that allows the user to insert an integer
            number then check If a number is even or odd.
             
            Console.WriteLine("Enter a Number : ");
            string evenNum = Console.ReadLine();
            int numE = int.Parse(evenNum);
            string addOrEven = (numE % 2 == 0) ? "Even\n" : "Odd\n";
            Console.WriteLine(addOrEven);
            */
            #endregion

            #region Q7
            /* 
             7- Write a program that takes character from the user then if it is a vowel chars 
            (a,e,I,o,u) then print (vowel) otherwise print (consonant).

          
            Console.WriteLine("Enter a character: ");

            char userChar = Convert.ToChar(Console.ReadLine());

         string isVowel= ((userChar == 'a') || (userChar == 'e') || (userChar == 'i') ||
                (userChar == 'o') || (userChar == 'u')) ? "vowel" : "consonant";
            Console.WriteLine(isVowel);

               */
            #endregion

            #region Q8
            /*
             8- Write a program that allows the user to insert an 
            integer then print all numbers between 1 to that number.

             
            Console.WriteLine("Enter a Number:");
            int toNum = Convert.ToInt32(Console.ReadLine());

            int inreaseNum = 1;
            Console.Write(inreaseNum++);

            while (inreaseNum <= toNum) Console.Write($", {inreaseNum++} ");

            */
            #endregion


            #region Q9
            /*
              9- Write a program that allows the user to insert 
             an integer then print a multiplication table up to 12. 

            Console.WriteLine("Enter a Number:");
            int multiplNum = Convert.ToInt32(Console.ReadLine());

            int inreaseNum = 1;
            
            while (inreaseNum <= 12) Console.Write( multiplNum*inreaseNum++ +" ");

            */
            #endregion

            #region Q10

            /*
             10- Write a program that allows to user to 
            insert number then print all even numbers between 1 to this number

            
            Console.WriteLine("Enter a Number:");
            int allEvenNum = Convert.ToInt32(Console.ReadLine());

            int inreaseNum = 1;


            while (inreaseNum <= allEvenNum)
            {
                if (inreaseNum % 2 == 0) Console.Write($"{inreaseNum} ");
                inreaseNum++;
            }

         */
            #endregion


            #region Q11

            /*
             11- Write a program that takes two integers then prints the power.
         
            Console.WriteLine("Enter Two Numbers :");

            int num = Convert.ToInt32(Console.ReadLine());
            int power = Convert.ToInt32(Console.ReadLine());


           Console.WriteLine($"{num} Power {power} = {Math.Pow(num,power)}");

            */

            #endregion

            #region Q12



            /*
             12- Write a program to enter marks of five subjects and 
            calculate total, average and percentage.

          
          

            Console.WriteLine("Enter Marks of five subjects:");

            String num = Console.ReadLine();

            String[] subjectsAverage = num.Split(' ');

            int result = 0;

            foreach (String val in subjectsAverage) result += Convert.ToInt32(val);


            int percentage = (result * 100) / (100 * subjectsAverage.Length );


            Console.WriteLine($"Total marks = {result}\n\t" +
                $"Average Marks = {result / subjectsAverage.Length}\n\tPercentage = {percentage}");

                */

            #endregion

            #region Q13

            /*
             13- Write a program to input the month number 
            and print the number of days in that month.
             
            Console.WriteLine("Month Number: ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());
            int days = 0;

            switch (monthNumber)
            {
                case 1:days = 31; break;
                case 2: days = 28; break;
                case 3: days = 31; break;
                case 4: days = 30; break;
                case 5: days = 31; break;
                case 6: days = 30; break;
                case 7: days = 31; break;
                case 8: days = 31; break;
                case 9: days = 30; break;
                case 10: days = 31; break;
                case 12: days = 30; break;
                case 13: days = 31; break;
                default: days = 0; break;

            }
            Console.WriteLine($"Days in Month: {days}");
            */

            #endregion

            #region Q14

            /*
             14- Write a program to input marks of five subjects Physics, 
            Chemistry, Biology, Mathematics and Computer, And Calculate percentage and grade.
             

            Console.WriteLine("Input Your marks of five subjects: ");
           
            String num = Console.ReadLine();

            String[] subjectsPercentage = num.Split(' ');

            int result = 0;

            foreach (String val in subjectsPercentage) result += Convert.ToInt32(val);

            int percentageCalculate = (result * 100) / (100 * subjectsPercentage.Length);


            if (percentageCalculate >= 90) Console.WriteLine($"{percentageCalculate}%: Grad A");
            else if (percentageCalculate < 90 && percentageCalculate >= 80) Console.WriteLine($"{percentageCalculate}%: Grad B");
            else if (percentageCalculate < 80 && percentageCalculate >= 70) Console.WriteLine($"{percentageCalculate}%: Grad C");
            else if (percentageCalculate < 70 && percentageCalculate >= 60) Console.WriteLine($"{percentageCalculate}%: Grad D");
            else if (percentageCalculate < 60 && percentageCalculate >= 40) Console.WriteLine($"{percentageCalculate}%: Grad E");
            else Console.WriteLine($"{percentageCalculate}%: Grad F");

            */

            #endregion

            #region Q15

            /*
             15 - Write a program to check whether a number is positive or negative or zero.

             

            Console.WriteLine("Input Your number  to check it: ");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0) Console.WriteLine($"Number {num} is Positive");
            else if (num < 0) Console.WriteLine($"Number {num} is Negative");
            else Console.WriteLine($"Number {num} is Zero");

            */

            #endregion


            #region Q16
            /*
             
            16- Write a program to create a Simple Calculator.


            Console.WriteLine("Welcome to the Simple Calculator!\n" +
                "Options:\n" +
                "1. Addition\n" +
                "2. Subtraction\n" +
                "3. Multiplication\n" +
                "4. Division\n" +
                "5. Reminder\n");

            Console.WriteLine("\nSelect an operation (1-5):");
            int operationNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the first operand:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second operand:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());


            int result = 0;

            switch (operationNumber)
            {
                case 1: result = firstNumber + secondNumber; break;
                case 2: result = firstNumber - secondNumber; break;
                case 3: result = firstNumber * secondNumber; break;
                case 4: result = firstNumber / secondNumber; break;
                case 5: result = firstNumber % secondNumber; break;

                default: result = 0; break;

            }

            Console.WriteLine($"The Result is = {result}");

            */

            #endregion

            #region Q17

            /*
             17- Write a program to allow the user to enter a string and print the REVERSE of it.
             

            Console.WriteLine("Enter Something to reverse it: ");

            String something = Console.ReadLine();

            String reverseString = "";
            
            for (int i = something.Length - 1; i >= 0; i--) reverseString += something[i];
            
            Console.WriteLine($"The Reverse of that String: {reverseString}");

            */

            #endregion

            #region Q18
            /*
             18- Write a program to allow the user to enter int and print the REVERSED of it.

            Console.WriteLine("Enter Number to reverse it: ");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0) Console.WriteLine($"Number After REVERSED = {num/-1}");
            else if (num < 0) Console.WriteLine($"Number After REVERSED = {num/-1}");
            else Console.WriteLine($"The REVERSED of {num} is Zero");

            */
            #endregion

            #region Q19
            /*
             19. Write a program in C# Sharp to find the sum of all elements of the array. 
             

            Console.WriteLine("Enter Element Nuber:");

            int n = Convert.ToInt32(Console.ReadLine());


            int[] sum = new int[n];

            Console.WriteLine("All Numbers :");

            int result = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i+1}) ");
                sum[i] += Convert.ToInt32(Console.ReadLine());
            }

            foreach (int i in sum) result += i;

            Console.WriteLine($"Result = {result}");

            */
            #endregion

            
            #region Q23

            /*
             23. Write a program in C# Sharp to find maximum and minimum element in an array

             
            int[] numbers = new int[] { 33,2,44,53,75,2,88};

            int tempMax  = numbers[1];
            foreach (int number in numbers) if (number > tempMax) tempMax = number;
            Console.WriteLine($"The Max Element = {tempMax}");

            int tempMin = numbers[1];
            foreach (int number in numbers) if (number < tempMin) tempMin = number;
            Console.WriteLine($"The Min Element = {tempMin}");

            */

            #endregion

            #region Q24

            /*
             24. Write a program in C# Sharp to find the second largest element in an array.
         

            int[] Numbers = new int[] {2, 22,43,65,2,45,2,1};

            int tempFirstMax = 0;
            int tempSecondMax = 0;
            

            foreach (int userInput in Numbers) if (userInput > tempFirstMax) tempFirstMax = userInput;
            foreach (int userInput in Numbers) if (userInput > tempSecondMax && userInput != tempFirstMax) tempSecondMax = userInput;


            Console.WriteLine($"The Socend Largest Number is = {tempSecondMax}");

                */
            #endregion
        }

    }
}