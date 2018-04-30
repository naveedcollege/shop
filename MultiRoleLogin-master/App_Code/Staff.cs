using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Staff
/// </summary>
public class Staff : User
{
    private string staffRole;

    public Staff():base()
    {

    }

    public Staff(int userId, string username, string email, string firstName, string lastName, string password):base(userId, username, email, firstName, lastName, password)
    {

    }


    public string StaffRole
    {
        get
        {
            return staffRole;
        }

        set
        {
            staffRole = value;
        }
    }
}