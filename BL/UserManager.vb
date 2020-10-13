Imports DAL
Imports Entities
Imports Tester

Public Class UserManager
    Inherits BaseManager
    Implements IDisposable


    '
    ' Summary:
    '     Writes the specified string value, followed by the current line terminator, to
    '     the standard output stream.
    '
    Public Function GetAll() As List(Of User)

        Try



            Dim list As New List(Of User) From
            {
            New User("Yonatan", 29),
            New User("Harel", 31),
            New User("Maayan", 3)
            }
            Return list
        Catch ex As Exception

            Logger("User manager", "error", ex.Message, "User GetAll")
            'Throw ex
        End Try

        Return Nothing





    End Function


    Public Sub Dispose() Implements IDisposable.Dispose

        ' GC


    End Sub


End Class
