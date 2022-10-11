<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buku_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.penerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pengarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jml = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_pinjam = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.buku_id, Me.id_kategori, Me.title, Me.penerbit, Me.pengarang, Me.jml})
        Me.DataGridView1.Location = New System.Drawing.Point(45, 154)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(1087, 454)
        Me.DataGridView1.TabIndex = 0
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.MinimumWidth = 8
        Me.no.Name = "no"
        Me.no.Width = 50
        '
        'buku_id
        '
        Me.buku_id.HeaderText = "Kode Buku"
        Me.buku_id.MinimumWidth = 8
        Me.buku_id.Name = "buku_id"
        Me.buku_id.Width = 150
        '
        'id_kategori
        '
        Me.id_kategori.HeaderText = "Kode Jenis / Kategori Buku"
        Me.id_kategori.MinimumWidth = 8
        Me.id_kategori.Name = "id_kategori"
        Me.id_kategori.Width = 150
        '
        'title
        '
        Me.title.HeaderText = "Judul"
        Me.title.MinimumWidth = 8
        Me.title.Name = "title"
        Me.title.Width = 300
        '
        'penerbit
        '
        Me.penerbit.HeaderText = "Penerbit"
        Me.penerbit.MinimumWidth = 8
        Me.penerbit.Name = "penerbit"
        Me.penerbit.Width = 150
        '
        'pengarang
        '
        Me.pengarang.HeaderText = "Pengarang"
        Me.pengarang.MinimumWidth = 8
        Me.pengarang.Name = "pengarang"
        Me.pengarang.Width = 150
        '
        'jml
        '
        Me.jml.HeaderText = "stok"
        Me.jml.MinimumWidth = 8
        Me.jml.Name = "jml"
        Me.jml.Width = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cari"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(135, 108)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(827, 31)
        Me.txt_search.TabIndex = 2
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(968, 106)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(112, 34)
        Me.btn_search.TabIndex = 3
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'btn_pinjam
        '
        Me.btn_pinjam.Location = New System.Drawing.Point(353, 633)
        Me.btn_pinjam.Name = "btn_pinjam"
        Me.btn_pinjam.Size = New System.Drawing.Size(408, 87)
        Me.btn_pinjam.TabIndex = 21
        Me.btn_pinjam.Text = "PINJAM"
        Me.btn_pinjam.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Stencil", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(449, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 47)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "DATA BUKU"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 748)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_pinjam)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents btn_search As Button
    Friend WithEvents kd_buku As DataGridViewTextBoxColumn
    Friend WithEvents judul As DataGridViewTextBoxColumn
    Friend WithEvents kd_jenis_buku As DataGridViewTextBoxColumn
    Friend WithEvents kd_penerbit As DataGridViewTextBoxColumn
    Friend WithEvents kd_pengarang As DataGridViewTextBoxColumn
    Friend WithEvents stok As DataGridViewTextBoxColumn
    Friend WithEvents btn_pinjam As Button
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents buku_id As DataGridViewTextBoxColumn
    Friend WithEvents id_kategori As DataGridViewTextBoxColumn
    Friend WithEvents title As DataGridViewTextBoxColumn
    Friend WithEvents penerbit As DataGridViewTextBoxColumn
    Friend WithEvents pengarang As DataGridViewTextBoxColumn
    Friend WithEvents jml As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
End Class
