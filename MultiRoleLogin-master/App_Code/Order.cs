using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Order
/// </summary>
public class Order
{
    private int orderId;
    private List<OrderLine> orderLines;
    private DateTime orderDate;
    private int customerId;

    public int OrderId
    {
        get
        {
            return orderId;
        }

        set
        {
            orderId = value;
        }
    }

    public List<OrderLine> OrderLines
    {
        get
        {
            return orderLines;
        }

        set
        {
            orderLines = value;
        }
    }

    public DateTime OrderDate
    {
        get
        {
            return orderDate;
        }

        set
        {
            orderDate = value;
        }
    }

    public int CustomerId
    {
        get
        {
            return customerId;
        }

        set
        {
            customerId = value;
        }
    }

    public Order()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Order(int orderId, List<OrderLine> orderLines, DateTime orderDate, int customerId)
    {
        this.orderId = orderId;
        this.orderLines = orderLines;
        this.orderDate = orderDate;
        this.customerId = customerId;
    }
}