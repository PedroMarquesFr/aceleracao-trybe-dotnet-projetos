namespace calendar_events;
#pragma warning disable CS8602

public class EventList
{
    private class Node<T>
    {
        public T Value;
        public Node<T>? Next;

        public Node(T t)
        {
            Value = t;
            Next = null;
        }
    }

    private Node<Event>? Head;

    public void GenericList()
    {
        Head = null;
    }

    public void Add(Event input)
    {
        if (Head == null)
        {
            Head = new Node<Event>(input);
        }
        else
        {
            //Encontra onde inserir o próximo nó na lista.
            Node<Event>? lastNode = Head;
            while (lastNode.Next != null) lastNode = lastNode.Next;

            lastNode.Next = new Node<Event>(input);
        }
    }

    public void Print(string format)
    {
        Node<Event>? printNode = Head;
        while (printNode.Next != null)
        {
            printNode = printNode.Next;
            Console.Write(printNode.Value.EventDate.ToString(format));
        }

    }

    public Event Index(int index)
    {
        Node<Event>? searchNode = Head;
        for (int i = 0; i < index; i++)
        {
            if (searchNode.Next != null)
            {
                searchNode = searchNode.Next;
                continue;
            }
            else
            {
                throw new InvalidOperationException("Não há elementos suficientes na lista");
            }
        }
        return searchNode.Value;
    }

    public int SearchByTitle(string title)
    {
        Node<Event>? printNode = Head;
        int indexCounter = 0;
        do
        {
            if (printNode.Value.Title == title) return indexCounter;
            indexCounter += 1;
            printNode = printNode.Next;
        } while (printNode.Next != null);
        throw new InvalidOperationException("Não há elementos suficientes na lista");
    }

    public int SearchByDate(string dateSearch)
    {
        Node<Event>? printNode = Head;
        int indexCounter = 0;
        do
        {
            if (printNode.Value.EventDate == Convert.ToDateTime(dateSearch)) return indexCounter;
            indexCounter += 1;
            printNode = printNode.Next;
        } while (printNode.Next != null);
        throw new InvalidOperationException("Não há elementos suficientes na lista");
    }

}