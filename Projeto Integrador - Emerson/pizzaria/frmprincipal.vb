
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class frmprincipal

    Dim strConexao As String = My.Settings.pizzaConnectionString 'string de conexão
    Dim conexao As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emers\OneDrive\Área de Trabalho\Projeto Integrador - Emerson2\Projeto Integrador - Emerson\pizzaria\pizza.mdf;Integrated Security=True"
    Dim cn As New SqlConnection(conexao)
    Dim connection As New SqlClient.SqlConnection
    Dim command As New SqlClient.SqlCommand
    Dim adaptor As New SqlClient.SqlDataAdapter
    Dim dataset As New DataSet

    'declarando variavel para usar no double click da datagridvewr
    Dim codigoProduto As Integer




    Private Sub frmprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'exibindo na datagridviwer apenas os produtos com estoque 0
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
        cSql.CommandText = "SELECT IdProduto, CodBar, Quantidade FROM Produtos WHERE Quantidade <= 0 "
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



        'fecha a conexão
        cn.Close()
        '=================================================================================

        'exibindo texto ao passar mouse
        ' Cria a ToolTip e associa com o Form container.
        Dim toolTip1 As New ToolTip()
        ' Define o delay para a ToolTip.
        toolTip1.InitialDelay = 100
        toolTip1.ReshowDelay = 100
        ' Força a o texto da ToolTip a ser exibido mesmo que o form não esta ativo
        toolTip1.ShowAlways = True



    End Sub





    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub





    Private Sub dgvProdutos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    Private Sub AtualizaDG_Tick(sender As Object, e As EventArgs) Handles AtualizaDG.Tick
        'exibindo na datagridviwer apenas os produtos com estoque 0
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
        cSql.CommandText = "SELECT IdProduto, CodBar, Quantidade FROM Produtos WHERE Quantidade <= 0 "
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

        'fecha a conexão
        cn.Close()

        AtualizaDG.Stop()
    End Sub







    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub ArquivoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmprodutos.MdiParent = Me
        frmprodutos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        formfornecedores.MdiParent = Me
        formfornecedores.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmSaida.Text = "Produtos"
        frmSaida.MdiParent = Me
        frmSaida.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class