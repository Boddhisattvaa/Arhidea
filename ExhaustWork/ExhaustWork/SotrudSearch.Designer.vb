<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SotrudSearch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim NameLabel As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.shopeDataSet = New ExhaustWork.shopeDataSet
        Me.SrttbclientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SrttbclientTableAdapter = New ExhaustWork.shopeDataSetTableAdapters.srttbclientTableAdapter
        Me.TableAdapterManager = New ExhaustWork.shopeDataSetTableAdapters.TableAdapterManager
        Me.NameComboBox = New System.Windows.Forms.ComboBox
        NameLabel = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shopeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SrttbclientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(12, 275)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(70, 13)
        NameLabel.TabIndex = 2
        NameLabel.Text = "Покупатель:"
        AddHandler NameLabel.Click, AddressOf Me.NameLabel_Click
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, -1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(610, 264)
        Me.DataGridView1.TabIndex = 0
        '
        'shopeDataSet
        '
        Me.shopeDataSet.DataSetName = "shopeDataSet"
        Me.shopeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SrttbclientBindingSource
        '
        Me.SrttbclientBindingSource.DataMember = "srttbclient"
        Me.SrttbclientBindingSource.DataSource = Me.shopeDataSet
        '
        'SrttbclientTableAdapter
        '
        Me.SrttbclientTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BudgetTableAdapter = Nothing
        Me.TableAdapterManager.SaleTableAdapter = Nothing
        Me.TableAdapterManager.srttbclientTableAdapter = Me.SrttbclientTableAdapter
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
        'NameComboBox
        '
        Me.NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SrttbclientBindingSource, "Name", True))
        Me.NameComboBox.DataSource = Me.SrttbclientBindingSource
        Me.NameComboBox.DisplayMember = "Name"
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(88, 272)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NameComboBox.TabIndex = 3
        Me.NameComboBox.ValueMember = "Name"
        '
        'SotrudSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 297)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameComboBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "SotrudSearch"
        Me.ShowIcon = False
        Me.Text = "Поиск покупателей"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shopeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SrttbclientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents shopeDataSet As ExhaustWork.shopeDataSet
    Friend WithEvents SrttbclientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SrttbclientTableAdapter As ExhaustWork.shopeDataSetTableAdapters.srttbclientTableAdapter
    Friend WithEvents TableAdapterManager As ExhaustWork.shopeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NameComboBox As System.Windows.Forms.ComboBox
End Class
