<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prod
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
        Dim ЕдИзмLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim DiscountLabel As System.Windows.Forms.Label
        Me.SaleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.shopeDataSet = New ExhaustWork.shopeDataSet()
        Me.ЦенаПродажиTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ТоварBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.СкладDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.СкладBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.НаименованиеTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ЕдИзмBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboWarranty = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.КоличествоTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.SrttbclientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.SaleTableAdapter = New ExhaustWork.shopeDataSetTableAdapters.SaleTableAdapter()
        Me.TableAdapterManager = New ExhaustWork.shopeDataSetTableAdapters.TableAdapterManager()
        Me.SrttbclientTableAdapter = New ExhaustWork.shopeDataSetTableAdapters.srttbclientTableAdapter()
        Me.ЕдИзмTableAdapter = New ExhaustWork.shopeDataSetTableAdapters.ЕдИзмTableAdapter()
        Me.СкладTableAdapter = New ExhaustWork.shopeDataSetTableAdapters.СкладTableAdapter()
        Me.ТоварTableAdapter = New ExhaustWork.shopeDataSetTableAdapters.ТоварTableAdapter()
        ЕдИзмLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        DiscountLabel = New System.Windows.Forms.Label()
        CType(Me.SaleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shopeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ТоварBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СкладDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СкладBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЕдИзмBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SrttbclientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(6, 17)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(46, 13)
        NameLabel.TabIndex = 18
        NameLabel.Text = "Клиент:"
        '
        'DiscountLabel
        '
        DiscountLabel.AutoSize = True
        DiscountLabel.Location = New System.Drawing.Point(6, 47)
        DiscountLabel.Name = "DiscountLabel"
        DiscountLabel.Size = New System.Drawing.Size(44, 13)
        DiscountLabel.TabIndex = 19
        DiscountLabel.Text = "Скидка"
        '
        'SaleDataGridView
        '
        Me.SaleDataGridView.AutoGenerateColumns = False
        Me.SaleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SaleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.SaleDataGridView.DataSource = Me.SaleBindingSource
        Me.SaleDataGridView.Location = New System.Drawing.Point(21, 152)
        Me.SaleDataGridView.Name = "SaleDataGridView"
        Me.SaleDataGridView.Size = New System.Drawing.Size(118, 28)
        Me.SaleDataGridView.TabIndex = 5
        Me.SaleDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_sale"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_sale"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ЦенаПродажи"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ЦенаПродажи"
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
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Дата"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Дата"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'SaleBindingSource
        '
        Me.SaleBindingSource.DataMember = "Sale"
        Me.SaleBindingSource.DataSource = Me.shopeDataSet
        '
        'shopeDataSet
        '
        Me.shopeDataSet.DataSetName = "shopeDataSet"
        Me.shopeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ЦенаПродажиTextBox
        '
        Me.ЦенаПродажиTextBox.Enabled = False
        Me.ЦенаПродажиTextBox.Location = New System.Drawing.Point(175, 95)
        Me.ЦенаПродажиTextBox.Name = "ЦенаПродажиTextBox"
        Me.ЦенаПродажиTextBox.ReadOnly = True
        Me.ЦенаПродажиTextBox.Size = New System.Drawing.Size(134, 20)
        Me.ЦенаПродажиTextBox.TabIndex = 22
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SaleBindingSource, "Наименование", True))
        Me.ComboBox1.DataSource = Me.ТоварBindingSource
        Me.ComboBox1.DisplayMember = "Наименование"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(175, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(134, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "ID_товар"
        '
        'ТоварBindingSource
        '
        Me.ТоварBindingSource.DataMember = "Товар"
        Me.ТоварBindingSource.DataSource = Me.shopeDataSet
        '
        'СкладDataGridView
        '
        Me.СкладDataGridView.AutoGenerateColumns = False
        Me.СкладDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.СкладDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn13})
        Me.СкладDataGridView.DataSource = Me.СкладBindingSource
        Me.СкладDataGridView.Location = New System.Drawing.Point(12, 102)
        Me.СкладDataGridView.Name = "СкладDataGridView"
        Me.СкладDataGridView.Size = New System.Drawing.Size(127, 44)
        Me.СкладDataGridView.TabIndex = 14
        Me.СкладDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ID_Склад"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID_Склад"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Наименование"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Наименование"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ЦенаПокупки"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ЦенаПокупки"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Количество"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Количество"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ЕдИзм"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ЕдИзм"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Дата"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Дата"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'СкладBindingSource
        '
        Me.СкладBindingSource.DataMember = "Склад"
        Me.СкладBindingSource.DataSource = Me.shopeDataSet
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(19, 152)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Visible = False
        '
        'НаименованиеTextBox
        '
        Me.НаименованиеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaleBindingSource, "Наименование", True))
        Me.НаименованиеTextBox.Location = New System.Drawing.Point(192, 60)
        Me.НаименованиеTextBox.Name = "НаименованиеTextBox"
        Me.НаименованиеTextBox.Size = New System.Drawing.Size(100, 20)
        Me.НаименованиеTextBox.TabIndex = 16
        Me.НаименованиеTextBox.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SaleBindingSource, "ЕдИзм", True))
        Me.ComboBox2.DataSource = Me.ЕдИзмBindingSource
        Me.ComboBox2.DisplayMember = "Наименование"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(175, 122)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(134, 21)
        Me.ComboBox2.TabIndex = 4
        Me.ComboBox2.ValueMember = "ID_ЕдИзм"
        '
        'ЕдИзмBindingSource
        '
        Me.ЕдИзмBindingSource.DataMember = "ЕдИзм"
        Me.ЕдИзмBindingSource.DataSource = Me.shopeDataSet
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(552, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Выйти"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.comboWarranty)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(ЕдИзмLabel)
        Me.GroupBox1.Controls.Add(Me.ЦенаПродажиTextBox)
        Me.GroupBox1.Controls.Add(Me.КоличествоTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(280, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 178)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Введите информацию о продаваемом товаре:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Гарантия:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Общая стоимость товара:"
        '
        'comboWarranty
        '
        Me.comboWarranty.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SaleBindingSource, "ЕдИзм", True))
        Me.comboWarranty.FormattingEnabled = True
        Me.comboWarranty.Items.AddRange(New Object() {"3 Месяца", "Полгода" & Global.Microsoft.VisualBasic.ChrW(9), "Год", "2 Года", "3 Года"})
        Me.comboWarranty.Location = New System.Drawing.Point(175, 149)
        Me.comboWarranty.Name = "comboWarranty"
        Me.comboWarranty.Size = New System.Drawing.Size(134, 21)
        Me.comboWarranty.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Наименование товара:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Цена единицы товара:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Количество единиц товара:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(319, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 23
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(175, 44)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(134, 20)
        Me.TextBox2.TabIndex = 2
        '
        'КоличествоTextBox
        '
        Me.КоличествоTextBox.Location = New System.Drawing.Point(175, 69)
        Me.КоличествоTextBox.Name = "КоличествоTextBox"
        Me.КоличествоTextBox.Size = New System.Drawing.Size(134, 20)
        Me.КоличествоTextBox.TabIndex = 3
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(471, 196)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Добавить"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(156, 252)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 17
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(294, 252)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(63, 20)
        Me.TextBox4.TabIndex = 18
        '
        'NameComboBox
        '
        Me.NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SrttbclientBindingSource, "Name", True))
        Me.NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SrttbclientBindingSource, "IDClient", True))
        Me.NameComboBox.DataSource = Me.SrttbclientBindingSource
        Me.NameComboBox.DisplayMember = "Name"
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(65, 14)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(191, 21)
        Me.NameComboBox.TabIndex = 19
        Me.NameComboBox.ValueMember = "IDClient"
        '
        'SrttbclientBindingSource
        '
        Me.SrttbclientBindingSource.DataMember = "srttbclient"
        Me.SrttbclientBindingSource.DataSource = Me.shopeDataSet
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DiscountTextBox)
        Me.GroupBox2.Controls.Add(DiscountLabel)
        Me.GroupBox2.Controls.Add(NameLabel)
        Me.GroupBox2.Controls.Add(Me.NameComboBox)
        Me.GroupBox2.Controls.Add(Me.НаименованиеTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(262, 70)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Выберите клиента:"
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SrttbclientBindingSource, "Discount", True))
        Me.DiscountTextBox.Location = New System.Drawing.Point(66, 44)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.ReadOnly = True
        Me.DiscountTextBox.Size = New System.Drawing.Size(120, 20)
        Me.DiscountTextBox.TabIndex = 20
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
        Me.TableAdapterManager.srttbclientTableAdapter = Me.SrttbclientTableAdapter
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
        'SrttbclientTableAdapter
        '
        Me.SrttbclientTableAdapter.ClearBeforeFill = True
        '
        'ЕдИзмTableAdapter
        '
        Me.ЕдИзмTableAdapter.ClearBeforeFill = True
        '
        'СкладTableAdapter
        '
        Me.СкладTableAdapter.ClearBeforeFill = True
        '
        'ТоварTableAdapter
        '
        Me.ТоварTableAdapter.ClearBeforeFill = True
        '
        'prod
        '
        Me.AcceptButton = Me.Button4
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(637, 225)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.СкладDataGridView)
        Me.Controls.Add(Me.SaleDataGridView)
        Me.Name = "prod"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Пополнение товара на складе"
        CType(Me.SaleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shopeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ТоварBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СкладDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СкладBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЕдИзмBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SrttbclientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents shopeDataSet As ExhaustWork.shopeDataSet
    Friend WithEvents SaleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SaleTableAdapter As ExhaustWork.shopeDataSetTableAdapters.SaleTableAdapter
    Friend WithEvents TableAdapterManager As ExhaustWork.shopeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents СкладTableAdapter As ExhaustWork.shopeDataSetTableAdapters.СкладTableAdapter
    Friend WithEvents SaleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ЦенаПродажиTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents СкладBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents СкладDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents НаименованиеTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ТоварBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ТоварTableAdapter As ExhaustWork.shopeDataSetTableAdapters.ТоварTableAdapter
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ЕдИзмBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ЕдИзмTableAdapter As ExhaustWork.shopeDataSetTableAdapters.ЕдИзмTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents КоличествоTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SrttbclientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SrttbclientTableAdapter As ExhaustWork.shopeDataSetTableAdapters.srttbclientTableAdapter
    Friend WithEvents NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DiscountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents comboWarranty As System.Windows.Forms.ComboBox
End Class
