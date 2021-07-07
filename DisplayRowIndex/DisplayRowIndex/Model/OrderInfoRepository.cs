using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;


namespace DisplayRowIndex
{
    public class OrderInfoRepository
    {
        Random random;
        public OrderInfoRepository()
        {
            random = new Random();
        }
        
        public ObservableCollection<OrderInfo> GenerateItems()
        {
            ObservableCollection<OrderInfo> orderDetails = new ObservableCollection<OrderInfo>();
            for(int i=1000;i<1050;i++)
            {
                OrderInfo orderinfo = new OrderInfo();
                orderinfo.OrderID = i;
                orderinfo.CustomerID = random.Next(500);
                orderinfo.EmployeeID = random.Next(500, 600);
                orderinfo.EmployeeName = EmployeeNames[random.Next(15)];
                orderinfo.ShipCountry = ShipCountries[random.Next(10)];
                orderDetails.Add(orderinfo);
            }
            return orderDetails;
        }

        string[] EmployeeNames = new string[]
        {
            "Krish",
            "Arjun",
            "Parthiban",
            "Dhananjeyan",
            "Kesav",
            "Sarathy",
            "Yuvaraj",
            "Madhavan",
            "SriRam",
            "Kannan",
            "Yeshwanth",
            "Sona",
            "Subathra",
            "Vishali",
            "Rukmani",
            "Anusha",
            "Devika"
        };

        string[] ShipCountries = new string[]
        {
            "Sweden",
            "Denmark",
            "Canada",
            "UK",
            "Brazil",
            "Germany",
            "France",
            "Spain",
            "UK",
            "Mexico"
        };
    }
}