Imports System.Windows.Forms

Public Class MDMain

    Private Sub mnuMasterBarang_Click(sender As Object, e As EventArgs) Handles mnuMasterBarang.Click
        frmMasterBarang.MdiParent = Me
        frmMasterBarang.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub mnuBarangMasuk_Click(sender As Object, e As EventArgs) Handles mnuBarangMasuk.Click
        frmBarangMasuk.MdiParent = Me
        frmBarangMasuk.Show()
    End Sub
End Class
