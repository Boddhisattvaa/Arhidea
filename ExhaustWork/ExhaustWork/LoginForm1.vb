Imports System.Data.SqlClient
Public Class LoginForm1

    ' TODO: вставить код для настраиваемой проверки подлинности с использованием переданного имени пользователя и пароля 
    ' (См. http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' Пользовательский принципал можно затем подключить к принципалу потока следующим образом: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' где CustomPrincipal - реализация интерфейса IPrincipal, используемая для аутентификации. 
    ' Впоследствии My.User будет возвращать идентификационную информацию, заключенную в объекте CustomPrincipal,
    ' например, имя пользователя, отображаемое имя и т.д.

    Private Sub Rev_Crypt_Login()
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

    Private Sub Rev_Crypt_Pass()
        Dim n, i As Integer
        Dim s1, s2 As String

        s1 = PasswordTextBox.Text
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

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Rev_Crypt_Login()
        Rev_Crypt_Pass()
        '  Dim cn As New SqlConnection("Data Source=DESKTOP-TA8SKD5;AttachDbFilename=|DataDirectory|\shope.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        Dim cn As New SqlConnection("Data Source=DESKTOP-BCTG9KC;Initial Catalog=SHOPE;Integrated Security=True")
        Dim cm As New SqlCommand("FindUser", cn)
        Dim n As Integer

        ' Открываем соединение
        cn.Open()
        ' Задаём тип команды
        cm.CommandType = CommandType.StoredProcedure
        ' Добавляем параметры имени
        Dim prmName = New SqlParameter("@Name", SqlDbType.NVarChar, 50)
        prmName.Value = TextBox1.Text
        cm.Parameters.Add(prmName)
        ' Добавляем параметр пароля
        Dim prmPass = New SqlParameter("@Password", SqlDbType.NVarChar, 50)
        prmPass.Value = TextBox2.Text
        cm.Parameters.Add(prmPass)
        ' Выполняем запрос
        n = cm.ExecuteScalar

        If n > 0 Then
            ' Если кого-то нашли, значит, регистрация пройдена успешно
            'Form1.RedirectFromLoginPage(UsernameTextBox.Text, False)
            main.Show()
            Me.Close()
        Else
            ' если никого нет, значит, ошибка
            MsgBox("Вы не правильно ввели Имя Пользователя или Пароль", MsgBoxStyle.Critical, Title:="Ошибка ввода")
        End If

        cn.Close()

        TextBox1.Clear()
        TextBox2.Clear()
        '  main.ДанныеToolStripMenuItem1.Enabled = False
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
