Imports System.Security.Cryptography
Imports System.Text

Public Class Class1


    Public Class MD5

        Public Shared Function Encrypt(ByVal bytData() As Byte, _
          ByVal sKey As String, _
        Optional ByVal tMode As CipherMode = CipherMode.ECB, _
        Optional ByVal tPadding As PaddingMode = PaddingMode.PKCS7) As Byte()
            Dim keyArray As Byte()

            Dim hashmd5 As New MD5CryptoServiceProvider()
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(sKey))
            hashmd5.Clear()

            Dim tdes As New TripleDESCryptoServiceProvider()
            tdes.Key = keyArray
            tdes.Mode = tMode
            tdes.Padding = tPadding

            Dim cTransform As ICryptoTransform = tdes.CreateEncryptor()
            Dim resultArray As Byte() = cTransform.TransformFinalBlock(bytData, 0, bytData.Length)
            tdes.Clear()
            Return resultArray
        End Function

        Public Shared Function Decrypt(ByVal bytData() As Byte, _
        ByVal sKey As String, _
          Optional ByVal tMode As CipherMode = CipherMode.ECB, _
          Optional ByVal tPadding As PaddingMode = PaddingMode.PKCS7) As Byte()
            Dim keyArray As Byte()
            Dim hashmd5 As New MD5CryptoServiceProvider()
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(sKey))
            hashmd5.Clear()

            Dim tdes As New TripleDESCryptoServiceProvider()
            tdes.Key = keyArray
            tdes.Mode = tMode
            tdes.Padding = tPadding

            Dim cTransform As ICryptoTransform = tdes.CreateDecryptor()
            Dim resultArray As Byte() = cTransform.TransformFinalBlock(bytData, 0, bytData.Length)
            tdes.Clear()
            Return resultArray
        End Function
        Public Shared Function Rijndaelcrypt(ByVal File As String, ByVal Key As String)
            Dim oAesProvider As New RijndaelManaged
            Dim btClear() As Byte
            Dim btSalt() As Byte = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}
            Dim oKeyGenerator As New Rfc2898DeriveBytes(Key, btSalt)
            oAesProvider.Key = oKeyGenerator.GetBytes(oAesProvider.Key.Length)
            oAesProvider.IV = oKeyGenerator.GetBytes(oAesProvider.IV.Length)
            Dim ms As New IO.MemoryStream
            Dim cs As New CryptoStream(ms, _
              oAesProvider.CreateEncryptor(), _
              CryptoStreamMode.Write)
            btClear = System.Text.Encoding.UTF8.GetBytes(File)
            cs.Write(btClear, 0, btClear.Length)
            cs.Close()
            File = Convert.ToBase64String(ms.ToArray)
            Return File
        End Function
        Public Shared Function Md5Encrypt(ByVal bytData() As Byte, ByVal sKey As String, Optional ByVal tMode As CipherMode = CipherMode.ECB, Optional ByVal tPadding As PaddingMode = PaddingMode.PKCS7) As Byte()
            Dim keyArray As Byte()

            Dim hashmd5 As New MD5CryptoServiceProvider()
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(sKey))
            hashmd5.Clear()

            Dim tdes As New TripleDESCryptoServiceProvider()
            tdes.Key = keyArray
            tdes.Mode = tMode
            tdes.Padding = tPadding

            Dim cTransform As ICryptoTransform = tdes.CreateEncryptor()
            Dim resultArray As Byte() = cTransform.TransformFinalBlock(bytData, 0, bytData.Length)
            tdes.Clear()
            Return resultArray
        End Function
    End Class
    Public Shared Function XOREncrypt(ByVal up As Byte(), ByVal BB2 As String) As Byte()
        Dim CL As Byte() = System.Text.Encoding.ASCII.GetBytes(BB2)
        Randomize()
        Dim FP As Integer = Int((255 - 0 + 1) * Rnd()) + 1
        Dim BA(up.Length) As Byte
        Dim KA As Integer
        For MP As Integer = 0 To up.Length - 1
            BA(MP) += (up(MP) Xor CL(KA)) Xor FP
            If KA = BB2.Length - 1 Then KA = 0 Else KA = KA + 1
        Next
        BA(up.Length) = 112 Xor FP
        Return BA
    End Function
    Public Shared Function RC4Encrypt(ByVal A6 As Byte(), ByVal A7 As String) As Byte()
        Dim A1 As Byte() = System.Text.Encoding.ASCII.GetBytes(A7)
        Dim A2, A3, A4 As UInteger
        Dim A5 As UInteger() = New UInteger(255) {}
        Dim A9 As Byte() = New Byte(A6.Length - 1) {}
        For A2 = 0 To 255
            A5(A2) = A2
        Next
        For A2 = 0 To 255
            A3 = (A3 + A1(A2 Mod A1.Length) + A5(A2)) And 255
            A4 = A5(A2)
            A5(A2) = A5(A3)
            A5(A3) = A4
        Next
        A2 = 0 : A3 = 0
        For A8 = 0 To A9.Length - 1
            A2 = (A2 + 1) And 255
            A3 = (A3 + A5(A2)) And 255
            A4 = A5(A2)
            A5(A2) = A5(A3)
            A5(A3) = A4
            A9(A8) = A6(A8) Xor A5((A5(A2) + A5(A3)) And 255)
        Next
        Return A9
    End Function
    Public Shared Function Rijndaelcrypt(ByVal File As String, ByVal Key As String)
        Dim oAesProvider As New RijndaelManaged
        Dim btClear() As Byte
        Dim btSalt() As Byte = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}
        Dim oKeyGenerator As New Rfc2898DeriveBytes(Key, btSalt)
        oAesProvider.Key = oKeyGenerator.GetBytes(oAesProvider.Key.Length)
        oAesProvider.IV = oKeyGenerator.GetBytes(oAesProvider.IV.Length)
        Dim ms As New IO.MemoryStream
        Dim cs As New CryptoStream(ms, _
          oAesProvider.CreateEncryptor(), _
          CryptoStreamMode.Write)
        btClear = System.Text.Encoding.UTF8.GetBytes(File)
        cs.Write(btClear, 0, btClear.Length)
        cs.Close()
        File = Convert.ToBase64String(ms.ToArray)
        Return File
    End Function
    Public Shared Function Md5Encrypt(ByVal bytData() As Byte, ByVal sKey As String, Optional ByVal tMode As CipherMode = CipherMode.ECB, Optional ByVal tPadding As PaddingMode = PaddingMode.PKCS7) As Byte()
        Dim keyArray As Byte()

        Dim hashmd5 As New MD5CryptoServiceProvider()
        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(sKey))
        hashmd5.Clear()

        Dim tdes As New TripleDESCryptoServiceProvider()
        tdes.Key = keyArray
        tdes.Mode = tMode
        tdes.Padding = tPadding

        Dim cTransform As ICryptoTransform = tdes.CreateEncryptor()
        Dim resultArray As Byte() = cTransform.TransformFinalBlock(bytData, 0, bytData.Length)
        tdes.Clear()
        Return resultArray
    End Function
   


    Public Function RC4decrypt(ByVal D1 As Byte(), ByVal D2 As String) As Byte()
        Dim D3 As Byte() = System.Text.Encoding.ASCII.GetBytes(D2)
        Dim D4, D5, D6 As UInteger
        Dim D7 As UInteger() = New UInteger(255) {}
        Dim D8 As Byte() = New Byte(D1.Length - 1) {}
        For D4 = 0 To 255
            D7(D4) = D4
        Next
        For D4 = 0 To 255
            D5 = (D5 + D3(D4 Mod D3.Length) + D7(D4)) And 255
            D6 = D7(D4)
            D7(D4) = D7(D5)
            D7(D5) = D6
        Next
        D4 = 0 : D5 = 0
        For D9 = 0 To D8.Length - 1
            D4 = (D4 + 1) And 255
            D5 = (D5 + D7(D4)) And 255
            D6 = D7(D4)
            D7(D4) = D7(D5)
            D7(D5) = D6
            D8(D9) = D1(D9) Xor D7((D7(D4) + D7(D5)) And 255)
        Next
        Return D8
    End Function
    Public Function XORDcrypt(ByVal BB As Byte(), ByVal CC As String) As Byte()
        Dim AA As Byte() = System.Text.Encoding.ASCII.GetBytes(CC)
        Dim OO As Integer = BB(BB.Length - 1) Xor 112
        Dim QQ(BB.Length) As Byte
        Dim JJ As Integer
        For GG As Integer = 0 To BB.Length - 1
            QQ(GG) = (BB(GG) Xor OO) Xor AA(JJ)
            If JJ = CC.Length - 1 Then JJ = 0 Else JJ = JJ + 1
        Next
        ReDim Preserve QQ(BB.Length - 2)
        Return QQ
    End Function

    Public Shared Function Md5Decrypt(ByVal bytData() As Byte, ByVal sKey As String, Optional ByVal tMode As CipherMode = CipherMode.ECB, Optional ByVal tPadding As PaddingMode = PaddingMode.PKCS7) As Byte()
        Dim keyArray As Byte()
        Dim hashmd5 As New MD5CryptoServiceProvider()
        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(sKey))
        hashmd5.Clear()

        Dim tdes As New TripleDESCryptoServiceProvider()
        tdes.Key = keyArray
        tdes.Mode = tMode
        tdes.Padding = tPadding

        Dim cTransform As ICryptoTransform = tdes.CreateDecryptor()
        Dim resultArray As Byte() = cTransform.TransformFinalBlock(bytData, 0, bytData.Length)
        tdes.Clear()
        Return resultArray
    End Function
    Public Shared Function RijndaelDecrypt(ByVal UDecryptU As String, ByVal UKeyU As String)
        Dim XoAesProviderX As New RijndaelManaged
        Dim XbtCipherX() As Byte
        Dim XbtSaltX() As Byte = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}
        Dim XoKeyGeneratorX As New Rfc2898DeriveBytes(UKeyU, XbtSaltX)
        XoAesProviderX.Key = XoKeyGeneratorX.GetBytes(XoAesProviderX.Key.Length)
        XoAesProviderX.IV = XoKeyGeneratorX.GetBytes(XoAesProviderX.IV.Length)
        Dim XmsX As New IO.MemoryStream
        Dim XcsX As New CryptoStream(XmsX, XoAesProviderX.CreateDecryptor(), _
          CryptoStreamMode.Write)
        Try
            XbtCipherX = Convert.FromBase64String(UDecryptU)
            XcsX.Write(XbtCipherX, 0, XbtCipherX.Length)
            XcsX.Close()
            UDecryptU = System.Text.Encoding.UTF8.GetString(XmsX.ToArray)
        Catch
        End Try
        Return UDecryptU
    End Function
End Class
