Imports System.Data.SqlClient
Public Class main
    Inherits System.Windows.Forms.Form
    Private Sub СправочникТоварToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СправочникТоварToolStripMenuItem.Click
        goods.MdiParent = Me
        goods.Show()
    End Sub

    Private Sub СправочникЕдиницыИзмеренияToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EdIzm.MdiParent = Me
        EdIzm.Show()
    End Sub

    Private Sub ВыйтиToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ВыйтиToolStripMenuItem.Click
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        msg = "Вы уверены что хотите закончить работу?"   ' Define message.
        style = MsgBoxStyle.DefaultButton2 Or _
           MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        title = "Внимание"   ' Define title.
        ' Display message.
        response = MsgBox(msg, style, title)
        If response = MsgBoxResult.Yes Then   ' User chose Yes.
            End
        Else
        End If
    End Sub

    Private Sub СправочникДолжностиToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СправочникДолжностиToolStripMenuItem1.Click
        Dolj.MdiParent = Me
        Dolj.Show()
    End Sub

    Private Sub ФормаПродажиToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ФормаПродажиToolStripMenuItem.Click
        prod.MdiParent = Me
        prod.Show()
    End Sub

    Private Sub ФормаПокупкиToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ФормаПокупкиToolStripMenuItem1.Click
        sklad.MdiParent = Me
        sklad.Show()
    End Sub

    Private Sub ФормаСотрудникиToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Sotrud.MdiParent = Me
        Sotrud.Show()
    End Sub

    Private Sub ФормаБюджетToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        budg.MdiParent = Me
        budg.Show()
    End Sub

    Private Sub ОПрограммеToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОПрограммеToolStripMenuItem1.Click
        AboutBox1.MdiParent = Me
        AboutBox1.Show()
    End Sub

    Private Sub ОтчётПродажиЗаМесяцToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОтчётПродажиЗаМесяцToolStripMenuItem.Click
        Form1.MdiParent = Me
        Form1.Show()
    End Sub

    Private Sub СправочникОперацииToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СправочникОперацииToolStripMenuItem.Click
        oper.MdiParent = Me
        oper.Show()
    End Sub

    Private Sub ОтчётToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОтчётToolStripMenuItem.Click
        Form2.MdiParent = Me
        Form2.Show()
    End Sub

    Private Sub ОтчётПоПокупкамToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОтчётПоПокупкамToolStripMenuItem.Click
        Form3.MdiParent = Me
        Form3.Show()
    End Sub

    Private Sub ОбщийОтчётToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form4.MdiParent = Me
        Form4.Show()
    End Sub

    Private Sub ПоискПродажToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ПоискПродажToolStripMenuItem.Click
        ''find_prod.MdiParent = Me
        ''find_prod.Show()
    End Sub


    Private Sub РегистрацияПользователяToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        reg.MdiParent = Me
        reg.Show()
    End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HuiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        zForm5.Show()
    End Sub

    Private Sub ПоискНаСкладеToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Find.MdiParent = Me
        Find.Show()
    End Sub

    Private Sub HerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        zForm5.Show()
    End Sub

    Private Sub СправочникToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СправочникToolStripMenuItem.Click
        ClientReg.MdiParent = Me
        ClientReg.Show()
    End Sub

    Private Sub ОтчетПоКлиентамToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОтчетПоКлиентамToolStripMenuItem.Click
        Form5.MdiParent = Me
        Form5.Show()
    End Sub

    Private Sub ПоискТовараНаСкладеToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ПоискТовараНаСкладеToolStripMenuItem.Click
        Find.ShowDialog()
    End Sub

    Private Sub БюджетToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles БюджетToolStripMenuItem.Click
        budg.ShowDialog()
    End Sub

    Private Sub СотрудникиToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СотрудникиToolStripMenuItem.Click
        Sotrud.ShowDialog()
    End Sub

    Private Sub РегистрацияПользователяToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles РегистрацияПользователяToolStripMenuItem.Click
        reg.ShowDialog()
    End Sub

    Private Sub ОтчетПоСотрудникамToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОтчетПоСотрудникамToolStripMenuItem.Click
        Form6.ShowDialog()
    End Sub

    Private Sub КлиентыToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles КлиентыToolStripMenuItem.Click
        SotrudSearch.ShowDialog()
    End Sub

    Private Sub ToolStripContainer1_LeftToolStripPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ПоискТовараНаСкладеToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Find.ShowDialog()
    End Sub
End Class