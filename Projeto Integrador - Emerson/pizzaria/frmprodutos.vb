Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class frmprodutos

    Private Sub frmprodutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PizzaDataSet.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
        Me.FornecedoresTableAdapter.Fill(Me.PizzaDataSet.Fornecedores)

    End Sub

    Dim strConexao As String = My.Settings.pizzaConnectionString 'string de conexão
    Dim conexao As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emers\OneDrive\Área de Trabalho\Projeto Integrador - Emerson2\Projeto Integrador - Emerson\pizzaria\pizza.mdf;Integrated Security=True"

    Private Sub txtcodprod_LostFocus(sender As Object, e As EventArgs) Handles txtcodprod.TextChanged
        'Primeiramente vamos buscar pelo código do produto.
        'Declare a variável de conexão
        Dim cn As New SqlConnection(conexao)
        'Procurando o Produto pelo Código
        Dim codigo As Integer
        codigo = Val(txtcodprod.Text)
        Dim csql As String
        csql = "Select * From Produtos where IdProduto=" & codigo
        Dim cm As New SqlCommand(csql, cn)
        Try
            cn.Open()
            Dim dr As SqlDataReader
            dr = cm.ExecuteReader
            'Caso haja o produto, a propriedade read do datareader
            'é igual a true. Assim mostramos os dados na tela.
            If dr.Read() = True Then
                txtproduto.Text = dr("Nome")
                txtpreco.Text = dr("Preco")
                txtquantidade.Text = dr("Quantidade")
                txtCodBar.Text = dr("CodBar")
                cboForn.Text = dr("Forn")
                txtcodprod.Enabled = False
                'liberando botoes
                btnalterar.Enabled = True
                btnexcluir.Enabled = True
                btncancelar.Enabled = True
                btnpesquisar.Enabled = True

                'travando botao incluir pois se ja tem um registro voce nao pode incluir novamente
                btnincluir.Enabled = False
            Else
                'Caso não exista o cliente cujo código foi digitado
                'travando botoes deletar, cancelar e alterar
                btnexcluir.Enabled = False
                btncancelar.Enabled = False
                btnalterar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Ocorreu o erro: " & ex.Message, MsgBoxStyle.Critical)

            cn.Close()
        End Try
        cn.Close()
    End Sub

    Private Sub btnincluir_Click(sender As Object, e As EventArgs) Handles btnincluir.Click
        'formatando valor da caixa de texto preço
        Dim valor As Integer
        valor = txtpreco.Text
        Dim valorProduto As String
        valorProduto = valor.ToString("c")

        txtpreco.Text = valorProduto

        'chechando campos 
        If txtquantidade.Text = "0" Then
            MessageBox.Show("Um produto não pode ser cadastro sem uma quantidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else


            Dim cn As New SqlConnection(conexao)
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            Dim cm As New SqlCommand
            'gravando dados do formulário clientes
            cm.Connection = cn
            Dim comando As String = "INSERT INTO Produtos (IdProduto, Nome, CodBar, Preco, Quantidade, Forn) VALUES ('" & txtcodprod.Text & "','" & txtproduto.Text & "','" &
            txtCodBar.Text & "','" & txtpreco.Text & "','" & txtquantidade.Text & "', '" & cboForn.Text & "')"
            Try
                cm.CommandText = comando
                cm.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Ocorreu o erro: " & ex.Message, MsgBoxStyle.Critical)
                cn.Close()
            End Try
            '============================================================================
            MsgBox("Produto " & txtproduto.Text & ", cadastrado com cod: " & txtcodprod.Text)
            'liberar os botões.
            btnalterar.Enabled = True
            btnexcluir.Enabled = True
            btnpesquisar.Enabled = True
            btnincluir.Enabled = True
            btncancelar.Enabled = True
            txtcodprod.Enabled = True
            'LIMPAR AS CAIXAS DE TEXTO
            For Each ctl As Control In GroupBox1.Controls
                If TypeOf ctl Is TextBox Then ctl.Text = ""
                If TypeOf ctl Is ComboBox Then ctl.Text = ""

            Next ctl
            cn.Close()
            'colocar o foco na caixa txtcodigo
            txtcodprod.Focus()
        End If
    End Sub

    Private Sub btnalterar_Click(sender As Object, e As EventArgs) Handles btnalterar.Click
        'formatando caixa de texto preço
        Dim valor As Integer
        valor = txtpreco.Text
        Dim valorProduto As String
        valorProduto = valor.ToString("c")

        txtpreco.Text = valorProduto

        'Ativa a conexao
        Dim cn As New SqlConnection(conexao)
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        'Declare a variável de conexão
        'Procurando o Produto pelo Código
        Dim codBar As String
        codBar = Val(txtcodprod.Text)
        Dim cSql As New SqlCommand

        'chechando se quer mesmo salvar alteração
        MsgBox("Deseja salvar alteracao?")


        cSql.CommandText = "UPDATE Produtos SET Nome = '" & txtproduto.Text & "', CodBar = '" & txtCodBar.Text &
        "', Preco =  '" & txtpreco.Text & "', Quantidade = '" & txtquantidade.Text & "'WHERE IdProduto='" & txtcodprod.Text & "' "
        cSql.CommandType = CommandType.Text
        cSql.Connection = cn
        cSql.ExecuteNonQuery()

        Try
            MsgBox("Produto " & txtproduto.Text & ", alterado com sucesso", 64, "Aviso")
        Catch ex As Exception
            MsgBox("Ocorreu o erro: " & ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
        'Liberamos os botões.
        btnalterar.Enabled = True
        btnexcluir.Enabled = True
        btnpesquisar.Enabled = True
        btnincluir.Enabled = True
        btncancelar.Enabled = True
        txtcodprod.Enabled = True
        'LIMPAR AS CAIXAS DE TEXTO
        'Agora vou mostrar um jeito mais simples
        For Each ctl As Control In GroupBox1.Controls
            If TypeOf ctl Is TextBox Then ctl.Text = ""
        Next ctl
        cn.Close()
        'colocar o foco na caixa txtcodigo
        txtcodprod.Focus()


        'atualiza grid da tela principal
        frmprincipal.AtualizaDG.Start()
    End Sub

    Private Sub btnexcluir_Click(sender As Object, e As EventArgs) Handles btnexcluir.Click
        Dim cn As New SqlConnection(conexao)

        'se estiver desconectado, entao, conectar
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        'string para exclusão do cliente
        Dim exclu As String
        exclu = "DELETE FROM Produtos WHERE IdProduto=" & Val(txtcodprod.Text)
        'pede confirmação ao usuário
        Dim confirma As Integer
        confirma = MsgBox("Deseja excluir o Produto: " & txtproduto.Text & " ? ", 36, "Pergunta")
        Dim cm As New SqlCommand
        If confirma = vbYes Then
            Try
                cm.Connection = cn
                cm.CommandText = exclu
                cm.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Ocorreu o erro: " & ex.Message, MsgBoxStyle.Critical)
                cn.Close()
            End Try
        Else
            MsgBox("Operação cancelada, registro NÃO excluído", 64, "Aviso")
        End If
        'Liberamos os botões.
        btnalterar.Enabled = True
        btnexcluir.Enabled = True
        btnpesquisar.Enabled = True
        btnincluir.Enabled = True
        btncancelar.Enabled = True
        txtcodprod.Enabled = True
        'LIMPAR AS CAIXAS DE TEXTO
        For Each ctl As Control In GroupBox1.Controls
            If TypeOf ctl Is TextBox Then ctl.Text = ""
        Next ctl
        txtquantidade.Text = ""
        cn.Close()
        'colocar o foco na caixa txtcodigo
        txtcodprod.Focus()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Dim cn As New SqlConnection(conexao)
        'Liber os botões.
        btnalterar.Enabled = True
        btnexcluir.Enabled = True
        btnpesquisar.Enabled = True
        btnincluir.Enabled = True
        btncancelar.Enabled = True
        txtcodprod.Enabled = True
        'LIMPAR AS CAIXAS DE TEXTO
        For Each ctl As Control In GroupBox1.Controls
            If TypeOf ctl Is TextBox Then ctl.Text = ""
            If TypeOf ctl Is ComboBox Then ctl.Text = ""
        Next ctl
        txtCodBar.Text = ""
        cn.Close()
        'colocar o foco na caixa txtcodigo
        txtcodprod.Focus()
    End Sub

    Private Sub btnpesquisar_Click(sender As Object, e As EventArgs) Handles btnpesquisar.Click
        consultaProd.Text = "Produtos"
        consultaProd.ShowDialog()
    End Sub


End Class