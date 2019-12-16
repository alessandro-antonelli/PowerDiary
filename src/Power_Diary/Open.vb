Imports Microsoft.VisualBasic.CompilerServices
Imports Power_Diary.My
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace Power_Diary
    <DesignerGenerated> _
    Public Class Open
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            Me.InitializeComponent
        End Sub

        Private Sub CancelButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close
        End Sub

        Private Sub DiariesView_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            If (Me.OpenMode = 0) Then
                MyProject.Forms.Main.Carica(Me.DiariesView.SelectedItems(0).Name)
                Me.Close
            End If
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
            Me.CancelButt = New Button
            Me.DiariesView = New ListView
            Me.NameCol = New ColumnHeader
            Me.OwnerCol = New ColumnHeader
            Me.PasswordCol = New ColumnHeader
            Me.InfoCol = New ColumnHeader
            Me.SuspendLayout
            Me.OKButt.Anchor = (AnchorStyles.Right Or AnchorStyles.Bottom)
            Dim point As New Point(&H197, &HB7)
            Me.OKButt.Location = point
            Me.OKButt.Name = "OKButt"
            Dim size As New Size(&H4B, &H17)
            Me.OKButt.Size = size
            Me.OKButt.TabIndex = 0
            Me.OKButt.Text = "&OK"
            Me.OKButt.UseVisualStyleBackColor = True
            Me.CancelButt.Anchor = (AnchorStyles.Right Or AnchorStyles.Bottom)
            Me.CancelButt.DialogResult = DialogResult.Cancel
            point = New Point(&H146, &HB7)
            Me.CancelButt.Location = point
            Me.CancelButt.Name = "CancelButt"
            size = New Size(&H4B, &H17)
            Me.CancelButt.Size = size
            Me.CancelButt.TabIndex = 1
            Me.CancelButt.Text = "&Annulla"
            Me.CancelButt.UseVisualStyleBackColor = True
            Me.DiariesView.AllowColumnReorder = True
            Me.DiariesView.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or (AnchorStyles.Bottom Or AnchorStyles.Top)))
            Dim values As ColumnHeader() = New ColumnHeader() { Me.NameCol, Me.OwnerCol, Me.PasswordCol, Me.InfoCol }
            Me.DiariesView.Columns.AddRange(values)
            Me.DiariesView.FullRowSelect = True
            Me.DiariesView.HideSelection = False
            point = New Point(12, 12)
            Me.DiariesView.Location = point
            Me.DiariesView.MultiSelect = False
            Me.DiariesView.Name = "DiariesView"
            Me.DiariesView.ShowGroups = False
            size = New Size(470, &HA5)
            Me.DiariesView.Size = size
            Me.DiariesView.Sorting = SortOrder.Ascending
            Me.DiariesView.TabIndex = &H19
            Me.DiariesView.UseCompatibleStateImageBehavior = False
            Me.DiariesView.View = View.Details
            Me.NameCol.Text = "Nome"
            Me.NameCol.Width = &H81
            Me.OwnerCol.Text = "Proprietario"
            Me.OwnerCol.Width = &H56
            Me.PasswordCol.Text = "Password"
            Me.PasswordCol.Width = &H3F
            Me.InfoCol.Text = "Descrizione"
            Me.InfoCol.Width = &H9A
            Me.AcceptButton = Me.OKButt
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.CancelButt
            size = New Size(&H1EE, &HDA)
            Me.ClientSize = size
            Me.Controls.Add(Me.DiariesView)
            Me.Controls.Add(Me.CancelButt)
            Me.Controls.Add(Me.OKButt)
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.Name = "Open"
            Me.ShowIcon = False
            Me.Text = "Apri diario"
            Me.ResumeLayout(False)
        End Sub

        Public Sub LoadOpen(ByVal Optional Mode As Byte = 0)
            Me.OpenMode = Mode
            Dim num2 As Short = CShort((MyProject.Computer.FileSystem.GetDirectories((Application.StartupPath & "\Diaries")).Count - 1))
            Dim i As Short = 0
            Do While (i <= num2)
                Try 
                    Dim str As String = MyProject.Computer.FileSystem.GetDirectories((Application.StartupPath & "\Diaries"))(i)
                    Dim item2 As New ListViewItem
                    item2.Name = str
                    Dim item3 As New ListViewSubItem
                    Dim item4 As New ListViewSubItem
                    Dim item As New ListViewSubItem
                    Dim reader As New StreamReader((str & "\Settings.txt"))
                    item4.Text = If((reader.ReadLine <> ""), "Sì", "No")
                    item2.Text = reader.ReadLine
                    item3.Text = reader.ReadLine
                    item.Text = reader.ReadLine
                    reader.Close
                    item2.SubItems.Add(item3)
                    item2.SubItems.Add(item4)
                    item2.SubItems.Add(item)
                    Me.DiariesView.Items.Add(item2)
                Catch exception1 As Exception
                    Dim ex As Exception = exception1
                    ProjectData.SetProjectError(ex)
                    Dim exception As Exception = ex
                    Dim item6 As New ListViewItem
                    item6.Text = "Diario danneggiato"
                    Dim item7 As New ListViewSubItem
                    Dim item8 As New ListViewSubItem
                    Dim item5 As New ListViewSubItem
                    item6.SubItems.Add(item7)
                    item6.SubItems.Add(item8)
                    item6.SubItems.Add(item5)
                    Me.DiariesView.Items.Add(item6)
                    ProjectData.ClearProjectError
                End Try
                Select Case Me.OpenMode
                    Case 1
                        Me.DiariesView.CheckBoxes = True
                        Me.Text = "Seleziona i diari da esportare"
                        Exit Select
                    Case 2
                        Me.Text = "Seleziona il diario da aprire automaticamente"
                        Exit Select
                    Case Else
                        Exit Select
                End Select
                i = CShort((i + 1))
            Loop
        End Sub

        Private Sub OKButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Select Case Me.OpenMode
                Case 0
                    If (Me.DiariesView.SelectedItems.Count = 0) Then
                        Return
                    End If
                    MyProject.Forms.Main.Carica(Me.DiariesView.SelectedItems(0).Name)
                    Me.Close
                    Exit Select
                Case 1
                    Dim num3 As Short = CShort((Me.DiariesView.Items.Count - 1))
                    Dim num As Short = 0
                    Do While True
                        If (num > num3) Then
                            Me.Close
                            Exit Do
                        End If
                        If Me.DiariesView.Items(num).Checked Then
                            MyProject.Forms.IOSettings.ExpDiariesList.Add(Me.DiariesView.Items(num).Name)
                        End If
                        num = CShort((num + 1))
                    Loop
                    Exit Select
                Case 2
                    If (Me.DiariesView.SelectedItems.Count = 0) Then
                        Return
                    End If
                    MyProject.Forms.Settings.AutoLoadText.Text = Me.DiariesView.SelectedItems(0).Name
                    Me.Close
                    Exit Select
                Case Else
                    Exit Select
            End Select
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

        Friend Overridable Property DiariesView As ListView
            <DebuggerNonUserCode> _
            Get
                Return Me._DiariesView
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ListView)
                If (Not Me._DiariesView Is Nothing) Then
                    RemoveHandler Me._DiariesView.DoubleClick, New EventHandler(AddressOf Me.DiariesView_DoubleClick)
                End If
                Me._DiariesView = WithEventsValue
                If (Not Me._DiariesView Is Nothing) Then
                    AddHandler Me._DiariesView.DoubleClick, New EventHandler(AddressOf Me.DiariesView_DoubleClick)
                End If
            End Set
        End Property

        Friend Overridable Property NameCol As ColumnHeader
            <DebuggerNonUserCode> _
            Get
                Return Me._NameCol
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ColumnHeader)
                Me._NameCol = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OwnerCol As ColumnHeader
            <DebuggerNonUserCode> _
            Get
                Return Me._OwnerCol
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ColumnHeader)
                Me._OwnerCol = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PasswordCol As ColumnHeader
            <DebuggerNonUserCode> _
            Get
                Return Me._PasswordCol
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ColumnHeader)
                Me._PasswordCol = WithEventsValue
            End Set
        End Property

        Friend Overridable Property InfoCol As ColumnHeader
            <DebuggerNonUserCode> _
            Get
                Return Me._InfoCol
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ColumnHeader)
                Me._InfoCol = WithEventsValue
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("OKButt")> _
        Private _OKButt As Button
        <AccessedThroughProperty("CancelButt")> _
        Private _CancelButt As Button
        <AccessedThroughProperty("DiariesView")> _
        Private _DiariesView As ListView
        <AccessedThroughProperty("NameCol")> _
        Private _NameCol As ColumnHeader
        <AccessedThroughProperty("OwnerCol")> _
        Private _OwnerCol As ColumnHeader
        <AccessedThroughProperty("PasswordCol")> _
        Private _PasswordCol As ColumnHeader
        <AccessedThroughProperty("InfoCol")> _
        Private _InfoCol As ColumnHeader
        Private OpenMode As Byte
    End Class
End Namespace

