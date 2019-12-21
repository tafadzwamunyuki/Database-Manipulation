<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSearch))
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtUID = New System.Windows.Forms.TextBox()
        Me.txtUFname = New System.Windows.Forms.TextBox()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.txtUSurname = New System.Windows.Forms.TextBox()
        Me.txtUEmail = New System.Windows.Forms.TextBox()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblUserFName = New System.Windows.Forms.Label()
        Me.lblMname = New System.Windows.Forms.Label()
        Me.lblUserLastName = New System.Windows.Forms.Label()
        Me.lblUserEmail = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(30, 208)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtUID
        '
        Me.txtUID.Location = New System.Drawing.Point(130, 26)
        Me.txtUID.Name = "txtUID"
        Me.txtUID.Size = New System.Drawing.Size(193, 20)
        Me.txtUID.TabIndex = 1
        '
        'txtUFname
        '
        Me.txtUFname.Location = New System.Drawing.Point(130, 60)
        Me.txtUFname.Name = "txtUFname"
        Me.txtUFname.Size = New System.Drawing.Size(193, 20)
        Me.txtUFname.TabIndex = 2
        '
        'txtMName
        '
        Me.txtMName.Location = New System.Drawing.Point(130, 93)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(193, 20)
        Me.txtMName.TabIndex = 3
        '
        'txtUSurname
        '
        Me.txtUSurname.Location = New System.Drawing.Point(130, 131)
        Me.txtUSurname.Name = "txtUSurname"
        Me.txtUSurname.Size = New System.Drawing.Size(193, 20)
        Me.txtUSurname.TabIndex = 4
        '
        'txtUEmail
        '
        Me.txtUEmail.Location = New System.Drawing.Point(130, 173)
        Me.txtUEmail.Name = "txtUEmail"
        Me.txtUEmail.Size = New System.Drawing.Size(193, 20)
        Me.txtUEmail.TabIndex = 5
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Location = New System.Drawing.Point(27, 33)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(43, 13)
        Me.lblUserID.TabIndex = 6
        Me.lblUserID.Text = "User ID"
        '
        'lblUserFName
        '
        Me.lblUserFName.AutoSize = True
        Me.lblUserFName.Location = New System.Drawing.Point(27, 67)
        Me.lblUserFName.Name = "lblUserFName"
        Me.lblUserFName.Size = New System.Drawing.Size(82, 13)
        Me.lblUserFName.TabIndex = 7
        Me.lblUserFName.Text = "User First Name"
        '
        'lblMname
        '
        Me.lblMname.AutoSize = True
        Me.lblMname.Location = New System.Drawing.Point(27, 100)
        Me.lblMname.Name = "lblMname"
        Me.lblMname.Size = New System.Drawing.Size(94, 13)
        Me.lblMname.TabIndex = 8
        Me.lblMname.Text = "User Middle Name"
        '
        'lblUserLastName
        '
        Me.lblUserLastName.AutoSize = True
        Me.lblUserLastName.Location = New System.Drawing.Point(27, 138)
        Me.lblUserLastName.Name = "lblUserLastName"
        Me.lblUserLastName.Size = New System.Drawing.Size(74, 13)
        Me.lblUserLastName.TabIndex = 9
        Me.lblUserLastName.Text = "User Surname"
        '
        'lblUserEmail
        '
        Me.lblUserEmail.AutoSize = True
        Me.lblUserEmail.Location = New System.Drawing.Point(27, 180)
        Me.lblUserEmail.Name = "lblUserEmail"
        Me.lblUserEmail.Size = New System.Drawing.Size(57, 13)
        Me.lblUserEmail.TabIndex = 10
        Me.lblUserEmail.Text = "User Email"
        '
        'FrmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 255)
        Me.Controls.Add(Me.lblUserEmail)
        Me.Controls.Add(Me.lblUserLastName)
        Me.Controls.Add(Me.lblMname)
        Me.Controls.Add(Me.lblUserFName)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.txtUEmail)
        Me.Controls.Add(Me.txtUSurname)
        Me.Controls.Add(Me.txtMName)
        Me.Controls.Add(Me.txtUFname)
        Me.Controls.Add(Me.txtUID)
        Me.Controls.Add(Me.btnSearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSearch"
        Me.Text = "Search Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents txtUID As TextBox
    Friend WithEvents txtUFname As TextBox
    Friend WithEvents txtMName As TextBox
    Friend WithEvents txtUSurname As TextBox
    Friend WithEvents txtUEmail As TextBox
    Friend WithEvents lblUserID As Label
    Friend WithEvents lblUserFName As Label
    Friend WithEvents lblMname As Label
    Friend WithEvents lblUserLastName As Label
    Friend WithEvents lblUserEmail As Label
End Class
