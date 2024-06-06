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
        CType(Me.Tabla1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabla2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tabla1
        '
        Me.Tabla1.AllowUserToAddRows = False
        Me.Tabla1.AllowUserToDeleteRows = False
        Me.Tabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla1.ColumnHeadersVisible = False
        Me.Tabla1.Location = New System.Drawing.Point(12, 35)
        Me.Tabla1.Name = "Tabla1"
        Me.Tabla1.RowHeadersVisible = False
        Me.Tabla1.RowTemplate.Height = 25
        Me.Tabla1.Size = New System.Drawing.Size(325, 264)
        Me.Tabla1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(343, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 73)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Tabla2
        '
        Me.Tabla2.AllowUserToAddRows = False
        Me.Tabla2.AllowUserToDeleteRows = False
        Me.Tabla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla2.ColumnHeadersVisible = False
        Me.Tabla2.Location = New System.Drawing.Point(12, 350)
        Me.Tabla2.Name = "Tabla2"
        Me.Tabla2.ReadOnly = True
        Me.Tabla2.RowHeadersVisible = False
        Me.Tabla2.RowTemplate.Height = 25
        Me.Tabla2.Size = New System.Drawing.Size(406, 33)
        Me.Tabla2.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ingrese una matriz de 10x8"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 332)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Los menores de cada fila son:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 395)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tabla2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tabla1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Tabla1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabla2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tabla1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Tabla2 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
