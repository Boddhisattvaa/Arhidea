Imports System.Data.SqlClient

Public Class SotrudSearch

    Private Sub SrttbclientBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SrttbclientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.shopeDataSet)

    End Sub

    Private Sub SotrudSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'shopeDataSet.srttbclient' table. You can move, or remove it, as needed.
        Me.SrttbclientTableAdapter.Fill(Me.shopeDataSet.srttbclient)
        NameComboBox.ResetText()
    End Sub

    Private Sub NameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameComboBox.SelectedIndexChanged
        Dim Cn As SqlConnection
        Cn = New SqlConnection()
        Cn.ConnectionString = "Data Source=DESKTOP-BCTG9KC;Initial Catalog=SHOPE;Integrated Security=True"
        Cn.Open()

        Dim str As String = "SELECT srttbclient.Name AS Клиент, SUM(Srttbgoodsclient.CountMoney) AS Сумма FROM  srttbclient INNER JOIN Srttbgoodsclient ON srttbclient.IDClient = Srttbgoodsclient.IDClient Where  srttbclient.Name='" & NameComboBox.Text & "'  GROUP BY srttbclient.Name "

        Dim A As SqlDataAdapter
        A = New SqlDataAdapter(str, Cn)

        Dim DB As DataSet = New DataSet

        A.Fill(DB)
        DataGridView1.DataSource = DB.Tables(0)
    End Sub
End Class