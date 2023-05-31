<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.dgvDB = New System.Windows.Forms.DataGridView()
        Me.btnLimpaGrid = New System.Windows.Forms.Button()
        Me.btnRemoveNomeGrid = New System.Windows.Forms.Button()
        Me.txtNomeGrid = New System.Windows.Forms.TextBox()
        Me.btnContador = New System.Windows.Forms.Button()
        Me.txtContador = New System.Windows.Forms.TextBox()
        Me.rdbTodos = New System.Windows.Forms.RadioButton()
        Me.rdbQuantZero = New System.Windows.Forms.RadioButton()
        Me.btnGridLista = New System.Windows.Forms.Button()
        Me.btnLimpaLista = New System.Windows.Forms.Button()
        Me.btnContaLista = New System.Windows.Forms.Button()
        Me.lstNomes = New System.Windows.Forms.ListBox()
        Me.btnEliminaNomeList = New System.Windows.Forms.Button()
        Me.txtNomeLista = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.btnContaTabela = New System.Windows.Forms.Button()
        Me.lblErro = New System.Windows.Forms.Label()
        Me.txtContTable = New System.Windows.Forms.TextBox()
        Me.btnAtualizaLinha = New System.Windows.Forms.Button()
        Me.btnInsere = New System.Windows.Forms.Button()
        Me.txtInsNome = New System.Windows.Forms.TextBox()
        CType(Me.dgvDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(14, 14)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(266, 27)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "btnConnect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'dgvDB
        '
        Me.dgvDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDB.Location = New System.Drawing.Point(14, 46)
        Me.dgvDB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvDB.Name = "dgvDB"
        Me.dgvDB.Size = New System.Drawing.Size(1158, 435)
        Me.dgvDB.TabIndex = 1
        '
        'btnLimpaGrid
        '
        Me.btnLimpaGrid.Location = New System.Drawing.Point(285, 14)
        Me.btnLimpaGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLimpaGrid.Name = "btnLimpaGrid"
        Me.btnLimpaGrid.Size = New System.Drawing.Size(188, 27)
        Me.btnLimpaGrid.TabIndex = 2
        Me.btnLimpaGrid.Text = "Button1"
        Me.btnLimpaGrid.UseVisualStyleBackColor = True
        '
        'btnRemoveNomeGrid
        '
        Me.btnRemoveNomeGrid.Location = New System.Drawing.Point(476, 14)
        Me.btnRemoveNomeGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemoveNomeGrid.Name = "btnRemoveNomeGrid"
        Me.btnRemoveNomeGrid.Size = New System.Drawing.Size(246, 27)
        Me.btnRemoveNomeGrid.TabIndex = 3
        Me.btnRemoveNomeGrid.Text = "Button1"
        Me.btnRemoveNomeGrid.UseVisualStyleBackColor = True
        '
        'txtNomeGrid
        '
        Me.txtNomeGrid.Location = New System.Drawing.Point(726, 18)
        Me.txtNomeGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNomeGrid.Name = "txtNomeGrid"
        Me.txtNomeGrid.Size = New System.Drawing.Size(95, 23)
        Me.txtNomeGrid.TabIndex = 4
        '
        'btnContador
        '
        Me.btnContador.Location = New System.Drawing.Point(824, 14)
        Me.btnContador.Margin = New System.Windows.Forms.Padding(2)
        Me.btnContador.Name = "btnContador"
        Me.btnContador.Size = New System.Drawing.Size(141, 27)
        Me.btnContador.TabIndex = 5
        Me.btnContador.Text = "Button1"
        Me.btnContador.UseVisualStyleBackColor = True
        '
        'txtContador
        '
        Me.txtContador.Location = New System.Drawing.Point(968, 18)
        Me.txtContador.Margin = New System.Windows.Forms.Padding(2)
        Me.txtContador.Name = "txtContador"
        Me.txtContador.Size = New System.Drawing.Size(62, 23)
        Me.txtContador.TabIndex = 6
        '
        'rdbTodos
        '
        Me.rdbTodos.AutoSize = True
        Me.rdbTodos.Location = New System.Drawing.Point(672, 489)
        Me.rdbTodos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdbTodos.Name = "rdbTodos"
        Me.rdbTodos.Size = New System.Drawing.Size(97, 19)
        Me.rdbTodos.TabIndex = 7
        Me.rdbTodos.TabStop = True
        Me.rdbTodos.Text = "RadioButton1"
        Me.rdbTodos.UseVisualStyleBackColor = True
        '
        'rdbQuantZero
        '
        Me.rdbQuantZero.AutoSize = True
        Me.rdbQuantZero.Location = New System.Drawing.Point(926, 488)
        Me.rdbQuantZero.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rdbQuantZero.Name = "rdbQuantZero"
        Me.rdbQuantZero.Size = New System.Drawing.Size(97, 19)
        Me.rdbQuantZero.TabIndex = 8
        Me.rdbQuantZero.TabStop = True
        Me.rdbQuantZero.Text = "RadioButton2"
        Me.rdbQuantZero.UseVisualStyleBackColor = True
        '
        'btnGridLista
        '
        Me.btnGridLista.Location = New System.Drawing.Point(14, 534)
        Me.btnGridLista.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnGridLista.Name = "btnGridLista"
        Me.btnGridLista.Size = New System.Drawing.Size(220, 27)
        Me.btnGridLista.TabIndex = 9
        Me.btnGridLista.Text = "Button1"
        Me.btnGridLista.UseVisualStyleBackColor = True
        '
        'btnLimpaLista
        '
        Me.btnLimpaLista.Location = New System.Drawing.Point(15, 569)
        Me.btnLimpaLista.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLimpaLista.Name = "btnLimpaLista"
        Me.btnLimpaLista.Size = New System.Drawing.Size(219, 27)
        Me.btnLimpaLista.TabIndex = 10
        Me.btnLimpaLista.Text = "Button1"
        Me.btnLimpaLista.UseVisualStyleBackColor = True
        '
        'btnContaLista
        '
        Me.btnContaLista.Location = New System.Drawing.Point(15, 602)
        Me.btnContaLista.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnContaLista.Name = "btnContaLista"
        Me.btnContaLista.Size = New System.Drawing.Size(219, 27)
        Me.btnContaLista.TabIndex = 11
        Me.btnContaLista.Text = "Button2"
        Me.btnContaLista.UseVisualStyleBackColor = True
        '
        'lstNomes
        '
        Me.lstNomes.FormattingEnabled = True
        Me.lstNomes.ItemHeight = 15
        Me.lstNomes.Location = New System.Drawing.Point(253, 534)
        Me.lstNomes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstNomes.Name = "lstNomes"
        Me.lstNomes.Size = New System.Drawing.Size(139, 109)
        Me.lstNomes.TabIndex = 12
        '
        'btnEliminaNomeList
        '
        Me.btnEliminaNomeList.Location = New System.Drawing.Point(401, 533)
        Me.btnEliminaNomeList.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnEliminaNomeList.Name = "btnEliminaNomeList"
        Me.btnEliminaNomeList.Size = New System.Drawing.Size(147, 27)
        Me.btnEliminaNomeList.TabIndex = 13
        Me.btnEliminaNomeList.Text = "Button1"
        Me.btnEliminaNomeList.UseVisualStyleBackColor = True
        '
        'txtNomeLista
        '
        Me.txtNomeLista.Location = New System.Drawing.Point(401, 568)
        Me.txtNomeLista.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNomeLista.Name = "txtNomeLista"
        Me.txtNomeLista.Size = New System.Drawing.Size(146, 23)
        Me.txtNomeLista.TabIndex = 14
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(0, 516)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(41, 15)
        Me.lbl1.TabIndex = 15
        Me.lbl1.Text = "Label1"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(0, 647)
        Me.lbl2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(41, 15)
        Me.lbl2.TabIndex = 16
        Me.lbl2.Text = "Label1"
        '
        'btnContaTabela
        '
        Me.btnContaTabela.Location = New System.Drawing.Point(15, 736)
        Me.btnContaTabela.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnContaTabela.Name = "btnContaTabela"
        Me.btnContaTabela.Size = New System.Drawing.Size(203, 27)
        Me.btnContaTabela.TabIndex = 17
        Me.btnContaTabela.Text = "Button1"
        Me.btnContaTabela.UseVisualStyleBackColor = True
        '
        'lblErro
        '
        Me.lblErro.AutoSize = True
        Me.lblErro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblErro.ForeColor = System.Drawing.Color.Red
        Me.lblErro.Location = New System.Drawing.Point(238, 485)
        Me.lblErro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblErro.Name = "lblErro"
        Me.lblErro.Size = New System.Drawing.Size(63, 20)
        Me.lblErro.TabIndex = 18
        Me.lblErro.Text = "Label1"
        '
        'txtContTable
        '
        Me.txtContTable.Location = New System.Drawing.Point(243, 738)
        Me.txtContTable.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtContTable.Name = "txtContTable"
        Me.txtContTable.Size = New System.Drawing.Size(116, 23)
        Me.txtContTable.TabIndex = 19
        '
        'btnAtualizaLinha
        '
        Me.btnAtualizaLinha.Location = New System.Drawing.Point(15, 703)
        Me.btnAtualizaLinha.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAtualizaLinha.Name = "btnAtualizaLinha"
        Me.btnAtualizaLinha.Size = New System.Drawing.Size(344, 27)
        Me.btnAtualizaLinha.TabIndex = 20
        Me.btnAtualizaLinha.Text = "Button1"
        Me.btnAtualizaLinha.UseVisualStyleBackColor = True
        '
        'btnInsere
        '
        Me.btnInsere.Location = New System.Drawing.Point(15, 771)
        Me.btnInsere.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnInsere.Name = "btnInsere"
        Me.btnInsere.Size = New System.Drawing.Size(344, 50)
        Me.btnInsere.TabIndex = 21
        Me.btnInsere.Text = "Button1"
        Me.btnInsere.UseVisualStyleBackColor = True
        '
        'txtInsNome
        '
        Me.txtInsNome.Location = New System.Drawing.Point(369, 784)
        Me.txtInsNome.Name = "txtInsNome"
        Me.txtInsNome.Size = New System.Drawing.Size(100, 23)
        Me.txtInsNome.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 836)
        Me.Controls.Add(Me.txtInsNome)
        Me.Controls.Add(Me.btnInsere)
        Me.Controls.Add(Me.btnAtualizaLinha)
        Me.Controls.Add(Me.txtContTable)
        Me.Controls.Add(Me.lblErro)
        Me.Controls.Add(Me.btnContaTabela)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtNomeLista)
        Me.Controls.Add(Me.btnEliminaNomeList)
        Me.Controls.Add(Me.lstNomes)
        Me.Controls.Add(Me.btnContaLista)
        Me.Controls.Add(Me.btnLimpaLista)
        Me.Controls.Add(Me.btnGridLista)
        Me.Controls.Add(Me.rdbQuantZero)
        Me.Controls.Add(Me.rdbTodos)
        Me.Controls.Add(Me.txtContador)
        Me.Controls.Add(Me.btnContador)
        Me.Controls.Add(Me.txtNomeGrid)
        Me.Controls.Add(Me.btnRemoveNomeGrid)
        Me.Controls.Add(Me.btnLimpaGrid)
        Me.Controls.Add(Me.dgvDB)
        Me.Controls.Add(Me.btnConnect)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConnect As Button
    Friend WithEvents dgvDB As DataGridView
    Friend WithEvents btnLimpaGrid As Button
    Friend WithEvents btnRemoveNomeGrid As Button
    Friend WithEvents txtNomeGrid As TextBox
    Friend WithEvents btnContador As Button
    Friend WithEvents txtContador As TextBox
    Friend WithEvents rdbTodos As RadioButton
    Friend WithEvents rdbQuantZero As RadioButton
    Friend WithEvents btnGridLista As Button
    Friend WithEvents btnLimpaLista As Button
    Friend WithEvents btnContaLista As Button
    Friend WithEvents lstNomes As ListBox
    Friend WithEvents btnEliminaNomeList As Button
    Friend WithEvents txtNomeLista As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents btnContaTabela As Button
    Friend WithEvents lblErro As Label
    Friend WithEvents txtContTable As TextBox
    Friend WithEvents btnAtualizaLinha As Button
    Friend WithEvents btnInsere As Button
    Friend WithEvents txtInsNome As TextBox
End Class
