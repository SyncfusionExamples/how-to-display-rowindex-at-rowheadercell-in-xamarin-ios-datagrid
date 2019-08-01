using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Syncfusion.SfDataGrid;
using Syncfusion.GridCommon.ScrollAxis;

namespace DisplayRowIndex
{
    public class MyViewController : UIViewController
    {
        private SfDataGrid dataGrid;
        private ViewModel viewModel;
        public MyViewController()
        {
            dataGrid = new SfDataGrid();
            viewModel = new ViewModel();
            dataGrid.ItemsSource = viewModel.OrdersInfo;
            dataGrid.ShowRowHeader = true;
            dataGrid.RowHeaderWidth = 50;
            dataGrid.CellRenderers.Remove("RowHeader");
            dataGrid.CellRenderers.Add("RowHeader", new CustomGridRowHeaderCellRenderer());
            View.AddSubview(dataGrid);
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
            dataGrid.Frame = new CoreGraphics.CGRect(0, 0, View.Frame.Width, View.Frame.Height);
        }
    }
     
}