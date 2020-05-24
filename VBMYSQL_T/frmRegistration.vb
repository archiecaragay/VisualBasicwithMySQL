Imports MySql.Data.MySqlClient

Public Class frmRegistration
    Dim vGender As String

    Private Sub radMale_CheckedChanged(sender As Object, e As EventArgs) Handles radMale.CheckedChanged
        vGender = "M"
    End Sub

    Private Sub radFemale_CheckedChanged(sender As Object, e As EventArgs) Handles radFemale.CheckedChanged
        vGender = "F"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
            'dtpBirthdate.CustomFormat = "yyyy-MM-dd"

            Using con As New MySqlConnection(strConnect)
                con.Open()
                Using cmd As New MySqlCommand("INSERT INTO testTable( first, middle, last, address, gender, birthdate) VALUES(@C1, @C2, @C3, @C4, @C5, @C6)", con)
                    With cmd.Parameters
                        .AddWithValue("@C1", txtFirst.Text)
                        .AddWithValue("@C2", txtMiddle.Text)
                        .AddWithValue("@C3", txtLast.Text)
                        .AddWithValue("@C4", txtAddress.Text)
                        .AddWithValue("@C5", vGender)
                        .AddWithValue("@C6", dtpBirthdate.Value.Date)
                        cmd.ExecuteNonQuery()
                    End With
                End Using
            End Using

            MsgBox("Record Added")

            ResetFields()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub ResetFields()
        txtFirst.Clear()
        txtMiddle.Clear()
        txtLast.Clear()
        radMale.Checked = False
        radFemale.Checked = False
        txtAddress.Clear()
    End Sub

    Private Sub btnResetFields_Click(sender As Object, e As EventArgs) Handles btnResetFields.Click
        ResetFields()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenCon()
        Try
            Dim vStr As String
            vStr = "SELECT * FROM testTable"
            Dim dtAdapter As New MySqlDataAdapter(vStr, con)
            Dim ds As DataSet = New DataSet
            dtAdapter.Fill(ds, "testTable")
            DataGridView1.DataSource = ds.Tables("testTable")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub
End Class
