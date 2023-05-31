<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbxCategorias = New System.Windows.Forms.ComboBox()
        Me.cbxFornecedores = New System.Windows.Forms.ComboBox()
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.btnTodasCat = New System.Windows.Forms.Button()
        Me.btnTodosForn = New System.Windows.Forms.Button()
        Me.btnTodosProd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotLin = New System.Windows.Forms.Label()
        Me.lblPrecMed = New System.Windows.Forms.Label()
        Me.lblMaisCaro = New System.Windows.Forms.Label()
        Me.txtTotLin = New System.Windows.Forms.TextBox()
        Me.txtPrecMed = New System.Windows.Forms.TextBox()
        Me.txtMaisCaro = New System.Windows.Forms.TextBox()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxCategorias
        '
        Me.cbxCategorias.FormattingEnabled = True
        Me.cbxCategorias.Location = New System.Drawing.Point(12, 42)
        Me.cbxCategorias.Name = "cbxCategorias"
        Me.cbxCategorias.Size = New System.Drawing.Size(177, 21)
        Me.cbxCategorias.TabIndex = 0
        '
        'cbxFornecedores
        '
        Me.cbxFornecedores.FormattingEnabled = True
        Me.cbxFornecedores.Location = New System.Drawing.Point(195, 42)
        Me.cbxFornecedores.Name = "cbxFornecedores"
        Me.cbxFornecedores.Size = New System.Drawing.Size(219, 21)
        Me.cbxFornecedores.TabIndex = 1
        '
        'dgvProdutos
        '
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos.Location = New System.Drawing.Point(12, 96)
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.Size = New System.Drawing.Size(958, 355)
        Me.dgvProdutos.TabIndex = 2
        '
        'btnTodasCat
        '
        Me.btnTodasCat.Location = New System.Drawing.Point(12, 12)
        Me.btnTodasCat.Name = "btnTodasCat"
        Me.btnTodasCat.Size = New System.Drawing.Size(177, 23)
        Me.btnTodasCat.TabIndex = 3
        Me.btnTodasCat.Text = "Button1"
        Me.btnTodasCat.UseVisualStyleBackColor = True
        '
        'btnTodosForn
        '
        Me.btnTodosForn.Location = New System.Drawing.Point(195, 13)
        Me.btnTodosForn.Name = "btnTodosForn"
        Me.btnTodosForn.Size = New System.Drawing.Size(219, 23)
        Me.btnTodosForn.TabIndex = 4
        Me.btnTodosForn.Text = "Button1"
        Me.btnTodosForn.UseVisualStyleBackColor = True
        '
        'btnTodosProd
        '
        Me.btnTodosProd.Location = New System.Drawing.Point(460, 13)
        Me.btnTodosProd.Name = "btnTodosProd"
        Me.btnTodosProd.Size = New System.Drawing.Size(160, 23)
        Me.btnTodosProd.TabIndex = 5
        Me.btnTodosProd.Text = "Button1"
        Me.btnTodosProd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(636, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Button1"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotLin
        '
        Me.lblTotLin.AutoSize = True
        Me.lblTotLin.Location = New System.Drawing.Point(12, 458)
        Me.lblTotLin.Name = "lblTotLin"
        Me.lblTotLin.Size = New System.Drawing.Size(39, 13)
        Me.lblTotLin.TabIndex = 7
        Me.lblTotLin.Text = "Label1"
        '
        'lblPrecMed
        '
        Me.lblPrecMed.AutoSize = True
        Me.lblPrecMed.Location = New System.Drawing.Point(123, 458)
        Me.lblPrecMed.Name = "lblPrecMed"
        Me.lblPrecMed.Size = New System.Drawing.Size(39, 13)
        Me.lblPrecMed.TabIndex = 8
        Me.lblPrecMed.Text = "Label2"
        '
        'lblMaisCaro
        '
        Me.lblMaisCaro.AutoSize = True
        Me.lblMaisCaro.Location = New System.Drawing.Point(241, 457)
        Me.lblMaisCaro.Name = "lblMaisCaro"
        Me.lblMaisCaro.Size = New System.Drawing.Size(39, 13)
        Me.lblMaisCaro.TabIndex = 9
        Me.lblMaisCaro.Text = "Label3"
        '
        'txtTotLin
        '
        Me.txtTotLin.Location = New System.Drawing.Point(15, 475)
        Me.txtTotLin.Name = "txtTotLin"
        Me.txtTotLin.Size = New System.Drawing.Size(77, 20)
        Me.txtTotLin.TabIndex = 10
        '
        'txtPrecMed
        '
        Me.txtPrecMed.Location = New System.Drawing.Point(126, 475)
        Me.txtPrecMed.Name = "txtPrecMed"
        Me.txtPrecMed.Size = New System.Drawing.Size(77, 20)
        Me.txtPrecMed.TabIndex = 11
        '
        'txtMaisCaro
        '
        Me.txtMaisCaro.Location = New System.Drawing.Point(244, 475)
        Me.txtMaisCaro.Name = "txtMaisCaro"
        Me.txtMaisCaro.Size = New System.Drawing.Size(276, 20)
        Me.txtMaisCaro.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 574)
        Me.Controls.Add(Me.txtMaisCaro)
        Me.Controls.Add(Me.txtPrecMed)
        Me.Controls.Add(Me.txtTotLin)
        Me.Controls.Add(Me.lblMaisCaro)
        Me.Controls.Add(Me.lblPrecMed)
        Me.Controls.Add(Me.lblTotLin)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTodosProd)
        Me.Controls.Add(Me.btnTodosForn)
        Me.Controls.Add(Me.btnTodasCat)
        Me.Controls.Add(Me.dgvProdutos)
        Me.Controls.Add(Me.cbxFornecedores)
        Me.Controls.Add(Me.cbxCategorias)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxCategorias As ComboBox
    Friend WithEvents cbxFornecedores As ComboBox
    Friend WithEvents dgvProdutos As DataGridView
    Friend WithEvents btnTodasCat As Button
    Friend WithEvents btnTodosForn As Button
    Friend WithEvents btnTodosProd As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotLin As Label
    Friend WithEvents lblPrecMed As Label
    Friend WithEvents lblMaisCaro As Label
    Friend WithEvents txtTotLin As TextBox
    Friend WithEvents txtPrecMed As TextBox
    Friend WithEvents txtMaisCaro As TextBox
End Class
