using LinkedList;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to LinkedList Program");


/// <summary>
/// UC7 - To search an element in linked list
/// /// </summary>

LinkedLis<int> myList = new LinkedLis<int>();
myList.Add(56);
myList.Add(30);
myList.Add(70);

Console.WriteLine(myList.Search(30));

myList.Display();
