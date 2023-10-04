<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReport11 = New ExhaustWork.CrystalReport1()
        Me.shopeDataSet = New ExhaustWork.shopeDataSet()
        Me.SaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaleTableAdapter = New ExhaustWork.shopeDataSetTableAdapters.SaleTableAdapter()
        Me.TableAdapterManager = New ExhaustWork.shopeDataSetTableAdapters.TableAdapterManager()
        Me.ТоварBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ТоварTableAdapter = New ExhaustWork.shopeDataSetTableAdapters.ТоварTableAdapter()
        Me.ЕдИзмBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЕдИзмTableAdapter = New ExhaustWork.shopeDataSetTableAdapters.ЕдИзмTableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.shopeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ТоварBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЕдИзмBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CrystalReport11
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(822, 566)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'shopeDataSet
        '
        Me.shopeDataSet.DataSetName = "shopeDataSet"
        Me.shopeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SaleBindingSource
        '
        Me.SaleBindingSource.DataMember = "Sale"
        Me.SaleBindingSource.DataSource = Me.shopeDataSet
        '
        'SaleTableAdapter
        '
        Me.SaleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BudgetTableAdapter = Nothing
        Me.TableAdapterManager.SaleTableAdapter = Me.SaleTableAdapter
        Me.TableAdapterManager.srttbclientTableAdapter = Nothing
        Me.TableAdapterManager.SrttbgoodsclientTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ExhaustWork.shopeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.ДолжностиTableAdapter = Nothing
        Me.TableAdapterManager.ЕдИзмTableAdapter = Nothing
        Me.TableAdapterManager.КодОперацииTableAdapter = Nothing
        Me.TableAdapterManager.КупляTableAdapter = Nothing
        Me.TableAdapterManager.СкладTableAdapter = Nothing
        Me.TableAdapterManager.СотрудникиTableAdapter = Nothing
        Me.TableAdapterManager.ТоварTableAdapter = Nothing
        '
        'ТоварBindingSource
        '
        Me.ТоварBindingSource.DataMember = "Товар"
        Me.ТоварBindingSource.DataSource = Me.shopeDataSet
        '
        'ТоварTableAdapter
        '
        Me.ТоварTableAdapter.ClearBeforeFill = True
        '
        'ЕдИзмBindingSource
        '
        Me.ЕдИзмBindingSource.DataMember = "ЕдИзм"
        Me.ЕдИзмBindingSource.DataSource = Me.shopeDataSet
        '
        'ЕдИзмTableAdapter
        '
        Me.ЕдИзмTableAdapter.ClearBeforeFill = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(493, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(152, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(493, 29)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(152, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(651, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 45)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Собрать отчёт"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(351, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Выберите конечную дату:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(351, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Выберите начальную дату:"
        '
        'Form1
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 566)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Отчёт"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.shopeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ТоварBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЕдИзмBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents shopeDataSet As ExhaustWork.shopeDataSet
    Friend WithEvents SaleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SaleTableAdapter As ExhaustWork.shopeDataSetTableAdapters.SaleTableAdapter
    Friend WithEvents TableAdapterManager As ExhaustWork.shopeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ТоварBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ТоварTableAdapter As ExhaustWork.shopeDataSetTableAdapters.ТоварTableAdapter
    Friend WithEvents ЕдИзмBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ЕдИзмTableAdapter As ExhaustWork.shopeDataSetTableAdapters.ЕдИзмTableAdapter
    Friend WithEvents CrystalReport11 As ExhaustWork.CrystalReport1
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
