Imports System.Runtime.Intrinsics.X86
Imports projectVP.SharedFunctions
Public Class main_form

    Public obj As New SharedFunctions

    Public Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click

        Dim ssn As String = emp_ssn.Text

        ' Validate fields
        If String.IsNullOrWhiteSpace(name_txt.Text) OrElse String.IsNullOrWhiteSpace(ssn) OrElse String.IsNullOrWhiteSpace(dob_txt.Text) OrElse String.IsNullOrWhiteSpace(dp_txt.Text) Then
            MsgBox("Please fill in all fields.", MsgBoxStyle.Critical, "Validation Error")
            Return
        End If

        ' Validate SSN length
        If ssn.Length <> 12 Then
            MsgBox("Employee SSN must be 12 digits.", MsgBoxStyle.Critical, "Validation Error")
            Return
        End If

        obj.DbOpreation("insert into employee ( employee_name,employee_ssn,employee_dob,employee_dp,profile_img) values('" & name_txt.Text & "','" & ssn & "','" & dob_txt.Text & "','" & dp_txt.Text & "' " & ",'" & profilePic.ImageLocation & "')")
        obj.displayOnDataGrid("select * from employee  ", emp_data_grid_view)
    End Sub
    Private Sub Main_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        obj.FillList(dp_txt, "departments", "dp_name", "id")
        obj.displayOnDataGrid("select * from employee  ", emp_data_grid_view)


    End Sub

    Public Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Dim stNo As String = emp_ssn.Text
        obj.DbOpreation("delete from employee where  id = " & id_txt.Text)
        obj.displayOnDataGrid("select * from employee  ", emp_data_grid_view)

    End Sub
    Private Sub edit_btn_Click(sender As Object, e As EventArgs) Handles edit_btn.Click
        Dim ssn As String = emp_ssn.Text
        ' Validate fields
        If String.IsNullOrWhiteSpace(name_txt.Text) OrElse String.IsNullOrWhiteSpace(ssn) OrElse String.IsNullOrWhiteSpace(dob_txt.Text) OrElse String.IsNullOrWhiteSpace(dp_txt.Text) Then
            MsgBox("Please fill in all fields.", MsgBoxStyle.Critical, "Validation Error")
            Return
        End If

        ' Validate SSN length
        If ssn.Length <> 12 Then
            MsgBox("Employee SSN must be 12 digits.", MsgBoxStyle.Critical, "Validation Error")
            Return
        End If
        obj.DbOpreation("UPDATE employee SET employee_name = '" & name_txt.Text & "', employee_ssn = '" & emp_ssn.Text & "', employee_dob = '" & dob_txt.Text & "', employee_dp = '" & dp_txt.Text & "', profile_img = '" & profilePic.ImageLocation & "' WHERE id = " & id_txt.Text)
        obj.displayOnDataGrid("select * from employee  ", emp_data_grid_view)
    End Sub

    Private Sub pic_btn_Click(sender As Object, e As EventArgs)
        'image path
        Dim img_path As String

        'open file dialog for the user to chose an image
        OpenFileDialog1.ShowDialog()

        'assigning a value for the img_path variable
        img_path = OpenFileDialog1.FileName



        'Changing user picture
        PictureBox.ImageLocation = img_path

        ' Only PNG or JPG or JPEG
        If img_path.Contains(".png") Or img_path.Contains(".jpg") Or img_path.Contains(".jpeg") Then

            PictureBox.Load(img_path)
        Else
            MsgBox("الرجاء اختيار صورة نوع PNG أو JPG !", MsgBoxStyle.Critical, "منظومة شؤون الطلبة")
        End If
    End Sub

    Private Sub search_txt_TextChanged(sender As Object, e As EventArgs) Handles search_txt.TextChanged
        obj.displayOnDataGrid("select * from employee where employee_name like '%" & search_txt.Text & "%'", emp_data_grid_view)
    End Sub

    Private Sub student_data_grid_view_KeyDown(sender As Object, e As KeyEventArgs) Handles emp_data_grid_view.KeyDown
        ' Check if the current row is not null before accessing its cells
        If emp_data_grid_view.CurrentRow IsNot DBNull.Value Then
            id_txt.Text = emp_data_grid_view.CurrentRow.Cells(0).Value
            name_txt.Text = emp_data_grid_view.CurrentRow.Cells(1).Value
            emp_ssn.Text = emp_data_grid_view.CurrentRow.Cells(2).Value
            dob_txt.Text = emp_data_grid_view.CurrentRow.Cells(3).Value
            dp_txt.Text = emp_data_grid_view.CurrentRow.Cells(4).Value
            ' Check if cell 5 is not null before assigning to profilePic.ImageLocation
            If emp_data_grid_view.CurrentRow.Cells(5).Value IsNot DBNull.Value Then
                profilePic.ImageLocation = emp_data_grid_view.CurrentRow.Cells(5).Value
            Else
                profilePic.ImageLocation = String.Empty ' or set a default image
            End If
        End If
    End Sub

    Private Sub add_pic_btn_Click(sender As Object, e As EventArgs) Handles add_pic_btn.Click
        'image path
        Dim img_path As String

        'open file dialog for the user to chose an image
        OpenFileDialog1.ShowDialog()

        'assigning a value for the img_path variable
        img_path = OpenFileDialog1.FileName

        'displays the image path for the user in the GUI

        'Changing user picture
        profilePic.ImageLocation = img_path

        ' Only PNG or JPG or JPEG
        If img_path.Contains(".png") Or img_path.Contains(".jpg") Or img_path.Contains(".jpeg") Then

            profilePic.Load(img_path)
        Else
            MsgBox("الرجاء اختيار صورة نوع PNG أو JPG !", MsgBoxStyle.Critical, "منظومة شؤون الطلبة")
        End If
    End Sub
End Class
