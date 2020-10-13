Imports System.Configuration
Imports BL
Imports Entities

Module Module1

    Sub Main()
        user()
        'Birds()
    End Sub



    Sub user()

        Dim name As String = ConfigurationManager.AppSettings("Name")

        Try
            Console.WriteLine("Academka")

            Dim user As New User("Yonatan", 29)


            Console.WriteLine(user) ' Taster.User
            Console.WriteLine(user.ToString()) ' Taster.User
            Dim v1 = Console.ReadLine()

            Console.WriteLine(v1)

            Dim users As List(Of User)
            Dim orders As List(Of Order)

            Using manager As New UserManager
                Try

                    users = manager.GetAll()

                    For Each user In users
                        Console.WriteLine(user)
                    Next

                Catch ex As Exception

                End Try

            End Using





        Catch ex As Exception
            Console.WriteLine(ex.Message)

            Console.ReadLine()
        End Try


    End Sub

    Sub Birds()

        Console.WriteLine("Academka")

        Dim user As New User("Yonatan", 29)


        Console.WriteLine(user) ' Taster.User
        Console.WriteLine(user.ToString()) ' Taster.User
        Dim v1 = Console.ReadLine()

        Console.WriteLine(v1)


    End Sub

End Module
