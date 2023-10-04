Public Class goods

    Private Sub ТоварBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ТоварBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ТоварBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.shopeDataSet)
    End Sub

    Private Sub goods_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "shopeDataSet.Товар". При необходимости она может быть перемещена или удалена.
        Me.ТоварTableAdapter.Fill(Me.shopeDataSet.Товар)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class