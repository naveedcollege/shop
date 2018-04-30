using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

/// <summary>
/// Summary description for DAL
/// </summary>
public class DAL
{
    private string conStr;
    private SqlConnection con;

    private Dictionary<string, Staff> allStaff;
    private Dictionary<string, Customer> customers;

    public Dictionary<string, Staff> AllStaff
    {
        get
        {
            return allStaff;
        }

        set
        {
            allStaff = value;
        }
    }

    public Dictionary<string, Customer> Customers
    {
        get
        {
            return customers;
        }

        set
        {
            customers = value;
        }
    }

    public DAL()
    {
        // Create and initiate the connection to the database

        conStr = ConfigurationManager.ConnectionStrings["UserDBConnectionString1"].ConnectionString;
        con = new SqlConnection(conStr);

        AllStaff = new Dictionary<string, Staff>();
        Customers = new Dictionary<string, Customer>();
    }

    public DataTable getAllUserData() {

        // Retrieve all of the users from the database and store them in a datatable.
        
        string myQuery = "SELECT * FROM Users";
        var myCommand = new SqlCommand(myQuery, con);
        SqlDataReader myResults;
        DataTable myDataTable = new DataTable();

       // Try to load the results into the datatable if the connection is open.
        try
        {
            con.Open();
            myResults = myCommand.ExecuteReader();

            if (myResults.HasRows == true)
            {
                myDataTable.Load(myResults);
            }

            return myDataTable;
        }

        // Catch the exception if there is an error.
        catch (Exception e)
        {
            return myDataTable;
        }

       // Close the connection once all the users have been loaded into the datatable and dispose of the command.
        finally
        {
            con.Close();
            myCommand.Dispose();
        }

    }

    public void loadUserdata() {
        DataTable UsersTable;

        UsersTable = this.getAllUserData();

        for (int i = 0; i <= UsersTable.Rows.Count - 1; i++)
        {
            string username = Convert.ToString(UsersTable.Rows[i][1]);
            string password = Convert.ToString(UsersTable.Rows[i][2]);
            string firstname = Convert.ToString(UsersTable.Rows[i][3]);
            string lastname = Convert.ToString(UsersTable.Rows[i][4]);
            string email = Convert.ToString(UsersTable.Rows[i][5]);
            string role = Convert.ToString(UsersTable.Rows[i][6]);
           
                 if (role.Equals("C"))
            {
                // Create a new customer
                Customer cstmr = new Customer(1, username, email, firstname, lastname, password);

                // Add the newly created customer to the dictionary.
                Customers.Add(username, cstmr);
             
            }

                  else if (role.Equals( "M"))
            {
                // Create a new instance of Staff.
                Staff stf = new Staff(1, username, email, firstname, lastname, password);

                // Add the newly created Staff to the dictionary.
                AllStaff.Add(username, stf);

                
            }
        }
    }

    public string retrieveStaffRole(string username)
    {
        string sql = "select * from StaffRoles where username=@username";
        string role = "";

        // Try to open the connection and run the query to check the user's staff role.
        try
        {
            con.Open();
            SqlCommand com = new SqlCommand(sql,con);

           
            com.Parameters.AddWithValue("@username", username);
        
            // Read the user's staff role and store it in a variable.
            SqlDataReader rdr = com.ExecuteReader();
            if (rdr.Read())
            {
                role = rdr["role"].ToString();
            }
        }
        
        // Catch the exception if the attempt to open the database or run the query fails.
        catch (Exception e)
        {
            String error = e.Message;
           
        } finally
        {
            // Close the connection.
            con.Close();
           
        }

        return "";

    }

    public Customer checkCustomerLogin(string username, string password)
    {
        // Check the username exists as a key in the dictionary.
        if (customers.ContainsKey(username)== true)
        {
            // Get the value of the user from the dictionary and store it in variable c
            Customer c = customers[username];

            // If the password the user enters matches, return the user object.
            if (c.Password.Equals(password))
            {
                return c;
            }
        }

        return null;
     }
    

    public Staff checkStaffLogin(string username, string password)
    {
        // Check the username exists as a key in the dictionary.
        if (customers.ContainsKey(username) == true)
        {
            // Get the value of the user from the dictionary and store it in variable c
            Staff s = allStaff[username];

            if (s.StaffRole == "M")
            {
                // If the password the user enters matches, return the user object.
                if (s.Password.Equals(password))
             {
                   return s;
             }
            }

            
        }

        return null;
    }


}