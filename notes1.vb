Imports System
Imports System.Data.SqlClient
Module Program
    Sub Main(args As String())

        'Dim empid As Integer
        'Dim name As String
        'Dim salary As Double

        'Console.WriteLine("Enter employeeid")
        'empid = Convert.ToInt32(Console.ReadLine())
        'Console.WriteLine("Enter employee name")
        'name = Console.ReadLine()
        'Console.WriteLine("Enter employee Salary")
        'salary = Convert.ToDouble(Console.ReadLine())

        Dim con As SqlConnection = New SqlConnection()

            ' Corrected connection string
            con.ConnectionString = "Data Source=CAN-5951-22; Initial Catalog=srf; Integrated Security=true"

            Dim cmd As SqlCommand = New SqlCommand("CREATE TABLE employeADOexample (empid INT, empname VARCHAR(20), empsalary FLOAT)", con)

            Try
                con.Open()
                cmd.ExecuteNonQuery()
                Console.WriteLine("Table is created")
            Catch ex As Exception
                Console.WriteLine(ex)
            Finally
                con.Close()
            End Try
        End Sub
    End Module



