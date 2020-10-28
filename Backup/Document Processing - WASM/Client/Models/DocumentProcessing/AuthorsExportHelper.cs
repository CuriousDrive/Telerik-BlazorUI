using BookStores.Models;
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

        public void ExportTitleColumn(IRowExporter rowExporter, Author author, SpreadCellFormat normalFormat)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                // this.UpdateProgess();
                cellExporter.SetValue(author.FirstName + " " + author.LastName);
                cellExporter.SetFormat(normalFormat);
            }
        }

        public void ExportDateOfBirthColumn(IRowExporter rowExporter, Author author)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                SpreadCellFormat dateFormat = new SpreadCellFormat();
                dateFormat.FontSize = 10;
                dateFormat.VerticalAlignment = SpreadVerticalAlignment.Center;
                dateFormat.HorizontalAlignment = SpreadHorizontalAlignment.Center;
                dateFormat.NumberFormat = "m/d/yyyy";

                // this.UpdateProgess();
                cellExporter.SetValue(author.DateOfBirth);
                cellExporter.SetFormat(dateFormat);
            }
        }

        public void ExportEmailAddressColumn(IRowExporter rowExporter, Author author, SpreadCellFormat normalFormat)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                // this.UpdateProgess();
                cellExporter.SetValue(author.EmailAddress);
                cellExporter.SetFormat(normalFormat);
            }
        }

        public void ExportSalaryColumn(IRowExporter rowExporter, Author author)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                //($* #,##0.00);($* (#,##0.00);($* \" - \"??);(@_)

                SpreadCellFormat currencyFormat = new SpreadCellFormat();
                currencyFormat.FontSize = 10;
                currencyFormat.VerticalAlignment = SpreadVerticalAlignment.Center;
                currencyFormat.HorizontalAlignment = SpreadHorizontalAlignment.Center;
                currencyFormat.NumberFormat = "_($ #,##0.00_);_($ (#,##0.00);_(@_)";

                // this.UpdateProgess();
                cellExporter.SetValue(author.Salary.ToString());
                cellExporter.SetFormat(currencyFormat);
            }
        }

        public void ExportPhoneColumn(IRowExporter rowExporter, Author author, SpreadCellFormat normalFormat)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                // this.UpdateProgess();
                cellExporter.SetValue(author.Phone);
                cellExporter.SetFormat(normalFormat);
            }
        }


        public void ExportStatusColumn(IRowExporter rowExporter, Author author)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                SpreadColor color = null;
               
                if(author.Salary > 100)
                    color = new SpreadColor(242, 116, 33);
                if (author.Salary > 1000)
                    color = new SpreadColor(255, 192, 0);
                if (author.Salary > 10000)
                    color = new SpreadColor(142, 188, 0);
                if (author.Salary > 100000)
                    color = new SpreadColor(27, 157, 222);

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
                    cellExporter.SetValue("List of Authors");
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