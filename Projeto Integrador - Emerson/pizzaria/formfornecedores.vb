Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class formfornecedores
    Dim strConexao As String = My.Settings.pizzaConnectionString 'string de conexão
    Dim conexao As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emers\OneDrive\Área de Trabalho\Projeto Integrador - Emerson2\Projeto Integrador - Emerson\pizzaria\pizza.mdf;Integrated Security=True"
    Private Sub formfornecedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtcodigo_LostFocus(sender As Object, e As EventArgs) Handles txtcodigo.TextChanged
        If txtcodigo.Text = Nothing Then
            Exit Sub
        End If
        'Primeiramente vamos buscar pelo código do cliente.
        'Declare a variável de conexão
        Dim cn As New SqlConnection(conexao)
        'Procurando o Cliente pelo Código
        Dim codigo As Integer
        codigo = Val(txtcodigo.Text)
        Dim csql As String
        csql = "Select * From Fornecedores where cod_forn=" & codigo
        Dim cm As New SqlCommand(csql, cn)
        Try
            cn.Open()
            Dim dr As SqlDataReader
            dr = cm.ExecuteReader
            'Caso haja o cliente, a propriedade read do datareader
            'é igual a true. Assim mostramos os dados na tela.
            If dr.Read() = True Then
                txtrazao.Text = dr("razao_social")
                txtcnpj.Text = dr("cnpj")
                txtendereco.Text = dr("endereco")
                txtbairro.Text = dr("bairro")
                txtcep.Text = dr("cep")
                maskphone.Text = dr("telefone")
                txtcidade.Text = dr("cidade")
                txtemail.Text = dr("email")
                comboestado.Text = dr("uf")
                txtobservacoes.Text = dr("observacoes")
                txtcodigo.Enabled = False
            Else
                'CASO QUEIRA ADICIONAR ALGUM BOTAO PARA ENABLE COLOCAR AQUI

            End If
        Catch ex As Exception
            MsgBox("Ocorreu o erro: " & ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
        cn.Close()
    End Sub

    Private Sub btnincluir_Click(sender As Object, e As EventArgs) Handles btnincluir.Click
        If MessageBox.Show("Deseja incluir o fornecedor " & txtrazao.Text & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

            Dim cn As New SqlConnection(conexao)
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            Dim cm As New SqlCommand
            'gravando dados do formulário clientes
            cm.Connection = cn
            Dim comando As String = "INSERT INTO Fornecedores (razao_social, endereco, bairro, cidade,
uf, cep, email, telefone, observacoes, cnpj) VALUES ('" & txtrazao.Text & "','" &
        txtendereco.Text & "','" & txtbairro.Text & "','" & txtcidade.Text & "','" & comboestado.Text & "','" &
        txtcep.Text & "','" & txtemail.Text & "','" & maskphone.Text & "', '" & txtobservacoes.Text & "', '" & txtcnpj.Text & "')"
            Try
                cm.CommandText = comando
                cm.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Ocorreu o erro: " & ex.Message, MsgBoxStyle.Critical)
                cn.Close()
            End Try
            '============================================================================
            MsgBox("Fornecedor " & txtrazao.Text & ", cadastrado com cod: " & txtcodigo.Text)
            'liberar os botões.
            btnalterar.Enabled = True
            btnexcluir.Enabled = True
            btnpesquisar.Enabled = True
            btnincluir.Enabled = True
            btncancelar.Enabled = True
            txtcodigo.Enabled = True
            'LIMPAR AS CAIXAS DE TEXTO
            For Each ctl As Control In GroupBox1.Controls
                If TypeOf ctl Is TextBox Then ctl.Text = ""

            Next ctl
            cn.Close()
            'colocar o foco na caixa txtcodigo
            txtcodigo.Focus()
        Else


        End If
    End Sub

    Private Sub btnalterar_Click(sender As Object, e As EventArgs) Handles btnalterar.Click
        'Ativa a conexao
        Dim cn As New SqlConnection(conexao)
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        'Declare a variável de conexão
        'Procurando o Produto pelo Código
        Dim codBar As String
        codBar = Val(txtcodigo.Text)
        Dim cSql As New SqlCommand

        'chechando se quer mesmo salvar alteração
        MsgBox("Deseja salvar alteracao?")


        cSql.CommandText = "UPDATE Fornecedores SET razao_social = '" & txtrazao.Text & "', endereco = '" & txtendereco.Text &
        "', bairro =  '" & txtbairro.Text & "', cidade = '" & txtcidade.Text & "', uf= '" & comboestado.Text &
        "', cep = '" & txtcep.Text & "', email = '" & txtemail.Text & "', telefone = '" & maskphone.Text &
        "', observacoes = '" & txtobservacoes.Text & "', cnpj = '" & txtcnpj.Text &
        "'WHERE cod_forn='" & txtcodigo.Text & "' "
            cSql.CommandType = CommandType.Text
            cSql.Connection = cn
            cSql.ExecuteNonQuery()

            Try
                MsgBox("Fornecedor " & txtrazao.Text & ", alterado com sucesso", 64, "Aviso")
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
            txtcodigo.Enabled = True
            'LIMPAR AS CAIXAS DE TEXTO
            'Agora vou mostrar um jeito mais simples
            For Each ctl As Control In GroupBox1.Controls
                If TypeOf ctl Is TextBox Then ctl.Text = ""
            Next ctl
            cn.Close()
            'colocar o foco na caixa txtcodigo
            txtcodigo.Focus()

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Dim cn As New SqlConnection(conexao)
        'Liber os botões.
        btnalterar.Enabled = True
        btnexcluir.Enabled = True
        btnpesquisar.Enabled = True
        btnincluir.Enabled = True
        btncancelar.Enabled = True
        txtcodigo.Enabled = True
        'LIMPAR AS CAIXAS DE TEXTO
        For Each ctl As Control In GroupBox1.Controls
            If TypeOf ctl Is TextBox Then ctl.Text = ""
            If TypeOf ctl Is MaskedTextBox Then ctl.Text = ""
        Next ctl
        txtcodigo.Text = ""
        cn.Close()
        'colocar o foco na caixa txtcodigo
        txtcodigo.Focus()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Txtcidade_TextChanged(sender As Object, e As EventArgs) Handles txtcidade.TextChanged

    End Sub

    Private Sub Btnexcluir_Click(sender As Object, e As EventArgs) Handles btnexcluir.Click
        Dim cn As New SqlConnection(conexao)

        'se estiver desconectado, entao, conectar
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        'string para exclusão do cliente
        Dim exclu As String
        exclu = "DELETE FROM Fornecedores WHERE cod_forn=" & Val(txtcodigo.Text)
        'pede confirmação ao usuário
        Dim confirma As Integer
        confirma = MsgBox("Deseja excluir o Fornecedor: " & txtrazao.Text & " ? ", 36, "Pergunta")
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
        txtcodigo.Enabled = True
        'LIMPAR AS CAIXAS DE TEXTO
        For Each ctl As Control In GroupBox1.Controls
            If TypeOf ctl Is TextBox Then ctl.Text = ""
        Next ctl
        txtrazao.Text = ""
        cn.Close()
        'colocar o foco na caixa txtcodigo
        txtcodigo.Focus()
    End Sub

    Private Sub Btnpesquisar_Click(sender As Object, e As EventArgs) Handles btnpesquisar.Click
        consultaForn.Text = "Fornecedores"
        consultaForn.ShowDialog()
    End Sub
End Class