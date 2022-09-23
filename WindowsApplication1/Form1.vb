Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Form1
    Private Sub USERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USERToolStripMenuItem.Click
        Dim Form = New User()
        Form.MdiParent = Me
        Form.Show()

    End Sub

    Private Sub KELUARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KELUARToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call bukakoneksi()

    End Sub


End Class
