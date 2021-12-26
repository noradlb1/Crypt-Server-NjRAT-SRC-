Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim R As New OpenFileDialog
        With R

            .Filter = "|*.exe"

            .ShowDialog()
        End With

        FlatTextBox1.Text = R.FileName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next

        If FlatCheckBox1.Checked Then

            Dim fox As String = Convert.ToBase64String(IO.File.ReadAllBytes(FlatTextBox1.Text))

            Dim fox1 As String = Class1.Rijndaelcrypt(fox, key.Text)

            Dim fox3 As String = My.Resources.RijndaelDecrypt
            Dim fox4 As String





            fox4 = fox3.Replace("%1%", xx(4)).Replace("%2%", fox1).Replace("%3%", xx(6)).Replace("%4%", xx(8)).Replace("%5%", xx(10)).Replace("%6%", xx(12)).Replace("%7%", xx(13)).Replace("%8%", key.Text)

            r1.Text = fox4





        End If

        If FlatCheckBox2.Checked Then

            Dim xxx() As Byte = Class1.MD5.Encrypt(IO.File.ReadAllBytes(FlatTextBox1.Text), key.Text)
            Dim xx1 As String = Convert.ToBase64String(xxx)

            Dim fox3 As String = My.Resources.MD5
            Dim fox4 As String

            fox4 = fox3.Replace("%1%", xx(4)).Replace("%2%", xx1).Replace("%3%", xx(6)).Replace("%4%", xx(8)).Replace("%5%", xx(10)).Replace("%6%", key.Text)

            r1.Text = fox4

        End If
        If FlatCheckBox3.Checked Then

            Dim xxx() As Byte = Class1.Md5Encrypt(IO.File.ReadAllBytes(FlatTextBox1.Text), key.Text)

            Dim xx1 As String = Convert.ToBase64String(xxx)




            Dim fox3 As String = My.Resources.MD51
            Dim fox4 As String

            fox4 = fox3.Replace("%1%", xx(4)).Replace("%2%", xx1).Replace("%3%", xx(6)).Replace("%4%", xx(8)).Replace("%5%", xx(10)).Replace("%8%", key.Text)

            r1.Text = fox4

        End If


        If FlatCheckBox4.Checked Then

            Dim xxx() As Byte = Class1.XOREncrypt(IO.File.ReadAllBytes(FlatTextBox1.Text), key.Text)

            Dim xx1 As String = Convert.ToBase64String(xxx)




            Dim fox3 As String = My.Resources._xor
            Dim fox4 As String

            fox4 = fox3.Replace("%1%", xx(4)).Replace("%2%", xx1).Replace("%3%", xx(6)).Replace("%4%", xx(8)).Replace("%5%", xx(10)).Replace("%8%", key.Text)

            r1.Text = fox4

        End If


        If FlatCheckBox5.Checked Then

            Dim xxx() As Byte = Class1.RC4Encrypt(IO.File.ReadAllBytes(FlatTextBox1.Text), key.Text)


            Dim xx1 As String = Convert.ToBase64String(xxx)




            Dim fox3 As String = My.Resources.RC4
            Dim fox4 As String

            fox4 = fox3.Replace("%1%", xx(4)).Replace("%2%", xx1).Replace("%3%", xx(6)).Replace("%4%", xx(8)).Replace("%5%", xx(10)).Replace("%8%", key.Text)

            r1.Text = fox4

        End If

    End Sub
    Public Function xx(ByVal len As Long)
        Dim rnd As New Random
        Dim arb As String = "АдресэлектроннойпоАдресэлектроннойпочтызащищенотспамботовдлягопросмотрауасдолженбытьвключенчтызащищенотспамботовдлягопросмотрауасдолженбытьвключенJavascript"
        Dim result As String = Nothing
        For i = 0 To len
            result = result & arb(rnd.Next(arb.Length))

        Next
        Return result
    End Function
    Public Function GEN(ByVal lenght As Integer) As String
        Randomize()
        Dim b() As Char
        Dim s As New System.Text.StringBuilder("")
        b = "ПрывітаннеяквыставіцесяЦівыдзевызнаходзіцесяЧамутамнебыловыспрабаваліпаехацьувыдаленыммесцыцівыненавідзіцеПадарожжы".ToCharArray()
        For i As Integer = 1 To lenght
            Randomize()
            Dim z As Integer = Int(((b.Length - 2) - 0 + 1) * Rnd()) + 1
            s.Append(b(z))
        Next
        Return s.ToString
    End Function
    Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New RijndaelManaged
        Dim Hash_AES As New MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = CipherMode.ECB
            Dim DESEncryptor As ICryptoTransform = AES.CreateEncryptor
            Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncryptor.TransformFinalBlock(buffer, 0, buffer.Length))

        Catch ex As Exception

        End Try
        Return encrypted
    End Function

    Private Sub key_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles key.MouseMove

        key.Text = GEN(FlatTrackBar1.Value)
    End Sub

    Private Sub FlatTrackBar1_Scroll(sender As Object, e As EventArgs) Handles FlatTrackBar1.Scroll

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sfd As New SaveFileDialog

        sfd.Filter = "Visual Basic File|*.vb"
        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            File.WriteAllText(sfd.FileName, r1.Text)
            MsgBox("Saved in : " & sfd.FileName, MsgBoxStyle.Information, "ok")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
