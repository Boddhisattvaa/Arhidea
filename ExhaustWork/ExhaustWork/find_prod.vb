Imports System.Data.SqlClient
Public Class find_prod

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        msg = "Вы уверены что хотите удалить выбранную запись?"   ' Define message.
        style = MsgBoxStyle.DefaultButton2 Or _
           MsgBoxStyle.OkOnly Or MsgBoxStyle.YesNo
        title = "Внимание"   ' Define title.
        ' Display message.
        response = MsgBox(msg, style, title)
        If response = MsgBoxResult.Yes Then   ' User chose Yes.

            Dim oleConnect As New SqlConnection
            Dim oleCommanda, oleCommanda2 As New SqlCommand

            oleConnect.ConnectionString = "Data Source=DESKTOP-BCTG9KC;Initial Catalog=SHOPE;Integrated Security=True"

            oleCommanda.Connection = oleConnect
            oleCommanda.CommandType = CommandType.Text
            oleCommanda.CommandText = "Delete From Sale Where Дата='" & TextBox2.Text & "'"

            oleCommanda2.Connection = oleConnect
            oleCommanda2.CommandType = CommandType.Text
            ' oleCommanda2.CommandText = "Insert INTO Склад (Наименование , ЦенаПокупки , Количество ,Сумма, ЕдИзм , Рецепт , [СрокГодности] , [Дата]) VALUES " & _
            ' "( '" & ComboBox1.SelectedValue & "','" & TextBox3.Text & "','" & КоличествоTextBox.Text & "','" & ComboBox2.SelectedValue & "'," & _
            '     "'" & РецептCheckBox.CheckAlign & "','" & СрокГодностиDateTimePicker.Text & "','" & Date.Now & "','" & TextBox2.Text & "' )"

            oleConnect.Open()
            oleCommanda.ExecuteNonQuery()
            oleCommanda2.ExecuteNonQuery()
            oleConnect.Close()

            MsgBox("Запись успешно удалена и наличие товара на складе обновлено", MsgBoxStyle.Information)
        Else
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim Cn As SqlConnection
        Cn = New SqlConnection()
        Cn.ConnectionString = "Data Source=DESKTOP-BCTG9KC;Initial Catalog=SHOPE;Integrated Security=True"
        Cn.Open()

        Dim str As String = "SELECT Товар.Наименование, Sale.ЦенаПродажи, Sale.Количество, ЕдИзм.Наименование, Sale.Дата FROM Товар INNER JOIN (ЕдИзм INNER JOIN Sale ON " & _
        "ЕдИзм.ID_ЕдИзм = Sale.ЕдИзм) ON Товар.ID_товар = Sale.Наименование Where ( (Товар.Наименование) Like '%" & TextBox1.Text & "%') ;"

        Dim A As SqlDataAdapter
        A = New SqlDataAdapter(str, Cn)

        Dim DB As DataSet = New DataSet

        A.Fill(DB)

        DataGridView1.DataSource = DB.Tables(0)
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        For i = 0 To DataGridView1.RowCount - 1
            If DataGridView1.Item(0, i).Selected = True Then
                TextBox2.Text = DataGridView1.Item(4, i).Value
            End If
        Next
    End Sub

    Private Sub find_prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class