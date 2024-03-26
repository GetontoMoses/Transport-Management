<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingForm
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
        Me.Book = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.txtdestination = New System.Windows.Forms.TextBox()
        Me.txtpickup = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Book
        '
        Me.Book.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Book.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Book.Location = New System.Drawing.Point(515, 306)
        Me.Book.Name = "Book"
        Me.Book.Size = New System.Drawing.Size(108, 43)
        Me.Book.TabIndex = 0
        Me.Book.Text = "Book"
        Me.Book.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Destination"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Pickup Point"
        '
        'txtdate
        '
        Me.txtdate.Location = New System.Drawing.Point(256, 75)
        Me.txtdate.Multiline = True
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(242, 41)
        Me.txtdate.TabIndex = 4
        '
        'txtdestination
        '
        Me.txtdestination.Location = New System.Drawing.Point(256, 207)
        Me.txtdestination.Multiline = True
        Me.txtdestination.Name = "txtdestination"
        Me.txtdestination.Size = New System.Drawing.Size(242, 41)
        Me.txtdestination.TabIndex = 5
        '
        'txtpickup
        '
        Me.txtpickup.Location = New System.Drawing.Point(256, 143)
        Me.txtpickup.Multiline = True
        Me.txtpickup.Name = "txtpickup"
        Me.txtpickup.Size = New System.Drawing.Size(242, 41)
        Me.txtpickup.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(297, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Booking information"
        '
        'BookingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpickup)
        Me.Controls.Add(Me.txtdestination)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Book)
        Me.Name = "BookingForm"
        Me.Text = "BookingForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Book As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdate As TextBox
    Friend WithEvents txtdestination As TextBox
    Friend WithEvents txtpickup As TextBox
    Friend WithEvents Label4 As Label
End Class
