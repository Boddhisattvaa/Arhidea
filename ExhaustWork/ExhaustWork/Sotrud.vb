Imports System.Data.SqlClient
Public Class Sotrud

    Private Sub Sotrud_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "shopeDataSet.Должности". При необходимости она может быть перемещена или удалена.
        Me.ДолжностиTableAdapter.Fill(Me.shopeDataSet.Должности)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "shopeDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
        Me.СотрудникиTableAdapter.Fill(Me.shopeDataSet.Сотрудники)
        ComboBox1.ResetText()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If ComboBox1.Text = "" Or TextBox1.Text = "" Or TextBox3.Text = "" Then 'Or ЦенаПокупкиTextBox.Text = "" And budgetbox.Text < 0 Then
            MsgBox("Заполнены не все поля!", MsgBoxStyle.OkOnly, "Внимание!")
            Exit Sub
        Else
            'Запрос на добавление данных
            Dim oleConnect As New SqlConnection
            Dim oleCommanda As New SqlCommand
            Dim budget As New SqlCommand

            oleConnect.ConnectionString = "Data Source=DESKTOP-BCTG9KC;Initial Catalog=SHOPE;Integrated Security=True"

            oleCommanda.Connection = oleConnect
            oleCommanda.CommandType = CommandType.Text
            oleCommanda.CommandText = "INSERT INTO Сотрудники (ФИО, Должность,Оклад , Адрес , Телефон) VALUES ( '" & TextBox1.Text & "','" & ComboBox1.SelectedValue & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"

            budget.Connection = oleConnect
            budget.CommandType = CommandType.Text
            budget.CommandText = "INSERT INTO Budget ([Дата],Операция,Приход,Расход,СуммаБюджета) VALUES ( '" & Date.Now & "','3','0','" & TextBox3.Text & "','" & -TextBox3.Text & "')"

            oleConnect.Open()
            oleCommanda.ExecuteNonQuery()
            budget.ExecuteNonQuery()
            oleConnect.Close()

            TextBox1.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            Me.СотрудникиTableAdapter.Fill(Me.shopeDataSet.Сотрудники)
            ComboBox1.ResetText()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
            oleCommanda.CommandText = "delete from Сотрудники Where ФИО='" & TextBox2.Text & "' and Адрес='" & TextBox6.Text & "'"

            oleConnect.Open()
            oleCommanda.ExecuteNonQuery()
            oleConnect.Close()

            MsgBox("Запись успешно удалена", MsgBoxStyle.Information)
            Me.СотрудникиTableAdapter.Fill(Me.shopeDataSet.Сотрудники)
            TextBox2.Clear()
            TextBox6.Clear()
        Else
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

  

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = "," Or e.KeyChar = Chr(8)) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = "," Or e.KeyChar = Chr(8)) Then
            e.KeyChar = ""
        End If
    End Sub
    
    
   
End Class