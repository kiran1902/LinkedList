﻿using LinkedList;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to LinkedList Program");


/// <summary>
/// UC8 - Adding an element(40 after 30) in linked list
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
