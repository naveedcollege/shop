using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Inherits from the user class
/// </summary>
public class Customer : User
{
    private string membershipType;
    private Dictionary<int, Order> orders;

    public Customer():base()
    {
        this.membershipType = "standard";
        this.orders = new Dictionary<int, Order>();
    }

    public Customer(int userId, string username, string email, string firstName, string lastName, string password) : base(userId, username, email, firstName, lastName, password) {
        this.membershipType = "standard";
        this.orders = new Dictionary<int, Order>();

    }

    public string MembershipType
    {
        get
        {
            return membershipType;
        }

        set
        {
            membershipType = value;
        }
    }

    public Dictionary<int, Order> Orders
    {
        get
        {
            return orders;
        }

        set
        {
            orders = value;
        }
    }
}