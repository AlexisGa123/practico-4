<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.cmd = New System.Windows.Forms.Button()
        Me.Tabla2 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Tabla3 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        CType(Me.Tabla2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabla3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd
        '
        Me.cmd.Location = New System.Drawing.Point(293, 208)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(81, 72)
        Me.cmd.TabIndex = 1
        Me.cmd.Text = "Calcular"
        Me.cmd.UseVisualStyleBackColor = True
        '
        'Tabla2
        '
        Me.Tabla2.AllowUserToAddRows = False
        Me.Tabla2.AllowUserToDeleteRows = False
        Me.Tabla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla2.ColumnHeadersVisible = False
        Me.Tabla2.Location = New System.Drawing.Point(12, 45)
        Me.Tabla2.Name = "Tabla2"
        Me.Tabla2.RowHeadersVisible = False
        Me.Tabla2.RowTemplate.Height = 25
        Me.Tabla2.Size = New System.Drawing.Size(404, 35)
        Me.Tabla2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingrese un vector de 10 elementos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Elementos pares:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(293, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Elementos impares"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "El mayor es:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 213)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(64, 23)
        Me.TextBox1.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Esta en la posicion:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 257)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(64, 23)
        Me.TextBox2.TabIndex = 9
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(293, 108)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(107, 79)
        Me.ListBox1.TabIndex = 11
        '
        'Tabla3
        '
        Me.Tabla3.AllowUserToAddRows = False
        Me.Tabla3.AllowUserToDeleteRows = False
        Me.Tabla3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla3.ColumnHeadersVisible = False
        Me.Tabla3.Location = New System.Drawing.Point(12, 306)
        Me.Tabla3.Name = "Tabla3"
        Me.Tabla3.ReadOnly = True
        Me.Tabla3.RowHeadersVisible = False
        Me.Tabla3.RowTemplate.Height = 25
        Me.Tabla3.Size = New System.Drawing.Size(404, 35)
        Me.Tabla3.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Nuevo vector"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Location = New System.Drawing.Point(12, 108)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(107, 79)
        Me.ListBox2.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 385)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Tabla3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tabla2)
        Me.Controls.Add(Me.cmd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Tabla2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabla3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd As Button
    Friend WithEvents Tabla2 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Tabla3 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents ListBox2 As ListBox
End Class
