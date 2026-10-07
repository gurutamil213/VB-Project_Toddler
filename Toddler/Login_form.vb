Imports System.Configuration

Public Class Login_form

    Private ReadOnly appUsername As String = ConfigurationManager.AppSettings("ToddlerLoginUsername")
    Private ReadOnly appPassword As String = ConfigurationManager.AppSettings("ToddlerLoginPassword")

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dashboard.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        MaximizeBox = False
    End Sub

    Private Sub Form3_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        dashboard.Visible = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dashboard.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        If String.Equals(username, appUsername, StringComparison.Ordinal) AndAlso
           String.Equals(password, appPassword, StringComparison.Ordinal) Then
            Edit_form.Show()
            Me.Visible = False
        Else
            MsgBox("check the details")
        End If
    End Sub
End Class