using System;

namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 15;
            printPrimeNumbers(a, b);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);
            Console.ReadKey();


            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);
            Console.ReadKey();



            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);
            Console.ReadKey();


            int n4 = 5;
            printTriangle(n4);
           

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);
          

            /* Self reflection
            * The assigment was quite helpful in making us familiar with the syntax, IDE- visual studio and basic commands
            * It covered almost every basic concepts like different loops, datatypes, coversion, methods etc
            * The best part I liked about the assignment was writing different codes all together and the description of every step
            * The description writing part made sure the we understand each and every line of the code.
            * Recommendation-
            * I would be very helpful if we are provided with most optimized and straight code, once our assignment has been graded.
            * This would help us understand where we could have done things in a better way.*/




        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                Console.Write("The prime numbers between " + x + " and " + y + " are:"); //Custom output message
                int i, j, k; //variables declaration
                for (i = x; i < y; i++) //for loop initialization to find all the prime numbers between x and y
                {
                    k = 0; //k variable initialilized to 0
                    if (i > 1) //if loop nested inside the for loop to check the starting value is greater than 1
                    {
                        for (j = 2; j < i; j++) // nested for loop to divide the number with all possible value less than itself
                        {
                            if (i % j == 0)//nested if to check if the remainder is zero
                            {
                                k = 1;// assign 1 to k of the remainder is zero
                                break;// break and exit the loop after if condition is satisfied
                            }
                        }// if the reminder is not zero and the condition mentioned above is not satisfied, k will be equal to zero
                        if (k == 0)//check if k is equal to zero
                        {
                            Console.WriteLine(i); //output the value of i after the above if condition is satisfied.

                        }
                    }
                }
                Console.ReadKey(); // basically holds the output window untill a key is pressed

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }
        /* Summary: This method computes the series 1/2 – 2!/3 + 3!/4 – 4!/5 --- n     
        * where ! means factorial, i.e., 4! = 4*3*2*1 = 24. Round off the results to 
        * three decimal places.*/

        public static double getSeriesResult(int n1)
        {
            try
            {
                double calcfact(double g) //function to calculate factorial of a number
                {
                    double i, k = 1; //declare variable i and k, initialize k to 1

                    for (i = 1; i <= g; i++) // for loop to multiply from 1 to the upto input g
                    { k = k * i; } //multiplication  and storing the value in k
                    return k; //returning the output k
                }
                double b = Convert.ToDouble(n1); // initialize variable b and store the value of integer n1 as double in b
                double m, j, z = 0;    //declare variable m,j and z, initialize z to 0
                for (j = 1; j <= b; j++) //for loop initialization to do the calculation
                {
                    m = (calcfact(j) / (j + 1)); //assigning the value (j!/(j+1)) to m
                    if (j % 2 == 0)// check if no is even
                    {
                        m = -m; // make the no negative if it is even

                    }
                    z += m;// add the the value of m to z after every loop iteration
                }
                return (Math.Round(z, 3)); // round the number z to 3 decimal places and eturn the value
                

            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }
        /* summary: This method converts a number from decimal (base 10) to binary(base 2).*/
        public static long decimalToBinary(long n)
        {
            try
            {
                int b = Convert.ToInt32(n);//declare integer b ans assign the value of n after converting it to int
                string z = "";// declare an empty string
                while (b > 1)//perform the below mentioned functions if the input is greater than 1
                {
                    int r;//declare integer r, to store the remainder value;
                    r = b % 2;//store the value of reminder in r
                    b = b / 2;//divide the input for the loop
                    z = r.ToString() + z;//store the value of reminder by converting it to string and concatination

                }
                if (b < 0)// check if input is negative
                {
                    Console.WriteLine("Error: Input is negative");// return an error message mentioning
                }
                else
                    z = Convert.ToString(b) + z;// concatenate the value of z and final b after converting it to string
                return (Convert.ToInt64(z));// return the output after convrsion to long
                

            }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }

            return 0;
        }

        /* summary: This method converts a number from binary(base 2) to decimal (base 10).*/
        public static long binaryToDecimal(long n)
        {
            try
            {

                long z = 1, d = 0, r; //declare the integers and initialize z to 1 and d to 0
                while (n > 0)// execute the below mentioned statements if input is greater than 1
                {
                    r = n % 10;// store the remainder of n divided by 10 in r
                    d = d + r * z;  //store the value in d after every iteration
                    n = n / 10;// n stores the position of every unit place and the loop stops when it reduces to zero
                    z = z * 2; // z multiplies with 2 in every iteration

                }
                return (d); // return the final vlue of d after the while loop is executed

            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return 0;
        }

        /* summary      : This method prints a triangle using *
        * For example n = 5 will display the output as: 

              *
             ***
            *****
           *******
          *********
                                    */

        public static void printTriangle(int n4)
        {
            try
            {
                int i, j, k; //declare the integers i,j and k
                for (i = 1; i <= n4; i++) // for loop to be executed from i=1 to the input value n4 with increment every time
                                          // for n4 number of rows
                {
                    for (j = 1; j <= n4 - i; j++)//for loop to be executed from j=1 to one values less than the input n4 with increment every time
                                                 //this loop will print the blank spaces before *
                    {

                        Console.Write(" "); // print the blank spaces before the *
                    }
                    for (k = 1; k < i * 2; k++)//for loop to be executed from k=1 to twice the value of outermost loop with increment every time
                                               //this loop will print the *
                    {
                        Console.Write("*");// print the blank spaces before the *
                    }
                    Console.WriteLine();// print the *
                }
                Console.ReadKey();// basically holds the output window untill a key is pressed

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }
        /* summary      : This method computes the frequency of each element in the array
         * For example a = {1,2,3,2,2,1,3,2} will display the output as: 

            Number	Frequency
                  1	2
                  2	4
                  3	2                           */

        public static void computeFrequency(int[] arr)
        {
            try
            {
                int i, n, d, j; //declare the integers i, d, j and n
                n = arr.Length; // store the lenth of the input array in n
                int[] arr1 = new int[n]; //create a new arrary arr1 of length n
                for (i = 0; i < n; i++) // for loop to insert values into arr1 equivalent to length of arr
                {
                    arr1[i] = -1; //assign value -1 to every position in arr1
                }
                for (i = 0; i < n; i++)// for loop to check every value in the array from 0th position till nth(length of array)
                {

                    d = 1;//initialize the variable d to 1
                    for (j = i + 1; j < n; j++)// for loop t find the mathching values in the array arr
                    {
                        if (arr[i] == arr[j])// check if the i th position element of arr is equal to j th position element
                        {
                            d++;// increament the value of d if the  IF condition is satisfied
                            arr1[j] = 0;// update the element at j th position to 0
                        }
                    }
                    if (arr1[i] != 0)// if loop to write the frequency
                    {
                        arr1[i] = d;//  update the element at i th position equal to d
                    }
                }
                Console.WriteLine("Number\tFrequency");// this line will print the Column names
                for (i = 0; i < n; i++)// for loop to print the results for every unique value in arr
                {
                    if (arr1[i] != 0)// check so the that no frequnecy of value 0 is printed
                    {
                        Console.Write(arr[i]); //write the i th element of arr
                        Console.Write(" \t"); // to print tab between the number and the frequency
                        Console.Write(arr1[i]); //write the frequency of i th element stored in arr1
                        Console.Write("\n");// to print the next iteration in new line
                    }
                }
                Console.ReadKey();// basically holds the output window untill a key is pressed

            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}

