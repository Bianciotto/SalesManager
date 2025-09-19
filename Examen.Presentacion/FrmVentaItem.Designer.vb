<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentaItem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVentaItem))
        Me.TabCtrlSaleItem = New System.Windows.Forms.TabControl()
        Me.TabPageSaleItemSell = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxFindSaleItemTabSell = New System.Windows.Forms.GroupBox()
        Me.LblTotalProductSaleItemTabSell = New System.Windows.Forms.Label()
        Me.LblFindClientSaleItemTabSell = New System.Windows.Forms.Label()
        Me.LblFindProductSaleItemTabSell = New System.Windows.Forms.Label()
        Me.LblDataClientSaleItemTabSell = New System.Windows.Forms.Label()
        Me.TextbFindClientSaleItemTabSell = New System.Windows.Forms.TextBox()
        Me.BtnFindClientSaleItemTabSell = New System.Windows.Forms.Button()
        Me.BtnFindProductSaleItemTabSell = New System.Windows.Forms.Button()
        Me.TextbFindProductSaleItemTabSell = New System.Windows.Forms.TextBox()
        Me.GroupBoxListProductSaleItemTabSell = New System.Windows.Forms.GroupBox()
        Me.DgvListProductSaleItemTabSell = New System.Windows.Forms.DataGridView()
        Me.GroupBoxListProductAddSaleItemTabSell = New System.Windows.Forms.GroupBox()
        Me.BtnSellSaleItemTabSell = New System.Windows.Forms.Button()
        Me.BtnCancelSellSaleItemTabSell = New System.Windows.Forms.Button()
        Me.LblTotalSaleItemTabSell = New System.Windows.Forms.Label()
        Me.LblTotalTitelSaleItemTabSell = New System.Windows.Forms.Label()
        Me.DgvListProductAddSaleItemTabSell = New System.Windows.Forms.DataGridView()
        Me.TabPageSaleItemUpdate = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvListSaleSaleItemTabEdit = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DgvListItemSaleItemTabEdit = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblFindClientSaleItemTabEdit = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextbFindClientSaleItemTabEdit = New System.Windows.Forms.TextBox()
        Me.BtnFindClientSaleItemTabEdit = New System.Windows.Forms.Button()
        Me.TabCtrlSaleItem.SuspendLayout()
        Me.TabPageSaleItemSell.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBoxFindSaleItemTabSell.SuspendLayout()
        Me.GroupBoxListProductSaleItemTabSell.SuspendLayout()
        CType(Me.DgvListProductSaleItemTabSell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxListProductAddSaleItemTabSell.SuspendLayout()
        CType(Me.DgvListProductAddSaleItemTabSell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageSaleItemUpdate.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvListSaleSaleItemTabEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvListItemSaleItemTabEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabCtrlSaleItem
        '
        Me.TabCtrlSaleItem.Controls.Add(Me.TabPageSaleItemSell)
        Me.TabCtrlSaleItem.Controls.Add(Me.TabPageSaleItemUpdate)
        Me.TabCtrlSaleItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCtrlSaleItem.Location = New System.Drawing.Point(0, 0)
        Me.TabCtrlSaleItem.Name = "TabCtrlSaleItem"
        Me.TabCtrlSaleItem.SelectedIndex = 0
        Me.TabCtrlSaleItem.Size = New System.Drawing.Size(800, 450)
        Me.TabCtrlSaleItem.TabIndex = 0
        '
        'TabPageSaleItemSell
        '
        Me.TabPageSaleItemSell.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPageSaleItemSell.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSaleItemSell.Name = "TabPageSaleItemSell"
        Me.TabPageSaleItemSell.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSaleItemSell.Size = New System.Drawing.Size(792, 424)
        Me.TabPageSaleItemSell.TabIndex = 0
        Me.TabPageSaleItemSell.Text = "Vender"
        Me.TabPageSaleItemSell.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxFindSaleItemTabSell, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxListProductSaleItemTabSell, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBoxListProductAddSaleItemTabSell, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(786, 418)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBoxFindSaleItemTabSell
        '
        Me.GroupBoxFindSaleItemTabSell.AutoSize = True
        Me.GroupBoxFindSaleItemTabSell.Controls.Add(Me.LblTotalProductSaleItemTabSell)
        Me.GroupBoxFindSaleItemTabSell.Controls.Add(Me.LblFindClientSaleItemTabSell)
        Me.GroupBoxFindSaleItemTabSell.Controls.Add(Me.LblFindProductSaleItemTabSell)
        Me.GroupBoxFindSaleItemTabSell.Controls.Add(Me.LblDataClientSaleItemTabSell)
        Me.GroupBoxFindSaleItemTabSell.Controls.Add(Me.TextbFindClientSaleItemTabSell)
        Me.GroupBoxFindSaleItemTabSell.Controls.Add(Me.BtnFindClientSaleItemTabSell)
        Me.GroupBoxFindSaleItemTabSell.Controls.Add(Me.BtnFindProductSaleItemTabSell)
        Me.GroupBoxFindSaleItemTabSell.Controls.Add(Me.TextbFindProductSaleItemTabSell)
        Me.GroupBoxFindSaleItemTabSell.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxFindSaleItemTabSell.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxFindSaleItemTabSell.Name = "GroupBoxFindSaleItemTabSell"
        Me.GroupBoxFindSaleItemTabSell.Size = New System.Drawing.Size(780, 77)
        Me.GroupBoxFindSaleItemTabSell.TabIndex = 0
        Me.GroupBoxFindSaleItemTabSell.TabStop = False
        Me.GroupBoxFindSaleItemTabSell.Text = "Seccion de Busqueda"
        '
        'LblTotalProductSaleItemTabSell
        '
        Me.LblTotalProductSaleItemTabSell.AutoSize = True
        Me.LblTotalProductSaleItemTabSell.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalProductSaleItemTabSell.Location = New System.Drawing.Point(151, 60)
        Me.LblTotalProductSaleItemTabSell.Name = "LblTotalProductSaleItemTabSell"
        Me.LblTotalProductSaleItemTabSell.Size = New System.Drawing.Size(119, 15)
        Me.LblTotalProductSaleItemTabSell.TabIndex = 6
        Me.LblTotalProductSaleItemTabSell.Text = "Total de Productos: "
        '
        'LblFindClientSaleItemTabSell
        '
        Me.LblFindClientSaleItemTabSell.AutoSize = True
        Me.LblFindClientSaleItemTabSell.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFindClientSaleItemTabSell.Location = New System.Drawing.Point(494, 11)
        Me.LblFindClientSaleItemTabSell.Name = "LblFindClientSaleItemTabSell"
        Me.LblFindClientSaleItemTabSell.Size = New System.Drawing.Size(101, 15)
        Me.LblFindClientSaleItemTabSell.TabIndex = 5
        Me.LblFindClientSaleItemTabSell.Text = "Asigne al Cliente"
        '
        'LblFindProductSaleItemTabSell
        '
        Me.LblFindProductSaleItemTabSell.AutoSize = True
        Me.LblFindProductSaleItemTabSell.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFindProductSaleItemTabSell.Location = New System.Drawing.Point(151, 11)
        Me.LblFindProductSaleItemTabSell.Name = "LblFindProductSaleItemTabSell"
        Me.LblFindProductSaleItemTabSell.Size = New System.Drawing.Size(117, 15)
        Me.LblFindProductSaleItemTabSell.TabIndex = 4
        Me.LblFindProductSaleItemTabSell.Text = "Busque el Producto "
        '
        'LblDataClientSaleItemTabSell
        '
        Me.LblDataClientSaleItemTabSell.AutoSize = True
        Me.LblDataClientSaleItemTabSell.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDataClientSaleItemTabSell.Font = New System.Drawing.Font("Calisto MT", 7.0!)
        Me.LblDataClientSaleItemTabSell.Location = New System.Drawing.Point(625, 9)
        Me.LblDataClientSaleItemTabSell.Name = "LblDataClientSaleItemTabSell"
        Me.LblDataClientSaleItemTabSell.Size = New System.Drawing.Size(2, 13)
        Me.LblDataClientSaleItemTabSell.TabIndex = 1
        '
        'TextbFindClientSaleItemTabSell
        '
        Me.TextbFindClientSaleItemTabSell.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.TextbFindClientSaleItemTabSell.Location = New System.Drawing.Point(484, 30)
        Me.TextbFindClientSaleItemTabSell.Name = "TextbFindClientSaleItemTabSell"
        Me.TextbFindClientSaleItemTabSell.Size = New System.Drawing.Size(135, 26)
        Me.TextbFindClientSaleItemTabSell.TabIndex = 2
        '
        'BtnFindClientSaleItemTabSell
        '
        Me.BtnFindClientSaleItemTabSell.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.BtnFindClientSaleItemTabSell.Location = New System.Drawing.Point(413, 28)
        Me.BtnFindClientSaleItemTabSell.Name = "BtnFindClientSaleItemTabSell"
        Me.BtnFindClientSaleItemTabSell.Size = New System.Drawing.Size(68, 29)
        Me.BtnFindClientSaleItemTabSell.TabIndex = 0
        Me.BtnFindClientSaleItemTabSell.Text = "Asignar"
        Me.BtnFindClientSaleItemTabSell.UseVisualStyleBackColor = True
        '
        'BtnFindProductSaleItemTabSell
        '
        Me.BtnFindProductSaleItemTabSell.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.BtnFindProductSaleItemTabSell.Location = New System.Drawing.Point(75, 28)
        Me.BtnFindProductSaleItemTabSell.Name = "BtnFindProductSaleItemTabSell"
        Me.BtnFindProductSaleItemTabSell.Size = New System.Drawing.Size(68, 29)
        Me.BtnFindProductSaleItemTabSell.TabIndex = 0
        Me.BtnFindProductSaleItemTabSell.Text = "Buscar"
        Me.BtnFindProductSaleItemTabSell.UseVisualStyleBackColor = True
        '
        'TextbFindProductSaleItemTabSell
        '
        Me.TextbFindProductSaleItemTabSell.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.TextbFindProductSaleItemTabSell.Location = New System.Drawing.Point(148, 30)
        Me.TextbFindProductSaleItemTabSell.Name = "TextbFindProductSaleItemTabSell"
        Me.TextbFindProductSaleItemTabSell.Size = New System.Drawing.Size(135, 26)
        Me.TextbFindProductSaleItemTabSell.TabIndex = 1
        '
        'GroupBoxListProductSaleItemTabSell
        '
        Me.GroupBoxListProductSaleItemTabSell.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxListProductSaleItemTabSell.AutoSize = True
        Me.GroupBoxListProductSaleItemTabSell.Controls.Add(Me.DgvListProductSaleItemTabSell)
        Me.GroupBoxListProductSaleItemTabSell.Location = New System.Drawing.Point(3, 86)
        Me.GroupBoxListProductSaleItemTabSell.Name = "GroupBoxListProductSaleItemTabSell"
        Me.GroupBoxListProductSaleItemTabSell.Size = New System.Drawing.Size(780, 161)
        Me.GroupBoxListProductSaleItemTabSell.TabIndex = 1
        Me.GroupBoxListProductSaleItemTabSell.TabStop = False
        Me.GroupBoxListProductSaleItemTabSell.Text = "Lista de Productos"
        '
        'DgvListProductSaleItemTabSell
        '
        Me.DgvListProductSaleItemTabSell.AllowUserToAddRows = False
        Me.DgvListProductSaleItemTabSell.AllowUserToDeleteRows = False
        Me.DgvListProductSaleItemTabSell.AllowUserToOrderColumns = True
        Me.DgvListProductSaleItemTabSell.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvListProductSaleItemTabSell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvListProductSaleItemTabSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListProductSaleItemTabSell.Location = New System.Drawing.Point(33, 39)
        Me.DgvListProductSaleItemTabSell.Name = "DgvListProductSaleItemTabSell"
        Me.DgvListProductSaleItemTabSell.Size = New System.Drawing.Size(702, 87)
        Me.DgvListProductSaleItemTabSell.TabIndex = 0
        '
        'GroupBoxListProductAddSaleItemTabSell
        '
        Me.GroupBoxListProductAddSaleItemTabSell.AutoSize = True
        Me.GroupBoxListProductAddSaleItemTabSell.Controls.Add(Me.BtnSellSaleItemTabSell)
        Me.GroupBoxListProductAddSaleItemTabSell.Controls.Add(Me.BtnCancelSellSaleItemTabSell)
        Me.GroupBoxListProductAddSaleItemTabSell.Controls.Add(Me.LblTotalSaleItemTabSell)
        Me.GroupBoxListProductAddSaleItemTabSell.Controls.Add(Me.LblTotalTitelSaleItemTabSell)
        Me.GroupBoxListProductAddSaleItemTabSell.Controls.Add(Me.DgvListProductAddSaleItemTabSell)
        Me.GroupBoxListProductAddSaleItemTabSell.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxListProductAddSaleItemTabSell.Location = New System.Drawing.Point(3, 253)
        Me.GroupBoxListProductAddSaleItemTabSell.Name = "GroupBoxListProductAddSaleItemTabSell"
        Me.GroupBoxListProductAddSaleItemTabSell.Size = New System.Drawing.Size(780, 162)
        Me.GroupBoxListProductAddSaleItemTabSell.TabIndex = 2
        Me.GroupBoxListProductAddSaleItemTabSell.TabStop = False
        Me.GroupBoxListProductAddSaleItemTabSell.Text = "Productos Elegidos"
        '
        'BtnSellSaleItemTabSell
        '
        Me.BtnSellSaleItemTabSell.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSellSaleItemTabSell.AutoSize = True
        Me.BtnSellSaleItemTabSell.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.BtnSellSaleItemTabSell.Location = New System.Drawing.Point(154, 127)
        Me.BtnSellSaleItemTabSell.Name = "BtnSellSaleItemTabSell"
        Me.BtnSellSaleItemTabSell.Size = New System.Drawing.Size(68, 29)
        Me.BtnSellSaleItemTabSell.TabIndex = 6
        Me.BtnSellSaleItemTabSell.Text = "Vender"
        Me.BtnSellSaleItemTabSell.UseVisualStyleBackColor = True
        '
        'BtnCancelSellSaleItemTabSell
        '
        Me.BtnCancelSellSaleItemTabSell.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCancelSellSaleItemTabSell.AutoSize = True
        Me.BtnCancelSellSaleItemTabSell.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.BtnCancelSellSaleItemTabSell.Location = New System.Drawing.Point(33, 127)
        Me.BtnCancelSellSaleItemTabSell.Name = "BtnCancelSellSaleItemTabSell"
        Me.BtnCancelSellSaleItemTabSell.Size = New System.Drawing.Size(80, 29)
        Me.BtnCancelSellSaleItemTabSell.TabIndex = 5
        Me.BtnCancelSellSaleItemTabSell.Text = "Cancelar"
        Me.BtnCancelSellSaleItemTabSell.UseVisualStyleBackColor = True
        '
        'LblTotalSaleItemTabSell
        '
        Me.LblTotalSaleItemTabSell.AutoEllipsis = True
        Me.LblTotalSaleItemTabSell.AutoSize = True
        Me.LblTotalSaleItemTabSell.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblTotalSaleItemTabSell.Location = New System.Drawing.Point(624, 162)
        Me.LblTotalSaleItemTabSell.Name = "LblTotalSaleItemTabSell"
        Me.LblTotalSaleItemTabSell.Size = New System.Drawing.Size(17, 19)
        Me.LblTotalSaleItemTabSell.TabIndex = 4
        Me.LblTotalSaleItemTabSell.Text = "$"
        '
        'LblTotalTitelSaleItemTabSell
        '
        Me.LblTotalTitelSaleItemTabSell.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblTotalTitelSaleItemTabSell.AutoEllipsis = True
        Me.LblTotalTitelSaleItemTabSell.AutoSize = True
        Me.LblTotalTitelSaleItemTabSell.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblTotalTitelSaleItemTabSell.Location = New System.Drawing.Point(511, 132)
        Me.LblTotalTitelSaleItemTabSell.Name = "LblTotalTitelSaleItemTabSell"
        Me.LblTotalTitelSaleItemTabSell.Size = New System.Drawing.Size(98, 19)
        Me.LblTotalTitelSaleItemTabSell.TabIndex = 2
        Me.LblTotalTitelSaleItemTabSell.Text = "Precio Final:"
        '
        'DgvListProductAddSaleItemTabSell
        '
        Me.DgvListProductAddSaleItemTabSell.AllowUserToAddRows = False
        Me.DgvListProductAddSaleItemTabSell.AllowUserToDeleteRows = False
        Me.DgvListProductAddSaleItemTabSell.AllowUserToOrderColumns = True
        Me.DgvListProductAddSaleItemTabSell.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvListProductAddSaleItemTabSell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvListProductAddSaleItemTabSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListProductAddSaleItemTabSell.Location = New System.Drawing.Point(33, 16)
        Me.DgvListProductAddSaleItemTabSell.Name = "DgvListProductAddSaleItemTabSell"
        Me.DgvListProductAddSaleItemTabSell.ReadOnly = True
        Me.DgvListProductAddSaleItemTabSell.Size = New System.Drawing.Size(702, 99)
        Me.DgvListProductAddSaleItemTabSell.TabIndex = 0
        '
        'TabPageSaleItemUpdate
        '
        Me.TabPageSaleItemUpdate.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPageSaleItemUpdate.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSaleItemUpdate.Name = "TabPageSaleItemUpdate"
        Me.TabPageSaleItemUpdate.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSaleItemUpdate.Size = New System.Drawing.Size(792, 424)
        Me.TabPageSaleItemUpdate.TabIndex = 1
        Me.TabPageSaleItemUpdate.Text = "Eliminar Venta"
        Me.TabPageSaleItemUpdate.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox3, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(786, 418)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DgvListSaleSaleItemTabEdit)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(780, 168)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listas de Ventas"
        '
        'DgvListSaleSaleItemTabEdit
        '
        Me.DgvListSaleSaleItemTabEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvListSaleSaleItemTabEdit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvListSaleSaleItemTabEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListSaleSaleItemTabEdit.Location = New System.Drawing.Point(69, 19)
        Me.DgvListSaleSaleItemTabEdit.Margin = New System.Windows.Forms.Padding(3, 15, 3, 3)
        Me.DgvListSaleSaleItemTabEdit.Name = "DgvListSaleSaleItemTabEdit"
        Me.DgvListSaleSaleItemTabEdit.Size = New System.Drawing.Size(644, 145)
        Me.DgvListSaleSaleItemTabEdit.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.DgvListItemSaleItemTabEdit)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 246)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(780, 169)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Venta Seleccionada"
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button4.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.Button4.Location = New System.Drawing.Point(452, 134)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 29)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button3.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.Button3.Location = New System.Drawing.Point(215, 134)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 29)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DgvListItemSaleItemTabEdit
        '
        Me.DgvListItemSaleItemTabEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvListItemSaleItemTabEdit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvListItemSaleItemTabEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListItemSaleItemTabEdit.Location = New System.Drawing.Point(69, 21)
        Me.DgvListItemSaleItemTabEdit.Name = "DgvListItemSaleItemTabEdit"
        Me.DgvListItemSaleItemTabEdit.Size = New System.Drawing.Size(644, 111)
        Me.DgvListItemSaleItemTabEdit.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LblFindClientSaleItemTabEdit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextbFindClientSaleItemTabEdit)
        Me.GroupBox1.Controls.Add(Me.BtnFindClientSaleItemTabEdit)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(780, 63)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Venta"
        '
        'LblFindClientSaleItemTabEdit
        '
        Me.LblFindClientSaleItemTabEdit.AutoSize = True
        Me.LblFindClientSaleItemTabEdit.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblFindClientSaleItemTabEdit.Location = New System.Drawing.Point(421, 22)
        Me.LblFindClientSaleItemTabEdit.Name = "LblFindClientSaleItemTabEdit"
        Me.LblFindClientSaleItemTabEdit.Size = New System.Drawing.Size(153, 19)
        Me.LblFindClientSaleItemTabEdit.TabIndex = 6
        Me.LblFindClientSaleItemTabEdit.Text = "Cantidad de Ventas: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calisto MT", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(30, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "IDCliente"
        '
        'TextbFindClientSaleItemTabEdit
        '
        Me.TextbFindClientSaleItemTabEdit.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.TextbFindClientSaleItemTabEdit.Location = New System.Drawing.Point(116, 19)
        Me.TextbFindClientSaleItemTabEdit.Name = "TextbFindClientSaleItemTabEdit"
        Me.TextbFindClientSaleItemTabEdit.Size = New System.Drawing.Size(135, 26)
        Me.TextbFindClientSaleItemTabEdit.TabIndex = 3
        '
        'BtnFindClientSaleItemTabEdit
        '
        Me.BtnFindClientSaleItemTabEdit.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.BtnFindClientSaleItemTabEdit.Location = New System.Drawing.Point(274, 17)
        Me.BtnFindClientSaleItemTabEdit.Name = "BtnFindClientSaleItemTabEdit"
        Me.BtnFindClientSaleItemTabEdit.Size = New System.Drawing.Size(80, 29)
        Me.BtnFindClientSaleItemTabEdit.TabIndex = 1
        Me.BtnFindClientSaleItemTabEdit.Text = "Buscar"
        Me.BtnFindClientSaleItemTabEdit.UseVisualStyleBackColor = True
        '
        'FrmVentaItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabCtrlSaleItem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVentaItem"
        Me.Text = "Vender Items"
        Me.TabCtrlSaleItem.ResumeLayout(False)
        Me.TabPageSaleItemSell.ResumeLayout(False)
        Me.TabPageSaleItemSell.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBoxFindSaleItemTabSell.ResumeLayout(False)
        Me.GroupBoxFindSaleItemTabSell.PerformLayout()
        Me.GroupBoxListProductSaleItemTabSell.ResumeLayout(False)
        CType(Me.DgvListProductSaleItemTabSell, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxListProductAddSaleItemTabSell.ResumeLayout(False)
        Me.GroupBoxListProductAddSaleItemTabSell.PerformLayout()
        CType(Me.DgvListProductAddSaleItemTabSell, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageSaleItemUpdate.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvListSaleSaleItemTabEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvListItemSaleItemTabEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabCtrlSaleItem As TabControl
    Friend WithEvents TabPageSaleItemSell As TabPage
    Friend WithEvents TabPageSaleItemUpdate As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBoxFindSaleItemTabSell As GroupBox
    Friend WithEvents TextbFindProductSaleItemTabSell As TextBox
    Friend WithEvents GroupBoxListProductSaleItemTabSell As GroupBox
    Friend WithEvents GroupBoxListProductAddSaleItemTabSell As GroupBox
    Friend WithEvents LblTotalSaleItemTabSell As Label
    Friend WithEvents TextbFindClientSaleItemTabSell As TextBox
    Friend WithEvents BtnFindClientSaleItemTabSell As Button
    Friend WithEvents BtnFindProductSaleItemTabSell As Button
    Friend WithEvents DgvListProductSaleItemTabSell As DataGridView
    Friend WithEvents LblTotalTitelSaleItemTabSell As Label
    Friend WithEvents LblDataClientSaleItemTabSell As Label
    Friend WithEvents DgvListProductAddSaleItemTabSell As DataGridView
    Friend WithEvents LblFindClientSaleItemTabSell As Label
    Friend WithEvents LblFindProductSaleItemTabSell As Label
    Friend WithEvents BtnSellSaleItemTabSell As Button
    Friend WithEvents BtnCancelSellSaleItemTabSell As Button
    Friend WithEvents LblTotalProductSaleItemTabSell As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DgvListSaleSaleItemTabEdit As DataGridView
    Friend WithEvents DgvListItemSaleItemTabEdit As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TextbFindClientSaleItemTabEdit As TextBox
    Friend WithEvents BtnFindClientSaleItemTabEdit As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents LblFindClientSaleItemTabEdit As Label
End Class
