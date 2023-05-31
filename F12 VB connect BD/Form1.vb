Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnConnect.Text = "Copia da BD os produtos para a grid"
        btnLimpaGrid.Text = "Limpa a grid"
        btnRemoveNomeGrid.Text = "Remove este nome da grid"
        btnContador.Text = "Conta na grid"
        rdbTodos.Text = "Todos da BD para grid"
        rdbQuantZero.Text = "Da BD para a grid, apenas quant. zero"
        lbl1.Text = "_________________________________________________________________________________________________________________________________________________________________________"
        lbl2.Text = "_________________________________________________________________________________________________________________________________________________________________________"
        btnGridLista.Text = "Nomes da grid para a lista"
        btnLimpaLista.Text = "Limpa a lista"
        btnContaLista.Text = "Conta elementos na lista"
        btnEliminaNomeList.Text = "Elimina este nome da lista"
        btnContaTabela.Text = "Conta produtos na tabela"
        lblErro.Text = ""
        btnAtualizaLinha.Text = "Atualiza linha corrente da grid, para a tabela"
        btnInsere.Text = "Insere das texts para a tabela (nome, fornecedor, categoria, preço) [Nota 1: o identity está ativo? | Nota 2: o campo]"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim obj As New DataBaseAccess 'INSTANCIAR A CLASSE FORNECIDA

        Dim sc As String = obj.ConnectionString 'qual a string connection?
        Dim ssql As String

        If rdbTodos.Checked Then
            ssql = "Select * From Produtos;" 'que dados trazer?
        ElseIf rdbQuantZero.Checked Then
            ssql = "Select * From Produtos WHERE Existências = 0;" 'que dados trazer?
        End If

        Try
            dgvDB.DataSource = obj.BuscaDados(sc, ssql)
        Catch
            lblErro.Text = "Selecione a forma como quer os dados! ->"
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnLimpaGrid.Click
        dgvDB.Columns.Clear()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnRemoveNomeGrid.Click
        For i = 0 To dgvDB.Rows.Count - 2
            If txtNomeGrid.Text = dgvDB.Rows(i).Cells(1).Value Then
                dgvDB.Rows.RemoveAt(i)
            End If
        Next
    End Sub

    Private Sub btnContador_Click(sender As Object, e As EventArgs) Handles btnContador.Click
        If dgvDB.Rows.Count() = 0 Then
            txtContador.Text = dgvDB.Rows.Count()
        Else
            txtContador.Text = dgvDB.Rows.Count() - 1
        End If

    End Sub

    Private Sub rdbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTodos.CheckedChanged
        lblErro.Text = ""
    End Sub

    Private Sub btnGridLista_Click(sender As Object, e As EventArgs) Handles btnGridLista.Click
        For i = 0 To dgvDB.Rows.Count - 2
            lstNomes.Items.Add(dgvDB.Rows(i).Cells(1).Value)
        Next
    End Sub

    Private Sub btnLimpaLista_Click(sender As Object, e As EventArgs) Handles btnLimpaLista.Click
        lstNomes.Items.Clear()
    End Sub

    Private Sub btnContaLista_Click(sender As Object, e As EventArgs) Handles btnContaLista.Click
        ''txtNomeLista.Text = lstNomes.Items.Count

        MessageBox.Show("TOTAL NOMES na lista: " + CStr(lstNomes.Items.Count))
    End Sub

    Private Sub btnEliminaNomeList_Click(sender As Object, e As EventArgs) Handles btnEliminaNomeList.Click
        lstNomes.Items.Remove(txtNomeLista.Text)
    End Sub

    Private Sub btnContaTabela_Click(sender As Object, e As EventArgs) Handles btnContaTabela.Click

        Dim obj As New DataBaseAccess 'INSTANCIAR A CLASSE FORNECIDA

        Dim sc As String = obj.ConnectionString 'qual a string connection?
        Dim ssql As String = "SELECT count(*) FROM Produtos;" 'que dados trazer?
        txtContTable.Text = obj.BuscaDados(sc, ssql).Rows(0)(0).ToString
    End Sub

    Private Sub rdbQuantZero_CheckedChanged(sender As Object, e As EventArgs) Handles rdbQuantZero.CheckedChanged
        lblErro.Text = ""
    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles btnAtualizaLinha.Click
        Dim obj As New DataBaseAccess 'INSTANCIAR A CLASSE FORNECIDA

        Dim sc As String = obj.ConnectionString 'qual a string connection?

        Dim c1 As String
        c1 = dgvDB.CurrentRow.Cells(0).Value
        Dim c2 As String
        c2 = dgvDB.CurrentRow.Cells(1).Value
        Dim c3 As String
        c3 = dgvDB.CurrentRow.Cells(2).Value
        Dim c4
        c4 = dgvDB.CurrentRow.Cells(3).Value
        Dim c5
        c5 = dgvDB.CurrentRow.Cells(4).Value
        Dim c6
        c6 = dgvDB.CurrentRow.Cells(5).Value
        Dim c7
        c7 = dgvDB.CurrentRow.Cells(6).Value
        Dim c8
        c8 = dgvDB.CurrentRow.Cells(7).Value
        Dim c9
        c9 = dgvDB.CurrentRow.Cells(8).Value


        ''Dim ssql As String = "UPDATE Produtos SET NomeDoProduto = '" + c2 + "' " + "AND CódigoDoFornecedor = '" + c3 + "' " + "AND CódigoDaCategoria = '" + c4 + "WHERE CódigoDoProduto = " + c1 + ";"
        Dim ssql As String = "UPDATE Produtos SET NomeDoProduto = '" + c2 + "' " + ", CódigoDoProduto = '" + c3 + "' " + "WHERE CódigoDoProduto = " + c1 + ";"
        ''MessageBox.Show(ssql)

        obj.BuscaDados(sc, ssql)
    End Sub

    Private Sub btnInsere_Click(sender As Object, e As EventArgs) Handles btnInsere.Click
        Dim obj As New DataBaseAccess 'INSTANCIAR A CLASSE FORNECIDA
        Dim sc As String = obj.ConnectionString 'qual a string connection?

        ''INSERT INTO Categorias (CódigoDaCategoria, NomeDaCategoria) VALUES (11, 'frutas');


        Dim ssql As String = "INSERT INTO Produtos (CódigoDoProduto, NomeDoProduto, Descontinuado) VALUES (200, '" & txtInsNome.Text.ToString & "',0);"
        obj.BuscaDados(sc, ssql)
    End Sub
End Class
