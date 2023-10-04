Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class Form3
    Inherits System.Windows.Forms.Form
    Dim Conn As SqlConnection

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyyMMdd"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyyMMdd"

        If DateTimePicker1.Text > DateTimePicker2.Text Then
            MsgBox("Вы не правильно выбрали дату", MsgBoxStyle.Critical, Title:="Ошибка выбора")
        Else
            Conn = New SqlConnection()
            Conn.ConnectionString = "Data Source=DESKTOP-BCTG9KC;Initial Catalog=SHOPE;Integrated Security=True"
            Conn.Open()

            Dim d1, d2 As String
            d1 = DateTimePicker1.Text
            d2 = DateTimePicker2.Text

            Dim strSQL As String = "SELECT * FROM Купля Where([Дата] Between '" & d1 & "' And '" & d2 & "');"

            Dim Ad As SqlDataAdapter
            Ad = New SqlDataAdapter(strSQL, Conn)
            Dim DBDS As DataSet = New DataSet
            Ad.Fill(DBDS, "Купля")

            strSQL = "SELECT * FROM Товар ;"
            Ad = New SqlDataAdapter(strSQL, Conn)
            Ad.Fill(DBDS, "Товар")

            strSQL = "SELECT * FROM ЕдИзм ;"
            Ad = New SqlDataAdapter(strSQL, Conn)
            Ad.Fill(DBDS, "ЕдИзм")

            Dim myreport As ReportDocument = New CrystalReport3
            myreport.SetDataSource(DBDS)
            CrystalReportViewer1.ReportSource = myreport
        End If

        DateTimePicker1.Format = DateTimePickerFormat.Long
        DateTimePicker2.Format = DateTimePickerFormat.Long
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If DateTimePicker1.Text > DateTimePicker2.Text Then
            MsgBox("Вы не правильно ввели даты", MsgBoxStyle.OkOnly)
        Else
            Conn = New SqlConnection()
            Conn.ConnectionString = "Data Source=DESKTOP-BCTG9KC;Initial Catalog=SHOPE;Integrated Security=True"
            Conn.Open()

            Dim d1, d2 As String
            d1 = DateTimePicker1.Text
            d2 = DateTimePicker2.Text

            Dim strSQL As String = "SELECT * FROM Купля Where([Дата] Between '" & d1 & "' And '" & d2 & "')ORDER BY [Сумма];"

            Dim Ad As SqlDataAdapter
            Ad = New SqlDataAdapter(strSQL, Conn)
            Dim DBDS As DataSet = New DataSet
            Ad.Fill(DBDS, "Купля")

            strSQL = "SELECT * FROM Товар ;"
            Ad = New SqlDataAdapter(strSQL, Conn)
            Ad.Fill(DBDS, "Товар")

            strSQL = "SELECT * FROM ЕдИзм ;"
            Ad = New SqlDataAdapter(strSQL, Conn)
            Ad.Fill(DBDS, "ЕдИзм")

            Dim myreport As ReportDocument = New CrystalReport3
            myreport.SetDataSource(DBDS)
            CrystalReportViewer1.ReportSource = myreport
        End If
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class