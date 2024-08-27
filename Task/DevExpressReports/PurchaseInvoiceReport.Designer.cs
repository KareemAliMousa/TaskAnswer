namespace TaskAnswer.DevExpressReports
{
    partial class PurchaseInvoiceReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.invoiceTable = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.Product = new DevExpress.XtraReports.UI.XRTableCell();
            this.Price = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.CustomerName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.DateOfRegistration = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.Code = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.Id = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.invoiceTable});
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // invoiceTable
            // 
            this.invoiceTable.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.invoiceTable.BorderWidth = 1F;
            this.invoiceTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.invoiceTable.Name = "invoiceTable";
            this.invoiceTable.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.invoiceTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.invoiceTable.SizeF = new System.Drawing.SizeF(650F, 30.41668F);
            this.invoiceTable.StylePriority.UseBorders = false;
            this.invoiceTable.StylePriority.UseBorderWidth = false;
            this.invoiceTable.StylePriority.UseTextAlignment = false;
            this.invoiceTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Product,
            this.Price});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // Product
            // 
            this.Product.BackColor = System.Drawing.Color.Transparent;
            this.Product.Font = new DevExpress.Drawing.DXFont("Arial", 14F);
            this.Product.ForeColor = System.Drawing.Color.Black;
            this.Product.Multiline = true;
            this.Product.Name = "Product";
            this.Product.StylePriority.UseBackColor = false;
            this.Product.StylePriority.UseFont = false;
            this.Product.StylePriority.UseForeColor = false;
            this.Product.StylePriority.UseTextAlignment = false;
            this.Product.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.Product.Weight = 2.9833810930759257D;
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.Color.Transparent;
            this.Price.Font = new DevExpress.Drawing.DXFont("Arial", 14F);
            this.Price.ForeColor = System.Drawing.Color.Black;
            this.Price.Multiline = true;
            this.Price.Name = "Price";
            this.Price.StylePriority.UseBackColor = false;
            this.Price.StylePriority.UseFont = false;
            this.Price.StylePriority.UseForeColor = false;
            this.Price.StylePriority.UseTextAlignment = false;
            this.Price.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.Price.Weight = 2.9416071978952609D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 60.83333F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.CustomerName,
            this.xrLabel7,
            this.DateOfRegistration,
            this.xrLabel5,
            this.Code,
            this.xrLabel3,
            this.xrLabel2,
            this.Id});
            this.PageHeader.HeightF = 188.3333F;
            this.PageHeader.Name = "PageHeader";
            // 
            // CustomerName
            // 
            this.CustomerName.BackColor = System.Drawing.Color.Transparent;
            this.CustomerName.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.CustomerName.Font = new DevExpress.Drawing.DXFont("Arial", 12F);
            this.CustomerName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CustomerName.LocationFloat = new DevExpress.Utils.PointFloat(196.6666F, 130.5416F);
            this.CustomerName.Multiline = true;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.CustomerName.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.CustomerName.SizeF = new System.Drawing.SizeF(194.7915F, 29.45838F);
            this.CustomerName.StylePriority.UseBackColor = false;
            this.CustomerName.StylePriority.UseBorders = false;
            this.CustomerName.StylePriority.UseFont = false;
            this.CustomerName.StylePriority.UseForeColor = false;
            this.CustomerName.StylePriority.UsePadding = false;
            this.CustomerName.StylePriority.UseTextAlignment = false;
            this.CustomerName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Arial", 12F);
            this.xrLabel7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(10F, 130.5416F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.xrLabel7.SizeF = new System.Drawing.SizeF(172.4999F, 29.45839F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Customer Name";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DateOfRegistration
            // 
            this.DateOfRegistration.BackColor = System.Drawing.Color.Transparent;
            this.DateOfRegistration.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.DateOfRegistration.Font = new DevExpress.Drawing.DXFont("Arial", 12F);
            this.DateOfRegistration.ForeColor = System.Drawing.SystemColors.Desktop;
            this.DateOfRegistration.LocationFloat = new DevExpress.Utils.PointFloat(196.6666F, 91.41678F);
            this.DateOfRegistration.Multiline = true;
            this.DateOfRegistration.Name = "DateOfRegistration";
            this.DateOfRegistration.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.DateOfRegistration.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.DateOfRegistration.SizeF = new System.Drawing.SizeF(194.7915F, 29.45838F);
            this.DateOfRegistration.StylePriority.UseBackColor = false;
            this.DateOfRegistration.StylePriority.UseBorders = false;
            this.DateOfRegistration.StylePriority.UseFont = false;
            this.DateOfRegistration.StylePriority.UseForeColor = false;
            this.DateOfRegistration.StylePriority.UsePadding = false;
            this.DateOfRegistration.StylePriority.UseTextAlignment = false;
            this.DateOfRegistration.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Arial", 12F);
            this.xrLabel5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(10F, 91.41678F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.xrLabel5.SizeF = new System.Drawing.SizeF(172.4999F, 29.45837F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Date Of Registration";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // Code
            // 
            this.Code.BackColor = System.Drawing.Color.Transparent;
            this.Code.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Code.Font = new DevExpress.Drawing.DXFont("Arial", 12F);
            this.Code.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Code.LocationFloat = new DevExpress.Utils.PointFloat(119.9999F, 51.12506F);
            this.Code.Multiline = true;
            this.Code.Name = "Code";
            this.Code.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.Code.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.Code.SizeF = new System.Drawing.SizeF(194.7915F, 29.45839F);
            this.Code.StylePriority.UseBackColor = false;
            this.Code.StylePriority.UseBorders = false;
            this.Code.StylePriority.UseFont = false;
            this.Code.StylePriority.UseForeColor = false;
            this.Code.StylePriority.UsePadding = false;
            this.Code.StylePriority.UseTextAlignment = false;
            this.Code.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Arial", 12F);
            this.xrLabel3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(10F, 51.12506F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.xrLabel3.SizeF = new System.Drawing.SizeF(74.99988F, 29.45839F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Code";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Arial", 12F);
            this.xrLabel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(10F, 10F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.xrLabel2.SizeF = new System.Drawing.SizeF(74.99988F, 29.45838F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Id";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // Id
            // 
            this.Id.BackColor = System.Drawing.Color.Transparent;
            this.Id.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Id.Font = new DevExpress.Drawing.DXFont("Arial", 12F);
            this.Id.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Id.LocationFloat = new DevExpress.Utils.PointFloat(119.9999F, 10F);
            this.Id.Multiline = true;
            this.Id.Name = "Id";
            this.Id.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.Id.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.Id.SizeF = new System.Drawing.SizeF(194.7915F, 29.45838F);
            this.Id.StylePriority.UseBackColor = false;
            this.Id.StylePriority.UseBorders = false;
            this.Id.StylePriority.UseFont = false;
            this.Id.StylePriority.UseForeColor = false;
            this.Id.StylePriority.UsePadding = false;
            this.Id.StylePriority.UseTextAlignment = false;
            this.Id.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.GroupHeader1.HeightF = 30.41668F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.BorderWidth = 1F;
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(650F, 30.41668F);
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseBorderWidth = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell1.Font = new DevExpress.Drawing.DXFont("Arial", 14F);
            this.xrTableCell1.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseBackColor = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseForeColor = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "Product";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.Weight = 2.9833810930759257D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell2.Font = new DevExpress.Drawing.DXFont("Arial", 14F);
            this.xrTableCell2.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseBackColor = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseForeColor = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "Price";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell2.Weight = 2.9416071978952609D;
            // 
            // PurchaseInvoiceReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.GroupHeader1});
            this.Margins = new DevExpress.Drawing.DXMargins(100F, 100F, 60.83333F, 100F);
            this.Version = "22.2";
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel CustomerName;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel DateOfRegistration;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel Code;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel Id;
        private DevExpress.XtraReports.UI.XRTable invoiceTable;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell Product;
        private DevExpress.XtraReports.UI.XRTableCell Price;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
    }
}
