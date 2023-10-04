Public Class zForm5

    Private Sub zForm5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "shopeDataSet.Sale". При необходимости она может быть перемещена или удалена.
        Me.SaleTableAdapter.Fill(Me.shopeDataSet.Sale)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "shopeDataSet.Sale". При необходимости она может быть перемещена или удалена.
        Me.SaleTableAdapter.Fill(Me.shopeDataSet.Sale)

    End Sub

    Private Sub SaleBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SaleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.shopeDataSet)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.SaleDataGridView.EndEdit(True)
        Me.SaleTableAdapter.Update(Me.shopeDataSet)
        Me.SaleTableAdapter.Fill(Me.shopeDataSet.Sale)
        'SaleDataGridView.Rows.Clear()
        SaleDataGridView.Columns.Clear()
        SaleDataGridView.Columns.Add("Наименование", "ss")

    End Sub
   
End Class