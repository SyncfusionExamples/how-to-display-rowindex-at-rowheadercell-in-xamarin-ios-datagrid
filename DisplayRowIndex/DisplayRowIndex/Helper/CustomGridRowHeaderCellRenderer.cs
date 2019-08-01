using Syncfusion.SfDataGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;

namespace DisplayRowIndex
{
    public class CustomGridRowHeaderCellRenderer : GridRowHeaderCellRenderer
    {
        public CustomGridRowHeaderCellRenderer()
        {

        }

        protected override GridRowHeaderCell OnCreateDisplayUIView()
        {
            GridRowHeaderCell rowHeaderCell = new GridRowHeaderCell();
            UILabel rowHeader = new UILabel();
            rowHeader.TextColor = UIColor.Black;
            rowHeader.TextAlignment = UITextAlignment.Center;
            rowHeaderCell.AddSubview(rowHeader);
            rowHeader.Frame = new CoreGraphics.CGRect(0, 0, this.DataGrid.RowHeaderWidth, this.DataGrid.RowHeight);
            return rowHeaderCell;
        }

        public override void OnInitializeDisplayView(DataColumnBase dataColumn, GridRowHeaderCell view)
        {
            UILabel rowHeader = (UILabel)view.Subviews[0];

            // Setting "Index" as text for the RowHeader column in header row
            if (dataColumn.RowIndex == 0)
            {
                rowHeader.Text = "Index";
            }
            // Setting the RowIndex as text for the RowHeader
            else
            {
                rowHeader.Text = dataColumn.RowIndex.ToString();
            }
            base.OnInitializeDisplayView(dataColumn, view);
        }

        public override void OnUpdateDisplayValue(DataColumnBase dataColumn, GridRowHeaderCell view)
        {
            UILabel rowHeader = (UILabel)view.Subviews[0];

            // RowHeader's text is updated when the datagrid is scrolled
            rowHeader.Text = dataColumn.RowIndex.ToString();

            base.OnUpdateDisplayValue(dataColumn, view);
        }

    }
}