<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РедактироватьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РедактироватьСправочникЕдИзмToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправочникТоварыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправочникДолжностиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СпрToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СодержаниеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОПрограммеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДанныеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ФормаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ФормаПокупкиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ФормаСотрудникиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ФормаБюджетToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ФайлToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПоискПродажToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПоискТовараНаСкладеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ВыйтиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДанныеToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ФормаПродажиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ФормаПокупкиToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправочникиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.БюджетToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СотрудникиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправочникToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправочникТоварToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправочникОперацииToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправочникДолжностиToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОтчётыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОтчётToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОтчётПродажиЗаМесяцToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОтчётПоПокупкамToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОтчетПоКлиентамToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОтчетПоСотрудникамToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КлиентыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РегистрацияПользователяToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОПрограммеToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'РедактироватьToolStripMenuItem
        '
        Me.РедактироватьToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.РедактироватьСправочникЕдИзмToolStripMenuItem, Me.СправочникТоварыToolStripMenuItem, Me.СправочникДолжностиToolStripMenuItem})
        Me.РедактироватьToolStripMenuItem.Name = "РедактироватьToolStripMenuItem"
        Me.РедактироватьToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.РедактироватьToolStripMenuItem.Text = "Справочники"
        '
        'РедактироватьСправочникЕдИзмToolStripMenuItem
        '
        Me.РедактироватьСправочникЕдИзмToolStripMenuItem.Name = "РедактироватьСправочникЕдИзмToolStripMenuItem"
        Me.РедактироватьСправочникЕдИзмToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+E"
        Me.РедактироватьСправочникЕдИзмToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.РедактироватьСправочникЕдИзмToolStripMenuItem.Size = New System.Drawing.Size(315, 22)
        Me.РедактироватьСправочникЕдИзмToolStripMenuItem.Text = "Справочник <Единицы Измерения>"
        '
        'СправочникТоварыToolStripMenuItem
        '
        Me.СправочникТоварыToolStripMenuItem.Name = "СправочникТоварыToolStripMenuItem"
        Me.СправочникТоварыToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+T"
        Me.СправочникТоварыToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.СправочникТоварыToolStripMenuItem.Size = New System.Drawing.Size(315, 22)
        Me.СправочникТоварыToolStripMenuItem.Text = "Справочник <Товары>"
        '
        'СправочникДолжностиToolStripMenuItem
        '
        Me.СправочникДолжностиToolStripMenuItem.Name = "СправочникДолжностиToolStripMenuItem"
        Me.СправочникДолжностиToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+D"
        Me.СправочникДолжностиToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.СправочникДолжностиToolStripMenuItem.Size = New System.Drawing.Size(315, 22)
        Me.СправочникДолжностиToolStripMenuItem.Text = "Справочник <Должности>"
        '
        'СпрToolStripMenuItem
        '
        Me.СпрToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СодержаниеToolStripMenuItem, Me.ОПрограммеToolStripMenuItem})
        Me.СпрToolStripMenuItem.Name = "СпрToolStripMenuItem"
        Me.СпрToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.СпрToolStripMenuItem.Text = "Справка"
        '
        'СодержаниеToolStripMenuItem
        '
        Me.СодержаниеToolStripMenuItem.Name = "СодержаниеToolStripMenuItem"
        Me.СодержаниеToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.СодержаниеToolStripMenuItem.Text = "Содержание"
        '
        'ОПрограммеToolStripMenuItem
        '
        Me.ОПрограммеToolStripMenuItem.Name = "ОПрограммеToolStripMenuItem"
        Me.ОПрограммеToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ОПрограммеToolStripMenuItem.Text = "О программе"
        '
        'ДанныеToolStripMenuItem
        '
        Me.ДанныеToolStripMenuItem.Name = "ДанныеToolStripMenuItem"
        Me.ДанныеToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ДанныеToolStripMenuItem.Text = "Данные"
        '
        'ФормаToolStripMenuItem
        '
        Me.ФормаToolStripMenuItem.Name = "ФормаToolStripMenuItem"
        Me.ФормаToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ФормаToolStripMenuItem.Text = "Форма <Продажи>"
        '
        'ФормаПокупкиToolStripMenuItem
        '
        Me.ФормаПокупкиToolStripMenuItem.Name = "ФормаПокупкиToolStripMenuItem"
        Me.ФормаПокупкиToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ФормаПокупкиToolStripMenuItem.Text = "Форма <Покупки>"
        '
        'ФормаСотрудникиToolStripMenuItem
        '
        Me.ФормаСотрудникиToolStripMenuItem.Name = "ФормаСотрудникиToolStripMenuItem"
        Me.ФормаСотрудникиToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ФормаСотрудникиToolStripMenuItem.Text = "Форма <Сотрудники>"
        '
        'ФормаБюджетToolStripMenuItem
        '
        Me.ФормаБюджетToolStripMenuItem.Name = "ФормаБюджетToolStripMenuItem"
        Me.ФормаБюджетToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ФормаБюджетToolStripMenuItem.Text = "Форма <Бюджет>"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem1, Me.ДанныеToolStripMenuItem1, Me.СправочникиToolStripMenuItem, Me.ОтчётыToolStripMenuItem, Me.СправкаToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(830, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem1
        '
        Me.ФайлToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПоискПродажToolStripMenuItem, Me.ToolStripSeparator3, Me.ВыйтиToolStripMenuItem})
        Me.ФайлToolStripMenuItem1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ФайлToolStripMenuItem1.Name = "ФайлToolStripMenuItem1"
        Me.ФайлToolStripMenuItem1.Size = New System.Drawing.Size(45, 20)
        Me.ФайлToolStripMenuItem1.Text = "&Файл"
        '
        'ПоискПродажToolStripMenuItem
        '
        Me.ПоискПродажToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПоискТовараНаСкладеToolStripMenuItem})
        Me.ПоискПродажToolStripMenuItem.Name = "ПоискПродажToolStripMenuItem"
        Me.ПоискПродажToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ПоискПродажToolStripMenuItem.Text = "Поиск"
        '
        'ПоискТовараНаСкладеToolStripMenuItem
        '
        Me.ПоискТовараНаСкладеToolStripMenuItem.Name = "ПоискТовараНаСкладеToolStripMenuItem"
        Me.ПоискТовараНаСкладеToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ПоискТовараНаСкладеToolStripMenuItem.Text = "Поиск товара на складе"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(141, 6)
        '
        'ВыйтиToolStripMenuItem
        '
        Me.ВыйтиToolStripMenuItem.Name = "ВыйтиToolStripMenuItem"
        Me.ВыйтиToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X"
        Me.ВыйтиToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ВыйтиToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ВыйтиToolStripMenuItem.Text = "Выйти"
        '
        'ДанныеToolStripMenuItem1
        '
        Me.ДанныеToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФормаПродажиToolStripMenuItem, Me.ФормаПокупкиToolStripMenuItem1})
        Me.ДанныеToolStripMenuItem1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ДанныеToolStripMenuItem1.Name = "ДанныеToolStripMenuItem1"
        Me.ДанныеToolStripMenuItem1.Size = New System.Drawing.Size(69, 20)
        Me.ДанныеToolStripMenuItem1.Text = "&Операции"
        '
        'ФормаПродажиToolStripMenuItem
        '
        Me.ФормаПродажиToolStripMenuItem.Name = "ФормаПродажиToolStripMenuItem"
        Me.ФормаПродажиToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ФормаПродажиToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.ФормаПродажиToolStripMenuItem.Text = "Продажа товара"
        '
        'ФормаПокупкиToolStripMenuItem1
        '
        Me.ФормаПокупкиToolStripMenuItem1.Name = "ФормаПокупкиToolStripMenuItem1"
        Me.ФормаПокупкиToolStripMenuItem1.ShortcutKeyDisplayString = ""
        Me.ФормаПокупкиToolStripMenuItem1.Size = New System.Drawing.Size(228, 22)
        Me.ФормаПокупкиToolStripMenuItem1.Text = "Пополнение товара на складе"
        '
        'СправочникиToolStripMenuItem
        '
        Me.СправочникиToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.БюджетToolStripMenuItem, Me.СотрудникиToolStripMenuItem, Me.СправочникToolStripMenuItem, Me.СправочникТоварToolStripMenuItem, Me.СправочникОперацииToolStripMenuItem, Me.СправочникДолжностиToolStripMenuItem1})
        Me.СправочникиToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.СправочникиToolStripMenuItem.Name = "СправочникиToolStripMenuItem"
        Me.СправочникиToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.СправочникиToolStripMenuItem.Text = "&Справочники"
        '
        'БюджетToolStripMenuItem
        '
        Me.БюджетToolStripMenuItem.Name = "БюджетToolStripMenuItem"
        Me.БюджетToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.БюджетToolStripMenuItem.Text = "Бюджет"
        Me.БюджетToolStripMenuItem.Visible = False
        '
        'СотрудникиToolStripMenuItem
        '
        Me.СотрудникиToolStripMenuItem.Name = "СотрудникиToolStripMenuItem"
        Me.СотрудникиToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.СотрудникиToolStripMenuItem.Text = "Сотрудники"
        '
        'СправочникToolStripMenuItem
        '
        Me.СправочникToolStripMenuItem.Name = "СправочникToolStripMenuItem"
        Me.СправочникToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.СправочникToolStripMenuItem.Text = "Клиенты"
        '
        'СправочникТоварToolStripMenuItem
        '
        Me.СправочникТоварToolStripMenuItem.Name = "СправочникТоварToolStripMenuItem"
        Me.СправочникТоварToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.СправочникТоварToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.СправочникТоварToolStripMenuItem.Text = "Наименование товара"
        '
        'СправочникОперацииToolStripMenuItem
        '
        Me.СправочникОперацииToolStripMenuItem.Name = "СправочникОперацииToolStripMenuItem"
        Me.СправочникОперацииToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.СправочникОперацииToolStripMenuItem.Text = "Операции над товаром"
        Me.СправочникОперацииToolStripMenuItem.Visible = False
        '
        'СправочникДолжностиToolStripMenuItem1
        '
        Me.СправочникДолжностиToolStripMenuItem1.Name = "СправочникДолжностиToolStripMenuItem1"
        Me.СправочникДолжностиToolStripMenuItem1.ShortcutKeyDisplayString = ""
        Me.СправочникДолжностиToolStripMenuItem1.Size = New System.Drawing.Size(200, 22)
        Me.СправочникДолжностиToolStripMenuItem1.Text = "Должности сотрудников"
        '
        'ОтчётыToolStripMenuItem
        '
        Me.ОтчётыToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОтчётToolStripMenuItem, Me.ОтчётПродажиЗаМесяцToolStripMenuItem, Me.ОтчётПоПокупкамToolStripMenuItem, Me.ОтчетПоКлиентамToolStripMenuItem, Me.ОтчетПоСотрудникамToolStripMenuItem, Me.КлиентыToolStripMenuItem})
        Me.ОтчётыToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ОтчётыToolStripMenuItem.Name = "ОтчётыToolStripMenuItem"
        Me.ОтчётыToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ОтчётыToolStripMenuItem.Text = "&Отчёты"
        '
        'ОтчётToolStripMenuItem
        '
        Me.ОтчётToolStripMenuItem.Name = "ОтчётToolStripMenuItem"
        Me.ОтчётToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ОтчётToolStripMenuItem.Text = "Отчёт о товаре на складе"
        Me.ОтчётToolStripMenuItem.Visible = False
        '
        'ОтчётПродажиЗаМесяцToolStripMenuItem
        '
        Me.ОтчётПродажиЗаМесяцToolStripMenuItem.Name = "ОтчётПродажиЗаМесяцToolStripMenuItem"
        Me.ОтчётПродажиЗаМесяцToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ОтчётПродажиЗаМесяцToolStripMenuItem.Text = "Отчёт по проданному товару"
        '
        'ОтчётПоПокупкамToolStripMenuItem
        '
        Me.ОтчётПоПокупкамToolStripMenuItem.Name = "ОтчётПоПокупкамToolStripMenuItem"
        Me.ОтчётПоПокупкамToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ОтчётПоПокупкамToolStripMenuItem.Text = "Отчёт по купленному товару"
        '
        'ОтчетПоКлиентамToolStripMenuItem
        '
        Me.ОтчетПоКлиентамToolStripMenuItem.Name = "ОтчетПоКлиентамToolStripMenuItem"
        Me.ОтчетПоКлиентамToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ОтчетПоКлиентамToolStripMenuItem.Text = "Отчет по покупателям"
        '
        'ОтчетПоСотрудникамToolStripMenuItem
        '
        Me.ОтчетПоСотрудникамToolStripMenuItem.Name = "ОтчетПоСотрудникамToolStripMenuItem"
        Me.ОтчетПоСотрудникамToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ОтчетПоСотрудникамToolStripMenuItem.Text = "Отчет по сотрудникам"
        '
        'КлиентыToolStripMenuItem
        '
        Me.КлиентыToolStripMenuItem.Name = "КлиентыToolStripMenuItem"
        Me.КлиентыToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.КлиентыToolStripMenuItem.Text = "Список клиентов"
        '
        'СправкаToolStripMenuItem
        '
        Me.СправкаToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.РегистрацияПользователяToolStripMenuItem, Me.ОПрограммеToolStripMenuItem1})
        Me.СправкаToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem"
        Me.СправкаToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.СправкаToolStripMenuItem.Text = "&Помощь"
        '
        'РегистрацияПользователяToolStripMenuItem
        '
        Me.РегистрацияПользователяToolStripMenuItem.Name = "РегистрацияПользователяToolStripMenuItem"
        Me.РегистрацияПользователяToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.РегистрацияПользователяToolStripMenuItem.Text = "Регистрация пользователя"
        '
        'ОПрограммеToolStripMenuItem1
        '
        Me.ОПрограммеToolStripMenuItem1.Name = "ОПрограммеToolStripMenuItem1"
        Me.ОПрограммеToolStripMenuItem1.Size = New System.Drawing.Size(212, 22)
        Me.ОПрограммеToolStripMenuItem1.Text = "О программе "
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 554)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(830, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(830, 576)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ИС магазина «Архидея»"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ФайлToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents РедактироватьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents РедактироватьСправочникЕдИзмToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СпрToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СодержаниеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОПрограммеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СправочникТоварыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СправочникДолжностиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ДанныеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ФормаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ФормаПокупкиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ФормаСотрудникиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ФормаБюджетToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ФайлToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ДанныеToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ФормаПродажиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ФормаПокупкиToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СправочникиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СправочникТоварToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СправочникДолжностиToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВыйтиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОтчётыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОтчётПродажиЗаМесяцToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОтчётToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СправочникОперацииToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОтчётПоПокупкамToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ПоискПродажToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents СправкаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОПрограммеToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СправочникToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОтчетПоКлиентамToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПоискТовараНаСкладеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СотрудникиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents БюджетToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents РегистрацияПользователяToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОтчетПоСотрудникамToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents КлиентыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
