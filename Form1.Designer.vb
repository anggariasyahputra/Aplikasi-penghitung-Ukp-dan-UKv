<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        CheckBox1 = New CheckBox()
        Label4 = New Label()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox6 = New CheckBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(167, 37)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(216, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(167, 75)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(216, 23)
        TextBox2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(60, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 30)
        Label1.TabIndex = 2
        Label1.Text = "NAMA :"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(82, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 30)
        Label2.TabIndex = 3
        Label2.Text = "NIM :"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(61, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 30)
        Label3.TabIndex = 4
        Label3.Text = "PRODI :"' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Sistem Informasi", "Teknik Informatika", "Teknik Multimedia Jaringan", "Komputerisasi Akuntansi"})
        ComboBox1.Location = New Point(167, 118)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(216, 23)
        ComboBox1.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(351, 316)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 47)
        Button1.TabIndex = 6
        Button1.Text = "KIRIM"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox1.Location = New Point(167, 176)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(128, 25)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Pemrograman"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(57, 165)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 30)
        Label4.TabIndex = 8
        Label4.Text = "Matkul :"' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox2.Location = New Point(167, 215)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(98, 25)
        CheckBox2.TabIndex = 9
        CheckBox2.Text = "Akuntansi"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox3.Location = New Point(167, 254)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(91, 25)
        CheckBox3.TabIndex = 10
        CheckBox3.Text = "Robotika"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox4.Location = New Point(351, 176)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(91, 25)
        CheckBox4.TabIndex = 11
        CheckBox4.Text = "Statistika"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox5.Location = New Point(351, 215)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(108, 25)
        CheckBox5.TabIndex = 12
        CheckBox5.Text = "Religiusitas"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox6.Location = New Point(351, 254)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(111, 25)
        CheckBox6.TabIndex = 13
        CheckBox6.Text = "Matematika"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(671, 8)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 41)
        Label5.TabIndex = 14
        Label5.Text = "HASIL"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(626, 96)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 30)
        Label6.TabIndex = 15
        Label6.Text = "NAMA :"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(626, 55)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 30)
        Label7.TabIndex = 16
        Label7.Text = "NIM     :"' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(626, 135)
        Label8.Name = "Label8"
        Label8.Size = New Size(87, 30)
        Label8.TabIndex = 17
        Label8.Text = "PRODI :"' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(626, 176)
        Label9.Name = "Label9"
        Label9.Size = New Size(88, 30)
        Label9.TabIndex = 18
        Label9.Text = "UKP     :"' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(630, 215)
        Label10.Name = "Label10"
        Label10.Size = New Size(84, 30)
        Label10.TabIndex = 19
        Label10.Text = "UKV    :"' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(733, 54)
        Label11.Name = "Label11"
        Label11.Size = New Size(55, 30)
        Label11.TabIndex = 20
        Label11.Text = "NIM"' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(731, 99)
        Label12.Name = "Label12"
        Label12.Size = New Size(70, 30)
        Label12.TabIndex = 21
        Label12.Text = "Nama"' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(732, 140)
        Label13.Name = "Label13"
        Label13.Size = New Size(64, 30)
        Label13.TabIndex = 22
        Label13.Text = "Prodi"' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(731, 177)
        Label14.Name = "Label14"
        Label14.Size = New Size(49, 30)
        Label14.TabIndex = 23
        Label14.Text = "ukp"' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(732, 213)
        Label15.Name = "Label15"
        Label15.Size = New Size(47, 30)
        Label15.TabIndex = 24
        Label15.Text = "ukv"' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(625, 284)
        Label16.Name = "Label16"
        Label16.Size = New Size(81, 41)
        Label16.TabIndex = 25
        Label16.Text = "Total"' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(733, 295)
        Label17.Name = "Label17"
        Label17.Size = New Size(0, 30)
        Label17.TabIndex = 26
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point)
        Label18.Location = New Point(733, 284)
        Label18.Name = "Label18"
        Label18.Size = New Size(81, 41)
        Label18.TabIndex = 27
        Label18.Text = "Total"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(928, 387)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(CheckBox6)
        Controls.Add(CheckBox5)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(Label4)
        Controls.Add(CheckBox1)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
End Class
