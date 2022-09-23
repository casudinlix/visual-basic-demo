Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Module koneksi
    Public comSQL As New SqlClient.SqlCommand
    Public sql As String
    Public conn As New SqlConnection
    Public Ds As DataSet
    Public Da As SqlDataAdapter
    Public str As String = "Data Source=LAPTOP-SIS24U9C;Initial Catalog=latihan;Integrated Security=True"

    Public Sub bukakoneksi()
        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = str

            Try
                conn.Open()
                MsgBox("Koneksi Berhasil")
            Catch ex As Exception
                MsgBox("Koneksi Gagal: " & ex.ToString)
            End Try

        End If
    End Sub

    Public Sub tutupkoneksi()
        If conn.State = ConnectionState.Open Then

            Try
                conn.Close()
            Catch ex As Exception
                MsgBox("Gagal menutup koneksi: " & ex.ToString)
            End Try

        End If
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
    ' untuk reset form
    Public Sub ClearTextBoxes(frm As Form)

        For Each Control In frm.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control

    End Sub
End Module
