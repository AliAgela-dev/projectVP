Imports System.Data.SqlClient
Imports System.Reflection

Public Class SharedFunctions
    Public db As New SqlConnection("Server=LAPTOP-RCJITDS4\SQLEXPRESS;Database=warehouse; Trusted_Connection=True;")

    Public Function FillList(ByVal comboboxZ As ComboBox,
    ByVal tableName As String, ByVal name As String,
    ByVal id As String, Optional ByVal condt As String = "")
        Try
            Dim sqlstr As String = "select * from  " & tableName & " " & condt
            Dim adp As New SqlClient.SqlDataAdapter(sqlstr, db)
            Dim ds As New DataSet
            adp.Fill(ds, sqlstr)
            Dim dtb As New DataTable
            dtb = ds.Tables(sqlstr)
            comboboxZ.DataSource = dtb
            comboboxZ.DisplayMember = name
            comboboxZ.ValueMember = id
        Catch ex As Exception
            ex.Message.ToString()
        End Try
    End Function
    Public Function DbOpreation(ByVal sql As String)
        If db.State = ConnectionState.Open Then db.Close()
        If db.State = ConnectionState.Closed Then db.Open()
        Dim sqlCmd As New SqlCommand(sql, db)
        Try
            sqlCmd.ExecuteNonQuery()
            MsgBox("*** تم التعديل على قاعدة البيانات ***", MsgBoxStyle.Information, "منظومة  شؤون الطلبة")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqlCmd.Dispose()
        If db.State = ConnectionState.Open Then db.Close()

    End Function

    Public Sub displayOnDataGrid(ByVal sql As String, ByVal DataGridViewXYZ As DataGridView)
        ' ********************************* TO DISPLAY ON DATA GRIDS **************************************************************
        Dim adp As New SqlDataAdapter(sql, db)
        Dim ds As New DataSet

        adp.Fill(ds, sql)
        Dim dtb As New DataTable

        dtb = ds.Tables(sql)
        DataGridViewXYZ.DataSource = dtb

    End Sub
    Function isLogedIn(ByVal sql) As Boolean
        If db.State = ConnectionState.Open Then db.Close()
        If db.State = ConnectionState.Closed Then db.Open()

        Dim user As New SqlDataAdapter(sql, db)
        Dim ds As New DataSet

        user.Fill(ds, sql)
        Dim users As New DataTable

        users = ds.Tables(sql)
        If users.Rows.Count = 1 Then
            Return True

        End If
        Return False
    End Function

End Class
