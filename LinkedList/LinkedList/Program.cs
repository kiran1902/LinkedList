using LinkedList;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to LinkedList Program");


/// <summary>
/// UC4 - Inserting an element at particular position in linked list
/// /// </summary>

LinkedLis<int> myList = new LinkedLis<int>();
myList.Add(56);
myList.Add(70);

Console.WriteLine("Linked List Before Inserting : ");
myList.Display();
myList.Pat_Pos(30, 2);
Console.WriteLine("Linked List After Inserting");
myList.Display();