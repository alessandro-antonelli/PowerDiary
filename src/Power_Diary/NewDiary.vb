Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Power_Diary.My
Imports Power_Diary.My.Resources
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace Power_Diary
    <DesignerGenerated> _
    Public Class NewDiary
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            Me.InitializeComponent
        End Sub

        Private Sub CancelButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.NameLab = New Label
            Me.NameText = New TextBox
            Me.CancelButt = New Button
            Me.OwnerText = New TextBox
            Me.OwnerLab = New Label
            Me.InfoText = New TextBox
            Me.InfoLab = New Label
            Me.PhraseText = New TextBox
            Me.PhraseLab = New Label
            Me.Password1Lab = New Label
            Me.Password1Text = New TextBox
            Me.Password2Text = New TextBox
            Me.Password2Lab = New Label
            Me.PasswordGroup = New GroupBox
            Me.PasswordCheck = New CheckBox
            Me.OKButt = New Button
            Me.Mess2Lab = New Label
            Me.Mess1Lab = New Label
            Me.MessPict = New PictureBox
            Me.PasswordGroup.SuspendLayout
            DirectCast(Me.MessPict, ISupportInitialize).BeginInit
            Me.SuspendLayout
            Me.NameLab.AutoSize = True
            Dim point As New Point(12, 15)
            Me.NameLab.Location = point
            Me.NameLab.Name = "NameLab"
            Dim size As New Size(&H53, 13)
            Me.NameLab.Size = size
            Me.NameLab.TabIndex = 0
            Me.NameLab.Text = "Nome del diario:"
            Me.NameText.BackColor = Color.LightSalmon
            point = New Point(&H80, 12)
            Me.NameText.Location = point
            Me.NameText.Name = "NameText"
            size = New Size(&H162, 20)
            Me.NameText.Size = size
            Me.NameText.TabIndex = 1
            point = New Point(&H146, &H12F)
            Me.CancelButt.Location = point
            Me.CancelButt.Name = "CancelButt"
            size = New Size(&H4B, &H17)
            Me.CancelButt.Size = size
            Me.CancelButt.TabIndex = 3
            Me.CancelButt.Text = "&Annulla"
            Me.CancelButt.UseVisualStyleBackColor = True
            point = New Point(&H80, &H26)
            Me.OwnerText.Location = point
            Me.OwnerText.Name = "OwnerText"
            size = New Size(&H162, 20)
            Me.OwnerText.Size = size
            Me.OwnerText.TabIndex = 5
            Me.OwnerLab.AutoSize = True
            point = New Point(12, &H29)
            Me.OwnerLab.Location = point
            Me.OwnerLab.Name = "OwnerLab"
            size = New Size(110, 13)
            Me.OwnerLab.Size = size
            Me.OwnerLab.TabIndex = 4
            Me.OwnerLab.Text = "Nome del proprietario:"
            point = New Point(&H80, &H40)
            Me.InfoText.Location = point
            Me.InfoText.Name = "InfoText"
            size = New Size(&H162, 20)
            Me.InfoText.Size = size
            Me.InfoText.TabIndex = 7
            Me.InfoLab.AutoSize = True
            point = New Point(12, &H43)
            Me.InfoLab.Location = point
            Me.InfoLab.Name = "InfoLab"
            size = New Size(110, 13)
            Me.InfoLab.Size = size
            Me.InfoLab.TabIndex = 6
            Me.InfoLab.Text = "Descrizione del diario:"
            point = New Point(&H80, 90)
            Me.PhraseText.Location = point
            Me.PhraseText.Name = "PhraseText"
            size = New Size(&H162, 20)
            Me.PhraseText.Size = size
            Me.PhraseText.TabIndex = 9
            Me.PhraseLab.AutoSize = True
            point = New Point(12, &H5D)
            Me.PhraseLab.Location = point
            Me.PhraseLab.Name = "PhraseLab"
            size = New Size(&H55, 13)
            Me.PhraseLab.Size = size
            Me.PhraseLab.TabIndex = 8
            Me.PhraseLab.Text = "Frase personale:"
            Me.Password1Lab.AutoSize = True
            Me.Password1Lab.Enabled = False
            point = New Point(&H17, &H2D)
            Me.Password1Lab.Location = point
            Me.Password1Lab.Name = "Password1Lab"
            size = New Size(&H35, 13)
            Me.Password1Lab.Size = size
            Me.Password1Lab.TabIndex = 11
            Me.Password1Lab.Text = "Password"
            Me.Password1Text.Enabled = False
            point = New Point(&H81, &H2A)
            Me.Password1Text.Location = point
            Me.Password1Text.Name = "Password1Text"
            size = New Size(&H14F, 20)
            Me.Password1Text.Size = size
            Me.Password1Text.TabIndex = 12
            Me.Password2Text.Enabled = False
            point = New Point(&H81, &H44)
            Me.Password2Text.Location = point
            Me.Password2Text.Name = "Password2Text"
            size = New Size(&H14F, 20)
            Me.Password2Text.Size = size
            Me.Password2Text.TabIndex = 14
            Me.Password2Lab.AutoSize = True
            Me.Password2Lab.Enabled = False
            point = New Point(&H17, &H47)
            Me.Password2Lab.Location = point
            Me.Password2Lab.Name = "Password2Lab"
            size = New Size(100, 13)
            Me.Password2Lab.Size = size
            Me.Password2Lab.TabIndex = 13
            Me.Password2Lab.Text = "Conferma password"
            Me.PasswordGroup.Controls.Add(Me.PasswordCheck)
            Me.PasswordGroup.Controls.Add(Me.Password2Text)
            Me.PasswordGroup.Controls.Add(Me.Password1Lab)
            Me.PasswordGroup.Controls.Add(Me.Password2Lab)
            Me.PasswordGroup.Controls.Add(Me.Password1Text)
            point = New Point(12, &HC5)
            Me.PasswordGroup.Location = point
            Me.PasswordGroup.Name = "PasswordGroup"
            size = New Size(470, 100)
            Me.PasswordGroup.Size = size
            Me.PasswordGroup.TabIndex = 15
            Me.PasswordGroup.TabStop = False
            Me.PasswordGroup.Text = "Password"
            Me.PasswordCheck.AutoSize = True
            point = New Point(6, &H13)
            Me.PasswordCheck.Location = point
            Me.PasswordCheck.Name = "PasswordCheck"
            size = New Size(&HD7, &H11)
            Me.PasswordCheck.Size = size
            Me.PasswordCheck.TabIndex = 15
            Me.PasswordCheck.Text = "Imposta password per l'accesso al diario"
            Me.PasswordCheck.UseVisualStyleBackColor = True
            point = New Point(&H197, &H12F)
            Me.OKButt.Location = point
            Me.OKButt.Name = "OKButt"
            size = New Size(&H4B, &H17)
            Me.OKButt.Size = size
            Me.OKButt.TabIndex = &H11
            Me.OKButt.Text = "&OK"
            Me.OKButt.UseVisualStyleBackColor = True
            Me.Mess2Lab.AutoSize = True
            point = New Point(&H1C, &H9F)
            Me.Mess2Lab.Location = point
            size = New Size(420, 13)
            Me.Mess2Lab.MaximumSize = size
            Me.Mess2Lab.Name = "Mess2Lab"
            size = New Size(&HCC, 13)
            Me.Mess2Lab.Size = size
            Me.Mess2Lab.TabIndex = 20
            Me.Mess2Lab.Text = "È necessario inserire un nome per il diario."
            Me.Mess1Lab.AutoSize = True
            Me.Mess1Lab.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(&H1C, &H8E)
            Me.Mess1Lab.Location = point
            Me.Mess1Lab.Name = "Mess1Lab"
            size = New Size(&HCF, 13)
            Me.Mess1Lab.Size = size
            Me.Mess1Lab.TabIndex = &H13
            Me.Mess1Lab.Text = "Impossibile assegnare questo nome"
            Me.MessPict.Image = Resources.cancel1
            point = New Point(12, 140)
            Me.MessPict.Location = point
            Me.MessPict.Name = "MessPict"
            size = New Size(&H10, &H10)
            Me.MessPict.Size = size
            Me.MessPict.SizeMode = PictureBoxSizeMode.Zoom
            Me.MessPict.TabIndex = &H12
            Me.MessPict.TabStop = False
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H1EE, &H152)
            Me.ClientSize = size
            Me.Controls.Add(Me.Mess2Lab)
            Me.Controls.Add(Me.Mess1Lab)
            Me.Controls.Add(Me.MessPict)
            Me.Controls.Add(Me.OKButt)
            Me.Controls.Add(Me.PasswordGroup)
            Me.Controls.Add(Me.PhraseText)
            Me.Controls.Add(Me.PhraseLab)
            Me.Controls.Add(Me.InfoText)
            Me.Controls.Add(Me.InfoLab)
            Me.Controls.Add(Me.OwnerText)
            Me.Controls.Add(Me.OwnerLab)
            Me.Controls.Add(Me.CancelButt)
            Me.Controls.Add(Me.NameText)
            Me.Controls.Add(Me.NameLab)
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.Name = "NewDiary"
            Me.Text = "Nuovo diario"
            Me.PasswordGroup.ResumeLayout(False)
            Me.PasswordGroup.PerformLayout
            DirectCast(Me.MessPict, ISupportInitialize).EndInit
            Me.ResumeLayout(False)
            Me.PerformLayout
        End Sub

        Private Sub NameText_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.OKButt.Enabled = True
            Me.NameText.BackColor = Color.White
            Me.Mess1Lab.Visible = False
            Me.Mess2Lab.Visible = False
            Me.MessPict.Visible = False
            If (Me.NameText.Text = "") Then
                Me.NameText.BackColor = Color.LightSalmon
                Me.Mess2Lab.Text = "È necessario inserire un nome per il diario."
                Me.Mess1Lab.Visible = True
                Me.Mess2Lab.Visible = True
                Me.MessPict.Visible = True
                Me.OKButt.Enabled = False
            ElseIf MyProject.Computer.FileSystem.DirectoryExists((Application.StartupPath & "\Diaries\" & Me.NameText.Text)) Then
                Me.NameText.BackColor = Color.LightSalmon
                Me.Mess2Lab.Text = "Un diario con questo nome esiste già."
                Me.Mess1Lab.Visible = True
                Me.Mess2Lab.Visible = True
                Me.MessPict.Visible = True
                Me.OKButt.Enabled = False
            End If
        End Sub

        Private Sub OKButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Computer.FileSystem.CreateDirectory((Application.StartupPath & "\Diaries\" & Me.NameText.Text))
            Dim writer As New StreamWriter((Application.StartupPath & "\Diaries\" & Me.NameText.Text & "\Settings.txt"), False)
            writer.Write(Me.Password1Text.Text)
            writer.WriteLine
            writer.Write(Me.NameText.Text)
            writer.WriteLine
            writer.Write(Me.OwnerText.Text)
            writer.WriteLine
            writer.Write(Me.InfoText.Text)
            writer.WriteLine
            writer.Write(Me.PhraseText.Text)
            writer.WriteLine
            writer.Write(Strings.Format(MyProject.Computer.Clock.LocalTime, "dd/MM/yyyy"))
            writer.WriteLine
            writer.Write(Strings.Format(MyProject.Computer.Clock.LocalTime, "HH:mm:ss"))
            writer.Close
            MyProject.Forms.Main.Carica((Application.StartupPath & "\Diaries\" & Me.NameText.Text))
            Me.Close
        End Sub

        Private Sub Password1Text_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.Password2Text.BackColor = Color.White
            Me.OKButt.Enabled = True
            If (Me.Password2Text.Text <> Me.Password1Text.Text) Then
                Me.Password2Text.BackColor = Color.Orange
                Me.OKButt.Enabled = False
            End If
        End Sub

        Private Sub Password2Text_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.Password2Text.BackColor = Color.White
            Me.OKButt.Enabled = True
            If (Me.Password2Text.Text <> Me.Password1Text.Text) Then
                Me.Password2Text.BackColor = Color.Orange
                Me.OKButt.Enabled = False
            End If
        End Sub

        Private Sub PasswordCheck_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.Password1Lab.Enabled = Me.PasswordCheck.Checked
            Me.Password2Lab.Enabled = Me.PasswordCheck.Checked
            Me.Password1Text.Enabled = Me.PasswordCheck.Checked
            Me.Password2Text.Enabled = Me.PasswordCheck.Checked
        End Sub


        ' Properties
        Friend Overridable Property NameLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._NameLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._NameLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property NameText As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._NameText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                If (Not Me._NameText Is Nothing) Then
                    RemoveHandler Me._NameText.TextChanged, New EventHandler(AddressOf Me.NameText_TextChanged)
                End If
                Me._NameText = WithEventsValue
                If (Not Me._NameText Is Nothing) Then
                    AddHandler Me._NameText.TextChanged, New EventHandler(AddressOf Me.NameText_TextChanged)
                End If
            End Set
        End Property

        Friend Overridable Property Button1 As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._Button1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                Me._Button1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CancelButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._CancelButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._CancelButt Is Nothing) Then
                    RemoveHandler Me._CancelButt.Click, New EventHandler(AddressOf Me.CancelButt_Click)
                End If
                Me._CancelButt = WithEventsValue
                If (Not Me._CancelButt Is Nothing) Then
                    AddHandler Me._CancelButt.Click, New EventHandler(AddressOf Me.CancelButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property OwnerText As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._OwnerText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._OwnerText = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OwnerLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._OwnerLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._OwnerLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property InfoText As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._InfoText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._InfoText = WithEventsValue
            End Set
        End Property

        Friend Overridable Property InfoLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._InfoLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._InfoLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PhraseText As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PhraseText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._PhraseText = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PhraseLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._PhraseLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._PhraseLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CheckBox1 As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._CheckBox1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._CheckBox1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Password1Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Password1Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Password1Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Password1Text As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._Password1Text
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                If (Not Me._Password1Text Is Nothing) Then
                    RemoveHandler Me._Password1Text.TextChanged, New EventHandler(AddressOf Me.Password1Text_TextChanged)
                End If
                Me._Password1Text = WithEventsValue
                If (Not Me._Password1Text Is Nothing) Then
                    AddHandler Me._Password1Text.TextChanged, New EventHandler(AddressOf Me.Password1Text_TextChanged)
                End If
            End Set
        End Property

        Friend Overridable Property Password2Text As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._Password2Text
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                If (Not Me._Password2Text Is Nothing) Then
                    RemoveHandler Me._Password2Text.TextChanged, New EventHandler(AddressOf Me.Password2Text_TextChanged)
                End If
                Me._Password2Text = WithEventsValue
                If (Not Me._Password2Text Is Nothing) Then
                    AddHandler Me._Password2Text.TextChanged, New EventHandler(AddressOf Me.Password2Text_TextChanged)
                End If
            End Set
        End Property

        Friend Overridable Property PasswordGroup As GroupBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PasswordGroup
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._PasswordGroup = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Password2Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Password2Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Password2Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PasswordCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PasswordCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                If (Not Me._PasswordCheck Is Nothing) Then
                    RemoveHandler Me._PasswordCheck.CheckedChanged, New EventHandler(AddressOf Me.PasswordCheck_CheckedChanged)
                End If
                Me._PasswordCheck = WithEventsValue
                If (Not Me._PasswordCheck Is Nothing) Then
                    AddHandler Me._PasswordCheck.CheckedChanged, New EventHandler(AddressOf Me.PasswordCheck_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property OKButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._OKButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._OKButt Is Nothing) Then
                    RemoveHandler Me._OKButt.Click, New EventHandler(AddressOf Me.OKButt_Click)
                End If
                Me._OKButt = WithEventsValue
                If (Not Me._OKButt Is Nothing) Then
                    AddHandler Me._OKButt.Click, New EventHandler(AddressOf Me.OKButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property Mess2Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Mess2Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Mess2Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Mess1Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Mess1Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Mess1Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property MessPict As PictureBox
            <DebuggerNonUserCode> _
            Get
                Return Me._MessPict
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._MessPict = WithEventsValue
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("NameLab")> _
        Private _NameLab As Label
        <AccessedThroughProperty("NameText")> _
        Private _NameText As TextBox
        <AccessedThroughProperty("Button1")> _
        Private _Button1 As Button
        <AccessedThroughProperty("CancelButt")> _
        Private _CancelButt As Button
        <AccessedThroughProperty("OwnerText")> _
        Private _OwnerText As TextBox
        <AccessedThroughProperty("OwnerLab")> _
        Private _OwnerLab As Label
        <AccessedThroughProperty("InfoText")> _
        Private _InfoText As TextBox
        <AccessedThroughProperty("InfoLab")> _
        Private _InfoLab As Label
        <AccessedThroughProperty("PhraseText")> _
        Private _PhraseText As TextBox
        <AccessedThroughProperty("PhraseLab")> _
        Private _PhraseLab As Label
        <AccessedThroughProperty("CheckBox1")> _
        Private _CheckBox1 As CheckBox
        <AccessedThroughProperty("Password1Lab")> _
        Private _Password1Lab As Label
        <AccessedThroughProperty("Password1Text")> _
        Private _Password1Text As TextBox
        <AccessedThroughProperty("Password2Text")> _
        Private _Password2Text As TextBox
        <AccessedThroughProperty("PasswordGroup")> _
        Private _PasswordGroup As GroupBox
        <AccessedThroughProperty("Password2Lab")> _
        Private _Password2Lab As Label
        <AccessedThroughProperty("PasswordCheck")> _
        Private _PasswordCheck As CheckBox
        <AccessedThroughProperty("OKButt")> _
        Private _OKButt As Button
        <AccessedThroughProperty("Mess2Lab")> _
        Private _Mess2Lab As Label
        <AccessedThroughProperty("Mess1Lab")> _
        Private _Mess1Lab As Label
        <AccessedThroughProperty("MessPict")> _
        Private _MessPict As PictureBox
    End Class
End Namespace

