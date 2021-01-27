<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmprodutos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmprodutos))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboForn = New System.Windows.Forms.ComboBox()
        Me.FornecedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PizzaDataSet = New pizzaria.pizzaDataSet()
        Me.txtCodBar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtquantidade = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpreco = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtproduto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodprod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnpesquisar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnexcluir = New System.Windows.Forms.Button()
        Me.btnalterar = New System.Windows.Forms.Button()
        Me.btnincluir = New System.Windows.Forms.Button()
        Me.FornecedoresTableAdapter = New pizzaria.pizzaDataSetTableAdapters.FornecedoresTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PizzaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboForn)
        Me.GroupBox1.Controls.Add(Me.txtCodBar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtquantidade)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtpreco)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtproduto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtcodprod)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(441, 211)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Fornecedor"
        '
        'cboForn
        '
        Me.cboForn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboForn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboForn.DataSource = Me.FornecedoresBindingSource
        Me.cboForn.DisplayMember = "razao_social"
        Me.cboForn.FormattingEnabled = True
        Me.cboForn.Location = New System.Drawing.Point(91, 139)
        Me.cboForn.Name = "cboForn"
        Me.cboForn.Size = New System.Drawing.Size(331, 22)
        Me.cboForn.TabIndex = 9
        Me.cboForn.ValueMember = "razao_social"
        '
        'FornecedoresBindingSource
        '
        Me.FornecedoresBindingSource.DataMember = "Fornecedores"
        Me.FornecedoresBindingSource.DataSource = Me.PizzaDataSet
        '
        'PizzaDataSet
        '
        Me.PizzaDataSet.DataSetName = "pizzaDataSet"
        Me.PizzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCodBar
        '
        Me.txtCodBar.Location = New System.Drawing.Point(61, 107)
        Me.txtCodBar.Name = "txtCodBar"
        Me.txtCodBar.Size = New System.Drawing.Size(361, 22)
        Me.txtCodBar.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "CodBar"
        '
        'txtquantidade
        '
        Me.txtquantidade.Location = New System.Drawing.Point(91, 173)
        Me.txtquantidade.Name = "txtquantidade"
        Me.txtquantidade.Size = New System.Drawing.Size(331, 22)
        Me.txtquantidade.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Quantidade"
        '
        'txtpreco
        '
        Me.txtpreco.Location = New System.Drawing.Point(61, 77)
        Me.txtpreco.Name = "txtpreco"
        Me.txtpreco.Size = New System.Drawing.Size(361, 22)
        Me.txtpreco.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Preço"
        '
        'txtproduto
        '
        Me.txtproduto.Location = New System.Drawing.Point(61, 47)
        Me.txtproduto.Name = "txtproduto"
        Me.txtproduto.Size = New System.Drawing.Size(361, 22)
        Me.txtproduto.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Produto"
        '
        'txtcodprod
        '
        Me.txtcodprod.Location = New System.Drawing.Point(61, 13)
        Me.txtcodprod.Name = "txtcodprod"
        Me.txtcodprod.Size = New System.Drawing.Size(361, 22)
        Me.txtcodprod.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnpesquisar)
        Me.GroupBox2.Controls.Add(Me.btncancelar)
        Me.GroupBox2.Controls.Add(Me.btnexcluir)
        Me.GroupBox2.Controls.Add(Me.btnalterar)
        Me.GroupBox2.Controls.Add(Me.btnincluir)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(459, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(215, 211)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnpesquisar
        '
        Me.btnpesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnpesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnpesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnpesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpesquisar.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpesquisar.Image = CType(resources.GetObject("btnpesquisar.Image"), System.Drawing.Image)
        Me.btnpesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnpesquisar.Location = New System.Drawing.Point(142, 54)
        Me.btnpesquisar.Name = "btnpesquisar"
        Me.btnpesquisar.Size = New System.Drawing.Size(63, 75)
        Me.btnpesquisar.TabIndex = 9
        Me.btnpesquisar.Text = "Pesquisar"
        Me.btnpesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnpesquisar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(74, 92)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(62, 75)
        Me.btncancelar.TabIndex = 8
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnexcluir
        '
        Me.btnexcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnexcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnexcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexcluir.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexcluir.Image = CType(resources.GetObject("btnexcluir.Image"), System.Drawing.Image)
        Me.btnexcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnexcluir.Location = New System.Drawing.Point(74, 13)
        Me.btnexcluir.Name = "btnexcluir"
        Me.btnexcluir.Size = New System.Drawing.Size(62, 73)
        Me.btnexcluir.TabIndex = 7
        Me.btnexcluir.Text = "Excluir"
        Me.btnexcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnexcluir.UseVisualStyleBackColor = True
        '
        'btnalterar
        '
        Me.btnalterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnalterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnalterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnalterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnalterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnalterar.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalterar.Image = CType(resources.GetObject("btnalterar.Image"), System.Drawing.Image)
        Me.btnalterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnalterar.Location = New System.Drawing.Point(6, 92)
        Me.btnalterar.Name = "btnalterar"
        Me.btnalterar.Size = New System.Drawing.Size(62, 75)
        Me.btnalterar.TabIndex = 6
        Me.btnalterar.Text = "Alterar"
        Me.btnalterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnalterar.UseVisualStyleBackColor = True
        '
        'btnincluir
        '
        Me.btnincluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnincluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnincluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnincluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnincluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnincluir.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnincluir.Image = CType(resources.GetObject("btnincluir.Image"), System.Drawing.Image)
        Me.btnincluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnincluir.Location = New System.Drawing.Point(6, 13)
        Me.btnincluir.Name = "btnincluir"
        Me.btnincluir.Size = New System.Drawing.Size(62, 73)
        Me.btnincluir.TabIndex = 5
        Me.btnincluir.Text = "Salvar"
        Me.btnincluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnincluir.UseVisualStyleBackColor = True
        '
        'FornecedoresTableAdapter
        '
        Me.FornecedoresTableAdapter.ClearBeforeFill = True
        '
        'frmprodutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(678, 239)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmprodutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Produtos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PizzaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtquantidade As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpreco As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtproduto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcodprod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnpesquisar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnexcluir As Button
    Friend WithEvents btnalterar As Button
    Friend WithEvents btnincluir As Button
    Friend WithEvents txtCodBar As TextBox
    Friend WithEvents cboForn As ComboBox
    Friend WithEvents PizzaDataSet As pizzaDataSet
    Friend WithEvents FornecedoresBindingSource As BindingSource
    Friend WithEvents FornecedoresTableAdapter As pizzaDataSetTableAdapters.FornecedoresTableAdapter
    Friend WithEvents Label6 As Label
End Class
