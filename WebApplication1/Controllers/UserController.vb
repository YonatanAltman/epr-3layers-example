Imports System.Net
Imports System.Web.Http
Imports BL
Imports Entities

Namespace Controllers
    Public Class UserController
        Inherits ApiController

        ' GET: api/User
        Public Function GetValues() As IEnumerable(Of User)

            Dim users
            Try

                Using manager As New UserManager

                    users = manager.GetAll()

                End Using
            Catch ex As Exception

            End Try

            Return users

        End Function

        ' GET: api/User/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/User
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/User/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/User/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace