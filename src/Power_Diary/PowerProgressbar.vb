Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Namespace Power_Diary
    <DesignerGenerated> _
    Public Class PowerProgressbar
        Inherits UserControl
        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.Power_Progressbar_Load)
            AddHandler MyBase.Paint, New PaintEventHandler(AddressOf Me.PowerProgressbar_Paint)
            Me.InitializeComponent
            Me.p_Minimum = 0
            Me.p_Maximum = 100
            Me.p_Value = 0
            Me.p_BarColor = BarColors.Green
        End Sub

        Public Sub Disegna()
            Dim num2 As Integer
            Dim num3 As Double
            Dim height As Integer = CInt(Math.Round(CDbl((CDbl((Me.Height - 2)) / 2))))
            If ((Me.p_Value = 0) And (Me.p_Maximum = 0)) Then
                num3 = 0
                num2 = 0
            Else
                num3 = (CDbl(Me.p_Value) / CDbl(Me.p_Maximum))
                num2 = CInt(Math.Round(CDbl(((Me.Width - 2) * num3))))
            End If
            Dim rect As New Rectangle(1, 1, num2, height)
            Dim rectangle As New Rectangle(1, (height + 1), num2, ((Me.Height - 2) - height))
            Dim rectangle4 As New Rectangle(num2, 1, (Me.Width - 1), height)
            Dim rectangle2 As New Rectangle(num2, (height + 1), (Me.Width - 1), ((Me.Height - 2) - height))
            Me.CreateGraphics.FillRectangle(Brushes.White, rectangle4)
            Me.CreateGraphics.FillRectangle(Brushes.WhiteSmoke, rectangle2)
            Me.CreateGraphics.DrawLine(Pens.Gray, 1, 0, (Me.Width - 2), 0)
            Me.CreateGraphics.DrawLine(Pens.Gray, 1, (Me.Height - 1), (Me.Width - 2), (Me.Height - 1))
            Me.CreateGraphics.DrawLine(Pens.Gray, 0, 1, 0, (Me.Height - 2))
            Me.CreateGraphics.DrawLine(Pens.Gray, (Me.Width - 1), 1, (Me.Width - 1), (Me.Height - 2))
            Select Case Me.p_BarColor
                Case BarColors.Yellow
                    Me.CreateGraphics.FillRectangle(New SolidBrush(Color.FromArgb(&HFF, &HFB, &HA1)), rect)
                    Me.CreateGraphics.FillRectangle(New SolidBrush(Color.FromArgb(&HFB, &HEB, 2)), rectangle)
                    Exit Select
                Case BarColors.Orange
                    Me.CreateGraphics.FillRectangle(Brushes.Orange, rect)
                    Me.CreateGraphics.FillRectangle(Brushes.DarkOrange, rectangle)
                    Exit Select
                Case BarColors.Red
                    Me.CreateGraphics.FillRectangle(New SolidBrush(Color.FromArgb(&HFF, 80, 80)), rect)
                    Me.CreateGraphics.FillRectangle(New SolidBrush(Color.FromArgb(&HDD, 0, 0)), rectangle)
                    Exit Select
                Case BarColors.Violet
                    Me.CreateGraphics.FillRectangle(Brushes.DarkOrchid, rect)
                    Me.CreateGraphics.FillRectangle(Brushes.Purple, rectangle)
                    Exit Select
                Case BarColors.Brown
                    Me.CreateGraphics.FillRectangle(Brushes.Peru, rect)
                    Me.CreateGraphics.FillRectangle(Brushes.DarkGoldenrod, rectangle)
                    Exit Select
                Case BarColors.Green
                    Me.CreateGraphics.FillRectangle(New SolidBrush(Color.FromArgb(170, &HF6, &HB3)), rect)
                    Me.CreateGraphics.FillRectangle(New SolidBrush(Color.FromArgb(&H2D, &HE0, 70)), rectangle)
                    Exit Select
                Case BarColors.Blue
                    Me.CreateGraphics.FillRectangle(New SolidBrush(Color.FromArgb(&H49, &H93, 230)), rect)
                    Me.CreateGraphics.FillRectangle(New SolidBrush(Color.FromArgb(&H22, &H59, &HD7)), rectangle)
                    Exit Select
                Case BarColors.Grey
                    Me.CreateGraphics.FillRectangle(New SolidBrush(Color.FromArgb(&HEA, 240, &HF6)), rect)
                    Me.CreateGraphics.FillRectangle(New SolidBrush(Color.FromArgb(&HBD, &HC7, &HD6)), rectangle)
                    Exit Select
                Case BarColors.Black
                    Me.CreateGraphics.FillRectangle(Brushes.DimGray, rect)
                    Me.CreateGraphics.FillRectangle(Brushes.Black, rectangle)
                    Exit Select
                Case Else
                    Exit Select
            End Select
            If Me.p_DisplayPercent Then
                Select Case Me.p_BarColor
                    Case BarColors.Yellow
                        Me.CreateGraphics.DrawString((Conversions.ToString(CDbl((num3 * 100))) & " %"), New Font("Microsoft Sans Serif", 8!, FontStyle.Regular), Brushes.Black, CSng(((CDbl(Me.Width) / 2) - 15)), CSng((CDbl(Me.Height) / 5)))
                        Exit Select
                    Case BarColors.Orange
                        Me.CreateGraphics.DrawString((Conversions.ToString(CDbl((num3 * 100))) & " %"), New Font("Microsoft Sans Serif", 8!, FontStyle.Regular), Brushes.Black, CSng(((CDbl(Me.Width) / 2) - 15)), CSng((CDbl(Me.Height) / 5)))
                        Exit Select
                    Case BarColors.Red
                        Me.CreateGraphics.DrawString((Conversions.ToString(CDbl((num3 * 100))) & " %"), New Font("Microsoft Sans Serif", 8!, FontStyle.Regular), Brushes.Black, CSng(((CDbl(Me.Width) / 2) - 15)), CSng((CDbl(Me.Height) / 5)))
                        Exit Select
                    Case BarColors.Violet
                        Me.CreateGraphics.DrawString((Conversions.ToString(CDbl((num3 * 100))) & " %"), New Font("Microsoft Sans Serif", 8!, FontStyle.Regular), Brushes.Black, CSng(((CDbl(Me.Width) / 2) - 15)), CSng((CDbl(Me.Height) / 5)))
                        Exit Select
                    Case BarColors.Brown
                        Me.CreateGraphics.DrawString((Conversions.ToString(CDbl((num3 * 100))) & " %"), New Font("Microsoft Sans Serif", 8!, FontStyle.Regular), Brushes.Black, CSng(((CDbl(Me.Width) / 2) - 15)), CSng((CDbl(Me.Height) / 5)))
                        Exit Select
                    Case BarColors.Green
                        Me.CreateGraphics.DrawString((Conversions.ToString(CDbl((num3 * 100))) & " %"), New Font("Microsoft Sans Serif", 8!, FontStyle.Regular), Brushes.Black, CSng(((CDbl(Me.Width) / 2) - 15)), CSng((CDbl(Me.Height) / 5)))
                        Exit Select
                    Case BarColors.Blue
                        Me.CreateGraphics.DrawString((Conversions.ToString(CDbl((num3 * 100))) & " %"), New Font("Microsoft Sans Serif", 8!, FontStyle.Regular), Brushes.Black, CSng(((CDbl(Me.Width) / 2) - 15)), CSng((CDbl(Me.Height) / 5)))
                        Exit Select
                    Case BarColors.Grey
                        Me.CreateGraphics.DrawString((Conversions.ToString(CDbl((num3 * 100))) & " %"), New Font("Microsoft Sans Serif", 8!, FontStyle.Regular), Brushes.Black, CSng(((CDbl(Me.Width) / 2) - 15)), CSng((CDbl(Me.Height) / 5)))
                        Exit Select
                    Case BarColors.Black
                        Me.CreateGraphics.DrawString((Conversions.ToString(CDbl((num3 * 100))) & " %"), New Font("Microsoft Sans Serif", 8!, FontStyle.Regular), Brushes.LightGray, CSng(((CDbl(Me.Width) / 2) - 15)), CSng((CDbl(Me.Height) / 5)))
                        Exit Select
                    Case Else
                        Exit Select
                End Select
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
            Me.SuspendLayout
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.BackColor = Color.Transparent
            Me.Name = "PowerProgressbar"
            Dim size As New Size(300, 20)
            Me.Size = size
            Me.ResumeLayout(False)
        End Sub

        Private Sub Power_Progressbar_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim rect As New Rectangle(1, 1, (Me.Width - 1), (Me.Height - 1))
            Me.CreateGraphics.DrawRectangle(Pens.Black, rect)
        End Sub

        Private Sub PowerProgressbar_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
            Me.Disegna
        End Sub


        ' Properties
        Public Property Value As Long
            Get
                Return Me.p_Value
            End Get
            Set(ByVal Value As Long)
                If Not ((Value >= Me.p_Minimum) And (Value <= Me.p_Maximum)) Then
                    Throw New ArgumentOutOfRangeException
                End If
                Me.p_Value = Value
                Me.Disegna
            End Set
        End Property

        Public Property Minimum As Long
            Get
                Return Me.p_Minimum
            End Get
            Set(ByVal Value As Long)
                If (Value < 0) Then
                    Throw New ArgumentOutOfRangeException
                End If
                Me.p_Minimum = Value
                If (Me.p_Minimum > Me.p_Maximum) Then
                    Me.p_Maximum = (Me.p_Minimum + 1)
                End If
            End Set
        End Property

        Public Property Maximum As Long
            Get
                Return Me.p_Maximum
            End Get
            Set(ByVal Value As Long)
                If (Value < 0) Then
                    Throw New ArgumentOutOfRangeException
                End If
                Me.p_Maximum = Value
                If (Me.p_Maximum < Me.p_Minimum) Then
                    Me.p_Minimum = (Me.p_Maximum - 1)
                End If
            End Set
        End Property

        Public Property BarColor As BarColors
            Get
                Return Me.p_BarColor
            End Get
            Set(ByVal Value As BarColors)
                Me.p_BarColor = Value
                Me.Disegna
            End Set
        End Property

        Public Property DisplayPercent As Boolean
            Get
                Return Me.p_DisplayPercent
            End Get
            Set(ByVal value As Boolean)
                Me.p_DisplayPercent = value
                Me.Disegna
            End Set
        End Property


        ' Fields
        Private components As IContainer
        Private p_Value As Long
        Private p_Minimum As Long
        Private p_Maximum As Long
        Private p_BarColor As BarColors
        Private p_DisplayPercent As Boolean

        ' Nested Types
        Public Enum BarColors
            ' Fields
            Yellow = 0
            Orange = 1
            Red = 2
            Violet = 3
            Brown = 4
            Green = 5
            Blue = 6
            Grey = 7
            Black = 8
        End Enum
    End Class
End Namespace

