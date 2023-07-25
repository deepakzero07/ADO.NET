Imports System
Imports System.Data.SqlClient
Module Program
    Sub Main(args As String())



        Dim con As SqlConnection = New SqlConnection()

        con.ConnectionString = "Data Source=CAN-5951-22; Initial Catalog=studentdb; Integrated Security=true"

        Try
            con.Open()

            For i As Integer = 1 To 2
                Dim studid As Integer
                Dim name As String
                Dim dept As String
                Dim percentage As Decimal
                Dim year As Integer

                Console.WriteLine("Enter Studentid " & i & ":")
                studid = Convert.ToInt32(Console.ReadLine())

                Console.WriteLine("Enter Student name " & i & ":")
                name = Console.ReadLine()

                Console.WriteLine("Enter Student dept " & i & ":")
                dept = Console.ReadLine()

                Console.WriteLine("Enter Percentage " & i & ":")
                percentage = Convert.ToDecimal(Console.ReadLine())

                Console.WriteLine("Enter year " & i & ":")
                year = Convert.ToInt32(Console.ReadLine())

                ' Dim cmd2 As SqlCommand = New SqlCommand("CREATE TABLE studentexample1 (studid INT, name VARCHAR(20),dept VARCHAR(20), percentage FLOAT,year int)", con)

                Dim insertQuery As String = "INSERT INTO studentexample1 (studid, name, dept, percentage, year) VALUES (" & studid & ", '" & name & "', '" & dept & "', " & percentage & ", " & year & ")"
                Dim cmd As SqlCommand = New SqlCommand(insertQuery, con)
                ' cmd2.ExecuteNonQuery()
                cmd.ExecuteNonQuery()

            Next

            Console.WriteLine("Data updated")
            Console.WriteLine("table created")

            Dim selectQuery As String = "SELECT * FROM studentexample1"
            Dim selectCmd As SqlCommand = New SqlCommand(selectQuery, con)

            Dim reader As SqlDataReader = selectCmd.ExecuteReader()

            While reader.Read()
                Console.WriteLine("ID : {0}, Name: {1}, Dept: {2}, Percentage: {3}, Year: {4}", reader("studid"), reader("name"), reader("dept"), reader("percentage"), reader("year"))
            End While

        Catch ex As Exception
            Console.WriteLine(ex)
        Finally
            con.Close()
        End Try
    End Sub













End Module
