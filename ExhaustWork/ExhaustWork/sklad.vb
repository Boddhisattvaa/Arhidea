Imports System.Data.SqlClient

Public Class sklad
    Dim Conn As SqlConnection

    Private Sub Ch_Analyse()
        Dim t, p As String
        Dim s As Char
        Dim n, i, j, w, f As Integer
        Dim k, ch As Double
        Dim wrap As String

        wrap = Chr(13) + Chr(10)
        p = ""

        t = TextBox1.Text
        n = TextBox1.TextLength - 1

        For i = 0 To n
            k = 0
            s = t(i)
            f = 0
            p = p + t(i)
            For j = 0 To n
                If t(j) = s Then
                    k = k + 1
                End If
            Next


            ch = k / (n + 1)

            For w = 0 To p.Length - 1
                If s = "," Then
                    s = "."
                End If
            Next

            If f < 2 Then

                TextBox2.Text += s.ToString
            Else
                TextBox2.Text += ""
            End If
        Next
    End Sub
    Private Sub Ch_Analyse2()
        Dim t, p As String
        Dim s As Char
        Dim n, i, j, w, f As Integer
        Dim k, ch As Double
        Dim wrap As String

        wrap = Chr(13) + Chr(10)
        p = ""

        t = ЦенаПокупкиTextBox.Text
        n = ЦенаПокупкиTextBox.TextLength - 1

        For i = 0 To n
            k = 0
            s = t(i)
            f = 0
            p = p + t(i)
            For j = 0 To n
                If t(j) = s Then
                    k = k + 1
                End If
            Next


            ch = k / (n + 1)

            For w = 0 To p.Length - 1
                If s = "," Then
                    s = "."
                End If
            Next

            If f < 2 Then

                TextBox3.Text += s.ToString
            Else
                TextBox3.Text += ""
            End If
        Next
    End Sub
    Private Sub budget()
        Dim oleConnect As New SqlConnection
        Dim cmd As New SqlCommand("SELECT Sum(СуммаБюджета) as Kupleno FROM Budget;")
        oleConnect.ConnectionString = "Data Source=DESKTOP-BCTG9KC;Initial Catalog=SHOPE;Integrated Security=True"
        cmd.Connection = oleConnect
        oleConnect.Open()
        Dim result As SqlDataReader = cmd.ExecuteReader
        Dim i As Integer = 0
        While result.Read()
            budgetbox.Text = result("Kupleno")
        End While
        oleConnect.Close()
    End Sub

    Private Sub sklad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "shopeDataSet.ЕдИзм". При необходимости она может быть перемещена или удалена.
        Me.ЕдИзмTableAdapter.Fill(Me.shopeDataSet.ЕдИзм)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "shopeDataSet.Товар". При необходимости она может быть перемещена или удалена.
        Me.ТоварTableAdapter.Fill(Me.shopeDataSet.Товар)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "shopeDataSet.Склад". При необходимости она может быть перемещена или удалена.
        Me.СкладTableAdapter.Fill(Me.shopeDataSet.Склад)
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        ЦенаПокупкиTextBox.Text = "0,00"
        budget()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EdIzm.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        goods.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Ch_Analyse()
        Ch_Analyse2()
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Or КоличествоTextBox.Text = "" Or ЦенаПокупкиTextBox.Text = "" And budgetbox.Text < 0 Then
            MsgBox("Заполнены не все поля!", MsgBoxStyle.OkOnly, "Внимание!")
            Exit Sub
        Else
            'СрокГодностиDateTimePicker.Format = DateTimePickerFormat.Custom
            'СрокГодностиDateTimePicker.CustomFormat = "dd/MM/yyyy"
            Dim bud, summa As Double
            bud = budgetbox.Text
            summa = TextBox1.Text
            If summa > bud Then
                MsgBox("Вы не можете добавить запись, так как сумма данной записи превышает ваш текущий бюджет " & budgetbox.Text, MsgBoxStyle.Critical, "Внимание!")
                Exit Sub
            Else

                Dim oleConnect As New SqlConnection
                Dim oleCommanda As New SqlCommand
                Dim olecom As New SqlCommand
                Dim budget As New SqlCommand

                oleConnect.ConnectionString = "Data Source=DESKTOP-BCTG9KC;Initial Catalog=SHOPE;Integrated Security=True"

                oleCommanda.Connection = oleConnect
                oleCommanda.CommandType = CommandType.Text
                oleCommanda.CommandText = "INSERT INTO Склад (Наименование , ЦенаПокупки , Количество , ЕдИзм , [Дата],Сумма) VALUES " & _
                "( '" & ComboBox1.SelectedValue & "','" & TextBox3.Text & "','" & КоличествоTextBox.Text & "','" & ComboBox2.SelectedValue & "','" & Date.Now & "','" & TextBox2.Text & "' )"

                olecom.Connection = oleConnect
                olecom.CommandType = CommandType.Text
                olecom.CommandText = "INSERT INTO Купля (Наименование , ЦенаПокупки , Количество , ЕдИзм ,[Дата],Сумма) VALUES ( '" & ComboBox1.SelectedValue & "'," & _
                "'" & TextBox3.Text & "','" & КоличествоTextBox.Text & "','" & ComboBox2.SelectedValue & "','" & Date.Now & "','" & TextBox2.Text & "' )"

                budget.Connection = oleConnect
                budget.CommandType = CommandType.Text
                budget.CommandText = "INSERT INTO Budget ( Операция , [Дата] , Приход , Расход , СуммаБюджета) VALUES " & _
                "( 1 , '" & Date.Now & "' , 0 , '" & TextBox2.Text & " ', '-" & TextBox2.Text & "' )"

                oleConnect.Open()
                oleCommanda.ExecuteNonQuery()
                olecom.ExecuteNonQuery()
                budget.ExecuteNonQuery()
                oleConnect.Close()

                ComboBox1.ResetText()
                ComboBox2.ResetText()
                ЦенаПокупкиTextBox.Clear()
                КоличествоTextBox.Clear()
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()

            End If
        End If
        budget()
    End Sub

    Private Sub КоличествоTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles КоличествоTextBox.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = Chr(8)) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub КоличествоTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles КоличествоTextBox.TextChanged
        If КоличествоTextBox.Text = "" Then
            TextBox1.Clear()
            Exit Sub
        Else
            TextBox1.Text = ЦенаПокупкиTextBox.Text * КоличествоTextBox.Text
        End If
    End Sub

    Private Sub ЦенаПокупкиTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ЦенаПокупкиTextBox.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = "," Or e.KeyChar = Chr(8)) Then
            e.KeyChar = ""
            ' ToolTip1.Show("Значение должно быть только числовым!", ЦенаПокупкиTextBox)
            ' Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        '  ToolTip1.Hide(ЦенаПокупкиTextBox)
        ' Timer1.Enabled = False
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        e.KeyChar = ""
    End Sub
End Class