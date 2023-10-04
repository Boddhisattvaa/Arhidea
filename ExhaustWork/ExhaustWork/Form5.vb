Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class Form5
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

            Dim strSQL As String = "SELECT * from Srttbgoodsclient where(Date Between '" & d1 & "' And '" & d2 & "');"

            Dim Ad As SqlDataAdapter
            Ad = New SqlDataAdapter(strSQL, Conn)
            Dim DBDS As DataSet = New DataSet
            Ad.Fill(DBDS, "Srttbgoodsclient")

            strSQL = "SELECT * FROM Товар ;"
            Ad = New SqlDataAdapter(strSQL, Conn)
            Ad.Fill(DBDS, "Товар")

            strSQL = "SELECT * FROM srttbclient ;"
            Ad = New SqlDataAdapter(strSQL, Conn)
            Ad.Fill(DBDS, "srttbclient")

           

            Dim myreport As ReportDocument = New CrystalReport5
            myreport.SetDataSource(DBDS)
            CrystalReportViewer1.ReportSource = myreport
        End If
        DateTimePicker1.Format = DateTimePickerFormat.Long
        DateTimePicker2.Format = DateTimePickerFormat.Long
    End Sub
End Class