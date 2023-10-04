Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class Form4
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

            Dim strSQL As String = "SELECT * FROM Budget where([Дата] Between '" & d1 & "' And '" & d2 & "');"

            Dim Ad As SqlDataAdapter
            Ad = New SqlDataAdapter(strSQL, Conn)
            Dim DBDS As DataSet = New DataSet
            Ad.Fill(DBDS, "Budget")

            strSQL = "SELECT * FROM Сотрудники ;"
            Ad = New SqlDataAdapter(strSQL, Conn)
            Ad.Fill(DBDS, "Сотрудники")

            Dim myreport As ReportDocument = New CrystalReport4
            myreport.SetDataSource(DBDS)
            CrystalReportViewer1.ReportSource = myreport
        End If
        DateTimePicker1.Format = DateTimePickerFormat.Long
        DateTimePicker2.Format = DateTimePickerFormat.Long
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class