Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ukv As Integer = 100000
        Dim ukp, totalUKV, total

        If CheckBox1.Checked = True Then
            totalUKV += ukv
        End If
        If CheckBox2.Checked = True Then
            totalUKV += ukv
        End If
        If CheckBox3.Checked = True Then
            totalUKV += ukv
        End If
        If CheckBox4.Checked = True Then
            totalUKV += ukv
        End If
        If CheckBox5.Checked = True Then
            totalUKV += ukv
        End If
        If CheckBox6.Checked = True Then
            totalUKV += ukv
        End If

        If ComboBox1.Text = "Sistem Informasi" Then
            ukp = 1200000
        ElseIf ComboBox1.Text = "Teknik Informatika" Then
            ukp = 1100000
        ElseIf ComboBox1.Text = "Teknik Multimedia Jaringan" Then
            ukp = 900000
        ElseIf ComboBox1.Text = "Komputerisasi Akuntansi" Then
            ukp = 750000
        End If

        total = totalUKV + ukp

        Label11.Text = TextBox2.Text
        Label11.Visible = True
        Label12.Text = TextBox1.Text
        Label12.Visible = True
        Label13.Text = ComboBox1.Text
        Label13.Visible = True
        Label14.Text = ukp
        Label14.Visible = True
        Label15.Text = totalUKV
        Label15.Visible = True
        Label18.Text = total
        Label18.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Label18.Visible = False
    End Sub

End Class
