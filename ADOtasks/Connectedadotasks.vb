Imports System
Imports System.Data
Imports System.Data.SqlClient
Module Program
    Sub Main(args As String())


        'task2()
        'fourth()
        'fifth()
        third()






    End Sub
    '    Dim con As SqlConnection = New SqlConnection()

    '    con.ConnectionString = "Data Source=CAN-5951-22; Initial Catalog=studentdb; Integrated Security=true"

    '    Try
    '        con.Open()

    '        For i As Integer = 1 To 2
    '            Dim studid As Integer
    '            Dim name As String
    '            Dim dept As String
    '            Dim percentage As Decimal
    '            Dim year As Integer

    '            Console.WriteLine("Enter Studentid " & i & ":")
    '            studid = Convert.ToInt32(Console.ReadLine())

    '            Console.WriteLine("Enter Student name " & i & ":")
    '            name = Console.ReadLine()

    '            Console.WriteLine("Enter Student dept " & i & ":")
    '            dept = Console.ReadLine()

    '            Console.WriteLine("Enter Percentage " & i & ":")
    '            percentage = Convert.ToDecimal(Console.ReadLine())

    '            Console.WriteLine("Enter year " & i & ":")
    '            year = Convert.ToInt32(Console.ReadLine())

    '            ' Dim cmd2 As SqlCommand = New SqlCommand("CREATE TABLE studentexample1 (studid INT, name VARCHAR(20),dept VARCHAR(20), percentage FLOAT,year int)", con)

    '            Dim insertQuery As String = "INSERT INTO studentexample1 (studid, name, dept, percentage, year) VALUES (" & studid & ", '" & name & "', '" & dept & "', " & percentage & ", " & year & ")"
    '            Dim cmd As SqlCommand = New SqlCommand(insertQuery, con)
    '            ' cmd2.ExecuteNonQuery()
    '            cmd.ExecuteNonQuery()

    '        Next

    '        Console.WriteLine("Data updated")
    '        Console.WriteLine("table created")

    '        Dim selectQuery As String = "SELECT * FROM studentexample1"
    '        Dim selectCmd As SqlCommand = New SqlCommand(selectQuery, con)

    '        Dim reader As SqlDataReader = selectCmd.ExecuteReader()

    '        While reader.Read()
    '            Console.WriteLine("ID : {0}, Name: {1}, Dept: {2}, Percentage: {3}, Year: {4}", reader("studid"), reader("name"), reader("dept"), reader("percentage"), reader("year"))
    '        End While

    '    Catch ex As Exception
    '        Console.WriteLine(ex)
    '    Finally
    '        con.Close()
    '    End Try
    'End Sub


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

                            Console.WriteLine($"{stuID}" & vbTab & $"{Name}" & vbTab & $"{dept}" & vbTab & $"{percentage}" & vbTab & vbTab & $"{year}")
                        End While
                    End Using
                End Using
            Catch ex As Exception
                Console.WriteLine("Error: " & ex.Message)
            End Try
        End Using

        Console.ReadKey()
    End Sub








    Sub fourth()



        Dim empid As Integer
        Dim name As String
        Dim salary As Double

        'Console.WriteLine("Enter employeeid")
        'empid = Convert.ToInt32(Console.ReadLine())
        'Console.WriteLine("Enter employee name")
        'name = Console.ReadLine()
        'Console.WriteLine("Enter employee Salary")
        'salary = Convert.ToDouble(Console.ReadLine())

        Dim con As SqlConnection = New SqlConnection()
        con.ConnectionString = "Data Source=CAN-5951-22; Initial Catalog=studentdb; Integrated Security=true"

        'Dim query As String = ""

        ' Uncomment one of the following queries based on the operation you want to perform

        ' 1. Create the table (if not already created)
        ' query = "CREATE TABLE sortemployee (empid INT, empname VARCHAR(20), empsalary FLOAT)"

        ' 2. Insert a new row into the table
        'query = "INSERT INTO sortemployee VALUES(" & empid & ", '" & name & "', " & salary & ")"

        ' 3. Update the employee name
        ' query = "UPDATE employADxample SET empname = '" & name & "' WHERE empid = " & empid

        ' 4. Delete a row from the table
        'query = "DELETE FROM employADxample WHERE empid = " & empid

        'Dim cmd As SqlCommand = New SqlCommand(query, con)

        Try
            con.Open()
            'cmd.ExecuteNonQuery()
            Console.WriteLine("Data updated")

            ' Retrieve data in ascending order based on empid
            Dim query As String = "SELECT * FROM sortemployee ORDER BY empid ASC"
            Dim cmd As SqlCommand = New SqlCommand(query, con)

            Dim reader As SqlDataReader = cmd.ExecuteReader

            While reader.Read
                Console.WriteLine("ID : {0}, name : {1}, salary : {2}", reader("empid"), reader("empname"), reader("empsalary"))
            End While

        Catch ex As Exception
            Console.WriteLine(ex)
        Finally
            con.Close()
        End Try
    End Sub






    Sub fifth()




        Dim con As SqlConnection = New SqlConnection()
        con.ConnectionString = "Data Source=CAN-5951-22; Initial Catalog=studentdb; Integrated Security=true"

        Try
            con.Open()
            'cmd.ExecuteNonQuery()
            Console.WriteLine("Data deleted")

            Dim query As String = "delete FROM fifthtask where taskid=2"


            Dim cmd As SqlCommand = New SqlCommand(query, con)

            Dim reader As SqlDataReader = cmd.ExecuteReader



        Catch ex As Exception
            Console.WriteLine(ex)
        Finally
            con.Close()
        End Try
    End Sub


    Sub third()



        Dim connectionString As String = "Data Source=CAN-5951-22; Initial Catalog=studentdb; Integrated Security=true"
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        connection.Open()

        ' Dim createTableQuery As String = "CREATE TABLE common_data (sturollno INT, name VARCHAR(50), attendance_percentage FLOAT)"
        'Dim createTableCommand As SqlCommand = New SqlCommand(createTableQuery, connection)
        'createTableCommand.ExecuteNonQuery()

        Dim compareQuery As String = "INSERT INTO common_data (sturollno, name, attendance_percentage) " &
                                     "SELECT sd.sturollno, sd.name, sd.attendance_percentage " &
                                     "FROM student_details sd " &
                                     "INNER JOIN sport_details sd2 ON sd.sturollno = sd2.collegeregno AND sd.name = sd2.name"
        Dim compareCommand As SqlCommand = New SqlCommand(compareQuery, connection)
        compareCommand.ExecuteNonQuery()

        connection.Close()
    End Sub



End Module







