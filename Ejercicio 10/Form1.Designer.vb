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
        Me.Tabla1 = New System.Windows.Forms.DataGridView()
        Me.Tabla2 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tabla3 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.Tabla1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabla2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabla3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tabla1
        '
        Me.Tabla1.AllowUserToAddRows = False
        Me.Tabla1.AllowUserToDeleteRows = False
        Me.Tabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla1.ColumnHeadersVisible = False
        Me.Tabla1.Location = New System.Drawing.Point(12, 40)
        Me.Tabla1.Name = "Tabla1"
        Me.Tabla1.RowHeadersVisible = False
        Me.Tabla1.RowHeadersWidth = 51
        Me.Tabla1.RowTemplate.Height = 25
        Me.Tabla1.Size = New System.Drawing.Size(284, 187)
        Me.Tabla1.TabIndex = 3
        '
        'Tabla2
        '
        Me.Tabla2.AllowUserToAddRows = False
        Me.Tabla2.AllowUserToDeleteRows = False
        Me.Tabla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla2.ColumnHeadersVisible = False
        Me.Tabla2.Location = New System.Drawing.Point(12, 265)
        Me.Tabla2.Name = "Tabla2"
        Me.Tabla2.ReadOnly = True
        Me.Tabla2.RowHeadersVisible = False
        Me.Tabla2.RowHeadersWidth = 51
        Me.Tabla2.RowTemplate.Height = 25
        Me.Tabla2.Size = New System.Drawing.Size(284, 33)
        Me.Tabla2.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Ingrese matriz de 7x7"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Matriz de 3x4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 247)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Vector obtenido:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(342, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 73)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Tabla3
        '
        Me.Tabla3.AllowUserToAddRows = False
        Me.Tabla3.AllowUserToDeleteRows = False
        Me.Tabla3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla3.ColumnHeadersVisible = False
        Me.Tabla3.Location = New System.Drawing.Point(12, 334)
        Me.Tabla3.Name = "Tabla3"
        Me.Tabla3.RowHeadersVisible = False
        Me.Tabla3.RowHeadersWidth = 51
        Me.Tabla3.RowTemplate.Height = 25
        Me.Tabla3.Size = New System.Drawing.Size(165, 88)
        Me.Tabla3.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(224, 384)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 15)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "El mayor de la contradiagonal:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(224, 401)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(112, 23)
        Me.TextBox1.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Tabla3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tabla2)
        Me.Controls.Add(Me.Tabla1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Tabla1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabla2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabla3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tabla1 As DataGridView
    Friend WithEvents Tabla2 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Tabla3 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
