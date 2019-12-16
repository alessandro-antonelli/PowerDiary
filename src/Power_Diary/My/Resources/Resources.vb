Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices

Namespace Power_Diary.My.Resources
    <HideModuleName, CompilerGenerated, GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"), StandardModule, DebuggerNonUserCode> _
    Friend NotInheritable Class Resources
        ' Properties
        <EditorBrowsable(EditorBrowsableState.Advanced)> _
        Friend Shared ReadOnly Property ResourceManager As ResourceManager
            Get
                If Object.ReferenceEquals(Resources.resourceMan, Nothing) Then
                    Resources.resourceMan = New ResourceManager("Power_Diary.Resources", GetType(Resources).Assembly)
                End If
                Return Resources.resourceMan
            End Get
        End Property

        <EditorBrowsable(EditorBrowsableState.Advanced)> _
        Friend Shared Property Culture As CultureInfo
            Get
                Return Resources.resourceCulture
            End Get
            Set(ByVal Value As CultureInfo)
                Resources.resourceCulture = Value
            End Set
        End Property

        Friend Shared ReadOnly Property _exit As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("exit", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property back As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("back", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property cancel As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("cancel", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property cancel1 As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("cancel1", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property configure As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("configure", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property download_manager As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("download_manager", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property edit_add As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("edit_add", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property empty As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("empty", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property empty1 As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("empty1", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property folder_yellow As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("folder_yellow", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property fonts As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("fonts", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property forward As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("forward", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property image As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("image", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property krec_record As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("krec_record", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property ledblue As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("ledblue", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property ledgreen As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("ledgreen", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property ledlightblue As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("ledlightblue", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property ledlightgreen As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("ledlightgreen", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property ledorange As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("ledorange", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property ledpurple As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("ledpurple", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property ledred As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("ledred", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property ledyellow As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("ledyellow", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property messagebox_critical As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("messagebox_critical", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property messagebox_info As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("messagebox_info", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property misc As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("misc", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property package As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("package", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property pencil As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("pencil", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property player_play As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("player_play", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property player_stop As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("player_stop", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property Power_diary As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("Power diary", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property Power_splash As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("Power splash", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property redo As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("redo", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property services As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("services", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property sound As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("sound", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property undo As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("undo", Resources.resourceCulture), Bitmap)
            End Get
        End Property

        Friend Shared ReadOnly Property www As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("www", Resources.resourceCulture), Bitmap)
            End Get
        End Property


        ' Fields
        Private Shared resourceMan As ResourceManager
        Private Shared resourceCulture As CultureInfo
    End Class
End Namespace

