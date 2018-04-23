Namespace ExtendedDrillThroughReport
	Partial Public Class OrderDetailsReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.nwindDataSet1 = New ExtendedDrillThroughReport.nwindDataSet()
			Me.categoriesTableAdapter = New ExtendedDrillThroughReport.nwindDataSetTableAdapters.CategoriesTableAdapter()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.order_DetailsTableAdapter1 = New ExtendedDrillThroughReport.nwindDataSetTableAdapters.Order_DetailsTableAdapter()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.ProductID = New DevExpress.XtraReports.Parameters.Parameter()
			Me.ProductName = New DevExpress.XtraReports.Parameters.Parameter()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
			DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.Detail.Dpi = 100F
			Me.Detail.HeightF = 25F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.Dpi = 100F
			Me.TopMargin.HeightF = 100F
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Dpi = 100F
			Me.BottomMargin.HeightF = 100F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.EnforceConstraints = False
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' PageHeader
			' 
			Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1, Me.xrLabel2, Me.xrTable2})
			Me.PageHeader.Dpi = 100F
			Me.PageHeader.HeightF = 72.91667F
			Me.PageHeader.Name = "PageHeader"
			' 
			' order_DetailsTableAdapter1
			' 
			Me.order_DetailsTableAdapter1.ClearBeforeFill = True
			' 
			' xrTable1
			' 
			Me.xrTable1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTable1.Dpi = 100F
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(650F, 25F)
			Me.xrTable1.StylePriority.UseBorders = False
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell9, Me.xrTableCell2, Me.xrTableCell3})
			Me.xrTableRow1.Dpi = 100F
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 11.5R
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Order Details.OrderID")})
			Me.xrTableCell1.Dpi = 100F
			Me.xrTableCell1.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Underline)
			Me.xrTableCell1.ForeColor = System.Drawing.Color.DodgerBlue
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F)
			Me.xrTableCell1.StylePriority.UseFont = False
			Me.xrTableCell1.StylePriority.UseForeColor = False
			Me.xrTableCell1.StylePriority.UsePadding = False
			Me.xrTableCell1.StylePriority.UseTextAlignment = False
			Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCell1.Weight = 0.39999999503206463R
'			Me.xrTableCell1.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.xrTableCell1_BeforePrint)
'			Me.xrTableCell1.PreviewMouseMove += New DevExpress.XtraReports.UI.PreviewMouseEventHandler(Me.xrTableCell1_PreviewMouseMove)
'			Me.xrTableCell1.PreviewClick += New DevExpress.XtraReports.UI.PreviewMouseEventHandler(Me.xrTableCell1_PreviewClick)
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Order Details.Quantity")})
			Me.xrTableCell2.Dpi = 100F
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F)
			Me.xrTableCell2.StylePriority.UsePadding = False
			Me.xrTableCell2.StylePriority.UseTextAlignment = False
			Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell2.Weight = 0.40000000247983658R
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Order Details.Discount", "{0:$0.00}")})
			Me.xrTableCell3.Dpi = 100F
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F)
			Me.xrTableCell3.StylePriority.UsePadding = False
			Me.xrTableCell3.StylePriority.UseTextAlignment = False
			Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell3.Weight = 0.40000000158594073R
			' 
			' ProductID
			' 
			Me.ProductID.Description = "Product ID"
			Me.ProductID.Name = "ProductID"
			Me.ProductID.Type = GetType(Integer)
			Me.ProductID.ValueInfo = "0"
			' 
			' ProductName
			' 
			Me.ProductName.Description = "ProductName"
			Me.ProductName.Name = "ProductName"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Dpi = 100F
			Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel1.ForeColor = System.Drawing.Color.Maroon
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(12.08334F, 10.00001F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(90.62502F, 23F)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.StylePriority.UseForeColor = False
			Me.xrLabel1.Text = "Product:"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding(Me.ProductName, "Text", "")})
			Me.xrLabel2.Dpi = 100F
			Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel2.ForeColor = System.Drawing.Color.Maroon
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(102.7083F, 10.00001F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(448.9583F, 23F)
			Me.xrLabel2.StylePriority.UseFont = False
			Me.xrLabel2.StylePriority.UseForeColor = False
			' 
			' xrTable2
			' 
			Me.xrTable2.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTable2.Dpi = 100F
			Me.xrTable2.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold)
			Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 47.91667F)
			Me.xrTable2.Name = "xrTable2"
			Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
			Me.xrTable2.SizeF = New System.Drawing.SizeF(650F, 25F)
			Me.xrTable2.StylePriority.UseBorders = False
			Me.xrTable2.StylePriority.UseFont = False
			Me.xrTable2.StylePriority.UseTextAlignment = False
			Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell5, Me.xrTableCell6, Me.xrTableCell7, Me.xrTableCell8})
			Me.xrTableRow2.Dpi = 100F
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.Weight = 11.5R
			' 
			' xrTableCell5
			' 
			Me.xrTableCell5.Dpi = 100F
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.Text = "Order ID"
			Me.xrTableCell5.Weight = 0.4R
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.Dpi = 100F
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.Text = "Unit Price"
			Me.xrTableCell6.Weight = 0.4R
			' 
			' xrTableCell7
			' 
			Me.xrTableCell7.Dpi = 100F
			Me.xrTableCell7.Name = "xrTableCell7"
			Me.xrTableCell7.Text = "Quantity"
			Me.xrTableCell7.Weight = 0.4R
			' 
			' xrTableCell8
			' 
			Me.xrTableCell8.Dpi = 100F
			Me.xrTableCell8.Name = "xrTableCell8"
			Me.xrTableCell8.Text = "Discount"
			Me.xrTableCell8.Weight = 0.4R
			' 
			' xrTableCell9
			' 
			Me.xrTableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Order Details.UnitPrice", "{0:$0.00}")})
			Me.xrTableCell9.Dpi = 100F
			Me.xrTableCell9.Name = "xrTableCell9"
			Me.xrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F)
			Me.xrTableCell9.StylePriority.UsePadding = False
			Me.xrTableCell9.StylePriority.UseTextAlignment = False
			Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell9.Weight = 0.40000001889538916R
			' 
			' OrderDetailsReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader})
			Me.DataAdapter = Me.order_DetailsTableAdapter1
			Me.DataMember = "Order Details"
			Me.DataSource = Me.nwindDataSet1
			Me.FilterString = "[ProductID] = ?ProductID"
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.ProductID, Me.ProductName})
			Me.Version = "16.1"
			DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private nwindDataSet1 As nwindDataSet
		Private categoriesTableAdapter As nwindDataSetTableAdapters.CategoriesTableAdapter
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private order_DetailsTableAdapter1 As nwindDataSetTableAdapters.Order_DetailsTableAdapter
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private WithEvents xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private ProductID As DevExpress.XtraReports.Parameters.Parameter
		Private ProductName As DevExpress.XtraReports.Parameters.Parameter
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrTable2 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
	End Class
End Namespace
