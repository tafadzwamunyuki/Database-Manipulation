<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInsert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInsert))
        Me.lblInsert = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.lblMname = New System.Windows.Forms.Label()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdateData = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInsert
        '
        Me.lblInsert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInsert.Location = New System.Drawing.Point(12, 201)
        Me.lblInsert.Name = "lblInsert"
        Me.lblInsert.Size = New System.Drawing.Size(75, 23)
        Me.lblInsert.TabIndex = 0
        Me.lblInsert.Text = "Enter Data"
        Me.lblInsert.UseVisualStyleBackColor = True
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(12, 26)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(18, 13)
        Me.lblId.TabIndex = 1
        Me.lblId.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(107, 19)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(251, 20)
        Me.txtID.TabIndex = 2
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(107, 57)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(251, 20)
        Me.txtFname.TabIndex = 3
        '
        'txtMname
        '
        Me.txtMname.Location = New System.Drawing.Point(107, 92)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(251, 20)
        Me.txtMname.TabIndex = 4
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(107, 127)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(251, 20)
        Me.txtLname.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(107, 162)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(251, 20)
        Me.txtEmail.TabIndex = 6
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Location = New System.Drawing.Point(9, 64)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(57, 13)
        Me.lblFname.TabIndex = 7
        Me.lblFname.Text = "First Name"
        '
        'lblMname
        '
        Me.lblMname.AutoSize = True
        Me.lblMname.Location = New System.Drawing.Point(9, 99)
        Me.lblMname.Name = "lblMname"
        Me.lblMname.Size = New System.Drawing.Size(69, 13)
        Me.lblMname.TabIndex = 8
        Me.lblMname.Text = "Middle Name"
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Location = New System.Drawing.Point(12, 134)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(58, 13)
        Me.lblLname.TabIndex = 9
        Me.lblLname.Text = "Last Name"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(12, 169)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(36, 13)
        Me.lblemail.TabIndex = 10
        Me.lblemail.Text = "E-Mail"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Location = New System.Drawing.Point(107, 201)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "Search Data"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Location = New System.Drawing.Point(191, 201)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete Data"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdateData
        '
        Me.btnUpdateData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateData.Location = New System.Drawing.Point(283, 201)
        Me.btnUpdateData.Name = "btnUpdateData"
        Me.btnUpdateData.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateData.TabIndex = 13
        Me.btnUpdateData.Text = "Update Record"
        Me.btnUpdateData.UseVisualStyleBackColor = True
        '
        'FrmInsert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 232)
        Me.Controls.Add(Me.btnUpdateData)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lblLname)
        Me.Controls.Add(Me.lblMname)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtMname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblInsert)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInsert"
        Me.Text = "Enter User Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInsert As Button
    Friend WithEvents lblId As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblFname As Label
    Friend WithEvents lblMname As Label
    Friend WithEvents lblLname As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdateData As Button
End Class
