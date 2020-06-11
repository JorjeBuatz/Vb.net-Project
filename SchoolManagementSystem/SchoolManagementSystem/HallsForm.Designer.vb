<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HallsForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HallBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchoolDatabaseDataSet = New SchoolManagementSystem.SchoolDatabaseDataSet()
        Me.HallTableAdapter = New SchoolManagementSystem.SchoolDatabaseDataSetTableAdapters.HallTableAdapter()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.HallNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HallBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(195, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Halls"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HallNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HallBindingSource
        Me.DataGridView1.GridColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.Location = New System.Drawing.Point(93, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(255, 334)
        Me.DataGridView1.TabIndex = 1
        '
        'HallBindingSource
        '
        Me.HallBindingSource.DataMember = "Hall"
        Me.HallBindingSource.DataSource = Me.SchoolDatabaseDataSet
        '
        'SchoolDatabaseDataSet
        '
        Me.SchoolDatabaseDataSet.DataSetName = "SchoolDatabaseDataSet"
        Me.SchoolDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HallTableAdapter
        '
        Me.HallTableAdapter.ClearBeforeFill = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Location = New System.Drawing.Point(176, 404)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(75, 23)
        Me.SaveBtn.TabIndex = 2
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'HallNameDataGridViewTextBoxColumn
        '
        Me.HallNameDataGridViewTextBoxColumn.DataPropertyName = "HallName"
        Me.HallNameDataGridViewTextBoxColumn.HeaderText = "Hall Name"
        Me.HallNameDataGridViewTextBoxColumn.Name = "HallNameDataGridViewTextBoxColumn"
        Me.HallNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.HallNameDataGridViewTextBoxColumn.Width = 250
        '
        'HallsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(448, 439)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HallsForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HallsForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HallBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SchoolDatabaseDataSet As SchoolDatabaseDataSet
    Friend WithEvents HallBindingSource As BindingSource
    Friend WithEvents HallTableAdapter As SchoolDatabaseDataSetTableAdapters.HallTableAdapter
    Friend WithEvents SaveBtn As Button
    Friend WithEvents HallNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
