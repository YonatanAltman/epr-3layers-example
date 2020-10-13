Public Class User
    Property Name As String
    Property Age As Integer

    Sub New(name As String, age As Integer)

        Me.Name = name
        Me.Age = age


    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("Name :{0}  Age: {1}", Me.Name, Me.Age)
    End Function
End Class
