Namespace ExtendedDrillThroughReport
	Partial Public Class OrdersReport
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
			Dim dynamicListLookUpSettings1 As New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
			Me.customersTableAdapter1 = New ExtendedDrillThroughReport.nwindDataSetTableAdapters.CustomersTableAdapter()
			Me.nwindDataSet1 = New ExtendedDrillThroughReport.nwindDataSet()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
			Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.CustomerName = New DevExpress.XtraReports.Parameters.Parameter()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.categoriesTableAdapter = New ExtendedDrillThroughReport.nwindDataSetTableAdapters.CategoriesTableAdapter()
			Me.ordersTableAdapter1 = New ExtendedDrillThroughReport.nwindDataSetTableAdapters.OrdersTableAdapter()
			Me.OrderID = New DevExpress.XtraReports.Parameters.Parameter()
			DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' customersTableAdapter1
			' 
			Me.customersTableAdapter1.ClearBeforeFill = True
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine1, Me.xrLabel11, Me.xrLabel10, Me.xrLabel9, Me.xrLabel8, Me.xrLabel5, Me.xrLabel4, Me.xrLabel2, Me.xrLabel3})
			Me.Detail.Dpi = 100F
			Me.Detail.HeightF = 197.9167F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLine1
			' 
			Me.xrLine1.Dpi = 100F
			Me.xrLine1.ForeColor = System.Drawing.Color.DarkOrange
			Me.xrLine1.LineWidth = 2
			Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(224.9999F, 32.99999F)
			Me.xrLine1.Name = "xrLine1"
			Me.xrLine1.SizeF = New System.Drawing.SizeF(163.5416F, 23F)
			Me.xrLine1.StylePriority.UseForeColor = False
			' 
			' xrLabel11
			' 
			Me.xrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.ShipCountry", "{0:M/d/yyyy}")})
			Me.xrLabel11.Dpi = 100F
			Me.xrLabel11.Font = New System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel11.ForeColor = System.Drawing.Color.Maroon
			Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(326.0417F, 169.625F)
			Me.xrLabel11.Name = "xrLabel11"
			Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel11.SizeF = New System.Drawing.SizeF(107.2916F, 23F)
			Me.xrLabel11.StylePriority.UseFont = False
			Me.xrLabel11.StylePriority.UseForeColor = False
			' 
			' xrLabel10
			' 
			Me.xrLabel10.Dpi = 100F
			Me.xrLabel10.Font = New System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel10.ForeColor = System.Drawing.Color.Maroon
			Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(188.5416F, 169.625F)
			Me.xrLabel10.Name = "xrLabel10"
			Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel10.SizeF = New System.Drawing.SizeF(123.9584F, 23F)
			Me.xrLabel10.StylePriority.UseFont = False
			Me.xrLabel10.StylePriority.UseForeColor = False
			Me.xrLabel10.StylePriority.UseTextAlignment = False
			Me.xrLabel10.Text = "ShipCountry:"
			Me.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrLabel9
			' 
			Me.xrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.Freight", "{0:$0.00}")})
			Me.xrLabel9.Dpi = 100F
			Me.xrLabel9.Font = New System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel9.ForeColor = System.Drawing.Color.Maroon
			Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(326.0417F, 116.4167F)
			Me.xrLabel9.Name = "xrLabel9"
			Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel9.SizeF = New System.Drawing.SizeF(107.2916F, 23F)
			Me.xrLabel9.StylePriority.UseFont = False
			Me.xrLabel9.StylePriority.UseForeColor = False
			' 
			' xrLabel8
			' 
			Me.xrLabel8.Dpi = 100F
			Me.xrLabel8.Font = New System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel8.ForeColor = System.Drawing.Color.Maroon
			Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(188.5416F, 116.4167F)
			Me.xrLabel8.Name = "xrLabel8"
			Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel8.SizeF = New System.Drawing.SizeF(85.41671F, 23F)
			Me.xrLabel8.StylePriority.UseFont = False
			Me.xrLabel8.StylePriority.UseForeColor = False
			Me.xrLabel8.StylePriority.UseTextAlignment = False
			Me.xrLabel8.Text = "Freight:"
			Me.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrLabel5
			' 
			Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrderDate", "{0:dd-MMM-yy}")})
			Me.xrLabel5.Dpi = 100F
			Me.xrLabel5.Font = New System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel5.ForeColor = System.Drawing.Color.Maroon
			Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(326.0417F, 63.20832F)
			Me.xrLabel5.Name = "xrLabel5"
			Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel5.SizeF = New System.Drawing.SizeF(107.2916F, 23F)
			Me.xrLabel5.StylePriority.UseFont = False
			Me.xrLabel5.StylePriority.UseForeColor = False
			' 
			' xrLabel4
			' 
			Me.xrLabel4.Dpi = 100F
			Me.xrLabel4.Font = New System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel4.ForeColor = System.Drawing.Color.Maroon
			Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(188.5416F, 63.20832F)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel4.SizeF = New System.Drawing.SizeF(64.58337F, 23F)
			Me.xrLabel4.StylePriority.UseFont = False
			Me.xrLabel4.StylePriority.UseForeColor = False
			Me.xrLabel4.StylePriority.UseTextAlignment = False
			Me.xrLabel4.Text = "Date:"
			Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrLabel2
			' 
			Me.xrLabel2.Dpi = 100F
			Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel2.ForeColor = System.Drawing.Color.DarkOrange
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(224.9999F, 10.00001F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(87.50003F, 23F)
			Me.xrLabel2.StylePriority.UseFont = False
			Me.xrLabel2.StylePriority.UseForeColor = False
			Me.xrLabel2.StylePriority.UseTextAlignment = False
			Me.xrLabel2.Text = "Order #"
			Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrLabel3
			' 
			Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrderID")})
			Me.xrLabel3.Dpi = 100F
			Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel3.ForeColor = System.Drawing.Color.DarkOrange
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(312.5F, 10.00001F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(107.2916F, 23F)
			Me.xrLabel3.StylePriority.UseFont = False
			Me.xrLabel3.StylePriority.UseForeColor = False
			' 
			' CustomerName
			' 
			Me.CustomerName.Description = "Customer Name"
			dynamicListLookUpSettings1.DataAdapter = Me.customersTableAdapter1
			dynamicListLookUpSettings1.DataMember = "Customers"
			dynamicListLookUpSettings1.DataSource = Me.nwindDataSet1
			dynamicListLookUpSettings1.DisplayMember = "CompanyName"
			dynamicListLookUpSettings1.ValueMember = Nothing
			Me.CustomerName.LookUpSettings = dynamicListLookUpSettings1
			Me.CustomerName.Name = "CustomerName"
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
			Me.BottomMargin.HeightF = 256.25F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' ordersTableAdapter1
			' 
			Me.ordersTableAdapter1.ClearBeforeFill = True
			' 
			' OrderID
			' 
			Me.OrderID.Description = "Order ID"
			Me.OrderID.Name = "OrderID"
			Me.OrderID.Type = GetType(Integer)
			Me.OrderID.ValueInfo = "0"
			' 
			' OrdersReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin})
			Me.DataAdapter = Me.ordersTableAdapter1
			Me.DataMember = "Orders"
			Me.DataSource = Me.nwindDataSet1
			Me.FilterString = "[OrderID] = ?OrderID"
			Me.Margins = New System.Drawing.Printing.Margins(100, 100, 100, 256)
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.OrderID, Me.CustomerName})
			Me.Version = "16.1"
			DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private nwindDataSet1 As nwindDataSet
		Private categoriesTableAdapter As nwindDataSetTableAdapters.CategoriesTableAdapter
		Private ordersTableAdapter1 As nwindDataSetTableAdapters.OrdersTableAdapter
		Private OrderID As DevExpress.XtraReports.Parameters.Parameter
		Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private CustomerName As DevExpress.XtraReports.Parameters.Parameter
		Private customersTableAdapter1 As nwindDataSetTableAdapters.CustomersTableAdapter
		Private xrLabel11 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel10 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel9 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel8 As DevExpress.XtraReports.UI.XRLabel
		Private xrLine1 As DevExpress.XtraReports.UI.XRLine
	End Class
End Namespace
