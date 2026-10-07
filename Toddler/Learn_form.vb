Imports System.IO
Imports System.Data.OleDb

Public Class Learn_form
    Private ReadOnly cn As New OleDbConnection(My.Settings.toddlerConnectionString)

    Private Function ResolveImagePath(ByVal storedPath As String) As String
        If String.IsNullOrWhiteSpace(storedPath) Then
            Return String.Empty
        End If

        Dim trimmedPath As String = storedPath.Trim()
        If Path.IsPathRooted(trimmedPath) Then
            Return trimmedPath
        End If

        Return Path.Combine(Application.StartupPath, trimmedPath.Replace("/", "\"))
    End Function

    Private Sub ShowImage(ByVal storedPath As String)
        PictureBox1.Image = Nothing

        If String.IsNullOrWhiteSpace(storedPath) Then
            Return
        End If

        Dim fullPath As String = ResolveImagePath(storedPath)
        If File.Exists(fullPath) Then
            PictureBox1.Image = Image.FromFile(fullPath)
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dashboard.Visible = False
        MaximizeBox = False
    End Sub

    Private Sub Form2_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        dashboard.Visible = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = Button1.Text
        lbfruit.Visible = True
        lbveg.Visible = False
        lbanimal.Visible = False
        lbbird.Visible = False
        Label3.Text = "Nutrients"
        Label6.Text = "Grow Type"
        Dim str1 As String
        Dim cmd1 As New OleDbCommand
        cn.Open()
        str1 = "select name from fruit"
        cmd1 = New OleDbCommand(str1, cn)
        cmd1.ExecuteNonQuery()
        cn.Close()
        Dim da As New OleDbDataAdapter(cmd1)
        Dim dt As New DataTable
        da.Fill(dt)
        lbfruit.DataSource = dt
        lbfruit.DisplayMember = "name"

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label1.Text = Button2.Text
        lbfruit.Visible = False
        lbveg.Visible = True
        lbanimal.Visible = False
        lbbird.Visible = False
        Label3.Text = "Nutrients"
        Label6.Text = "Grow Type"
        Dim str1 As String
        Dim cmd1 As New OleDbCommand
        cn.Open()
        str1 = "select name from veg"
        cmd1 = New OleDbCommand(str1, cn)
        cmd1.ExecuteNonQuery()
        cn.Close()
        Dim da As New OleDbDataAdapter(cmd1)
        Dim dt As New DataTable
        da.Fill(dt)
        lbveg.DataSource = dt
        lbveg.DisplayMember = "name"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label1.Text = Button3.Text
        lbfruit.Visible = False
        lbveg.Visible = False
        lbanimal.Visible = True
        lbbird.Visible = False
        Label3.Text = "Food"
        Label6.Text = "Special Characteristic"
        Dim str1 As String
        Dim cmd1 As New OleDbCommand
        cn.Open()
        str1 = "select name from animal"
        cmd1 = New OleDbCommand(str1, cn)
        cmd1.ExecuteNonQuery()
        cn.Close()
        Dim da As New OleDbDataAdapter(cmd1)
        Dim dt As New DataTable
        da.Fill(dt)
        lbanimal.DataSource = dt
        lbanimal.DisplayMember = "name"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Label1.Text = Button4.Text
        lbfruit.Visible = False
        lbveg.Visible = False
        lbanimal.Visible = False
        lbbird.Visible = True
        Label3.Text = "Food"
        Label6.Text = "Special Characteristic"
        Dim str1 As String
        Dim cmd1 As New OleDbCommand
        cn.Open()
        str1 = "select name from bird"
        cmd1 = New OleDbCommand(str1, cn)
        cmd1.ExecuteNonQuery()
        cn.Close()
        Dim da As New OleDbDataAdapter(cmd1)
        Dim dt As New DataTable
        da.Fill(dt)
        lbbird.DataSource = dt
        lbbird.DisplayMember = "name"
    End Sub




    Private Sub lbbird_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbbird.SelectedIndexChanged

        lbname.Text = lbbird.Text
        cn.Open()
        Dim cmd4 As New OleDbCommand("SELECT * FROM bird WHERE name = ?", cn)
        cmd4.Parameters.AddWithValue("@name", lbname.Text)
        Dim myreader As OleDbDataReader = cmd4.ExecuteReader()
        If myreader.Read Then
            tbvar.Text = myreader("varieties").ToString
            tbnut.Text = myreader("food").ToString
            tbplace.Text = myreader("place").ToString
            tbgt.Text = myreader("sc").ToString
            tbpath.Text = myreader("photo").ToString
            tbcolor.Text = myreader("color").ToString
            ShowImage(tbpath.Text)
        End If
        cn.Close()
    End Sub

    Private Sub lbfruit_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbfruit.SelectedIndexChanged

        lbname.Text = lbfruit.Text
        cn.Open()
        Dim cmd4 As New OleDbCommand("SELECT * FROM fruit WHERE name = ?", cn)
        cmd4.Parameters.AddWithValue("@name", lbname.Text)
        Dim myreader As OleDbDataReader = cmd4.ExecuteReader()
        If myreader.Read Then
            tbvar.Text = myreader("varieties").ToString
            tbnut.Text = myreader("nutrients").ToString
            tbplace.Text = myreader("place").ToString
            tbgt.Text = myreader("growtype").ToString
            tbpath.Text = myreader("photo").ToString
            tbcolor.Text = myreader("color").ToString
            ShowImage(tbpath.Text)
        End If
        cn.Close()
    End Sub

    Private Sub lbveg_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbveg.SelectedIndexChanged

        lbname.Text = lbveg.Text
        cn.Open()
        Dim cmd4 As New OleDbCommand("SELECT * FROM veg WHERE name = ?", cn)
        cmd4.Parameters.AddWithValue("@name", lbname.Text)
        Dim myreader As OleDbDataReader = cmd4.ExecuteReader()
        If myreader.Read Then
            tbvar.Text = myreader("varieties").ToString
            tbnut.Text = myreader("nutrients").ToString
            tbplace.Text = myreader("place").ToString
            tbgt.Text = myreader("growtype").ToString
            tbpath.Text = myreader("photo").ToString
            tbcolor.Text = myreader("color").ToString
            ShowImage(tbpath.Text)
        End If
        cn.Close()
    End Sub

    Private Sub lbanimal_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbanimal.SelectedIndexChanged

        lbname.Text = lbanimal.Text
        cn.Open()
        Dim cmd4 As New OleDbCommand("SELECT * FROM animal WHERE name = ?", cn)
        cmd4.Parameters.AddWithValue("@name", lbname.Text)
        Dim myreader As OleDbDataReader = cmd4.ExecuteReader()
        If myreader.Read Then
            tbvar.Text = myreader("varieties").ToString
            tbnut.Text = myreader("food").ToString
            tbplace.Text = myreader("place").ToString
            tbgt.Text = myreader("sc").ToString
            tbpath.Text = myreader("photo").ToString
            tbcolor.Text = myreader("color").ToString
            ShowImage(tbpath.Text)
        End If
        cn.Close()
    End Sub


End Class