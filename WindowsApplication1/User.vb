Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class User
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loaddata()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id = textId.Text
        Dim name = textName.Text
        Dim email = textEmail.Text
        bukakoneksi()
        sql = "INSERT INTO users (id,nama,email) VALUES (" & "'" & id & "'," & "'" & name & "'," & "'" & email & "')"
        comSQL = New SqlCommand(sql, conn)
        Try
            comSQL.ExecuteNonQuery()
            MsgBox("simpan berhasil")
            Call loaddata(Me)


            Me.Refresh()
            Call ClearTextBoxes(Me)
        Catch ex As Exception
            MsgBox("simpan gagal: " & ex.ToString)

        End Try
        tutupkoneksi()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub





End Class