Imports System.Net
Imports System.IO
Imports Nancy.Json

Public Class Form1
    Public id As String
    Private Sub caribuku()
        Try
            Dim no As Integer
            DataGridView1.Rows.Clear()
            no = 1
            Dim uriString As String = "http://localhost/uts-perpus-ci/index.php/api/GetDataBuku" & txt_search.Text.Trim
            Dim uri As New Uri(uriString)
            Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse()
            Dim read = New StreamReader(response.GetResponseStream())
            Dim raw As String = read.ReadToEnd()
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
            For Each item As Object In dict
                DataGridView1.Rows.Add(no, item("buku_id").ToString, item("id_kategori").ToString, item("title").ToString,
                                       item("penerbit").ToString, item("pengarang").ToString, item("jml").ToString)
                no = no + 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        caribuku()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim no As Integer
            DataGridView1.Rows.Clear()
            no = 1
            Dim uriString As String = "http://localhost/uts-perpus-ci/index.php/api/GetDataBuku" & txt_search.Text.Trim
            Dim uri As New Uri(uriString)
            Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse()
            Dim read = New StreamReader(response.GetResponseStream())
            Dim raw As String = read.ReadToEnd()
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
            For Each item As Object In dict
                DataGridView1.Rows.Add(no, item("buku_id").ToString, item("id_kategori").ToString, item("title").ToString,
                                       item("penerbit").ToString, item("pengarang").ToString, item("jml").ToString)
                no = no + 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try

    End Sub

    Private Sub btn_pinjam_Click(sender As Object, e As EventArgs) Handles btn_pinjam.Click
        FormPeminjaman.Show()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        ' Code untuk tampil data
        Dim no As Integer
        Me.DataGridView1.Rows.Clear()
        buka()
        rec.Open("Select * from tbl_buku where buku_id like '%" & txt_search.Text & "%' order by buku_id", con, 3, 2)
        no = 1
        Do While Not rec.EOF

            Me.DataGridView1.Rows.Add(no, rec.Fields.Item("buku_id").Value, rec.Fields.Item("id_kategori").Value, rec.Fields("title").Value,
                                      rec.Fields.Item("penerbit").Value, rec.Fields.Item("pengarang").Value, rec.Fields.Item("jml").Value)
            rec.MoveNext()
            no = no + 1
        Loop
        tutup()
    End Sub
End Class
