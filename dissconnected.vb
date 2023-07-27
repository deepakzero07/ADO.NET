Imports System
Imports System.Collections.Immutable
Imports System.ComponentModel.Design
Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Security.Principal

Module Program
    Sub Main(args As String())


        'task2()
        'fourth()
        'fifth()
        'third()


        sixthselection()
        SeventhInsertion()
        '  updationadapter()




        'demo2()
        'seventhdeletion()
        'demo3()
        'demo4()
        ''grpbyexample()
        'workwitharrays()
        'linqlonethirty()
        ' grinding()
        '      colol()












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

            Dim query As String = "delete FROM fifthtask where taskid=3"


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


    Sub sixthselection()

        Dim conn As SqlConnection = New SqlConnection
        conn.ConnectionString = "Data Source=CAN-5951-22; Initial Catalog=studentdb; Integrated Security=true"
        Dim cmd As New SqlCommand()
        Dim adapter As SqlDataAdapter
        Dim ds As New DataSet
        cmd.Connection = conn
        cmd.CommandText = "select * from diconnected"
        adapter = New SqlDataAdapter(cmd)
        adapter.Fill(ds)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            Console.WriteLine("id:" & ds.Tables(0).Rows(i).ItemArray(0))
            Console.WriteLine("name:" & ds.Tables(0).Rows(i).ItemArray(1))
            Console.WriteLine()
        Next
    End Sub






    Sub seventhdeletion()
        Console.WriteLine("Enter Id no to Delete: ")
        Dim num = Convert.ToInt32(Console.ReadLine)
        Dim conn As SqlConnection = New SqlConnection
        conn.ConnectionString = "Data Source=CAN-5951-22; Initial Catalog=studentdb; Integrated Security=true"
        Dim cmd As New SqlCommand()
        Dim adapter As SqlDataAdapter
        Dim ds As New DataSet
        Dim cmd2 As SqlCommand = New SqlCommand("Select * from diconnected", conn)
        adapter = New SqlDataAdapter(cmd2)
        adapter.Fill(ds)
        Dim sqlan As SqlCommandBuilder = New SqlCommandBuilder(adapter)
        Console.WriteLine()
        Console.WriteLine("Before Delete")

        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                Console.Write(ds.Tables(0).Rows(i).Item(j) & " ")
            Next
            Console.WriteLine()
        Next
        For Each i In ds.Tables(0).Rows
            If i.itemarray(0) = num Then
                i.delete()
            End If
        Next
        adapter.Update(ds, ds.Tables(0).ToString())
        Console.WriteLine()
        Console.WriteLine("After Delete")

        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                Console.Write(ds.Tables(0).Rows(i).Item(j) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub



    Sub demo()
        Dim comon As List(Of String) = New List(Of String)
        comon.Add("deepak")
        comon.Add("sathish")
        comon.Add("prasanth")
        comon.Add("arnab")
        comon.Add("arun")
        comon.Add("ram")

        Dim result = From names In comon
                     Where names.Contains("k")
                     Select names


        For Each name In result
            Console.WriteLine(name)
        Next
    End Sub

    ''query synatax
    Sub demo2()
        Dim marks As Integer() = {1, 2, 3, 4, 5, 6, 7, 8}

        Dim result1 = From i In marks
                      Where i > 6
                      Select i


        For Each num In result1
            Console.WriteLine(num)
        Next


    End Sub


    Sub demo3()
        Dim marks As Integer() = {1, 2, 3, 4, 5, 6, 7, 8}


        Dim result1 As IEnumerable(Of Integer) = marks.Where(Function(i) i > 6).ToList()


        For Each num In result1
            Console.WriteLine(num)
        Next


    End Sub



    Sub demo4()
        Dim marks As Integer() = {1, 2, 3, 4, 5, 6, 7, 8, 9}

        Dim result1 = From i In marks
                      Where i > 6
                      Select i Order By i Descending



        For Each i In result1
            Console.WriteLine(i)
        Next


    End Sub


    Sub SeventhInsertion()
        Dim conn As SqlConnection = New SqlConnection()
        conn.ConnectionString = "Data Source=CAN-5951-22; Initial Catalog=studentdb; Integrated Security=true"

        Dim cmd2 As SqlCommand = New SqlCommand("SELECT * FROM diconnected", conn)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd2)
        Dim ds As New DataSet()

        adapter.Fill(ds)

        Console.WriteLine("Before Insertion:")
        PrintDataSet1(ds)

        ' Prompt for data to insert
        Console.WriteLine("Enter data to insert:")
        Console.Write("Column1: ")
        Dim col1 As Integer = Convert.ToInt32(Console.ReadLine())
        Console.Write("Column2: ")
        Dim col2 As String = Console.ReadLine()
        'Console.Write("Column3: ")
        'Dim col3 As String = Console.ReadLine()
        'Console.Write("Column4: ")
        'Dim col4 As String = Console.ReadLine()
        'Console.Write("Column5: ")
        'Dim col5 As String = Console.ReadLine()
        'Console.Write("Column6: ")
        'Dim col6 As String = Console.ReadLine()

        ' Create a new row and insert it into the dataset
        Dim newRow As DataRow = ds.Tables(0).NewRow()
        newRow.ItemArray = New Object() {col1, col2}
        ds.Tables(0).Rows.Add(newRow)

        ' Update the changes to the database
        Dim sqlan As SqlCommandBuilder = New SqlCommandBuilder(adapter)
        adapter.Update(ds, ds.Tables(0).ToString())

        ' Display the dataset after the insertion
        Console.WriteLine()
        Console.WriteLine("After Insertion:")
        PrintDataSet1(ds)
    End Sub

    Private Sub PrintDataSet1(ds As DataSet)
        For Each table As DataTable In ds.Tables
            For Each row As DataRow In table.Rows
                For Each item In row.ItemArray
                    Console.Write(item.ToString() & " ")
                Next
                Console.WriteLine()
            Next
        Next
    End Sub




    Sub grpbyexample()
        Dim employee As New List(Of Tuple(Of Integer, String))

        employee.Add(New Tuple(Of Integer, String)(111, "deepak"))
        employee.Add(New Tuple(Of Integer, String)(222, "prasanth"))
        employee.Add(New Tuple(Of Integer, String)(333, "benito"))
        employee.Add(New Tuple(Of Integer, String)(444, "sathish"))
        employee.Add(New Tuple(Of Integer, String)(555, "arnab"))

        Dim result = From i In employee
                     Group By i.Item1 Into
                         idgroup = Group


        For Each i In result
            Console.WriteLine(i.Item1)
            For Each j In i.idgroup
                Console.WriteLine("   1===  " & j.Item2)
            Next

        Next

    End Sub



    Sub workwitharrays()
        Dim mymarks() As Integer = {1, 2, 3, 4, 5, 8}
        Dim secondget As Integer = mymarks.Average

        ' Console.WriteLine(secondget)
        Dim avg As Integer = mymarks.Take(3).Average
        'Console.WriteLine(avg)

        Dim result = (From m In mymarks Order By m Descending).Take(3)

        For Each i In result
            Console.WriteLine(i)
        Next

    End Sub




    Sub linqlonethirty()


        Dim conn As SqlConnection = New SqlConnection
        conn.ConnectionString = "Data Source=CAN-5952-22; Initial Catalog-srf; Integrated Security=true"
        Dim cmd As New SqlCommand()
        Dim adapter As SqlDataAdapter
        Dim ds As New DataSet

        cmd.Connection = conn
        cmd.CommandText = "select * from student Academics"
        adapter = New SqlDataAdapter(cmd)
        adapter.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then

            Dim result = From i In ds.Tables(0)
                         Where i.Field(Of Double)("percentage") > 90
                         Select New With {.id = i.Field(Of Integer)("id"), .name = i.Field(Of String)("name"), .dept = i.Field(Of String)("dept"), .year = i.Field(Of Integer)("year"), .clgName = i.Field(Of String)("clgName"), .percentage = i.Field(Of Double)("percentage")}



            For Each i In result
                Console.WriteLine(" ID: {0} Name: {1} Dept: {2} year: {3} clgName: {4} percentage: {5}", i.id, i.name,
                i.dept, i.year, i.clgName, i.percentage)
            Next
        End If
    End Sub




    Sub grinding()
        Dim mymarks() As Integer = {1, 2, 3, 4, 5, 8}
        Dim secondget As Integer = mymarks.Average

        Dim avg As Integer = mymarks.Take(3).Average
        'Console.WriteLine(avg)

        Dim result = (From m In mymarks Order By m Descending).Take(3)

        For Each i In result
            'Console.WriteLine(i)
        Next


        ' Find the maximum value from the array
        'Dim maxVal As Integer = mymarks.Max()
        'Console.WriteLine("Maximum value in the array: " & maxVal)

        'Dim minval As Integer = mymarks.Min()
        'Console.WriteLine("Maximum value in the array: " & minval)


        'Dim sumval As Integer = mymarks.Sum()
        'Console.WriteLine("Maximum value in the array: " & sumval)


        'Dim countval As Integer = mymarks.Count()
        'Console.WriteLine("Maximum value in the array: " & countval)

        'Dim range As Integer = mymarks.Max() - mymarks.Min()
        'Console.WriteLine("Range of the array: " & range)



        ''elements above threshold
        ''Dim threshold As Integer = 4
        ''Dim aboveThreshold As IEnumerable(Of Integer) = mymarks.Where(Function(m) m > threshold)



        ''For Each mark In aboveThreshold
        ''    Console.WriteLine("Element above threshold: " & mark)
        ''Next


        ''all elements pasing the codition
        ''Dim allPassing As Boolean = mymarks.All(Function(m) m >= 1 And m <= 10)

        ''If allPassing Then
        ''    Console.WriteLine("All elements are within the valid range (1 to 10).")
        ''Else
        ''    Console.WriteLine("Some elements are out of the valid range.")
        ''End If


        'any elemenst failing the condition

        'Dim hasFailingGrade As Boolean = mymarks.Any(Function(m) m < 0)

        'If hasFailingGrade Then
        '    Console.WriteLine("There are failing grades in the array.")
        'Else
        '    Console.WriteLine("All grades are passing.")
        'End If

        'Dim moreMarks() As Integer = {10, 7, 6}
        'Dim combinedMarks() As Integer = mymarks.Concat(moreMarks).ToArray()

        'For Each mark In combinedMarks
        '    Console.WriteLine("Combined Mark: " & mark)
        'Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Dim indicesToInclude() As Integer = {1, 3, 4}
        Dim filteredMarks = indicesToInclude.Select(Function(i) mymarks(i))

        For Each mark In filteredMarks
            Console.WriteLine("Filtered Mark: " & mark)
        Next

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    End Sub



    Sub colol()

        Dim a As List(Of Integer) = New List(Of Integer)
        a.Add(1)
        a.Add(2)
        a.Add(3)
        a.Add(4)
        a.Add(5)




        Console.WriteLine(a.Max)
        Console.WriteLine(a.Min)




    End Sub






End Module





