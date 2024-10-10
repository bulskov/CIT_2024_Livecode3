
int[] numbers = [1, 2, 3, 4, 5];


// delegate int Transformer(int x);



var z = 2;

Action<int[], Func<int, int>> print = Print;


print(numbers, x => x - z);




//Print(numbers, );

//SquareNumbers(numbers);

//AddTenToNumbers(numbers);



//static int Square(int x)
//{
//    Console.WriteLine("Square");
//    return x * x;
//}

//static int AddTen(int x)
//{
//    Console.WriteLine("AddTen");
//    return x + 10;
//}

static void Print(int[] numbers, Func<int, int> fn)
{
    foreach (var n in numbers)
    {
        Console.WriteLine(fn(n));
    }
    Console.WriteLine();
}


//static void SquareNumbers(int[] numbers)
//{
//    foreach(var n in numbers)
//    {
//        Console.WriteLine(n * n);
//    }
//    Console.WriteLine();
//}

//static void AddTenToNumbers(int[] numbers)
//{
//    foreach (var n in numbers)
//    {
//        Console.WriteLine(n + 10);
//    }
//    Console.WriteLine();
//}


//delegate int Transformer(int x);