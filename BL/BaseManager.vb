Imports System.Configuration

Public Class BaseManager




    Public Function Logger(source As String, type As String, value As String, Optional pointer As String = Nothing) As Integer

        ' 
        Dim isLog = ConfigurationManager.AppSettings("isLog")
        If isLog = "true" Then


            Console.WriteLine("*************************")
            Console.WriteLine("ERROR: " + value)
            Console.WriteLine("*************************")
            Console.ReadLine()
        End If


        Return 0
    End Function

End Class
