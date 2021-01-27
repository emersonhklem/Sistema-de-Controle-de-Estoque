<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formfornecedores
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formfornecedores))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnpesquisar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnexcluir = New System.Windows.Forms.Button()
        Me.btnalterar = New System.Windows.Forms.Button()
        Me.btnincluir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtcnpj = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtobservacoes = New System.Windows.Forms.RichTextBox()
        Me.maskphone = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.comboestado = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcidade = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcep = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbairro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtendereco = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtrazao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnpesquisar)
        Me.GroupBox2.Controls.Add(Me.btncancelar)
        Me.GroupBox2.Controls.Add(Me.btnexcluir)
        Me.GroupBox2.Controls.Add(Me.btnalterar)
        Me.GroupBox2.Controls.Add(Me.btnincluir)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(575, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 331)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opção"
        '
        'btnpesquisar
        '
        Me.btnpesquisar.BackColor = System.Drawing.Color.Transparent
        Me.btnpesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnpesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnpesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnpesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpesquisar.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpesquisar.Image = CType(resources.GetObject("btnpesquisar.Image"), System.Drawing.Image)
        Me.btnpesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnpesquisar.Location = New System.Drawing.Point(81, 27)
        Me.btnpesquisar.Name = "btnpesquisar"
        Me.btnpesquisar.Size = New System.Drawing.Size(62, 71)
        Me.btnpesquisar.TabIndex = 15
        Me.btnpesquisar.Text = "Pesquisar"
        Me.btnpesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnpesquisar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.Transparent
        Me.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(13, 182)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(62, 74)
        Me.btncancelar.TabIndex = 14
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnexcluir
        '
        Me.btnexcluir.BackColor = System.Drawing.Color.Transparent
        Me.btnexcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnexcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnexcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexcluir.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexcluir.Image = CType(resources.GetObject("btnexcluir.Image"), System.Drawing.Image)
        Me.btnexcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnexcluir.Location = New System.Drawing.Point(81, 104)
        Me.btnexcluir.Name = "btnexcluir"
        Me.btnexcluir.Size = New System.Drawing.Size(62, 72)
        Me.btnexcluir.TabIndex = 13
        Me.btnexcluir.Text = "Excluir"
        Me.btnexcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnexcluir.UseVisualStyleBackColor = False
        '
        'btnalterar
        '
        Me.btnalterar.BackColor = System.Drawing.Color.Transparent
        Me.btnalterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnalterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnalterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnalterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnalterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnalterar.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalterar.Image = CType(resources.GetObject("btnalterar.Image"), System.Drawing.Image)
        Me.btnalterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnalterar.Location = New System.Drawing.Point(13, 104)
        Me.btnalterar.Name = "btnalterar"
        Me.btnalterar.Size = New System.Drawing.Size(62, 72)
        Me.btnalterar.TabIndex = 12
        Me.btnalterar.Text = "Alterar"
        Me.btnalterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnalterar.UseVisualStyleBackColor = False
        '
        'btnincluir
        '
        Me.btnincluir.BackColor = System.Drawing.Color.Transparent
        Me.btnincluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnincluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnincluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnincluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnincluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnincluir.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnincluir.Image = CType(resources.GetObject("btnincluir.Image"), System.Drawing.Image)
        Me.btnincluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnincluir.Location = New System.Drawing.Point(13, 28)
        Me.btnincluir.Name = "btnincluir"
        Me.btnincluir.Size = New System.Drawing.Size(62, 70)
        Me.btnincluir.TabIndex = 11
        Me.btnincluir.Text = "Incluir"
        Me.btnincluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnincluir.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtcnpj)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtobservacoes)
        Me.GroupBox1.Controls.Add(Me.maskphone)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.comboestado)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtcidade)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtcep)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtbairro)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtendereco)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.txtrazao)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 333)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'txtcnpj
        '
        Me.txtcnpj.Location = New System.Drawing.Point(69, 67)
        Me.txtcnpj.Name = "txtcnpj"
        Me.txtcnpj.Size = New System.Drawing.Size(93, 22)
        Me.txtcnpj.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 14)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "CNPJ"
        '
        'txtemail
        '
        Me.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtemail.Location = New System.Drawing.Point(240, 135)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(306, 22)
        Me.txtemail.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(185, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 14)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "E-mail"
        '
        'txtobservacoes
        '
        Me.txtobservacoes.Location = New System.Drawing.Point(6, 231)
        Me.txtobservacoes.Name = "txtobservacoes"
        Me.txtobservacoes.Size = New System.Drawing.Size(539, 96)
        Me.txtobservacoes.TabIndex = 10
        Me.txtobservacoes.Text = ""
        '
        'maskphone
        '
        Me.maskphone.Location = New System.Drawing.Point(422, 174)
        Me.maskphone.Mask = "(99) 00000-0000"
        Me.maskphone.Name = "maskphone"
        Me.maskphone.Size = New System.Drawing.Size(123, 22)
        Me.maskphone.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 14)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Anotações"
        '
        'comboestado
        '
        Me.comboestado.FormattingEnabled = True
        Me.comboestado.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.comboestado.Location = New System.Drawing.Point(255, 174)
        Me.comboestado.Name = "comboestado"
        Me.comboestado.Size = New System.Drawing.Size(80, 22)
        Me.comboestado.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(198, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 14)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Estado"
        '
        'txtcidade
        '
        Me.txtcidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcidade.Location = New System.Drawing.Point(76, 174)
        Me.txtcidade.Name = "txtcidade"
        Me.txtcidade.Size = New System.Drawing.Size(100, 22)
        Me.txtcidade.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cidade"
        '
        'txtcep
        '
        Me.txtcep.Location = New System.Drawing.Point(69, 118)
        Me.txtcep.Name = "txtcep"
        Me.txtcep.Size = New System.Drawing.Size(93, 22)
        Me.txtcep.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "CEP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(352, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Telefone"
        '
        'txtbairro
        '
        Me.txtbairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbairro.Location = New System.Drawing.Point(240, 96)
        Me.txtbairro.Name = "txtbairro"
        Me.txtbairro.Size = New System.Drawing.Size(305, 22)
        Me.txtbairro.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(183, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Bairro"
        '
        'txtendereco
        '
        Me.txtendereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtendereco.Location = New System.Drawing.Point(240, 57)
        Me.txtendereco.Name = "txtendereco"
        Me.txtendereco.Size = New System.Drawing.Size(305, 22)
        Me.txtendereco.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Endereço "
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(39, 16)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(104, 22)
        Me.txtcodigo.TabIndex = 0
        '
        'txtrazao
        '
        Me.txtrazao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtrazao.Location = New System.Drawing.Point(240, 16)
        Me.txtrazao.Name = "txtrazao"
        Me.txtrazao.Size = New System.Drawing.Size(305, 22)
        Me.txtrazao.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Razão Social"
        '
        'formfornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(739, 352)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "formfornecedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fornecedores"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnpesquisar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnexcluir As Button
    Friend WithEvents btnalterar As Button
    Friend WithEvents btnincluir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtobservacoes As RichTextBox
    Friend WithEvents maskphone As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents comboestado As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcidade As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcep As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbairro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtendereco As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtrazao As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtcnpj As TextBox
    Friend WithEvents Label11 As Label
End Class
