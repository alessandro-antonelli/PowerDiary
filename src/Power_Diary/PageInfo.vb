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
    Public Class PageInfo
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            Me.InitializeComponent
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
            Me.OKButt = New Button
            Me.TableLayoutPanel1 = New TableLayoutPanel
            Me.TitleLab = New Label
            Me.Title2Lab = New Label
            Me.DateLab = New Label
            Me.Date2Lab = New Label
            Me.FeelLab = New Label
            Me.Feel2Lab = New Label
            Me.TableLayoutPanel1.SuspendLayout
            Me.SuspendLayout
            Me.OKButt.DialogResult = DialogResult.Cancel
            Dim point As New Point(&H101, &HB7)
            Me.OKButt.Location = point
            Me.OKButt.Name = "OKButt"
            Dim size As New Size(&H4B, &H17)
            Me.OKButt.Size = size
            Me.OKButt.TabIndex = 0
            Me.OKButt.Text = "&OK"
            Me.OKButt.UseVisualStyleBackColor = True
            Me.TableLayoutPanel1.ColumnCount = 2
            Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle)
            Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle)
            Me.TableLayoutPanel1.Controls.Add(Me.TitleLab, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.Title2Lab, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.DateLab, 0, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.Date2Lab, 1, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.FeelLab, 0, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.Feel2Lab, 1, 3)
            point = New Point(12, 12)
            Me.TableLayoutPanel1.Location = point
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 4
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20!))
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20!))
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20!))
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20!))
            size = New Size(320, &HA5)
            Me.TableLayoutPanel1.Size = size
            Me.TableLayoutPanel1.TabIndex = 1
            Me.TitleLab.AutoSize = True
            point = New Point(3, 0)
            Me.TitleLab.Location = point
            Me.TitleLab.Name = "TitleLab"
            size = New Size(&H21, 13)
            Me.TitleLab.Size = size
            Me.TitleLab.TabIndex = 0
            Me.TitleLab.Text = "Titolo"
            Me.Title2Lab.AutoSize = True
            Me.Title2Lab.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(&H2F, 0)
            Me.Title2Lab.Location = point
            Me.Title2Lab.Name = "Title2Lab"
            size = New Size(0, 13)
            Me.Title2Lab.Size = size
            Me.Title2Lab.TabIndex = 1
            Me.DateLab.AutoSize = True
            point = New Point(3, 13)
            Me.DateLab.Location = point
            Me.DateLab.Name = "DateLab"
            size = New Size(30, 13)
            Me.DateLab.Size = size
            Me.DateLab.TabIndex = 4
            Me.DateLab.Text = "Data"
            Me.Date2Lab.AutoSize = True
            point = New Point(&H2F, 13)
            Me.Date2Lab.Location = point
            Me.Date2Lab.Name = "Date2Lab"
            size = New Size(0, 13)
            Me.Date2Lab.Size = size
            Me.Date2Lab.TabIndex = 5
            Me.FeelLab.AutoSize = True
            point = New Point(3, &H1A)
            Me.FeelLab.Location = point
            Me.FeelLab.Name = "FeelLab"
            size = New Size(&H26, 13)
            Me.FeelLab.Size = size
            Me.FeelLab.TabIndex = 6
            Me.FeelLab.Text = "Umore"
            Me.Feel2Lab.AutoSize = True
            Me.Feel2Lab.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(&H2F, &H1A)
            Me.Feel2Lab.Location = point
            Me.Feel2Lab.Name = "Feel2Lab"
            size = New Size(0, 13)
            Me.Feel2Lab.Size = size
            Me.Feel2Lab.TabIndex = 7
            Me.AcceptButton = Me.OKButt
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.OKButt
            size = New Size(&H158, &HDA)
            Me.ClientSize = size
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Controls.Add(Me.OKButt)
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "PageInfo"
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.Text = "Informazioni sulla pagina"
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout
            Me.ResumeLayout(False)
        End Sub

        Public Sub LoadInfo(ByVal ID As Integer)
            Dim strArray As String() = New String() { Application.StartupPath, "\Diaries\", MyProject.Forms.Main.NomeLab.Text, "\", Conversions.ToString(ID), "\", Conversions.ToString(ID), ".txt" }
            Dim reader As New StreamReader(String.Concat(strArray))
            Me.Title2Lab.Text = reader.ReadLine
            Me.Feel2Lab.Text = reader.ReadLine
            Me.Date2Lab.Text = (reader.ReadLine & " | " & reader.ReadLine)
            reader.Close
            Dim text As String = Me.Feel2Lab.Text
            If ([text] = "Ottimo") Then
                Me.Feel2Lab.ForeColor = Color.Lime
            ElseIf ([text] = "Molto buono") Then
                Me.Feel2Lab.ForeColor = Color.LawnGreen
            ElseIf ([text] = "Buono") Then
                Me.Feel2Lab.ForeColor = Color.GreenYellow
            ElseIf ([text] = "Normale") Then
                Me.Feel2Lab.ForeColor = Color.Yellow
            ElseIf ([text] = "Mediocre") Then
                Me.Feel2Lab.ForeColor = Color.DarkOrange
            ElseIf ([text] = "Triste") Then
                Me.Feel2Lab.ForeColor = Color.IndianRed
            ElseIf ([text] = "Molto triste") Then
                Me.Feel2Lab.ForeColor = Color.DarkRed
            ElseIf ([text] = "Arrabbiato") Then
                Me.Feel2Lab.ForeColor = Color.DimGray
            ElseIf ([text] = "Molto arrabbiato") Then
                Me.Feel2Lab.ForeColor = Color.Black
            End If
        End Sub

        Private Sub OKButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close
        End Sub


        ' Properties
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

        Friend Overridable Property TitleLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._TitleLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._TitleLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Title2Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Title2Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Title2Lab = WithEventsValue
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

        Friend Overridable Property Date2Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Date2Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Date2Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property FeelLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._FeelLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._FeelLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Feel2Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Feel2Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Feel2Lab = WithEventsValue
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("OKButt")> _
        Private _OKButt As Button
        <AccessedThroughProperty("TableLayoutPanel1")> _
        Private _TableLayoutPanel1 As TableLayoutPanel
        <AccessedThroughProperty("TitleLab")> _
        Private _TitleLab As Label
        <AccessedThroughProperty("Title2Lab")> _
        Private _Title2Lab As Label
        <AccessedThroughProperty("DateLab")> _
        Private _DateLab As Label
        <AccessedThroughProperty("Date2Lab")> _
        Private _Date2Lab As Label
        <AccessedThroughProperty("FeelLab")> _
        Private _FeelLab As Label
        <AccessedThroughProperty("Feel2Lab")> _
        Private _Feel2Lab As Label
    End Class
End Namespace

