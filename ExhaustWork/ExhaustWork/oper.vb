Public Class oper

    Private Sub КодОперацииBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles КодОперацииBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.КодОперацииBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.shopeDataSet)

    End Sub

    Private Sub oper_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "shopeDataSet.КодОперации". При необходимости она может быть перемещена или удалена.
        Me.КодОперацииTableAdapter.Fill(Me.shopeDataSet.КодОперации)

    End Sub

    Private Sub КодОперацииDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles КодОперацииDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class