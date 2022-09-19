using System;
using System.Threading;

namespace delivery_server;

public class Order
{
    public Item OrderItem { get; set; }
    public int Quantity { get; set; }
    public double OrderPrice { get; }
    public bool IsReady { get; set; }
    public bool IsSend { get; set; }

    public Order(Item orderItem, int quantity)
    {
        OrderItem = orderItem;
        Quantity = quantity;
        OrderPrice = OrderItem.Price * quantity;
        IsReady = false;
        IsSend = false;

        Task.Run(() => this.Process());
    }

    public void Process()
    {
        Task.Run(() => Thread.Sleep(OrderItem.TimeToPrepare * Quantity));
        IsReady = true;
    }

    public void ChangeStatusSendOrder()
    {
        IsSend = true;
    }
}
