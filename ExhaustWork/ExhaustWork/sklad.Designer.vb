<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sklad
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
        Me.components = New System.ComponentModel.Container
        Dim НаименованиеLabel As System.Windows.Forms.Label
        Dim ЦенаПокупкиLabel As System.Windows.Forms.Label
        Dim КоличествоLabel As System.Windows.Forms.Label
        Dim ЕдИзмLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.shopeDataSet = New ExhaustWork.shopeDataSet
        Me.СкладBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.СкладTableAdapter = New ExhaustWork.shopeDataSetTableAdapters.СкладTableAdapter
        Me.TableAdapterManager = New ExhaustWork.shopeDataSetTableAdapters.TableAdapterManager
        Me.ЕдИзмTableAdapter = New ExhaustWork.shopeDataSetTableAdapters.ЕдИзмTableAdapter
        Me.ТоварTableAdapter = New ExhaustWork.shopeDataSetTableAdapters.ТоварTableAdapter
        Me.СкладDataGridView = New System.Windows.Forms.DataGridView
        Me.IDСкладDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.НаименованиеDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ЦенаПокупкиDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.КоличествоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.СуммаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ДатаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ЕдИзмDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ЦенаПокупкиTextBox = New System.Windows.Forms.TextBox
        Me.КоличествоTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ТоварBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ЕдИзмBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button4 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.budgetbox = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        НаименованиеLabel = New System.Windows.Forms.Label
        ЦенаПокупкиLabel = New System.Windows.Forms.Label
        КоличествоLabel = New System.Windows.Forms.Label
        ЕдИзмLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        CType(Me.shopeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СкладBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СкладDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ТоварBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЕдИзмBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'НаименованиеLabel
        '
        НаименованиеLabel.AutoSize = True
        НаименованиеLabel.Location = New System.Drawing.Point(6, 20)
        НаименованиеLabel.Name = "НаименованиеLabel"
        НаименованиеLabel.Size = New System.Drawing.Size(124, 13)
        НаименованиеLabel.TabIndex = 4
        НаименованиеLabel.Text = "Наименование товара:"
        '
        'ЦенаПокупкиLabel
        '
        ЦенаПокупкиLabel.AutoSize = True
        ЦенаПокупкиLabel.Location = New System.Drawing.Point(6, 47)
        ЦенаПокупкиLabel.Name = "ЦенаПокупкиLabel"
        ЦенаПокупкиLabel.Size = New System.Drawing.Size(121, 13)
        ЦенаПокупкиLabel.TabIndex = 6
        ЦенаПокупкиLabel.Text = "Цена единицы товара:"
        '
        'КоличествоLabel
        '
        КоличествоLabel.AutoSize = True
        КоличествоLabel.Location = New System.Drawing.Point(6, 73)
        КоличествоLabel.Name = "КоличествоLabel"
        КоличествоLabel.Size = New System.Drawing.Size(146, 13)
        КоличествоLabel.TabIndex = 8
        КоличествоLabel.Text = "Количество единиц товара:"
        '
        'ЕдИзмLabel
        '
        ЕдИзмLabel.AutoSize = True
        ЕдИзмLabel.Location = New System.Drawing.Point(6, 125)
        ЕдИзмLabel.Name = "ЕдИзмLabel"
        ЕдИзмLabel.Size = New System.Drawing.Size(114, 13)
        ЕдИзмLabel.TabIndex = 10
        ЕдИзмLabel.Text = "Единицы измерения:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(6, 99)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(140, 13)
        Label1.TabIndex = 8
        Label1.Text = "Общая стоимость товара:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(13, 151)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(50, 13)
        Label2.TabIndex = 12
        Label2.Text = "Бюджет:"
        Label2.Visible = False
        '
        'shopeDataSet
        '
        Me.shopeDataSet.DataSetName = "shopeDataSet"
        Me.shopeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'СкладBindingSource
        '
        Me.СкладBindingSource.DataMember = "Склад"
        Me.СкладBindingSource.DataSource = Me.shopeDataSet
        '
        'СкладTableAdapter
        '
        Me.СкладTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BudgetTableAdapter = Nothing
        Me.TableAdapterManager.SaleTableAdapter = Nothing
        Me.TableAdapterManager.srttbclientTableAdapter = Nothing
        Me.TableAdapterManager.SrttbgoodsclientTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ExhaustWork.shopeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.ДолжностиTableAdapter = Nothing
        Me.TableAdapterManager.ЕдИзмTableAdapter = Me.ЕдИзмTableAdapter
        Me.TableAdapterManager.КодОперацииTableAdapter = Nothing
        Me.TableAdapterManager.КупляTableAdapter = Nothing
        Me.TableAdapterManager.СкладTableAdapter = Me.СкладTableAdapter
        Me.TableAdapterManager.СотрудникиTableAdapter = Nothing
        Me.TableAdapterManager.ТоварTableAdapter = Me.ТоварTableAdapter
        '
        'ЕдИзмTableAdapter
        '
        Me.ЕдИзмTableAdapter.ClearBeforeFill = True
        '
        'ТоварTableAdapter
        '
        Me.ТоварTableAdapter.ClearBeforeFill = True
        '
        'СкладDataGridView
        '
        Me.СкладDataGridView.AutoGenerateColumns = False
        Me.СкладDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.СкладDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDСкладDataGridViewTextBoxColumn, Me.НаименованиеDataGridViewTextBoxColumn, Me.ЦенаПокупкиDataGridViewTextBoxColumn, Me.КоличествоDataGridViewTextBoxColumn, Me.СуммаDataGridViewTextBoxColumn, Me.ДатаDataGridViewTextBoxColumn, Me.ЕдИзмDataGridViewTextBoxColumn})
        Me.СкладDataGridView.DataSource = Me.СкладBindingSource
        Me.СкладDataGridView.Location = New System.Drawing.Point(0, 252)
        Me.СкладDataGridView.Name = "СкладDataGridView"
        Me.СкладDataGridView.Size = New System.Drawing.Size(859, 67)
        Me.СкладDataGridView.TabIndex = 999
        Me.СкладDataGridView.Visible = False
        '
        'IDСкладDataGridViewTextBoxColumn
        '
        Me.IDСкладDataGridViewTextBoxColumn.DataPropertyName = "ID_Склад"
        Me.IDСкладDataGridViewTextBoxColumn.HeaderText = "ID_Склад"
        Me.IDСкладDataGridViewTextBoxColumn.Name = "IDСкладDataGridViewTextBoxColumn"
        Me.IDСкладDataGridViewTextBoxColumn.ReadOnly = True
        '
        'НаименованиеDataGridViewTextBoxColumn
        '
        Me.НаименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование"
        Me.НаименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование"
        Me.НаименованиеDataGridViewTextBoxColumn.Name = "НаименованиеDataGridViewTextBoxColumn"
        '
        'ЦенаПокупкиDataGridViewTextBoxColumn
        '
        Me.ЦенаПокупкиDataGridViewTextBoxColumn.DataPropertyName = "ЦенаПокупки"
        Me.ЦенаПокупкиDataGridViewTextBoxColumn.HeaderText = "ЦенаПокупки"
        Me.ЦенаПокупкиDataGridViewTextBoxColumn.Name = "ЦенаПокупкиDataGridViewTextBoxColumn"
        '
        'КоличествоDataGridViewTextBoxColumn
        '
        Me.КоличествоDataGridViewTextBoxColumn.DataPropertyName = "Количество"
        Me.КоличествоDataGridViewTextBoxColumn.HeaderText = "Количество"
        Me.КоличествоDataGridViewTextBoxColumn.Name = "КоличествоDataGridViewTextBoxColumn"
        '
        'СуммаDataGridViewTextBoxColumn
        '
        Me.СуммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма"
        Me.СуммаDataGridViewTextBoxColumn.HeaderText = "Сумма"
        Me.СуммаDataGridViewTextBoxColumn.Name = "СуммаDataGridViewTextBoxColumn"
        '
        'ДатаDataGridViewTextBoxColumn
        '
        Me.ДатаDataGridViewTextBoxColumn.DataPropertyName = "Дата"
        Me.ДатаDataGridViewTextBoxColumn.HeaderText = "Дата"
        Me.ДатаDataGridViewTextBoxColumn.Name = "ДатаDataGridViewTextBoxColumn"
        '
        'ЕдИзмDataGridViewTextBoxColumn
        '
        Me.ЕдИзмDataGridViewTextBoxColumn.DataPropertyName = "ЕдИзм"
        Me.ЕдИзмDataGridViewTextBoxColumn.HeaderText = "ЕдИзм"
        Me.ЕдИзмDataGridViewTextBoxColumn.Name = "ЕдИзмDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Склад"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Склад"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Наименование"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Наименование"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ЦенаПокупки"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ЦенаПокупки"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Количество"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Количество"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ЕдИзм"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ЕдИзм"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Рецепт"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Рецепт"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "СрокГодности"
        Me.DataGridViewTextBoxColumn6.HeaderText = "СрокГодности"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Дата"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Дата"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'ЦенаПокупкиTextBox
        '
        Me.ЦенаПокупкиTextBox.Location = New System.Drawing.Point(173, 44)
        Me.ЦенаПокупкиTextBox.Name = "ЦенаПокупкиTextBox"
        Me.ЦенаПокупкиTextBox.Size = New System.Drawing.Size(147, 20)
        Me.ЦенаПокупкиTextBox.TabIndex = 2
        '
        'КоличествоTextBox
        '
        Me.КоличествоTextBox.Location = New System.Drawing.Point(173, 70)
        Me.КоличествоTextBox.Name = "КоличествоTextBox"
        Me.КоличествоTextBox.Size = New System.Drawing.Size(147, 20)
        Me.КоличествоTextBox.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(271, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Выйти"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.СкладBindingSource, "Наименование", True))
        Me.ComboBox1.DataSource = Me.ТоварBindingSource
        Me.ComboBox1.DisplayMember = "Наименование"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(173, 17)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(147, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "ID_товар"
        '
        'ТоварBindingSource
        '
        Me.ТоварBindingSource.DataMember = "Товар"
        Me.ТоварBindingSource.DataSource = Me.shopeDataSet
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.СкладBindingSource, "ЕдИзм", True))
        Me.ComboBox2.DataSource = Me.ЕдИзмBindingSource
        Me.ComboBox2.DisplayMember = "Наименование"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(173, 122)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(147, 21)
        Me.ComboBox2.TabIndex = 4
        Me.ComboBox2.ValueMember = "ID_ЕдИзм"
        '
        'ЕдИзмBindingSource
        '
        Me.ЕдИзмBindingSource.DataMember = "ЕдИзм"
        Me.ЕдИзмBindingSource.DataSource = Me.shopeDataSet
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(194, 175)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(71, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Добавить"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(173, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(147, 20)
        Me.TextBox1.TabIndex = 1000
        '
        'budgetbox
        '
        Me.budgetbox.Enabled = False
        Me.budgetbox.Location = New System.Drawing.Point(202, 151)
        Me.budgetbox.Name = "budgetbox"
        Me.budgetbox.ReadOnly = True
        Me.budgetbox.Size = New System.Drawing.Size(147, 20)
        Me.budgetbox.TabIndex = 1002
        Me.budgetbox.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(37, 212)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1003
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(136, 212)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 1004
        Me.TextBox3.Visible = False
        '
        'Timer1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(НаименованиеLabel)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(ЕдИзмLabel)
        Me.GroupBox1.Controls.Add(Me.budgetbox)
        Me.GroupBox1.Controls.Add(Me.КоличествоTextBox)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(КоличествоLabel)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ЦенаПокупкиTextBox)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(ЦенаПокупкиLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(334, 157)
        Me.GroupBox1.TabIndex = 1005
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Введите информацию о закупаемом товаре:"
        '
        'sklad
        '
        Me.AcceptButton = Me.Button4
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(356, 209)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.СкладDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Name = "sklad"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Пополнение товара на складе"
        CType(Me.shopeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СкладBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СкладDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ТоварBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЕдИзмBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents shopeDataSet As ExhaustWork.shopeDataSet
    Friend WithEvents СкладBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents СкладTableAdapter As ExhaustWork.shopeDataSetTableAdapters.СкладTableAdapter
    Friend WithEvents TableAdapterManager As ExhaustWork.shopeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents СкладDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ЦенаПокупкиTextBox As System.Windows.Forms.TextBox
    Friend WithEvents КоличествоTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ТоварTableAdapter As ExhaustWork.shopeDataSetTableAdapters.ТоварTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ТоварBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ЕдИзмTableAdapter As ExhaustWork.shopeDataSetTableAdapters.ЕдИзмTableAdapter
    Friend WithEvents ЕдИзмBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents budgetbox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents IDСкладDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents НаименованиеDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ЦенаПокупкиDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents КоличествоDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents СуммаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ДатаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ЕдИзмDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
