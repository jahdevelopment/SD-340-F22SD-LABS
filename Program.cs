using SD_340_F22SD_LABS;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Collections;


var intList = new SD_340_F22SD_LABS.LinkedList<int>();
intList.AddData(1);
intList.AddData(2);
intList.AddData(3);

var stringList = new SD_340_F22SD_LABS.LinkedList<string>();

stringList.AddData("hello");
stringList.AddData("world");
stringList.AddData("!");

Console.WriteLine("Int list:");
intList.PrintData();

Console.WriteLine("\nString list:");
stringList.PrintData();
