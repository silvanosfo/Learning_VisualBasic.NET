Public Class Form1
    Private Sub LoadCat()
        Dim obj As New DataBaseAccess
        Dim sc As String = obj.ConnectionString
        Dim ssql1 As String = "Select CódigoDaCategoria, NomeDaCategoria From Categorias"
        cbxCategorias.DataSource = obj.BuscaDados(sc, ssql1)
        cbxCategorias.DisplayMember = "NomeDaCategoria"
        cbxCategorias.ValueMember = "CódigoDaCategoria"


        cbxCategorias.SelectedValue = -1
        cbxCategorias.SelectedText = ""


    End Sub

    Private Sub LoadForn()
        Dim obj As New DataBaseAccess
        Dim sc As String = obj.ConnectionString
        Dim ssql2 As String = "Select CódigoDoFornecedor, NomeDaEmpresa From Fornecedores"
        cbxFornecedores.DataSource = obj.BuscaDados(sc, ssql2)
        cbxFornecedores.DisplayMember = "NomeDaEmpresa"
        cbxFornecedores.ValueMember = "CódigoDoFornecedor"

        cbxFornecedores.SelectedValue = -1
        cbxFornecedores.SelectedText = ""
    End Sub

    Private Sub FillGrid()
        Dim obj As New DataBaseAccess
        Dim sc As String = obj.ConnectionString
        Dim ssql As String
        cbxCategorias.ValueMember = "CódigoDaCategoria"
        cbxFornecedores.ValueMember = "CódigoDoFornecedor"

        ssql = "SELECT * FROM Produtos WHERE "

        If cbxCategorias.Text = "Todas" And cbxFornecedores.Text <> "Todos" Then
            ssql = ssql & "CódigoDoFornecedor = '" & cbxFornecedores.SelectedValue & "';"

        ElseIf cbxFornecedores.Text = "Todos" And cbxCategorias.Text <> "Todas" Then
            ssql = ssql & "CódigoDaCategoria = '" & cbxCategorias.SelectedValue & "';"

        ElseIf cbxFornecedores.Text = "Todos" And cbxCategorias.Text = "Todas" Then
            ssql = "SELECT * FROM Produtos"
        Else
            ssql = ssql & "CódigoDaCategoria = '" & cbxCategorias.SelectedValue & "' And CódigoDoFornecedor = '" & cbxFornecedores.SelectedValue & "';"
        End If

        dgvProdutos.DataSource = obj.BuscaDados(sc, ssql)
        Try
            AtualizaInfo()
        Catch

        End Try
    End Sub

    Private Sub AtualizaInfo()
        txtTotLin.Text = dgvProdutos.Rows.Count - 1

        Dim maisCaro As Double = dgvProdutos.Rows(0).Cells(4).Value
        Dim media As Double
        Dim soma As Double = 0
        Dim i As Integer = 0
        For i = 0 To dgvProdutos.Rows.Count() - 2
            soma = soma + CInt(dgvProdutos.Rows(i).Cells(4).Value)
            If maisCaro < dgvProdutos.Rows(i).Cells(4).Value Then
                maisCaro = dgvProdutos.Rows(i).Cells(4).Value
            End If
        Next
        media = soma / (dgvProdutos.Rows.Count - 1)
        txtPrecMed.Text = media
        txtMaisCaro.Text = dgvProdutos.Rows(i).Cells(1).Value & " ( " & dgvProdutos.Rows(i).Cells(4).Value.ToString & " ) "


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnTodasCat.Text = "Todas as Categorias"
        btnTodosForn.Text = "Todos os Fornecedores"
        btnTodosProd.Text = "Todos os Produtos"
        btnExit.Text = "EXIT"
        lblTotLin.Text = "Total de linhas"
        lblPrecMed.Text = "Preço médio"
        lblMaisCaro.Text = "Produto e preço (mais caro)"

        LoadCat()
        LoadForn()
    End Sub

    Private Sub cbxCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategorias.SelectedIndexChanged
        FillGrid()
    End Sub

    Private Sub cbxFornecedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxFornecedores.SelectedIndexChanged
        FillGrid()
    End Sub

    Private Sub btnTodasCat_Click(sender As Object, e As EventArgs) Handles btnTodasCat.Click
        cbxCategorias.Text = "Todas"
        FillGrid()
    End Sub

    Private Sub btnTodosForn_Click(sender As Object, e As EventArgs) Handles btnTodosForn.Click
        cbxFornecedores.Text = "Todos"
        FillGrid()
    End Sub

    Private Sub btnTodosProd_Click(sender As Object, e As EventArgs) Handles btnTodosProd.Click
        cbxCategorias.Text = "Todas"
        cbxFornecedores.Text = "Todos"
        FillGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
