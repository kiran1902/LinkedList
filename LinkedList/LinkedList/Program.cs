using LinkedList;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to LinkedList Program");


/// <summary>
/// UC9 - Delete an element(40) in linked list
/// </summary>

LinkedLis<int> myList = new LinkedLis<int>();
myList.Add(56);
myList.Add(30);
myList.Add(70);

Console.WriteLine("Before Adding");
myList.Display();
myList.Pat_Pos(40, 3);
Console.WriteLine("After adding");
myList.Display();

Console.WriteLine("After removing");
myList.Pop_Last(3);
myList.Display();
