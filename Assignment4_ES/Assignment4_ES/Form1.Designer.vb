<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSalePrice = New System.Windows.Forms.Label()
        Me.lblOriginalPrice = New System.Windows.Forms.Label()
        Me.lblPercentOff = New System.Windows.Forms.Label()
        Me.txtOrginalPrice = New System.Windows.Forms.TextBox()
        Me.txtPercentOff = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(11, 162)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(92, 162)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(173, 162)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSalePrice
        '
        Me.lblSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalePrice.Location = New System.Drawing.Point(54, 100)
        Me.lblSalePrice.Name = "lblSalePrice"
        Me.lblSalePrice.Size = New System.Drawing.Size(150, 46)
        Me.lblSalePrice.TabIndex = 3
        Me.lblSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOriginalPrice
        '
        Me.lblOriginalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOriginalPrice.Location = New System.Drawing.Point(43, 20)
        Me.lblOriginalPrice.Name = "lblOriginalPrice"
        Me.lblOriginalPrice.Size = New System.Drawing.Size(115, 23)
        Me.lblOriginalPrice.TabIndex = 4
        Me.lblOriginalPrice.Text = "Original Price     $"
        '
        'lblPercentOff
        '
        Me.lblPercentOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentOff.Location = New System.Drawing.Point(43, 50)
        Me.lblPercentOff.Name = "lblPercentOff"
        Me.lblPercentOff.Size = New System.Drawing.Size(115, 23)
        Me.lblPercentOff.TabIndex = 5
        Me.lblPercentOff.Text = "Percent Off       %"
        '
        'txtOrginalPrice
        '
        Me.txtOrginalPrice.Location = New System.Drawing.Point(135, 17)
        Me.txtOrginalPrice.Name = "txtOrginalPrice"
        Me.txtOrginalPrice.Size = New System.Drawing.Size(81, 20)
        Me.txtOrginalPrice.TabIndex = 6
        '
        'txtPercentOff
        '
        Me.txtPercentOff.Location = New System.Drawing.Point(135, 47)
        Me.txtPercentOff.Name = "txtPercentOff"
        Me.txtPercentOff.Size = New System.Drawing.Size(81, 20)
        Me.txtPercentOff.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Sale Price"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 202)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPercentOff)
        Me.Controls.Add(Me.txtOrginalPrice)
        Me.Controls.Add(Me.lblPercentOff)
        Me.Controls.Add(Me.lblOriginalPrice)
        Me.Controls.Add(Me.lblSalePrice)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sale"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSalePrice As Label
    Friend WithEvents lblOriginalPrice As Label
    Friend WithEvents lblPercentOff As Label
    Friend WithEvents txtOrginalPrice As TextBox
    Friend WithEvents txtPercentOff As TextBox
    Friend WithEvents Label1 As Label
End Class
