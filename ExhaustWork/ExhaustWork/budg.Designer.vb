<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class budg
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
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.IDBudgetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ОперацияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.КодОперацииBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.shopeDataSet = New ExhaustWork.shopeDataSet
        Me.ДатаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПриходDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.РасходDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.СуммаБюджетаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BudgetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BudgetTableAdapter = New ExhaustWork.shopeDataSetTableAdapters.BudgetTableAdapter
        Me.Button3 = New System.Windows.Forms.Button
        Me.КодОперацииBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.КодОперацииTableAdapter = New ExhaustWork.shopeDataSetTableAdapters.КодОперацииTableAdapter
        Me.TableAdapterManager = New ExhaustWork.shopeDataSetTableAdapters.TableAdapterManager
        Me.НаименованиеComboBox = New System.Windows.Forms.ComboBox
        Me.КодОперацииBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КодОперацииBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shopeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BudgetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КодОперацииBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КодОперацииBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(73, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(129, 20)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(73, 90)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(129, 20)
        Me.TextBox4.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Операция:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Дата:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Приход:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Расход:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(73, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Добавить"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(606, 115)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Выйти"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDBudgetDataGridViewTextBoxColumn, Me.ОперацияDataGridViewTextBoxColumn, Me.ДатаDataGridViewTextBoxColumn, Me.ПриходDataGridViewTextBoxColumn, Me.РасходDataGridViewTextBoxColumn, Me.СуммаБюджетаDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BudgetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(208, 11)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(486, 98)
        Me.DataGridView1.TabIndex = 11
        '
        'IDBudgetDataGridViewTextBoxColumn
        '
        Me.IDBudgetDataGridViewTextBoxColumn.DataPropertyName = "ID_Budget"
        Me.IDBudgetDataGridViewTextBoxColumn.HeaderText = "ID_Budget"
        Me.IDBudgetDataGridViewTextBoxColumn.Name = "IDBudgetDataGridViewTextBoxColumn"
        Me.IDBudgetDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDBudgetDataGridViewTextBoxColumn.Visible = False
        '
        'ОперацияDataGridViewTextBoxColumn
        '
        Me.ОперацияDataGridViewTextBoxColumn.DataPropertyName = "Операция"
        Me.ОперацияDataGridViewTextBoxColumn.DataSource = Me.КодОперацииBindingSource2
        Me.ОперацияDataGridViewTextBoxColumn.DisplayMember = "Наименование"
        Me.ОперацияDataGridViewTextBoxColumn.HeaderText = "Операция"
        Me.ОперацияDataGridViewTextBoxColumn.Name = "ОперацияDataGridViewTextBoxColumn"
        Me.ОперацияDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ОперацияDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ОперацияDataGridViewTextBoxColumn.ValueMember = "ID_Операция"
        Me.ОперацияDataGridViewTextBoxColumn.Width = 125
        '
        'КодОперацииBindingSource2
        '
        Me.КодОперацииBindingSource2.DataMember = "КодОперации"
        Me.КодОперацииBindingSource2.DataSource = Me.shopeDataSet
        '
        'shopeDataSet
        '
        Me.shopeDataSet.DataSetName = "shopeDataSet"
        Me.shopeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ДатаDataGridViewTextBoxColumn
        '
        Me.ДатаDataGridViewTextBoxColumn.DataPropertyName = "Дата"
        Me.ДатаDataGridViewTextBoxColumn.HeaderText = "Дата"
        Me.ДатаDataGridViewTextBoxColumn.Name = "ДатаDataGridViewTextBoxColumn"
        '
        'ПриходDataGridViewTextBoxColumn
        '
        Me.ПриходDataGridViewTextBoxColumn.DataPropertyName = "Приход"
        Me.ПриходDataGridViewTextBoxColumn.HeaderText = "Приход"
        Me.ПриходDataGridViewTextBoxColumn.Name = "ПриходDataGridViewTextBoxColumn"
        '
        'РасходDataGridViewTextBoxColumn
        '
        Me.РасходDataGridViewTextBoxColumn.DataPropertyName = "Расход"
        Me.РасходDataGridViewTextBoxColumn.HeaderText = "Расход"
        Me.РасходDataGridViewTextBoxColumn.Name = "РасходDataGridViewTextBoxColumn"
        '
        'СуммаБюджетаDataGridViewTextBoxColumn
        '
        Me.СуммаБюджетаDataGridViewTextBoxColumn.DataPropertyName = "СуммаБюджета"
        Me.СуммаБюджетаDataGridViewTextBoxColumn.HeaderText = "СуммаБюджета"
        Me.СуммаБюджетаDataGridViewTextBoxColumn.Name = "СуммаБюджетаDataGridViewTextBoxColumn"
        Me.СуммаБюджетаDataGridViewTextBoxColumn.Visible = False
        '
        'BudgetBindingSource
        '
        Me.BudgetBindingSource.DataMember = "Budget"
        Me.BudgetBindingSource.DataSource = Me.shopeDataSet
        '
        'BudgetTableAdapter
        '
        Me.BudgetTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(208, 115)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Удалить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'КодОперацииBindingSource
        '
        Me.КодОперацииBindingSource.DataMember = "КодОперации"
        Me.КодОперацииBindingSource.DataSource = Me.shopeDataSet
        '
        'КодОперацииTableAdapter
        '
        Me.КодОперацииTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BudgetTableAdapter = Me.BudgetTableAdapter
        Me.TableAdapterManager.SaleTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ExhaustWork.shopeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.ДолжностиTableAdapter = Nothing
        Me.TableAdapterManager.ЕдИзмTableAdapter = Nothing
        Me.TableAdapterManager.КодОперацииTableAdapter = Me.КодОперацииTableAdapter
        Me.TableAdapterManager.КупляTableAdapter = Nothing
        Me.TableAdapterManager.СкладTableAdapter = Nothing
        Me.TableAdapterManager.СотрудникиTableAdapter = Nothing
        Me.TableAdapterManager.ТоварTableAdapter = Nothing
        '
        'НаименованиеComboBox
        '
        Me.НаименованиеComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.КодОперацииBindingSource, "Наименование", True))
        Me.НаименованиеComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BudgetBindingSource, "Операция", True))
        Me.НаименованиеComboBox.DataSource = Me.КодОперацииBindingSource1
        Me.НаименованиеComboBox.DisplayMember = "Наименование"
        Me.НаименованиеComboBox.FormattingEnabled = True
        Me.НаименованиеComboBox.Location = New System.Drawing.Point(73, 11)
        Me.НаименованиеComboBox.Name = "НаименованиеComboBox"
        Me.НаименованиеComboBox.Size = New System.Drawing.Size(129, 21)
        Me.НаименованиеComboBox.TabIndex = 1
        Me.НаименованиеComboBox.ValueMember = "ID_Операция"
        '
        'КодОперацииBindingSource1
        '
        Me.КодОперацииBindingSource1.DataMember = "КодОперации"
        Me.КодОперацииBindingSource1.DataSource = Me.shopeDataSet
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(334, 119)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(25, 20)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(365, 119)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(25, 20)
        Me.TextBox5.TabIndex = 15
        Me.TextBox5.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(73, 41)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(129, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'budg
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(693, 149)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.НаименованиеComboBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Name = "budg"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Форма <Бюджет>"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КодОперацииBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shopeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BudgetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КодОперацииBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КодОперацииBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents shopeDataSet As ExhaustWork.shopeDataSet
    Friend WithEvents BudgetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BudgetTableAdapter As ExhaustWork.shopeDataSetTableAdapters.BudgetTableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents КодОперацииBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents КодОперацииTableAdapter As ExhaustWork.shopeDataSetTableAdapters.КодОперацииTableAdapter
    Friend WithEvents TableAdapterManager As ExhaustWork.shopeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents НаименованиеComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents КодОперацииBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents КодОперацииBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents IDBudgetDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ОперацияDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ДатаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПриходDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents РасходDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents СуммаБюджетаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
