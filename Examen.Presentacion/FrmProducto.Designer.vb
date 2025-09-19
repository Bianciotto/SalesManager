<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProducto))
        Me.TabContrlProduct = New System.Windows.Forms.TabControl()
        Me.TabPageListProduct = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnFindProductTabProduct = New System.Windows.Forms.Button()
        Me.TextbFindProductTabList = New System.Windows.Forms.TextBox()
        Me.LblTotalProductTabList = New System.Windows.Forms.Label()
        Me.DgvListProductTabList = New System.Windows.Forms.DataGridView()
        Me.TabPageAddProduct = New System.Windows.Forms.TabPage()
        Me.GroupBoxProductTabAdd = New System.Windows.Forms.GroupBox()
        Me.BtnAddProductTabAdd = New System.Windows.Forms.Button()
        Me.BtnCancelProductTabAdd = New System.Windows.Forms.Button()
        Me.LblCategoryProductTabAdd = New System.Windows.Forms.Label()
        Me.LblPriceProductTabAdd = New System.Windows.Forms.Label()
        Me.LblNameProductTabAdd = New System.Windows.Forms.Label()
        Me.TextbCategoryProductTabAdd = New System.Windows.Forms.TextBox()
        Me.TextbPriceProductTabAdd = New System.Windows.Forms.TextBox()
        Me.TextbNameProductTabAdd = New System.Windows.Forms.TextBox()
        Me.TabPageUpdateProduct = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnFindProductTabUpdate = New System.Windows.Forms.Button()
        Me.TextbFindProductTabUpdate = New System.Windows.Forms.TextBox()
        Me.GroupBoxProductTabUpdate = New System.Windows.Forms.GroupBox()
        Me.BtnCancelProductTabUpdate = New System.Windows.Forms.Button()
        Me.BtnUpdateProductTabUpdate = New System.Windows.Forms.Button()
        Me.LblCategoryProductTabUpdate = New System.Windows.Forms.Label()
        Me.LblPriceProductTabUpdate = New System.Windows.Forms.Label()
        Me.LblNameProductTabUpdate = New System.Windows.Forms.Label()
        Me.TextbCategoryProductTabUpdate = New System.Windows.Forms.TextBox()
        Me.TextbPriceProductTabUpdate = New System.Windows.Forms.TextBox()
        Me.TextbNameProductTabUpdate = New System.Windows.Forms.TextBox()
        Me.LblTotalProductTabUpdate = New System.Windows.Forms.Label()
        Me.DgvListProductTabUpdate = New System.Windows.Forms.DataGridView()
        Me.TabPageDeleteProduct = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnFindProductTabDelete = New System.Windows.Forms.Button()
        Me.GroupBoxProductTabDelete = New System.Windows.Forms.GroupBox()
        Me.BtnDeleteProductTabDelete = New System.Windows.Forms.Button()
        Me.BtnCancelProductTabDelete = New System.Windows.Forms.Button()
        Me.LblEmpyCategoryProductTabDelete = New System.Windows.Forms.Label()
        Me.LblEmpyPriceProductTabDelete = New System.Windows.Forms.Label()
        Me.LblEmpyNameProductTabDelete = New System.Windows.Forms.Label()
        Me.LblCategoryProductTabDelete = New System.Windows.Forms.Label()
        Me.LblPriceProductTabDelete = New System.Windows.Forms.Label()
        Me.LblNameProductTabDelete = New System.Windows.Forms.Label()
        Me.TextbFindProductTabDelete = New System.Windows.Forms.TextBox()
        Me.LblTotalProductTabDelete = New System.Windows.Forms.Label()
        Me.DgvListProductTabDelete = New System.Windows.Forms.DataGridView()
        Me.TabContrlProduct.SuspendLayout()
        Me.TabPageListProduct.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DgvListProductTabList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageAddProduct.SuspendLayout()
        Me.GroupBoxProductTabAdd.SuspendLayout()
        Me.TabPageUpdateProduct.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBoxProductTabUpdate.SuspendLayout()
        CType(Me.DgvListProductTabUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageDeleteProduct.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBoxProductTabDelete.SuspendLayout()
        CType(Me.DgvListProductTabDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabContrlProduct
        '
        Me.TabContrlProduct.Controls.Add(Me.TabPageListProduct)
        Me.TabContrlProduct.Controls.Add(Me.TabPageAddProduct)
        Me.TabContrlProduct.Controls.Add(Me.TabPageUpdateProduct)
        Me.TabContrlProduct.Controls.Add(Me.TabPageDeleteProduct)
        Me.TabContrlProduct.Location = New System.Drawing.Point(-2, 0)
        Me.TabContrlProduct.Name = "TabContrlProduct"
        Me.TabContrlProduct.SelectedIndex = 0
        Me.TabContrlProduct.Size = New System.Drawing.Size(806, 448)
        Me.TabContrlProduct.TabIndex = 0
        '
        'TabPageListProduct
        '
        Me.TabPageListProduct.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPageListProduct.Location = New System.Drawing.Point(4, 22)
        Me.TabPageListProduct.Name = "TabPageListProduct"
        Me.TabPageListProduct.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageListProduct.Size = New System.Drawing.Size(798, 422)
        Me.TabPageListProduct.TabIndex = 0
        Me.TabPageListProduct.Text = "Listado"
        Me.TabPageListProduct.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnFindProductTabProduct, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextbFindProductTabList, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTotalProductTabList, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.DgvListProductTabList, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(798, 422)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'BtnFindProductTabProduct
        '
        Me.BtnFindProductTabProduct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnFindProductTabProduct.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.BtnFindProductTabProduct.Location = New System.Drawing.Point(360, 38)
        Me.BtnFindProductTabProduct.Name = "BtnFindProductTabProduct"
        Me.BtnFindProductTabProduct.Size = New System.Drawing.Size(68, 29)
        Me.BtnFindProductTabProduct.TabIndex = 2
        Me.BtnFindProductTabProduct.Text = "Buscar"
        Me.BtnFindProductTabProduct.UseVisualStyleBackColor = True
        '
        'TextbFindProductTabList
        '
        Me.TextbFindProductTabList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextbFindProductTabList.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.TextbFindProductTabList.Location = New System.Drawing.Point(327, 4)
        Me.TextbFindProductTabList.Name = "TextbFindProductTabList"
        Me.TextbFindProductTabList.Size = New System.Drawing.Size(135, 26)
        Me.TextbFindProductTabList.TabIndex = 1
        '
        'LblTotalProductTabList
        '
        Me.LblTotalProductTabList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblTotalProductTabList.AutoSize = True
        Me.LblTotalProductTabList.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblTotalProductTabList.Location = New System.Drawing.Point(320, 363)
        Me.LblTotalProductTabList.Name = "LblTotalProductTabList"
        Me.LblTotalProductTabList.Size = New System.Drawing.Size(149, 19)
        Me.LblTotalProductTabList.TabIndex = 0
        Me.LblTotalProductTabList.Text = "Total de Productos: "
        '
        'DgvListProductTabList
        '
        Me.DgvListProductTabList.AllowUserToAddRows = False
        Me.DgvListProductTabList.AllowUserToDeleteRows = False
        Me.DgvListProductTabList.AllowUserToOrderColumns = True
        Me.DgvListProductTabList.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvListProductTabList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvListProductTabList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListProductTabList.Location = New System.Drawing.Point(23, 73)
        Me.DgvListProductTabList.Name = "DgvListProductTabList"
        Me.DgvListProductTabList.ReadOnly = True
        Me.DgvListProductTabList.Size = New System.Drawing.Size(743, 247)
        Me.DgvListProductTabList.TabIndex = 0
        '
        'TabPageAddProduct
        '
        Me.TabPageAddProduct.Controls.Add(Me.GroupBoxProductTabAdd)
        Me.TabPageAddProduct.Location = New System.Drawing.Point(4, 22)
        Me.TabPageAddProduct.Name = "TabPageAddProduct"
        Me.TabPageAddProduct.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAddProduct.Size = New System.Drawing.Size(798, 422)
        Me.TabPageAddProduct.TabIndex = 1
        Me.TabPageAddProduct.Text = "Agregar"
        Me.TabPageAddProduct.UseVisualStyleBackColor = True
        '
        'GroupBoxProductTabAdd
        '
        Me.GroupBoxProductTabAdd.Controls.Add(Me.BtnAddProductTabAdd)
        Me.GroupBoxProductTabAdd.Controls.Add(Me.BtnCancelProductTabAdd)
        Me.GroupBoxProductTabAdd.Controls.Add(Me.LblCategoryProductTabAdd)
        Me.GroupBoxProductTabAdd.Controls.Add(Me.LblPriceProductTabAdd)
        Me.GroupBoxProductTabAdd.Controls.Add(Me.LblNameProductTabAdd)
        Me.GroupBoxProductTabAdd.Controls.Add(Me.TextbCategoryProductTabAdd)
        Me.GroupBoxProductTabAdd.Controls.Add(Me.TextbPriceProductTabAdd)
        Me.GroupBoxProductTabAdd.Controls.Add(Me.TextbNameProductTabAdd)
        Me.GroupBoxProductTabAdd.Location = New System.Drawing.Point(112, 27)
        Me.GroupBoxProductTabAdd.Name = "GroupBoxProductTabAdd"
        Me.GroupBoxProductTabAdd.Size = New System.Drawing.Size(568, 370)
        Me.GroupBoxProductTabAdd.TabIndex = 0
        Me.GroupBoxProductTabAdd.TabStop = False
        Me.GroupBoxProductTabAdd.Text = "Nuevo Producto"
        '
        'BtnAddProductTabAdd
        '
        Me.BtnAddProductTabAdd.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.BtnAddProductTabAdd.Location = New System.Drawing.Point(304, 271)
        Me.BtnAddProductTabAdd.Name = "BtnAddProductTabAdd"
        Me.BtnAddProductTabAdd.Size = New System.Drawing.Size(113, 37)
        Me.BtnAddProductTabAdd.TabIndex = 5
        Me.BtnAddProductTabAdd.Text = "Agregar"
        Me.BtnAddProductTabAdd.UseVisualStyleBackColor = True
        '
        'BtnCancelProductTabAdd
        '
        Me.BtnCancelProductTabAdd.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.BtnCancelProductTabAdd.Location = New System.Drawing.Point(145, 271)
        Me.BtnCancelProductTabAdd.Name = "BtnCancelProductTabAdd"
        Me.BtnCancelProductTabAdd.Size = New System.Drawing.Size(113, 37)
        Me.BtnCancelProductTabAdd.TabIndex = 4
        Me.BtnCancelProductTabAdd.Text = "Cancelar"
        Me.BtnCancelProductTabAdd.UseVisualStyleBackColor = True
        '
        'LblCategoryProductTabAdd
        '
        Me.LblCategoryProductTabAdd.AutoSize = True
        Me.LblCategoryProductTabAdd.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblCategoryProductTabAdd.Location = New System.Drawing.Point(233, 186)
        Me.LblCategoryProductTabAdd.Name = "LblCategoryProductTabAdd"
        Me.LblCategoryProductTabAdd.Size = New System.Drawing.Size(99, 19)
        Me.LblCategoryProductTabAdd.TabIndex = 0
        Me.LblCategoryProductTabAdd.Text = "Categoria (*)"
        '
        'LblPriceProductTabAdd
        '
        Me.LblPriceProductTabAdd.AutoSize = True
        Me.LblPriceProductTabAdd.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblPriceProductTabAdd.Location = New System.Drawing.Point(233, 106)
        Me.LblPriceProductTabAdd.Name = "LblPriceProductTabAdd"
        Me.LblPriceProductTabAdd.Size = New System.Drawing.Size(75, 19)
        Me.LblPriceProductTabAdd.TabIndex = 0
        Me.LblPriceProductTabAdd.Text = "Precio (*)"
        '
        'LblNameProductTabAdd
        '
        Me.LblNameProductTabAdd.AutoSize = True
        Me.LblNameProductTabAdd.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblNameProductTabAdd.Location = New System.Drawing.Point(233, 34)
        Me.LblNameProductTabAdd.Name = "LblNameProductTabAdd"
        Me.LblNameProductTabAdd.Size = New System.Drawing.Size(88, 19)
        Me.LblNameProductTabAdd.TabIndex = 0
        Me.LblNameProductTabAdd.Text = "Nombre (*)"
        '
        'TextbCategoryProductTabAdd
        '
        Me.TextbCategoryProductTabAdd.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.TextbCategoryProductTabAdd.Location = New System.Drawing.Point(145, 209)
        Me.TextbCategoryProductTabAdd.Name = "TextbCategoryProductTabAdd"
        Me.TextbCategoryProductTabAdd.Size = New System.Drawing.Size(274, 26)
        Me.TextbCategoryProductTabAdd.TabIndex = 3
        '
        'TextbPriceProductTabAdd
        '
        Me.TextbPriceProductTabAdd.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.TextbPriceProductTabAdd.Location = New System.Drawing.Point(145, 129)
        Me.TextbPriceProductTabAdd.Name = "TextbPriceProductTabAdd"
        Me.TextbPriceProductTabAdd.Size = New System.Drawing.Size(274, 26)
        Me.TextbPriceProductTabAdd.TabIndex = 2
        '
        'TextbNameProductTabAdd
        '
        Me.TextbNameProductTabAdd.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.TextbNameProductTabAdd.Location = New System.Drawing.Point(145, 57)
        Me.TextbNameProductTabAdd.Name = "TextbNameProductTabAdd"
        Me.TextbNameProductTabAdd.Size = New System.Drawing.Size(274, 26)
        Me.TextbNameProductTabAdd.TabIndex = 1
        '
        'TabPageUpdateProduct
        '
        Me.TabPageUpdateProduct.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPageUpdateProduct.Location = New System.Drawing.Point(4, 22)
        Me.TabPageUpdateProduct.Name = "TabPageUpdateProduct"
        Me.TabPageUpdateProduct.Size = New System.Drawing.Size(798, 422)
        Me.TabPageUpdateProduct.TabIndex = 2
        Me.TabPageUpdateProduct.Text = "Actualizar"
        Me.TabPageUpdateProduct.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.BtnFindProductTabUpdate, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TextbFindProductTabUpdate, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBoxProductTabUpdate, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.LblTotalProductTabUpdate, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.DgvListProductTabUpdate, 0, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(798, 422)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'BtnFindProductTabUpdate
        '
        Me.BtnFindProductTabUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnFindProductTabUpdate.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.BtnFindProductTabUpdate.Location = New System.Drawing.Point(365, 38)
        Me.BtnFindProductTabUpdate.Name = "BtnFindProductTabUpdate"
        Me.BtnFindProductTabUpdate.Size = New System.Drawing.Size(68, 29)
        Me.BtnFindProductTabUpdate.TabIndex = 2
        Me.BtnFindProductTabUpdate.Text = "Buscar"
        Me.BtnFindProductTabUpdate.UseVisualStyleBackColor = True
        '
        'TextbFindProductTabUpdate
        '
        Me.TextbFindProductTabUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextbFindProductTabUpdate.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.TextbFindProductTabUpdate.Location = New System.Drawing.Point(331, 4)
        Me.TextbFindProductTabUpdate.Name = "TextbFindProductTabUpdate"
        Me.TextbFindProductTabUpdate.Size = New System.Drawing.Size(135, 26)
        Me.TextbFindProductTabUpdate.TabIndex = 1
        '
        'GroupBoxProductTabUpdate
        '
        Me.GroupBoxProductTabUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBoxProductTabUpdate.Controls.Add(Me.BtnCancelProductTabUpdate)
        Me.GroupBoxProductTabUpdate.Controls.Add(Me.BtnUpdateProductTabUpdate)
        Me.GroupBoxProductTabUpdate.Controls.Add(Me.LblCategoryProductTabUpdate)
        Me.GroupBoxProductTabUpdate.Controls.Add(Me.LblPriceProductTabUpdate)
        Me.GroupBoxProductTabUpdate.Controls.Add(Me.LblNameProductTabUpdate)
        Me.GroupBoxProductTabUpdate.Controls.Add(Me.TextbCategoryProductTabUpdate)
        Me.GroupBoxProductTabUpdate.Controls.Add(Me.TextbPriceProductTabUpdate)
        Me.GroupBoxProductTabUpdate.Controls.Add(Me.TextbNameProductTabUpdate)
        Me.GroupBoxProductTabUpdate.Location = New System.Drawing.Point(33, 253)
        Me.GroupBoxProductTabUpdate.Name = "GroupBoxProductTabUpdate"
        Me.GroupBoxProductTabUpdate.Size = New System.Drawing.Size(732, 169)
        Me.GroupBoxProductTabUpdate.TabIndex = 2
        Me.GroupBoxProductTabUpdate.TabStop = False
        Me.GroupBoxProductTabUpdate.Text = "Nuevos Datos"
        '
        'BtnCancelProductTabUpdate
        '
        Me.BtnCancelProductTabUpdate.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.BtnCancelProductTabUpdate.Location = New System.Drawing.Point(493, 52)
        Me.BtnCancelProductTabUpdate.Name = "BtnCancelProductTabUpdate"
        Me.BtnCancelProductTabUpdate.Size = New System.Drawing.Size(103, 36)
        Me.BtnCancelProductTabUpdate.TabIndex = 6
        Me.BtnCancelProductTabUpdate.Text = "Cancelar"
        Me.BtnCancelProductTabUpdate.UseVisualStyleBackColor = True
        '
        'BtnUpdateProductTabUpdate
        '
        Me.BtnUpdateProductTabUpdate.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.BtnUpdateProductTabUpdate.Location = New System.Drawing.Point(612, 52)
        Me.BtnUpdateProductTabUpdate.Name = "BtnUpdateProductTabUpdate"
        Me.BtnUpdateProductTabUpdate.Size = New System.Drawing.Size(103, 36)
        Me.BtnUpdateProductTabUpdate.TabIndex = 7
        Me.BtnUpdateProductTabUpdate.Text = "Actualizar"
        Me.BtnUpdateProductTabUpdate.UseVisualStyleBackColor = True
        '
        'LblCategoryProductTabUpdate
        '
        Me.LblCategoryProductTabUpdate.AutoSize = True
        Me.LblCategoryProductTabUpdate.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblCategoryProductTabUpdate.Location = New System.Drawing.Point(117, 106)
        Me.LblCategoryProductTabUpdate.Name = "LblCategoryProductTabUpdate"
        Me.LblCategoryProductTabUpdate.Size = New System.Drawing.Size(77, 19)
        Me.LblCategoryProductTabUpdate.TabIndex = 5
        Me.LblCategoryProductTabUpdate.Text = "Categoria"
        '
        'LblPriceProductTabUpdate
        '
        Me.LblPriceProductTabUpdate.AutoSize = True
        Me.LblPriceProductTabUpdate.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblPriceProductTabUpdate.Location = New System.Drawing.Point(117, 61)
        Me.LblPriceProductTabUpdate.Name = "LblPriceProductTabUpdate"
        Me.LblPriceProductTabUpdate.Size = New System.Drawing.Size(53, 19)
        Me.LblPriceProductTabUpdate.TabIndex = 4
        Me.LblPriceProductTabUpdate.Text = "Precio"
        '
        'LblNameProductTabUpdate
        '
        Me.LblNameProductTabUpdate.AutoSize = True
        Me.LblNameProductTabUpdate.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblNameProductTabUpdate.Location = New System.Drawing.Point(117, 19)
        Me.LblNameProductTabUpdate.Name = "LblNameProductTabUpdate"
        Me.LblNameProductTabUpdate.Size = New System.Drawing.Size(66, 19)
        Me.LblNameProductTabUpdate.TabIndex = 3
        Me.LblNameProductTabUpdate.Text = "Nombre"
        '
        'TextbCategoryProductTabUpdate
        '
        Me.TextbCategoryProductTabUpdate.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.TextbCategoryProductTabUpdate.Location = New System.Drawing.Point(204, 103)
        Me.TextbCategoryProductTabUpdate.Name = "TextbCategoryProductTabUpdate"
        Me.TextbCategoryProductTabUpdate.Size = New System.Drawing.Size(269, 26)
        Me.TextbCategoryProductTabUpdate.TabIndex = 5
        '
        'TextbPriceProductTabUpdate
        '
        Me.TextbPriceProductTabUpdate.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.TextbPriceProductTabUpdate.Location = New System.Drawing.Point(204, 58)
        Me.TextbPriceProductTabUpdate.Name = "TextbPriceProductTabUpdate"
        Me.TextbPriceProductTabUpdate.Size = New System.Drawing.Size(269, 26)
        Me.TextbPriceProductTabUpdate.TabIndex = 4
        '
        'TextbNameProductTabUpdate
        '
        Me.TextbNameProductTabUpdate.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.TextbNameProductTabUpdate.Location = New System.Drawing.Point(204, 16)
        Me.TextbNameProductTabUpdate.Name = "TextbNameProductTabUpdate"
        Me.TextbNameProductTabUpdate.Size = New System.Drawing.Size(269, 26)
        Me.TextbNameProductTabUpdate.TabIndex = 3
        '
        'LblTotalProductTabUpdate
        '
        Me.LblTotalProductTabUpdate.AutoSize = True
        Me.LblTotalProductTabUpdate.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblTotalProductTabUpdate.Location = New System.Drawing.Point(25, 220)
        Me.LblTotalProductTabUpdate.Margin = New System.Windows.Forms.Padding(25, 10, 0, 0)
        Me.LblTotalProductTabUpdate.Name = "LblTotalProductTabUpdate"
        Me.LblTotalProductTabUpdate.Size = New System.Drawing.Size(125, 19)
        Me.LblTotalProductTabUpdate.TabIndex = 3
        Me.LblTotalProductTabUpdate.Text = "Total Productos:"
        '
        'DgvListProductTabUpdate
        '
        Me.DgvListProductTabUpdate.AllowUserToAddRows = False
        Me.DgvListProductTabUpdate.AllowUserToDeleteRows = False
        Me.DgvListProductTabUpdate.AllowUserToOrderColumns = True
        Me.DgvListProductTabUpdate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvListProductTabUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvListProductTabUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListProductTabUpdate.Location = New System.Drawing.Point(3, 73)
        Me.DgvListProductTabUpdate.Name = "DgvListProductTabUpdate"
        Me.DgvListProductTabUpdate.ReadOnly = True
        Me.DgvListProductTabUpdate.Size = New System.Drawing.Size(792, 134)
        Me.DgvListProductTabUpdate.TabIndex = 4
        '
        'TabPageDeleteProduct
        '
        Me.TabPageDeleteProduct.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPageDeleteProduct.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDeleteProduct.Name = "TabPageDeleteProduct"
        Me.TabPageDeleteProduct.Size = New System.Drawing.Size(798, 422)
        Me.TabPageDeleteProduct.TabIndex = 3
        Me.TabPageDeleteProduct.Text = "Eliminar"
        Me.TabPageDeleteProduct.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.BtnFindProductTabDelete, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBoxProductTabDelete, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.TextbFindProductTabDelete, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LblTotalProductTabDelete, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.DgvListProductTabDelete, 0, 2)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(798, 422)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'BtnFindProductTabDelete
        '
        Me.BtnFindProductTabDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnFindProductTabDelete.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.BtnFindProductTabDelete.Location = New System.Drawing.Point(365, 38)
        Me.BtnFindProductTabDelete.Name = "BtnFindProductTabDelete"
        Me.BtnFindProductTabDelete.Size = New System.Drawing.Size(68, 29)
        Me.BtnFindProductTabDelete.TabIndex = 2
        Me.BtnFindProductTabDelete.Text = "Buscar"
        Me.BtnFindProductTabDelete.UseVisualStyleBackColor = True
        '
        'GroupBoxProductTabDelete
        '
        Me.GroupBoxProductTabDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBoxProductTabDelete.Controls.Add(Me.BtnDeleteProductTabDelete)
        Me.GroupBoxProductTabDelete.Controls.Add(Me.BtnCancelProductTabDelete)
        Me.GroupBoxProductTabDelete.Controls.Add(Me.LblEmpyCategoryProductTabDelete)
        Me.GroupBoxProductTabDelete.Controls.Add(Me.LblEmpyPriceProductTabDelete)
        Me.GroupBoxProductTabDelete.Controls.Add(Me.LblEmpyNameProductTabDelete)
        Me.GroupBoxProductTabDelete.Controls.Add(Me.LblCategoryProductTabDelete)
        Me.GroupBoxProductTabDelete.Controls.Add(Me.LblPriceProductTabDelete)
        Me.GroupBoxProductTabDelete.Controls.Add(Me.LblNameProductTabDelete)
        Me.GroupBoxProductTabDelete.Location = New System.Drawing.Point(33, 253)
        Me.GroupBoxProductTabDelete.Name = "GroupBoxProductTabDelete"
        Me.GroupBoxProductTabDelete.Size = New System.Drawing.Size(732, 169)
        Me.GroupBoxProductTabDelete.TabIndex = 1
        Me.GroupBoxProductTabDelete.TabStop = False
        Me.GroupBoxProductTabDelete.Text = "Producto a Eliminar"
        '
        'BtnDeleteProductTabDelete
        '
        Me.BtnDeleteProductTabDelete.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.BtnDeleteProductTabDelete.Location = New System.Drawing.Point(612, 52)
        Me.BtnDeleteProductTabDelete.Name = "BtnDeleteProductTabDelete"
        Me.BtnDeleteProductTabDelete.Size = New System.Drawing.Size(103, 36)
        Me.BtnDeleteProductTabDelete.TabIndex = 4
        Me.BtnDeleteProductTabDelete.Text = "Eliminar"
        Me.BtnDeleteProductTabDelete.UseVisualStyleBackColor = True
        '
        'BtnCancelProductTabDelete
        '
        Me.BtnCancelProductTabDelete.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.BtnCancelProductTabDelete.Location = New System.Drawing.Point(493, 52)
        Me.BtnCancelProductTabDelete.Name = "BtnCancelProductTabDelete"
        Me.BtnCancelProductTabDelete.Size = New System.Drawing.Size(103, 36)
        Me.BtnCancelProductTabDelete.TabIndex = 3
        Me.BtnCancelProductTabDelete.Text = "Cancelar"
        Me.BtnCancelProductTabDelete.UseVisualStyleBackColor = True
        '
        'LblEmpyCategoryProductTabDelete
        '
        Me.LblEmpyCategoryProductTabDelete.AutoSize = True
        Me.LblEmpyCategoryProductTabDelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblEmpyCategoryProductTabDelete.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblEmpyCategoryProductTabDelete.Location = New System.Drawing.Point(283, 103)
        Me.LblEmpyCategoryProductTabDelete.Name = "LblEmpyCategoryProductTabDelete"
        Me.LblEmpyCategoryProductTabDelete.Size = New System.Drawing.Size(2, 21)
        Me.LblEmpyCategoryProductTabDelete.TabIndex = 5
        '
        'LblEmpyPriceProductTabDelete
        '
        Me.LblEmpyPriceProductTabDelete.AutoSize = True
        Me.LblEmpyPriceProductTabDelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblEmpyPriceProductTabDelete.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblEmpyPriceProductTabDelete.Location = New System.Drawing.Point(283, 58)
        Me.LblEmpyPriceProductTabDelete.Name = "LblEmpyPriceProductTabDelete"
        Me.LblEmpyPriceProductTabDelete.Size = New System.Drawing.Size(2, 21)
        Me.LblEmpyPriceProductTabDelete.TabIndex = 4
        '
        'LblEmpyNameProductTabDelete
        '
        Me.LblEmpyNameProductTabDelete.AutoSize = True
        Me.LblEmpyNameProductTabDelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblEmpyNameProductTabDelete.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblEmpyNameProductTabDelete.Location = New System.Drawing.Point(283, 16)
        Me.LblEmpyNameProductTabDelete.Name = "LblEmpyNameProductTabDelete"
        Me.LblEmpyNameProductTabDelete.Size = New System.Drawing.Size(2, 21)
        Me.LblEmpyNameProductTabDelete.TabIndex = 3
        '
        'LblCategoryProductTabDelete
        '
        Me.LblCategoryProductTabDelete.AutoSize = True
        Me.LblCategoryProductTabDelete.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblCategoryProductTabDelete.Location = New System.Drawing.Point(117, 106)
        Me.LblCategoryProductTabDelete.Name = "LblCategoryProductTabDelete"
        Me.LblCategoryProductTabDelete.Size = New System.Drawing.Size(77, 19)
        Me.LblCategoryProductTabDelete.TabIndex = 2
        Me.LblCategoryProductTabDelete.Text = "Categoria"
        '
        'LblPriceProductTabDelete
        '
        Me.LblPriceProductTabDelete.AutoSize = True
        Me.LblPriceProductTabDelete.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblPriceProductTabDelete.Location = New System.Drawing.Point(117, 61)
        Me.LblPriceProductTabDelete.Name = "LblPriceProductTabDelete"
        Me.LblPriceProductTabDelete.Size = New System.Drawing.Size(53, 19)
        Me.LblPriceProductTabDelete.TabIndex = 1
        Me.LblPriceProductTabDelete.Text = "Precio"
        '
        'LblNameProductTabDelete
        '
        Me.LblNameProductTabDelete.AutoSize = True
        Me.LblNameProductTabDelete.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblNameProductTabDelete.Location = New System.Drawing.Point(117, 19)
        Me.LblNameProductTabDelete.Name = "LblNameProductTabDelete"
        Me.LblNameProductTabDelete.Size = New System.Drawing.Size(66, 19)
        Me.LblNameProductTabDelete.TabIndex = 0
        Me.LblNameProductTabDelete.Text = "Nombre"
        '
        'TextbFindProductTabDelete
        '
        Me.TextbFindProductTabDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextbFindProductTabDelete.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.TextbFindProductTabDelete.Location = New System.Drawing.Point(331, 4)
        Me.TextbFindProductTabDelete.Name = "TextbFindProductTabDelete"
        Me.TextbFindProductTabDelete.Size = New System.Drawing.Size(135, 26)
        Me.TextbFindProductTabDelete.TabIndex = 1
        '
        'LblTotalProductTabDelete
        '
        Me.LblTotalProductTabDelete.AutoSize = True
        Me.LblTotalProductTabDelete.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblTotalProductTabDelete.Location = New System.Drawing.Point(25, 220)
        Me.LblTotalProductTabDelete.Margin = New System.Windows.Forms.Padding(25, 10, 0, 0)
        Me.LblTotalProductTabDelete.Name = "LblTotalProductTabDelete"
        Me.LblTotalProductTabDelete.Size = New System.Drawing.Size(125, 19)
        Me.LblTotalProductTabDelete.TabIndex = 3
        Me.LblTotalProductTabDelete.Text = "Total Productos:"
        '
        'DgvListProductTabDelete
        '
        Me.DgvListProductTabDelete.AllowUserToAddRows = False
        Me.DgvListProductTabDelete.AllowUserToDeleteRows = False
        Me.DgvListProductTabDelete.AllowUserToOrderColumns = True
        Me.DgvListProductTabDelete.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvListProductTabDelete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvListProductTabDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListProductTabDelete.Location = New System.Drawing.Point(3, 73)
        Me.DgvListProductTabDelete.Name = "DgvListProductTabDelete"
        Me.DgvListProductTabDelete.ReadOnly = True
        Me.DgvListProductTabDelete.Size = New System.Drawing.Size(792, 134)
        Me.DgvListProductTabDelete.TabIndex = 4
        '
        'FrmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabContrlProduct)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmProducto"
        Me.Text = "Productos"
        Me.TabContrlProduct.ResumeLayout(False)
        Me.TabPageListProduct.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DgvListProductTabList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageAddProduct.ResumeLayout(False)
        Me.GroupBoxProductTabAdd.ResumeLayout(False)
        Me.GroupBoxProductTabAdd.PerformLayout()
        Me.TabPageUpdateProduct.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBoxProductTabUpdate.ResumeLayout(False)
        Me.GroupBoxProductTabUpdate.PerformLayout()
        CType(Me.DgvListProductTabUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageDeleteProduct.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBoxProductTabDelete.ResumeLayout(False)
        Me.GroupBoxProductTabDelete.PerformLayout()
        CType(Me.DgvListProductTabDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabContrlProduct As TabControl
    Friend WithEvents TabPageListProduct As TabPage
    Friend WithEvents TabPageAddProduct As TabPage
    Friend WithEvents TabPageUpdateProduct As TabPage
    Friend WithEvents TabPageDeleteProduct As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnFindProductTabProduct As Button
    Friend WithEvents TextbFindProductTabList As TextBox
    Friend WithEvents DgvListProductTabList As DataGridView
    Friend WithEvents LblTotalProductTabList As Label
    Friend WithEvents GroupBoxProductTabAdd As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnAddProductTabAdd As Button
    Friend WithEvents BtnCancelProductTabAdd As Button
    Friend WithEvents LblCategoryProductTabAdd As Label
    Friend WithEvents LblPriceProductTabAdd As Label
    Friend WithEvents LblNameProductTabAdd As Label
    Friend WithEvents TextbCategoryProductTabAdd As TextBox
    Friend WithEvents TextbPriceProductTabAdd As TextBox
    Friend WithEvents TextbNameProductTabAdd As TextBox
    Friend WithEvents BtnFindProductTabUpdate As Button
    Friend WithEvents TextbFindProductTabUpdate As TextBox
    Friend WithEvents GroupBoxProductTabUpdate As GroupBox
    Friend WithEvents BtnCancelProductTabUpdate As Button
    Friend WithEvents BtnUpdateProductTabUpdate As Button
    Friend WithEvents LblCategoryProductTabUpdate As Label
    Friend WithEvents LblPriceProductTabUpdate As Label
    Friend WithEvents LblNameProductTabUpdate As Label
    Friend WithEvents TextbCategoryProductTabUpdate As TextBox
    Friend WithEvents TextbPriceProductTabUpdate As TextBox
    Friend WithEvents TextbNameProductTabUpdate As TextBox
    Friend WithEvents LblTotalProductTabUpdate As Label
    Friend WithEvents DgvListProductTabUpdate As DataGridView
    Friend WithEvents BtnFindProductTabDelete As Button
    Friend WithEvents GroupBoxProductTabDelete As GroupBox
    Friend WithEvents LblNameProductTabDelete As Label
    Friend WithEvents TextbFindProductTabDelete As TextBox
    Friend WithEvents LblTotalProductTabDelete As Label
    Friend WithEvents BtnDeleteProductTabDelete As Button
    Friend WithEvents BtnCancelProductTabDelete As Button
    Friend WithEvents LblEmpyCategoryProductTabDelete As Label
    Friend WithEvents LblEmpyPriceProductTabDelete As Label
    Friend WithEvents LblEmpyNameProductTabDelete As Label
    Friend WithEvents LblCategoryProductTabDelete As Label
    Friend WithEvents LblPriceProductTabDelete As Label
    Friend WithEvents DgvListProductTabDelete As DataGridView
End Class
