<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterBarang
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.mnuButton = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEXIT = New System.Windows.Forms.Button()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.fraData = New System.Windows.Forms.GroupBox()
        Me.NumHarga = New System.Windows.Forms.NumericUpDown()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuButton.SuspendLayout()
        Me.fraData.SuspendLayout()
        CType(Me.NumHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 308)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1128, 402)
        Me.DataGridView1.TabIndex = 0
        '
        'mnuButton
        '
        Me.mnuButton.Controls.Add(Me.btnSave)
        Me.mnuButton.Controls.Add(Me.btnEXIT)
        Me.mnuButton.Controls.Add(Me.btnDELETE)
        Me.mnuButton.Controls.Add(Me.btnEDIT)
        Me.mnuButton.Controls.Add(Me.btnADD)
        Me.mnuButton.Location = New System.Drawing.Point(215, 228)
        Me.mnuButton.Name = "mnuButton"
        Me.mnuButton.Size = New System.Drawing.Size(584, 74)
        Me.mnuButton.TabIndex = 1
        Me.mnuButton.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(247, 25)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 37)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEXIT
        '
        Me.btnEXIT.Location = New System.Drawing.Point(475, 25)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(89, 37)
        Me.btnEXIT.TabIndex = 3
        Me.btnEXIT.Text = "EXIT"
        Me.btnEXIT.UseVisualStyleBackColor = True
        '
        'btnDELETE
        '
        Me.btnDELETE.Location = New System.Drawing.Point(356, 25)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(89, 37)
        Me.btnDELETE.TabIndex = 2
        Me.btnDELETE.Text = "DELETE"
        Me.btnDELETE.UseVisualStyleBackColor = True
        '
        'btnEDIT
        '
        Me.btnEDIT.Location = New System.Drawing.Point(130, 25)
        Me.btnEDIT.Name = "btnEDIT"
        Me.btnEDIT.Size = New System.Drawing.Size(89, 37)
        Me.btnEDIT.TabIndex = 1
        Me.btnEDIT.Text = "EDIT"
        Me.btnEDIT.UseVisualStyleBackColor = True
        '
        'btnADD
        '
        Me.btnADD.Location = New System.Drawing.Point(12, 25)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(89, 37)
        Me.btnADD.TabIndex = 0
        Me.btnADD.Text = "ADD"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'fraData
        '
        Me.fraData.Controls.Add(Me.NumHarga)
        Me.fraData.Controls.Add(Me.txtNama)
        Me.fraData.Controls.Add(Me.txtKode)
        Me.fraData.Controls.Add(Me.Label3)
        Me.fraData.Controls.Add(Me.Label2)
        Me.fraData.Controls.Add(Me.Label1)
        Me.fraData.Location = New System.Drawing.Point(13, 13)
        Me.fraData.Name = "fraData"
        Me.fraData.Size = New System.Drawing.Size(1127, 209)
        Me.fraData.TabIndex = 2
        Me.fraData.TabStop = False
        Me.fraData.Text = "BARANG"
        '
        'NumHarga
        '
        Me.NumHarga.Location = New System.Drawing.Point(315, 146)
        Me.NumHarga.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.NumHarga.Name = "NumHarga"
        Me.NumHarga.Size = New System.Drawing.Size(451, 26)
        Me.NumHarga.TabIndex = 5
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(315, 96)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(451, 26)
        Me.txtNama.TabIndex = 4
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(315, 52)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(451, 26)
        Me.txtKode.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "HARGA BARANG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA BARANG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KODE BARANG"
        '
        'frmMasterBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 737)
        Me.Controls.Add(Me.fraData)
        Me.Controls.Add(Me.mnuButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmMasterBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DAFTAR BARANG"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuButton.ResumeLayout(False)
        Me.fraData.ResumeLayout(False)
        Me.fraData.PerformLayout()
        CType(Me.NumHarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents mnuButton As System.Windows.Forms.GroupBox
    Friend WithEvents btnEXIT As System.Windows.Forms.Button
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnEDIT As System.Windows.Forms.Button
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents fraData As System.Windows.Forms.GroupBox
    Friend WithEvents NumHarga As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtKode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button

End Class
