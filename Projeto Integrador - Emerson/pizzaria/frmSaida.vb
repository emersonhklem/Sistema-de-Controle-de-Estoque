
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class frmSaida


    Dim strConexao As String = My.Settings.pizzaConnectionString 'string de conexão
    Dim conexao As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emers\OneDrive\Área de Trabalho\Projeto Integrador - Emerson2\Projeto Integrador - Emerson\pizzaria\pizza.mdf;Integrated Security=True"
    Dim cn As New SqlConnection(conexao)
    Dim connection As New SqlClient.SqlConnection
    Dim command As New SqlClient.SqlCommand
    Dim adaptor As New SqlClient.SqlDataAdapter
    Dim dataset As New DataSet


    Dim valorEstoque As Double




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim campo As Double = cboCodBar.Text
        'declarando a variavel teste igual a que esta no datagridviwer



        ' Dim parametro As String = cboparametro.Text
        ' Dim valor As String = "'" & txtvalor.Text & "'" 'Coloquei aspas simples no valor, para o compilador entender que é uma string
        '  Dim tipo As String = tipocampo.ToString
        'Ativa a conexao
        Dim cn As New SqlConnection(conexao)
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        'Cria o objeto de comando
        Dim cSql As New SqlCommand


        cSql.CommandText = "SELECT * FROM Produtos WHERE CodBar =  '" & cboCodBar.Text & "' "



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


        'igualando a variavel teste com o valor da datagrid viwer 

    End Sub

    Private Sub frmSaida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PizzaDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
        Me.ProdutosTableAdapter.Fill(Me.PizzaDataSet.Produtos)

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






        valorEstoque = DataGridView1.CurrentRow().Cells(4).Value

        'fecha a conexão
        cn.Close()
    End Sub

    Private Sub cboCodBar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCodBar.SelectedIndexChanged

    End Sub

    Private Sub cboCodBar_LostFocus(sender As Object, e As EventArgs) Handles cboCodBar.LostFocus
        If cboCodBar.Text = Nothing Then
            Exit Sub
        End If
        'Declare a variável de conexão
        Dim cn As New SqlConnection(conexao)
        'Procurando o Cliente pelo Código
        Dim CodBar As String
        CodBar = Val(cboCodBar.Text)
        Dim csql As String
        csql = "Select Nome From Produtos where CodBar=" & CodBar
        Dim cm As New SqlCommand(csql, cn)
        Try
            cn.Open()
            Dim dr As SqlDataReader
            dr = cm.ExecuteReader
            'Caso haja o cliente, a propriedade read do datareader
            'é igual a true. Assim mostramos os dados na tela.
            If dr.Read() = True Then
                txtDesc.Text = dr("Nome")


            End If
        Catch ex As Exception
            MsgBox("Ocorreu o erro: " & ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
        cn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSaida.Click
        'fazendo com que a variavel pegue o valor da datagridviwer na coluna 4

        valorEstoque = DataGridView1.CurrentRow().Cells(4).Value

        'variavel para igualar ao dado do banco de dados
        Dim qte As Integer
        qte = Val(txtQte.Text)


        If (qte = 0) Then
            MessageBox.Show("Informe um valor de saída!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else


            'checando quantidade do estoque menos a que quer dar saida
            If (qte > valorEstoque) Then
                MessageBox.Show("Quantidade de saída maior que estoque atual", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else



                Dim cm As New SqlCommand
                'Ativa a conexao
                Dim cn As New SqlConnection(conexao)
                If cn.State = ConnectionState.Closed Then
                    cn.Open()
                End If




                Dim codBar As String
                codBar = Val(cboCodBar.Text)
                Dim cSql As New SqlCommand
                cSql.CommandText = "UPDATE Produtos SET Quantidade= Quantidade - '" & Val(txtQte.Text) & "'WHERE CodBar='" & codBar & "' "
                cSql.CommandType = CommandType.Text
                cSql.Connection = cn
                cSql.ExecuteNonQuery()



                MessageBox.Show("Saída realizada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Try


                Catch ex As Exception
                    MsgBox("Ocorreu o erro: " & ex.Message, MsgBoxStyle.Critical)
                    cn.Close()
                End Try
                cn.Close()
            End If
        End If
        'chamando timer para atualizar datagridviewr
        Timer1.Start()
        '   chamando timer da tela principal para atualizar a grid de la
        frmprincipal.AtualizaDG.Start()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Refresh()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick



        'timer para exibir os dados novamente na gridviwer
        Dim campo As Double = cboCodBar.Text

        ' Dim parametro As String = cboparametro.Text
        ' Dim valor As String = "'" & txtvalor.Text & "'" 'Coloquei aspas simples no valor, para o compilador entender que é uma string
        '  Dim tipo As String = tipocampo.ToString
        'Ativa a conexao
        Dim cn As New SqlConnection(conexao)
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        'Cria o objeto de comando
        Dim cSql As New SqlCommand


        cSql.CommandText = "SELECT * FROM Produtos WHERE CodBar =  '" & cboCodBar.Text & "' "



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


        Timer1.Stop()
    End Sub

    Private Sub checagem_Tick(sender As Object, e As EventArgs) Handles checagem.Tick
        'travando botao pesquisa/ok para nao dar erro
        If cboCodBar.Text = "" Then
            btnBuscar.Enabled = False
            btnSaida.Enabled = False
        Else
            btnBuscar.Enabled = True
            btnSaida.Enabled = True
        End If
    End Sub

    Private Sub variavel_Tick(sender As Object, e As EventArgs) Handles variavel.Tick

    End Sub

    Private Sub TxtDesc_TextChanged(sender As Object, e As EventArgs) Handles txtDesc.TextChanged

    End Sub
End Class