Imports System.Data.SqlClient
Public Class budg

    Private Sub budg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "shopeDataSet.КодОперации". При необходимости она может быть перемещена или удалена.
        Me.КодОперацииTableAdapter.Fill(Me.shopeDataSet.КодОперации)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "shopeDataSet.Budget". При необходимости она может быть перемещена или удалена.
        Me.BudgetTableAdapter.Fill(Me.shopeDataSet.Budget)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If НаименованиеComboBox.Text = "" Then 'Or ComboBox2.Text = "" Or КоличествоTextBox.Text = "" Or ЦенаПокупкиTextBox.Text = "" And budgetbox.Text < 0 Then
            MsgBox("Заполнены не все поля!", MsgBoxStyle.OkOnly, "Внимание!")
            Exit Sub
        Else
            DateTimePicker1.Format = DateTimePickerFormat.Custom
            DateTimePicker1.CustomFormat = "dd/MM/yyyy"
            If TextBox4.Text = "" Then
                TextBox4.Text = 0
            End If
            If TextBox3.Text = "" Then
                TextBox3.Text = 0
            End If
            'Запрос на добавление данных
            Dim oleConnect As New SqlConnection
            Dim oleCommanda As New SqlCommand
            Dim budget As New SqlCommand
            Dim sumb As Double
            sumb = TextBox3.Text - TextBox4.Text
            oleConnect.ConnectionString = "Data Source=DESKTOP-BCTG9KC;Initial Catalog=SHOPE;Integrated Security=True"

            oleCommanda.Connection = oleConnect
            oleCommanda.CommandType = CommandType.Text
            oleCommanda.CommandText = "INSERT INTO Budget (Операция,[Дата],Приход,Расход,СуммаБюджета) VALUES ( '" & НаименованиеComboBox.SelectedValue & "','" & DateTimePicker1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & sumb & "')"

            oleConnect.Open()
            oleCommanda.ExecuteNonQuery()
            oleConnect.Close()

            НаименованиеComboBox.ResetText()
            DateTimePicker1.Format = DateTimePickerFormat.Long
            DateTimePicker1.Text = Today
            TextBox3.Clear()
            TextBox4.Clear()

            Me.BudgetTableAdapter.Fill(Me.shopeDataSet.Budget)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        For i = 0 To DataGridView1.RowCount - 1
            If DataGridView1.Item(0, i).Selected = True Then
                TextBox1.Text = DataGridView1.Item(0, i).Value
                TextBox5.Text = DataGridView1.Item(2, i).Value
            End If
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Удаление выбранной строки оп идендификатору
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

            oleConnect.ConnectionString = "Data Source=DESKTOP-BCTG9KC;Initial Catalog=SHOPE;Integrated Security=True"

            oleCommanda.Connection = oleConnect
            oleCommanda.CommandType = CommandType.Text
            oleCommanda.CommandText = "delete from Budget Where ID_budget='" & TextBox1.Text & "' and [Дата]='" & TextBox5.Text & "'"

            oleConnect.Open()
            oleCommanda.ExecuteNonQuery()
            oleConnect.Close()

            MsgBox("Запись успешно удалена", MsgBoxStyle.Information)
            Me.BudgetTableAdapter.Fill(Me.shopeDataSet.Budget)
            TextBox1.Clear()
            TextBox5.Clear()
        Else
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = "," Or e.KeyChar = Chr(8)) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = "," Or e.KeyChar = Chr(8)) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub НаименованиеComboBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles НаименованиеComboBox.KeyPress
        e.KeyChar = ""
    End Sub

End Class