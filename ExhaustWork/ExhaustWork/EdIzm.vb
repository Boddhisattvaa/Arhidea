Public Class EdIzm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub ЕдИзмBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЕдИзмBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ЕдИзмBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.shopeDataSet)

    End Sub

    Private Sub EdIzm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "shopeDataSet.ЕдИзм". При необходимости она может быть перемещена или удалена.
        Me.ЕдИзмTableAdapter.Fill(Me.shopeDataSet.ЕдИзм)

    End Sub
End Class