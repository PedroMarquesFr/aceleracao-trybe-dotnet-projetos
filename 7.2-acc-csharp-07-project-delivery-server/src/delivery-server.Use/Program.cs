using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace delivery_server;

public class Program
{
       
    public static void Main(string[] args)
    {
        var OrderHandler = new ProcessOrders();
        var Feijao = new Item("feijão", 5.0, 2000);
        var Arroz = new Item("arroz", 1.0, 1000);
        var Carne = new Item("carne", 10.0, 6000);
        
        OrderHandler.AddOrder(Feijao, 3);
        OrderHandler.AddOrder(Arroz, 20);
        OrderHandler.AddOrder(Carne, 20);
        while(true)
        {
        }
    }
}
