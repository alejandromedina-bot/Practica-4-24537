<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Hora = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Minuto = New System.Windows.Forms.Label()
        Me.Dia = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.segundos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Hora
        '
        Me.Hora.AutoSize = True
        Me.Hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hora.Location = New System.Drawing.Point(106, 207)
        Me.Hora.Name = "Hora"
        Me.Hora.Size = New System.Drawing.Size(78, 55)
        Me.Hora.TabIndex = 0
        Me.Hora.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(190, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 55)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = ":"
        '
        'Minuto
        '
        Me.Minuto.AutoSize = True
        Me.Minuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minuto.Location = New System.Drawing.Point(233, 207)
        Me.Minuto.Name = "Minuto"
        Me.Minuto.Size = New System.Drawing.Size(78, 55)
        Me.Minuto.TabIndex = 2
        Me.Minuto.Text = "00"
        '
        'Dia
        '
        Me.Dia.AutoSize = True
        Me.Dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dia.Location = New System.Drawing.Point(56, 155)
        Me.Dia.Name = "Dia"
        Me.Dia.Size = New System.Drawing.Size(76, 25)
        Me.Dia.TabIndex = 3
        Me.Dia.Text = "Lunes"
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Location = New System.Drawing.Point(138, 155)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(241, 25)
        Me.Fecha.TabIndex = 4
        Me.Fecha.Text = "09 de Marzo del 2026"
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.practica_4_24537.My.Resources.Resources.caratula2
        Me.PictureBox1.Location = New System.Drawing.Point(-18, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(598, 438)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'segundos
        '
        Me.segundos.AutoSize = True
        Me.segundos.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.segundos.Location = New System.Drawing.Point(360, 207)
        Me.segundos.Name = "segundos"
        Me.segundos.Size = New System.Drawing.Size(78, 55)
        Me.segundos.TabIndex = 6
        Me.segundos.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(317, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 55)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = ":"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 447)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.segundos)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Dia)
        Me.Controls.Add(Me.Minuto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Hora)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Hora As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Minuto As Label
    Friend WithEvents Dia As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents segundos As Label
    Friend WithEvents Label1 As Label
End Class
