Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices

Namespace Power_Diary.My
    <CompilerGenerated, EditorBrowsable(EditorBrowsableState.Advanced), GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")> _
    Friend NotInheritable Class MySettings
        Inherits ApplicationSettingsBase
        ' Methods
        <EditorBrowsable(EditorBrowsableState.Advanced), DebuggerNonUserCode> _
        Private Shared Sub AutoSaveSettings(ByVal sender As Object, ByVal e As EventArgs)
            If MyProject.Application.SaveMySettingsOnExit Then
                MySettingsProperty.Settings.Save
            End If
        End Sub


        ' Properties
        Public Shared ReadOnly Property [Default] As MySettings
            Get
                If Not MySettings.addedHandler Then
                    Dim addedHandlerLockObject As Object = MySettings.addedHandlerLockObject
                    ObjectFlowControl.CheckForSyncLockOnValueType(addedHandlerLockObject)
                    SyncLock addedHandlerLockObject
                        If Not MySettings.addedHandler Then
                            AddHandler MyProject.Application.Shutdown, New ShutdownEventHandler(AddressOf MySettings.AutoSaveSettings)
                            MySettings.addedHandler = True
                        End If
                    End SyncLock
                End If
                Return MySettings.defaultInstance
            End Get
        End Property

        <UserScopedSetting, DefaultSettingValue("Arial, 12pt"), DebuggerNonUserCode> _
        Public Property Font As Font
            Get
                Return DirectCast(Me("Font"), Font)
            End Get
            Set(ByVal Value As Font)
                Me("Font") = Value
            End Set
        End Property

        <DefaultSettingValue("False"), DebuggerNonUserCode, UserScopedSetting> _
        Public Property Updates As Boolean
            Get
                Return Conversions.ToBoolean(Me("Updates"))
            End Get
            Set(ByVal Value As Boolean)
                Me("Updates") = Value
            End Set
        End Property

        <DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("")> _
        Public Property AutoLoadPath As String
            Get
                Return Conversions.ToString(Me("AutoLoadPath"))
            End Get
            Set(ByVal Value As String)
                Me("AutoLoadPath") = Value
            End Set
        End Property

        <DefaultSettingValue("False"), UserScopedSetting, DebuggerNonUserCode> _
        Public Property AutoLoad As Boolean
            Get
                Return Conversions.ToBoolean(Me("AutoLoad"))
            End Get
            Set(ByVal Value As Boolean)
                Me("AutoLoad") = Value
            End Set
        End Property

        <DefaultSettingValue("White"), DebuggerNonUserCode, UserScopedSetting> _
        Public Property BackColor As Color
            Get
                Dim color2 As Color
                Dim obj1 As Object = Me("BackColor")
                If (Not obj1 Is Nothing) Then
                    Return DirectCast(obj1, Color*)
                End If
                Dim local1 As Object = obj1
                Return color2
            End Get
            Set(ByVal Value As Color)
                Me("BackColor") = Value
            End Set
        End Property


        ' Fields
        Private Shared defaultInstance As MySettings = DirectCast(SettingsBase.Synchronized(New MySettings), MySettings)
        Private Shared addedHandler As Boolean
        Private Shared addedHandlerLockObject As Object = New Object
    End Class
End Namespace

