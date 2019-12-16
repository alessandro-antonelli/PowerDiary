Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace Power_Diary
    <DesignerGenerated> _
    Public Class Record
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            Me.InitializeComponent
        End Sub

        Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (Interaction.MsgBox("Vuoi uscire dalla finestra della registrazione senza salvare?", (MsgBoxStyle.Question Or MsgBoxStyle.YesNo), "Salvare?") = MsgBoxResult.Yes) Then
                Me.Close
            End If
        End Sub

        Private Sub Class_Initialize_Renamed()
            Me.xState = MyState.Idle
        End Sub

        Private Sub Class_Terminate_Renamed()
            Me.StopRecord
        End Sub

        Public Sub CloseRecord()
            Dim num As Integer = Record.mciSendString("close capture", CStr(Nothing), 0, 0)
            Me.xState = MyState.Idle
            Me.Timer1.Enabled = False
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Protected Overrides Sub Finalize()
            Me.Class_Terminate_Renamed
            MyBase.Finalize
        End Sub

        Private Sub GetSoundFormat()
            If (Me._SoundFormat = SoundFormats.Mono_6kbps_8_Bit) Then
                Me.lSamples = &H1770
                Me.lBits = 8
                Me.lChannels = 1
            ElseIf (Me._SoundFormat = SoundFormats.Mono_8kbps_8_Bit) Then
                Me.lSamples = &H1F40
                Me.lBits = 8
                Me.lChannels = 1
            ElseIf (Me._SoundFormat = SoundFormats.Mono_11kbps_8_Bit) Then
                Me.lSamples = &H2B11
                Me.lBits = 8
                Me.lChannels = 1
            ElseIf (Me._SoundFormat = SoundFormats.Mono_16kbps_8_Bit) Then
                Me.lSamples = &H3E80
                Me.lBits = 8
                Me.lChannels = 1
            ElseIf (Me._SoundFormat = SoundFormats.Mono_22kbps_8_Bit) Then
                Me.lSamples = &H5622
                Me.lBits = 8
                Me.lChannels = 1
            ElseIf (Me._SoundFormat = SoundFormats.Mono_32kbps_8_Bit) Then
                Me.lSamples = &H7D00
                Me.lBits = 8
                Me.lChannels = 1
            ElseIf (Me._SoundFormat = SoundFormats.Mono_44kbps_8_Bit) Then
                Me.lSamples = &HAC44
                Me.lBits = 8
                Me.lChannels = 1
            ElseIf (Me._SoundFormat = SoundFormats.Mono_48kbps_8_Bit) Then
                Me.lSamples = &HBB80
                Me.lBits = 8
                Me.lChannels = 1
            ElseIf (Me._SoundFormat = SoundFormats.Stereo_24kbps_16_Bit) Then
                Me.lSamples = &H1770
                Me.lBits = &H10
                Me.lChannels = 2
            ElseIf (Me._SoundFormat = SoundFormats.Stereo_32kbps_16_Bit) Then
                Me.lSamples = &H1F40
                Me.lBits = &H10
                Me.lChannels = 2
            ElseIf (Me._SoundFormat = SoundFormats.Stereo_44kbps_16_Bit) Then
                Me.lSamples = &H2B11
                Me.lBits = &H10
                Me.lChannels = 2
            ElseIf (Me._SoundFormat = SoundFormats.Stereo_64kbps_16_Bit) Then
                Me.lSamples = &H3E80
                Me.lBits = &H10
                Me.lChannels = 2
            ElseIf (Me._SoundFormat = SoundFormats.Stereo_88kbps_16_Bit) Then
                Me.lSamples = &H5622
                Me.lBits = &H10
                Me.lChannels = 2
            ElseIf (Me._SoundFormat = SoundFormats.Stereo_1288kbps_16_Bit) Then
                Me.lSamples = &H7D00
                Me.lBits = &H10
                Me.lChannels = 2
            ElseIf (Me._SoundFormat = SoundFormats.Stereo_176kbps_16_Bit) Then
                Me.lSamples = &HAC44
                Me.lBits = &H10
                Me.lChannels = 2
            ElseIf (Me._SoundFormat = SoundFormats.Stereo_192kbps_16_Bit) Then
                Me.lSamples = &HBB80
                Me.lBits = &H10
                Me.lChannels = 2
            End If
            Me.iBlockAlign = CShort(Math.Round(CDbl((CDbl((Me.lChannels * Me.lBits)) / 8))))
            Me.lBytesPerSec = (Me.lSamples * Me.iBlockAlign)
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Me.RecPaus = New Button
            Me.Button2 = New Button
            Me.Button3 = New Button
            Me.Button4 = New Button
            Me.ProgressBar1 = New ProgressBar
            Me.Label1 = New Label
            Me.Timer1 = New Timer(Me.components)
            Me.SuspendLayout
            Me.RecPaus.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            Dim point As New Point(12, &H51)
            Me.RecPaus.Location = point
            Me.RecPaus.Name = "RecPaus"
            Dim size As New Size(&H4B, &H17)
            Me.RecPaus.Size = size
            Me.RecPaus.TabIndex = 0
            Me.RecPaus.Text = "&Registra"
            Me.RecPaus.UseVisualStyleBackColor = True
            point = New Point(&HFF, &H51)
            Me.Button2.Location = point
            Me.Button2.Name = "Button2"
            size = New Size(&H4B, &H17)
            Me.Button2.Size = size
            Me.Button2.TabIndex = 1
            Me.Button2.Text = "&Annulla"
            Me.Button2.UseVisualStyleBackColor = True
            point = New Point(&HFF, &H34)
            Me.Button3.Location = point
            Me.Button3.Name = "Button3"
            size = New Size(&H4B, &H17)
            Me.Button3.Size = size
            Me.Button3.TabIndex = 2
            Me.Button3.Text = "&OK"
            Me.Button3.UseVisualStyleBackColor = True
            point = New Point(&H5D, &H51)
            Me.Button4.Location = point
            Me.Button4.Name = "Button4"
            size = New Size(&H4B, &H17)
            Me.Button4.Size = size
            Me.Button4.TabIndex = 3
            Me.Button4.Text = "&Stop"
            Me.Button4.UseVisualStyleBackColor = True
            point = New Point(&H54, 11)
            Me.ProgressBar1.Location = point
            Me.ProgressBar1.Name = "ProgressBar1"
            size = New Size(&HF6, &H17)
            Me.ProgressBar1.Size = size
            Me.ProgressBar1.TabIndex = 4
            Me.Label1.AutoSize = True
            point = New Point(12, 15)
            Me.Label1.Location = point
            Me.Label1.Name = "Label1"
            size = New Size(&H42, 13)
            Me.Label1.Size = size
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "Livello audio"
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H156, &H74)
            Me.ClientSize = size
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.ProgressBar1)
            Me.Controls.Add(Me.Button4)
            Me.Controls.Add(Me.Button3)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.RecPaus)
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.Name = "Registrazione"
            Me.Text = "Registrazione"
            Me.ResumeLayout(False)
            Me.PerformLayout
        End Sub

        <DllImport("winmm.dll", EntryPoint:="mciSendStringA", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
        Private Shared Function mciSendString(<MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpstrCommand As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
        End Function

        Public Function PauseRecord() As Boolean
            ' Invalid method body.
        End Function

        Public Function StartRecord() As Boolean
            ' Invalid method body.
        End Function

        Public Function StopRecord() As Boolean
            ' Invalid method body.
        End Function


        ' Properties
        Friend Overridable Property RecPaus As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._RecPaus
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                Me._RecPaus = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Button2 As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._Button2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._Button2 Is Nothing) Then
                    RemoveHandler Me._Button2.Click, New EventHandler(AddressOf Me.Button2_Click)
                End If
                Me._Button2 = WithEventsValue
                If (Not Me._Button2 Is Nothing) Then
                    AddHandler Me._Button2.Click, New EventHandler(AddressOf Me.Button2_Click)
                End If
            End Set
        End Property

        Friend Overridable Property Button3 As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._Button3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                Me._Button3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Button4 As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._Button4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                Me._Button4 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ProgressBar1 As ProgressBar
            <DebuggerNonUserCode> _
            Get
                Return Me._ProgressBar1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ProgressBar)
                Me._ProgressBar1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Label1 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Label1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Label1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Timer1 As Timer
            <DebuggerNonUserCode> _
            Get
                Return Me._Timer1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Timer)
                Me._Timer1 = WithEventsValue
            End Set
        End Property

        Public ReadOnly Property State As MyState
            Get
                Return Me.xState
            End Get
        End Property

        Public Property SoundFormat As SoundFormats
            Get
                Return Me._SoundFormat
            End Get
            Set(ByVal Value As SoundFormats)
                Me._SoundFormat = Value
            End Set
        End Property

        Public Property FileName As String
            Get
                Return Me.FName
            End Get
            Set(ByVal Value As String)
                Me.FName = Value
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("RecPaus")> _
        Private _RecPaus As Button
        <AccessedThroughProperty("Button2")> _
        Private _Button2 As Button
        <AccessedThroughProperty("Button3")> _
        Private _Button3 As Button
        <AccessedThroughProperty("Button4")> _
        Private _Button4 As Button
        <AccessedThroughProperty("ProgressBar1")> _
        Private _ProgressBar1 As ProgressBar
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label
        <AccessedThroughProperty("Timer1")> _
        Private _Timer1 As Timer
        Private lSamples As Integer
        Private lRet As Integer
        Private lBits As Integer
        Private lChannels As Integer
        Private iBlockAlign As Short
        Private lBytesPerSec As Integer
        Private xState As MyState
        Private _SoundFormat As SoundFormats
        Private FName As String

        ' Nested Types
        Public Enum MyState
            ' Fields
            Idle = 0
            Recording = 1
            Paused = 2
        End Enum

        Public Enum SoundFormats
            ' Fields
            Mono_6kbps_8_Bit = 0
            Mono_8kbps_8_Bit = 1
            Mono_11kbps_8_Bit = 2
            Mono_16kbps_8_Bit = 3
            Mono_22kbps_8_Bit = 4
            Mono_32kbps_8_Bit = 5
            Mono_44kbps_8_Bit = 6
            Mono_48kbps_8_Bit = 7
            Stereo_24kbps_16_Bit = 8
            Stereo_32kbps_16_Bit = 9
            Stereo_44kbps_16_Bit = 10
            Stereo_64kbps_16_Bit = 11
            Stereo_88kbps_16_Bit = 12
            Stereo_1288kbps_16_Bit = 13
            Stereo_176kbps_16_Bit = 14
            Stereo_192kbps_16_Bit = 15
        End Enum
    End Class
End Namespace

