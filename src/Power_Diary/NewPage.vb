Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Power_Diary.My
Imports Power_Diary.My.Resources
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
    Public Class NewPage
        Inherits Form
        ' Methods
        Public Sub New()
            Me.InitializeComponent
        End Sub

        Private Sub AddFilesButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.AddFilesButt.Checked Then
                Me.AddFilesButt.Checked = True
                Me.AddFilesDial.ShowDialog
            Else
                Me.AddFilesButt.Checked = False
                Me.AttachedFiles.Clear
            End If
        End Sub

        Private Sub AddFilesDial_FileOk(ByVal sender As Object, ByVal e As CancelEventArgs)
            Dim num2 As Integer = (Me.AddFilesDial.FileNames.Length - 1)
            Dim i As Integer = 0
            Do While (i <= num2)
                Me.AttachedFiles.Add(Conversions.ToString(Me.AddFilesDial.FileNames.GetValue(i)))
                i += 1
            Loop
        End Sub

        Private Sub AnnullaButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (Me.Mode = 1) Then
                If (MessageBox.Show("Vuoi davvero annullare la modifica della pagina?", "Annullare?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes) Then
                    Me.Close
                End If
            ElseIf (MessageBox.Show("Vuoi davvero annullare la creazione della pagina?", "Annullare?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes) Then
                Me.Close
            End If
        End Sub

        Private Sub ArrabbiatoMenu_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.ArrabbiatoMenu.Checked = True
            Me.Umore = "Arrabbiato"
            Me.UmoreSplit.Image = Resources.ledpurple
            Me.MoltoBuonoMenu.Checked = False
            Me.BuonoMenu.Checked = False
            Me.NormaleMenu.Checked = False
            Me.MediocreMenu.Checked = False
            Me.TristeMenu.Checked = False
            Me.MoltoTristeMenu.Checked = False
            Me.OttimoMenu.Checked = False
            Me.MoltoArrabbiatoMenu.Checked = False
        End Sub

        Private Sub BuonoMenu_Click_1(ByVal sender As Object, ByVal e As EventArgs)
            Me.BuonoMenu.Checked = True
            Me.Umore = "Buono"
            Me.UmoreSplit.Image = Resources.ledlightgreen
            Me.MoltoBuonoMenu.Checked = False
            Me.OttimoMenu.Checked = False
            Me.NormaleMenu.Checked = False
            Me.MediocreMenu.Checked = False
            Me.TristeMenu.Checked = False
            Me.MoltoTristeMenu.Checked = False
            Me.ArrabbiatoMenu.Checked = False
            Me.MoltoArrabbiatoMenu.Checked = False
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub ImageButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.ImageButt.Checked Then
                Me.ImageButt.Checked = True
                Me.ImageDial.ShowDialog
            Else
                Me.ImageButt.Checked = False
                Me.ImagePath = ""
            End If
        End Sub

        Private Sub ImageDial_FileOk(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.ImagePath = Me.ImageDial.FileName
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Dim manager As New ComponentResourceManager(GetType(NewPage))
            Me.ToolStrip1 = New ToolStrip
            Me.RecordButt = New ToolStripButton
            Me.BgSoundButt = New ToolStripButton
            Me.ImageButt = New ToolStripButton
            Me.AddFilesButt = New ToolStripButton
            Me.AddInfoButt = New ToolStripButton
            Me.UmoreSplit = New ToolStripDropDownButton
            Me.OttimoMenu = New ToolStripMenuItem
            Me.MoltoBuonoMenu = New ToolStripMenuItem
            Me.BuonoMenu = New ToolStripMenuItem
            Me.NormaleMenu = New ToolStripMenuItem
            Me.MediocreMenu = New ToolStripMenuItem
            Me.TristeMenu = New ToolStripMenuItem
            Me.MoltoTristeMenu = New ToolStripMenuItem
            Me.ArrabbiatoMenu = New ToolStripMenuItem
            Me.MoltoArrabbiatoMenu = New ToolStripMenuItem
            Me.OKButt = New Button
            Me.AnnullaButt = New Button
            Me.TitoloText = New TextBox
            Me.Label1 = New Label
            Me.ScegliAudio = New OpenFileDialog
            Me.TestoText = New TextBox
            Me.ImageDial = New OpenFileDialog
            Me.AddFilesDial = New OpenFileDialog
            Me.ToolStrip1.SuspendLayout
            Me.SuspendLayout
            Me.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
            Dim size As New Size(&H18, &H18)
            Me.ToolStrip1.ImageScalingSize = size
            Dim toolStripItems As ToolStripItem() = New ToolStripItem() { Me.RecordButt, Me.BgSoundButt, Me.ImageButt, Me.AddFilesButt, Me.AddInfoButt, Me.UmoreSplit }
            Me.ToolStrip1.Items.AddRange(toolStripItems)
            Dim point As New Point(0, 0)
            Me.ToolStrip1.Location = point
            Me.ToolStrip1.Name = "ToolStrip1"
            size = New Size(&H1EC, &H1F)
            Me.ToolStrip1.Size = size
            Me.ToolStrip1.TabIndex = 3
            Me.ToolStrip1.Text = "ToolStrip1"
            Me.RecordButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.RecordButt.Image = Resources.krec_record
            Me.RecordButt.ImageTransparentColor = Color.Magenta
            Me.RecordButt.Name = "RecordButt"
            size = New Size(&H1C, &H1C)
            Me.RecordButt.Size = size
            Me.RecordButt.Text = "Registrazione dal microfono"
            Me.BgSoundButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.BgSoundButt.Image = Resources.sound
            Me.BgSoundButt.ImageTransparentColor = Color.Magenta
            Me.BgSoundButt.Name = "BgSoundButt"
            size = New Size(&H1C, &H1C)
            Me.BgSoundButt.Size = size
            Me.BgSoundButt.Text = "Aggiungi audio di sottofondo"
            Me.ImageButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.ImageButt.Image = Resources.image
            Me.ImageButt.ImageTransparentColor = Color.Magenta
            Me.ImageButt.Name = "ImageButt"
            size = New Size(&H1C, &H1C)
            Me.ImageButt.Size = size
            Me.ImageButt.Text = "Inserisci immagine"
            Me.AddFilesButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.AddFilesButt.Image = Resources.package
            Me.AddFilesButt.ImageTransparentColor = Color.Magenta
            Me.AddFilesButt.Name = "AddFilesButt"
            size = New Size(&H1C, &H1C)
            Me.AddFilesButt.Size = size
            Me.AddFilesButt.Text = "Allega file..."
            Me.AddInfoButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.AddInfoButt.Image = Resources.edit_add
            Me.AddInfoButt.ImageTransparentColor = Color.Magenta
            Me.AddInfoButt.Name = "AddInfoButt"
            size = New Size(&H1C, &H1C)
            Me.AddInfoButt.Size = size
            Me.AddInfoButt.Text = "Aggiungi dati personalizzati"
            Me.UmoreSplit.DisplayStyle = ToolStripItemDisplayStyle.Image
            toolStripItems = New ToolStripItem() { Me.OttimoMenu, Me.MoltoBuonoMenu, Me.BuonoMenu, Me.NormaleMenu, Me.MediocreMenu, Me.TristeMenu, Me.MoltoTristeMenu, Me.ArrabbiatoMenu, Me.MoltoArrabbiatoMenu }
            Me.UmoreSplit.DropDownItems.AddRange(toolStripItems)
            Me.UmoreSplit.Image = Resources.ledyellow
            Me.UmoreSplit.ImageTransparentColor = Color.Magenta
            Me.UmoreSplit.Name = "UmoreSplit"
            size = New Size(&H25, &H1C)
            Me.UmoreSplit.Size = size
            Me.UmoreSplit.Text = "Umore della giornata"
            Me.OttimoMenu.Image = Resources.ledgreen
            Me.OttimoMenu.ImageTransparentColor = Color.White
            Me.OttimoMenu.Name = "OttimoMenu"
            size = New Size(&HAC, 30)
            Me.OttimoMenu.Size = size
            Me.OttimoMenu.Text = "Ottimo"
            Me.MoltoBuonoMenu.ImageTransparentColor = Color.White
            Me.MoltoBuonoMenu.Name = "MoltoBuonoMenu"
            size = New Size(&HAC, 30)
            Me.MoltoBuonoMenu.Size = size
            Me.MoltoBuonoMenu.Text = "Molto buono"
            Me.BuonoMenu.Image = Resources.ledlightgreen
            Me.BuonoMenu.ImageTransparentColor = Color.White
            Me.BuonoMenu.Name = "BuonoMenu"
            size = New Size(&HAC, 30)
            Me.BuonoMenu.Size = size
            Me.BuonoMenu.Text = "Buono"
            Me.NormaleMenu.Checked = True
            Me.NormaleMenu.CheckState = CheckState.Checked
            Me.NormaleMenu.Image = Resources.ledyellow
            Me.NormaleMenu.ImageTransparentColor = Color.White
            Me.NormaleMenu.Name = "NormaleMenu"
            size = New Size(&HAC, 30)
            Me.NormaleMenu.Size = size
            Me.NormaleMenu.Text = "Normale"
            Me.MediocreMenu.Image = Resources.ledorange
            Me.MediocreMenu.ImageTransparentColor = Color.White
            Me.MediocreMenu.Name = "MediocreMenu"
            size = New Size(&HAC, 30)
            Me.MediocreMenu.Size = size
            Me.MediocreMenu.Text = "Mediocre"
            Me.TristeMenu.Image = Resources.ledlightblue
            Me.TristeMenu.ImageTransparentColor = Color.White
            Me.TristeMenu.Name = "TristeMenu"
            size = New Size(&HAC, 30)
            Me.TristeMenu.Size = size
            Me.TristeMenu.Text = "Triste"
            Me.MoltoTristeMenu.Image = Resources.ledblue
            Me.MoltoTristeMenu.ImageTransparentColor = Color.White
            Me.MoltoTristeMenu.Name = "MoltoTristeMenu"
            size = New Size(&HAC, 30)
            Me.MoltoTristeMenu.Size = size
            Me.MoltoTristeMenu.Text = "Molto triste"
            Me.ArrabbiatoMenu.Image = Resources.ledpurple
            Me.ArrabbiatoMenu.ImageTransparentColor = Color.White
            Me.ArrabbiatoMenu.Name = "ArrabbiatoMenu"
            size = New Size(&HAC, 30)
            Me.ArrabbiatoMenu.Size = size
            Me.ArrabbiatoMenu.Text = "Arrabbiato"
            Me.MoltoArrabbiatoMenu.Image = Resources.ledred
            Me.MoltoArrabbiatoMenu.ImageTransparentColor = Color.White
            Me.MoltoArrabbiatoMenu.Name = "MoltoArrabbiatoMenu"
            size = New Size(&HAC, 30)
            Me.MoltoArrabbiatoMenu.Size = size
            Me.MoltoArrabbiatoMenu.Text = "Molto arrabbiato"
            Me.OKButt.Anchor = (AnchorStyles.Right Or AnchorStyles.Bottom)
            point = New Point(&H195, &H14B)
            Me.OKButt.Location = point
            Me.OKButt.Name = "OKButt"
            size = New Size(&H4B, &H17)
            Me.OKButt.Size = size
            Me.OKButt.TabIndex = 4
            Me.OKButt.Text = "&OK"
            Me.OKButt.UseVisualStyleBackColor = True
            Me.AnnullaButt.Anchor = (AnchorStyles.Right Or AnchorStyles.Bottom)
            point = New Point(&H144, &H14B)
            Me.AnnullaButt.Location = point
            Me.AnnullaButt.Name = "AnnullaButt"
            size = New Size(&H4B, &H17)
            Me.AnnullaButt.Size = size
            Me.AnnullaButt.TabIndex = 5
            Me.AnnullaButt.Text = "&Annulla"
            Me.AnnullaButt.UseVisualStyleBackColor = True
            Me.TitoloText.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or AnchorStyles.Top))
            Me.TitoloText.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(&H6F, &H22)
            Me.TitoloText.Location = point
            Me.TitoloText.Name = "TitoloText"
            size = New Size(&H171, 20)
            Me.TitoloText.Size = size
            Me.TitoloText.TabIndex = &H26
            Me.Label1.AutoSize = True
            point = New Point(12, &H25)
            Me.Label1.Location = point
            Me.Label1.Name = "Label1"
            size = New Size(&H5D, 13)
            Me.Label1.Size = size
            Me.Label1.TabIndex = &H27
            Me.Label1.Text = "Titolo della pagina"
            Me.ScegliAudio.Filter = "File audio|*.wav;*.mp3;*.wma"
            Me.ScegliAudio.Title = "Scegli il file audio da usare come sottofondo"
            Me.TestoText.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or (AnchorStyles.Bottom Or AnchorStyles.Top)))
            Me.TestoText.BackColor = MySettings.Default.BackColor
            Me.TestoText.DataBindings.Add(New Binding("Font", MySettings.Default, "Font", True, DataSourceUpdateMode.OnPropertyChanged))
            Me.TestoText.DataBindings.Add(New Binding("BackColor", MySettings.Default, "BackColor", True, DataSourceUpdateMode.OnPropertyChanged))
            Me.TestoText.Font = MySettings.Default.Font
            point = New Point(12, &H3E)
            Me.TestoText.Location = point
            Me.TestoText.Multiline = True
            Me.TestoText.Name = "TestoText"
            Me.TestoText.ScrollBars = ScrollBars.Vertical
            size = New Size(&H1D4, &H107)
            Me.TestoText.Size = size
            Me.TestoText.TabIndex = &H21
            Me.ImageDial.Filter = "File di immagine|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.wmf;*.emf;*ico;*cur"
            Me.AddFilesDial.Filter = "Tutti i files|*.*"
            Me.AddFilesDial.Multiselect = True
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H1EC, &H16E)
            Me.ClientSize = size
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.TitoloText)
            Me.Controls.Add(Me.TestoText)
            Me.Controls.Add(Me.AnnullaButt)
            Me.Controls.Add(Me.OKButt)
            Me.Controls.Add(Me.ToolStrip1)
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.Name = "NewPage"
            Me.Text = "Nuova pagina"
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout
            Me.ResumeLayout(False)
            Me.PerformLayout
        End Sub

        Public Sub LoadForm(ByVal OpenMode As Byte, ByVal PageID As Integer)
            If (OpenMode = 1) Then
                Me.Mode = OpenMode
                Me.ID = PageID
                Me.Text = "Modifica pagina"
                Dim strArray As String() = New String() { Application.StartupPath, "\Diaries\", MyProject.Forms.Main.NomeLab.Text, "\", Conversions.ToString(Me.ID), "\", Conversions.ToString(Me.ID), ".txt" }
                Dim reader As New StreamReader(String.Concat(strArray))
                Me.TitoloText.Text = reader.ReadLine
                Dim str7 As String = reader.ReadLine
                If (str7 = "Ottimo") Then
                    Me.UmoreSplit.Image = Resources.ledgreen
                    Me.OttimoMenu.Checked = True
                    Me.Umore = "Ottimo"
                    Me.UmoreSplit.Image = Resources.ledgreen
                    Me.MoltoBuonoMenu.Checked = False
                    Me.BuonoMenu.Checked = False
                    Me.NormaleMenu.Checked = False
                    Me.MediocreMenu.Checked = False
                    Me.TristeMenu.Checked = False
                    Me.MoltoTristeMenu.Checked = False
                    Me.ArrabbiatoMenu.Checked = False
                    Me.MoltoArrabbiatoMenu.Checked = False
                ElseIf (str7 = "Molto buono") Then
                    Me.MoltoBuonoMenu.Checked = True
                    Me.Umore = "Molto buono"
                    Me.UmoreSplit.Image = Resources.empty
                    Me.OttimoMenu.Checked = False
                    Me.BuonoMenu.Checked = False
                    Me.NormaleMenu.Checked = False
                    Me.MediocreMenu.Checked = False
                    Me.TristeMenu.Checked = False
                    Me.MoltoTristeMenu.Checked = False
                    Me.ArrabbiatoMenu.Checked = False
                    Me.MoltoArrabbiatoMenu.Checked = False
                ElseIf (str7 = "Buono") Then
                    Me.UmoreSplit.Image = Resources.ledlightgreen
                    Me.BuonoMenu.Checked = True
                    Me.Umore = "Buono"
                    Me.UmoreSplit.Image = Resources.ledlightgreen
                    Me.MoltoBuonoMenu.Checked = False
                    Me.OttimoMenu.Checked = False
                    Me.NormaleMenu.Checked = False
                    Me.MediocreMenu.Checked = False
                    Me.TristeMenu.Checked = False
                    Me.MoltoTristeMenu.Checked = False
                    Me.ArrabbiatoMenu.Checked = False
                    Me.MoltoArrabbiatoMenu.Checked = False
                ElseIf (str7 = "Normale") Then
                    Me.UmoreSplit.Image = Resources.ledyellow
                    Me.NormaleMenu.Checked = True
                    Me.Umore = "Normale"
                    Me.UmoreSplit.Image = Resources.ledyellow
                    Me.MoltoBuonoMenu.Checked = False
                    Me.BuonoMenu.Checked = False
                    Me.OttimoMenu.Checked = False
                    Me.MediocreMenu.Checked = False
                    Me.TristeMenu.Checked = False
                    Me.MoltoTristeMenu.Checked = False
                    Me.ArrabbiatoMenu.Checked = False
                    Me.MoltoArrabbiatoMenu.Checked = False
                ElseIf (str7 = "Mediocre") Then
                    Me.UmoreSplit.Image = Resources.ledorange
                    Me.MediocreMenu.Checked = True
                    Me.Umore = "Mediocre"
                    Me.UmoreSplit.Image = Resources.ledorange
                    Me.MoltoBuonoMenu.Checked = False
                    Me.BuonoMenu.Checked = False
                    Me.NormaleMenu.Checked = False
                    Me.OttimoMenu.Checked = False
                    Me.TristeMenu.Checked = False
                    Me.MoltoTristeMenu.Checked = False
                    Me.ArrabbiatoMenu.Checked = False
                    Me.MoltoArrabbiatoMenu.Checked = False
                ElseIf (str7 = "Triste") Then
                    Me.UmoreSplit.Image = Resources.ledlightblue
                    Me.TristeMenu.Checked = True
                    Me.Umore = "Triste"
                    Me.UmoreSplit.Image = Resources.ledlightblue
                    Me.MoltoBuonoMenu.Checked = False
                    Me.BuonoMenu.Checked = False
                    Me.NormaleMenu.Checked = False
                    Me.MediocreMenu.Checked = False
                    Me.OttimoMenu.Checked = False
                    Me.MoltoTristeMenu.Checked = False
                    Me.ArrabbiatoMenu.Checked = False
                    Me.MoltoArrabbiatoMenu.Checked = False
                ElseIf (str7 = "Molto triste") Then
                    Me.UmoreSplit.Image = Resources.ledblue
                    Me.MoltoTristeMenu.Checked = True
                    Me.Umore = "Molto triste"
                    Me.UmoreSplit.Image = Resources.ledblue
                    Me.MoltoBuonoMenu.Checked = False
                    Me.BuonoMenu.Checked = False
                    Me.NormaleMenu.Checked = False
                    Me.MediocreMenu.Checked = False
                    Me.TristeMenu.Checked = False
                    Me.OttimoMenu.Checked = False
                    Me.ArrabbiatoMenu.Checked = False
                    Me.MoltoArrabbiatoMenu.Checked = False
                ElseIf (str7 = "Arrabbiato") Then
                    Me.UmoreSplit.Image = Resources.ledpurple
                    Me.ArrabbiatoMenu.Checked = True
                    Me.Umore = "Arrabbiato"
                    Me.UmoreSplit.Image = Resources.ledpurple
                    Me.MoltoBuonoMenu.Checked = False
                    Me.BuonoMenu.Checked = False
                    Me.NormaleMenu.Checked = False
                    Me.MediocreMenu.Checked = False
                    Me.TristeMenu.Checked = False
                    Me.MoltoTristeMenu.Checked = False
                    Me.OttimoMenu.Checked = False
                    Me.MoltoArrabbiatoMenu.Checked = False
                ElseIf (str7 = "Molto arrabbiato") Then
                    Me.UmoreSplit.Image = Resources.ledred
                    Me.MoltoArrabbiatoMenu.Checked = True
                    Me.Umore = "Molto arrabbiato"
                    Me.UmoreSplit.Image = Resources.ledred
                    Me.MoltoBuonoMenu.Checked = False
                    Me.BuonoMenu.Checked = False
                    Me.NormaleMenu.Checked = False
                    Me.MediocreMenu.Checked = False
                    Me.TristeMenu.Checked = False
                    Me.MoltoTristeMenu.Checked = False
                    Me.ArrabbiatoMenu.Checked = False
                    Me.OttimoMenu.Checked = False
                End If
                reader.ReadLine
                reader.ReadLine
                Me.TestoText.Text = reader.ReadToEnd
                reader.Close
                strArray = New String() { Application.StartupPath, "\Diaries\", MyProject.Forms.Main.NomeLab.Text, "\", Conversions.ToString(Me.ID) }
                Dim num5 As Integer = (MyProject.Computer.FileSystem.GetFiles(String.Concat(strArray)).Count - 1)
                Dim num As Integer = 0
                Do While True
                    Dim strArray2 As String()
                    If (num > num5) Then
                        strArray2 = New String() { Application.StartupPath, "\Diaries\", MyProject.Forms.Main.NomeLab.Text, "\", Conversions.ToString(Me.ID) }
                        Dim num6 As Integer = (MyProject.Computer.FileSystem.GetFiles(String.Concat(strArray2)).Count - 1)
                        Dim num2 As Integer = 0
                        Do While True
                            If (num2 > num6) Then
                                Dim list As New List(Of String)
                                strArray2 = New String() { Application.StartupPath, "\Diaries\", MyProject.Forms.Main.NomeLab.Text, "\", Conversions.ToString(Me.ID) }
                                Dim num7 As Integer = (MyProject.Computer.FileSystem.GetFiles(String.Concat(strArray2)).Count - 1)
                                Dim i As Integer = 0
                                Do While (i <= num7)
                                    strArray = New String() { Application.StartupPath, "\Diaries\", MyProject.Forms.Main.NomeLab.Text, "\", Conversions.ToString(Me.ID) }
                                    Dim str5 As String = MyProject.Computer.FileSystem.GetFileInfo(MyProject.Computer.FileSystem.GetFiles(String.Concat(strArray))(i)).Name
                                    If ((str5.Length > 4) AndAlso ((Conversions.ToString(str5(0)) & Conversions.ToString(str5(1)) & Conversions.ToString(str5(2)) & Conversions.ToString(str5(3))) = "File")) Then
                                        strArray2 = New String() { Application.StartupPath, "\Diaries\", MyProject.Forms.Main.NomeLab.Text, "\", Conversions.ToString(Me.ID) }
                                        list.Add(MyProject.Computer.FileSystem.GetFiles(String.Concat(strArray2))(i))
                                        Me.AddFilesButt.Checked = True
                                    End If
                                    i += 1
                                Loop
                                Exit Do
                            End If
                            strArray = New String() { Application.StartupPath, "\Diaries\", MyProject.Forms.Main.NomeLab.Text, "\", Conversions.ToString(Me.ID) }
                            Dim str3 As String = MyProject.Computer.FileSystem.GetFileInfo(MyProject.Computer.FileSystem.GetFiles(String.Concat(strArray))(num2)).Name
                            If (str3.Length > 5) Then
                                strArray2 = New String() { Conversions.ToString(str3(0)), Conversions.ToString(str3(1)), Conversions.ToString(str3(2)), Conversions.ToString(str3(3)), Conversions.ToString(str3(4)) }
                                If (String.Concat(strArray2) = "Image") Then
                                    strArray2 = New String() { Application.StartupPath, "\Diaries\", MyProject.Forms.Main.NomeLab.Text, "\", Conversions.ToString(Me.ID) }
                                    Me.ImageDial.FileName = MyProject.Computer.FileSystem.GetFiles(String.Concat(strArray2))(num2)
                                    Me.ImageButt.Checked = True
                                End If
                            End If
                            num2 += 1
                        Loop
                        Exit Do
                    End If
                    strArray2 = New String() { Application.StartupPath, "\Diaries\", MyProject.Forms.Main.NomeLab.Text, "\", Conversions.ToString(Me.ID) }
                    Dim name As String = MyProject.Computer.FileSystem.GetFileInfo(MyProject.Computer.FileSystem.GetFiles(String.Concat(strArray2))(num)).Name
                    If (name.Length > 5) Then
                        strArray2 = New String() { Conversions.ToString(name(0)), Conversions.ToString(name(1)), Conversions.ToString(name(2)), Conversions.ToString(name(3)), Conversions.ToString(name(4)) }
                        If (String.Concat(strArray2) = "Audio") Then
                            strArray2 = New String() { Application.StartupPath, "\Diaries\", MyProject.Forms.Main.NomeLab.Text, "\", Conversions.ToString(Me.ID) }
                            Me.ScegliAudio.FileName = MyProject.Computer.FileSystem.GetFiles(String.Concat(strArray2))(num)
                            Me.BgSoundButt.Checked = True
                        End If
                    End If
                    num += 1
                Loop
            End If
        End Sub

        Private Sub MediocreMenu_Click_1(ByVal sender As Object, ByVal e As EventArgs)
            Me.MediocreMenu.Checked = True
            Me.Umore = "Mediocre"
            Me.UmoreSplit.Image = Resources.ledorange
            Me.MoltoBuonoMenu.Checked = False
            Me.BuonoMenu.Checked = False
            Me.NormaleMenu.Checked = False
            Me.OttimoMenu.Checked = False
            Me.TristeMenu.Checked = False
            Me.MoltoTristeMenu.Checked = False
            Me.ArrabbiatoMenu.Checked = False
            Me.MoltoArrabbiatoMenu.Checked = False
        End Sub

        Private Sub MoltoArrabbiatoMenu_Click_1(ByVal sender As Object, ByVal e As EventArgs)
            Me.MoltoArrabbiatoMenu.Checked = True
            Me.Umore = "Molto arrabbiato"
            Me.UmoreSplit.Image = Resources.ledred
            Me.MoltoBuonoMenu.Checked = False
            Me.BuonoMenu.Checked = False
            Me.NormaleMenu.Checked = False
            Me.MediocreMenu.Checked = False
            Me.TristeMenu.Checked = False
            Me.MoltoTristeMenu.Checked = False
            Me.ArrabbiatoMenu.Checked = False
            Me.OttimoMenu.Checked = False
        End Sub

        Private Sub MoltoBuonoMenu_Click_1(ByVal sender As Object, ByVal e As EventArgs)
            Me.MoltoBuonoMenu.Checked = True
            Me.Umore = "Molto buono"
            Me.UmoreSplit.Image = Resources.empty
            Me.OttimoMenu.Checked = False
            Me.BuonoMenu.Checked = False
            Me.NormaleMenu.Checked = False
            Me.MediocreMenu.Checked = False
            Me.TristeMenu.Checked = False
            Me.MoltoTristeMenu.Checked = False
            Me.ArrabbiatoMenu.Checked = False
            Me.MoltoArrabbiatoMenu.Checked = False
        End Sub

        Private Sub MoltoTristeMenu_Click_1(ByVal sender As Object, ByVal e As EventArgs)
            Me.MoltoTristeMenu.Checked = True
            Me.Umore = "Molto triste"
            Me.UmoreSplit.Image = Resources.ledblue
            Me.MoltoBuonoMenu.Checked = False
            Me.BuonoMenu.Checked = False
            Me.NormaleMenu.Checked = False
            Me.MediocreMenu.Checked = False
            Me.TristeMenu.Checked = False
            Me.OttimoMenu.Checked = False
            Me.ArrabbiatoMenu.Checked = False
            Me.MoltoArrabbiatoMenu.Checked = False
        End Sub

        Private Sub NormaleMenu_Click_1(ByVal sender As Object, ByVal e As EventArgs)
            Me.NormaleMenu.Checked = True
            Me.Umore = "Normale"
            Me.UmoreSplit.Image = Resources.ledyellow
            Me.MoltoBuonoMenu.Checked = False
            Me.BuonoMenu.Checked = False
            Me.OttimoMenu.Checked = False
            Me.MediocreMenu.Checked = False
            Me.TristeMenu.Checked = False
            Me.MoltoTristeMenu.Checked = False
            Me.ArrabbiatoMenu.Checked = False
            Me.MoltoArrabbiatoMenu.Checked = False
        End Sub

        Private Sub OKButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim strArray As String()
            Dim str As String = (Application.StartupPath & "\Diaries\" & MyProject.Forms.Main.NomeLab.Text & "\")
            Select Case Me.Mode
                Case 0
                    Dim num As Short = 1
                    Do While True
                        If Not MyProject.Computer.FileSystem.DirectoryExists((str & Conversions.ToString(CInt(num)))) Then
                            MyProject.Computer.FileSystem.CreateDirectory((str & Conversions.ToString(CInt(num))))
                            strArray = New String() { str, Conversions.ToString(CInt(num)), "\", Conversions.ToString(CInt(num)), ".txt" }
                            Dim writer As New StreamWriter(String.Concat(strArray))
                            writer.Write(Me.TitoloText.Text)
                            writer.WriteLine
                            writer.Write(Me.Umore)
                            writer.WriteLine
                            writer.Write(Strings.Format(MyProject.Computer.Clock.LocalTime, "dd/MM/yyyy"))
                            writer.WriteLine
                            writer.Write(Strings.Format(MyProject.Computer.Clock.LocalTime, "HH:mm:ss"))
                            writer.WriteLine
                            writer.Write(Me.TestoText.Text)
                            writer.Close
                            If Me.BgSoundButt.Checked Then
                                MyProject.Computer.FileSystem.CopyFile(Me.SoundPath, (str & Conversions.ToString(CInt(num)) & "\Audio" & MyProject.Computer.FileSystem.GetFileInfo(Me.ScegliAudio.FileName).Extension), True)
                            End If
                            If Me.ImageButt.Checked Then
                                MyProject.Computer.FileSystem.CopyFile(Me.ImagePath, (str & Conversions.ToString(CInt(num)) & "\Image" & MyProject.Computer.FileSystem.GetFileInfo(Me.ImageDial.FileName).Extension), True)
                            End If
                            If Me.AddFilesButt.Checked Then
                                Dim count As Integer = Me.AttachedFiles.Count
                                Dim i As Integer = 1
                                Do While (i <= count)
                                    strArray = New String() { str, Conversions.ToString(CInt(num)), "\File ", Conversions.ToString(i), MyProject.Computer.FileSystem.GetFileInfo(Conversions.ToString(Me.AddFilesDial.FileNames.GetValue(CInt((i - 1))))).Extension }
                                    MyProject.Computer.FileSystem.CopyFile(Me.AttachedFiles((i - 1)), String.Concat(strArray))
                                    i += 1
                                Loop
                            End If
                            Dim item As New ListViewItem
                            item.Name = Conversions.ToString(CInt(num))
                            item.Text = Strings.Format(MyProject.Computer.Clock.LocalTime, "dd/MM/yyyy")
                            item.ImageIndex = Conversions.ToInteger("0")
                            Dim item3 As New ListViewSubItem
                            Dim item4 As New ListViewSubItem
                            Dim item2 As New ListViewSubItem
                            item3.Text = Strings.Format(MyProject.Computer.Clock.LocalTime, "HH:mm:ss")
                            item4.Text = Me.TitoloText.Text
                            item2.Text = Me.Umore
                            item.SubItems.Add(item3)
                            item.SubItems.Add(item4)
                            item.SubItems.Add(item2)
                            MyProject.Forms.Main.PagineList.Items.Add(item)
                            Exit Do
                        End If
                        num = CShort((num + 1))
                    Loop
                    Exit Select
                Case 1
                    strArray = New String() { str, Conversions.ToString(Me.ID), "\", Conversions.ToString(Me.ID), ".txt" }
                    Dim reader As New StreamReader(String.Concat(strArray))
                    reader.ReadLine
                    reader.ReadLine
                    Dim str2 As String = reader.ReadLine
                    Dim str3 As String = reader.ReadLine
                    reader.Close
                    strArray = New String() { str, Conversions.ToString(Me.ID), "\", Conversions.ToString(Me.ID), ".txt" }
                    Dim writer2 As New StreamWriter(String.Concat(strArray), False)
                    writer2.Write(Me.TitoloText.Text)
                    writer2.WriteLine
                    writer2.Write(Me.Umore)
                    writer2.WriteLine
                    writer2.Write(str2)
                    writer2.WriteLine
                    writer2.Write(str3)
                    writer2.WriteLine
                    writer2.Write(Me.TestoText.Text)
                    writer2.Close
                    If Me.BgSoundButt.Checked Then
                        MyProject.Computer.FileSystem.CopyFile(Me.SoundPath, (str & Conversions.ToString(Me.ID) & "\Audio" & MyProject.Computer.FileSystem.GetFileInfo(Me.ScegliAudio.FileName).Extension), True)
                    End If
                    If Me.ImageButt.Checked Then
                        MyProject.Computer.FileSystem.CopyFile(Me.ImagePath, (str & Conversions.ToString(Me.ID) & "\Image" & MyProject.Computer.FileSystem.GetFileInfo(Me.ImageDial.FileName).Extension), True)
                    End If
                    If Me.AddFilesButt.Checked Then
                        Dim count As Integer = Me.AttachedFiles.Count
                        Dim i As Integer = 1
                        Do While (i <= count)
                            strArray = New String() { str, Conversions.ToString(Me.ID), "\File ", Conversions.ToString(i), MyProject.Computer.FileSystem.GetFileInfo(Conversions.ToString(Me.AddFilesDial.FileNames.GetValue(CInt((i - 1))))).Extension }
                            MyProject.Computer.FileSystem.CopyFile(Me.AttachedFiles((i - 1)), String.Concat(strArray))
                            i += 1
                        Loop
                    End If
                    MyProject.Forms.Main.PagineList.SelectedItems(0).Remove
                    Dim item5 As New ListViewItem
                    item5.Name = Conversions.ToString(Me.ID)
                    item5.Text = Strings.Format(str2, "")
                    item5.ImageIndex = Conversions.ToInteger("0")
                    Dim item As New ListViewSubItem
                    Dim item8 As New ListViewSubItem
                    Dim item6 As New ListViewSubItem
                    item.Text = Strings.Format(str3, "")
                    item8.Text = Me.TitoloText.Text
                    item6.Text = Me.Umore
                    item5.SubItems.Add(item)
                    item5.SubItems.Add(item8)
                    item5.SubItems.Add(item6)
                    MyProject.Forms.Main.PagineList.Items.Add(item5)
                    Exit Select
                Case Else
                    Exit Select
            End Select
            Me.Close
        End Sub

        Private Sub OttimoMenu_Click_1(ByVal sender As Object, ByVal e As EventArgs)
            Me.OttimoMenu.Checked = True
            Me.Umore = "Ottimo"
            Me.UmoreSplit.Image = Resources.ledgreen
            Me.MoltoBuonoMenu.Checked = False
            Me.BuonoMenu.Checked = False
            Me.NormaleMenu.Checked = False
            Me.MediocreMenu.Checked = False
            Me.TristeMenu.Checked = False
            Me.MoltoTristeMenu.Checked = False
            Me.ArrabbiatoMenu.Checked = False
            Me.MoltoArrabbiatoMenu.Checked = False
        End Sub

        Private Sub RecordButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.Record.Show
        End Sub

        Private Sub ScegliAudio_FileOk(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.SoundPath = Me.ScegliAudio.FileName
        End Sub

        Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.BgSoundButt.Checked Then
                Me.BgSoundButt.Checked = True
                Me.ScegliAudio.ShowDialog
            Else
                Me.BgSoundButt.Checked = False
                Me.SoundPath = ""
            End If
        End Sub

        Private Sub TristeMenu_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.TristeMenu.Checked = True
            Me.Umore = "Triste"
            Me.UmoreSplit.Image = Resources.ledlightblue
            Me.MoltoBuonoMenu.Checked = False
            Me.BuonoMenu.Checked = False
            Me.NormaleMenu.Checked = False
            Me.MediocreMenu.Checked = False
            Me.OttimoMenu.Checked = False
            Me.MoltoTristeMenu.Checked = False
            Me.ArrabbiatoMenu.Checked = False
            Me.MoltoArrabbiatoMenu.Checked = False
        End Sub


        ' Properties
        Friend Overridable Property ToolStrip1 As ToolStrip
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStrip1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStrip)
                Me._ToolStrip1 = WithEventsValue
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

        Friend Overridable Property TitoloText As TextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._TitoloText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TextBox)
                Me._TitoloText = WithEventsValue
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

        Friend Overridable Property BgSoundButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._BgSoundButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._BgSoundButt Is Nothing) Then
                    RemoveHandler Me._BgSoundButt.Click, New EventHandler(AddressOf Me.ToolStripButton2_Click)
                End If
                Me._BgSoundButt = WithEventsValue
                If (Not Me._BgSoundButt Is Nothing) Then
                    AddHandler Me._BgSoundButt.Click, New EventHandler(AddressOf Me.ToolStripButton2_Click)
                End If
            End Set
        End Property

        Friend Overridable Property AddInfoButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._AddInfoButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                Me._AddInfoButt = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ScegliAudio As OpenFileDialog
            <DebuggerNonUserCode> _
            Get
                Return Me._ScegliAudio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As OpenFileDialog)
                If (Not Me._ScegliAudio Is Nothing) Then
                    RemoveHandler Me._ScegliAudio.FileOk, New CancelEventHandler(AddressOf Me.ScegliAudio_FileOk)
                End If
                Me._ScegliAudio = WithEventsValue
                If (Not Me._ScegliAudio Is Nothing) Then
                    AddHandler Me._ScegliAudio.FileOk, New CancelEventHandler(AddressOf Me.ScegliAudio_FileOk)
                End If
            End Set
        End Property

        Friend Overridable Property ImageButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._ImageButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._ImageButt Is Nothing) Then
                    RemoveHandler Me._ImageButt.Click, New EventHandler(AddressOf Me.ImageButt_Click)
                End If
                Me._ImageButt = WithEventsValue
                If (Not Me._ImageButt Is Nothing) Then
                    AddHandler Me._ImageButt.Click, New EventHandler(AddressOf Me.ImageButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property RecordButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._RecordButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._RecordButt Is Nothing) Then
                    RemoveHandler Me._RecordButt.Click, New EventHandler(AddressOf Me.RecordButt_Click)
                End If
                Me._RecordButt = WithEventsValue
                If (Not Me._RecordButt Is Nothing) Then
                    AddHandler Me._RecordButt.Click, New EventHandler(AddressOf Me.RecordButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ImageDial As OpenFileDialog
            <DebuggerNonUserCode> _
            Get
                Return Me._ImageDial
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As OpenFileDialog)
                If (Not Me._ImageDial Is Nothing) Then
                    RemoveHandler Me._ImageDial.FileOk, New CancelEventHandler(AddressOf Me.ImageDial_FileOk)
                End If
                Me._ImageDial = WithEventsValue
                If (Not Me._ImageDial Is Nothing) Then
                    AddHandler Me._ImageDial.FileOk, New CancelEventHandler(AddressOf Me.ImageDial_FileOk)
                End If
            End Set
        End Property

        Friend Overridable Property AddFilesButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._AddFilesButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._AddFilesButt Is Nothing) Then
                    RemoveHandler Me._AddFilesButt.Click, New EventHandler(AddressOf Me.AddFilesButt_Click)
                End If
                Me._AddFilesButt = WithEventsValue
                If (Not Me._AddFilesButt Is Nothing) Then
                    AddHandler Me._AddFilesButt.Click, New EventHandler(AddressOf Me.AddFilesButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property AddFilesDial As OpenFileDialog
            <DebuggerNonUserCode> _
            Get
                Return Me._AddFilesDial
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As OpenFileDialog)
                If (Not Me._AddFilesDial Is Nothing) Then
                    RemoveHandler Me._AddFilesDial.FileOk, New CancelEventHandler(AddressOf Me.AddFilesDial_FileOk)
                End If
                Me._AddFilesDial = WithEventsValue
                If (Not Me._AddFilesDial Is Nothing) Then
                    AddHandler Me._AddFilesDial.FileOk, New CancelEventHandler(AddressOf Me.AddFilesDial_FileOk)
                End If
            End Set
        End Property

        Friend Overridable Property UmoreSplit As ToolStripDropDownButton
            <DebuggerNonUserCode> _
            Get
                Return Me._UmoreSplit
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripDropDownButton)
                Me._UmoreSplit = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OttimoMenu As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._OttimoMenu
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._OttimoMenu Is Nothing) Then
                    RemoveHandler Me._OttimoMenu.Click, New EventHandler(AddressOf Me.OttimoMenu_Click_1)
                End If
                Me._OttimoMenu = WithEventsValue
                If (Not Me._OttimoMenu Is Nothing) Then
                    AddHandler Me._OttimoMenu.Click, New EventHandler(AddressOf Me.OttimoMenu_Click_1)
                End If
            End Set
        End Property

        Friend Overridable Property MoltoBuonoMenu As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._MoltoBuonoMenu
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._MoltoBuonoMenu Is Nothing) Then
                    RemoveHandler Me._MoltoBuonoMenu.Click, New EventHandler(AddressOf Me.MoltoBuonoMenu_Click_1)
                End If
                Me._MoltoBuonoMenu = WithEventsValue
                If (Not Me._MoltoBuonoMenu Is Nothing) Then
                    AddHandler Me._MoltoBuonoMenu.Click, New EventHandler(AddressOf Me.MoltoBuonoMenu_Click_1)
                End If
            End Set
        End Property

        Friend Overridable Property BuonoMenu As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._BuonoMenu
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._BuonoMenu Is Nothing) Then
                    RemoveHandler Me._BuonoMenu.Click, New EventHandler(AddressOf Me.BuonoMenu_Click_1)
                End If
                Me._BuonoMenu = WithEventsValue
                If (Not Me._BuonoMenu Is Nothing) Then
                    AddHandler Me._BuonoMenu.Click, New EventHandler(AddressOf Me.BuonoMenu_Click_1)
                End If
            End Set
        End Property

        Friend Overridable Property NormaleMenu As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._NormaleMenu
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._NormaleMenu Is Nothing) Then
                    RemoveHandler Me._NormaleMenu.Click, New EventHandler(AddressOf Me.NormaleMenu_Click_1)
                End If
                Me._NormaleMenu = WithEventsValue
                If (Not Me._NormaleMenu Is Nothing) Then
                    AddHandler Me._NormaleMenu.Click, New EventHandler(AddressOf Me.NormaleMenu_Click_1)
                End If
            End Set
        End Property

        Friend Overridable Property MediocreMenu As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._MediocreMenu
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._MediocreMenu Is Nothing) Then
                    RemoveHandler Me._MediocreMenu.Click, New EventHandler(AddressOf Me.MediocreMenu_Click_1)
                End If
                Me._MediocreMenu = WithEventsValue
                If (Not Me._MediocreMenu Is Nothing) Then
                    AddHandler Me._MediocreMenu.Click, New EventHandler(AddressOf Me.MediocreMenu_Click_1)
                End If
            End Set
        End Property

        Friend Overridable Property MoltoTristeMenu As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._MoltoTristeMenu
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._MoltoTristeMenu Is Nothing) Then
                    RemoveHandler Me._MoltoTristeMenu.Click, New EventHandler(AddressOf Me.MoltoTristeMenu_Click_1)
                End If
                Me._MoltoTristeMenu = WithEventsValue
                If (Not Me._MoltoTristeMenu Is Nothing) Then
                    AddHandler Me._MoltoTristeMenu.Click, New EventHandler(AddressOf Me.MoltoTristeMenu_Click_1)
                End If
            End Set
        End Property

        Friend Overridable Property TristeMenu As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._TristeMenu
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._TristeMenu Is Nothing) Then
                    RemoveHandler Me._TristeMenu.Click, New EventHandler(AddressOf Me.TristeMenu_Click)
                End If
                Me._TristeMenu = WithEventsValue
                If (Not Me._TristeMenu Is Nothing) Then
                    AddHandler Me._TristeMenu.Click, New EventHandler(AddressOf Me.TristeMenu_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ArrabbiatoMenu As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._ArrabbiatoMenu
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._ArrabbiatoMenu Is Nothing) Then
                    RemoveHandler Me._ArrabbiatoMenu.Click, New EventHandler(AddressOf Me.ArrabbiatoMenu_Click)
                End If
                Me._ArrabbiatoMenu = WithEventsValue
                If (Not Me._ArrabbiatoMenu Is Nothing) Then
                    AddHandler Me._ArrabbiatoMenu.Click, New EventHandler(AddressOf Me.ArrabbiatoMenu_Click)
                End If
            End Set
        End Property

        Friend Overridable Property MoltoArrabbiatoMenu As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._MoltoArrabbiatoMenu
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._MoltoArrabbiatoMenu Is Nothing) Then
                    RemoveHandler Me._MoltoArrabbiatoMenu.Click, New EventHandler(AddressOf Me.MoltoArrabbiatoMenu_Click_1)
                End If
                Me._MoltoArrabbiatoMenu = WithEventsValue
                If (Not Me._MoltoArrabbiatoMenu Is Nothing) Then
                    AddHandler Me._MoltoArrabbiatoMenu.Click, New EventHandler(AddressOf Me.MoltoArrabbiatoMenu_Click_1)
                End If
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("ToolStrip1")> _
        Private _ToolStrip1 As ToolStrip
        <AccessedThroughProperty("OKButt")> _
        Private _OKButt As Button
        <AccessedThroughProperty("AnnullaButt")> _
        Private _AnnullaButt As Button
        <AccessedThroughProperty("TestoText")> _
        Private _TestoText As TextBox
        <AccessedThroughProperty("TitoloText")> _
        Private _TitoloText As TextBox
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label
        <AccessedThroughProperty("BgSoundButt")> _
        Private _BgSoundButt As ToolStripButton
        <AccessedThroughProperty("AddInfoButt")> _
        Private _AddInfoButt As ToolStripButton
        <AccessedThroughProperty("ScegliAudio")> _
        Private _ScegliAudio As OpenFileDialog
        <AccessedThroughProperty("ImageButt")> _
        Private _ImageButt As ToolStripButton
        <AccessedThroughProperty("RecordButt")> _
        Private _RecordButt As ToolStripButton
        <AccessedThroughProperty("ImageDial")> _
        Private _ImageDial As OpenFileDialog
        <AccessedThroughProperty("AddFilesButt")> _
        Private _AddFilesButt As ToolStripButton
        <AccessedThroughProperty("AddFilesDial")> _
        Private _AddFilesDial As OpenFileDialog
        <AccessedThroughProperty("UmoreSplit")> _
        Private _UmoreSplit As ToolStripDropDownButton
        <AccessedThroughProperty("OttimoMenu")> _
        Private _OttimoMenu As ToolStripMenuItem
        <AccessedThroughProperty("MoltoBuonoMenu")> _
        Private _MoltoBuonoMenu As ToolStripMenuItem
        <AccessedThroughProperty("BuonoMenu")> _
        Private _BuonoMenu As ToolStripMenuItem
        <AccessedThroughProperty("NormaleMenu")> _
        Private _NormaleMenu As ToolStripMenuItem
        <AccessedThroughProperty("MediocreMenu")> _
        Private _MediocreMenu As ToolStripMenuItem
        <AccessedThroughProperty("MoltoTristeMenu")> _
        Private _MoltoTristeMenu As ToolStripMenuItem
        <AccessedThroughProperty("TristeMenu")> _
        Private _TristeMenu As ToolStripMenuItem
        <AccessedThroughProperty("ArrabbiatoMenu")> _
        Private _ArrabbiatoMenu As ToolStripMenuItem
        <AccessedThroughProperty("MoltoArrabbiatoMenu")> _
        Private _MoltoArrabbiatoMenu As ToolStripMenuItem
        Private AttachedFiles As List(Of String)
        Private ImagePath As String
        Private SoundPath As String
        Private Umore As String = "Normale"
        Private Mode As Byte
        Private ID As Integer
    End Class
End Namespace

