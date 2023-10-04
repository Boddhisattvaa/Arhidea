Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class Form6

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As SqlConnection

        conn = New SqlConnection()
        conn.ConnectionString = "Data Source=DESKTOP-BCTG9KC;Initial Catalog=SHOPE;Integrated Security=True"
        conn.Open()

        Dim strSQL As String = "SELECT * from Сотрудники"

        Dim Ad As SqlDataAdapter
        Ad = New SqlDataAdapter(strSQL, conn)
        Dim DBDS As DataSet = New DataSet
        Ad.Fill(DBDS, "Сотрудники")

        strSQL = "SELECT * FROM Должности ;"
        Ad = New SqlDataAdapter(strSQL, conn)
        Ad.Fill(DBDS, "Должности")


        Dim myreport As ReportDocument = New CrystalReport6
        myreport.SetDataSource(DBDS)
        CrystalReportViewer1.ReportSource = myreport
    End Sub
End Class