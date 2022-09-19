using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace delivery_server;

public class ProcessOrders
{
    public ArrayList OrdersList;
    public int TimeToCheck;

    public ProcessOrders()
    {
        TimeToCheck = 1;
        OrdersList = new ArrayList();
        Console.WriteLine("SERVER:> Controlador de delivery iniciado!");
        this.DeliveryReadyOrders(TimeSpan.FromSeconds(TimeToCheck));
    }

    public void AddOrder(Item item, int quantity)
    {
        OrdersList.Add(new Order(item, quantity));
        Console.WriteLine($"SERVER:> {quantity} * {item.Name} adicionados");
    }

    async Task DeliveryReadyOrders(TimeSpan timeSpan)
    {
        var periodicTimer = new PeriodicTimer(timeSpan);
        while (await periodicTimer.WaitForNextTickAsync())
        {
            foreach (Order order in OrdersList)
            {
                if (order.IsReady && !order.IsSend)
                {
                    order.ChangeStatusSendOrder();
                    Console.WriteLine($"SERVER:> O pedido de {order.Quantity} {order.OrderItem.Name} no valor de {order.OrderPrice} Reais foi enviado!");
                }
                else
                {
                    Console.WriteLine("SERVER:> Nenhum pedido está pronto para enviar!");
                }
            }
        }
    }

}
