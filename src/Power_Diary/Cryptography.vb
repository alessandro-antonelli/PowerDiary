Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Power_Diary.My
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Security.Cryptography
Imports System.Windows.Forms

Namespace Power_Diary
    <DesignerGenerated> _
    Public Class Cryptography
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            Me.InitializeComponent
        End Sub

        Public Function CreateIV(ByVal Password As String) As Byte()
            Dim chArray As Char() = Password.ToCharArray
            Dim buffer As Byte() = New Byte((chArray.GetUpperBound(0) + 1)  - 1) {}
            Dim upperBound As Integer = chArray.GetUpperBound(0)
            Dim i As Integer = 0
            Do While (i <= upperBound)
                buffer(i) = CByte(Strings.Asc(chArray(i)))
                i += 1
            Loop
            Dim buffer4 As Byte() = New SHA512Managed().ComputeHash(buffer)
            Dim buffer2 As Byte() = New Byte(&H10  - 1) {}
            Dim index As Integer = &H20
            Do While True
                buffer2((index - &H20)) = buffer4(index)
                index += 1
                If (index > &H2F) Then
                    Return buffer2
                End If
            Loop
        End Function

        Public Function CreateKey(ByVal Password As String) As Byte()
            Dim chArray As Char() = Password.ToCharArray
            Dim buffer As Byte() = New Byte((chArray.GetUpperBound(0) + 1)  - 1) {}
            Dim upperBound As Integer = chArray.GetUpperBound(0)
            Dim i As Integer = 0
            Do While (i <= upperBound)
                buffer(i) = CByte(Strings.Asc(chArray(i)))
                i += 1
            Loop
            Dim buffer4 As Byte() = New SHA512Managed().ComputeHash(buffer)
            Dim buffer2 As Byte() = New Byte(&H20  - 1) {}
            Dim index As Integer = 0
            Do While True
                buffer2(index) = buffer4(index)
                index += 1
                If (index > &H1F) Then
                    Return buffer2
                End If
            Loop
        End Function

        Public Sub Decrypt(ByVal InputPath As String, ByVal InputName As String, ByVal Password As String, ByVal Replace As Boolean, ByVal OutputPath As String)
            If Replace Then
                OutputPath = (InputPath & "\TempFileName")
            End If
            Dim stream2 As New FileStream((InputPath & "\" & InputName), FileMode.Open, FileAccess.Read)
            Dim stream As New FileStream(OutputPath, FileMode.OpenOrCreate, FileAccess.Write)
            stream.SetLength(0)
            Dim buffer As Byte() = New Byte(&H1001  - 1) {}
            Dim length As Long = stream2.Length
            New CryptoStream(stream, New RijndaelManaged().CreateDecryptor(Me.CreateKey(Password), Me.CreateIV(Password)), CryptoStreamMode.Write).Close
            stream2.Close
            stream.Close
            If Replace Then
                MyProject.Computer.FileSystem.DeleteFile((InputPath & "\" & InputName))
                MyProject.Computer.FileSystem.RenameFile(OutputPath, InputName)
            End If
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Public Sub Encrypt(ByVal InputPath As String, ByVal InputName As String, ByVal Password As String, ByVal Replace As Boolean, ByVal OutputPath As String)
            If Replace Then
                OutputPath = (InputPath & "\TempFileName")
            End If
            Dim stream2 As New FileStream((InputPath & "\" & InputName), FileMode.Open, FileAccess.Read)
            Dim stream As New FileStream(OutputPath, FileMode.OpenOrCreate, FileAccess.Write)
            stream.SetLength(0)
            Dim buffer As Byte() = New Byte(&H1001  - 1) {}
            Dim length As Long = stream2.Length
            New CryptoStream(stream, New RijndaelManaged().CreateEncryptor(Me.CreateKey(Password), Me.CreateIV(Password)), CryptoStreamMode.Write).Close
            stream2.Close
            stream.Close
            If Replace Then
                MyProject.Computer.FileSystem.DeleteFile((InputPath & "\" & InputName))
                MyProject.Computer.FileSystem.RenameFile(OutputPath, InputName)
            End If
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.SuspendLayout
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            Dim size As New Size(&HAC, &H2E)
            Me.ClientSize = size
            Me.Name = "Cryptography"
            Me.Text = "Encrypt"
            Me.ResumeLayout(False)
        End Sub


        ' Fields
        Private components As IContainer
    End Class
End Namespace

