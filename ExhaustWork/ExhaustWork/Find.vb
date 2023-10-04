Imports System.Data.SqlClient
Public Class Find

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        For i = 0 To DataGridView1.RowCount - 1
            If DataGridView1.Item(0, i).Selected = True Then
                TextBox2.Text = DataGridView1.Item(4, i).Value
            End If
        Next
    End Sub

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
            Dim oleCommanda As New SqlCommand
            Dim olecom As New SqlCommand
            Dim bud As New SqlCommand

            oleConnect.ConnectionString = "Data Source=DESKTOP-BCTG9KC;Initial Catalog=SHOPE;Integrated Security=True"

            oleCommanda.Connection = oleConnect
            oleCommanda.CommandType = CommandType.Text
            oleCommanda.CommandText = "Delete From Склад Where Дата='" & TextBox2.Text & "'"

            olecom.Connection = oleConnect
            olecom.CommandType = CommandType.Text
            olecom.CommandText = "Delete From Купля Where Дата='" & TextBox2.Text & "'"

            bud.Connection = oleConnect
            bud.CommandType = CommandType.Text
            bud.CommandText = "Delete From Budget Where Дата='" & TextBox2.Text & "'"

            oleConnect.Open()
            oleCommanda.ExecuteNonQuery()
            olecom.ExecuteNonQuery()
            bud.ExecuteNonQuery()
            oleConnect.Close()

            MsgBox("Запись успешно удалена", MsgBoxStyle.Information)
        Else
        End If
    End Sub

    Private Sub Find_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "shopeDataSet.Товар". При необходимости она может быть перемещена или удалена.
        Me.ТоварTableAdapter.Fill(Me.shopeDataSet.Товар)
        ComboBox1.ResetText()

        Me.GroupBox2.Visible = True
        Me.GroupBox3.Visible = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim Cn As SqlConnection
        Cn = New SqlConnection()
        Cn.ConnectionString = "Data Source=DESKTOP-BCTG9KC;Initial Catalog=SHOPE;Integrated Security=True"
        Cn.Open()

        Dim str As String = "SELECT Товар.Наименование, Склад.ЦенаПокупки, Склад.Количество, ЕдИзм.Наименование as ЕдИзм, Склад.Дата FROM Товар INNER JOIN (ЕдИзм INNER JOIN Склад ON " & _
        "ЕдИзм.ID_ЕдИзм = Склад.ЕдИзм) ON Товар.ID_товар = Склад.Наименование Where ( (Товар.Наименование) Like '%" & ComboBox1.Text & "%') ;"

        Dim A As SqlDataAdapter
        A = New SqlDataAdapter(str, Cn)

        Dim DB As DataSet = New DataSet

        A.Fill(DB)

        DataGridView1.DataSource = DB.Tables(0)
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.GroupBox2.Visible = True
        Me.GroupBox3.Visible = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.GroupBox2.Visible = False
        Me.GroupBox3.Visible = True
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = "," Or e.KeyChar = Chr(8)) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = "," Or e.KeyChar = Chr(8)) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Dim Cn As SqlConnection
        Cn = New SqlConnection()
        Cn.ConnectionString = "Data Source=DESKTOP-BCTG9KC;Initial Catalog=SHOPE;Integrated Security=True"
        Cn.Open()

        Dim str As String = "SELECT Товар.Наименование, Склад.ЦенаПокупки, Склад.Количество, ЕдИзм.Наименование as ЕдИзм, Склад.Дата FROM Товар INNER JOIN (ЕдИзм INNER JOIN Склад ON " & _
        "ЕдИзм.ID_ЕдИзм = Склад.ЕдИзм) ON Товар.ID_товар = Склад.Наименование Where ( (Склад.ЦенаПокупки) Between '" & TextBox1.Text & "' And '" & TextBox3.Text & "' ) ;"

        Dim A As SqlDataAdapter
        A = New SqlDataAdapter(str, Cn)

        Dim DB As DataSet = New DataSet

        A.Fill(DB)

        DataGridView1.DataSource = DB.Tables(0)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class