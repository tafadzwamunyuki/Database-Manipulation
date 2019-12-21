<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDelete))
        Me.lblDId = New System.Windows.Forms.Label()
        Me.txtDID = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblDel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDId
        '
        Me.lblDId.AutoSize = True
        Me.lblDId.Location = New System.Drawing.Point(24, 34)
        Me.lblDId.Name = "lblDId"
        Me.lblDId.Size = New System.Drawing.Size(18, 13)
        Me.lblDId.TabIndex = 0
        Me.lblDId.Text = "ID"
        '
        'txtDID
        '
        Me.txtDID.Location = New System.Drawing.Point(99, 27)
        Me.txtDID.Name = "txtDID"
        Me.txtDID.Size = New System.Drawing.Size(146, 20)
        Me.txtDID.TabIndex = 5
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(27, 62)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete Data"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblDel
        '
        Me.lblDel.AutoSize = True
        Me.lblDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDel.Location = New System.Drawing.Point(24, 9)
        Me.lblDel.Name = "lblDel"
        Me.lblDel.Size = New System.Drawing.Size(202, 13)
        Me.lblDel.TabIndex = 11
        Me.lblDel.Text = "DELETES USER RECORDS BY ID"
        '
        'frmDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 93)
        Me.Controls.Add(Me.lblDel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtDID)
        Me.Controls.Add(Me.lblDId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDelete"
        Me.Text = "Delete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDId As Label
    Friend WithEvents txtDID As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblDel As Label
End Class
