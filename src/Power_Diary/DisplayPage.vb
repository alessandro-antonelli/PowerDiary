Imports Microsoft.DirectX.AudioVideoPlayback
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
    Public Class DisplayPage
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            AddHandler MyBase.FormClosed, New FormClosedEventHandler(AddressOf Me.VisualizzaPagina_FormClosed)
            Me.InitializeComponent
        End Sub

        Public Sub Carica(ByVal ID As Integer)
            Me.Play.Enabled = False
            Me.Stopp.Enabled = False
            Me.ImagePict.Image = Me.ImagePict.InitialImage
            Me.PreviousPageButt.Enabled = True
            Me.NextPageButt.Enabled = True
            Me.FilesView.Items.Clear
            Me.PageID = ID
            Dim strArray As String() = New String() { Application.StartupPath, "\Diaries\", MyProject.Forms.Main.NomeLab.Text, "\", Conversions.ToString(ID), "\" }
            Me.Path = String.Concat(strArray)
            Dim reader As New StreamReader((Me.Path & Conversions.ToString(ID) & ".txt"))
            Me.TitleLab.Text = reader.ReadLine
            Me.Text = (Me.TitleLab.Text & " - Power Diary")
            reader.ReadLine
            Me.DateLab.Text = (reader.ReadLine & " | " & reader.ReadLine)
            Me.TestoText.Text = reader.ReadToEnd
            reader.Close
            Me.Page1Text.Text = Conversions.ToString(ID)
            Me.Page2Lab.Text = Conversions.ToString(MyProject.Forms.Main.PagineList.Items.Count)
            Dim num3 As Integer = (MyProject.Computer.FileSystem.GetFiles(Me.Path).Count - 1)
            Dim i As Integer = 0
            Do While (i <= num3)
                Dim name As String = MyProject.Computer.FileSystem.GetFileInfo(MyProject.Computer.FileSystem.GetFiles(Me.Path)(i)).Name
                Dim startIndex As Short = CShort(name.LastIndexOfAny(Conversions.ToCharArrayRankOne(".")))
                Dim str3 As String = If((startIndex >= 1), name.Remove(startIndex, (name.Length - startIndex)), name)
                If (str3 = "Audio") Then
                    Me.Play.Enabled = True
                ElseIf (str3 = "Image") Then
                    Me.ImagePict.ImageLocation = MyProject.Computer.FileSystem.GetFiles(Me.Path)(i)
                ElseIf ((str3 = "File 1") OrElse ((str3 = "File 2") OrElse ((str3 = "File 3") OrElse ((str3 = "File 4") OrElse ((str3 = "File 5") OrElse ((str3 = "File 6") OrElse ((str3 = "File 7") OrElse ((str3 = "File 8") OrElse ((str3 = "File 9") OrElse (str3 = "File 10")))))))))) Then
                    Dim item As New ListViewItem
                    item.ImageIndex = 0
                    item.Name = MyProject.Computer.FileSystem.GetFiles(Me.Path)(i)
                    item.Text = name
                    Me.FilesView.Items.Add(item)
                End If
                i += 1
            Loop
            If (Conversions.ToDouble(Me.Page1Text.Text) = 1) Then
                Me.PreviousPageButt.Enabled = False
            End If
            If (Me.Page1Text.Text = Me.Page2Lab.Text) Then
                Me.NextPageButt.Enabled = False
            End If
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub FilesView_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            If (Me.FilesView.SelectedItems.Count <> 0) Then
                Process.Start(Me.FilesView.SelectedItems(0).Name)
            End If
        End Sub

        Private Sub ImagePict_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            If (MyProject.Computer.FileSystem.FileExists((Me.Path & "Image.jpg")) Or MyProject.Computer.FileSystem.FileExists((Me.Path & "Image.jpeg"))) Then
                Process.Start((Me.Path & "Image.jpg"))
            End If
            If MyProject.Computer.FileSystem.FileExists((Me.Path & "Image.bmp")) Then
                Process.Start((Me.Path & "Image.bmp"))
            End If
            If MyProject.Computer.FileSystem.FileExists((Me.Path & "Image.png")) Then
                Process.Start((Me.Path & "Image.png"))
            End If
            If MyProject.Computer.FileSystem.FileExists((Me.Path & "Image.gif")) Then
                Process.Start((Me.Path & "Image.gif"))
            End If
            If MyProject.Computer.FileSystem.FileExists((Me.Path & "Image.wmf")) Then
                Process.Start((Me.Path & "Image.wmf"))
            End If
            If MyProject.Computer.FileSystem.FileExists((Me.Path & "Image.emf")) Then
                Process.Start((Me.Path & "Image.emf"))
            End If
            If MyProject.Computer.FileSystem.FileExists((Me.Path & "Image.ico")) Then
                Process.Start((Me.Path & "Image.ico"))
            End If
            If MyProject.Computer.FileSystem.FileExists((Me.Path & "Image.cur")) Then
                Process.Start((Me.Path & "Image.cur"))
            End If
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Dim manager As New ComponentResourceManager(GetType(DisplayPage))
            Me.MainToolStrip = New ToolStrip
            Me.PageLab = New ToolStripLabel
            Me.Page1Text = New ToolStripTextBox
            Me.OfLab = New ToolStripLabel
            Me.Page2Lab = New ToolStripLabel
            Me.Separator = New ToolStripSeparator
            Me.ToolStripSeparator1 = New ToolStripSeparator
            Me.TitleLab = New ToolStripLabel
            Me.DateLab = New ToolStripLabel
            Me.TestoText = New TextBox
            Me.FilesView = New ListView
            Me.FilesImageList = New ImageList(Me.components)
            Me.ImagePict = New PictureBox
            Me.PreviousPageButt = New ToolStripButton
            Me.NextPageButt = New ToolStripButton
            Me.Play = New ToolStripButton
            Me.Stopp = New ToolStripButton
            Me.PageInfoButt = New ToolStripButton
            Me.MainToolStrip.SuspendLayout
            DirectCast(Me.ImagePict, ISupportInitialize).BeginInit
            Me.SuspendLayout
            Me.MainToolStrip.GripStyle = ToolStripGripStyle.Hidden
            Dim size As New Size(&H18, &H18)
            Me.MainToolStrip.ImageScalingSize = size
            Dim toolStripItems As ToolStripItem() = New ToolStripItem() { Me.PageLab, Me.Page1Text, Me.OfLab, Me.Page2Lab, Me.PreviousPageButt, Me.NextPageButt, Me.Separator, Me.Play, Me.Stopp }
            toolStripItems(9) = Me.PageInfoButt
            toolStripItems(10) = Me.ToolStripSeparator1
            toolStripItems(11) = Me.DateLab
            toolStripItems(12) = Me.TitleLab
            Me.MainToolStrip.Items.AddRange(toolStripItems)
            Dim point As New Point(0, 0)
            Me.MainToolStrip.Location = point
            Me.MainToolStrip.Name = "MainToolStrip"
            size = New Size(&H278, &H1F)
            Me.MainToolStrip.Size = size
            Me.MainToolStrip.TabIndex = 10
            Me.PageLab.Name = "PageLab"
            size = New Size(&H27, &H1C)
            Me.PageLab.Size = size
            Me.PageLab.Text = "Pagina"
            Me.Page1Text.Name = "Page1Text"
            size = New Size(&H19, &H1F)
            Me.Page1Text.Size = size
            Me.Page1Text.Text = "0"
            Me.Page1Text.TextBoxTextAlign = HorizontalAlignment.Center
            Me.OfLab.Name = "OfLab"
            size = New Size(15, &H1C)
            Me.OfLab.Size = size
            Me.OfLab.Text = "di"
            Me.Page2Lab.Name = "Page2Lab"
            size = New Size(13, &H1C)
            Me.Page2Lab.Size = size
            Me.Page2Lab.Text = "0"
            Me.Separator.Name = "Separator"
            size = New Size(6, &H1F)
            Me.Separator.Size = size
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            size = New Size(6, &H1F)
            Me.ToolStripSeparator1.Size = size
            Me.TitleLab.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            Me.TitleLab.Name = "TitleLab"
            size = New Size(&H27, &H1C)
            Me.TitleLab.Size = size
            Me.TitleLab.Text = "Titolo"
            Me.DateLab.Name = "DateLab"
            size = New Size(&H65, &H1C)
            Me.DateLab.Size = size
            Me.DateLab.Text = "10/07/2008 | 10:42"
            Me.TestoText.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or (AnchorStyles.Bottom Or AnchorStyles.Top)))
            Me.TestoText.BackColor = MySettings.Default.BackColor
            Me.TestoText.DataBindings.Add(New Binding("Font", MySettings.Default, "Font", True, DataSourceUpdateMode.OnPropertyChanged))
            Me.TestoText.DataBindings.Add(New Binding("BackColor", MySettings.Default, "BackColor", True, DataSourceUpdateMode.OnPropertyChanged))
            Me.TestoText.Font = MySettings.Default.Font
            point = New Point(12, &H22)
            Me.TestoText.Location = point
            Me.TestoText.Multiline = True
            Me.TestoText.Name = "TestoText"
            Me.TestoText.ReadOnly = True
            Me.TestoText.ScrollBars = ScrollBars.Vertical
            size = New Size(&H260, &H12A)
            Me.TestoText.Size = size
            Me.TestoText.TabIndex = &H44
            Me.FilesView.Anchor = (AnchorStyles.Right Or AnchorStyles.Bottom)
            Me.FilesView.FullRowSelect = True
            Me.FilesView.LargeImageList = Me.FilesImageList
            point = New Point(460, &H152)
            Me.FilesView.Location = point
            Me.FilesView.MultiSelect = False
            Me.FilesView.Name = "FilesView"
            size = New Size(160, &H60)
            Me.FilesView.Size = size
            Me.FilesView.SmallImageList = Me.FilesImageList
            Me.FilesView.Sorting = SortOrder.Descending
            Me.FilesView.TabIndex = &H24
            Me.FilesView.UseCompatibleStateImageBehavior = False
            Me.FilesView.View = View.List
            Me.FilesImageList.ImageStream = DirectCast(manager.GetObject("FilesImageList.ImageStream"), ImageListStreamer)
            Me.FilesImageList.TransparentColor = Color.Transparent
            Me.FilesImageList.Images.SetKeyName(0, "empty.png")
            Me.ImagePict.Anchor = (AnchorStyles.Left Or AnchorStyles.Bottom)
            Me.ImagePict.ErrorImage = Resources.cancel
            Me.ImagePict.InitialImage = Resources.empty1
            point = New Point(12, &H152)
            Me.ImagePict.Location = point
            Me.ImagePict.Name = "ImagePict"
            size = New Size(&H80, &H60)
            Me.ImagePict.Size = size
            Me.ImagePict.SizeMode = PictureBoxSizeMode.Zoom
            Me.ImagePict.TabIndex = &H23
            Me.ImagePict.TabStop = False
            Me.PreviousPageButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.PreviousPageButt.Image = Resources.back
            Me.PreviousPageButt.ImageTransparentColor = Color.Magenta
            Me.PreviousPageButt.Name = "PreviousPageButt"
            size = New Size(&H1C, &H1C)
            Me.PreviousPageButt.Size = size
            Me.PreviousPageButt.Text = "Pagina precedente"
            Me.NextPageButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.NextPageButt.Image = Resources.forward
            Me.NextPageButt.ImageTransparentColor = Color.Magenta
            Me.NextPageButt.Name = "NextPageButt"
            size = New Size(&H1C, &H1C)
            Me.NextPageButt.Size = size
            Me.NextPageButt.Text = "Pagina successiva"
            Me.Play.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.Play.Enabled = False
            Me.Play.Image = Resources.player_play
            Me.Play.ImageTransparentColor = Color.Magenta
            Me.Play.Name = "Play"
            size = New Size(&H1C, &H1C)
            Me.Play.Size = size
            Me.Play.Text = "Riproduci audio di sottofondo"
            Me.Stopp.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.Stopp.Enabled = False
            Me.Stopp.Image = Resources.player_stop
            Me.Stopp.ImageTransparentColor = Color.Magenta
            Me.Stopp.Name = "Stopp"
            size = New Size(&H1C, &H1C)
            Me.Stopp.Size = size
            Me.Stopp.Text = "Stop"
            Me.PageInfoButt.Alignment = ToolStripItemAlignment.Right
            Me.PageInfoButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.PageInfoButt.Image = Resources.messagebox_info
            Me.PageInfoButt.ImageTransparentColor = Color.Magenta
            Me.PageInfoButt.Name = "PageInfoButt"
            size = New Size(&H1C, &H1C)
            Me.PageInfoButt.Size = size
            Me.PageInfoButt.Text = "Informazioni sulla pagina"
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H278, &H1BE)
            Me.ClientSize = size
            Me.Controls.Add(Me.FilesView)
            Me.Controls.Add(Me.ImagePict)
            Me.Controls.Add(Me.TestoText)
            Me.Controls.Add(Me.MainToolStrip)
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.Name = "DisplayPage"
            Me.Text = "Pagina"
            Me.MainToolStrip.ResumeLayout(False)
            Me.MainToolStrip.PerformLayout
            DirectCast(Me.ImagePict, ISupportInitialize).EndInit
            Me.ResumeLayout(False)
            Me.PerformLayout
        End Sub

        Private Sub NextPageButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.Stopp.Enabled Then
                Me.AudioBackground.Stop
            End If
            Me.Carica(CInt(Math.Round(CDbl((Conversions.ToDouble(Me.Page1Text.Text) + 1)))))
        End Sub

        Private Sub Page1Text_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
            If (Me.Page1Text.Text = "") Then
                Me.Carica(1)
            End If
            If (Conversions.ToDouble(Me.Page1Text.Text) = 0) Then
                Me.Carica(1)
            End If
            If Operators.ConditionalCompareObjectGreater(Conversion.Int(Me.Page1Text.Text), Conversion.Int(Me.Page2Lab.Text), False) Then
                Me.Carica(Conversions.ToInteger(Conversion.Int(Me.Page2Lab.Text)))
            End If
            If (e.KeyChar = ChrW(13)) Then
                Me.Carica(Conversions.ToInteger(Me.Page1Text.Text))
            End If
        End Sub

        Private Sub PageInfoButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.PageInfo.LoadInfo(Me.PageID)
            MyProject.Forms.PageInfo.Show
        End Sub

        Private Sub Play_Click(ByVal sender As Object, ByVal e As EventArgs)
            If MyProject.Computer.FileSystem.FileExists((Me.Path & "Audio.wav")) Then
                Me.AudioBackground = New Audio((Me.Path & "Audio.wav"), True)
            End If
            If MyProject.Computer.FileSystem.FileExists((Me.Path & "Audio.mp3")) Then
                Me.AudioBackground = New Audio((Me.Path & "Audio.mp3"), True)
            End If
            If MyProject.Computer.FileSystem.FileExists((Me.Path & "Audio.wma")) Then
                Me.AudioBackground = New Audio((Me.Path & "Audio.wma"), True)
            End If
            Me.Stopp.Enabled = True
        End Sub

        Private Sub PreviousPageButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.Stopp.Enabled Then
                Me.AudioBackground.Stop
            End If
            Me.Carica(CInt(Math.Round(CDbl((Conversions.ToDouble(Me.Page1Text.Text) - 1)))))
        End Sub

        Private Sub Stopp_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.AudioBackground.Stop
            Me.Stopp.Enabled = False
        End Sub

        Private Sub VisualizzaPagina_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
            If Me.Stopp.Enabled Then
                Me.AudioBackground.Stop
            End If
        End Sub


        ' Properties
        Friend Overridable Property ToolStripMenuItem2 As ToolStripSeparator
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripMenuItem2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripSeparator)
                Me._ToolStripMenuItem2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property SalvaToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._SalvaToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._SalvaToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property VaiADataToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._VaiADataToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._VaiADataToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property MainToolStrip As ToolStrip
            <DebuggerNonUserCode> _
            Get
                Return Me._MainToolStrip
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStrip)
                Me._MainToolStrip = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PageLab As ToolStripLabel
            <DebuggerNonUserCode> _
            Get
                Return Me._PageLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripLabel)
                Me._PageLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Page1Text As ToolStripTextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._Page1Text
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripTextBox)
                If (Not Me._Page1Text Is Nothing) Then
                    RemoveHandler Me._Page1Text.KeyPress, New KeyPressEventHandler(AddressOf Me.Page1Text_KeyPress)
                End If
                Me._Page1Text = WithEventsValue
                If (Not Me._Page1Text Is Nothing) Then
                    AddHandler Me._Page1Text.KeyPress, New KeyPressEventHandler(AddressOf Me.Page1Text_KeyPress)
                End If
            End Set
        End Property

        Friend Overridable Property OfLab As ToolStripLabel
            <DebuggerNonUserCode> _
            Get
                Return Me._OfLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripLabel)
                Me._OfLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Page2Lab As ToolStripLabel
            <DebuggerNonUserCode> _
            Get
                Return Me._Page2Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripLabel)
                Me._Page2Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PreviousPageButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._PreviousPageButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._PreviousPageButt Is Nothing) Then
                    RemoveHandler Me._PreviousPageButt.Click, New EventHandler(AddressOf Me.PreviousPageButt_Click)
                End If
                Me._PreviousPageButt = WithEventsValue
                If (Not Me._PreviousPageButt Is Nothing) Then
                    AddHandler Me._PreviousPageButt.Click, New EventHandler(AddressOf Me.PreviousPageButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property NextPageButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._NextPageButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._NextPageButt Is Nothing) Then
                    RemoveHandler Me._NextPageButt.Click, New EventHandler(AddressOf Me.NextPageButt_Click)
                End If
                Me._NextPageButt = WithEventsValue
                If (Not Me._NextPageButt Is Nothing) Then
                    AddHandler Me._NextPageButt.Click, New EventHandler(AddressOf Me.NextPageButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property Separator As ToolStripSeparator
            <DebuggerNonUserCode> _
            Get
                Return Me._Separator
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripSeparator)
                Me._Separator = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Play As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._Play
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._Play Is Nothing) Then
                    RemoveHandler Me._Play.Click, New EventHandler(AddressOf Me.Play_Click)
                End If
                Me._Play = WithEventsValue
                If (Not Me._Play Is Nothing) Then
                    AddHandler Me._Play.Click, New EventHandler(AddressOf Me.Play_Click)
                End If
            End Set
        End Property

        Friend Overridable Property Stopp As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._Stopp
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._Stopp Is Nothing) Then
                    RemoveHandler Me._Stopp.Click, New EventHandler(AddressOf Me.Stopp_Click)
                End If
                Me._Stopp = WithEventsValue
                If (Not Me._Stopp Is Nothing) Then
                    AddHandler Me._Stopp.Click, New EventHandler(AddressOf Me.Stopp_Click)
                End If
            End Set
        End Property

        Friend Overridable Property TestoText As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._TestoText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._TestoText = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PageInfoButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._PageInfoButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._PageInfoButt Is Nothing) Then
                    RemoveHandler Me._PageInfoButt.Click, New EventHandler(AddressOf Me.PageInfoButt_Click)
                End If
                Me._PageInfoButt = WithEventsValue
                If (Not Me._PageInfoButt Is Nothing) Then
                    AddHandler Me._PageInfoButt.Click, New EventHandler(AddressOf Me.PageInfoButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ImagePict As PictureBox
            <DebuggerNonUserCode> _
            Get
                Return Me._ImagePict
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PictureBox)
                If (Not Me._ImagePict Is Nothing) Then
                    RemoveHandler Me._ImagePict.DoubleClick, New EventHandler(AddressOf Me.ImagePict_DoubleClick)
                End If
                Me._ImagePict = WithEventsValue
                If (Not Me._ImagePict Is Nothing) Then
                    AddHandler Me._ImagePict.DoubleClick, New EventHandler(AddressOf Me.ImagePict_DoubleClick)
                End If
            End Set
        End Property

        Friend Overridable Property FilesView As ListView
            <DebuggerNonUserCode> _
            Get
                Return Me._FilesView
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ListView)
                If (Not Me._FilesView Is Nothing) Then
                    RemoveHandler Me._FilesView.DoubleClick, New EventHandler(AddressOf Me.FilesView_DoubleClick)
                End If
                Me._FilesView = WithEventsValue
                If (Not Me._FilesView Is Nothing) Then
                    AddHandler Me._FilesView.DoubleClick, New EventHandler(AddressOf Me.FilesView_DoubleClick)
                End If
            End Set
        End Property

        Friend Overridable Property FilesImageList As ImageList
            <DebuggerNonUserCode> _
            Get
                Return Me._FilesImageList
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ImageList)
                Me._FilesImageList = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ToolStripSeparator1 As ToolStripSeparator
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripSeparator1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripSeparator)
                Me._ToolStripSeparator1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TitleLab As ToolStripLabel
            <DebuggerNonUserCode> _
            Get
                Return Me._TitleLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripLabel)
                Me._TitleLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DateLab As ToolStripLabel
            <DebuggerNonUserCode> _
            Get
                Return Me._DateLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripLabel)
                Me._DateLab = WithEventsValue
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("ToolStripMenuItem2")> _
        Private _ToolStripMenuItem2 As ToolStripSeparator
        <AccessedThroughProperty("SalvaToolStripMenuItem")> _
        Private _SalvaToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("VaiADataToolStripMenuItem")> _
        Private _VaiADataToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("MainToolStrip")> _
        Private _MainToolStrip As ToolStrip
        <AccessedThroughProperty("PageLab")> _
        Private _PageLab As ToolStripLabel
        <AccessedThroughProperty("Page1Text")> _
        Private _Page1Text As ToolStripTextBox
        <AccessedThroughProperty("OfLab")> _
        Private _OfLab As ToolStripLabel
        <AccessedThroughProperty("Page2Lab")> _
        Private _Page2Lab As ToolStripLabel
        <AccessedThroughProperty("PreviousPageButt")> _
        Private _PreviousPageButt As ToolStripButton
        <AccessedThroughProperty("NextPageButt")> _
        Private _NextPageButt As ToolStripButton
        <AccessedThroughProperty("Separator")> _
        Private _Separator As ToolStripSeparator
        <AccessedThroughProperty("Play")> _
        Private _Play As ToolStripButton
        <AccessedThroughProperty("Stopp")> _
        Private _Stopp As ToolStripButton
        <AccessedThroughProperty("TestoText")> _
        Private _TestoText As TextBox
        <AccessedThroughProperty("PageInfoButt")> _
        Private _PageInfoButt As ToolStripButton
        <AccessedThroughProperty("ImagePict")> _
        Private _ImagePict As PictureBox
        <AccessedThroughProperty("FilesView")> _
        Private _FilesView As ListView
        <AccessedThroughProperty("FilesImageList")> _
        Private _FilesImageList As ImageList
        <AccessedThroughProperty("ToolStripSeparator1")> _
        Private _ToolStripSeparator1 As ToolStripSeparator
        <AccessedThroughProperty("TitleLab")> _
        Private _TitleLab As ToolStripLabel
        <AccessedThroughProperty("DateLab")> _
        Private _DateLab As ToolStripLabel
        Private PageID As Integer
        Private Path As String
        Private AudioBackground As Audio
    End Class
End Namespace

