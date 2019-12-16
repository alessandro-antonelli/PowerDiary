Imports Microsoft.VisualBasic.CompilerServices
Imports Power_Diary.My
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace Power_Diary
    <DesignerGenerated> _
    Public Class DiaryInfo
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.DiaryInfo_Load)
            Me.InitializeComponent
        End Sub

        Private Sub CloseButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close
        End Sub

        Private Sub DiaryInfo_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.PathText.Text = (Application.StartupPath & "\Diaries\" & MyProject.Forms.Main.NomeLab.Text)
            Dim reader As New StreamReader((Application.StartupPath & "\Diaries\" & MyProject.Forms.Main.NomeLab.Text & "\Settings.txt"))
            Me.PasswordText.Text = If((reader.ReadLine <> ""), "Sì", "No")
            Me.NameText.Text = reader.ReadLine
            Me.Text = ("Informazioni su " & Me.NameText.Text)
            Me.OwnerText.Text = reader.ReadLine
            Me.InfoText.Text = reader.ReadLine
            Me.PhraseText.Text = reader.ReadLine
            Me.DateText.Text = (reader.ReadLine & " | " & reader.ReadLine)
            reader.Close
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
            Me.TableLayoutPanel1 = New TableLayoutPanel
            Me.InfoText = New Label
            Me.PhraseLab = New Label
            Me.NameLab = New Label
            Me.NameText = New Label
            Me.OwnerLab = New Label
            Me.OwnerText = New Label
            Me.PasswordLab = New Label
            Me.DateLab = New Label
            Me.PasswordText = New Label
            Me.PathLab = New Label
            Me.DateText = New Label
            Me.PathText = New LinkLabel
            Me.InfoLab = New Label
            Me.PhraseText = New Label
            Me.CloseButt = New Button
            Me.TableLayoutPanel1.SuspendLayout
            Me.SuspendLayout
            Me.TableLayoutPanel1.ColumnCount = 2
            Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle)
            Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle)
            Me.TableLayoutPanel1.Controls.Add(Me.InfoText, 1, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.PhraseLab, 0, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.NameLab, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.NameText, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.OwnerLab, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.OwnerText, 1, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.PasswordLab, 0, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.DateLab, 0, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.PasswordText, 1, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.PathLab, 0, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.DateText, 1, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.PathText, 1, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.InfoLab, 0, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.PhraseText, 1, 3)
            Dim point As New Point(12, 12)
            Me.TableLayoutPanel1.Location = point
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 7
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20!))
            Dim size As New Size(320, &H73)
            Me.TableLayoutPanel1.Size = size
            Me.TableLayoutPanel1.TabIndex = &H12
            Me.InfoText.AutoSize = True
            point = New Point(&H7E, &H1A)
            Me.InfoText.Location = point
            Me.InfoText.Name = "InfoText"
            size = New Size(&H10, 13)
            Me.InfoText.Size = size
            Me.InfoText.TabIndex = 20
            Me.InfoText.Text = "---"
            Me.PhraseLab.AutoSize = True
            point = New Point(3, &H27)
            Me.PhraseLab.Location = point
            Me.PhraseLab.Name = "PhraseLab"
            size = New Size(&H55, 13)
            Me.PhraseLab.Size = size
            Me.PhraseLab.TabIndex = &H13
            Me.PhraseLab.Text = "Frase personale:"
            Me.NameLab.AutoSize = True
            point = New Point(3, 0)
            Me.NameLab.Location = point
            Me.NameLab.Name = "NameLab"
            size = New Size(&H23, 13)
            Me.NameLab.Size = size
            Me.NameLab.TabIndex = 0
            Me.NameLab.Text = "Nome"
            Me.NameText.AutoSize = True
            Me.NameText.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(&H7E, 0)
            Me.NameText.Location = point
            Me.NameText.Name = "NameText"
            size = New Size(&HBB, 13)
            Me.NameText.Size = size
            Me.NameText.TabIndex = 1
            Me.NameText.Text = "Non è stato aperto alcun diario."
            Me.OwnerLab.AutoSize = True
            point = New Point(3, 13)
            Me.OwnerLab.Location = point
            Me.OwnerLab.Name = "OwnerLab"
            size = New Size(&H6B, 13)
            Me.OwnerLab.Size = size
            Me.OwnerLab.TabIndex = 2
            Me.OwnerLab.Text = "Nome del proprietario"
            Me.OwnerText.AutoSize = True
            point = New Point(&H7E, 13)
            Me.OwnerText.Location = point
            Me.OwnerText.Name = "OwnerText"
            size = New Size(&H10, 13)
            Me.OwnerText.Size = size
            Me.OwnerText.TabIndex = 3
            Me.OwnerText.Text = "---"
            Me.PasswordLab.AutoSize = True
            point = New Point(3, &H4E)
            Me.PasswordLab.Location = point
            Me.PasswordLab.Name = "PasswordLab"
            size = New Size(&H35, 13)
            Me.PasswordLab.Size = size
            Me.PasswordLab.TabIndex = 6
            Me.PasswordLab.Text = "Password"
            Me.DateLab.AutoSize = True
            point = New Point(3, &H41)
            Me.DateLab.Location = point
            Me.DateLab.Name = "DateLab"
            size = New Size(&H68, 13)
            Me.DateLab.Size = size
            Me.DateLab.TabIndex = 12
            Me.DateLab.Text = "Data della creazione"
            Me.PasswordText.AutoSize = True
            point = New Point(&H7E, &H4E)
            Me.PasswordText.Location = point
            Me.PasswordText.Name = "PasswordText"
            size = New Size(&H10, 13)
            Me.PasswordText.Size = size
            Me.PasswordText.TabIndex = 7
            Me.PasswordText.Text = "---"
            Me.PathLab.AutoSize = True
            point = New Point(3, &H34)
            Me.PathLab.Location = point
            Me.PathLab.Name = "PathLab"
            size = New Size(&H75, 13)
            Me.PathLab.Size = size
            Me.PathLab.TabIndex = 10
            Me.PathLab.Text = "Locazione dei file diario"
            Me.DateText.AutoSize = True
            point = New Point(&H7E, &H41)
            Me.DateText.Location = point
            Me.DateText.Name = "DateText"
            size = New Size(&H21, 13)
            Me.DateText.Size = size
            Me.DateText.TabIndex = 13
            Me.DateText.Text = "--- | ---"
            Me.PathText.AutoSize = True
            point = New Point(&H7E, &H34)
            Me.PathText.Location = point
            size = New Size(&HC3, &H1A)
            Me.PathText.MaximumSize = size
            Me.PathText.Name = "PathText"
            size = New Size(&H10, 13)
            Me.PathText.Size = size
            Me.PathText.TabIndex = 15
            Me.PathText.TabStop = True
            Me.PathText.Text = "---"
            Me.InfoLab.AutoSize = True
            point = New Point(3, &H1A)
            Me.InfoLab.Location = point
            Me.InfoLab.Name = "InfoLab"
            size = New Size(110, 13)
            Me.InfoLab.Size = size
            Me.InfoLab.TabIndex = 4
            Me.InfoLab.Text = "Informazioni sul diario:"
            Me.PhraseText.AutoSize = True
            Me.PhraseText.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Italic, GraphicsUnit.Point, 0)
            point = New Point(&H7E, &H27)
            Me.PhraseText.Location = point
            size = New Size(&HC5, &H27)
            Me.PhraseText.MaximumSize = size
            Me.PhraseText.Name = "PhraseText"
            size = New Size(&H10, 13)
            Me.PhraseText.Size = size
            Me.PhraseText.TabIndex = 5
            Me.PhraseText.Text = "---"
            Me.CloseButt.DialogResult = DialogResult.Cancel
            point = New Point(&H101, &H85)
            Me.CloseButt.Location = point
            Me.CloseButt.Name = "CloseButt"
            size = New Size(&H4B, &H17)
            Me.CloseButt.Size = size
            Me.CloseButt.TabIndex = &H13
            Me.CloseButt.Text = "&Chiudi"
            Me.CloseButt.UseVisualStyleBackColor = True
            Me.AcceptButton = Me.CloseButt
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.CloseButt
            size = New Size(&H158, &HA8)
            Me.ClientSize = size
            Me.Controls.Add(Me.CloseButt)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "DiaryInfo"
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.Text = "Informazioni su "
            Me.TopMost = True
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout
            Me.ResumeLayout(False)
        End Sub

        Private Sub PathText_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs)
            Process.Start(Me.PathText.Text)
        End Sub


        ' Properties
        Friend Overridable Property TableLayoutPanel1 As TableLayoutPanel
            <DebuggerNonUserCode> _
            Get
                Return Me._TableLayoutPanel1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TableLayoutPanel)
                Me._TableLayoutPanel1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property InfoText As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._InfoText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._InfoText = WithEventsValue
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

        Friend Overridable Property NameText As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._NameText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._NameText = WithEventsValue
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

        Friend Overridable Property OwnerText As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._OwnerText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._OwnerText = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PasswordLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._PasswordLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._PasswordLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DateLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._DateLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._DateLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PasswordText As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._PasswordText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._PasswordText = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PathLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._PathLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._PathLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DateText As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._DateText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._DateText = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PathText As LinkLabel
            <DebuggerNonUserCode> _
            Get
                Return Me._PathText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As LinkLabel)
                If (Not Me._PathText Is Nothing) Then
                    RemoveHandler Me._PathText.LinkClicked, New LinkLabelLinkClickedEventHandler(AddressOf Me.PathText_LinkClicked)
                End If
                Me._PathText = WithEventsValue
                If (Not Me._PathText Is Nothing) Then
                    AddHandler Me._PathText.LinkClicked, New LinkLabelLinkClickedEventHandler(AddressOf Me.PathText_LinkClicked)
                End If
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

        Friend Overridable Property PhraseText As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._PhraseText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._PhraseText = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CloseButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._CloseButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._CloseButt Is Nothing) Then
                    RemoveHandler Me._CloseButt.Click, New EventHandler(AddressOf Me.CloseButt_Click)
                End If
                Me._CloseButt = WithEventsValue
                If (Not Me._CloseButt Is Nothing) Then
                    AddHandler Me._CloseButt.Click, New EventHandler(AddressOf Me.CloseButt_Click)
                End If
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("TableLayoutPanel1")> _
        Private _TableLayoutPanel1 As TableLayoutPanel
        <AccessedThroughProperty("InfoText")> _
        Private _InfoText As Label
        <AccessedThroughProperty("PhraseLab")> _
        Private _PhraseLab As Label
        <AccessedThroughProperty("NameLab")> _
        Private _NameLab As Label
        <AccessedThroughProperty("NameText")> _
        Private _NameText As Label
        <AccessedThroughProperty("OwnerLab")> _
        Private _OwnerLab As Label
        <AccessedThroughProperty("OwnerText")> _
        Private _OwnerText As Label
        <AccessedThroughProperty("PasswordLab")> _
        Private _PasswordLab As Label
        <AccessedThroughProperty("DateLab")> _
        Private _DateLab As Label
        <AccessedThroughProperty("PasswordText")> _
        Private _PasswordText As Label
        <AccessedThroughProperty("PathLab")> _
        Private _PathLab As Label
        <AccessedThroughProperty("DateText")> _
        Private _DateText As Label
        <AccessedThroughProperty("PathText")> _
        Private _PathText As LinkLabel
        <AccessedThroughProperty("InfoLab")> _
        Private _InfoLab As Label
        <AccessedThroughProperty("PhraseText")> _
        Private _PhraseText As Label
        <AccessedThroughProperty("CloseButt")> _
        Private _CloseButt As Button
    End Class
End Namespace

