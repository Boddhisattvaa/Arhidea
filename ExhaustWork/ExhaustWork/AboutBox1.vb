﻿Public NotInheritable Class AboutBox1

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Установить заголовок формы.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("О программе {0}", ApplicationTitle)
        ' Инициализировать текст, отображаемый в окне "О программе".
        ' TODO: настроить сведения о сборке приложения в области "Приложение" диалогового окна 
        '    свойств проекта (в меню "Проект").
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Версия {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = "Институт электроники и технологии"

        'Me.TextBoxDescription.Text = My.Application.Info.Description

        Me.TextBoxDescription.Text = "Разработал данное ПО студент группы ИСТТ Кудайбергенов Дастан Кубанычбекович"
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub LabelCopyright_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelCopyright.Click

    End Sub
End Class
