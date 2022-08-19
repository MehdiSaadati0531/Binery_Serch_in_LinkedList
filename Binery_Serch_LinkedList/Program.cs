using LinkedList;

NodeOperation a = new NodeOperation();

for (int i = 0; i < 32; i++)
{
    a.InsertNodeAtLast(i);
}


Console.WriteLine(a.BinarySearchs(13));