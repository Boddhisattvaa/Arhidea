Imports System.Math
Imports System.Data.SqlClient
Public Class prod
    Dim d As Integer

    Private Sub Ch_Analyse()
        Dim t, p As String
        Dim s As Char
        Dim n, i, j, w, f As Integer
        Dim k, ch As Double
        Dim wrap As String

        wrap = Chr(13) + Chr(10)
        p = ""

        t = TextBox2.Text
        n = TextBox2.TextLength - 1

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
    Private Sub Ch_Analyse2()
        Dim t, p As String
        Dim s As Char
        Dim n, i, j, w, f As Integer
        Dim k, ch As Double
        Dim wrap As String

        wrap = Chr(13) + Chr(10)
        p = ""

        t = ЦенаПродажиTextBox.Text
        n = ЦенаПродажиTextBox.TextLength - 1

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

                TextBox4.Text += s.ToString
            Else
                TextBox4.Text += ""
            End If
        Next
    End Sub

    Private Sub Del()
        Dim i As Integer
        Dim b As Boolean = False

        Me.СкладBindingSource.MoveFirst()
        For i = 0 To Me.СкладBindingSource.Count - 1
            If Me.СкладDataGridView.Item(1, i).Value = НаименованиеTextBox.Text Then
                If Me.СкладDataGridView.Item(3, i).Value = 0 Then
                    b = True
                    Exit For
                Else
                    Me.СкладBindingSource.MoveNext()
                End If
            Else
                Me.СкладBindingSource.MoveNext()
            End If
        Next

        If b = True Then
            Me.СкладBindingSource.RemoveAt(Me.СкладDataGridView.CurrentRow.Index)
            Null()
        End If
    End Sub

    Private Sub Null()
        Dim i As Integer
        Dim b1 As Boolean = False
        Dim c As Integer
        c = Me.СкладBindingSource.Count
        Me.СкладBindingSource.MoveFirst()
        For i = 0 To Me.СкладBindingSource.Count - 1
            If Me.СкладDataGridView.Item(1, i).Value = НаименованиеTextBox.Text Then
                If Me.СкладDataGridView.Item(3, i).Value = 0 Then
                    b1 = True
                    Exit For
                Else
                    Me.СкладBindingSource.MoveNext()
                    b1 = False
                End If
            Else
                Me.СкладBindingSource.MoveNext()
                b1 = False
            End If
        Next

        If b1 = True Then
            Del()
        End If
    End Sub

    Private Sub Minus_Na_Sklade()
        Dim i, g As Integer
        If Me.СкладDataGridView.RowCount - 1 = 0 Then
            MsgBox("На складе  больше нет товара! Откройте окно 'Купленный товар' и введите туда данные о купленном товаре!", MsgBoxStyle.OkOnly, "Внимание")
            Me.SaleBindingSource.RemoveAt(Me.SaleDataGridView.CurrentRow.Index)
        Else
            For i = 0 To Me.СкладDataGridView.RowCount - 1
                If Me.СкладDataGridView.Item(1, i).Value = НаименованиеTextBox.Text Then
                    If Me.СкладDataGridView.Item(3, i).Value > Me.TextBox1.Text Then
                        Me.СкладDataGridView.Item(3, i).Value -= Int(TextBox1.Text)
                        Exit For
                    Else
                        g = Me.СкладDataGridView.Item(3, i).Value - Int(TextBox1.Text)
                        Me.СкладDataGridView.Item(3, i).Value -= (Int(TextBox1.Text) - Abs(g))
                        TextBox1.Text = Abs(g)
                    End If

                End If
            Next
        End If
    End Sub

    Private Sub prod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'shopeDataSet.srttbclient' table. You can move, or remove it, as needed.
        Me.SrttbclientTableAdapter.Fill(Me.shopeDataSet.srttbclient)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "shopeDataSet.ЕдИзм". При необходимости она может быть перемещена или удалена.
        Me.ЕдИзмTableAdapter.Fill(Me.shopeDataSet.ЕдИзм)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "shopeDataSet.Товар". При необходимости она может быть перемещена или удалена.
        Me.ТоварTableAdapter.Fill(Me.shopeDataSet.Товар)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "shopeDataSet.Склад". При необходимости она может быть перемещена или удалена.
        Me.СкладTableAdapter.Fill(Me.shopeDataSet.Склад)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "shopeDataSet.Sale". При необходимости она может быть перемещена или удалена.
        Me.SaleTableAdapter.Fill(Me.shopeDataSet.Sale)
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        Label3.Visible = False
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label3.Visible = True
        НаименованиеTextBox.Text = ComboBox1.SelectedValue
        Dim tovar As DataTable
        Dim s, i As Integer
        s = 0
        For i = 0 To Me.СкладBindingSource.Count - 1
            If Me.СкладDataGridView.Item(1, i).Value = НаименованиеTextBox.Text Then
                s += Me.СкладDataGridView.Item(3, i).Value
            End If
        Next
        Label3.Text = s

        Dim Cn As SqlConnection
        Cn = New SqlConnection()
        Cn.ConnectionString = "Data Source=DESKTOP-BCTG9KC;Initial Catalog=SHOPE;Integrated Security=True"
        Cn.Open()

        Dim str As String = "SELECT Склад.ЦенаПокупки FROM Склад Where ( (Склад.Наименование) = '" & Convert.ToInt32(ComboBox1.SelectedIndex) + 1 & "' ) ;"

        Dim A As SqlDataAdapter
        A = New SqlDataAdapter(str, Cn)

        Dim DB As DataSet = New DataSet
        ' tovar = 
        A.Fill(DB, "tovar")
        tovar = DB.Tables("tovar")
        If (tovar.Rows.Count > 0) Then
            TextBox2.Text = (30 / 100 * Convert.ToInt32(tovar.Rows(0)("ЦенаПокупки"))) + Convert.ToInt32(tovar.Rows(0)("ЦенаПокупки"))
        End If
    End Sub

    Private Sub КоличествоTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles КоличествоTextBox.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = Chr(8)) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub КоличествоTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles КоличествоTextBox.TextChanged
        Dim i, s, h As Integer
        If КоличествоTextBox.Text = "" Then
            h = 0
            ЦенаПродажиTextBox.Clear()
            Exit Sub
        Else
            If Me.КоличествоTextBox.Text = 0 Then
                MsgBox("Ноль нельзя вводить!", MsgBoxStyle.OkOnly, "Внимание!")
                Exit Sub
            End If
            h = Me.КоличествоTextBox.Text
            ЦенаПродажиTextBox.Text = (КоличествоTextBox.Text * TextBox2.Text) - ((КоличествоTextBox.Text * TextBox2.Text) * DiscountTextBox.Text) / 100
        End If
        s = 0
        For i = 0 To Me.СкладBindingSource.Count - 1
            If Me.СкладDataGridView.Item(1, i).Value = НаименованиеTextBox.Text Then
                s += Me.СкладDataGridView.Item(3, i).Value
            End If

        Next
        If s < h Then
            MsgBox("На складе столько товара нет! Есть только " & s & " единиц выбранного товара!", MsgBoxStyle.Critical, "Внимание!")
            КоличествоTextBox.Clear()
            TextBox1.Clear()
            Exit Sub
        Else
            Me.TextBox1.Text = Me.КоличествоTextBox.Text
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        goods.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EdIzm.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Or КоличествоTextBox.Text = "" Or ЦенаПродажиTextBox.Text = "" Then
            MsgBox("Заполнены не все поля!", MsgBoxStyle.OkOnly, "Внимание!")
            Exit Sub
        Else
            Ch_Analyse()
            Ch_Analyse2()

            Dim oleConnect As New SqlConnection
            Dim oleCommanda As New SqlCommand
            Dim budget As New SqlCommand
            Dim client As New SqlCommand
            oleConnect.ConnectionString = "Data Source=DESKTOP-BCTG9KC;Initial Catalog=SHOPE;Integrated Security=True"

            oleCommanda.Connection = oleConnect
            oleCommanda.CommandType = CommandType.Text
            oleCommanda.CommandText = "INSERT INTO Sale (Наименование , ЦенаПродажи , Количество , ЕдИзм , [Дата],Сумма,Warranty) VALUES ( '" & ComboBox1.SelectedValue & "','" & TextBox3.Text & "','" & КоличествоTextBox.Text & "','" & ComboBox2.SelectedValue & "','" & Date.Now & "','" & TextBox4.Text & "','" & comboWarranty.Text & "' )"

            budget.Connection = oleConnect
            budget.CommandType = CommandType.Text
            budget.CommandText = "INSERT INTO Budget ( Операция , [Дата] , Приход , Расход , СуммаБюджета) VALUES ( 2 , '" & Date.Now & "' , '" & TextBox4.Text & "' , 0, '" & TextBox4.Text & "' )"

            client.Connection = oleConnect
            client.CommandType = CommandType.Text
            client.CommandText = "INSERT INTO Srttbgoodsclient ( IDClient,ID_Товар,CountMoney,[Date] ) VALUES ( '" & NameComboBox.SelectedValue & "' , '" & ComboBox1.SelectedValue & "' , '" & ЦенаПродажиTextBox.Text & "','" & Date.Now & "' )"
            Try
                oleConnect.Open()
                oleCommanda.ExecuteNonQuery()
                budget.ExecuteNonQuery()
                client.ExecuteNonQuery()
                oleConnect.Close()
            Catch ex As Exception

            End Try
            Me.Validate()
            Minus_Na_Sklade()
            Null()
            Me.SaleBindingSource.EndEdit()
            Me.СкладBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.shopeDataSet)

            ComboBox1.ResetText()
            ComboBox2.ResetText()
            NameComboBox.ResetText()
            DiscountTextBox.Clear()
            ЦенаПродажиTextBox.Clear()
            КоличествоTextBox.Clear()
            TextBox2.Clear()
            Label2.Text = ""
            TextBox3.Clear()
            TextBox4.Clear()
            comboWarranty.ResetText()
        End If
        Label3.Text = ""
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = "," Or e.KeyChar = Chr(8)) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        e.KeyChar = ""
    End Sub
  
    
End Class