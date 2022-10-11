Imports System.Net
Imports System.IO
Imports Nancy.Json
Public Class FormPeminjaman

    Public id As String

    Private Sub caripeminjaman()
        Try
            Dim no As Integer
            DataGridView1.Rows.Clear()
            no = 1
            Dim uriString As String = "http://localhost/uts-perpus-ci/index.php/api/GetDataPeminjaman" & txt_search.Text.Trim
            Dim uri As New Uri(uriString)
            Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse()
            Dim read = New StreamReader(response.GetResponseStream())
            Dim raw As String = read.ReadToEnd()
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
            For Each item As Object In dict
                DataGridView1.Rows.Add(no, item("pinjam_id").ToString, item("anggota_id").ToString, item("buku_id").ToString,
                                       item("status").ToString, item("lama_pinjam").ToString, item("tgl_pinjam").ToString, item("tgl_balik").ToString)
                no = no + 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try
    End Sub


    Private Sub simpanapi()
        Dim uriString As String = "http://localhost/uts-perpus-ci/index.php/api/PostDataPeminjaman" & txt_id_pinjam.Text.Trim & "/" & txt_pinjam_id.Text.Trim & "/" & txt_anggota_id.Text.Trim & "/" & txt_buku_id.Text.Trim & "/" & cmb_status.Text.Trim & "/" & txt_tgl_pinjam.Text.Trim & "/" & txt_lama_pinjam.Text.Trim & "/" & txt_tgl_balik.Text.Trim & "/" & txt_tgl_kembali.Text.Trim & "/"
        Dim uri As New Uri(uriString)
        Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
        request.Method = "POST"
        Dim response As HttpWebResponse = request.GetResponse()
        Dim read = New StreamReader(response.GetResponseStream())
        Dim raw As String = read.ReadToEnd()
        Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
    End Sub

    Private Sub updateapi()
        Dim uriString As String = "http://localhost/uts-perpus-ci/index.php/api/PutDataPeminjaman" & txt_pinjam_id.Text.Trim & "/" & txt_anggota_id.Text.Trim & "/" & txt_buku_id.Text.Trim & "/" & cmb_status.Text.Trim & "/" & txt_tgl_pinjam.Text.Trim & "/" & txt_lama_pinjam.Text.Trim & "/" & txt_tgl_balik.Text.Trim & "/"
        Dim uri As New Uri(uriString)
        Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
        request.Method = "PUT"
        Dim response As HttpWebResponse = request.GetResponse()
        Dim read = New StreamReader(response.GetResponseStream())
        Dim raw As String = read.ReadToEnd()
        Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
    End Sub

    Private Sub deleteapi()
        Dim uriString As String = "http://localhost/uts-perpus-ci/index.php/api/DeleteDataPeminjaman" & txt_pinjam_id.Text.Trim & "/"
        Dim uri As New Uri(uriString)
        Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
        request.Method = "DELETE"
        Dim response As HttpWebResponse = request.GetResponse()
        Dim read = New StreamReader(response.GetResponseStream())
        Dim raw As String = read.ReadToEnd()
        Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
    End Sub


    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Try
            buka()
            Dim a As String
            a = "INSERT INTO tbl_pinjam VALUES('" & txt_id_pinjam.Text & "','" & txt_pinjam_id.Text & "','" & txt_anggota_id.Text & "', '" & txt_buku_id.Text & "',
				 '" & cmb_status.Text & "', '" & txt_tgl_pinjam.Text & "', '" & txt_lama_pinjam.Text & "', '" & txt_tgl_balik.Text & "', '" & txt_tgl_kembali.Text & "')"
            con.Execute(a)

            simpanapi()

            MsgBox("Peminjaman Sukses", MsgBoxStyle.Information, "Pemberitahuan")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try

        txt_buku_id.Text = ""
        txt_pinjam_id.Text = ""
        txt_anggota_id.Text = ""
        cmb_status.Text = ""
        txt_tgl_pinjam.Text = ""
        txt_lama_pinjam.Text = ""
        txt_tgl_balik.Text = ""

    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        txt_buku_id.Text = ""
        txt_pinjam_id.Text = ""
        txt_anggota_id.Text = ""
        cmb_status.Text = ""
        txt_tgl_pinjam.Text = ""
        txt_lama_pinjam.Text = ""
        txt_tgl_balik.Text = ""

    End Sub

    Private Sub FormPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim no As Integer
            DataGridView1.Rows.Clear()
            no = 1
            Dim uriString As String = "http://localhost/uts-perpus-ci/index.php/api/GetDataPeminjaman" & txt_search.Text.Trim
            Dim uri As New Uri(uriString)
            Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse()
            Dim read = New StreamReader(response.GetResponseStream())
            Dim raw As String = read.ReadToEnd()
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
            For Each item As Object In dict
                DataGridView1.Rows.Add(no, item("pinjam_id").ToString, item("anggota_id").ToString, item("buku_id").ToString,
                                       item("status").ToString, item("lama_pinjam").ToString, item("tgl_pinjam").ToString, item("tgl_balik").ToString)
                no = no + 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try

        lbl_otomatis.Enabled = False
        txt_id_pinjam.Enabled = False
        txt_tgl_kembali.Enabled = False

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        id = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        txt_pinjam_id.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        txt_anggota_id.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        txt_buku_id.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        cmb_status.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        txt_lama_pinjam.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        txt_tgl_pinjam.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        txt_tgl_balik.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            buka()
            Dim b As String
            b = "DELETE FROM tbl_pinjam WHERE pinjam_id = '" & txt_pinjam_id.Text & "'"
            con.Execute(b)

            deleteapi()

            MsgBox("Data Peminjaman Berhasil Dihapus", MsgBoxStyle.Information, "Pemberitahuan")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try

        caripeminjaman()

        txt_buku_id.Text = ""
        txt_pinjam_id.Text = ""
        txt_anggota_id.Text = ""
        cmb_status.Text = ""
        txt_tgl_pinjam.Text = ""
        txt_lama_pinjam.Text = ""
        txt_tgl_balik.Text = ""

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs)
        Try
            buka()
            Dim c As String
            c = "UPDATE tbl_pinjam SET kd_anggota ='" & txt_anggota_id.Text & "', kd_buku = '" & txt_buku_id.Text & "',
				jumlah_pinjam='" & txt_lama_pinjam.Text & "', tanggal_pinjam='" & txt_tgl_pinjam.Text & "'
				WHERE kd_peminjaman ='" & txt_pinjam_id.Text & "'"
            con.Execute(c)

            updateapi()

            MsgBox("Data Peminjaman Berhasil Diupdate", MsgBoxStyle.Information, "Pemberitahuan")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try

        caripeminjaman()

        txt_buku_id.Text = ""
        txt_pinjam_id.Text = ""
        txt_anggota_id.Text = ""
        cmb_status.Text = ""
        txt_tgl_pinjam.Text = ""
        txt_lama_pinjam.Text = ""
        txt_tgl_balik.Text = ""

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        ' Code untuk tampil data
        Dim no As Integer
        Me.DataGridView1.Rows.Clear()
        buka()
        rec.Open("Select * from tbl_pinjam where pinjam_id like '%" & txt_search.Text & "%' order by pinjam_id", con, 3, 2)
        no = 1
        Do While Not rec.EOF

            Me.DataGridView1.Rows.Add(no, rec.Fields.Item("pinjam_id").Value, rec.Fields.Item("anggota_id").Value, rec.Fields("buku_id").Value,
                                      rec.Fields.Item("status").Value, rec.Fields.Item("lama_pinjam").Value, rec.Fields.Item("tgl_pinjam").Value, rec.Fields.Item("tgl_balik").Value)
            rec.MoveNext()
            no = no + 1
        Loop
        tutup()
    End Sub
End Class