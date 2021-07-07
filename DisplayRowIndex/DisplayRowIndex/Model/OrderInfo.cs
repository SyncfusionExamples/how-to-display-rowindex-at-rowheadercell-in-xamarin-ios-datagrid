using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DisplayRowIndex
{
    public class OrderInfo
    {
        public int OrderID { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int CustomerID { get; set; }
        public string ShipCountry { get; set; }

        public OrderInfo()
        {

        }

        public OrderInfo(int orderID,int employeeID,string employeeName,int customerID,string shipCountry)
        {
            OrderID = orderID;
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            CustomerID = customerID;
            ShipCountry = shipCountry;
        }        

    }
}