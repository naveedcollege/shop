using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Product
/// </summary>
public class Product
{
    private int productId;
    private string productName;
    private int productDescription;
    private int productLevel;
    private decimal productCost;

    public int ProductId
    {
        get
        {
            return productId;
        }

        set
        {
            productId = value;
        }
    }

    public string ProductName
    {
        get
        {
            return productName;
        }

        set
        {
            productName = value;
        }
    }

    public int ProductDescription
    {
        get
        {
            return productDescription;
        }

        set
        {
            productDescription = value;
        }
    }

    public int ProductLevel
    {
        get
        {
            return productLevel;
        }

        set
        {
            productLevel = value;
        }
    }

    public decimal ProductCost
    {
        get
        {
            return productCost;
        }

        set
        {
            productCost = value;
        }
    }

    public Product()
    {
        //
        // TODO: Add constructor logic here
        //

    }

    public Product(int productId, string productName, int productDescription, int productLevel, decimal productCost)
    {
        this.productId = productId;
        this.productName = productName;
        this.productDescription = productDescription;
        this.productLevel = productLevel;
        this.productCost = productCost;
    }

    public override string ToString()
    {
        return productName;
    }
}