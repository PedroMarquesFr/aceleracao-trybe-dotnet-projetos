namespace generic_list;

public class GenericList<T>
{
    private class Node
    {
        public T Value;
        public Node? Next;

        public Node(T t)
        {
            Value = t;
            Next = null;
        }
    }

    private Node? Head;

    public GenericList()
    {
        Head = null;
    }

    public void Add(T input)
    {
        if (Head == null)
        {
            Head = new Node(input);
        }
        else
        {
            //Encontra onde inserir o próximo nó na lista.
            Node lastNode = Head;
            while (lastNode.Next != null) lastNode = lastNode.Next;

            lastNode.Next = new Node(input);
        }
    }

    public void Print()
    {
        Node? printNode = Head;
        while (printNode.Next != null)
        {
            Console.Write(printNode.Value + " ");
            printNode = printNode.Next;
        }
        Console.WriteLine(printNode.Value);
    }

    public T Index(int index)
    {
        Node? printNode = Head;
        int counter = 0;
        while (printNode != null)
        {

            if (counter == index) return printNode.Value;
            printNode = printNode.Next;
            counter += 1;
        }
        throw new InvalidOperationException("Não há elementos suficientes na lista");
    }

    public int Search(T element)
    {
        Node? printNode = Head;
        int counter = 0;
        while (printNode != null)
        {
            if (printNode.Value.Equals(element)) return counter;
            printNode = printNode.Next;
            counter += 1;
        }
        throw new InvalidOperationException("Elemento não está na lista");
    }

}