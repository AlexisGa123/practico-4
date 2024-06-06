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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tabla2 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tabla3 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.Tabla1.Location = New System.Drawing.Point(12, 47)
        Me.Tabla1.Name = "Tabla1"
        Me.Tabla1.RowHeadersVisible = False
        Me.Tabla1.RowTemplate.Height = 25
        Me.Tabla1.Size = New System.Drawing.Size(203, 141)
        Me.Tabla1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(267, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 77)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Tabla2
        '
        Me.Tabla2.AllowUserToAddRows = False
        Me.Tabla2.AllowUserToDeleteRows = False
        Me.Tabla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla2.ColumnHeadersVisible = False
        Me.Tabla2.Location = New System.Drawing.Point(12, 233)
        Me.Tabla2.Name = "Tabla2"
        Me.Tabla2.ReadOnly = True
        Me.Tabla2.RowHeadersVisible = False
        Me.Tabla2.RowTemplate.Height = 25
        Me.Tabla2.Size = New System.Drawing.Size(203, 33)
        Me.Tabla2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Diagonal principal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contradiagonal"
        '
        'Tabla3
        '
        Me.Tabla3.AllowUserToAddRows = False
        Me.Tabla3.AllowUserToDeleteRows = False
        Me.Tabla3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla3.ColumnHeadersVisible = False
        Me.Tabla3.Location = New System.Drawing.Point(12, 308)
        Me.Tabla3.Name = "Tabla3"
        Me.Tabla3.ReadOnly = True
        Me.Tabla3.RowHeadersVisible = False
        Me.Tabla3.RowTemplate.Height = 25
        Me.Tabla3.Size = New System.Drawing.Size(203, 33)
        Me.Tabla3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ingrese una matriz de 5x5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 365)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Tabla3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tabla2)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Tabla2 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tabla3 As DataGridView
    Friend WithEvents Label3 As Label
End Class
