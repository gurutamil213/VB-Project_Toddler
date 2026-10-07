Imports System.IO
Imports System.Data.OleDb

Public Class Edit_form
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

    Private Function StoreSelectedImage(ByVal selectedFile As String) As String
        Dim photosFolder As String = Path.Combine(Application.StartupPath, "photos")
        Directory.CreateDirectory(photosFolder)

        Dim fileName As String = Path.GetFileName(selectedFile)
        Dim destinationPath As String = Path.Combine(photosFolder, fileName)
        If File.Exists(destinationPath) Then
            File.Delete(destinationPath)
        End If

        File.Copy(selectedFile, destinationPath, True)
        Return Path.Combine("photos", fileName)
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

    Private Sub Form4_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        dashboard.Visible = True
        MaximizeBox = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using img1 As OpenFileDialog = New OpenFileDialog

            img1.Filter = "choose image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

            If img1.ShowDialog() = DialogResult.OK Then
                tbpath.Text = StoreSelectedImage(img1.FileName)
                ShowImage(tbpath.Text)
            End If
        End Using
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tbname.Text = ""
        tbcolor.Text = ""
        tbnut.Text = ""
        tbpath.Text = ""
        tbplace.Text = ""
        tbvar.Text = ""
        tbsc.Text = ""
        cbgt.SelectedItem = Nothing
        PictureBox1.Image = Nothing


    End Sub

    Private Sub cbcatalog_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbcatalog.SelectedIndexChanged
        tbname.Text = ""
        tbcolor.Text = ""
        tbnut.Text = ""
        tbpath.Text = ""
        tbplace.Text = ""
        tbvar.Text = ""
        tbsc.Text = ""
        cbgt.SelectedItem = Nothing
        PictureBox1.Image = Nothing

        If cbcatalog.SelectedIndex = 0 Then
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
            lbitems.DataSource = dt
            lbitems.DisplayMember = "name"
        ElseIf cbcatalog.SelectedIndex = 1 Then
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
            lbitems.DataSource = dt
            lbitems.DisplayMember = "name"
        ElseIf cbcatalog.SelectedIndex = 2 Then
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
            lbitems.DataSource = dt
            lbitems.DisplayMember = "name"
        ElseIf cbcatalog.SelectedIndex = 3 Then
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
            lbitems.DataSource = dt
            lbitems.DisplayMember = "name"
        Else
            gbfruit.Visible = False
        End If


        If cbcatalog.SelectedIndex = 0 Then
            tbsc.Visible = False
            cbgt.Visible = True
            gbfruit.Visible = True
            l3.Text = "Nutrients"
            l5.Text = "Grow type"

        ElseIf cbcatalog.SelectedIndex = 1 Then
            tbsc.Visible = False
            cbgt.Visible = True
            gbfruit.Visible = True
            l3.Text = "Nutrients"
            l5.Text = "Grow type"

        ElseIf cbcatalog.SelectedIndex = 2 Then
            cbgt.Visible = False
            gbfruit.Visible = True
            tbsc.Visible = True
            l3.Text = "Food"
            l5.Text = "Spcial Characters"

        ElseIf cbcatalog.SelectedIndex = 3 Then
            cbgt.Visible = False
            gbfruit.Visible = True
            tbsc.Visible = True
            l3.Text = "Food"
            l5.Text = "Spcial Characters"

        Else
            gbfruit.Visible = False
        End If
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gbfruit.Visible = False

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If cbcatalog.SelectedIndex = 0 Then
            cn.Open()
            Dim cmd As New OleDbCommand("INSERT INTO fruit (name, varieties, nutrients, place, growtype, photo, color) VALUES (?, ?, ?, ?, ?, ?, ?)", cn)
            cmd.Parameters.AddWithValue("name", tbname.Text)
            cmd.Parameters.AddWithValue("varieties", tbvar.Text)
            cmd.Parameters.AddWithValue("nutrients", tbnut.Text)
            cmd.Parameters.AddWithValue("place", tbplace.Text)
            cmd.Parameters.AddWithValue("growtype", cbgt.Text)
            cmd.Parameters.AddWithValue("photo", tbpath.Text)
            cmd.Parameters.AddWithValue("color", tbcolor.Text)
            cmd.ExecuteNonQuery()
            MsgBox("added")
            cn.Close()
        ElseIf cbcatalog.SelectedIndex = 1 Then
            cn.Open()
            Dim cmd As New OleDbCommand("INSERT INTO veg (name, varieties, nutrients, place, growtype, photo, color) VALUES (?, ?, ?, ?, ?, ?, ?)", cn)
            cmd.Parameters.AddWithValue("name", tbname.Text)
            cmd.Parameters.AddWithValue("varieties", tbvar.Text)
            cmd.Parameters.AddWithValue("nutrients", tbnut.Text)
            cmd.Parameters.AddWithValue("place", tbplace.Text)
            cmd.Parameters.AddWithValue("growtype", cbgt.Text)
            cmd.Parameters.AddWithValue("photo", tbpath.Text)
            cmd.Parameters.AddWithValue("color", tbcolor.Text)
            cmd.ExecuteNonQuery()
            MsgBox("added")
            cn.Close()
        ElseIf cbcatalog.SelectedIndex = 2 Then
            cn.Open()
            Dim cmd As New OleDbCommand("INSERT INTO animal (name, varieties, food, place, sc, photo, color) VALUES (?, ?, ?, ?, ?, ?, ?)", cn)
            cmd.Parameters.AddWithValue("name", tbname.Text)
            cmd.Parameters.AddWithValue("varieties", tbvar.Text)
            cmd.Parameters.AddWithValue("food", tbnut.Text)
            cmd.Parameters.AddWithValue("place", tbplace.Text)
            cmd.Parameters.AddWithValue("sc", tbsc.Text)
            cmd.Parameters.AddWithValue("photo", tbpath.Text)
            cmd.Parameters.AddWithValue("color", tbcolor.Text)
            cmd.ExecuteNonQuery()
            MsgBox("added")
            cn.Close()

        ElseIf cbcatalog.SelectedIndex = 3 Then
            cn.Open()
            Dim cmd As New OleDbCommand("INSERT INTO bird (name, varieties, food, place, sc, photo, color) VALUES (?, ?, ?, ?, ?, ?, ?)", cn)
            cmd.Parameters.AddWithValue("name", tbname.Text)
            cmd.Parameters.AddWithValue("varieties", tbvar.Text)
            cmd.Parameters.AddWithValue("food", tbnut.Text)
            cmd.Parameters.AddWithValue("place", tbplace.Text)
            cmd.Parameters.AddWithValue("sc", tbsc.Text)
            cmd.Parameters.AddWithValue("photo", tbpath.Text)
            cmd.Parameters.AddWithValue("color", tbcolor.Text)
            cmd.ExecuteNonQuery()
            MsgBox("added")
            cn.Close()
        End If
    End Sub



    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim itemName As String = tbname.Text.Trim()

        If cbcatalog.SelectedIndex = 0 Then
            cn.Open()
            Dim cmd2 As New OleDbCommand("DELETE FROM fruit WHERE name = ?", cn)
            cmd2.Parameters.AddWithValue("name", itemName)
            cmd2.ExecuteNonQuery()
            MsgBox("Deleted")
            cn.Close()

        ElseIf cbcatalog.SelectedIndex = 1 Then
            cn.Open()
            Dim cmd2 As New OleDbCommand("DELETE FROM veg WHERE name = ?", cn)
            cmd2.Parameters.AddWithValue("name", itemName)
            cmd2.ExecuteNonQuery()
            MsgBox("Deleted")
            cn.Close()

        ElseIf cbcatalog.SelectedIndex = 2 Then
            cn.Open()
            Dim cmd2 As New OleDbCommand("DELETE FROM animal WHERE name = ?", cn)
            cmd2.Parameters.AddWithValue("name", itemName)
            cmd2.ExecuteNonQuery()
            MsgBox("Deleted")
            cn.Close()

        ElseIf cbcatalog.SelectedIndex = 3 Then
            cn.Open()
            Dim cmd2 As New OleDbCommand("DELETE FROM bird WHERE name = ?", cn)
            cmd2.Parameters.AddWithValue("name", itemName)
            cmd2.ExecuteNonQuery()
            MsgBox("Deleted")
            cn.Close()

        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            rbvar.Visible = True
            rbnut.Visible = True
            rbplace.Visible = True
            rbgt.Visible = True
            rbcolor.Visible = True
            rbpath.Visible = True
        Else
            rbvar.Visible = False
            rbnut.Visible = False
            rbplace.Visible = False
            rbgt.Visible = False
            rbcolor.Visible = False
            rbpath.Visible = False
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim itemName As String = tbname.Text.Trim()
        Dim tableName As String = String.Empty
        Dim fieldName As String = String.Empty
        Dim fieldValue As Object = Nothing

        If cbcatalog.SelectedIndex = 0 Then
            tableName = "fruit"
            If rbvar.Checked Then
                fieldName = "varieties"
                fieldValue = tbvar.Text
            ElseIf rbnut.Checked Then
                fieldName = "nutrients"
                fieldValue = tbnut.Text
            ElseIf rbplace.Checked Then
                fieldName = "place"
                fieldValue = tbplace.Text
            ElseIf rbgt.Checked Then
                fieldName = "growtype"
                fieldValue = cbgt.Text
            ElseIf rbpath.Checked Then
                fieldName = "photo"
                fieldValue = tbpath.Text
            ElseIf rbcolor.Checked Then
                fieldName = "color"
                fieldValue = tbcolor.Text
            Else
                MsgBox("select what you want change..")
                Return
            End If
        ElseIf cbcatalog.SelectedIndex = 1 Then
            tableName = "veg"
            If rbvar.Checked Then
                fieldName = "varieties"
                fieldValue = tbvar.Text
            ElseIf rbnut.Checked Then
                fieldName = "nutrients"
                fieldValue = tbnut.Text
            ElseIf rbplace.Checked Then
                fieldName = "place"
                fieldValue = tbplace.Text
            ElseIf rbgt.Checked Then
                fieldName = "growtype"
                fieldValue = cbgt.Text
            ElseIf rbpath.Checked Then
                fieldName = "photo"
                fieldValue = tbpath.Text
            ElseIf rbcolor.Checked Then
                fieldName = "color"
                fieldValue = tbcolor.Text
            Else
                MsgBox("select what you want change..")
                Return
            End If
        ElseIf cbcatalog.SelectedIndex = 2 Then
            tableName = "animal"
            If rbvar.Checked Then
                fieldName = "varieties"
                fieldValue = tbvar.Text
            ElseIf rbnut.Checked Then
                fieldName = "food"
                fieldValue = tbnut.Text
            ElseIf rbplace.Checked Then
                fieldName = "place"
                fieldValue = tbplace.Text
            ElseIf rbgt.Checked Then
                fieldName = "sc"
                fieldValue = cbgt.Text
            ElseIf rbpath.Checked Then
                fieldName = "photo"
                fieldValue = tbpath.Text
            ElseIf rbcolor.Checked Then
                fieldName = "color"
                fieldValue = tbcolor.Text
            Else
                MsgBox("select what you want change..")
                Return
            End If
        ElseIf cbcatalog.SelectedIndex = 3 Then
            tableName = "bird"
            If rbvar.Checked Then
                fieldName = "varieties"
                fieldValue = tbvar.Text
            ElseIf rbnut.Checked Then
                fieldName = "food"
                fieldValue = tbnut.Text
            ElseIf rbplace.Checked Then
                fieldName = "place"
                fieldValue = tbplace.Text
            ElseIf rbgt.Checked Then
                fieldName = "sc"
                fieldValue = cbgt.Text
            ElseIf rbpath.Checked Then
                fieldName = "photo"
                fieldValue = tbpath.Text
            ElseIf rbcolor.Checked Then
                fieldName = "color"
                fieldValue = tbcolor.Text
            Else
                MsgBox("select what you want change..")
                Return
            End If
        Else
            Return
        End If

        Dim query As String = String.Empty
        Select Case tableName
            Case "fruit"
                Select Case fieldName
                    Case "varieties"
                        query = "UPDATE fruit SET varieties = ? WHERE name = ?"
                    Case "nutrients"
                        query = "UPDATE fruit SET nutrients = ? WHERE name = ?"
                    Case "place"
                        query = "UPDATE fruit SET place = ? WHERE name = ?"
                    Case "growtype"
                        query = "UPDATE fruit SET growtype = ? WHERE name = ?"
                    Case "photo"
                        query = "UPDATE fruit SET photo = ? WHERE name = ?"
                    Case "color"
                        query = "UPDATE fruit SET color = ? WHERE name = ?"
                    Case Else
                        MsgBox("invalid field selected")
                        Return
                End Select
            Case "veg"
                Select Case fieldName
                    Case "varieties"
                        query = "UPDATE veg SET varieties = ? WHERE name = ?"
                    Case "nutrients"
                        query = "UPDATE veg SET nutrients = ? WHERE name = ?"
                    Case "place"
                        query = "UPDATE veg SET place = ? WHERE name = ?"
                    Case "growtype"
                        query = "UPDATE veg SET growtype = ? WHERE name = ?"
                    Case "photo"
                        query = "UPDATE veg SET photo = ? WHERE name = ?"
                    Case "color"
                        query = "UPDATE veg SET color = ? WHERE name = ?"
                    Case Else
                        MsgBox("invalid field selected")
                        Return
                End Select
            Case "animal"
                Select Case fieldName
                    Case "varieties"
                        query = "UPDATE animal SET varieties = ? WHERE name = ?"
                    Case "food"
                        query = "UPDATE animal SET food = ? WHERE name = ?"
                    Case "place"
                        query = "UPDATE animal SET place = ? WHERE name = ?"
                    Case "sc"
                        query = "UPDATE animal SET sc = ? WHERE name = ?"
                    Case "photo"
                        query = "UPDATE animal SET photo = ? WHERE name = ?"
                    Case "color"
                        query = "UPDATE animal SET color = ? WHERE name = ?"
                    Case Else
                        MsgBox("invalid field selected")
                        Return
                End Select
            Case "bird"
                Select Case fieldName
                    Case "varieties"
                        query = "UPDATE bird SET varieties = ? WHERE name = ?"
                    Case "food"
                        query = "UPDATE bird SET food = ? WHERE name = ?"
                    Case "place"
                        query = "UPDATE bird SET place = ? WHERE name = ?"
                    Case "sc"
                        query = "UPDATE bird SET sc = ? WHERE name = ?"
                    Case "photo"
                        query = "UPDATE bird SET photo = ? WHERE name = ?"
                    Case "color"
                        query = "UPDATE bird SET color = ? WHERE name = ?"
                    Case Else
                        MsgBox("invalid field selected")
                        Return
                End Select
            Case Else
                MsgBox("invalid table selected")
                Return
        End Select

        cn.Open()
        Dim cmd3 As New OleDbCommand(query, cn)
        cmd3.Parameters.AddWithValue("value", fieldValue)
        cmd3.Parameters.AddWithValue("name", itemName)
        cmd3.ExecuteNonQuery()
        MsgBox("updated")
        cn.Close()
    End Sub

    Private Sub lbitems_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbitems.Click
        If cbcatalog.SelectedIndex = 0 Then
            tbname.Text = lbitems.Text
            cn.Open()
            Dim cmd4 As New OleDbCommand("SELECT * FROM fruit WHERE name = ?", cn)
            cmd4.Parameters.AddWithValue("name", tbname.Text)
            Dim myreader As OleDbDataReader = cmd4.ExecuteReader()
            If myreader.Read Then
                tbvar.Text = myreader("varieties").ToString
                tbnut.Text = myreader("nutrients").ToString
                tbplace.Text = myreader("place").ToString
                cbgt.SelectedItem = myreader("growtype").ToString
                tbpath.Text = myreader("photo").ToString
                tbcolor.Text = myreader("color").ToString
                ShowImage(tbpath.Text)
            End If
            cn.Close()

        ElseIf cbcatalog.SelectedIndex = 1 Then
            tbname.Text = lbitems.Text
            cn.Open()
            Dim cmd4 As New OleDbCommand("SELECT * FROM veg WHERE name = ?", cn)
            cmd4.Parameters.AddWithValue("name", tbname.Text)
            Dim myreader As OleDbDataReader = cmd4.ExecuteReader()
            If myreader.Read Then
                tbvar.Text = myreader("varieties").ToString
                tbnut.Text = myreader("nutrients").ToString
                tbplace.Text = myreader("place").ToString
                cbgt.SelectedItem = myreader("growtype").ToString
                tbpath.Text = myreader("photo").ToString
                tbcolor.Text = myreader("color").ToString
                ShowImage(tbpath.Text)
            End If
            cn.Close()

        ElseIf cbcatalog.SelectedIndex = 2 Then
            tbname.Text = lbitems.Text
            cn.Open()
            Dim cmd4 As New OleDbCommand("SELECT * FROM animal WHERE name = ?", cn)
            cmd4.Parameters.AddWithValue("name", tbname.Text)
            Dim myreader As OleDbDataReader = cmd4.ExecuteReader()
            If myreader.Read Then
                tbvar.Text = myreader("varieties").ToString
                tbnut.Text = myreader("food").ToString
                tbplace.Text = myreader("place").ToString
                tbsc.Text = myreader("sc").ToString
                tbpath.Text = myreader("photo").ToString
                tbcolor.Text = myreader("color").ToString
                ShowImage(tbpath.Text)
            End If
            cn.Close()

        ElseIf cbcatalog.SelectedIndex = 3 Then
            tbname.Text = lbitems.Text
            cn.Open()
            Dim cmd4 As New OleDbCommand("SELECT * FROM bird WHERE name = ?", cn)
            cmd4.Parameters.AddWithValue("name", tbname.Text)
            Dim myreader As OleDbDataReader = cmd4.ExecuteReader()
            If myreader.Read Then
                tbvar.Text = myreader("varieties").ToString
                tbnut.Text = myreader("food").ToString
                tbplace.Text = myreader("place").ToString
                tbsc.Text = myreader("sc").ToString
                tbpath.Text = myreader("photo").ToString
                tbcolor.Text = myreader("color").ToString
                ShowImage(tbpath.Text)
            End If
            cn.Close()

        End If



    End Sub





    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class