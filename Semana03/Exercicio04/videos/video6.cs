// Linked-List

using video1.LinkedList;
using System.Text.Json.Nodes;
using System.Xml.Linq;


//Node nodeA = node();
//nodeA.Data = 865;

//Node nodeB = node();
//nodeB.Data = 344;

//Node nodeC = node();
//nodeC.Data = 888;

//Node nodeD = node();
//nodeD.Data = 222;

//nodeA.Next = nodeB;
//nodeB.Next = nodeC;
//nodeC.Next = nodeD; 
linkedList linkedList = new LinkedList();
linkedList.InsertFirst(1);
linkedList.InsertFirst(2);
linkedList.InsertFirst(3);
linkedList.InsertFirst(4);

linkedList.DeleteFirst();
linkedList.DeleteFirst();

linkedList.InsertsLast(546);
linkedList.InsertsLast(3434);

linkedList.DisplayList();


