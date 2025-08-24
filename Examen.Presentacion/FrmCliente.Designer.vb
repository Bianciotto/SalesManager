<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCliente
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
        Me.TabctrlClient = New System.Windows.Forms.TabControl()
        Me.TabPageViewClient = New System.Windows.Forms.TabPage()
        Me.BtnFindClientTabList = New System.Windows.Forms.Button()
        Me.TextbFindClientTabList = New System.Windows.Forms.TextBox()
        Me.LblTotalClientTabList = New System.Windows.Forms.Label()
        Me.DgvListClientTabList = New System.Windows.Forms.DataGridView()
        Me.TabPageAddClient = New System.Windows.Forms.TabPage()
        Me.GroupBoxTabAdd = New System.Windows.Forms.GroupBox()
        Me.LblClientClientTabAdd = New System.Windows.Forms.Label()
        Me.BtnCancelAddClient = New System.Windows.Forms.Button()
        Me.LblPhoneClientTabAdd = New System.Windows.Forms.Label()
        Me.BtnAddClient = New System.Windows.Forms.Button()
        Me.TextbClientClientTabAdd = New System.Windows.Forms.TextBox()
        Me.TextbMailClientTabAdd = New System.Windows.Forms.TextBox()
        Me.TextbPhoneClientTabAdd = New System.Windows.Forms.TextBox()
        Me.LblMailClientTabAdd = New System.Windows.Forms.Label()
        Me.TabpageUpdateClient = New System.Windows.Forms.TabPage()
        Me.GroupBoxTabUpdate = New System.Windows.Forms.GroupBox()
        Me.BtnCancelClientTabUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnUpdateClientTabUpdate = New System.Windows.Forms.Button()
        Me.TextbMailClientTabUpdate = New System.Windows.Forms.TextBox()
        Me.TextbClientClientTabUpdate = New System.Windows.Forms.TextBox()
        Me.TextbPhoneClientTabUpdate = New System.Windows.Forms.TextBox()
        Me.LblTotalClientTabUpdate = New System.Windows.Forms.Label()
        Me.DgvListClientTabUpdate = New System.Windows.Forms.DataGridView()
        Me.BtnFindClientTabUpdate = New System.Windows.Forms.Button()
        Me.TextbFindClientTabUpdate = New System.Windows.Forms.TextBox()
        Me.TabPageDeleteClient = New System.Windows.Forms.TabPage()
        Me.TabctrlClient.SuspendLayout()
        Me.TabPageViewClient.SuspendLayout()
        CType(Me.DgvListClientTabList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageAddClient.SuspendLayout()
        Me.GroupBoxTabAdd.SuspendLayout()
        Me.TabpageUpdateClient.SuspendLayout()
        Me.GroupBoxTabUpdate.SuspendLayout()
        CType(Me.DgvListClientTabUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabctrlClient
        '
        Me.TabctrlClient.Controls.Add(Me.TabPageViewClient)
        Me.TabctrlClient.Controls.Add(Me.TabPageAddClient)
        Me.TabctrlClient.Controls.Add(Me.TabpageUpdateClient)
        Me.TabctrlClient.Controls.Add(Me.TabPageDeleteClient)
        Me.TabctrlClient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabctrlClient.Location = New System.Drawing.Point(0, 0)
        Me.TabctrlClient.Name = "TabctrlClient"
        Me.TabctrlClient.SelectedIndex = 0
        Me.TabctrlClient.Size = New System.Drawing.Size(800, 450)
        Me.TabctrlClient.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabctrlClient.TabIndex = 0
        '
        'TabPageViewClient
        '
        Me.TabPageViewClient.Controls.Add(Me.BtnFindClientTabList)
        Me.TabPageViewClient.Controls.Add(Me.TextbFindClientTabList)
        Me.TabPageViewClient.Controls.Add(Me.LblTotalClientTabList)
        Me.TabPageViewClient.Controls.Add(Me.DgvListClientTabList)
        Me.TabPageViewClient.Location = New System.Drawing.Point(4, 22)
        Me.TabPageViewClient.Name = "TabPageViewClient"
        Me.TabPageViewClient.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageViewClient.Size = New System.Drawing.Size(792, 424)
        Me.TabPageViewClient.TabIndex = 0
        Me.TabPageViewClient.Text = "Listado"
        Me.TabPageViewClient.UseVisualStyleBackColor = True
        '
        'BtnFindClientTabList
        '
        Me.BtnFindClientTabList.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.BtnFindClientTabList.Location = New System.Drawing.Point(266, 14)
        Me.BtnFindClientTabList.Name = "BtnFindClientTabList"
        Me.BtnFindClientTabList.Size = New System.Drawing.Size(77, 31)
        Me.BtnFindClientTabList.TabIndex = 3
        Me.BtnFindClientTabList.Text = "Busar"
        Me.BtnFindClientTabList.UseVisualStyleBackColor = True
        '
        'TextbFindClientTabList
        '
        Me.TextbFindClientTabList.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.TextbFindClientTabList.Location = New System.Drawing.Point(7, 17)
        Me.TextbFindClientTabList.Name = "TextbFindClientTabList"
        Me.TextbFindClientTabList.Size = New System.Drawing.Size(253, 26)
        Me.TextbFindClientTabList.TabIndex = 2
        Me.TextbFindClientTabList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblTotalClientTabList
        '
        Me.LblTotalClientTabList.AutoSize = True
        Me.LblTotalClientTabList.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblTotalClientTabList.Location = New System.Drawing.Point(7, 356)
        Me.LblTotalClientTabList.Name = "LblTotalClientTabList"
        Me.LblTotalClientTabList.Size = New System.Drawing.Size(55, 19)
        Me.LblTotalClientTabList.TabIndex = 1
        Me.LblTotalClientTabList.Text = "Total: "
        '
        'DgvListClientTabList
        '
        Me.DgvListClientTabList.AllowUserToAddRows = False
        Me.DgvListClientTabList.AllowUserToDeleteRows = False
        Me.DgvListClientTabList.AllowUserToOrderColumns = True
        Me.DgvListClientTabList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvListClientTabList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListClientTabList.Location = New System.Drawing.Point(5, 51)
        Me.DgvListClientTabList.Name = "DgvListClientTabList"
        Me.DgvListClientTabList.ReadOnly = True
        Me.DgvListClientTabList.Size = New System.Drawing.Size(780, 276)
        Me.DgvListClientTabList.TabIndex = 0
        '
        'TabPageAddClient
        '
        Me.TabPageAddClient.Controls.Add(Me.GroupBoxTabAdd)
        Me.TabPageAddClient.Location = New System.Drawing.Point(4, 22)
        Me.TabPageAddClient.Name = "TabPageAddClient"
        Me.TabPageAddClient.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAddClient.Size = New System.Drawing.Size(792, 424)
        Me.TabPageAddClient.TabIndex = 1
        Me.TabPageAddClient.Text = "Agregar"
        Me.TabPageAddClient.UseVisualStyleBackColor = True
        '
        'GroupBoxTabAdd
        '
        Me.GroupBoxTabAdd.Controls.Add(Me.LblClientClientTabAdd)
        Me.GroupBoxTabAdd.Controls.Add(Me.BtnCancelAddClient)
        Me.GroupBoxTabAdd.Controls.Add(Me.LblPhoneClientTabAdd)
        Me.GroupBoxTabAdd.Controls.Add(Me.BtnAddClient)
        Me.GroupBoxTabAdd.Controls.Add(Me.TextbClientClientTabAdd)
        Me.GroupBoxTabAdd.Controls.Add(Me.TextbMailClientTabAdd)
        Me.GroupBoxTabAdd.Controls.Add(Me.TextbPhoneClientTabAdd)
        Me.GroupBoxTabAdd.Controls.Add(Me.LblMailClientTabAdd)
        Me.GroupBoxTabAdd.Location = New System.Drawing.Point(112, 36)
        Me.GroupBoxTabAdd.Name = "GroupBoxTabAdd"
        Me.GroupBoxTabAdd.Size = New System.Drawing.Size(573, 346)
        Me.GroupBoxTabAdd.TabIndex = 8
        Me.GroupBoxTabAdd.TabStop = False
        Me.GroupBoxTabAdd.Text = "Nuevo Cliente"
        '
        'LblClientClientTabAdd
        '
        Me.LblClientClientTabAdd.AutoSize = True
        Me.LblClientClientTabAdd.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClientClientTabAdd.Location = New System.Drawing.Point(233, 35)
        Me.LblClientClientTabAdd.Name = "LblClientClientTabAdd"
        Me.LblClientClientTabAdd.Size = New System.Drawing.Size(80, 19)
        Me.LblClientClientTabAdd.TabIndex = 0
        Me.LblClientClientTabAdd.Tag = ""
        Me.LblClientClientTabAdd.Text = "Cliente (*)"
        '
        'BtnCancelAddClient
        '
        Me.BtnCancelAddClient.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.BtnCancelAddClient.Location = New System.Drawing.Point(304, 271)
        Me.BtnCancelAddClient.Name = "BtnCancelAddClient"
        Me.BtnCancelAddClient.Size = New System.Drawing.Size(113, 37)
        Me.BtnCancelAddClient.TabIndex = 7
        Me.BtnCancelAddClient.Text = "Cancelar"
        Me.BtnCancelAddClient.UseVisualStyleBackColor = True
        '
        'LblPhoneClientTabAdd
        '
        Me.LblPhoneClientTabAdd.AutoSize = True
        Me.LblPhoneClientTabAdd.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblPhoneClientTabAdd.Location = New System.Drawing.Point(233, 107)
        Me.LblPhoneClientTabAdd.Name = "LblPhoneClientTabAdd"
        Me.LblPhoneClientTabAdd.Size = New System.Drawing.Size(92, 19)
        Me.LblPhoneClientTabAdd.TabIndex = 1
        Me.LblPhoneClientTabAdd.Text = "Telefono (*)"
        '
        'BtnAddClient
        '
        Me.BtnAddClient.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.BtnAddClient.Location = New System.Drawing.Point(145, 271)
        Me.BtnAddClient.Name = "BtnAddClient"
        Me.BtnAddClient.Size = New System.Drawing.Size(113, 37)
        Me.BtnAddClient.TabIndex = 6
        Me.BtnAddClient.Text = "Agregar"
        Me.BtnAddClient.UseVisualStyleBackColor = True
        '
        'TextbClientClientTabAdd
        '
        Me.TextbClientClientTabAdd.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.TextbClientClientTabAdd.Location = New System.Drawing.Point(145, 57)
        Me.TextbClientClientTabAdd.Name = "TextbClientClientTabAdd"
        Me.TextbClientClientTabAdd.Size = New System.Drawing.Size(274, 26)
        Me.TextbClientClientTabAdd.TabIndex = 2
        '
        'TextbMailClientTabAdd
        '
        Me.TextbMailClientTabAdd.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.TextbMailClientTabAdd.Location = New System.Drawing.Point(145, 209)
        Me.TextbMailClientTabAdd.Name = "TextbMailClientTabAdd"
        Me.TextbMailClientTabAdd.Size = New System.Drawing.Size(272, 26)
        Me.TextbMailClientTabAdd.TabIndex = 5
        '
        'TextbPhoneClientTabAdd
        '
        Me.TextbPhoneClientTabAdd.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.TextbPhoneClientTabAdd.Location = New System.Drawing.Point(145, 129)
        Me.TextbPhoneClientTabAdd.Name = "TextbPhoneClientTabAdd"
        Me.TextbPhoneClientTabAdd.Size = New System.Drawing.Size(272, 26)
        Me.TextbPhoneClientTabAdd.TabIndex = 3
        '
        'LblMailClientTabAdd
        '
        Me.LblMailClientTabAdd.AutoSize = True
        Me.LblMailClientTabAdd.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblMailClientTabAdd.Location = New System.Drawing.Point(233, 187)
        Me.LblMailClientTabAdd.Name = "LblMailClientTabAdd"
        Me.LblMailClientTabAdd.Size = New System.Drawing.Size(80, 19)
        Me.LblMailClientTabAdd.TabIndex = 4
        Me.LblMailClientTabAdd.Text = "Correo (*)"
        '
        'TabpageUpdateClient
        '
        Me.TabpageUpdateClient.Controls.Add(Me.GroupBoxTabUpdate)
        Me.TabpageUpdateClient.Controls.Add(Me.LblTotalClientTabUpdate)
        Me.TabpageUpdateClient.Controls.Add(Me.DgvListClientTabUpdate)
        Me.TabpageUpdateClient.Controls.Add(Me.BtnFindClientTabUpdate)
        Me.TabpageUpdateClient.Controls.Add(Me.TextbFindClientTabUpdate)
        Me.TabpageUpdateClient.Location = New System.Drawing.Point(4, 22)
        Me.TabpageUpdateClient.Name = "TabpageUpdateClient"
        Me.TabpageUpdateClient.Size = New System.Drawing.Size(792, 424)
        Me.TabpageUpdateClient.TabIndex = 2
        Me.TabpageUpdateClient.Text = "Actualizar"
        Me.TabpageUpdateClient.UseVisualStyleBackColor = True
        '
        'GroupBoxTabUpdate
        '
        Me.GroupBoxTabUpdate.Controls.Add(Me.BtnCancelClientTabUpdate)
        Me.GroupBoxTabUpdate.Controls.Add(Me.Label1)
        Me.GroupBoxTabUpdate.Controls.Add(Me.Label2)
        Me.GroupBoxTabUpdate.Controls.Add(Me.Label3)
        Me.GroupBoxTabUpdate.Controls.Add(Me.BtnUpdateClientTabUpdate)
        Me.GroupBoxTabUpdate.Controls.Add(Me.TextbMailClientTabUpdate)
        Me.GroupBoxTabUpdate.Controls.Add(Me.TextbClientClientTabUpdate)
        Me.GroupBoxTabUpdate.Controls.Add(Me.TextbPhoneClientTabUpdate)
        Me.GroupBoxTabUpdate.Location = New System.Drawing.Point(116, 221)
        Me.GroupBoxTabUpdate.Name = "GroupBoxTabUpdate"
        Me.GroupBoxTabUpdate.Size = New System.Drawing.Size(587, 136)
        Me.GroupBoxTabUpdate.TabIndex = 11
        Me.GroupBoxTabUpdate.TabStop = False
        Me.GroupBoxTabUpdate.Text = "Nuevos Datos"
        '
        'BtnCancelClientTabUpdate
        '
        Me.BtnCancelClientTabUpdate.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.BtnCancelClientTabUpdate.Location = New System.Drawing.Point(349, 65)
        Me.BtnCancelClientTabUpdate.Name = "BtnCancelClientTabUpdate"
        Me.BtnCancelClientTabUpdate.Size = New System.Drawing.Size(103, 36)
        Me.BtnCancelClientTabUpdate.TabIndex = 9
        Me.BtnCancelClientTabUpdate.Text = "Cancelar"
        Me.BtnCancelClientTabUpdate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(117, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(117, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(117, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Correo"
        '
        'BtnUpdateClientTabUpdate
        '
        Me.BtnUpdateClientTabUpdate.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.BtnUpdateClientTabUpdate.Location = New System.Drawing.Point(349, 19)
        Me.BtnUpdateClientTabUpdate.Name = "BtnUpdateClientTabUpdate"
        Me.BtnUpdateClientTabUpdate.Size = New System.Drawing.Size(103, 36)
        Me.BtnUpdateClientTabUpdate.TabIndex = 7
        Me.BtnUpdateClientTabUpdate.Text = "Actualizar"
        Me.BtnUpdateClientTabUpdate.UseVisualStyleBackColor = True
        '
        'TextbMailClientTabUpdate
        '
        Me.TextbMailClientTabUpdate.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.TextbMailClientTabUpdate.Location = New System.Drawing.Point(204, 79)
        Me.TextbMailClientTabUpdate.Name = "TextbMailClientTabUpdate"
        Me.TextbMailClientTabUpdate.Size = New System.Drawing.Size(100, 26)
        Me.TextbMailClientTabUpdate.TabIndex = 8
        '
        'TextbClientClientTabUpdate
        '
        Me.TextbClientClientTabUpdate.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.TextbClientClientTabUpdate.Location = New System.Drawing.Point(204, 16)
        Me.TextbClientClientTabUpdate.Name = "TextbClientClientTabUpdate"
        Me.TextbClientClientTabUpdate.Size = New System.Drawing.Size(100, 26)
        Me.TextbClientClientTabUpdate.TabIndex = 1
        '
        'TextbPhoneClientTabUpdate
        '
        Me.TextbPhoneClientTabUpdate.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.TextbPhoneClientTabUpdate.Location = New System.Drawing.Point(204, 46)
        Me.TextbPhoneClientTabUpdate.Name = "TextbPhoneClientTabUpdate"
        Me.TextbPhoneClientTabUpdate.Size = New System.Drawing.Size(100, 26)
        Me.TextbPhoneClientTabUpdate.TabIndex = 2
        '
        'LblTotalClientTabUpdate
        '
        Me.LblTotalClientTabUpdate.AutoSize = True
        Me.LblTotalClientTabUpdate.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.LblTotalClientTabUpdate.Location = New System.Drawing.Point(7, 174)
        Me.LblTotalClientTabUpdate.Name = "LblTotalClientTabUpdate"
        Me.LblTotalClientTabUpdate.Size = New System.Drawing.Size(55, 19)
        Me.LblTotalClientTabUpdate.TabIndex = 10
        Me.LblTotalClientTabUpdate.Text = "Total: "
        '
        'DgvListClientTabUpdate
        '
        Me.DgvListClientTabUpdate.AllowUserToAddRows = False
        Me.DgvListClientTabUpdate.AllowUserToDeleteRows = False
        Me.DgvListClientTabUpdate.AllowUserToOrderColumns = True
        Me.DgvListClientTabUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvListClientTabUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListClientTabUpdate.Location = New System.Drawing.Point(7, 51)
        Me.DgvListClientTabUpdate.Name = "DgvListClientTabUpdate"
        Me.DgvListClientTabUpdate.ReadOnly = True
        Me.DgvListClientTabUpdate.Size = New System.Drawing.Size(780, 120)
        Me.DgvListClientTabUpdate.TabIndex = 9
        '
        'BtnFindClientTabUpdate
        '
        Me.BtnFindClientTabUpdate.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.BtnFindClientTabUpdate.Location = New System.Drawing.Point(116, 12)
        Me.BtnFindClientTabUpdate.Name = "BtnFindClientTabUpdate"
        Me.BtnFindClientTabUpdate.Size = New System.Drawing.Size(68, 33)
        Me.BtnFindClientTabUpdate.TabIndex = 6
        Me.BtnFindClientTabUpdate.Text = "Buscar"
        Me.BtnFindClientTabUpdate.UseVisualStyleBackColor = True
        '
        'TextbFindClientTabUpdate
        '
        Me.TextbFindClientTabUpdate.Font = New System.Drawing.Font("Calisto MT", 12.0!)
        Me.TextbFindClientTabUpdate.Location = New System.Drawing.Point(10, 16)
        Me.TextbFindClientTabUpdate.Name = "TextbFindClientTabUpdate"
        Me.TextbFindClientTabUpdate.Size = New System.Drawing.Size(100, 26)
        Me.TextbFindClientTabUpdate.TabIndex = 0
        '
        'TabPageDeleteClient
        '
        Me.TabPageDeleteClient.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDeleteClient.Name = "TabPageDeleteClient"
        Me.TabPageDeleteClient.Size = New System.Drawing.Size(792, 424)
        Me.TabPageDeleteClient.TabIndex = 3
        Me.TabPageDeleteClient.Text = "Eliminar"
        Me.TabPageDeleteClient.UseVisualStyleBackColor = True
        '
        'FrmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabctrlClient)
        Me.Name = "FrmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabctrlClient.ResumeLayout(False)
        Me.TabPageViewClient.ResumeLayout(False)
        Me.TabPageViewClient.PerformLayout()
        CType(Me.DgvListClientTabList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageAddClient.ResumeLayout(False)
        Me.GroupBoxTabAdd.ResumeLayout(False)
        Me.GroupBoxTabAdd.PerformLayout()
        Me.TabpageUpdateClient.ResumeLayout(False)
        Me.TabpageUpdateClient.PerformLayout()
        Me.GroupBoxTabUpdate.ResumeLayout(False)
        Me.GroupBoxTabUpdate.PerformLayout()
        CType(Me.DgvListClientTabUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabctrlClient As TabControl
    Friend WithEvents TabPageViewClient As TabPage
    Friend WithEvents TabPageAddClient As TabPage
    Friend WithEvents DgvListClientTabList As DataGridView
    Friend WithEvents LblTotalClientTabList As Label
    Friend WithEvents BtnFindClientTabList As Button
    Friend WithEvents TextbFindClientTabList As TextBox
    Friend WithEvents BtnCancelAddClient As Button
    Friend WithEvents BtnAddClient As Button
    Friend WithEvents TextbMailClientTabAdd As TextBox
    Friend WithEvents LblMailClientTabAdd As Label
    Friend WithEvents TextbPhoneClientTabAdd As TextBox
    Friend WithEvents TextbClientClientTabAdd As TextBox
    Friend WithEvents LblPhoneClientTabAdd As Label
    Friend WithEvents LblClientClientTabAdd As Label
    Friend WithEvents TabpageUpdateClient As TabPage
    Friend WithEvents TabPageDeleteClient As TabPage
    Friend WithEvents TextbPhoneClientTabUpdate As TextBox
    Friend WithEvents TextbClientClientTabUpdate As TextBox
    Friend WithEvents TextbFindClientTabUpdate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnUpdateClientTabUpdate As Button
    Friend WithEvents BtnFindClientTabUpdate As Button
    Friend WithEvents DgvListClientTabUpdate As DataGridView
    Friend WithEvents TextbMailClientTabUpdate As TextBox
    Friend WithEvents LblTotalClientTabUpdate As Label
    Friend WithEvents GroupBoxTabUpdate As GroupBox
    Friend WithEvents BtnCancelClientTabUpdate As Button
    Friend WithEvents GroupBoxTabAdd As GroupBox
End Class
