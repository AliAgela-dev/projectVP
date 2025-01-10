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
        add_pic_btn = New Button()
        profilePic = New PictureBox()
        dob_txt = New DateTimePicker()
        dp_txt = New ComboBox()
        nat_lbl = New Label()
        data_txt = New Label()
        Label2 = New Label()
        Label1 = New Label()
        emp_ssn = New TextBox()
        name_txt = New TextBox()
        add_btn = New Button()
        delete_btn = New Button()
        edit_btn = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        emp_data_grid_view = New DataGridView()
        search_txt = New TextBox()
        id_txt = New TextBox()
        id = New DataGridViewTextBoxColumn()
        employee_name = New DataGridViewTextBoxColumn()
        employee_ssn = New DataGridViewTextBoxColumn()
        employee_dob = New DataGridViewTextBoxColumn()
        employee_dp = New DataGridViewTextBoxColumn()
        profile_img = New DataGridViewTextBoxColumn()
        GB1.SuspendLayout()
        CType(profilePic, ComponentModel.ISupportInitialize).BeginInit()
        CType(emp_data_grid_view, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GB1
        ' 
        GB1.Anchor = AnchorStyles.None
        GB1.Controls.Add(add_pic_btn)
        GB1.Controls.Add(profilePic)
        GB1.Controls.Add(dob_txt)
        GB1.Controls.Add(dp_txt)
        GB1.Controls.Add(nat_lbl)
        GB1.Controls.Add(data_txt)
        GB1.Controls.Add(Label2)
        GB1.Controls.Add(Label1)
        GB1.Controls.Add(emp_ssn)
        GB1.Controls.Add(name_txt)
        GB1.Location = New Point(12, 12)
        GB1.Name = "GB1"
        GB1.RightToLeft = RightToLeft.Yes
        GB1.Size = New Size(1258, 359)
        GB1.TabIndex = 0
        GB1.TabStop = False
        GB1.Text = "منظومة الطلبة "
        ' 
        ' add_pic_btn
        ' 
        add_pic_btn.Location = New Point(30, 230)
        add_pic_btn.Name = "add_pic_btn"
        add_pic_btn.Size = New Size(205, 54)
        add_pic_btn.TabIndex = 19
        add_pic_btn.Text = "تحديد الصورة"
        add_pic_btn.UseVisualStyleBackColor = True
        ' 
        ' profilePic
        ' 
        profilePic.Image = CType(resources.GetObject("profilePic.Image"), Image)
        profilePic.Location = New Point(30, 17)
        profilePic.Name = "profilePic"
        profilePic.Size = New Size(205, 207)
        profilePic.TabIndex = 19
        profilePic.TabStop = False
        ' 
        ' dob_txt
        ' 
        dob_txt.Format = DateTimePickerFormat.Short
        dob_txt.Location = New Point(478, 88)
        dob_txt.Name = "dob_txt"
        dob_txt.Size = New Size(340, 30)
        dob_txt.TabIndex = 17
        ' 
        ' dp_txt
        ' 
        dp_txt.FormattingEnabled = True
        dp_txt.Location = New Point(478, 160)
        dp_txt.Name = "dp_txt"
        dp_txt.Size = New Size(340, 30)
        dp_txt.TabIndex = 16
        ' 
        ' nat_lbl
        ' 
        nat_lbl.AutoSize = True
        nat_lbl.Location = New Point(760, 135)
        nat_lbl.Name = "nat_lbl"
        nat_lbl.Size = New Size(41, 22)
        nat_lbl.TabIndex = 12
        nat_lbl.Text = "القسم"
        ' 
        ' data_txt
        ' 
        data_txt.AutoSize = True
        data_txt.Location = New Point(727, 63)
        data_txt.Name = "data_txt"
        data_txt.Size = New Size(91, 22)
        data_txt.TabIndex = 10
        data_txt.Text = "تاريخ الميلاد"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(1122, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 22)
        Label2.TabIndex = 4
        Label2.Text = "الرقم الوطني"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(1122, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 22)
        Label1.TabIndex = 3
        Label1.Text = "اسم الموظف"
        ' 
        ' emp_ssn
        ' 
        emp_ssn.Location = New Point(853, 160)
        emp_ssn.Name = "emp_ssn"
        emp_ssn.Size = New Size(340, 30)
        emp_ssn.TabIndex = 2
        ' 
        ' name_txt
        ' 
        name_txt.Location = New Point(853, 88)
        name_txt.Name = "name_txt"
        name_txt.Size = New Size(340, 30)
        name_txt.TabIndex = 0
        ' 
        ' add_btn
        ' 
        add_btn.Location = New Point(290, 398)
        add_btn.Name = "add_btn"
        add_btn.Size = New Size(94, 29)
        add_btn.TabIndex = 6
        add_btn.Text = "اضافة "
        add_btn.UseVisualStyleBackColor = True
        ' 
        ' delete_btn
        ' 
        delete_btn.Location = New Point(90, 398)
        delete_btn.Name = "delete_btn"
        delete_btn.Size = New Size(94, 29)
        delete_btn.TabIndex = 7
        delete_btn.Text = "حذف"
        delete_btn.UseVisualStyleBackColor = True
        ' 
        ' edit_btn
        ' 
        edit_btn.Location = New Point(190, 398)
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
        emp_data_grid_view.Columns.AddRange(New DataGridViewColumn() {id, employee_name, employee_ssn, employee_dob, employee_dp, profile_img})
        emp_data_grid_view.Location = New Point(12, 447)
        emp_data_grid_view.Name = "emp_data_grid_view"
        emp_data_grid_view.RowHeadersWidth = 51
        emp_data_grid_view.Size = New Size(1258, 188)
        emp_data_grid_view.TabIndex = 18
        ' 
        ' search_txt
        ' 
        search_txt.Location = New Point(906, 398)
        search_txt.Name = "search_txt"
        search_txt.Size = New Size(340, 30)
        search_txt.TabIndex = 18
        ' 
        ' id_txt
        ' 
        id_txt.Location = New Point(431, 397)
        id_txt.Name = "id_txt"
        id_txt.Size = New Size(65, 30)
        id_txt.TabIndex = 18
        ' 
        ' id
        ' 
        id.DataPropertyName = "id"
        id.HeaderText = "id"
        id.MinimumWidth = 6
        id.Name = "id"
        ' 
        ' employee_name
        ' 
        employee_name.DataPropertyName = "employee_name"
        employee_name.HeaderText = "اسم الموظف"
        employee_name.MinimumWidth = 6
        employee_name.Name = "employee_name"
        ' 
        ' employee_ssn
        ' 
        employee_ssn.DataPropertyName = "employee_ssn"
        employee_ssn.HeaderText = "الرقم الوطني"
        employee_ssn.MinimumWidth = 6
        employee_ssn.Name = "employee_ssn"
        ' 
        ' employee_dob
        ' 
        employee_dob.DataPropertyName = "employee_dob"
        employee_dob.HeaderText = "تاريخ الميلاد"
        employee_dob.MinimumWidth = 6
        employee_dob.Name = "employee_dob"
        ' 
        ' employee_dp
        ' 
        employee_dp.DataPropertyName = "employee_dp"
        employee_dp.HeaderText = "القسم"
        employee_dp.MinimumWidth = 6
        employee_dp.Name = "employee_dp"
        ' 
        ' profile_img
        ' 
        profile_img.DataPropertyName = "profile_img"
        profile_img.HeaderText = "profile_img"
        profile_img.MinimumWidth = 6
        profile_img.Name = "profile_img"
        profile_img.Visible = False
        ' 
        ' main_form
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 22.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1282, 753)
        Controls.Add(id_txt)
        Controls.Add(search_txt)
        Controls.Add(emp_data_grid_view)
        Controls.Add(edit_btn)
        Controls.Add(delete_btn)
        Controls.Add(GB1)
        Controls.Add(add_btn)
        Font = New Font("Times New Roman", 12.0F)
        Margin = New Padding(4)
        Name = "main_form"
        RightToLeftLayout = True
        SizeGripStyle = SizeGripStyle.Hide
        Text = "mainForm"
        GB1.ResumeLayout(False)
        GB1.PerformLayout()
        CType(profilePic, ComponentModel.ISupportInitialize).EndInit()
        CType(emp_data_grid_view, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Protected Friend WithEvents GB1 As GroupBox
    Friend WithEvents emp_ssn As TextBox
    Friend WithEvents ssn_txt As TextBox
    Friend WithEvents name_txt As TextBox
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
    Friend WithEvents dob_txt As DateTimePicker
    Friend WithEvents dp_txt As ComboBox
    Friend WithEvents prog_txt As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents emp_data_grid_view As DataGridView
    Friend WithEvents search_txt As TextBox
    Friend WithEvents id_txt As TextBox
    Friend WithEvents add_pic_btn As Button
    Friend WithEvents profilePic As PictureBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents employee_name As DataGridViewTextBoxColumn
    Friend WithEvents employee_ssn As DataGridViewTextBoxColumn
    Friend WithEvents employee_dob As DataGridViewTextBoxColumn
    Friend WithEvents employee_dp As DataGridViewTextBoxColumn
    Friend WithEvents profile_img As DataGridViewTextBoxColumn


End Class
