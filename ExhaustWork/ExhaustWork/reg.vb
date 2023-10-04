Imports System.Data.SqlClient
Public Class reg
    Private Sub Rev_Crypt_name()
        Dim n, i As Integer
        Dim s1, s2 As String

        s1 = UsernameTextBox.Text
        s2 = TextBox1.Text
        n = s1.Length
        i = 0

        While i < n
            s2 = s2.Insert(i, s1.ElementAt(n - 1 - i))
            i = i + 1
        End While
        s1 = s2
        TextBox1.Text = s1.ToString()
    End Sub

    Private Sub Rev_Crypt_pass()
        Dim n, i As Integer
        Dim s1, s2 As String

        s1 = passwordTextBox.Text
        s2 = TextBox2.Text
        n = s1.Length
        i = 0

        While i < n
            s2 = s2.Insert(i, s1.ElementAt(n - 1 - i))
            i = i + 1
        End While
        s1 = s2
        TextBox2.Text = s1.ToString()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If UsernameTextBox.Text = "" And PasswordTextBox.Text = "" Then
            MsgBox("Введены не все данные", MsgBoxStyle.Critical, Title:="Внимание")
        Else
            Rev_Crypt_name()
            Rev_Crypt_pass()

            Dim cn As New SqlConnection("Data Source=DESKTOP-BCTG9KC;Initial Catalog=SHOPE;Integrated Security=True")
            Dim cm As New SqlCommand

            cm.Connection = cn
            cm.CommandType = CommandType.Text
            cm.CommandText = "Insert INTO Users (UserName,Password) Values ('" & TextBox1.Text & "','" & TextBox2.Text & "')"

            cn.Open()
            cm.ExecuteNonQuery()
            cn.Close()

            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            MsgBox("Пользователь успешно зарегестрирован", MsgBoxStyle.Information, Title:="Внимание")
        End If
    End Sub
End Class