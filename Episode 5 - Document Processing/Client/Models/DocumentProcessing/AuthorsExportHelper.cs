using Telerik.Documents.SpreadsheetStreaming;

namespace BookStores.Client.Models.DocumentProcessing
{
    public class AuthorsExportHelper
    {

        // private static readonly int HeaderRowHeight = 22;
        // private static readonly int RowHeight = 18;
        // private static readonly string[] ColumnHeaders = { "ID", "DATE", "TIME", "CLIENT", "COMPANY", "SHIPPING", "DISCOUNT", "STATUS" };
        // private static readonly double[] ColumnWidths = { 9.43, 12.29, 10.71, 15.43, 21.71, 14.29, 13.57, 11.29 };

        public int HeaderRowHeight { get; set; }

        public string[] ColumnHeaders { get; set; }

        public double[] ColumnWidths { get; set; }

        public AuthorsExportHelper(int headerRowHeight, string[] columnHeaders, double[] columnWidths)
        {
            this.HeaderRowHeight = headerRowHeight;
            this.ColumnHeaders = columnHeaders;
            this.ColumnWidths = columnWidths;
        }

        #region Columns Export Methods

        public void ExportIdColumn(IRowExporter rowExporter, DocumentRow row, SpreadCellFormat normalFormat)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                // this.UpdateProgess();
                cellExporter.SetValue(row.Id);
                cellExporter.SetFormat(normalFormat);
            }
        }

        public void ExportDateColumn(IRowExporter rowExporter, DocumentRow row)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                SpreadCellFormat dateFormat = new SpreadCellFormat();
                dateFormat.FontSize = 10;
                dateFormat.VerticalAlignment = SpreadVerticalAlignment.Center;
                dateFormat.HorizontalAlignment = SpreadHorizontalAlignment.Center;
                dateFormat.NumberFormat = "m/d/yyyy";

                // this.UpdateProgess();
                cellExporter.SetValue(row.Date);
                cellExporter.SetFormat(dateFormat);
            }
        }

        public void ExportTimeColumn(IRowExporter rowExporter, DocumentRow row)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                SpreadCellFormat timeFormat = new SpreadCellFormat();
                timeFormat.FontSize = 10;
                timeFormat.VerticalAlignment = SpreadVerticalAlignment.Center;
                timeFormat.HorizontalAlignment = SpreadHorizontalAlignment.Center;
                timeFormat.NumberFormat = "h:mm;@";

                // this.UpdateProgess();
                cellExporter.SetValue(row.Time);
                cellExporter.SetFormat(timeFormat);
            }
        }

        public void ExportClientColumn(IRowExporter rowExporter, DocumentRow row, SpreadCellFormat normalFormat)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                // this.UpdateProgess();
                cellExporter.SetValue(row.Client);
                cellExporter.SetFormat(normalFormat);
            }
        }

        public void ExportCompanyColumn(IRowExporter rowExporter, DocumentRow row, SpreadCellFormat normalFormat)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                // this.UpdateProgess();
                cellExporter.SetValue(row.Company);
                cellExporter.SetFormat(normalFormat);
            }
        }

        public void ExportShippingColumn(IRowExporter rowExporter, DocumentRow row)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                SpreadCellFormat expressFormat = new SpreadCellFormat();
                expressFormat.FontSize = 10;
                expressFormat.VerticalAlignment = SpreadVerticalAlignment.Center;
                expressFormat.HorizontalAlignment = SpreadHorizontalAlignment.Center;

                if (row.Shipping == Shipping.Express)
                {
                    expressFormat.IsBold = true;
                    expressFormat.ForeColor = new SpreadThemableColor(new SpreadColor(192, 0, 0));
                }

                string shipping = string.Empty;
                switch (row.Shipping)
                {
                    case Shipping.Express:
                        shipping = "express";
                        break;
                    case Shipping.OneDay:
                        shipping = "1 day";
                        break;
                    case Shipping.TwoDays:
                        shipping = "2 days";
                        break;
                    case Shipping.Regular:
                        shipping = "regular";
                        break;
                }

                // this.UpdateProgess();
                cellExporter.SetValue(shipping);
                cellExporter.SetFormat(expressFormat);
            }
        }

        public void ExportDiscountColumn(IRowExporter rowExporter, DocumentRow row)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                SpreadCellFormat percentFormat = new SpreadCellFormat();
                percentFormat.FontSize = 10;
                percentFormat.VerticalAlignment = SpreadVerticalAlignment.Center;
                percentFormat.HorizontalAlignment = SpreadHorizontalAlignment.Center;
                percentFormat.NumberFormat = "0%";

                // this.UpdateProgess();
                cellExporter.SetValue(row.Discount);
                cellExporter.SetFormat(percentFormat);
            }
        }

        public void ExportStatusColumn(IRowExporter rowExporter, DocumentRow row)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                SpreadColor color = null;
                switch (row.Shipping)
                {
                    case Shipping.Express:
                        color = new SpreadColor(242, 116, 33);
                        break;
                    case Shipping.OneDay:
                        color = new SpreadColor(255, 192, 0);
                        break;
                    case Shipping.TwoDays:
                        color = new SpreadColor(142, 188, 0);
                        break;
                    case Shipping.Regular:
                        color = new SpreadColor(27, 157, 222);
                        break;
                }

                SpreadCellFormat statusFormat = new SpreadCellFormat();
                statusFormat.Fill = SpreadPatternFill.CreateSolidFill(color);
                SpreadBorder border = new SpreadBorder(SpreadBorderStyle.Thin, new SpreadThemableColor(new SpreadColor(255, 255, 255)));
                statusFormat.LeftBorder = border;
                statusFormat.TopBorder = border;
                statusFormat.RightBorder = border;
                statusFormat.BottomBorder = border;

                // this.UpdateProgess();
                cellExporter.SetFormat(statusFormat);
            }
        }

        #endregion

        public void ExportHeaderRows(IWorksheetExporter worksheetExporter)
        {
            using (IRowExporter rowExporter = worksheetExporter.CreateRowExporter())
            {
                rowExporter.SetHeightInPoints(HeaderRowHeight);

                using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
                {
                    SpreadCellFormat format = new SpreadCellFormat();
                    format.FontFamily = new SpreadThemableFontFamily("Segoe UI");
                    format.FontSize = 16;
                    format.Fill = SpreadPatternFill.CreateSolidFill(new SpreadColor(51, 153, 51));
                    format.ForeColor = new SpreadThemableColor(new SpreadColor(255, 255, 255));
                    format.HorizontalAlignment = SpreadHorizontalAlignment.Left;
                    format.VerticalAlignment = SpreadVerticalAlignment.Center;

                    cellExporter.SetFormat(format);
                    cellExporter.SetValue("ORDERS LOG");
                }
            }

            using (IRowExporter rowExporter = worksheetExporter.CreateRowExporter())
            {
                rowExporter.SetHeightInPoints(HeaderRowHeight);

                using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
                {
                    SpreadCellFormat format = new SpreadCellFormat();
                    format.FontFamily = new SpreadThemableFontFamily("Segoe UI");
                    format.FontSize = 14;
                    format.HorizontalAlignment = SpreadHorizontalAlignment.Left;
                    format.VerticalAlignment = SpreadVerticalAlignment.Center;

                    cellExporter.SetFormat(format);
                    cellExporter.SetValue("REPORT");
                }

                rowExporter.SkipCells(5);

                using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
                {
                    SpreadCellFormat format = new SpreadCellFormat();
                    format.FontFamily = new SpreadThemableFontFamily("Segoe UI");
                    format.FontSize = 14;
                    format.NumberFormat = "[$-409]mmm-yy;@";
                    format.HorizontalAlignment = SpreadHorizontalAlignment.Center;
                    format.VerticalAlignment = SpreadVerticalAlignment.Center;

                    cellExporter.SetFormat(format);
                    cellExporter.SetFormula("=TODAY()");
                }
            }

            using (IRowExporter rowExporter = worksheetExporter.CreateRowExporter())
            {
                rowExporter.SetHeightInPoints(HeaderRowHeight);

                SpreadCellFormat format = new SpreadCellFormat();
                format.IsBold = true;
                format.Fill = SpreadPatternFill.CreateSolidFill(new SpreadColor(142, 196, 65));
                format.ForeColor = new SpreadThemableColor(new SpreadColor(255, 255, 255));
                format.HorizontalAlignment = SpreadHorizontalAlignment.Center;
                format.VerticalAlignment = SpreadVerticalAlignment.Center;

                for (int i = 0; i < ColumnHeaders.Length; i++)
                {
                    using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
                    {
                        cellExporter.SetFormat(format);
                        cellExporter.SetValue(ColumnHeaders[i]);
                    }
                }
            }
        }
    }
}