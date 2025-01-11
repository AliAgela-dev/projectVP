<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_form))
        GB1 = New GroupBox()
        ca_txt = New ComboBox()
        Label5 = New Label()
        Label4 = New Label()
        id_txt = New TextBox()
        add_pic_btn = New Button()
        productpic = New PictureBox()
        dos_txt = New DateTimePicker()
        co_txt = New ComboBox()
        nat_lbl = New Label()
        data_txt = New Label()
        Label2 = New Label()
        Label1 = New Label()
        qun_txt = New TextBox()
        des_txt = New TextBox()
        add_btn = New Button()
        delete_btn = New Button()
        edit_btn = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        emp_data_grid_view = New DataGridView()
        product_id = New DataGridViewTextBoxColumn()
        product_number = New DataGridViewTextBoxColumn()
        product_description = New DataGridViewTextBoxColumn()
        quantity = New DataGridViewTextBoxColumn()
        date_of_last_shipment = New DataGridViewTextBoxColumn()
        country_description = New DataGridViewTextBoxColumn()
        category_description = New DataGridViewTextBoxColumn()
        product_picture = New DataGridViewTextBoxColumn()
        search_txt = New TextBox()
        Label3 = New Label()
        GB1.SuspendLayout()
        CType(productpic, ComponentModel.ISupportInitialize).BeginInit()
        CType(emp_data_grid_view, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GB1
        ' 
        GB1.Anchor = AnchorStyles.None
        GB1.Controls.Add(ca_txt)
        GB1.Controls.Add(Label5)
        GB1.Controls.Add(Label4)
        GB1.Controls.Add(id_txt)
        GB1.Controls.Add(add_pic_btn)
        GB1.Controls.Add(productpic)
        GB1.Controls.Add(dos_txt)
        GB1.Controls.Add(co_txt)
        GB1.Controls.Add(nat_lbl)
        GB1.Controls.Add(data_txt)
        GB1.Controls.Add(Label2)
        GB1.Controls.Add(Label1)
        GB1.Controls.Add(qun_txt)
        GB1.Controls.Add(des_txt)
        GB1.Location = New Point(37, 12)
        GB1.Name = "GB1"
        GB1.RightToLeft = RightToLeft.Yes
        GB1.Size = New Size(1379, 359)
        GB1.TabIndex = 0
        GB1.TabStop = False
        GB1.Text = "بيانات الصنف"
        ' 
        ' ca_txt
        ' 
        ca_txt.FormattingEnabled = True
        ca_txt.Location = New Point(315, 230)
        ca_txt.Name = "ca_txt"
        ca_txt.Size = New Size(340, 30)
        ca_txt.TabIndex = 22
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(671, 238)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 22)
        Label5.TabIndex = 21
        Label5.Text = "التصنيف"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(1230, 91)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 22)
        Label4.TabIndex = 20
        Label4.Text = "رقم الصنف"
        ' 
        ' id_txt
        ' 
        id_txt.Location = New Point(885, 88)
        id_txt.Name = "id_txt"
        id_txt.Size = New Size(340, 30)
        id_txt.TabIndex = 18
        ' 
        ' add_pic_btn
        ' 
        add_pic_btn.Location = New Point(33, 299)
        add_pic_btn.Name = "add_pic_btn"
        add_pic_btn.Size = New Size(205, 54)
        add_pic_btn.TabIndex = 19
        add_pic_btn.Text = "تحديد الصورة"
        add_pic_btn.UseVisualStyleBackColor = True
        ' 
        ' productpic
        ' 
        productpic.Image = CType(resources.GetObject("productpic.Image"), Image)
        productpic.Location = New Point(33, 85)
        productpic.Name = "productpic"
        productpic.Size = New Size(205, 207)
        productpic.TabIndex = 19
        productpic.TabStop = False
        ' 
        ' dos_txt
        ' 
        dos_txt.Format = DateTimePickerFormat.Short
        dos_txt.Location = New Point(315, 85)
        dos_txt.Name = "dos_txt"
        dos_txt.Size = New Size(340, 30)
        dos_txt.TabIndex = 17
        ' 
        ' co_txt
        ' 
        co_txt.FormattingEnabled = True
        co_txt.Location = New Point(315, 160)
        co_txt.Name = "co_txt"
        co_txt.Size = New Size(340, 30)
        co_txt.TabIndex = 16
        ' 
        ' nat_lbl
        ' 
        nat_lbl.AutoSize = True
        nat_lbl.Location = New Point(661, 168)
        nat_lbl.Name = "nat_lbl"
        nat_lbl.Size = New Size(68, 22)
        nat_lbl.TabIndex = 12
        nat_lbl.Text = "بلد المنشأ"
        ' 
        ' data_txt
        ' 
        data_txt.AutoSize = True
        data_txt.Location = New Point(661, 91)
        data_txt.Name = "data_txt"
        data_txt.Size = New Size(116, 22)
        data_txt.TabIndex = 10
        data_txt.Text = "تاريخ اخر شحنة"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(1231, 243)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 22)
        Label2.TabIndex = 4
        Label2.Text = "الكمية"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(1231, 163)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 22)
        Label1.TabIndex = 3
        Label1.Text = "الوصف"
        ' 
        ' qun_txt
        ' 
        qun_txt.Location = New Point(885, 235)
        qun_txt.Name = "qun_txt"
        qun_txt.Size = New Size(340, 30)
        qun_txt.TabIndex = 2
        ' 
        ' des_txt
        ' 
        des_txt.Location = New Point(885, 160)
        des_txt.Name = "des_txt"
        des_txt.Size = New Size(340, 30)
        des_txt.TabIndex = 0
        ' 
        ' add_btn
        ' 
        add_btn.Location = New Point(293, 398)
        add_btn.Name = "add_btn"
        add_btn.Size = New Size(94, 29)
        add_btn.TabIndex = 6
        add_btn.Text = "اضافة "
        add_btn.UseVisualStyleBackColor = True
        ' 
        ' delete_btn
        ' 
        delete_btn.Location = New Point(93, 398)
        delete_btn.Name = "delete_btn"
        delete_btn.Size = New Size(94, 29)
        delete_btn.TabIndex = 7
        delete_btn.Text = "حذف"
        delete_btn.UseVisualStyleBackColor = True
        ' 
        ' edit_btn
        ' 
        edit_btn.Location = New Point(193, 398)
        edit_btn.Name = "edit_btn"
        edit_btn.Size = New Size(94, 29)
        edit_btn.TabIndex = 8
        edit_btn.Text = "تعديل"
        edit_btn.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' emp_data_grid_view
        ' 
        emp_data_grid_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        emp_data_grid_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        emp_data_grid_view.Columns.AddRange(New DataGridViewColumn() {product_id, product_number, product_description, quantity, date_of_last_shipment, country_description, category_description, product_picture})
        emp_data_grid_view.Location = New Point(37, 451)
        emp_data_grid_view.Name = "emp_data_grid_view"
        emp_data_grid_view.RightToLeft = RightToLeft.Yes
        emp_data_grid_view.RowHeadersWidth = 51
        emp_data_grid_view.Size = New Size(1262, 188)
        emp_data_grid_view.TabIndex = 18
        ' 
        ' product_id
        ' 
        product_id.DataPropertyName = "product_id"
        product_id.HeaderText = "الرقم الالي"
        product_id.MinimumWidth = 6
        product_id.Name = "product_id"
        ' 
        ' product_number
        ' 
        product_number.DataPropertyName = "product_number"
        product_number.HeaderText = "رقم الصنف"
        product_number.MinimumWidth = 6
        product_number.Name = "product_number"
        ' 
        ' product_description
        ' 
        product_description.DataPropertyName = "product_description"
        product_description.HeaderText = "الوصف"
        product_description.MinimumWidth = 6
        product_description.Name = "product_description"
        ' 
        ' quantity
        ' 
        quantity.DataPropertyName = "quantity"
        quantity.HeaderText = "الكمية"
        quantity.MinimumWidth = 6
        quantity.Name = "quantity"
        ' 
        ' date_of_last_shipment
        ' 
        date_of_last_shipment.DataPropertyName = "date_of_last_shipment"
        date_of_last_shipment.HeaderText = "تاريخ اخر شحنة"
        date_of_last_shipment.MinimumWidth = 6
        date_of_last_shipment.Name = "date_of_last_shipment"
        ' 
        ' country_description
        ' 
        country_description.DataPropertyName = "country_description"
        country_description.HeaderText = "بلد المنشأ"
        country_description.MinimumWidth = 6
        country_description.Name = "country_description"
        ' 
        ' category_description
        ' 
        category_description.DataPropertyName = "category_description"
        category_description.HeaderText = "التصنيف"
        category_description.MinimumWidth = 6
        category_description.Name = "category_description"
        ' 
        ' product_picture
        ' 
        product_picture.DataPropertyName = "product_picture"
        product_picture.HeaderText = "profile_img"
        product_picture.MinimumWidth = 6
        product_picture.Name = "product_picture"
        product_picture.Visible = False
        ' 
        ' search_txt
        ' 
        search_txt.Location = New Point(783, 398)
        search_txt.Name = "search_txt"
        search_txt.Size = New Size(340, 30)
        search_txt.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(1152, 401)
        Label3.Name = "Label3"
        Label3.Size = New Size(240, 22)
        Label3.TabIndex = 23
        Label3.Text = "ادخل وصف لاصنف او رقمه للبحث"
        ' 
        ' main_form
        ' 
        AutoScaleDimensions = New SizeF(11F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1425, 753)
        Controls.Add(Label3)
        Controls.Add(search_txt)
        Controls.Add(emp_data_grid_view)
        Controls.Add(edit_btn)
        Controls.Add(delete_btn)
        Controls.Add(GB1)
        Controls.Add(add_btn)
        Font = New Font("Times New Roman", 12F)
        Margin = New Padding(4)
        Name = "main_form"
        RightToLeftLayout = True
        SizeGripStyle = SizeGripStyle.Hide
        Text = "mainForm"
        GB1.ResumeLayout(False)
        GB1.PerformLayout()
        CType(productpic, ComponentModel.ISupportInitialize).EndInit()
        CType(emp_data_grid_view, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Protected Friend WithEvents GB1 As GroupBox
    Friend WithEvents qun_txt As TextBox
    Friend WithEvents ssn_txt As TextBox
    Friend WithEvents des_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nat_lbl As Label
    Friend WithEvents program_txt As Label
    Friend WithEvents data_txt As Label
    Friend WithEvents add_btn As Button
    Friend WithEvents pic_btn As Button
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents delete_btn As Button
    Friend WithEvents edit_btn As Button
    Friend WithEvents dos_txt As DateTimePicker
    Friend WithEvents co_txt As ComboBox
    Friend WithEvents prog_txt As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents emp_data_grid_view As DataGridView
    Friend WithEvents search_txt As TextBox
    Friend WithEvents id_txt As TextBox
    Friend WithEvents add_pic_btn As Button
    Friend WithEvents productpic As PictureBox
    Friend WithEvents ca_txt As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents product_id As DataGridViewTextBoxColumn
    Friend WithEvents product_number As DataGridViewTextBoxColumn
    Friend WithEvents product_description As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents date_of_last_shipment As DataGridViewTextBoxColumn
    Friend WithEvents country_description As DataGridViewTextBoxColumn
    Friend WithEvents category_description As DataGridViewTextBoxColumn
    Friend WithEvents product_picture As DataGridViewTextBoxColumn


End Class
