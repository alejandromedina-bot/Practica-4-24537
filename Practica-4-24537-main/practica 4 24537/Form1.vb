Public Class Form1
    Dim estado As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim Time_o = DateTime.Now.ToString("HH:mm:ss")

        Dim Time_mod = Time_o.Split(":")

        Hora.Text = Time_mod(0)
        Minuto.Text = Time_mod(1)
        segundos.Text = Time_mod(2)
        Dia.Text = Day_o
        Fecha.Text = Date_o
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel1.Visible = True
        If estado = True Then
            Panel1.Visible = False
            estado = False
        ElseIf estado = False Then
            Panel1.Visible = True
            estado = True
        End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Blanco" Then
            Hora.ForeColor = Color.White
            Minuto.ForeColor = Color.White
            segundos.ForeColor = Color.White
            Dia.ForeColor = Color.White
            Fecha.ForeColor = Color.White
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
        ElseIf ComboBox1.Text = "Rojo" Then
            Hora.ForeColor = Color.Red
            Minuto.ForeColor = Color.Red
            segundos.ForeColor = Color.Red
            Dia.ForeColor = Color.Red
            Fecha.ForeColor = Color.Red
            Label1.ForeColor = Color.Red
            Label2.ForeColor = Color.Red
        ElseIf ComboBox1.Text = "Verde" Then
            Hora.ForeColor = Color.Green
            Minuto.ForeColor = Color.Green
            segundos.ForeColor = Color.Green
            Dia.ForeColor = Color.Green
            Fecha.ForeColor = Color.Green
            Label1.ForeColor = Color.Green
            Label2.ForeColor = Color.Green
        ElseIf ComboBox1.Text = "Amarillo" Then
            Hora.ForeColor = Color.Yellow
            Minuto.ForeColor = Color.Yellow
            segundos.ForeColor = Color.Yellow
            Dia.ForeColor = Color.Yellow
            Fecha.ForeColor = Color.Yellow
            Label1.ForeColor = Color.Yellow
            Label2.ForeColor = Color.Yellow
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label1.Visible = True Then
            Label1.Visible = False
        ElseIf Label1.Visible = False Then
            Label1.Visible = True
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Panel1.Visible = True
        If estado = True Then
            Panel2.Visible = False
            estado = False
        ElseIf estado = False Then
            Panel2.Visible = True
            estado = True
        End If
    End Sub
End Class
