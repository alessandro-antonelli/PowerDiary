Imports Microsoft.VisualBasic.CompilerServices
Imports Power_Diary.My
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace Power_Diary
    <DesignerGenerated> _
    Public Class IOSettings
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            Me.InitializeComponent
        End Sub

        Private Sub CancelButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close
        End Sub

        Private Sub DiariesButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.Open.LoadOpen(1)
            MyProject.Forms.Open.Show
        End Sub

        Private Sub DiariesCheck_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.DiariesButt.Enabled = Me.DiariesCheck.Checked
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub ExportButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.ImpExpProg.Maximum = (Me.ExpDiariesList.Count + 1)
            Me.ImpExpProg.Value = 0
            Me.ExportBrowser.ShowDialog
            MyProject.Computer.FileSystem.CreateDirectory((Me.ExportBrowser.SelectedPath & "\Power Diary"))
            If Me.SettingsCheck.Checked Then
                Dim writer As New StreamWriter((Me.ExportBrowser.SelectedPath & "\Power Diary\Settings.txt"), False)
                writer.Write(MySettingsProperty.Settings.AutoLoad)
                writer.WriteLine
                writer.Write(MySettingsProperty.Settings.AutoLoadPath)
                writer.WriteLine
                writer.Write(MySettingsProperty.Settings.Updates)
                writer.Close
                Me.ImpExpProg.Value = 1
            End If
            If Me.DiariesCheck.Checked Then
                Dim num2 As Short = CShort((Me.ExpDiariesList.Count - 1))
                Dim i As Short = 0
                Do While (i <= num2)
                    Dim name As String = MyProject.Computer.FileSystem.GetDirectoryInfo(MyProject.Computer.FileSystem.GetDirectories((Application.StartupPath & "\Diaries"))(i)).Name
                    MyProject.Computer.FileSystem.CreateDirectory((Me.ExportBrowser.SelectedPath & "\Power Diary\" & name))
                    MyProject.Computer.FileSystem.CopyDirectory(Me.ExpDiariesList(i), (Me.ExportBrowser.SelectedPath & "\Power Diary\" & name), True)
                    Me.ImpExpProg.Value = (Me.ImpExpProg.Value + 1)
                    i = CShort((i + 1))
                Loop
            End If
        End Sub

        Private Sub ImportButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.ImpExpProg.Maximum = 2
            Me.ImpExpProg.Value = 0
            Me.ImportBrowser.ShowDialog
            If Me.SettingsCheck.Checked Then
                If Not MyProject.Computer.FileSystem.FileExists((Me.ImportBrowser.SelectedPath & "\Settings.txt")) Then
                    MessageBox.Show("Impossibile caricare le impostazioni, il salvataggio è danneggiato.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
                    Return
                End If
                Dim reader As New StreamReader((Me.ImportBrowser.SelectedPath & "\Settings.txt"))
                MySettingsProperty.Settings.AutoLoad = Conversions.ToBoolean(reader.ReadLine)
                MySettingsProperty.Settings.AutoLoadPath = reader.ReadLine
                MySettingsProperty.Settings.Updates = Conversions.ToBoolean(reader.ReadLine)
                MySettingsProperty.Settings.Save
                reader.Close
                Me.ImpExpProg.Value = 1
            End If
            If (Me.DiariesCheck.Checked AndAlso (MessageBox.Show("I diari attualmente presenti saranno eliminati e non sarà possibile recuperarli, si consiglia di effettuare una copia di backup. Proseguire ugualmente?", "Proseguire?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) <> DialogResult.No)) Then
                Dim num2 As Short = CShort((MyProject.Computer.FileSystem.GetDirectories(Me.ImportBrowser.SelectedPath).Count - 1))
                Dim num As Short = 0
                Do While True
                    If (num > num2) Then
                        Me.ImpExpProg.Value = 2
                        Exit Do
                    End If
                    MyProject.Computer.FileSystem.CopyDirectory(MyProject.Computer.FileSystem.GetDirectories(Me.ImportBrowser.SelectedPath)(num), (Application.StartupPath & "\Diaries\"), True)
                    num = CShort((num + 1))
                Loop
            End If
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.ExportButt = New Button
            Me.CancelButt = New Button
            Me.ImportButt = New Button
            Me.ItemsGroup = New GroupBox
            Me.DiariesButt = New Button
            Me.DiariesCheck = New CheckBox
            Me.SettingsCheck = New CheckBox
            Me.ImportBrowser = New FolderBrowserDialog
            Me.ExportBrowser = New FolderBrowserDialog
            Me.ImpExpProg = New PowerProgressbar
            Me.ItemsGroup.SuspendLayout
            Me.SuspendLayout
            Dim point As New Point(&H5D, &HA3)
            Me.ExportButt.Location = point
            Me.ExportButt.Name = "ExportButt"
            Dim size As New Size(&H4B, &H17)
            Me.ExportButt.Size = size
            Me.ExportButt.TabIndex = 14
            Me.ExportButt.Text = "&Esporta"
            Me.ExportButt.UseVisualStyleBackColor = True
            point = New Point(&HB6, &HA3)
            Me.CancelButt.Location = point
            Me.CancelButt.Name = "CancelButt"
            size = New Size(&H4B, &H17)
            Me.CancelButt.Size = size
            Me.CancelButt.TabIndex = 11
            Me.CancelButt.Text = "&Annulla"
            Me.CancelButt.UseVisualStyleBackColor = True
            point = New Point(12, &HA3)
            Me.ImportButt.Location = point
            Me.ImportButt.Name = "ImportButt"
            size = New Size(&H4B, &H17)
            Me.ImportButt.Size = size
            Me.ImportButt.TabIndex = 13
            Me.ImportButt.Text = "&Importa"
            Me.ImportButt.UseVisualStyleBackColor = True
            Me.ItemsGroup.Controls.Add(Me.DiariesButt)
            Me.ItemsGroup.Controls.Add(Me.DiariesCheck)
            Me.ItemsGroup.Controls.Add(Me.SettingsCheck)
            point = New Point(12, 12)
            Me.ItemsGroup.Location = point
            Me.ItemsGroup.Name = "ItemsGroup"
            size = New Size(&HF5, &H77)
            Me.ItemsGroup.Size = size
            Me.ItemsGroup.TabIndex = 12
            Me.ItemsGroup.TabStop = False
            Me.ItemsGroup.Text = "Seleziona gli elementi da importare / esportare:"
            point = New Point(&H3B, &H27)
            Me.DiariesButt.Location = point
            Me.DiariesButt.Name = "DiariesButt"
            size = New Size(90, &H15)
            Me.DiariesButt.Size = size
            Me.DiariesButt.TabIndex = 4
            Me.DiariesButt.Text = "&Seleziona diari"
            Me.DiariesButt.UseVisualStyleBackColor = True
            Me.DiariesCheck.AutoSize = True
            Me.DiariesCheck.Checked = True
            Me.DiariesCheck.CheckState = CheckState.Checked
            point = New Point(6, &H2A)
            Me.DiariesCheck.Location = point
            Me.DiariesCheck.Name = "DiariesCheck"
            size = New Size(&H2F, &H11)
            Me.DiariesCheck.Size = size
            Me.DiariesCheck.TabIndex = 2
            Me.DiariesCheck.Text = "Diari"
            Me.DiariesCheck.UseVisualStyleBackColor = True
            Me.SettingsCheck.AutoSize = True
            Me.SettingsCheck.Checked = True
            Me.SettingsCheck.CheckState = CheckState.Checked
            point = New Point(6, &H13)
            Me.SettingsCheck.Location = point
            Me.SettingsCheck.Name = "SettingsCheck"
            size = New Size(&H54, &H11)
            Me.SettingsCheck.Size = size
            Me.SettingsCheck.TabIndex = 3
            Me.SettingsCheck.Text = "Impostazioni"
            Me.SettingsCheck.UseVisualStyleBackColor = True
            Me.ImportBrowser.Description = "Seleziona la cartella dove sono salvate le impostazioni"
            Me.ExportBrowser.Description = "Seleziona la cartella dove vuoi esportare le impostazioni"
            Me.ImpExpProg.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or AnchorStyles.Bottom))
            Me.ImpExpProg.BackColor = Color.Transparent
            Me.ImpExpProg.BarColor = BarColors.Red
            Me.ImpExpProg.DisplayPercent = False
            point = New Point(12, &H89)
            Me.ImpExpProg.Location = point
            Me.ImpExpProg.Maximum = 2
            Me.ImpExpProg.Minimum = 0
            Me.ImpExpProg.Name = "ImpExpProg"
            size = New Size(&HF5, 20)
            Me.ImpExpProg.Size = size
            Me.ImpExpProg.TabIndex = &H11
            Me.ImpExpProg.Value = 0
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H10D, &HC6)
            Me.ClientSize = size
            Me.Controls.Add(Me.ImpExpProg)
            Me.Controls.Add(Me.ExportButt)
            Me.Controls.Add(Me.CancelButt)
            Me.Controls.Add(Me.ImportButt)
            Me.Controls.Add(Me.ItemsGroup)
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.Name = "IOSettings"
            Me.ShowIcon = False
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Importa / esporta impostazioni"
            Me.ItemsGroup.ResumeLayout(False)
            Me.ItemsGroup.PerformLayout
            Me.ResumeLayout(False)
        End Sub


        ' Properties
        Friend Overridable Property ExportButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._ExportButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._ExportButt Is Nothing) Then
                    RemoveHandler Me._ExportButt.Click, New EventHandler(AddressOf Me.ExportButt_Click)
                End If
                Me._ExportButt = WithEventsValue
                If (Not Me._ExportButt Is Nothing) Then
                    AddHandler Me._ExportButt.Click, New EventHandler(AddressOf Me.ExportButt_Click)
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

        Friend Overridable Property ImportButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._ImportButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._ImportButt Is Nothing) Then
                    RemoveHandler Me._ImportButt.Click, New EventHandler(AddressOf Me.ImportButt_Click)
                End If
                Me._ImportButt = WithEventsValue
                If (Not Me._ImportButt Is Nothing) Then
                    AddHandler Me._ImportButt.Click, New EventHandler(AddressOf Me.ImportButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ItemsGroup As GroupBox
            <DebuggerNonUserCode> _
            Get
                Return Me._ItemsGroup
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._ItemsGroup = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DiariesCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._DiariesCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                If (Not Me._DiariesCheck Is Nothing) Then
                    RemoveHandler Me._DiariesCheck.CheckedChanged, New EventHandler(AddressOf Me.DiariesCheck_CheckedChanged)
                End If
                Me._DiariesCheck = WithEventsValue
                If (Not Me._DiariesCheck Is Nothing) Then
                    AddHandler Me._DiariesCheck.CheckedChanged, New EventHandler(AddressOf Me.DiariesCheck_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property SettingsCheck As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._SettingsCheck
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._SettingsCheck = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DiariesButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._DiariesButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._DiariesButt Is Nothing) Then
                    RemoveHandler Me._DiariesButt.Click, New EventHandler(AddressOf Me.DiariesButt_Click)
                End If
                Me._DiariesButt = WithEventsValue
                If (Not Me._DiariesButt Is Nothing) Then
                    AddHandler Me._DiariesButt.Click, New EventHandler(AddressOf Me.DiariesButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ImportBrowser As FolderBrowserDialog
            <DebuggerNonUserCode> _
            Get
                Return Me._ImportBrowser
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As FolderBrowserDialog)
                Me._ImportBrowser = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ExportBrowser As FolderBrowserDialog
            <DebuggerNonUserCode> _
            Get
                Return Me._ExportBrowser
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As FolderBrowserDialog)
                Me._ExportBrowser = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ImpExpProg As PowerProgressbar
            <DebuggerNonUserCode> _
            Get
                Return Me._ImpExpProg
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PowerProgressbar)
                Me._ImpExpProg = WithEventsValue
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("ExportButt")> _
        Private _ExportButt As Button
        <AccessedThroughProperty("CancelButt")> _
        Private _CancelButt As Button
        <AccessedThroughProperty("ImportButt")> _
        Private _ImportButt As Button
        <AccessedThroughProperty("ItemsGroup")> _
        Private _ItemsGroup As GroupBox
        <AccessedThroughProperty("DiariesCheck")> _
        Private _DiariesCheck As CheckBox
        <AccessedThroughProperty("SettingsCheck")> _
        Private _SettingsCheck As CheckBox
        <AccessedThroughProperty("DiariesButt")> _
        Private _DiariesButt As Button
        <AccessedThroughProperty("ImportBrowser")> _
        Private _ImportBrowser As FolderBrowserDialog
        <AccessedThroughProperty("ExportBrowser")> _
        Private _ExportBrowser As FolderBrowserDialog
        <AccessedThroughProperty("ImpExpProg")> _
        Private _ImpExpProg As PowerProgressbar
        Public ExpDiariesList As List(Of String)
    End Class
End Namespace

