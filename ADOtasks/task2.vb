Imports System
Imports System.Data.SqlClient
Module Program
    Sub Main(args As String())


        task2()

    End Sub
    Sub task2()
            Dim connectionString As String = "Data Source=CAN-5951-22;Initial Catalog=studentdb;Integrated Security=true;"

            Using connection As New SqlConnection(connectionString)
                Dim query As String = "SELECT * FROM readstudent"

                Try
                    connection.Open()
                    Using command As New SqlCommand(query, connection)
                        Using reader As SqlDataReader = command.ExecuteReader()
                            Console.WriteLine("readstudent:")
                            Console.WriteLine("ID" & vbTab & "Name" & vbTab & "dept" & vbTab & "percentage" & vbTab & "year")

                            While reader.Read()
                                Dim stuID As Integer = reader.GetInt32(0)
                                Dim Name As String = reader.GetString(1)
                                Dim dept As String = reader.GetString(2)
                            Dim percentage As Double = reader.GetDouble(3)
                            Dim year As Integer = reader.GetInt32(4)

                            Console.WriteLine($"{stuID}" & vbTab & $"{Name}" & vbTab & $"{dept}" & vbTab & $"{percentage}" & vbTab & $"{year}")
                            End While
                        End Using
                    End Using
                Catch ex As Exception
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using

        Console.ReadKey()
        End Sub


End Module
