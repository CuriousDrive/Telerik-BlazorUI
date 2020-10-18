using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.Documents.SpreadsheetStreaming;

namespace BookStores.Client.Models.DocumentProcessing
{
    public class DocumentSettings
    {
        private int exportedCellsCount;
        private double exportTime;
        private SpreadDocumentFormat selectedDocumentFormat;
        private int totalCellsCount;

        public SpreadDocumentFormat SelectedDocumentFormat
        {
            get
            {
                return this.selectedDocumentFormat;
            }

            set
            {
                if (this.selectedDocumentFormat != value)
                {
                    this.selectedDocumentFormat = value;
                }
            }
        }

        public IEnumerable<SpreadDocumentFormat> ExportFormats
        {
            get
            {
                return Enum.GetValues(typeof(SpreadDocumentFormat)).Cast<SpreadDocumentFormat>();
            }
        }

        public int ExportedCellsCount
        {
            get
            {
                return this.exportedCellsCount;
            }

            set
            {
                if (this.exportedCellsCount != value)
                {
                    this.exportedCellsCount = value;
                }
            }
        }

        public int TotalCellsCount
        {
            get
            {
                return this.totalCellsCount;
            }

            set
            {
                if (this.totalCellsCount != value)
                {
                    this.totalCellsCount = value;
                }
            }
        }

        public double ExportTime
        {
            get
            {
                return this.exportTime;
            }

            set
            {
                if (this.exportTime != value)
                {
                    this.exportTime = value;
                }
            }
        }
    }
}