Public Class Form1
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Try
            Using con = DbHelper.GetConnection()
                con.Open()
                MessageBox.Show("Connection Successful ✅")
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
