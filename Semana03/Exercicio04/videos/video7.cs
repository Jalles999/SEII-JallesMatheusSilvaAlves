//Stack


using video1.Stack;

Stack stack = new Stack();

for (int i = 0; i < 3; i++)
{
    stack.Push("Squirtle");
    stack.Push("Pickachu");
    stack.Push("Charmander");

}

stack.Pop();
stack.Peek();

while(!stack.isEmpty())
{
    var var = stack.Pop();
    Console.WriteLine(var);
}