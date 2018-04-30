Using System;
Using System.Collections.Generic;
Using System.Linq;
Using System.Web;

/// <summary>
/// Summary description for OrderLine
/// </summary>
Public Class OrderLine
{
    Private int orderlineId;
    Private int orderId;
    Private Product selectedProduct;
    Private int quantity;

    Public int OrderlineId
    {
        Get
        {
            Return orderlineId;
        }

        Set
        {
            orderlineId = value;
        }
    }

    Public int OrderId
    {
        Get
        {
            Return orderId;
        }

        Set
        {
            orderId = value;
        }
    }

    Public Product SelectedProduct
    {
        Get
        {
            Return selectedProduct;
        }

        Set
        {
            selectedProduct = value;
        }
    }

    Public int Quantity
    {
        Get
        {
            Return quantity;
        }

        Set
        {
            quantity = value;
        }
    }

    Public OrderLine()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    Public OrderLine(int orderlineId, int orderId, Product selectedProduct, int quantity)
    {
        this.OrderlineId = orderlineId;
        this.OrderId = orderId;
        this.SelectedProduct = selectedProduct;
        this.Quantity = quantity;
    }
}