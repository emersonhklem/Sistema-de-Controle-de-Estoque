Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class consultaProd
    Dim strConexao As String = My.Settings.pizzaConnectionString 'string de conexão
    Dim conexao As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emers\OneDrive\Área de Trabalho\Projeto Integrador - Emerson2\Projeto Integrador - Emerson\pizzaria\pizza.mdf;Integrated Security=True"
    Dim cn As New SqlConnection(conexao)

    Dim tipocampo As System.Type
    Private Sub consultaProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Ativa a conexao
        Dim cn As New SqlConnection(conexao)
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        'Cria o objeto de comando
        Dim cSql As New SqlCommand
        'Passar os valores da query SQL, tipo do comando,
        cSql.CommandText = "SELECT * FROM " & Me.Text 'tabela passada atraves do botao pesquisar de
        cSql.CommandType = CommandType.Text
        cSql.Connection = cn
        cSql.ExecuteNonQuery()
        'Declara um data adapter
        Dim daAdaptador As New SqlDataAdapter
        'Declara um dataset, armazenar dados de um banco de dados e pode também mover os dados de um
        Dim dsDataSet As New DataSet
        'Passa o comando a ser executado pelo DataAdapter
        daAdaptador.SelectCommand = cSql
        'O DataAdapter faz a conexão com o banco de dados e carrega o DataSet e fecha a conexao.
        daAdaptador.Fill(dsDataSet) 'populando o dataset e retorna o Dataset carregado para o
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dsDataSet.Tables(0) 'Tables (0) Indica a única Tabela selecionada
        'Preenchendo o ComboBox com os campos da Tabela (colunas)
        cbocampo.Items.Clear()
        Dim i As Integer
        For i = 0 To dsDataSet.Tables(0).Columns.Count - 1
            cbocampo.Items.Add(dsDataSet.Tables(0).Columns(i).ColumnName)
        Next
        'fecha a conexão
        cn.Close()

    End Sub

    Private Sub cbocampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocampo.SelectedIndexChanged
        Dim ds As New DataSet
        tipocampo = Me.DataGridView1.Columns(cbocampo.SelectedIndex).ValueType
        If (tipocampo.ToString = "System.Int16" Or
        tipocampo.ToString = "System.Int32" Or
        tipocampo.ToString = "System.Int64" Or
        tipocampo.ToString = "System.Decimal" Or
tipocampo.ToString = "System.Single" Or
tipocampo.ToString = "System.Double") Then
            cboparametro.Items.Clear()
            cboparametro.Items.Add("=")
            cboparametro.Items.Add(">")
            cboparametro.Items.Add(">=")
            cboparametro.Items.Add("<")
            cboparametro.Items.Add("<=")
            cboparametro.Items.Add("<>")
        End If
        If tipocampo.ToString = "System.String" Then
            cboparametro.Items.Clear()
            cboparametro.Items.Add("=")
            cboparametro.Items.Add("Começa com")
            cboparametro.Items.Add("Termina em")
            cboparametro.Items.Add("Tem a palavra")
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim campo As String = cbocampo.Text
        Dim parametro As String = cboparametro.Text
        Dim valor As String = "'" & txtvalor.Text & "'" 'Coloquei aspas simples no valor, para o compilador entender que é uma string
        Dim tipo As String = tipocampo.ToString
        'Ativa a conexao
        Dim cn As New SqlConnection(conexao)
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        'Cria o objeto de comando
        Dim cSql As New SqlCommand
        'Para tipos Numéricos
        If (tipo = "System.Int16" Or
        tipo = "System.Int32" Or
        tipo = "System.Int64" Or
        tipo = "System.Single" Or
        tipo = "System.Double" Or
        tipo = "System.Decimal") Then
            'Passar os valores da query SQL, tipo do comando, conexao e executa o comando
            cSql.CommandText = "SELECT * FROM " & Me.Text & " WHERE " _
            & campo & " " & parametro & valor
        End If

        '************************************************************
        Dim range = txtvalor.TextLength 'Vai receber a quantidade de caracteres do campo valor para tornar a query dinamica


        'Para tipos String
        If tipo = "System.String" Then

            'CRIEI UMA QUERY ESPECIFICA PARA CADA PARAMETRO
            If parametro = "Tem a palavra" Then
                cSql.CommandText = "SELECT * FROM Produtos WHERE CHARINDEX(" & valor & ", " & campo & ") > 0 "
            End If
            '------------------------------------------
            If parametro = "=" Then
                parametro = "="
                'Seleciona * onde o valor do campo for igual ao valor passado pelo usuario
                cSql.CommandText = "SELECT * FROM Produtos WHERE " & campo & " " & "= " & valor
            End If
            '----------------------------------------
            If parametro = "Começa com" Then
                'Retorna todos os valores dos campos em que o primeiro caracter ou mais são iguais ao campo valor
                cSql.CommandText = "SELECT * FROM Produtos WHERE LEFT(" & campo & ", " & range & ") = " & valor

            End If
            '------------------------------------------
            If parametro = "Termina em" Then
                'Retorna todos os valores dos campos em que o ultimo caracter é igual ao campo valor
                cSql.CommandText = "SELECT * FROM Produtos WHERE RIGHT(" & campo & ", " & range & ") = " & valor
            End If

        End If
        cSql.CommandType = CommandType.Text
        cSql.Connection = cn
        cSql.ExecuteNonQuery()
        'Declara um data adapter
        Dim daAdaptador As New SqlDataAdapter
        'Declara um dataset
        Dim dsDataSet As New DataSet
        'Passa o comando a ser executado pelo DataAdapter
        daAdaptador.SelectCommand = cSql
        'O DataAdapter faz a conexão com o banco de dados e carrega o DataSet e fecha a conexao.
        daAdaptador.Fill(dsDataSet)
        'Retorna o Dataset carregado para o DataGridView
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dsDataSet.Tables(0) 'Tables (0) Indica a única Tabela selecionada
    End Sub

    Private Sub btnOk_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If cbocampo.Text <> "" Then
            btnOk.Enabled = True
        Else
            btnOk.Enabled = False
        End If
    End Sub

    Private Sub Cboparametro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboparametro.SelectedIndexChanged

    End Sub
End Class