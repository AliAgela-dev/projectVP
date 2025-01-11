Imports System.Runtime.Intrinsics.X86
Imports projectVP.SharedFunctions
Public Class main_form

    Public obj As New SharedFunctions
    Dim data As String = "select p.product_id,p.product_number,p.description as product_description,p.quantity,p.date_of_last_shipment,c.description as country_description,cat.description as category_description,p.product_picture from product p inner join country c on p.country_of_origin = c.country_id inner join  category cat on p.category = cat.category_id;"

    Public Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        ' Validate that all fields are filled
        If String.IsNullOrWhiteSpace(id_txt.Text) OrElse String.IsNullOrWhiteSpace(des_txt.Text) OrElse String.IsNullOrWhiteSpace(qun_txt.Text) OrElse String.IsNullOrWhiteSpace(dos_txt.Text) OrElse co_txt.SelectedValue Is Nothing OrElse ca_txt.SelectedValue Is Nothing Then
            MsgBox("الرجاء ملء جميع الحقول.")
            Return
        End If

        ' Validate that id_txt is an integer
        Dim productId As Integer
        If Not Integer.TryParse(id_txt.Text, productId) Then
            MsgBox("الرجاء إدخال رقم صحيح في حقل رقم الصنف .")
            Return
        End If
        Dim qun As Integer
        If Not Integer.TryParse(qun_txt.Text, qun) Then
            MsgBox("الرجاء إدخال رقم صحيح في حقل الكمية.")
            Return
        End If

        Dim sql As String = "select product_number from product where product_number = " & productId

        If obj.isLogedIn(sql) Then
            MsgBox("هذا المنتج متواجد من قبل")
            Return
        End If
        obj.DbOpreation("insert into product ( product_number,description,quantity,date_of_last_shipment,country_of_origin,category,product_picture) values(" & productId & ",N'" & des_txt.Text & "'," & qun_txt.Text & ",'" & dos_txt.Text & "'," & co_txt.SelectedValue & "," & ca_txt.SelectedValue & ",'" & productpic.ImageLocation & "')")
        obj.displayOnDataGrid(data, emp_data_grid_view)
    End Sub
    Private Sub Main_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = user_name
        If user_role = "admin" Then

            delete_btn.Enabled = True
        Else

            delete_btn.Enabled = False
        End If
        obj.FillList(co_txt, "country", "description", "country_id")
        obj.FillList(ca_txt, "category", "description", "category_id")
        obj.displayOnDataGrid(data, emp_data_grid_view)


    End Sub

    Public Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        ' Validate that id_txt is an integer
        Dim productId As Integer
        If Not Integer.TryParse(id_txt.Text, productId) Then
            MsgBox("الرجاء إدخال رقم صحيح في حقل رقم الصنف .")
            Return
        End If
        obj.DbOpreation("delete from product where  product_number = " & id_txt.Text)
        obj.displayOnDataGrid(data, emp_data_grid_view)

    End Sub
    Private Sub edit_btn_Click(sender As Object, e As EventArgs) Handles edit_btn.Click
        ' Validate that all fields are filled
        If String.IsNullOrWhiteSpace(id_txt.Text) OrElse String.IsNullOrWhiteSpace(des_txt.Text) OrElse String.IsNullOrWhiteSpace(qun_txt.Text) OrElse String.IsNullOrWhiteSpace(dos_txt.Text) OrElse co_txt.SelectedValue Is Nothing OrElse ca_txt.SelectedValue Is Nothing Then
            MsgBox("الرجاء ملء جميع الحقول.")
            Return
        End If

        ' Validate that id_txt is an integer
        Dim productId As Integer
        If Not Integer.TryParse(id_txt.Text, productId) Then
            MsgBox("الرجاء إدخال رقم صحيح في حقل رقم الصنف .")
            Return
        End If
        Dim qun As Integer
        If Not Integer.TryParse(qun_txt.Text, qun) Then
            MsgBox("الرجاء إدخال رقم صحيح في حقل الكمية.")
            Return
        End If
        obj.DbOpreation("UPDATE product Set description = N'" & des_txt.Text & "', product_number = " & id_txt.Text & ", date_of_last_shipment = '" & dos_txt.Text & "', quantity = " & qun_txt.Text & ", country_of_origin = " & co_txt.SelectedValue & ", category = " & ca_txt.SelectedValue & ",product_picture ='" & productpic.ImageLocation & "' WHERE product_number = " & id_txt.Text)
        obj.displayOnDataGrid(data, emp_data_grid_view)
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
        Dim searchsql As String = "select  p.product_id, p.product_number, p.description as product_description, p.quantity, p.date_of_last_shipment, c.description as country_description, cat.description as category_description, p.product_picture from  product p inner join  country c on p.country_of_origin = c.country_id inner join  category cat on p.category = cat.category_id where  p.description like N'%" & search_txt.Text & "%'  or p.product_number like N'%" & search_txt.Text & "%' "
        obj.displayOnDataGrid(searchsql, emp_data_grid_view)
    End Sub

    Private Sub student_data_grid_view_KeyDown(sender As Object, e As KeyEventArgs) Handles emp_data_grid_view.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Check if the current row is not null before accessing its cells
            If emp_data_grid_view.CurrentRow.Index = emp_data_grid_view.Rows.Count - 1 Then
                ' Move to the first row
                emp_data_grid_view.CurrentCell = emp_data_grid_view.Rows(0).Cells(0)
            End If
            If emp_data_grid_view.CurrentRow IsNot DBNull.Value Then
                id_txt.Text = emp_data_grid_view.CurrentRow.Cells(1).Value
                des_txt.Text = emp_data_grid_view.CurrentRow.Cells(2).Value
                qun_txt.Text = emp_data_grid_view.CurrentRow.Cells(3).Value
                dos_txt.Text = emp_data_grid_view.CurrentRow.Cells(4).Value
                co_txt.Text = emp_data_grid_view.CurrentRow.Cells(5).Value
                ca_txt.Text = emp_data_grid_view.CurrentRow.Cells(6).Value
                ' Check if cell 5 is not null before assigning to productpic.ImageLocation
                If emp_data_grid_view.CurrentRow.Cells(5).Value IsNot DBNull.Value Then
                    productpic.ImageLocation = emp_data_grid_view.CurrentRow.Cells(7).Value
                Else
                    productpic.ImageLocation = String.Empty ' or set a default image
                End If
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
        productpic.ImageLocation = img_path

        ' Only PNG or JPG or JPEG
        If img_path.Contains(".png") Or img_path.Contains(".jpg") Or img_path.Contains(".jpeg") Then

            productpic.Load(img_path)
        Else
            MsgBox("الرجاء اختيار صورة نوع PNG أو JPG !", MsgBoxStyle.Critical, "منظومة شؤون الطلبة")
        End If
    End Sub
End Class
