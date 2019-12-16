Imports Microsoft.VisualBasic.CompilerServices
Imports Power_Diary.My
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace Power_Diary
    <DesignerGenerated> _
    Public Class Settings
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            Me.InitializeComponent
        End Sub

        Private Sub AnnullaButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close
        End Sub

        Public Sub Applica()
            MySettingsProperty.Settings.Font = Me.FontDial.Font
            MySettingsProperty.Settings.Save
            MySettingsProperty.Settings.Reload
        End Sub

        Private Sub ApplicaButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Applica
        End Sub

        Private Sub AutoloadButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.Open.LoadOpen(2)
            MyProject.Forms.Open.Show
        End Sub

        Private Sub BackColorButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.BackColorDial.ShowDialog
            MySettingsProperty.Settings.BackColor = Me.BackColorDial.Color
            MySettingsProperty.Settings.Save
        End Sub

        Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.ImageWidth.Enabled = Me.CheckBox1.Checked
            Me.ImageHeight.Enabled = Me.CheckBox1.Checked
            Me.xLab.Enabled = Me.CheckBox1.Checked
        End Sub

        Private Sub DefaultButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (MessageBox.Show("Vuoi davvero ripristinare le opzioni ai valori di default? In questo modo le attuali impostazioni sarano cancellate.", "Proseguire?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No) Then
            End If
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub FontButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.FontDial.ShowDialog
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Dim manager As New ComponentResourceManager(GetType(Settings))
            Me.OKButt = New Button
            Me.AnnullaButt = New Button
            Me.DefaultButt = New Button
            Me.ApplicaButt = New Button
            Me.OpzioniTab = New TabControl
            Me.MainTab = New TabPage
            Me.GroupBox2 = New GroupBox
            Me.AutoloadButt = New Button
            Me.AutoloadCheck = New CheckBox
            Me.AutoLoadText = New TextBox
            Me.AspettoTab = New TabPage
            Me.BackColorGroup = New GroupBox
            Me.BackColorPan = New Panel
            Me.BackColorButt = New Button
            Me.TestoGroup = New GroupBox
            Me.FontButt = New Button
            Me.LoremIpsumLab = New Label
            Me.SaveMemory = New TabPage
            Me.Label1 = New Label
            Me.ImageGroup = New GroupBox
            Me.CheckBox1 = New CheckBox
            Me.ImageHeight = New NumericUpDown
            Me.xLab = New Label
            Me.ImageWidth = New NumericUpDown
            Me.aLab = New Label
            Me.CheckBox2 = New CheckBox
            Me.NumericUpDown1 = New NumericUpDown
            Me.ComboBox1 = New ComboBox
            Me.PrivacyTab = New TabPage
            Me.CheckBox4 = New CheckBox
            Me.NumericUpDown2 = New NumericUpDown
            Me.CheckBox3 = New CheckBox
            Me.FontDial = New FontDialog
            Me.BackColorDial = New ColorDialog
            Me.OpzioniTab.SuspendLayout
            Me.MainTab.SuspendLayout
            Me.GroupBox2.SuspendLayout
            Me.AspettoTab.SuspendLayout
            Me.BackColorGroup.SuspendLayout
            Me.TestoGroup.SuspendLayout
            Me.SaveMemory.SuspendLayout
            Me.ImageGroup.SuspendLayout
            Me.ImageHeight.BeginInit
            Me.ImageWidth.BeginInit
            Me.NumericUpDown1.BeginInit
            Me.PrivacyTab.SuspendLayout
            Me.NumericUpDown2.BeginInit
            Me.SuspendLayout
            Dim point As New Point(&H195, &H14B)
            Me.OKButt.Location = point
            Me.OKButt.Name = "OKButt"
            Dim size As New Size(&H4B, &H17)
            Me.OKButt.Size = size
            Me.OKButt.TabIndex = 0
            Me.OKButt.Text = "&OK"
            Me.OKButt.UseVisualStyleBackColor = True
            point = New Point(&HF3, &H14B)
            Me.AnnullaButt.Location = point
            Me.AnnullaButt.Name = "AnnullaButt"
            size = New Size(&H4B, &H17)
            Me.AnnullaButt.Size = size
            Me.AnnullaButt.TabIndex = 1
            Me.AnnullaButt.Text = "&Annulla"
            Me.AnnullaButt.UseVisualStyleBackColor = True
            point = New Point(12, &H14B)
            Me.DefaultButt.Location = point
            Me.DefaultButt.Name = "DefaultButt"
            size = New Size(&H8F, &H17)
            Me.DefaultButt.Size = size
            Me.DefaultButt.TabIndex = 2
            Me.DefaultButt.Text = "&Reimposta valori predefiniti"
            Me.DefaultButt.UseVisualStyleBackColor = True
            point = New Point(&H144, &H14B)
            Me.ApplicaButt.Location = point
            Me.ApplicaButt.Name = "ApplicaButt"
            size = New Size(&H4B, &H17)
            Me.ApplicaButt.Size = size
            Me.ApplicaButt.TabIndex = 3
            Me.ApplicaButt.Text = "A&pplica"
            Me.ApplicaButt.UseVisualStyleBackColor = True
            Me.OpzioniTab.Controls.Add(Me.MainTab)
            Me.OpzioniTab.Controls.Add(Me.AspettoTab)
            Me.OpzioniTab.Controls.Add(Me.SaveMemory)
            Me.OpzioniTab.Controls.Add(Me.PrivacyTab)
            point = New Point(12, 12)
            Me.OpzioniTab.Location = point
            Me.OpzioniTab.Name = "OpzioniTab"
            Me.OpzioniTab.SelectedIndex = 0
            size = New Size(&H1D4, &H139)
            Me.OpzioniTab.Size = size
            Me.OpzioniTab.TabIndex = 4
            Me.MainTab.Controls.Add(Me.GroupBox2)
            point = New Point(4, &H16)
            Me.MainTab.Location = point
            Me.MainTab.Name = "MainTab"
            size = New Size(460, &H11F)
            Me.MainTab.Size = size
            Me.MainTab.TabIndex = 1
            Me.MainTab.Text = "Generale"
            Me.MainTab.UseVisualStyleBackColor = True
            Me.GroupBox2.Controls.Add(Me.AutoloadButt)
            Me.GroupBox2.Controls.Add(Me.AutoloadCheck)
            Me.GroupBox2.Controls.Add(Me.AutoLoadText)
            point = New Point(3, 3)
            Me.GroupBox2.Location = point
            Me.GroupBox2.Name = "GroupBox2"
            size = New Size(&H1C6, 70)
            Me.GroupBox2.Size = size
            Me.GroupBox2.TabIndex = 6
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Autoload"
            point = New Point(&H175, &H29)
            Me.AutoloadButt.Location = point
            Me.AutoloadButt.Name = "AutoloadButt"
            size = New Size(&H4B, &H17)
            Me.AutoloadButt.Size = size
            Me.AutoloadButt.TabIndex = &H2E
            Me.AutoloadButt.Text = "&Seleziona..."
            Me.AutoloadButt.UseVisualStyleBackColor = True
            Me.AutoloadCheck.AutoSize = True
            Me.AutoloadCheck.Checked = MySettings.Default.AutoLoad
            Me.AutoloadCheck.DataBindings.Add(New Binding("Checked", MySettings.Default, "AutoLoad", True, DataSourceUpdateMode.OnPropertyChanged))
            point = New Point(6, &H13)
            Me.AutoloadCheck.Location = point
            Me.AutoloadCheck.Name = "AutoloadCheck"
            size = New Size(&H11A, &H11)
            Me.AutoloadCheck.Size = size
            Me.AutoloadCheck.TabIndex = &H2D
            Me.AutoloadCheck.Text = "All'apertura, carica automaticamente il seguente diario:"
            Me.AutoloadCheck.UseVisualStyleBackColor = True
            Me.AutoLoadText.DataBindings.Add(New Binding("Text", MySettings.Default, "AutoLoadPath", True, DataSourceUpdateMode.OnPropertyChanged))
            point = New Point(6, &H2A)
            Me.AutoLoadText.Location = point
            Me.AutoLoadText.Name = "AutoLoadText"
            size = New Size(&H169, 20)
            Me.AutoLoadText.Size = size
            Me.AutoLoadText.TabIndex = &H2C
            Me.AutoLoadText.Text = MySettings.Default.AutoLoadPath
            Me.AspettoTab.Controls.Add(Me.BackColorGroup)
            Me.AspettoTab.Controls.Add(Me.TestoGroup)
            point = New Point(4, &H16)
            Me.AspettoTab.Location = point
            Me.AspettoTab.Name = "AspettoTab"
            Dim padding As New Padding(3)
            Me.AspettoTab.Padding = padding
            size = New Size(460, &H11F)
            Me.AspettoTab.Size = size
            Me.AspettoTab.TabIndex = 0
            Me.AspettoTab.Text = "Aspetto"
            Me.AspettoTab.UseVisualStyleBackColor = True
            Me.BackColorGroup.Controls.Add(Me.BackColorPan)
            Me.BackColorGroup.Controls.Add(Me.BackColorButt)
            point = New Point(6, &H4C)
            Me.BackColorGroup.Location = point
            Me.BackColorGroup.Name = "BackColorGroup"
            size = New Size(&H1C0, 100)
            Me.BackColorGroup.Size = size
            Me.BackColorGroup.TabIndex = 1
            Me.BackColorGroup.TabStop = False
            Me.BackColorGroup.Text = "Sfondo della pagina"
            Me.BackColorPan.BackColor = MySettings.Default.BackColor
            Me.BackColorPan.DataBindings.Add(New Binding("BackColor", MySettings.Default, "BackColor", True, DataSourceUpdateMode.OnPropertyChanged))
            point = New Point(6, &H13)
            Me.BackColorPan.Location = point
            Me.BackColorPan.Name = "BackColorPan"
            size = New Size(&H40, &H40)
            Me.BackColorPan.Size = size
            Me.BackColorPan.TabIndex = 2
            point = New Point(&H4C, &H1F)
            Me.BackColorButt.Location = point
            Me.BackColorButt.Name = "BackColorButt"
            size = New Size(&H75, &H26)
            Me.BackColorButt.Size = size
            Me.BackColorButt.TabIndex = 1
            Me.BackColorButt.Text = "Cambia colore di sfondo..."
            Me.BackColorButt.UseVisualStyleBackColor = True
            Me.TestoGroup.Controls.Add(Me.FontButt)
            Me.TestoGroup.Controls.Add(Me.LoremIpsumLab)
            point = New Point(3, 6)
            Me.TestoGroup.Location = point
            Me.TestoGroup.Name = "TestoGroup"
            size = New Size(&H1C3, &H40)
            Me.TestoGroup.Size = size
            Me.TestoGroup.TabIndex = 0
            Me.TestoGroup.TabStop = False
            Me.TestoGroup.Text = "Carattere del testo"
            point = New Point(370, &H10)
            Me.FontButt.Location = point
            Me.FontButt.Name = "FontButt"
            size = New Size(&H4B, &H17)
            Me.FontButt.Size = size
            Me.FontButt.TabIndex = 0
            Me.FontButt.Text = "Cambia..."
            Me.FontButt.UseVisualStyleBackColor = True
            Me.LoremIpsumLab.DataBindings.Add(New Binding("Font", MySettings.Default, "Font", True, DataSourceUpdateMode.OnPropertyChanged))
            Me.LoremIpsumLab.Font = MySettings.Default.Font
            point = New Point(6, &H10)
            Me.LoremIpsumLab.Location = point
            Me.LoremIpsumLab.Name = "LoremIpsumLab"
            size = New Size(&H166, &H29)
            Me.LoremIpsumLab.Size = size
            Me.LoremIpsumLab.TabIndex = 1
            Me.LoremIpsumLab.Text = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. "
            Me.SaveMemory.Controls.Add(Me.Label1)
            Me.SaveMemory.Controls.Add(Me.ImageGroup)
            Me.SaveMemory.Controls.Add(Me.aLab)
            Me.SaveMemory.Controls.Add(Me.CheckBox2)
            Me.SaveMemory.Controls.Add(Me.NumericUpDown1)
            Me.SaveMemory.Controls.Add(Me.ComboBox1)
            point = New Point(4, &H16)
            Me.SaveMemory.Location = point
            Me.SaveMemory.Name = "SaveMemory"
            padding = New Padding(3)
            Me.SaveMemory.Padding = padding
            size = New Size(460, &H11F)
            Me.SaveMemory.Size = size
            Me.SaveMemory.TabIndex = 2
            Me.SaveMemory.Text = "Risparmio memoria"
            Me.SaveMemory.UseVisualStyleBackColor = True
            Me.Label1.AutoSize = True
            point = New Point(&H11C, 110)
            Me.Label1.Location = point
            Me.Label1.Name = "Label1"
            size = New Size(&H22, 13)
            Me.Label1.Size = size
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "kbit/s"
            Me.Label1.Visible = False
            Me.ImageGroup.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or AnchorStyles.Top))
            Me.ImageGroup.Controls.Add(Me.CheckBox1)
            Me.ImageGroup.Controls.Add(Me.ImageHeight)
            Me.ImageGroup.Controls.Add(Me.xLab)
            Me.ImageGroup.Controls.Add(Me.ImageWidth)
            point = New Point(6, 6)
            Me.ImageGroup.Location = point
            Me.ImageGroup.Name = "ImageGroup"
            size = New Size(&H1C0, &H47)
            Me.ImageGroup.Size = size
            Me.ImageGroup.TabIndex = 4
            Me.ImageGroup.TabStop = False
            Me.ImageGroup.Text = "Immagini"
            Me.ImageGroup.Visible = False
            Me.CheckBox1.AutoSize = True
            point = New Point(6, &H13)
            Me.CheckBox1.Location = point
            Me.CheckBox1.Name = "CheckBox1"
            size = New Size(&HC3, &H11)
            Me.CheckBox1.Size = size
            Me.CheckBox1.TabIndex = 0
            Me.CheckBox1.Text = "Ridimensiona le immagini utilizzate a"
            Me.CheckBox1.UseVisualStyleBackColor = True
            Me.ImageHeight.Enabled = False
            point = New Point(&H116, &H12)
            Me.ImageHeight.Location = point
            Dim num As New Decimal(New Integer() { &H1000, 0, 0, 0 })
            Me.ImageHeight.Maximum = num
            num = New Decimal(New Integer() { 1, 0, 0, 0 })
            Me.ImageHeight.Minimum = num
            Me.ImageHeight.Name = "ImageHeight"
            size = New Size(&H31, 20)
            Me.ImageHeight.Size = size
            Me.ImageHeight.TabIndex = 2
            num = New Decimal(New Integer() { 600, 0, 0, 0 })
            Me.ImageHeight.Value = num
            Me.xLab.AutoSize = True
            Me.xLab.Enabled = False
            point = New Point(260, 20)
            Me.xLab.Location = point
            Me.xLab.Name = "xLab"
            size = New Size(12, 13)
            Me.xLab.Size = size
            Me.xLab.TabIndex = 3
            Me.xLab.Text = "x"
            Me.ImageWidth.Enabled = False
            point = New Point(&HCF, &H12)
            Me.ImageWidth.Location = point
            num = New Decimal(New Integer() { &H1000, 0, 0, 0 })
            Me.ImageWidth.Maximum = num
            num = New Decimal(New Integer() { 1, 0, 0, 0 })
            Me.ImageWidth.Minimum = num
            Me.ImageWidth.Name = "ImageWidth"
            size = New Size(&H2F, 20)
            Me.ImageWidth.Size = size
            Me.ImageWidth.TabIndex = 1
            num = New Decimal(New Integer() { 800, 0, 0, 0 })
            Me.ImageWidth.Value = num
            Me.aLab.AutoSize = True
            point = New Point(&HD5, 110)
            Me.aLab.Location = point
            Me.aLab.Name = "aLab"
            size = New Size(13, 13)
            Me.aLab.Size = size
            Me.aLab.TabIndex = 7
            Me.aLab.Text = "a"
            Me.aLab.Visible = False
            Me.CheckBox2.AutoSize = True
            point = New Point(12, &H6D)
            Me.CheckBox2.Location = point
            Me.CheckBox2.Name = "CheckBox2"
            size = New Size(&H8F, &H11)
            Me.CheckBox2.Size = size
            Me.CheckBox2.TabIndex = 4
            Me.CheckBox2.Text = "Ricampiona i file audio in"
            Me.CheckBox2.UseVisualStyleBackColor = True
            Me.CheckBox2.Visible = False
            point = New Point(&HE8, &H6C)
            Me.NumericUpDown1.Location = point
            Me.NumericUpDown1.Name = "NumericUpDown1"
            size = New Size(&H2E, 20)
            Me.NumericUpDown1.Size = size
            Me.NumericUpDown1.TabIndex = 6
            num = New Decimal(New Integer() { &H40, 0, 0, 0 })
            Me.NumericUpDown1.Value = num
            Me.NumericUpDown1.Visible = False
            Me.ComboBox1.FormattingEnabled = True
            Dim items As Object() = New Object() { "MP3", "WMA" }
            Me.ComboBox1.Items.AddRange(items)
            point = New Point(&HA1, &H6B)
            Me.ComboBox1.Location = point
            Me.ComboBox1.Name = "ComboBox1"
            size = New Size(&H2E, &H15)
            Me.ComboBox1.Size = size
            Me.ComboBox1.TabIndex = 5
            Me.ComboBox1.Text = "MP3"
            Me.ComboBox1.Visible = False
            Me.PrivacyTab.Controls.Add(Me.CheckBox4)
            Me.PrivacyTab.Controls.Add(Me.NumericUpDown2)
            Me.PrivacyTab.Controls.Add(Me.CheckBox3)
            point = New Point(4, &H16)
            Me.PrivacyTab.Location = point
            Me.PrivacyTab.Name = "PrivacyTab"
            padding = New Padding(3)
            Me.PrivacyTab.Padding = padding
            size = New Size(460, &H11F)
            Me.PrivacyTab.Size = size
            Me.PrivacyTab.TabIndex = 3
            Me.PrivacyTab.Text = "Privacy"
            Me.PrivacyTab.UseVisualStyleBackColor = True
            Me.CheckBox4.AutoSize = True
            point = New Point(6, &H1D)
            Me.CheckBox4.Location = point
            Me.CheckBox4.Name = "CheckBox4"
            size = New Size(400, &H11)
            Me.CheckBox4.Size = size
            Me.CheckBox4.TabIndex = 2
            Me.CheckBox4.Text = "Non conservare impostazioni personalizzate che contengono elementi personali"
            Me.CheckBox4.UseVisualStyleBackColor = True
            Me.CheckBox4.Visible = False
            point = New Point(&HD7, 5)
            Me.NumericUpDown2.Location = point
            num = New Decimal(New Integer() { &H3E7, 0, 0, 0 })
            Me.NumericUpDown2.Maximum = num
            num = New Decimal(New Integer() { 1, 0, 0, 0 })
            Me.NumericUpDown2.Minimum = num
            Me.NumericUpDown2.Name = "NumericUpDown2"
            size = New Size(&H2A, 20)
            Me.NumericUpDown2.Size = size
            Me.NumericUpDown2.TabIndex = 1
            num = New Decimal(New Integer() { 2, 0, 0, 0 })
            Me.NumericUpDown2.Value = num
            Me.NumericUpDown2.Visible = False
            Me.CheckBox3.AutoSize = True
            Me.CheckBox3.Checked = True
            Me.CheckBox3.CheckState = CheckState.Checked
            point = New Point(6, 6)
            Me.CheckBox3.Location = point
            Me.CheckBox3.Name = "CheckBox3"
            size = New Size(&HCB, &H11)
            Me.CheckBox3.Size = size
            Me.CheckBox3.TabIndex = 0
            Me.CheckBox3.Text = "Oscura il testo dopo inattività di minuti"
            Me.CheckBox3.UseVisualStyleBackColor = True
            Me.CheckBox3.Visible = False
            Me.FontDial.Font = MySettings.Default.Font
            Me.FontDial.FontMustExist = True
            Me.FontDial.ShowColor = True
            Me.FontDial.ShowHelp = True
            Me.BackColorDial.Color = MySettings.Default.BackColor
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H1EC, &H16E)
            Me.ClientSize = size
            Me.Controls.Add(Me.OpzioniTab)
            Me.Controls.Add(Me.ApplicaButt)
            Me.Controls.Add(Me.DefaultButt)
            Me.Controls.Add(Me.AnnullaButt)
            Me.Controls.Add(Me.OKButt)
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Settings"
            Me.ShowInTaskbar = False
            Me.Text = "Opzioni"
            Me.OpzioniTab.ResumeLayout(False)
            Me.MainTab.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout
            Me.AspettoTab.ResumeLayout(False)
            Me.BackColorGroup.ResumeLayout(False)
            Me.TestoGroup.ResumeLayout(False)
            Me.SaveMemory.ResumeLayout(False)
            Me.SaveMemory.PerformLayout
            Me.ImageGroup.ResumeLayout(False)
            Me.ImageGroup.PerformLayout
            Me.ImageHeight.EndInit
            Me.ImageWidth.EndInit
            Me.NumericUpDown1.EndInit
            Me.PrivacyTab.ResumeLayout(False)
            Me.PrivacyTab.PerformLayout
            Me.NumericUpDown2.EndInit
            Me.ResumeLayout(False)
        End Sub

        Private Sub OKButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Applica
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

        Friend Overridable Property AnnullaButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._AnnullaButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._AnnullaButt Is Nothing) Then
                    RemoveHandler Me._AnnullaButt.Click, New EventHandler(AddressOf Me.AnnullaButt_Click)
                End If
                Me._AnnullaButt = WithEventsValue
                If (Not Me._AnnullaButt Is Nothing) Then
                    AddHandler Me._AnnullaButt.Click, New EventHandler(AddressOf Me.AnnullaButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property DefaultButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._DefaultButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._DefaultButt Is Nothing) Then
                    RemoveHandler Me._DefaultButt.Click, New EventHandler(AddressOf Me.DefaultButt_Click)
                End If
                Me._DefaultButt = WithEventsValue
                If (Not Me._DefaultButt Is Nothing) Then
                    AddHandler Me._DefaultButt.Click, New EventHandler(AddressOf Me.DefaultButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ApplicaButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._ApplicaButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._ApplicaButt Is Nothing) Then
                    RemoveHandler Me._ApplicaButt.Click, New EventHandler(AddressOf Me.ApplicaButt_Click)
                End If
                Me._ApplicaButt = WithEventsValue
                If (Not Me._ApplicaButt Is Nothing) Then
                    AddHandler Me._ApplicaButt.Click, New EventHandler(AddressOf Me.ApplicaButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property OpzioniTab As TabControl
            <DebuggerNonUserCode> _
            Get
                Return Me._OpzioniTab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabControl)
                Me._OpzioniTab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property AspettoTab As TabPage
            <DebuggerNonUserCode> _
            Get
                Return Me._AspettoTab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabPage)
                Me._AspettoTab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TestoGroup As GroupBox
            <DebuggerNonUserCode> _
            Get
                Return Me._TestoGroup
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._TestoGroup = WithEventsValue
            End Set
        End Property

        Friend Overridable Property FontDial As FontDialog
            <DebuggerNonUserCode> _
            Get
                Return Me._FontDial
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As FontDialog)
                Me._FontDial = WithEventsValue
            End Set
        End Property

        Friend Overridable Property MainTab As TabPage
            <DebuggerNonUserCode> _
            Get
                Return Me._MainTab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabPage)
                Me._MainTab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property FontButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._FontButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._FontButt Is Nothing) Then
                    RemoveHandler Me._FontButt.Click, New EventHandler(AddressOf Me.FontButt_Click)
                End If
                Me._FontButt = WithEventsValue
                If (Not Me._FontButt Is Nothing) Then
                    AddHandler Me._FontButt.Click, New EventHandler(AddressOf Me.FontButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property LoremIpsumLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._LoremIpsumLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._LoremIpsumLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property GroupBox2 As GroupBox
            <DebuggerNonUserCode> _
            Get
                Return Me._GroupBox2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._GroupBox2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property AutoloadCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._AutoloadCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._AutoloadCheck = WithEventsValue
            End Set
        End Property

        Friend Overridable Property AutoLoadText As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._AutoLoadText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._AutoLoadText = WithEventsValue
            End Set
        End Property

        Friend Overridable Property AutoloadButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._AutoloadButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._AutoloadButt Is Nothing) Then
                    RemoveHandler Me._AutoloadButt.Click, New EventHandler(AddressOf Me.AutoloadButt_Click)
                End If
                Me._AutoloadButt = WithEventsValue
                If (Not Me._AutoloadButt Is Nothing) Then
                    AddHandler Me._AutoloadButt.Click, New EventHandler(AddressOf Me.AutoloadButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property BackColorGroup As GroupBox
            <DebuggerNonUserCode> _
            Get
                Return Me._BackColorGroup
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._BackColorGroup = WithEventsValue
            End Set
        End Property

        Friend Overridable Property BackColorPan As Panel
            <DebuggerNonUserCode> _
            Get
                Return Me._BackColorPan
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Panel)
                Me._BackColorPan = WithEventsValue
            End Set
        End Property

        Friend Overridable Property BackColorButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._BackColorButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._BackColorButt Is Nothing) Then
                    RemoveHandler Me._BackColorButt.Click, New EventHandler(AddressOf Me.BackColorButt_Click)
                End If
                Me._BackColorButt = WithEventsValue
                If (Not Me._BackColorButt Is Nothing) Then
                    AddHandler Me._BackColorButt.Click, New EventHandler(AddressOf Me.BackColorButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property BackColorDial As ColorDialog
            <DebuggerNonUserCode> _
            Get
                Return Me._BackColorDial
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ColorDialog)
                Me._BackColorDial = WithEventsValue
            End Set
        End Property

        Friend Overridable Property SaveMemory As TabPage
            <DebuggerNonUserCode> _
            Get
                Return Me._SaveMemory
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabPage)
                Me._SaveMemory = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ImageGroup As GroupBox
            <DebuggerNonUserCode> _
            Get
                Return Me._ImageGroup
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._ImageGroup = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CheckBox1 As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._CheckBox1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                If (Not Me._CheckBox1 Is Nothing) Then
                    RemoveHandler Me._CheckBox1.CheckedChanged, New EventHandler(AddressOf Me.CheckBox1_CheckedChanged)
                End If
                Me._CheckBox1 = WithEventsValue
                If (Not Me._CheckBox1 Is Nothing) Then
                    AddHandler Me._CheckBox1.CheckedChanged, New EventHandler(AddressOf Me.CheckBox1_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property ImageHeight As NumericUpDown
            <DebuggerNonUserCode> _
            Get
                Return Me._ImageHeight
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As NumericUpDown)
                Me._ImageHeight = WithEventsValue
            End Set
        End Property

        Friend Overridable Property xLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._xLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._xLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ImageWidth As NumericUpDown
            <DebuggerNonUserCode> _
            Get
                Return Me._ImageWidth
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As NumericUpDown)
                Me._ImageWidth = WithEventsValue
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

        Friend Overridable Property aLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._aLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._aLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CheckBox2 As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._CheckBox2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._CheckBox2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property NumericUpDown1 As NumericUpDown
            <DebuggerNonUserCode> _
            Get
                Return Me._NumericUpDown1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As NumericUpDown)
                Me._NumericUpDown1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ComboBox1 As ComboBox
            <DebuggerNonUserCode> _
            Get
                Return Me._ComboBox1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ComboBox)
                Me._ComboBox1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PrivacyTab As TabPage
            <DebuggerNonUserCode> _
            Get
                Return Me._PrivacyTab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabPage)
                Me._PrivacyTab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property NumericUpDown2 As NumericUpDown
            <DebuggerNonUserCode> _
            Get
                Return Me._NumericUpDown2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As NumericUpDown)
                Me._NumericUpDown2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CheckBox3 As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._CheckBox3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._CheckBox3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CheckBox4 As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._CheckBox4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._CheckBox4 = WithEventsValue
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("OKButt")> _
        Private _OKButt As Button
        <AccessedThroughProperty("AnnullaButt")> _
        Private _AnnullaButt As Button
        <AccessedThroughProperty("DefaultButt")> _
        Private _DefaultButt As Button
        <AccessedThroughProperty("ApplicaButt")> _
        Private _ApplicaButt As Button
        <AccessedThroughProperty("OpzioniTab")> _
        Private _OpzioniTab As TabControl
        <AccessedThroughProperty("AspettoTab")> _
        Private _AspettoTab As TabPage
        <AccessedThroughProperty("TestoGroup")> _
        Private _TestoGroup As GroupBox
        <AccessedThroughProperty("FontDial")> _
        Private _FontDial As FontDialog
        <AccessedThroughProperty("MainTab")> _
        Private _MainTab As TabPage
        <AccessedThroughProperty("FontButt")> _
        Private _FontButt As Button
        <AccessedThroughProperty("LoremIpsumLab")> _
        Private _LoremIpsumLab As Label
        <AccessedThroughProperty("GroupBox2")> _
        Private _GroupBox2 As GroupBox
        <AccessedThroughProperty("AutoloadCheck")> _
        Private _AutoloadCheck As CheckBox
        <AccessedThroughProperty("AutoLoadText")> _
        Private _AutoLoadText As TextBox
        <AccessedThroughProperty("AutoloadButt")> _
        Private _AutoloadButt As Button
        <AccessedThroughProperty("BackColorGroup")> _
        Private _BackColorGroup As GroupBox
        <AccessedThroughProperty("BackColorPan")> _
        Private _BackColorPan As Panel
        <AccessedThroughProperty("BackColorButt")> _
        Private _BackColorButt As Button
        <AccessedThroughProperty("BackColorDial")> _
        Private _BackColorDial As ColorDialog
        <AccessedThroughProperty("SaveMemory")> _
        Private _SaveMemory As TabPage
        <AccessedThroughProperty("ImageGroup")> _
        Private _ImageGroup As GroupBox
        <AccessedThroughProperty("CheckBox1")> _
        Private _CheckBox1 As CheckBox
        <AccessedThroughProperty("ImageHeight")> _
        Private _ImageHeight As NumericUpDown
        <AccessedThroughProperty("xLab")> _
        Private _xLab As Label
        <AccessedThroughProperty("ImageWidth")> _
        Private _ImageWidth As NumericUpDown
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label
        <AccessedThroughProperty("aLab")> _
        Private _aLab As Label
        <AccessedThroughProperty("CheckBox2")> _
        Private _CheckBox2 As CheckBox
        <AccessedThroughProperty("NumericUpDown1")> _
        Private _NumericUpDown1 As NumericUpDown
        <AccessedThroughProperty("ComboBox1")> _
        Private _ComboBox1 As ComboBox
        <AccessedThroughProperty("PrivacyTab")> _
        Private _PrivacyTab As TabPage
        <AccessedThroughProperty("NumericUpDown2")> _
        Private _NumericUpDown2 As NumericUpDown
        <AccessedThroughProperty("CheckBox3")> _
        Private _CheckBox3 As CheckBox
        <AccessedThroughProperty("CheckBox4")> _
        Private _CheckBox4 As CheckBox
    End Class
End Namespace

