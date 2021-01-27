<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaida))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQte = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PizzaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PizzaDataSet = New pizzaria.pizzaDataSet()
        Me.cboCodBar = New System.Windows.Forms.ComboBox()
        Me.ProdutosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FornecedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSaida = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.checagem = New System.Windows.Forms.Timer(Me.components)
        Me.ProdutosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdutosTableAdapter = New pizzaria.pizzaDataSetTableAdapters.ProdutosTableAdapter()
        Me.variavel = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PizzaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PizzaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código de Barras"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(334, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Quantidade"
        '
        'txtQte
        '
        Me.txtQte.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQte.Location = New System.Drawing.Point(337, 36)
        Me.txtQte.Name = "txtQte"
        Me.txtQte.Size = New System.Drawing.Size(148, 21)
        Me.txtQte.TabIndex = 2
        Me.txtQte.Text = "0"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.PizzaDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(473, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'PizzaDataSetBindingSource
        '
        Me.PizzaDataSetBindingSource.DataSource = Me.PizzaDataSet
        Me.PizzaDataSetBindingSource.Position = 0
        '
        'PizzaDataSet
        '
        Me.PizzaDataSet.DataSetName = "pizzaDataSet"
        Me.PizzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboCodBar
        '
        Me.cboCodBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCodBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCodBar.DataSource = Me.ProdutosBindingSource2
        Me.cboCodBar.DisplayMember = "CodBar"
        Me.cboCodBar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCodBar.FormattingEnabled = True
        Me.cboCodBar.Location = New System.Drawing.Point(12, 36)
        Me.cboCodBar.Name = "cboCodBar"
        Me.cboCodBar.Size = New System.Drawing.Size(126, 21)
        Me.cboCodBar.TabIndex = 0
        '
        'ProdutosBindingSource2
        '
        Me.ProdutosBindingSource2.DataMember = "Produtos"
        Me.ProdutosBindingSource2.DataSource = Me.PizzaDataSetBindingSource
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.BackColor = System.Drawing.Color.Transparent
        Me.lblDescricao.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDescricao.Location = New System.Drawing.Point(154, 19)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(72, 14)
        Me.lblDescricao.TabIndex = 9
        Me.lblDescricao.Text = "Descrição"
        '
        'txtDesc
        '
        Me.txtDesc.Enabled = False
        Me.txtDesc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(144, 36)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(187, 21)
        Me.txtDesc.TabIndex = 1
        '
        'Timer1
        '
        '
        'FornecedoresBindingSource
        '
        Me.FornecedoresBindingSource.DataMember = "Fornecedores"
        Me.FornecedoresBindingSource.DataSource = Me.PizzaDataSetBindingSource
        '
        'ProdutosBindingSource
        '
        Me.ProdutosBindingSource.DataMember = "Produtos"
        Me.ProdutosBindingSource.DataSource = Me.PizzaDataSetBindingSource
        '
        'btnSaida
        '
        Me.btnSaida.BackColor = System.Drawing.Color.Transparent
        Me.btnSaida.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaida.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSaida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaida.Image = CType(resources.GetObject("btnSaida.Image"), System.Drawing.Image)
        Me.btnSaida.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSaida.Location = New System.Drawing.Point(505, 36)
        Me.btnSaida.Name = "btnSaida"
        Me.btnSaida.Size = New System.Drawing.Size(62, 66)
        Me.btnSaida.TabIndex = 4
        Me.btnSaida.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSaida.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(505, 130)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 71)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Pesquisar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'checagem
        '
        Me.checagem.Enabled = True
        '
        'ProdutosBindingSource1
        '
        Me.ProdutosBindingSource1.DataMember = "Produtos"
        Me.ProdutosBindingSource1.DataSource = Me.PizzaDataSet
        '
        'ProdutosTableAdapter
        '
        Me.ProdutosTableAdapter.ClearBeforeFill = True
        '
        'variavel
        '
        '
        'frmSaida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(579, 230)
        Me.Controls.Add(Me.lblDescricao)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.btnSaida)
        Me.Controls.Add(Me.cboCodBar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtQte)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmSaida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saida"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PizzaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PizzaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQte As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PizzaDataSetBindingSource As BindingSource
    Friend WithEvents PizzaDataSet As pizzaDataSet
    Friend WithEvents btnBuscar As Button
    Friend WithEvents cboCodBar As ComboBox
    Friend WithEvents btnSaida As Button
    Friend WithEvents lblDescricao As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FornecedoresBindingSource As BindingSource
    Friend WithEvents ProdutosBindingSource As BindingSource
    Friend WithEvents ProdutosBindingSource1 As BindingSource
    Friend WithEvents checagem As Timer
    Friend WithEvents ProdutosBindingSource2 As BindingSource
    Friend WithEvents ProdutosTableAdapter As pizzaDataSetTableAdapters.ProdutosTableAdapter
    Friend WithEvents variavel As Timer
End Class
