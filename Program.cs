using System;
using System.Globalization;
using System.Linq;
//Predefine functionality available to us as package


namespace Demo_Types_inCSharp // user define package 
{
    internal class Program // public, private , protected, internal class is accessible within the same assembly
    {
        static void Main(string[] args)
        {
            // value types
            //int a = 10;
            //int b = a; // b is a copy of a
            //b = 20; // changing b does not affect a
            //Console.WriteLine($"Value Types: a = {a}, b = {b}"); // Output: a = 10, b = 20

            //Person p1 = new Person();// creating an instance of Person
            //p1.Name = "Raj";
            //Person p2 = new Person(); // creating another instance of Person
            //p2 = p1; // p2 references the same object as p1
            //p2.Name = "Ravi"; // changing p2 affects p1
            //Console.WriteLine(p1.Name);

            //Console.WriteLine("here we can understand diff between implicit and explicit conversion in .NET ");
            //// Implicit conversion

            //int intValue = 123;
            //long longValue = intValue; // Implicit conversion from int to long
            //Console.WriteLine($"Implicit conversion: int {intValue} to long {longValue}");

            //double doubleValue = longValue; // Implicit conversion from long to double
            //Console.WriteLine($"Implicit conversion: long {longValue} to double {doubleValue}");
            //// Explicit conversion

            //double anotherDoubleValue = 123.456;
            //int anotherIntValue = (int)anotherDoubleValue; // Explicit conversion from double to int
            //Console.WriteLine($"Explicit conversion: double {anotherDoubleValue} to int {anotherIntValue}");
            //// Note: The explicit conversion truncates the decimal part, so 123.456 becomes 123.

            ////Convert.ToInt32(), int.Parse(), .ToString()
            //Console.WriteLine(" there are different ways of explicit conversion : ");
            //string stringValue = "456";
            //int parsedIntValue = int.Parse(stringValue); // Using int.Parse
            //Console.WriteLine($"Parsed int value: {parsedIntValue}");
            //int convertedIntValue = Convert.ToInt32(stringValue); // Using Convert.ToInt32
            //Console.WriteLine($"Converted int value: {convertedIntValue}");

            //string anotherStringValue = 789.ToString(); // Using ToString
            //Console.WriteLine($"String value from int: {anotherStringValue}");
            // multiple ways of converting into string 
            // Note: int.Parse and Convert.ToInt32 can throw exceptions if the string is not a valid integer.


            // As a developer we need to work on seat booking system, we can use array to store the seat numbers and their availability status.
            //there are 50 rows and 10 columns of seats in the theatre, we can use a 2D array to represent the seating arrangement.
            //initially all seats are available, when a user books a seat it shul dbe marked as booked.
            //We need to create a logic for displaying the seating arrangement , allowing users to book seats, and displaying the booked seats.
            //Creating a 2D array to represent the seating arrangement

            //Step 1: Declare a 2D array for seating arrangement with rows and columns
            //Step 2: Initialize the 2D array with seat numbers and availability status
            //Step 3: Display the seating arrangement after initialization and before booking
            //Step 4: Allow users to book seats by selecting a seat number
            //Step 5: Display the seating arrangement after booking

            int rows = 10;
            int cols = 10;

            string[,] seatingArrangement = new string[rows, cols];

            Console.WriteLine("Seating Arrangement:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Initializing seat numbers in the format "Row-Column"
                    seatingArrangement[i, j] = $"|(A)|-{i + 1}-{j + 1}";
                }
            }

            // Displaying the seating arrangement
            //Console.WriteLine(string.Join(" ", seatingArrangement.Cast<string>().Skip(i * cols).Take(cols)));
            // in  above statement is used to format the output of each row of seats where
            // here we are using String .Join to join the elements of the array with a space separator
            // and Cast<string>() is used to convert the 2D array to a 1D array for formatting
            //then  we are using skip(i * columns) to skip the elements of the previous rows
            //take(columns) is used to take the elements of the current row



            //displaying each row of seats for my 2D array using for loop
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(seatingArrangement[i, j] + " "); // Displaying each seat in the row
                }
            }

            // Displaying each row of seats and using string.Join to format the output along with seat numbers using cast and skip methods

            //Step 4: Allow users to book seats by selecting a seat number
            Console.WriteLine("Enter the row number (1 to 5) to book a seat:");
            int selectedRow = Convert.ToInt32(Console.ReadLine()) - 1; // User input for row number (1 to 5)
            Console.WriteLine("Enter the column number (1 to 5) to book a seat:");
            int selectedColumn = Convert.ToInt32(Console.ReadLine()) - 1; // User input for column number (1 to 5)
            // Step 5: Check if the selected seat is available and book it
            if (selectedRow >= 0 && selectedRow < rows && selectedColumn >= 0 && selectedColumn < cols)
            {
                // Check if the seat is already booked
                if (seatingArrangement[selectedRow, selectedColumn].Contains("Booked"))
                {
                    Console.WriteLine("Sorry, this seat is already booked.");
                }
                else
                {
                    // Mark the seat as booked
                    seatingArrangement[selectedRow, selectedColumn] = $"|(B)|-{selectedRow + 1}-{selectedColumn + 1}"; // Marking the seat as booked
                    Console.WriteLine($"Seat at Row {selectedRow + 1}, Column {selectedColumn + 1} has been booked successfully.");
                }
            }
            else
            {
                Console.WriteLine("Invalid seat selection. Please try again.");
            }

            //displaying the seating arrangement after booking
            Console.WriteLine("Seating Arrangement after booking:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(seatingArrangement[i, j] + " "); // Displaying each seat in the row
                }
                Console.WriteLine(); // Move to the next line after displaying each row
            }

        }
    }
    // reference types
    public class Person
    {
        public string Name;
    }

}