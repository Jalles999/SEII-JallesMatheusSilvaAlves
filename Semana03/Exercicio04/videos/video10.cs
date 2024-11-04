using video1.BinarySearchTree;

BinarySearchTree bst = new BinarySearchTree();

bst.Insert(7, "Squirtle");
bst.Insert(23, "Ekans");
bst.Insert(151, "Mew");
bst.Insert(4, "Charmander");
bst.Insert(1, "Bulbasaur");


Console.WriteLine(bst.Find(151));

int value = 0;