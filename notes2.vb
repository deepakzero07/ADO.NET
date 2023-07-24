Imports System
Imports System.Data.SqlClient
Module Program
    Sub Main(args As String())

        Dim empid As Integer
        Dim name As String
        Dim salary As Double

        Console.WriteLine("Enter employeeid")
        empid = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter employee name")
        name = Console.ReadLine()
        Console.WriteLine("Enter employee Salary")
        salary = Convert.ToDouble(Console.ReadLine())



        Dim con As SqlConnection = New SqlConnection()

        con.ConnectionString = "Data Source=CAN-5951-22; Initial Catalog=srf; Integrated Security=true"

        'Dim cmd As SqlCommand = New SqlCommand("CREATE TABLE employADxample (empid INT, empname VARCHAR(20), empsalary FLOAT)", con)
        'Dim query = "INSERT INTO employADxample  VALUES(" & empid & " , '" & name & "'," & salary & ")"
        'Dim query = "update employADxample set empname = '" & name & "' where empid=" & empid
        Dim query = "delete from employADxample where empid=" & empid
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        Try
                con.Open()
                cmd.ExecuteNonQuery()
            Console.WriteLine("Data updated")
            query = "select * from employADxample"
            cmd = New SqlCommand(query, con)

            Dim reader As SqlDataReader = cmd.ExecuteReader

            While reader.Read
                Console.WriteLine("ID : {0} , name : {1} , salary : {2}", reader("empid"), reader("empname"), reader("empsalary"))
            End While

        Catch ex As Exception
                Console.WriteLine(ex)
            Finally
                con.Close()
            End Try
        End Sub
    End Module



