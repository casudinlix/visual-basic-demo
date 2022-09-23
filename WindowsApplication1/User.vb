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
        'Validasi
        If name = "" Or email = "" Then
            MsgBox("Kolom Tidak Boleh Kosong", MsgBoxStyle.Critical, "Error")
            'untuk stop 
            Exit Sub
        End If
        bukakoneksi()
        sql = "INSERT INTO users (nama,email) VALUES (" & "'" & name & "'," & "'" & email & "')"
        comSQL = New SqlCommand(sql, conn)
        Try
            comSQL.ExecuteNonQuery()
            MsgBox("simpan berhasil")
            Call loaddata()


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
    Public Sub loaddata()
        Call bukakoneksi()
        Dim sql = "SELECT * FROM users"
        Da = New SqlDataAdapter(sql, conn)
        Ds = New DataSet()
        Ds.Clear()
        Da.Fill(Ds, "users") 'Nama tabel
        DataGridView1.DataSource = (Ds.Tables("users"))

    End Sub
    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim id = textId.Text
        Dim name = textName.Text
        Dim email = textEmail.Text
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        textId.Text = row.Cells(0).Value.ToString
        textId.ReadOnly = True
        textName.Text = row.Cells(1).Value.ToString
        textEmail.Text = row.Cells(2).Value.ToString

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        'MsgBox("OOOOO")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim id = textId.Text
        Dim name = textName.Text
        Dim email = textEmail.Text
        bukakoneksi()
        'sql = "UPDATE users SET nama=" & "'" & name & "',email=" & "'" & email & "' WHERE id=" & "'" & id & "'"
        sql = "Update users set nama='" & name & "', email='" & email & "' WHERE id='" & id & "'"

        comSQL = New SqlCommand(sql, conn)
        Try
            comSQL.ExecuteNonQuery()
            MsgBox("berhasil Edit")
            Call loaddata()


            Me.Refresh()
            Call ClearTextBoxes(Me)
        Catch ex As Exception
            MsgBox("simpan gagal: " & ex.ToString)

        End Try
        tutupkoneksi()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bukakoneksi()
        Dim id = textId.Text

        If MsgBox("Apakah Anda Yakin?", MsgBoxStyle.YesNoCancel, "Peringatan") = MsgBoxResult.Yes Then
            sql = "DELETE users   WHERE id='" & id & "'"

            comSQL = New SqlCommand(sql, conn)
            Try
                comSQL.ExecuteNonQuery()
                MsgBox("berhasil Hapus")
                Call loaddata()


                Me.Refresh()
                Call ClearTextBoxes(Me)
                textId.ReadOnly = False
            Catch ex As Exception
                MsgBox("simpan gagal: " & ex.ToString)

            End Try
            tutupkoneksi()
        Else
            Me.Refresh()
            Call ClearTextBoxes(Me)
        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim search = keyword.Text
        Call bukakoneksi()
        Dim sql = "SELECT * FROM users WHERE nama LIKE '%" & search & "%' OR email = '%" & search & "%' "
        Da = New SqlDataAdapter(sql, conn)
        Ds = New DataSet()
        Ds.Clear()
        Da.Fill(Ds, "users") 'Nama tabel
        DataGridView1.DataSource = (Ds.Tables("users"))

    End Sub

    Public Sub filterData(key As Form)

    End Sub
End Class