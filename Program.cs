static void PrintNumbers()
{
    // Print all of the integers from 1 to 255.
    for (int i = 1; i <= 255; i++)
    {
        Console.WriteLine(i);
    }
}

static void PrintOdds()
{
    // Print all of the odd integers from 1 to 255.
    for (int i = 1; i <= 255; i++)
    {
        if ((i % 2) != 0)
        {
            Console.WriteLine(i);
        }
    }
}
static void PrintSum()
{
    // Print all of the numbers from 0 to 255, 
    // but this time, also print the sum as you go. 
    // For example, your output should be something like this:

    // New number: 0 Sum: 0
    // New number: 1 Sum: 1
    // New number: 2 Sum: 3
    int TempResult = 0;
    for (int i = 0; i <= 255; i++)
    {
        Console.WriteLine("New numbre: " + TempResult + "Sum: " + i);
        TempResult += i;
    }
}

static void LoopArray(int[] numbers)
{
    // Write a function that would iterate through each item of the given integer array and 
    // print each value to the console. 

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i]);
    }
}
static int FindMax(int[] numbers)
{
    // Write a function that takes an integer array and prints and returns the maximum value in the array. 
    // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
    // or even a mix of positive numbers, negative numbers and zero.

    int result = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > result)
        {
            result = numbers[i];
        }
    }

    return result;
}

static void GetAverage(int[] numbers)
{
    // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
    // For example, with an array [2, 10, 3], your program should write 5 to the console.

    int average = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        average += numbers[i];
    }
    average = (int)(average / numbers.Length);
    Console.WriteLine("El promedio es " + average);
}

static List<int> OddList()
{
    // Write a function that creates, and then returns, a List that contains all the odd numbers between 1 to 255. 
    // When the program is done, the List should have the values of [1, 3, 5, 7, ... 255].

    List<int> result = new List<int>();
    for (int i = 1; i <= 255; i++)
    {
        if ((i % 2) != 0)
        {
            result.Add(i);
        }
    }
    return result;
}

static int GreaterThanY(List<int> numbers, int y)
{
    // Write a function that takes an integer List, and an integer "y" and returns the number of values 
    // That are greater than the "y" value. 
    // For example, if our List contains 1, 3, 5, 7 and y is 3. Your function should return 2 
    // (since there are two values in the List that are greater than 3).
    int result = 0;
    for (int i = 0; i < numbers.Count; i++)
    {
        if (y > numbers[i])
        {
            result++;
        }
    }
    return result;
}

static void SquareArrayValues(List<int> numbers)
{
    // Write a function that takes a List of integers called "numbers", and then multiplies each value by itself.
    // For example, [1,5,10,-10] should become [1,25,100,100]
    for (int i = 0; i < numbers.Count; i++)
    {
        numbers[i] = numbers[i] * numbers[i];
    }
}

static void EliminateNegatives(List<int> numbers)
{
    // Given a List of integers called "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
    // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
    for (int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] < 0)
        {
            numbers[i] = 0;
        }
    }
}














