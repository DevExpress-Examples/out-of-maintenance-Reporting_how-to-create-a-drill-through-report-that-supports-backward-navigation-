Namespace ExtendedDrillThroughReport
	Partial Public Class ProductsReport
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
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.nwindDataSet1 = New ExtendedDrillThroughReport.nwindDataSet()
			Me.categoriesTableAdapter = New ExtendedDrillThroughReport.nwindDataSetTableAdapters.CategoriesTableAdapter()
			Me.productsTableAdapter1 = New ExtendedDrillThroughReport.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.CategoryName = New DevExpress.XtraReports.Parameters.Parameter()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.CategoryID = New DevExpress.XtraReports.Parameters.Parameter()
			DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
			Me.Detail.Dpi = 100F
			Me.Detail.HeightF = 25F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTable2
			' 
			Me.xrTable2.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTable2.Dpi = 100F
			Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTable2.Name = "xrTable2"
			Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
			Me.xrTable2.SizeF = New System.Drawing.SizeF(650F, 25F)
			Me.xrTable2.StylePriority.UseBorders = False
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
			Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName")})
			Me.xrTableCell5.Dpi = 100F
			Me.xrTableCell5.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Underline)
			Me.xrTableCell5.ForeColor = System.Drawing.Color.DodgerBlue
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F)
			Me.xrTableCell5.StylePriority.UseFont = False
			Me.xrTableCell5.StylePriority.UseForeColor = False
			Me.xrTableCell5.StylePriority.UsePadding = False
			Me.xrTableCell5.StylePriority.UseTextAlignment = False
			Me.xrTableCell5.Text = "xrTableCell5"
			Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCell5.Weight = 0.48974357722355771R
'			Me.xrTableCell5.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.xrTableCell5_BeforePrint)
'			Me.xrTableCell5.PreviewMouseMove += New DevExpress.XtraReports.UI.PreviewMouseEventHandler(Me.xrTableCell5_PreviewMouseMove)
'			Me.xrTableCell5.PreviewClick += New DevExpress.XtraReports.UI.PreviewMouseEventHandler(Me.xrTableCell5_PreviewClick)
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.QuantityPerUnit")})
			Me.xrTableCell6.Dpi = 100F
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F)
			Me.xrTableCell6.StylePriority.UsePadding = False
			Me.xrTableCell6.StylePriority.UseTextAlignment = False
			Me.xrTableCell6.Text = "xrTableCell6"
			Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCell6.Weight = 0.53846157602163469R
			' 
			' xrTableCell7
			' 
			Me.xrTableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitsInStock")})
			Me.xrTableCell7.Dpi = 100F
			Me.xrTableCell7.Name = "xrTableCell7"
			Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F)
			Me.xrTableCell7.StylePriority.UsePadding = False
			Me.xrTableCell7.StylePriority.UseTextAlignment = False
			Me.xrTableCell7.Text = "xrTableCell7"
			Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell7.Weight = 0.28205130709134618R
			' 
			' xrTableCell8
			' 
			Me.xrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitPrice", "{0:$0.00}")})
			Me.xrTableCell8.Dpi = 100F
			Me.xrTableCell8.Name = "xrTableCell8"
			Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F)
			Me.xrTableCell8.StylePriority.UsePadding = False
			Me.xrTableCell8.StylePriority.UseTextAlignment = False
			Me.xrTableCell8.Text = "xrTableCell8"
			Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell8.Weight = 0.28974353966346156R
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
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' productsTableAdapter1
			' 
			Me.productsTableAdapter1.ClearBeforeFill = True
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrLabel1})
			Me.ReportHeader.Dpi = 100F
			Me.ReportHeader.HeightF = 41.66667F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding(Me.CategoryName, "Text", "")})
			Me.xrLabel2.Dpi = 100F
			Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel2.ForeColor = System.Drawing.Color.Maroon
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(90.62502F, 10.00001F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(209.375F, 23F)
			Me.xrLabel2.StylePriority.UseFont = False
			Me.xrLabel2.StylePriority.UseForeColor = False
			' 
			' CategoryName
			' 
			Me.CategoryName.Description = "CategoryName"
			Me.CategoryName.Name = "CategoryName"
			Me.CategoryName.Visible = False
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Dpi = 100F
			Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel1.ForeColor = System.Drawing.Color.Maroon
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10.00001F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(90.62502F, 23F)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.StylePriority.UseForeColor = False
			Me.xrLabel1.Text = "Category:"
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.GroupHeader1.Dpi = 100F
			Me.GroupHeader1.HeightF = 25F
			Me.GroupHeader1.Name = "GroupHeader1"
			' 
			' xrTable1
			' 
			Me.xrTable1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTable1.Dpi = 100F
			Me.xrTable1.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold)
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(650F, 25F)
			Me.xrTable1.StylePriority.UseBorders = False
			Me.xrTable1.StylePriority.UseFont = False
			Me.xrTable1.StylePriority.UseTextAlignment = False
			Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell4})
			Me.xrTableRow1.Dpi = 100F
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 11.5R
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.Dpi = 100F
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Text = "Product Name"
			Me.xrTableCell1.Weight = 0.48974357722355771R
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.Dpi = 100F
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Text = "Quantity Per Unit"
			Me.xrTableCell2.Weight = 0.53846157602163469R
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.Dpi = 100F
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.Text = "Units In Stock"
			Me.xrTableCell3.Weight = 0.28205130709134618R
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.Dpi = 100F
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.Text = "Unit Price"
			Me.xrTableCell4.Weight = 0.28974353966346156R
			' 
			' CategoryID
			' 
			Me.CategoryID.Description = "Category ID"
			Me.CategoryID.Name = "CategoryID"
			Me.CategoryID.Type = GetType(Integer)
			Me.CategoryID.ValueInfo = "0"
			Me.CategoryID.Visible = False
			' 
			' ProductsReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1})
			Me.DataAdapter = Me.productsTableAdapter1
			Me.DataMember = "Products"
			Me.DataSource = Me.nwindDataSet1
			Me.FilterString = "[CategoryID] = ?CategoryID"
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.CategoryID, Me.CategoryName})
			Me.RequestParameters = False
			Me.Version = "16.1"
			DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrTable2 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private WithEvents xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
		Private nwindDataSet1 As nwindDataSet
		Private categoriesTableAdapter As nwindDataSetTableAdapters.CategoriesTableAdapter
		Private productsTableAdapter1 As nwindDataSetTableAdapters.ProductsTableAdapter
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private CategoryName As DevExpress.XtraReports.Parameters.Parameter
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private CategoryID As DevExpress.XtraReports.Parameters.Parameter
	End Class
End Namespace
