<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUpdate))
        Me.lblFname = New System.Windows.Forms.Label()
        Me.lblUpMname = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblUpId = New System.Windows.Forms.Label()
        Me.lblUpEmail = New System.Windows.Forms.Label()
        Me.txtupid = New System.Windows.Forms.TextBox()
        Me.txtuplname = New System.Windows.Forms.TextBox()
        Me.txtUpfname = New System.Windows.Forms.TextBox()
        Me.txtupmname = New System.Windows.Forms.TextBox()
        Me.txtupemail = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Location = New System.Drawing.Point(12, 52)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(57, 13)
        Me.lblFname.TabIndex = 0
        Me.lblFname.Text = "First Name"
        '
        'lblUpMname
        '
        Me.lblUpMname.AutoSize = True
        Me.lblUpMname.Location = New System.Drawing.Point(12, 89)
        Me.lblUpMname.Name = "lblUpMname"
        Me.lblUpMname.Size = New System.Drawing.Size(69, 13)
        Me.lblUpMname.TabIndex = 1
        Me.lblUpMname.Text = "Middle Name"
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Location = New System.Drawing.Point(12, 126)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(58, 13)
        Me.lblLName.TabIndex = 2
        Me.lblLName.Text = "Last Name"
        '
        'lblUpId
        '
        Me.lblUpId.AutoSize = True
        Me.lblUpId.Location = New System.Drawing.Point(12, 21)
        Me.lblUpId.Name = "lblUpId"
        Me.lblUpId.Size = New System.Drawing.Size(18, 13)
        Me.lblUpId.TabIndex = 3
        Me.lblUpId.Text = "ID"
        '
        'lblUpEmail
        '
        Me.lblUpEmail.AutoSize = True
        Me.lblUpEmail.Location = New System.Drawing.Point(12, 159)
        Me.lblUpEmail.Name = "lblUpEmail"
        Me.lblUpEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblUpEmail.TabIndex = 4
        Me.lblUpEmail.Text = "E-mail"
        '
        'txtupid
        '
        Me.txtupid.Location = New System.Drawing.Point(132, 14)
        Me.txtupid.Name = "txtupid"
        Me.txtupid.Size = New System.Drawing.Size(145, 20)
        Me.txtupid.TabIndex = 5
        '
        'txtuplname
        '
        Me.txtuplname.Location = New System.Drawing.Point(132, 123)
        Me.txtuplname.Name = "txtuplname"
        Me.txtuplname.Size = New System.Drawing.Size(145, 20)
        Me.txtuplname.TabIndex = 6
        '
        'txtUpfname
        '
        Me.txtUpfname.Location = New System.Drawing.Point(132, 49)
        Me.txtUpfname.Name = "txtUpfname"
        Me.txtUpfname.Size = New System.Drawing.Size(145, 20)
        Me.txtUpfname.TabIndex = 7
        '
        'txtupmname
        '
        Me.txtupmname.Location = New System.Drawing.Point(132, 82)
        Me.txtupmname.Name = "txtupmname"
        Me.txtupmname.Size = New System.Drawing.Size(145, 20)
        Me.txtupmname.TabIndex = 8
        '
        'txtupemail
        '
        Me.txtupemail.Location = New System.Drawing.Point(132, 152)
        Me.txtupemail.Name = "txtupemail"
        Me.txtupemail.Size = New System.Drawing.Size(145, 20)
        Me.txtupemail.TabIndex = 9
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(15, 194)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update Record"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'FrmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 222)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtupemail)
        Me.Controls.Add(Me.txtupmname)
        Me.Controls.Add(Me.txtUpfname)
        Me.Controls.Add(Me.txtuplname)
        Me.Controls.Add(Me.txtupid)
        Me.Controls.Add(Me.lblUpEmail)
        Me.Controls.Add(Me.lblUpId)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.lblUpMname)
        Me.Controls.Add(Me.lblFname)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUpdate"
        Me.Text = "Update"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFname As Label
    Friend WithEvents lblUpMname As Label
    Friend WithEvents lblLName As Label
    Friend WithEvents lblUpId As Label
    Friend WithEvents lblUpEmail As Label
    Friend WithEvents txtupid As TextBox
    Friend WithEvents txtuplname As TextBox
    Friend WithEvents txtUpfname As TextBox
    Friend WithEvents txtupmname As TextBox
    Friend WithEvents txtupemail As TextBox
    Friend WithEvents btnUpdate As Button
End Class
