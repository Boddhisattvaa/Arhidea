Public Class ClientReg

    Private Sub SrttbclientBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SrttbclientBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SrttbclientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.shopeDataSet)

    End Sub

    Private Sub ClientReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'shopeDataSet.srttbclient' table. You can move, or remove it, as needed.
        Me.SrttbclientTableAdapter.Fill(Me.shopeDataSet.srttbclient)

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class