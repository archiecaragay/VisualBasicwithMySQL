
Public Class frmConnection

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click

        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName > "" Then
            Me.txtLocalData.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub frmConnection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LocaldbDataSet.tbl_Application_Settings' table. You can move, or remove it, as needed.
        Me.Tbl_Application_SettingsTableAdapter.Fill(Me.LocaldbDataSet.tbl_Application_Settings)

    End Sub

    Private Sub lstConnections_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstConnections.SelectedIndexChanged

    End Sub
End Class