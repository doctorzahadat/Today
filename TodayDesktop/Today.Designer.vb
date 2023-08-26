<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmToday
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnPressMe = New Button()
        txtToday = New TextBox()
        SuspendLayout()
        ' 
        ' btnPressMe
        ' 
        btnPressMe.Location = New Point(478, 174)
        btnPressMe.Name = "btnPressMe"
        btnPressMe.Size = New Size(75, 23)
        btnPressMe.TabIndex = 0
        btnPressMe.Text = "Press Me"
        btnPressMe.UseVisualStyleBackColor = True
        ' 
        ' txtToday
        ' 
        txtToday.Location = New Point(49, 174)
        txtToday.Name = "txtToday"
        txtToday.Size = New Size(242, 23)
        txtToday.TabIndex = 1
        ' 
        ' frmToday
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtToday)
        Controls.Add(btnPressMe)
        Name = "frmToday"
        Text = "Today"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPressMe As Button
    Friend WithEvents txtToday As TextBox
End Class
