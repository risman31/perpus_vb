<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPeminjaman
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_pinjam_id = New System.Windows.Forms.TextBox()
        Me.txt_anggota_id = New System.Windows.Forms.TextBox()
        Me.txt_buku_id = New System.Windows.Forms.TextBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pinjam_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.anggota_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buku_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lama_pinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_pinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_balik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_lama_pinjam = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_id_pinjam = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_tgl_kembali = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_otomatis = New System.Windows.Forms.Label()
        Me.txt_tgl_pinjam = New System.Windows.Forms.TextBox()
        Me.txt_tgl_balik = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(752, 595)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(501, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA PEMINJAMAN BUKU"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Peminjaman"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode Anggota"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kode Buku"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(168, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(97, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tanggal Pinjam"
        '
        'txt_pinjam_id
        '
        Me.txt_pinjam_id.Location = New System.Drawing.Point(234, 140)
        Me.txt_pinjam_id.Name = "txt_pinjam_id"
        Me.txt_pinjam_id.Size = New System.Drawing.Size(150, 31)
        Me.txt_pinjam_id.TabIndex = 6
        '
        'txt_anggota_id
        '
        Me.txt_anggota_id.Location = New System.Drawing.Point(234, 179)
        Me.txt_anggota_id.Name = "txt_anggota_id"
        Me.txt_anggota_id.Size = New System.Drawing.Size(150, 31)
        Me.txt_anggota_id.TabIndex = 7
        '
        'txt_buku_id
        '
        Me.txt_buku_id.Location = New System.Drawing.Point(234, 221)
        Me.txt_buku_id.Name = "txt_buku_id"
        Me.txt_buku_id.Size = New System.Drawing.Size(150, 31)
        Me.txt_buku_id.TabIndex = 8
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(50, 495)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(334, 65)
        Me.btn_simpan.TabIndex = 11
        Me.btn_simpan.Text = "SIMPAN"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_batal
        '
        Me.btn_batal.Location = New System.Drawing.Point(234, 577)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(150, 65)
        Me.btn_batal.TabIndex = 12
        Me.btn_batal.Text = "BATAL"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.pinjam_id, Me.anggota_id, Me.buku_id, Me.status, Me.lama_pinjam, Me.tgl_pinjam, Me.tgl_balik})
        Me.DataGridView1.Location = New System.Drawing.Point(433, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(1090, 466)
        Me.DataGridView1.TabIndex = 14
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.MinimumWidth = 8
        Me.no.Name = "no"
        Me.no.Width = 50
        '
        'pinjam_id
        '
        Me.pinjam_id.HeaderText = "Kode Peminjaman"
        Me.pinjam_id.MinimumWidth = 8
        Me.pinjam_id.Name = "pinjam_id"
        Me.pinjam_id.Width = 150
        '
        'anggota_id
        '
        Me.anggota_id.HeaderText = "Kode Anggota"
        Me.anggota_id.MinimumWidth = 8
        Me.anggota_id.Name = "anggota_id"
        Me.anggota_id.Width = 150
        '
        'buku_id
        '
        Me.buku_id.HeaderText = "Kode Buku"
        Me.buku_id.MinimumWidth = 8
        Me.buku_id.Name = "buku_id"
        Me.buku_id.Width = 150
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.MinimumWidth = 8
        Me.status.Name = "status"
        Me.status.Width = 150
        '
        'lama_pinjam
        '
        Me.lama_pinjam.HeaderText = "Lama Pinjam"
        Me.lama_pinjam.MinimumWidth = 8
        Me.lama_pinjam.Name = "lama_pinjam"
        Me.lama_pinjam.Width = 80
        '
        'tgl_pinjam
        '
        Me.tgl_pinjam.HeaderText = "Tanggal Pinjam"
        Me.tgl_pinjam.MinimumWidth = 8
        Me.tgl_pinjam.Name = "tgl_pinjam"
        Me.tgl_pinjam.Width = 150
        '
        'tgl_balik
        '
        Me.tgl_balik.HeaderText = "Tanggal Balik"
        Me.tgl_balik.MinimumWidth = 8
        Me.tgl_balik.Name = "tgl_balik"
        Me.tgl_balik.Width = 150
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(50, 577)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(150, 65)
        Me.btn_delete.TabIndex = 16
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(702, 42)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(501, 31)
        Me.txt_search.TabIndex = 17
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(1209, 42)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(103, 31)
        Me.btn_search.TabIndex = 18
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(641, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 25)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Cari"
        '
        'txt_lama_pinjam
        '
        Me.txt_lama_pinjam.Location = New System.Drawing.Point(234, 352)
        Me.txt_lama_pinjam.Name = "txt_lama_pinjam"
        Me.txt_lama_pinjam.Size = New System.Drawing.Size(100, 31)
        Me.txt_lama_pinjam.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(114, 404)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 25)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Tanggal Balik"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(116, 355)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 25)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Lama Pinjam"
        '
        'cmb_status
        '
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Items.AddRange(New Object() {"Dipinjam"})
        Me.cmb_status.Location = New System.Drawing.Point(234, 264)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(150, 33)
        Me.cmb_status.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(340, 355)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 25)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Hari"
        '
        'txt_id_pinjam
        '
        Me.txt_id_pinjam.Location = New System.Drawing.Point(234, 94)
        Me.txt_id_pinjam.Name = "txt_id_pinjam"
        Me.txt_id_pinjam.Size = New System.Drawing.Size(52, 31)
        Me.txt_id_pinjam.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(131, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 25)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "ID Pinjam"
        '
        'txt_tgl_kembali
        '
        Me.txt_tgl_kembali.Location = New System.Drawing.Point(234, 446)
        Me.txt_tgl_kembali.Name = "txt_tgl_kembali"
        Me.txt_tgl_kembali.Size = New System.Drawing.Size(150, 31)
        Me.txt_tgl_kembali.TabIndex = 30
        Me.txt_tgl_kembali.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(43, 449)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(185, 25)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Tanggal Dikembalikan"
        '
        'lbl_otomatis
        '
        Me.lbl_otomatis.AutoSize = True
        Me.lbl_otomatis.Location = New System.Drawing.Point(293, 97)
        Me.lbl_otomatis.Name = "lbl_otomatis"
        Me.lbl_otomatis.Size = New System.Drawing.Size(91, 25)
        Me.lbl_otomatis.TabIndex = 31
        Me.lbl_otomatis.Text = "*otomatis"
        '
        'txt_tgl_pinjam
        '
        Me.txt_tgl_pinjam.Location = New System.Drawing.Point(234, 310)
        Me.txt_tgl_pinjam.Name = "txt_tgl_pinjam"
        Me.txt_tgl_pinjam.Size = New System.Drawing.Size(150, 31)
        Me.txt_tgl_pinjam.TabIndex = 32
        '
        'txt_tgl_balik
        '
        Me.txt_tgl_balik.Location = New System.Drawing.Point(234, 401)
        Me.txt_tgl_balik.Name = "txt_tgl_balik"
        Me.txt_tgl_balik.Size = New System.Drawing.Size(150, 31)
        Me.txt_tgl_balik.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(439, 25)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "-- SILAHKAN LENGKAPI FORM PEMINJAMAN BUKU --"
        '
        'FormPeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1582, 664)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_tgl_balik)
        Me.Controls.Add(Me.txt_tgl_pinjam)
        Me.Controls.Add(Me.lbl_otomatis)
        Me.Controls.Add(Me.txt_tgl_kembali)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_id_pinjam)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmb_status)
        Me.Controls.Add(Me.txt_lama_pinjam)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_batal)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.txt_buku_id)
        Me.Controls.Add(Me.txt_anggota_id)
        Me.Controls.Add(Me.txt_pinjam_id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPeminjaman"
        Me.Text = "FormPeminjaman"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_pinjam_id As TextBox
    Friend WithEvents txt_anggota_id As TextBox
    Friend WithEvents txt_buku_id As TextBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_batal As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_delete As Button
    Friend WithEvents txt_search As TextBox
    Friend WithEvents btn_search As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents pinjam_id As DataGridViewTextBoxColumn
    Friend WithEvents anggota_id As DataGridViewTextBoxColumn
    Friend WithEvents buku_id As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents lama_pinjam As DataGridViewTextBoxColumn
    Friend WithEvents tgl_pinjam As DataGridViewTextBoxColumn
    Friend WithEvents tgl_balik As DataGridViewTextBoxColumn
    Friend WithEvents txt_lama_pinjam As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_status As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_id_pinjam As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_tgl_kembali As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_otomatis As Label
    Friend WithEvents txt_tgl_pinjam As TextBox
    Friend WithEvents txt_tgl_balik As TextBox
    Friend WithEvents Label13 As Label
End Class
