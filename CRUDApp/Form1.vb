Imports System.Data.SqlClient

Public Class frmMasterBarang

    Dim mStateData As Integer

    Private Sub frmMasterBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Viewmonitoring()
        Call ChangeState(0)
        Call DetailFill()

    End Sub

    Private Function ChangeState(mState As Integer)

        If mState = 0 Then
            txtKode.Enabled = False
            txtNama.Enabled = False
            NumHarga.Enabled = False

            btnADD.Enabled = True
            btnEDIT.Enabled = True
            btnDELETE.Enabled = True
            btnEXIT.Text = "EXIT"

            btnSave.Enabled = False

            Call DetailClear()

            mStateData = 0
        ElseIf mState = 1 Then
            btnADD.Enabled = False
            btnEDIT.Enabled = False
            btnDELETE.Enabled = False

            txtKode.Enabled = True
            txtNama.Enabled = True
            NumHarga.Enabled = True

            btnSave.Enabled = True

            btnEXIT.Text = "CANCEL"

            Call DetailClear()

            mStateData = 1
        ElseIf mState = 2 Then
            btnADD.Enabled = False
            btnEDIT.Enabled = False
            btnDELETE.Enabled = False

            txtKode.Enabled = False
            txtNama.Enabled = True
            NumHarga.Enabled = True

            btnSave.Enabled = True

            btnEXIT.Text = "CANCEL"

            mStateData = 2

        End If

    End Function

    Private Sub Viewmonitoring()
        Call Koneksi()

        jString = "SELECT * FROM Andri.dbo.tbBarang"
        Da = New SqlDataAdapter(jString, Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tbBarang")
        DataGridView1.DataSource = (Ds.Tables("tbBarang"))

    End Sub

    Private Sub DetailFill()

        txtKode.Text = DataGridView1.CurrentRow.Cells("KodeBarang").Value
        txtNama.Text = DataGridView1.CurrentRow.Cells("NamaBarang").Value
        NumHarga.Value = DataGridView1.CurrentRow.Cells("Harga").Value

    End Sub

    Private Sub DetailClear()
        txtKode.Text = ""
        txtNama.Text = ""
        NumHarga.Value = 0
    End Sub

    Private Sub btnEXIT_Click(sender As Object, e As EventArgs) Handles btnEXIT.Click
        If btnEXIT.Text = "CANCEL" Then
            Call DetailClear()
            Call ChangeState(0)
            Exit Sub
        End If

        Me.Close()
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Call ChangeState(1)
    End Sub

    Private Function DetailValidate() As Boolean
        Call Koneksi()


        DetailValidate = False

        If txtKode.Text = "" Then
            MsgBox("harap isi kode barang")
            Exit Function
        End If

        If txtNama.Text = "" Then
            MsgBox("harap isi nama barang")
            Exit Function
        End If

        jString = "SELECT * FROM Andri.dbo.tbBarang" & vbCrLf
        jString = jString & "WHERE KodeBarang = '" & txtKode.Text & "'" & vbCrLf
        If mStateData = 2 Then
            jString = jString & "AND Kodebarang != '" & DataGridView1.CurrentRow.Cells("KodeBarang").Value & "'"
        End If
        Cmd = New SqlCommand(jString, Conn)
        Using Rd = Cmd.ExecuteReader()
            While Rd.Read()
                If Rd.HasRows Then
                    MsgBox("Kode Barang sudah digunakan!")
                    Exit Function
                End If
            End While
        End Using

        DetailValidate = True

    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call Koneksi()

        If DetailValidate() = False Then Exit Sub

        If mStateData = 1 Then
            jString = "INSERT INTO Andri.dbo.tbBarang VALUES (" & vbCrLf
            jString = jString & "'" & txtKode.Text & "'" & vbCrLf
            jString = jString & ",'" & txtNama.Text & "'" & vbCrLf
            jString = jString & ",'" & NumHarga.Value & "'" & vbCrLf
            jString = jString & ")"
            Cmd = New SqlCommand(jString, Conn)
            Cmd.ExecuteNonQuery()

            MsgBox("berhasil")

        ElseIf mStateData = 2 Then

            jString = "UPDATE Andri.dbo.tbBarang SET" & vbCrLf
            jString = jString & "NamaBarang = '" & txtNama.Text & "'" & vbCrLf
            jString = jString & ",Harga = '" & NumHarga.Value & "'" & vbCrLf
            jString = jString & "WHERE KodeBarang = '" & DataGridView1.CurrentRow.Cells("KodeBarang").Value & "'"
            Cmd = New SqlCommand(jString, Conn)
            Cmd.ExecuteNonQuery()

            MsgBox("berhasil")
        End If

        Call ChangeState(0)
        Call DetailFill()
        Call Viewmonitoring()

    End Sub

    Private Sub btnEDIT_Click(sender As Object, e As EventArgs) Handles btnEDIT.Click
        Call ChangeState(2)
    End Sub

    Private Sub btnDELETE_Click(sender As Object, e As EventArgs) Handles btnDELETE.Click
        Call Koneksi()

        Dim pHapus As String = MsgBox("Hapus data ini?", vbYesNo)
        If pHapus = vbYes Then

            jString = "DELETE FROM Andri.dbo.tbBarang Where KodeBarang = '" & DataGridView1.CurrentRow.Cells("KodeBarang").Value & "'"
            Cmd = New SqlCommand(jString, Conn)
            Cmd.ExecuteNonQuery()

            Call DetailClear()
            Call DetailFill()
            Call Viewmonitoring()
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Call DetailFill()
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Call DetailFill()
    End Sub
End Class
