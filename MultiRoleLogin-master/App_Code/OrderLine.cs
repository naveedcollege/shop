using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderLine
/// </summary>
public class OrderLine
{
    private int orderlineId;
    private int orderId;
    private Product selectedProduct;
    private int quantity;

    public int OrderlineId
    {
        get
        {
            return orderlineId;
        }

        set
        {
            orderlineId = value;
        }
    }

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

    public Product SelectedProduct
    {
        get
        {
            return selectedProduct;
        }

        set
        {
            selectedProduct = value;
        }
    }

    public int Quantity
    {
        get
        {
            return quantity;
        }

        set
        {
            quantity = value;
        }
    }

    public OrderLine()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public OrderLine(int orderlineId, int orderId, Product selectedProduct, int quantity)
    {
        this.OrderlineId = orderlineId;
        this.OrderId = orderId;
        this.SelectedProduct = selectedProduct;
        this.Quantity = quantity;
    }
}