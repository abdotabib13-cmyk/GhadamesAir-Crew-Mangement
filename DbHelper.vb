Imports System.Data.OleDb

Public Class DbHelper

    Private Shared ReadOnly conStr As String =
        "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\GhadamesSystem\Ghadames.accdb;"

    Public Shared Function GetConnection() As OleDbConnection
        Return New OleDbConnection(conStr)
    End Function

    Public Shared Function ExecuteQuery(sql As String, Optional params As List(Of OleDbParameter) = Nothing) As DataTable
        Dim dt As New DataTable
        Using con As OleDbConnection = GetConnection()
            Using cmd As New OleDbCommand(sql, con)
                If params IsNot Nothing Then cmd.Parameters.AddRange(params.ToArray())
                Using da As New OleDbDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Shared Sub ExecuteNonQuery(sql As String, Optional params As List(Of OleDbParameter) = Nothing)
        Using con As OleDbConnection = GetConnection()
            Using cmd As New OleDbCommand(sql, con)
                If params IsNot Nothing Then cmd.Parameters.AddRange(params.ToArray())
                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class
