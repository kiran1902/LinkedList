using LinkedList;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to LinkedList Program");


/// <summary>
/// UC5 - To pop an element in linked list
/// /// </summary>

LinkedLis<int> myList = new LinkedLis<int>();
myList.Add(56);
myList.Add(30);
myList.Add(70);
myList.Display();

//Console.WriteLine("Linked List Before Inserting : ");
//myList.Display();
//myList.Pat_Pos(30, 2);
//Console.WriteLine("Linked List After Inserting");
//myList.Display();

Console.WriteLine("After Pop Method");
myList.Pop_Last(3);
myList.Display();
