Imports Entities
Imports Tester

Public Class OrderManager
    Implements IDisposable

    '
    ' Summary:
    '     Writes the specified string value, followed by the current line terminator, to
    '     the standard output stream.
    '
    Public Function GetAll() As List(Of Order)


        Dim list As New List(Of Order) From
            {
            New Order("Yonatan", 29),
            New Order("Harel", 31),
            New Order("Maayan", 3)
            }

        Return list




    End Function




    Public Sub Dispose() Implements IDisposable.Dispose

        ' GC


    End Sub


End Class
