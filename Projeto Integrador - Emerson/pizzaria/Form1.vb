Imports System.Data.SqlClient
Imports System.Data
Imports System.Text
Public Class Form1
    Public user_1 As String
    Public senha_1 As String
    Dim strConexao As String = My.Settings.pizzaConnectionString 'string de conexão
    Dim connection As New SqlClient.SqlConnection
    Dim command As New SqlClient.SqlCommand
    Dim adaptor As New SqlClient.SqlDataAdapter
    Dim dataset As New DataSet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogar.Click
        user_1 = txt_login.Text
        senha_1 = txt_senha.Text
        connection.ConnectionString = strConexao
        connection.Open()
        command.CommandText = "SELECT login, senha FROM usuarios WHERE login='" & user_1 & "' and senha='" & senha_1 & "' "
        command.Connection = connection
        adaptor.SelectCommand = command
        adaptor.Fill(dataset, "0")
        Dim count = dataset.Tables(0).Rows.Count
        If count > 0 Then
            frmprincipal.Show()
            Me.Hide()
        Else
            MsgBox("Login invalido verifique seu login e senha",
            MsgBoxStyle.Critical)
            txt_login.Clear()
            txt_senha.Clear()
        End If
        connection.Close()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer

    End Structure

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        move.X = Me.Left - MousePosition.X
        move.y = Me.Top - MousePosition.Y
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Me.Left = move.X + MousePosition.X
        Me.Top = move.y + MousePosition.Y
    End Sub
    Dim move As MoveForm

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
