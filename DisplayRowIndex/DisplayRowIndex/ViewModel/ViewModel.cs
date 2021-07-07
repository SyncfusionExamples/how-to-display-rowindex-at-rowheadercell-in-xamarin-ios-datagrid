using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;


namespace DisplayRowIndex
{
    
    public class ViewModel
    {
        OrderInfoRepository repository;
        public ObservableCollection<OrderInfo> OrdersInfo { get; set; }        
        public ViewModel()
        {
            OrdersInfo = new ObservableCollection<OrderInfo>();
            repository = new OrderInfoRepository();
            PopulateItems();
        }
        private void PopulateItems()
        {
           OrdersInfo= repository.GenerateItems();
        }
    }
}