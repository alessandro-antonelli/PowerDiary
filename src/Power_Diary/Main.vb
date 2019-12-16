Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.FileIO
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
    Public Class Main
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.Principale_Load)
            Me.InitializeComponent
        End Sub

        Private Sub AnnullaRicercaButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.CercaText.Text = ""
        End Sub

        Private Sub ApriDiarioToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.Open.LoadOpen(0)
            MyProject.Forms.Open.Show
        End Sub

        Public Sub Carica(ByVal Path As String)
            If Not MyProject.Computer.FileSystem.FileExists((Path & "\Settings.txt")) Then
                MessageBox.Show("Impossibile aprire il diario. La cartella selezionata non è valida o è danneggiata.", "Impossibile aprire il diario", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Else
                Dim reader As New StreamReader((Path & "\Settings.txt"))
                Dim str6 As String = reader.ReadLine
                If ((str6 <> "") AndAlso (str6 <> Interaction.InputBox("Inserisci la password per l'apertura del diario", "Password", "", -1, -1))) Then
                    MessageBox.Show("Password errata! Impossibile aprire il diario.", "Password errata", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Else
                    Dim str3 As String = reader.ReadLine
                    Dim str5 As String = reader.ReadLine
                    Dim str2 As String = reader.ReadLine
                    Dim str7 As String = reader.ReadLine
                    Dim str As String = reader.ReadLine
                    Dim str4 As String = reader.ReadLine
                    reader.Close
                    Me.PagineList.Items.Clear
                    Dim count As Integer = MyProject.Computer.FileSystem.GetDirectories(Path).Count
                    Dim num3 As Integer = (count - 1)
                    Dim i As Integer = 0
                    Do While ((i <= num3) AndAlso ((count <> 0) AndAlso MyProject.Computer.FileSystem.DirectoryExists((Path & "\" & Conversions.ToString(CInt((i + 1)))))))
                        Dim directory As String = (Path & "\" & Conversions.ToString(CInt((i + 1))))
                        Dim item As New ListViewItem
                        Dim item3 As New ListViewSubItem
                        Dim item4 As New ListViewSubItem
                        Dim item2 As New ListViewSubItem
                        Try 
                            item.ImageIndex = Conversions.ToInteger("0")
                            item.Name = MyProject.Computer.FileSystem.GetDirectoryInfo(directory).Name
                            Dim reader2 As New StreamReader((directory & "\" & MyProject.Computer.FileSystem.GetDirectoryInfo(directory).Name & ".txt"))
                            item4.Text = reader2.ReadLine
                            item2.Text = reader2.ReadLine
                            item.Text = reader2.ReadLine
                            item3.Text = reader2.ReadLine
                            reader2.Close
                            Dim text As String = item2.Text
                            If ([text] = "Ottimo") Then
                                item2.BackColor = Color.Lime
                            ElseIf ([text] = "Molto buono") Then
                                item2.BackColor = Color.LawnGreen
                            ElseIf ([text] = "Buono") Then
                                item2.BackColor = Color.GreenYellow
                            ElseIf ([text] = "Normale") Then
                                item2.BackColor = Color.Yellow
                            ElseIf ([text] = "Mediocre") Then
                                item2.BackColor = Color.DarkOrange
                            ElseIf ([text] = "Triste") Then
                                item2.BackColor = Color.IndianRed
                            ElseIf ([text] = "Molto triste") Then
                                item2.BackColor = Color.DarkRed
                            ElseIf ([text] = "Arrabbiato") Then
                                item2.BackColor = Color.DimGray
                            ElseIf ([text] = "Molto arrabbiato") Then
                                item2.BackColor = Color.Black
                            End If
                        Catch exception1 As Exception
                            Dim ex As Exception = exception1
                            ProjectData.SetProjectError(ex)
                            Dim exception As Exception = ex
                            item.ImageIndex = Conversions.ToInteger("2")
                            item4.Text = "Pagina danneggiata"
                            item2.Text = ""
                            item.Text = ""
                            item3.Text = ""
                            ProjectData.ClearProjectError
                        End Try
                        item.SubItems.Add(item3)
                        item.SubItems.Add(item4)
                        item.SubItems.Add(item2)
                        Me.PagineList.Items.Add(item)
                        i += 1
                    Loop
                    Me.PagineTool.Enabled = True
                    Me.PagineList.Enabled = True
                    Me.InfoDiarioToolButt.Enabled = True
                    Me.InfoDiarioToolMenu.Enabled = True
                    Me.ImpostazioniToolMenu.Enabled = True
                    Me.EliminaToolMenu.Enabled = True
                    Me.ChiudiToolMenu.Enabled = True
                    Me.Text = (str3 & " - Power Diary")
                    Me.NomeLab.Text = str3
                    Me.FraseLab.Text = str2
                End If
            End If
        End Sub

        Private Sub CercaText_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.CercaText.Text = ""
        End Sub

        Private Sub CercaText_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.AnnullaRicercaButt.Enabled = (Me.CercaText.Text <> "")
        End Sub

        Public Sub Chiudi()
            Me.PagineList.Items.Clear
            Me.NomeLab.Text = "Non è stato aperto nessun diario."
            Me.FraseLab.Text = "Per aprire un diario, selezionare «File», poi «Apri diario» oppure «Nuovo diario» per crearne uno nuovo."
            Me.PagineTool.Enabled = False
            Me.PagineList.Enabled = False
            Me.InfoDiarioToolButt.Enabled = False
            Me.InfoDiarioToolMenu.Enabled = False
            Me.ImpostazioniToolMenu.Enabled = False
            Me.EliminaToolMenu.Enabled = False
            Me.ChiudiToolMenu.Enabled = False
            Me.ApriDiario.SelectedPath = Application.StartupPath
            MyProject.Forms.DiaryInfo.NameText.Text = "Non è stato aperto alcun diario."
            MyProject.Forms.DiaryInfo.PasswordText.Text = "---"
            Me.Text = "Power Diary"
            MyProject.Forms.DiaryInfo.Text = "Informazioni su..."
            MyProject.Forms.DiaryInfo.OwnerText.Text = "---"
            MyProject.Forms.DiaryInfo.InfoText.Text = "---"
            MyProject.Forms.DiaryInfo.PhraseText.Text = "---"
            MyProject.Forms.DiaryInfo.DateText.Text = "--- | ---"
            MyProject.Forms.DiaryInfo.PathText.Text = (Application.StartupPath & "\Diaries")
        End Sub

        Private Sub ChiudiToolMenu_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Chiudi
        End Sub

        Private Sub ControllaAggioToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.Updates.Show
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub EliminaToolMenu_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (MessageBox.Show("Sei sicuro di voler eliminare il diario? In questo modo tutte le pagine e le informazioni contenute verranno eliminate permanentemente.", "Eliminare il diario?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) <> DialogResult.No) Then
                MyProject.Computer.FileSystem.DeleteDirectory((Application.StartupPath & "\Diaries\" & Me.NomeLab.Text), DeleteDirectoryOption.DeleteAllContents)
                Me.Chiudi
            End If
        End Sub

        Private Sub ImportaEsportaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.IOSettings.Show
        End Sub

        Private Sub ImpostazioniToolMenu_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.DiarySettings.Show
        End Sub

        Private Sub InformazioniSuPowerDiaryToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.About.Show
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Dim manager As New ComponentResourceManager(GetType(Main))
            Me.MenuStrip1 = New MenuStrip
            Me.FileToolStripMenuItem = New ToolStripMenuItem
            Me.NuovoDiarioToolStripMenuItem = New ToolStripMenuItem
            Me.ToolStripMenuItem2 = New ToolStripSeparator
            Me.ApriDiarioToolStripMenuItem = New ToolStripMenuItem
            Me.ToolStripMenuItem3 = New ToolStripSeparator
            Me.ChiudiToolMenu = New ToolStripMenuItem
            Me.EsciToolStripMenuItem = New ToolStripMenuItem
            Me.VisualizzaToolStripMenuItem = New ToolStripMenuItem
            Me.InfoDiarioToolMenu = New ToolStripMenuItem
            Me.StrumentiToolStripMenuItem = New ToolStripMenuItem
            Me.OpzioniToolStripMenuItem = New ToolStripMenuItem
            Me.ImpostazioniToolMenu = New ToolStripMenuItem
            Me.EliminaToolMenu = New ToolStripMenuItem
            Me.ImportaEsportaToolStripMenuItem = New ToolStripMenuItem
            Me.ToolStripMenuItem1 = New ToolStripMenuItem
            Me.SitoWebUfficialeToolStripMenuItem = New ToolStripMenuItem
            Me.ControllaAggioToolStripMenuItem = New ToolStripMenuItem
            Me.InformazioniSuPowerDiaryToolStripMenuItem = New ToolStripMenuItem
            Me.ToolStrip1 = New ToolStrip
            Me.ToolStripButton3 = New ToolStripButton
            Me.ToolStripButton2 = New ToolStripButton
            Me.ToolStripSeparator1 = New ToolStripSeparator
            Me.InfoDiarioToolButt = New ToolStripButton
            Me.ApriDiario = New FolderBrowserDialog
            Me.FraseLab = New Label
            Me.NomeLab = New Label
            Me.PagineTool = New ToolStrip
            Me.ToolStripButton1 = New ToolStripButton
            Me.PageEditButt = New ToolStripButton
            Me.PageAddButt = New ToolStripButton
            Me.PageDeleteButt = New ToolStripButton
            Me.CercaText = New ToolStripTextBox
            Me.AnnullaRicercaButt = New ToolStripButton
            Me.PagineList = New ListView
            Me.DataCol = New ColumnHeader
            Me.OraCol = New ColumnHeader
            Me.TitoloCol = New ColumnHeader
            Me.UmoreCol = New ColumnHeader
            Me.ImageList1 = New ImageList(Me.components)
            Me.ApriDiario2 = New OpenFileDialog
            Me.MenuStrip1.SuspendLayout
            Me.ToolStrip1.SuspendLayout
            Me.PagineTool.SuspendLayout
            Me.SuspendLayout
            Dim size As New Size(&H18, &H18)
            Me.MenuStrip1.ImageScalingSize = size
            Dim toolStripItems As ToolStripItem() = New ToolStripItem() { Me.FileToolStripMenuItem, Me.VisualizzaToolStripMenuItem, Me.StrumentiToolStripMenuItem, Me.ToolStripMenuItem1 }
            Me.MenuStrip1.Items.AddRange(toolStripItems)
            Dim point As New Point(0, 0)
            Me.MenuStrip1.Location = point
            Me.MenuStrip1.Name = "MenuStrip1"
            size = New Size(&H278, &H18)
            Me.MenuStrip1.Size = size
            Me.MenuStrip1.TabIndex = 0
            Me.MenuStrip1.Text = "MenuStrip1"
            toolStripItems = New ToolStripItem() { Me.NuovoDiarioToolStripMenuItem, Me.ToolStripMenuItem2, Me.ApriDiarioToolStripMenuItem, Me.ToolStripMenuItem3, Me.ChiudiToolMenu, Me.EsciToolStripMenuItem }
            Me.FileToolStripMenuItem.DropDownItems.AddRange(toolStripItems)
            Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
            size = New Size(&H23, 20)
            Me.FileToolStripMenuItem.Size = size
            Me.FileToolStripMenuItem.Text = "&File"
            Me.NuovoDiarioToolStripMenuItem.Image = Resources.empty
            Me.NuovoDiarioToolStripMenuItem.Name = "NuovoDiarioToolStripMenuItem"
            size = New Size(&H91, &H16)
            Me.NuovoDiarioToolStripMenuItem.Size = size
            Me.NuovoDiarioToolStripMenuItem.Text = "Nuovo &diario"
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            size = New Size(&H8E, 6)
            Me.ToolStripMenuItem2.Size = size
            Me.ApriDiarioToolStripMenuItem.Image = Resources.folder_yellow
            Me.ApriDiarioToolStripMenuItem.Name = "ApriDiarioToolStripMenuItem"
            size = New Size(&H91, &H16)
            Me.ApriDiarioToolStripMenuItem.Size = size
            Me.ApriDiarioToolStripMenuItem.Text = "&Apri diario"
            Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
            size = New Size(&H8E, 6)
            Me.ToolStripMenuItem3.Size = size
            Me.ChiudiToolMenu.Enabled = False
            Me.ChiudiToolMenu.Image = Resources.cancel
            Me.ChiudiToolMenu.Name = "ChiudiToolMenu"
            size = New Size(&H91, &H16)
            Me.ChiudiToolMenu.Size = size
            Me.ChiudiToolMenu.Text = "&Chiudi"
            Me.EsciToolStripMenuItem.Image = Resources._exit
            Me.EsciToolStripMenuItem.Name = "EsciToolStripMenuItem"
            size = New Size(&H91, &H16)
            Me.EsciToolStripMenuItem.Size = size
            Me.EsciToolStripMenuItem.Text = "&Esci"
            toolStripItems = New ToolStripItem() { Me.InfoDiarioToolMenu }
            Me.VisualizzaToolStripMenuItem.DropDownItems.AddRange(toolStripItems)
            Me.VisualizzaToolStripMenuItem.Name = "VisualizzaToolStripMenuItem"
            size = New Size(&H40, 20)
            Me.VisualizzaToolStripMenuItem.Size = size
            Me.VisualizzaToolStripMenuItem.Text = "&Visualizza"
            Me.InfoDiarioToolMenu.Enabled = False
            Me.InfoDiarioToolMenu.Image = Resources.messagebox_info
            Me.InfoDiarioToolMenu.Name = "InfoDiarioToolMenu"
            size = New Size(&HBD, &H16)
            Me.InfoDiarioToolMenu.Size = size
            Me.InfoDiarioToolMenu.Text = "&Informazioni sul diario"
            toolStripItems = New ToolStripItem() { Me.OpzioniToolStripMenuItem, Me.ImpostazioniToolMenu, Me.EliminaToolMenu, Me.ImportaEsportaToolStripMenuItem }
            Me.StrumentiToolStripMenuItem.DropDownItems.AddRange(toolStripItems)
            Me.StrumentiToolStripMenuItem.Name = "StrumentiToolStripMenuItem"
            size = New Size(&H41, 20)
            Me.StrumentiToolStripMenuItem.Size = size
            Me.StrumentiToolStripMenuItem.Text = "&Strumenti"
            Me.OpzioniToolStripMenuItem.Image = Resources.configure
            Me.OpzioniToolStripMenuItem.Name = "OpzioniToolStripMenuItem"
            size = New Size(&HE7, &H16)
            Me.OpzioniToolStripMenuItem.Size = size
            Me.OpzioniToolStripMenuItem.Text = "&Opzioni"
            Me.ImpostazioniToolMenu.Enabled = False
            Me.ImpostazioniToolMenu.Image = Resources.misc
            Me.ImpostazioniToolMenu.Name = "ImpostazioniToolMenu"
            size = New Size(&HE7, &H16)
            Me.ImpostazioniToolMenu.Size = size
            Me.ImpostazioniToolMenu.Text = "I&mpostazioni diario"
            Me.EliminaToolMenu.Enabled = False
            Me.EliminaToolMenu.Image = Resources.messagebox_critical
            Me.EliminaToolMenu.Name = "EliminaToolMenu"
            size = New Size(&HE7, &H16)
            Me.EliminaToolMenu.Size = size
            Me.EliminaToolMenu.Text = "&Elimina diario"
            Me.ImportaEsportaToolStripMenuItem.Image = Resources.redo
            Me.ImportaEsportaToolStripMenuItem.Name = "ImportaEsportaToolStripMenuItem"
            size = New Size(&HE7, &H16)
            Me.ImportaEsportaToolStripMenuItem.Size = size
            Me.ImportaEsportaToolStripMenuItem.Text = "&Importa / Esporta impostazioni"
            toolStripItems = New ToolStripItem() { Me.SitoWebUfficialeToolStripMenuItem, Me.ControllaAggioToolStripMenuItem, Me.InformazioniSuPowerDiaryToolStripMenuItem }
            Me.ToolStripMenuItem1.DropDownItems.AddRange(toolStripItems)
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            size = New Size(&H18, 20)
            Me.ToolStripMenuItem1.Size = size
            Me.ToolStripMenuItem1.Text = "&?"
            Me.SitoWebUfficialeToolStripMenuItem.Image = Resources.www
            Me.SitoWebUfficialeToolStripMenuItem.Name = "SitoWebUfficialeToolStripMenuItem"
            size = New Size(&HDB, &H16)
            Me.SitoWebUfficialeToolStripMenuItem.Size = size
            Me.SitoWebUfficialeToolStripMenuItem.Text = "&Sito web ufficiale"
            Me.ControllaAggioToolStripMenuItem.Image = Resources.download_manager
            Me.ControllaAggioToolStripMenuItem.Name = "ControllaAggioToolStripMenuItem"
            size = New Size(&HDB, &H16)
            Me.ControllaAggioToolStripMenuItem.Size = size
            Me.ControllaAggioToolStripMenuItem.Text = "&Cerca aggiornamenti"
            Me.InformazioniSuPowerDiaryToolStripMenuItem.Image = Resources.messagebox_info
            Me.InformazioniSuPowerDiaryToolStripMenuItem.Name = "InformazioniSuPowerDiaryToolStripMenuItem"
            size = New Size(&HDB, &H16)
            Me.InformazioniSuPowerDiaryToolStripMenuItem.Size = size
            Me.InformazioniSuPowerDiaryToolStripMenuItem.Text = "&Informazioni su Power Diary"
            Me.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
            size = New Size(&H18, &H18)
            Me.ToolStrip1.ImageScalingSize = size
            toolStripItems = New ToolStripItem() { Me.ToolStripButton3, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.InfoDiarioToolButt }
            Me.ToolStrip1.Items.AddRange(toolStripItems)
            point = New Point(0, &H18)
            Me.ToolStrip1.Location = point
            Me.ToolStrip1.Name = "ToolStrip1"
            size = New Size(&H278, &H1F)
            Me.ToolStrip1.Size = size
            Me.ToolStrip1.TabIndex = 20
            Me.ToolStrip1.Text = "ToolStrip1"
            Me.ToolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.ToolStripButton3.Image = Resources.empty
            Me.ToolStripButton3.ImageTransparentColor = Color.Magenta
            Me.ToolStripButton3.Name = "ToolStripButton3"
            size = New Size(&H1C, &H1C)
            Me.ToolStripButton3.Size = size
            Me.ToolStripButton3.Text = "Nuovo diario"
            Me.ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.ToolStripButton2.Image = Resources.folder_yellow
            Me.ToolStripButton2.ImageTransparentColor = Color.Magenta
            Me.ToolStripButton2.Name = "ToolStripButton2"
            size = New Size(&H1C, &H1C)
            Me.ToolStripButton2.Size = size
            Me.ToolStripButton2.Text = "Apri diario"
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            size = New Size(6, &H1F)
            Me.ToolStripSeparator1.Size = size
            Me.InfoDiarioToolButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.InfoDiarioToolButt.Enabled = False
            Me.InfoDiarioToolButt.Image = Resources.messagebox_info
            Me.InfoDiarioToolButt.ImageTransparentColor = Color.Magenta
            Me.InfoDiarioToolButt.Name = "InfoDiarioToolButt"
            size = New Size(&H1C, &H1C)
            Me.InfoDiarioToolButt.Size = size
            Me.InfoDiarioToolButt.Text = "Informazioni sul diario"
            Me.ApriDiario.Description = "Seleziona la cartella con il nome del diario che desideri aprire e seleziona OK."
            Me.ApriDiario.ShowNewFolderButton = False
            Me.FraseLab.AutoSize = True
            point = New Point(12, 70)
            Me.FraseLab.Location = point
            size = New Size(&H268, &H1A)
            Me.FraseLab.MaximumSize = size
            Me.FraseLab.Name = "FraseLab"
            size = New Size(&H1EB, 13)
            Me.FraseLab.Size = size
            Me.FraseLab.TabIndex = &H16
            Me.FraseLab.Text = "Per aprire un diario, selezionare «File», poi «Apri diario» oppure «Nuovo diario» per crearne uno nuovo."
            Me.NomeLab.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or AnchorStyles.Top))
            Me.NomeLab.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(12, &H37)
            Me.NomeLab.Location = point
            size = New Size(&H268, 13)
            Me.NomeLab.MaximumSize = size
            Me.NomeLab.Name = "NomeLab"
            size = New Size(&H260, 13)
            Me.NomeLab.Size = size
            Me.NomeLab.TabIndex = &H17
            Me.NomeLab.Text = "Non è stato aperto nessun diario."
            Me.NomeLab.TextAlign = ContentAlignment.MiddleCenter
            Me.PagineTool.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or AnchorStyles.Top))
            Me.PagineTool.AutoSize = False
            Me.PagineTool.Dock = DockStyle.None
            Me.PagineTool.Enabled = False
            Me.PagineTool.GripStyle = ToolStripGripStyle.Hidden
            size = New Size(&H18, &H18)
            Me.PagineTool.ImageScalingSize = size
            toolStripItems = New ToolStripItem() { Me.ToolStripButton1, Me.PageEditButt, Me.PageAddButt, Me.PageDeleteButt, Me.CercaText, Me.AnnullaRicercaButt }
            Me.PagineTool.Items.AddRange(toolStripItems)
            point = New Point(9, &H6A)
            Me.PagineTool.Location = point
            Me.PagineTool.Name = "PagineTool"
            size = New Size(&H266, &H1F)
            Me.PagineTool.Size = size
            Me.PagineTool.Stretch = True
            Me.PagineTool.TabIndex = &H19
            Me.PagineTool.Text = "ToolStrip2"
            Me.ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.ToolStripButton1.Image = Resources.empty
            Me.ToolStripButton1.ImageTransparentColor = Color.Magenta
            Me.ToolStripButton1.Name = "ToolStripButton1"
            size = New Size(&H1C, &H1C)
            Me.ToolStripButton1.Size = size
            Me.ToolStripButton1.Text = "Nuova pagina"
            Me.PageEditButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.PageEditButt.Enabled = False
            Me.PageEditButt.Image = Resources.pencil
            Me.PageEditButt.ImageTransparentColor = Color.Magenta
            Me.PageEditButt.Name = "PageEditButt"
            size = New Size(&H1C, &H1C)
            Me.PageEditButt.Size = size
            Me.PageEditButt.Text = "Modifica"
            Me.PageAddButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.PageAddButt.Enabled = False
            Me.PageAddButt.Image = Resources.edit_add
            Me.PageAddButt.ImageTransparentColor = Color.Magenta
            Me.PageAddButt.Name = "PageAddButt"
            size = New Size(&H1C, &H1C)
            Me.PageAddButt.Size = size
            Me.PageAddButt.Text = "Continua pagina"
            Me.PageDeleteButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.PageDeleteButt.Enabled = False
            Me.PageDeleteButt.Image = Resources.messagebox_critical
            Me.PageDeleteButt.ImageTransparentColor = Color.Magenta
            Me.PageDeleteButt.Name = "PageDeleteButt"
            size = New Size(&H1C, &H1C)
            Me.PageDeleteButt.Size = size
            Me.PageDeleteButt.Text = "Elimina"
            Me.CercaText.Alignment = ToolStripItemAlignment.Right
            Me.CercaText.Name = "CercaText"
            size = New Size(100, &H1F)
            Me.CercaText.Size = size
            Me.CercaText.Text = "Cerca"
            Me.AnnullaRicercaButt.Alignment = ToolStripItemAlignment.Right
            Me.AnnullaRicercaButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.AnnullaRicercaButt.Enabled = False
            Me.AnnullaRicercaButt.Image = Resources.messagebox_critical
            Me.AnnullaRicercaButt.ImageTransparentColor = Color.Magenta
            Me.AnnullaRicercaButt.Name = "AnnullaRicercaButt"
            size = New Size(&H1C, &H1C)
            Me.AnnullaRicercaButt.Size = size
            Me.AnnullaRicercaButt.Text = "Annulla filtro"
            Me.PagineList.AllowColumnReorder = True
            Me.PagineList.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or (AnchorStyles.Bottom Or AnchorStyles.Top)))
            Dim values As ColumnHeader() = New ColumnHeader() { Me.DataCol, Me.OraCol, Me.TitoloCol, Me.UmoreCol }
            Me.PagineList.Columns.AddRange(values)
            Me.PagineList.Enabled = False
            Me.PagineList.FullRowSelect = True
            Me.PagineList.HideSelection = False
            Me.PagineList.LargeImageList = Me.ImageList1
            point = New Point(12, 140)
            Me.PagineList.Location = point
            Me.PagineList.MultiSelect = False
            Me.PagineList.Name = "PagineList"
            Me.PagineList.ShowGroups = False
            size = New Size(&H260, &H126)
            Me.PagineList.Size = size
            Me.PagineList.SmallImageList = Me.ImageList1
            Me.PagineList.TabIndex = &H18
            Me.PagineList.UseCompatibleStateImageBehavior = False
            Me.PagineList.View = View.Details
            Me.DataCol.Text = "Data"
            Me.DataCol.Width = &H5E
            Me.OraCol.Text = "Ora"
            Me.OraCol.Width = 70
            Me.TitoloCol.Text = "Titolo"
            Me.TitoloCol.Width = &HCB
            Me.UmoreCol.Text = "Umore"
            Me.UmoreCol.Width = &H63
            Me.ImageList1.ImageStream = DirectCast(manager.GetObject("ImageList1.ImageStream"), ImageListStreamer)
            Me.ImageList1.TransparentColor = Color.Transparent
            Me.ImageList1.Images.SetKeyName(0, "txt.png")
            Me.ImageList1.Images.SetKeyName(1, "services.png")
            Me.ImageList1.Images.SetKeyName(2, "no.png")
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H278, &H1BE)
            Me.ClientSize = size
            Me.Controls.Add(Me.PagineTool)
            Me.Controls.Add(Me.PagineList)
            Me.Controls.Add(Me.NomeLab)
            Me.Controls.Add(Me.FraseLab)
            Me.Controls.Add(Me.ToolStrip1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.MainMenuStrip = Me.MenuStrip1
            Me.Name = "Main"
            Me.Text = "Power Diary"
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout
            Me.PagineTool.ResumeLayout(False)
            Me.PagineTool.PerformLayout
            Me.ResumeLayout(False)
            Me.PerformLayout
        End Sub

        Private Sub NuovoDiarioToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (Not Me.ChiudiToolMenu.Enabled OrElse (MessageBox.Show("Vuoi davvero procedere alla creazione di un nuovo diario? Hai un diario ancora aperto.", "Procedere senza salvare?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.No)) Then
                MyProject.Forms.NewDiary.Show
            End If
        End Sub

        Private Sub OpzioniToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.Settings.Show
        End Sub

        Private Sub PageEditButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.NewPage.LoadForm(1, Conversions.ToInteger(Me.PagineList.SelectedItems(0).Name))
            MyProject.Forms.NewPage.Show
        End Sub

        Private Sub PagineList_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.DisplayPage.Carica(Conversions.ToInteger(Me.PagineList.SelectedItems(0).Name))
            MyProject.Forms.DisplayPage.Show
        End Sub

        Private Sub PagineList_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If (Me.PagineList.SelectedItems.Count = 0) Then
                Me.PageEditButt.Enabled = False
                Me.PageAddButt.Enabled = False
                Me.PageDeleteButt.Enabled = False
            Else
                Me.PageEditButt.Enabled = True
                Me.PageAddButt.Enabled = True
                Me.PageDeleteButt.Enabled = True
            End If
        End Sub

        Private Sub Principale_Load(ByVal sender As Object, ByVal e As EventArgs)
            If Not MyProject.Computer.FileSystem.DirectoryExists((Application.StartupPath & "\Diaries")) Then
                MyProject.Computer.FileSystem.CreateDirectory((Application.StartupPath & "\Diaries"))
            End If
            Me.ApriDiario.SelectedPath = (Application.StartupPath & "\Diaries\")
            If MySettingsProperty.Settings.Updates Then
                Process.Start((Application.StartupPath & "Update.exe"))
                MySettingsProperty.Settings.Updates = False
                Application.Exit
            ElseIf MyProject.Computer.FileSystem.FileExists((Application.StartupPath & "Update.exe")) Then
                MyProject.Computer.FileSystem.DeleteFile((Application.StartupPath & "Update.exe"), UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently)
            End If
            If MySettingsProperty.Settings.AutoLoad Then
                Me.Carica(MySettingsProperty.Settings.AutoLoadPath)
            End If
        End Sub

        Private Sub ProprietàDelDiarioToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.DiaryInfo.Show
        End Sub

        Private Sub SitoWebUfficialeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Process.Start("http://powersoftware.altervista.org")
        End Sub

        Private Sub ToolStripButton1_Click_1(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.NewPage.Show
        End Sub

        Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.Open.LoadOpen(0)
            MyProject.Forms.Open.Show
        End Sub

        Private Sub ToolStripButton3_Click_1(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.NewDiary.Show
        End Sub

        Private Sub ToolStripButton4_Click(ByVal sender As Object, ByVal e As EventArgs)
            If ((Me.PagineList.SelectedItems.Count <> 0) AndAlso (MessageBox.Show("Vuoi davvero eliminare la pagina selezionata?", "Eliminare la pagina?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) <> DialogResult.No)) Then
                Dim strArray As String() = New String() { Application.StartupPath, "\Diaries\", Me.NomeLab.Text, "\", Me.PagineList.SelectedItems(0).Name }
                MyProject.Computer.FileSystem.DeleteDirectory(String.Concat(strArray), DeleteDirectoryOption.DeleteAllContents)
                Me.PagineList.Items(Me.PagineList.SelectedItems(0).Index).Remove
            End If
        End Sub

        Private Sub ToolStripButton8_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.DiaryInfo.Show
        End Sub


        ' Properties
        Friend Overridable Property MenuStrip1 As MenuStrip
            <DebuggerNonUserCode> _
            Get
                Return Me._MenuStrip1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As MenuStrip)
                Me._MenuStrip1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property FileToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._FileToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._FileToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property NuovoDiarioToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._NuovoDiarioToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._NuovoDiarioToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._NuovoDiarioToolStripMenuItem.Click, New EventHandler(AddressOf Me.NuovoDiarioToolStripMenuItem_Click)
                End If
                Me._NuovoDiarioToolStripMenuItem = WithEventsValue
                If (Not Me._NuovoDiarioToolStripMenuItem Is Nothing) Then
                    AddHandler Me._NuovoDiarioToolStripMenuItem.Click, New EventHandler(AddressOf Me.NuovoDiarioToolStripMenuItem_Click)
                End If
            End Set
        End Property

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

        Friend Overridable Property ApriDiarioToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._ApriDiarioToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._ApriDiarioToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._ApriDiarioToolStripMenuItem.Click, New EventHandler(AddressOf Me.ApriDiarioToolStripMenuItem_Click)
                End If
                Me._ApriDiarioToolStripMenuItem = WithEventsValue
                If (Not Me._ApriDiarioToolStripMenuItem Is Nothing) Then
                    AddHandler Me._ApriDiarioToolStripMenuItem.Click, New EventHandler(AddressOf Me.ApriDiarioToolStripMenuItem_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ToolStripMenuItem1 As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripMenuItem1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._ToolStripMenuItem1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property VisualizzaToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._VisualizzaToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._VisualizzaToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property StrumentiToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._StrumentiToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._StrumentiToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OpzioniToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._OpzioniToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._OpzioniToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._OpzioniToolStripMenuItem.Click, New EventHandler(AddressOf Me.OpzioniToolStripMenuItem_Click)
                End If
                Me._OpzioniToolStripMenuItem = WithEventsValue
                If (Not Me._OpzioniToolStripMenuItem Is Nothing) Then
                    AddHandler Me._OpzioniToolStripMenuItem.Click, New EventHandler(AddressOf Me.OpzioniToolStripMenuItem_Click)
                End If
            End Set
        End Property

        Friend Overridable Property InformazioniSuPowerDiaryToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._InformazioniSuPowerDiaryToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._InformazioniSuPowerDiaryToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._InformazioniSuPowerDiaryToolStripMenuItem.Click, New EventHandler(AddressOf Me.InformazioniSuPowerDiaryToolStripMenuItem_Click)
                End If
                Me._InformazioniSuPowerDiaryToolStripMenuItem = WithEventsValue
                If (Not Me._InformazioniSuPowerDiaryToolStripMenuItem Is Nothing) Then
                    AddHandler Me._InformazioniSuPowerDiaryToolStripMenuItem.Click, New EventHandler(AddressOf Me.InformazioniSuPowerDiaryToolStripMenuItem_Click)
                End If
            End Set
        End Property

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

        Friend Overridable Property ToolStripButton3 As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripButton3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._ToolStripButton3 Is Nothing) Then
                    RemoveHandler Me._ToolStripButton3.Click, New EventHandler(AddressOf Me.ToolStripButton3_Click_1)
                End If
                Me._ToolStripButton3 = WithEventsValue
                If (Not Me._ToolStripButton3 Is Nothing) Then
                    AddHandler Me._ToolStripButton3.Click, New EventHandler(AddressOf Me.ToolStripButton3_Click_1)
                End If
            End Set
        End Property

        Friend Overridable Property ToolStripButton2 As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripButton2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._ToolStripButton2 Is Nothing) Then
                    RemoveHandler Me._ToolStripButton2.Click, New EventHandler(AddressOf Me.ToolStripButton2_Click)
                End If
                Me._ToolStripButton2 = WithEventsValue
                If (Not Me._ToolStripButton2 Is Nothing) Then
                    AddHandler Me._ToolStripButton2.Click, New EventHandler(AddressOf Me.ToolStripButton2_Click)
                End If
            End Set
        End Property

        Friend Overridable Property SitoWebUfficialeToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._SitoWebUfficialeToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._SitoWebUfficialeToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._SitoWebUfficialeToolStripMenuItem.Click, New EventHandler(AddressOf Me.SitoWebUfficialeToolStripMenuItem_Click)
                End If
                Me._SitoWebUfficialeToolStripMenuItem = WithEventsValue
                If (Not Me._SitoWebUfficialeToolStripMenuItem Is Nothing) Then
                    AddHandler Me._SitoWebUfficialeToolStripMenuItem.Click, New EventHandler(AddressOf Me.SitoWebUfficialeToolStripMenuItem_Click)
                End If
            End Set
        End Property

        Friend Overridable Property InfoDiarioToolMenu As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._InfoDiarioToolMenu
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._InfoDiarioToolMenu Is Nothing) Then
                    RemoveHandler Me._InfoDiarioToolMenu.Click, New EventHandler(AddressOf Me.ProprietàDelDiarioToolStripMenuItem_Click)
                End If
                Me._InfoDiarioToolMenu = WithEventsValue
                If (Not Me._InfoDiarioToolMenu Is Nothing) Then
                    AddHandler Me._InfoDiarioToolMenu.Click, New EventHandler(AddressOf Me.ProprietàDelDiarioToolStripMenuItem_Click)
                End If
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

        Friend Overridable Property InfoDiarioToolButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._InfoDiarioToolButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._InfoDiarioToolButt Is Nothing) Then
                    RemoveHandler Me._InfoDiarioToolButt.Click, New EventHandler(AddressOf Me.ToolStripButton8_Click)
                End If
                Me._InfoDiarioToolButt = WithEventsValue
                If (Not Me._InfoDiarioToolButt Is Nothing) Then
                    AddHandler Me._InfoDiarioToolButt.Click, New EventHandler(AddressOf Me.ToolStripButton8_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ApriDiario As FolderBrowserDialog
            <DebuggerNonUserCode> _
            Get
                Return Me._ApriDiario
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As FolderBrowserDialog)
                Me._ApriDiario = WithEventsValue
            End Set
        End Property

        Friend Overridable Property FraseLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._FraseLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._FraseLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property NomeLab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._NomeLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._NomeLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ControllaAggioToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._ControllaAggioToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._ControllaAggioToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._ControllaAggioToolStripMenuItem.Click, New EventHandler(AddressOf Me.ControllaAggioToolStripMenuItem_Click)
                End If
                Me._ControllaAggioToolStripMenuItem = WithEventsValue
                If (Not Me._ControllaAggioToolStripMenuItem Is Nothing) Then
                    AddHandler Me._ControllaAggioToolStripMenuItem.Click, New EventHandler(AddressOf Me.ControllaAggioToolStripMenuItem_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ToolStripMenuItem3 As ToolStripSeparator
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripMenuItem3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripSeparator)
                Me._ToolStripMenuItem3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ChiudiToolMenu As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._ChiudiToolMenu
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._ChiudiToolMenu Is Nothing) Then
                    RemoveHandler Me._ChiudiToolMenu.Click, New EventHandler(AddressOf Me.ChiudiToolMenu_Click)
                End If
                Me._ChiudiToolMenu = WithEventsValue
                If (Not Me._ChiudiToolMenu Is Nothing) Then
                    AddHandler Me._ChiudiToolMenu.Click, New EventHandler(AddressOf Me.ChiudiToolMenu_Click)
                End If
            End Set
        End Property

        Friend Overridable Property EsciToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._EsciToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                Me._EsciToolStripMenuItem = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PagineTool As ToolStrip
            <DebuggerNonUserCode> _
            Get
                Return Me._PagineTool
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStrip)
                Me._PagineTool = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ToolStripButton1 As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripButton1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._ToolStripButton1 Is Nothing) Then
                    RemoveHandler Me._ToolStripButton1.Click, New EventHandler(AddressOf Me.ToolStripButton1_Click_1)
                End If
                Me._ToolStripButton1 = WithEventsValue
                If (Not Me._ToolStripButton1 Is Nothing) Then
                    AddHandler Me._ToolStripButton1.Click, New EventHandler(AddressOf Me.ToolStripButton1_Click_1)
                End If
            End Set
        End Property

        Friend Overridable Property PageEditButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._PageEditButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._PageEditButt Is Nothing) Then
                    RemoveHandler Me._PageEditButt.Click, New EventHandler(AddressOf Me.PageEditButt_Click)
                End If
                Me._PageEditButt = WithEventsValue
                If (Not Me._PageEditButt Is Nothing) Then
                    AddHandler Me._PageEditButt.Click, New EventHandler(AddressOf Me.PageEditButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property PageDeleteButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._PageDeleteButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._PageDeleteButt Is Nothing) Then
                    RemoveHandler Me._PageDeleteButt.Click, New EventHandler(AddressOf Me.ToolStripButton4_Click)
                End If
                Me._PageDeleteButt = WithEventsValue
                If (Not Me._PageDeleteButt Is Nothing) Then
                    AddHandler Me._PageDeleteButt.Click, New EventHandler(AddressOf Me.ToolStripButton4_Click)
                End If
            End Set
        End Property

        Friend Overridable Property CercaText As ToolStripTextBox
            <DebuggerNonUserCode> _
            Get
                Return Me._CercaText
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripTextBox)
                If (Not Me._CercaText Is Nothing) Then
                    RemoveHandler Me._CercaText.TextChanged, New EventHandler(AddressOf Me.CercaText_TextChanged)
                    RemoveHandler Me._CercaText.Click, New EventHandler(AddressOf Me.CercaText_Click)
                End If
                Me._CercaText = WithEventsValue
                If (Not Me._CercaText Is Nothing) Then
                    AddHandler Me._CercaText.TextChanged, New EventHandler(AddressOf Me.CercaText_TextChanged)
                    AddHandler Me._CercaText.Click, New EventHandler(AddressOf Me.CercaText_Click)
                End If
            End Set
        End Property

        Friend Overridable Property PagineList As ListView
            <DebuggerNonUserCode> _
            Get
                Return Me._PagineList
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ListView)
                If (Not Me._PagineList Is Nothing) Then
                    RemoveHandler Me._PagineList.SelectedIndexChanged, New EventHandler(AddressOf Me.PagineList_SelectedIndexChanged)
                    RemoveHandler Me._PagineList.DoubleClick, New EventHandler(AddressOf Me.PagineList_DoubleClick)
                End If
                Me._PagineList = WithEventsValue
                If (Not Me._PagineList Is Nothing) Then
                    AddHandler Me._PagineList.SelectedIndexChanged, New EventHandler(AddressOf Me.PagineList_SelectedIndexChanged)
                    AddHandler Me._PagineList.DoubleClick, New EventHandler(AddressOf Me.PagineList_DoubleClick)
                End If
            End Set
        End Property

        Friend Overridable Property DataCol As ColumnHeader
            <DebuggerNonUserCode> _
            Get
                Return Me._DataCol
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ColumnHeader)
                Me._DataCol = WithEventsValue
            End Set
        End Property

        Friend Overridable Property OraCol As ColumnHeader
            <DebuggerNonUserCode> _
            Get
                Return Me._OraCol
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ColumnHeader)
                Me._OraCol = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TitoloCol As ColumnHeader
            <DebuggerNonUserCode> _
            Get
                Return Me._TitoloCol
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ColumnHeader)
                Me._TitoloCol = WithEventsValue
            End Set
        End Property

        Friend Overridable Property UmoreCol As ColumnHeader
            <DebuggerNonUserCode> _
            Get
                Return Me._UmoreCol
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ColumnHeader)
                Me._UmoreCol = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ImageList1 As ImageList
            <DebuggerNonUserCode> _
            Get
                Return Me._ImageList1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ImageList)
                Me._ImageList1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ImpostazioniToolMenu As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._ImpostazioniToolMenu
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._ImpostazioniToolMenu Is Nothing) Then
                    RemoveHandler Me._ImpostazioniToolMenu.Click, New EventHandler(AddressOf Me.ImpostazioniToolMenu_Click)
                End If
                Me._ImpostazioniToolMenu = WithEventsValue
                If (Not Me._ImpostazioniToolMenu Is Nothing) Then
                    AddHandler Me._ImpostazioniToolMenu.Click, New EventHandler(AddressOf Me.ImpostazioniToolMenu_Click)
                End If
            End Set
        End Property

        Friend Overridable Property EliminaToolMenu As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._EliminaToolMenu
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._EliminaToolMenu Is Nothing) Then
                    RemoveHandler Me._EliminaToolMenu.Click, New EventHandler(AddressOf Me.EliminaToolMenu_Click)
                End If
                Me._EliminaToolMenu = WithEventsValue
                If (Not Me._EliminaToolMenu Is Nothing) Then
                    AddHandler Me._EliminaToolMenu.Click, New EventHandler(AddressOf Me.EliminaToolMenu_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ImportaEsportaToolStripMenuItem As ToolStripMenuItem
            <DebuggerNonUserCode> _
            Get
                Return Me._ImportaEsportaToolStripMenuItem
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripMenuItem)
                If (Not Me._ImportaEsportaToolStripMenuItem Is Nothing) Then
                    RemoveHandler Me._ImportaEsportaToolStripMenuItem.Click, New EventHandler(AddressOf Me.ImportaEsportaToolStripMenuItem_Click)
                End If
                Me._ImportaEsportaToolStripMenuItem = WithEventsValue
                If (Not Me._ImportaEsportaToolStripMenuItem Is Nothing) Then
                    AddHandler Me._ImportaEsportaToolStripMenuItem.Click, New EventHandler(AddressOf Me.ImportaEsportaToolStripMenuItem_Click)
                End If
            End Set
        End Property

        Friend Overridable Property AnnullaRicercaButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._AnnullaRicercaButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._AnnullaRicercaButt Is Nothing) Then
                    RemoveHandler Me._AnnullaRicercaButt.Click, New EventHandler(AddressOf Me.AnnullaRicercaButt_Click)
                End If
                Me._AnnullaRicercaButt = WithEventsValue
                If (Not Me._AnnullaRicercaButt Is Nothing) Then
                    AddHandler Me._AnnullaRicercaButt.Click, New EventHandler(AddressOf Me.AnnullaRicercaButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ApriDiario2 As OpenFileDialog
            <DebuggerNonUserCode> _
            Get
                Return Me._ApriDiario2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As OpenFileDialog)
                Me._ApriDiario2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PageAddButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._PageAddButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                Me._PageAddButt = WithEventsValue
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("MenuStrip1")> _
        Private _MenuStrip1 As MenuStrip
        <AccessedThroughProperty("FileToolStripMenuItem")> _
        Private _FileToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("NuovoDiarioToolStripMenuItem")> _
        Private _NuovoDiarioToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("ToolStripMenuItem2")> _
        Private _ToolStripMenuItem2 As ToolStripSeparator
        <AccessedThroughProperty("ApriDiarioToolStripMenuItem")> _
        Private _ApriDiarioToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("ToolStripMenuItem1")> _
        Private _ToolStripMenuItem1 As ToolStripMenuItem
        <AccessedThroughProperty("VisualizzaToolStripMenuItem")> _
        Private _VisualizzaToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("StrumentiToolStripMenuItem")> _
        Private _StrumentiToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("OpzioniToolStripMenuItem")> _
        Private _OpzioniToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("InformazioniSuPowerDiaryToolStripMenuItem")> _
        Private _InformazioniSuPowerDiaryToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("ToolStrip1")> _
        Private _ToolStrip1 As ToolStrip
        <AccessedThroughProperty("ToolStripButton3")> _
        Private _ToolStripButton3 As ToolStripButton
        <AccessedThroughProperty("ToolStripButton2")> _
        Private _ToolStripButton2 As ToolStripButton
        <AccessedThroughProperty("SitoWebUfficialeToolStripMenuItem")> _
        Private _SitoWebUfficialeToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("InfoDiarioToolMenu")> _
        Private _InfoDiarioToolMenu As ToolStripMenuItem
        <AccessedThroughProperty("ToolStripSeparator1")> _
        Private _ToolStripSeparator1 As ToolStripSeparator
        <AccessedThroughProperty("InfoDiarioToolButt")> _
        Private _InfoDiarioToolButt As ToolStripButton
        <AccessedThroughProperty("ApriDiario")> _
        Private _ApriDiario As FolderBrowserDialog
        <AccessedThroughProperty("FraseLab")> _
        Private _FraseLab As Label
        <AccessedThroughProperty("NomeLab")> _
        Private _NomeLab As Label
        <AccessedThroughProperty("ControllaAggioToolStripMenuItem")> _
        Private _ControllaAggioToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("ToolStripMenuItem3")> _
        Private _ToolStripMenuItem3 As ToolStripSeparator
        <AccessedThroughProperty("ChiudiToolMenu")> _
        Private _ChiudiToolMenu As ToolStripMenuItem
        <AccessedThroughProperty("EsciToolStripMenuItem")> _
        Private _EsciToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("PagineTool")> _
        Private _PagineTool As ToolStrip
        <AccessedThroughProperty("ToolStripButton1")> _
        Private _ToolStripButton1 As ToolStripButton
        <AccessedThroughProperty("PageEditButt")> _
        Private _PageEditButt As ToolStripButton
        <AccessedThroughProperty("PageDeleteButt")> _
        Private _PageDeleteButt As ToolStripButton
        <AccessedThroughProperty("CercaText")> _
        Private _CercaText As ToolStripTextBox
        <AccessedThroughProperty("PagineList")> _
        Private _PagineList As ListView
        <AccessedThroughProperty("DataCol")> _
        Private _DataCol As ColumnHeader
        <AccessedThroughProperty("OraCol")> _
        Private _OraCol As ColumnHeader
        <AccessedThroughProperty("TitoloCol")> _
        Private _TitoloCol As ColumnHeader
        <AccessedThroughProperty("UmoreCol")> _
        Private _UmoreCol As ColumnHeader
        <AccessedThroughProperty("ImageList1")> _
        Private _ImageList1 As ImageList
        <AccessedThroughProperty("ImpostazioniToolMenu")> _
        Private _ImpostazioniToolMenu As ToolStripMenuItem
        <AccessedThroughProperty("EliminaToolMenu")> _
        Private _EliminaToolMenu As ToolStripMenuItem
        <AccessedThroughProperty("ImportaEsportaToolStripMenuItem")> _
        Private _ImportaEsportaToolStripMenuItem As ToolStripMenuItem
        <AccessedThroughProperty("AnnullaRicercaButt")> _
        Private _AnnullaRicercaButt As ToolStripButton
        <AccessedThroughProperty("ApriDiario2")> _
        Private _ApriDiario2 As OpenFileDialog
        <AccessedThroughProperty("PageAddButt")> _
        Private _PageAddButt As ToolStripButton
    End Class
End Namespace

