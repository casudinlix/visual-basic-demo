<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textEmail = New System.Windows.Forms.TextBox()
        Me.textName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.LatihanDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LatihanDataSet = New WindowsApplication1.latihanDataSet()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LatihanDataSet1 = New WindowsApplication1.latihanDataSet1()
        Me.LatihanDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.keyword = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.textId = New System.Windows.Forms.TextBox()
        CType(Me.LatihanDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LatihanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LatihanDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LatihanDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Label4.UseMnemonic = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Label5.UseMnemonic = False
        '
        'textEmail
        '
        Me.textEmail.Location = New System.Drawing.Point(116, 40)
        Me.textEmail.Name = "textEmail"
        Me.textEmail.Size = New System.Drawing.Size(186, 20)
        Me.textEmail.TabIndex = 7
        '
        'textName
        '
        Me.textName.Location = New System.Drawing.Point(116, 12)
        Me.textName.Name = "textName"
        Me.textName.Size = New System.Drawing.Size(186, 20)
        Me.textName.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(208, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Hapus"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(119, 67)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Ubah"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'LatihanDataSetBindingSource
        '
        Me.LatihanDataSetBindingSource.DataSource = Me.LatihanDataSet
        Me.LatihanDataSetBindingSource.Position = 0
        '
        'LatihanDataSet
        '
        Me.LatihanDataSet.DataSetName = "latihanDataSet"
        Me.LatihanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(297, 66)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Keluar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 134)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(400, 207)
        Me.DataGridView1.TabIndex = 14
        '
        'LatihanDataSet1
        '
        Me.LatihanDataSet1.DataSetName = "latihanDataSet1"
        Me.LatihanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LatihanDataSet1BindingSource
        '
        Me.LatihanDataSet1BindingSource.DataSource = Me.LatihanDataSet1
        Me.LatihanDataSet1BindingSource.Position = 0
        '
        'keyword
        '
        Me.keyword.Location = New System.Drawing.Point(26, 108)
        Me.keyword.MaximumSize = New System.Drawing.Size(250, 300)
        Me.keyword.Name = "keyword"
        Me.keyword.Size = New System.Drawing.Size(250, 20)
        Me.keyword.TabIndex = 15
        Me.keyword.Text = "Cari"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(285, 108)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 19)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Cari"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'textId
        '
        Me.textId.Location = New System.Drawing.Point(308, 11)
        Me.textId.Name = "textId"
        Me.textId.Size = New System.Drawing.Size(100, 20)
        Me.textId.TabIndex = 17
        Me.textId.Visible = False
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 371)
        Me.Controls.Add(Me.textId)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.keyword)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.textName)
        Me.Controls.Add(Me.textEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Name = "User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User"
        CType(Me.LatihanDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LatihanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LatihanDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LatihanDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents textEmail As TextBox
    Friend WithEvents textName As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents LatihanDataSetBindingSource As BindingSource
    Friend WithEvents LatihanDataSet As latihanDataSet
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LatihanDataSet1BindingSource As BindingSource
    Friend WithEvents LatihanDataSet1 As latihanDataSet1
    Friend WithEvents keyword As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents textId As TextBox
End Class
