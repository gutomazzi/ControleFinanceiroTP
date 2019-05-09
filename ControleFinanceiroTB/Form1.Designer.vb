<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblcredito = New System.Windows.Forms.Label()
        Me.lbldebito = New System.Windows.Forms.Label()
        Me.lblsaldo = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tipo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbcategoria = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdata = New System.Windows.Forms.MaskedTextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvlanc = New System.Windows.Forms.DataGridView()
        Me.btnremover = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvlanc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(686, 75)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(430, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CONTROLE FINANCEIRO"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel2.Controls.Add(Me.lblsaldo)
        Me.Panel2.Controls.Add(Me.lbldebito)
        Me.Panel2.Controls.Add(Me.lblcredito)
        Me.Panel2.Location = New System.Drawing.Point(2, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(686, 60)
        Me.Panel2.TabIndex = 1
        '
        'lblcredito
        '
        Me.lblcredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblcredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcredito.ForeColor = System.Drawing.Color.White
        Me.lblcredito.Location = New System.Drawing.Point(24, 12)
        Me.lblcredito.Name = "lblcredito"
        Me.lblcredito.Size = New System.Drawing.Size(181, 38)
        Me.lblcredito.TabIndex = 0
        Me.lblcredito.Text = "R$00,00"
        Me.lblcredito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldebito
        '
        Me.lbldebito.BackColor = System.Drawing.Color.Red
        Me.lbldebito.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldebito.ForeColor = System.Drawing.Color.White
        Me.lbldebito.Location = New System.Drawing.Point(250, 12)
        Me.lbldebito.Name = "lbldebito"
        Me.lbldebito.Size = New System.Drawing.Size(181, 38)
        Me.lbldebito.TabIndex = 1
        Me.lbldebito.Text = "R$00,00"
        Me.lbldebito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblsaldo
        '
        Me.lblsaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblsaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsaldo.ForeColor = System.Drawing.Color.White
        Me.lblsaldo.Location = New System.Drawing.Point(471, 12)
        Me.lblsaldo.Name = "lblsaldo"
        Me.lblsaldo.Size = New System.Drawing.Size(181, 38)
        Me.lblsaldo.TabIndex = 2
        Me.lblsaldo.Text = "R$00,00"
        Me.lblsaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnremover)
        Me.Panel3.Controls.Add(Me.dgvlanc)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.btnadd)
        Me.Panel3.Controls.Add(Me.txtdata)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.cmbcategoria)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtvalor)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.tipo)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtdesc)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(5, 146)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(304, 366)
        Me.Panel3.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Descrição"
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(9, 34)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(275, 20)
        Me.txtdesc.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Tipo"
        '
        'tipo
        '
        Me.tipo.FormattingEnabled = True
        Me.tipo.Items.AddRange(New Object() {"CREDITO", "DEBITO"})
        Me.tipo.Location = New System.Drawing.Point(9, 82)
        Me.tipo.Name = "tipo"
        Me.tipo.Size = New System.Drawing.Size(120, 21)
        Me.tipo.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(162, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 18)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Valor (R$)"
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(165, 82)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(119, 20)
        Me.txtvalor.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Categoria"
        '
        'cmbcategoria
        '
        Me.cmbcategoria.FormattingEnabled = True
        Me.cmbcategoria.Items.AddRange(New Object() {"SALARIO", "LAZER", "ALIMENTAÇÃO", "SAUDE", "ALUGUEL"})
        Me.cmbcategoria.Location = New System.Drawing.Point(9, 126)
        Me.cmbcategoria.Name = "cmbcategoria"
        Me.cmbcategoria.Size = New System.Drawing.Size(121, 21)
        Me.cmbcategoria.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(165, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Data"
        '
        'txtdata
        '
        Me.txtdata.Location = New System.Drawing.Point(165, 127)
        Me.txtdata.Mask = "00/00/0000"
        Me.txtdata.Name = "txtdata"
        Me.txtdata.Size = New System.Drawing.Size(119, 20)
        Me.txtdata.TabIndex = 9
        Me.txtdata.ValidatingType = GetType(Date)
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(9, 153)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(269, 20)
        Me.btnadd.TabIndex = 10
        Me.btnadd.Text = "ADICIONAR"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 18)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Últimos Lançamentos"
        '
        'dgvlanc
        '
        Me.dgvlanc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlanc.Location = New System.Drawing.Point(9, 192)
        Me.dgvlanc.Name = "dgvlanc"
        Me.dgvlanc.Size = New System.Drawing.Size(275, 134)
        Me.dgvlanc.TabIndex = 12
        '
        'btnremover
        '
        Me.btnremover.Location = New System.Drawing.Point(9, 332)
        Me.btnremover.Name = "btnremover"
        Me.btnremover.Size = New System.Drawing.Size(275, 21)
        Me.btnremover.TabIndex = 13
        Me.btnremover.Text = "REMOVER"
        Me.btnremover.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 524)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvlanc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblsaldo As Label
    Friend WithEvents lbldebito As Label
    Friend WithEvents lblcredito As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnremover As Button
    Friend WithEvents dgvlanc As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents txtdata As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbcategoria As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tipo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents Label5 As Label
End Class
