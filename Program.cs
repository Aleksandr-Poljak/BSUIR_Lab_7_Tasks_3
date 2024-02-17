// TASK 3
using BSUIR_Lab_7_Tasks_3;

Console.WriteLine("TASK 3");

User Alex = new User("Alex", "Petrov", 24, 10);
User Victor = new User("Victor", "Ivanov", 21, 9);
User Anna = new User("Anna", "Veselova", 26, 12);
User Olga = new User("Olga", "Temofeeva", 22, 11);

User[] users = { Alex, Victor, Olga, Anna };

Array.Sort(users);
Console.WriteLine("Стандартная сортировка по имени.");
foreach (User user in users)
{
    user.Print();
}

Console.WriteLine("\nСоритровка по возрасту.");
Array.Sort(users, new CompareUserAge());
foreach (User user in users)
{
    user.Print();
}

Console.WriteLine("\nСоритровка по id.");
Array.Sort(users, new ComparerUserId());
foreach (User user in users)
{
    user.Print();
}


Console.WriteLine("\nTASK 3");
FibonacciNumbers Fib1 = new(0, 100); // 0 1 1 2 3 5 8 13 21 34 55 89
FibonacciNumbers Fib2 = new(30, 400); // 34 55 89 144 233 377
foreach (var num in Fib1.GetNumbers())
{
    Console.Write(num.ToString() + " ");
}


