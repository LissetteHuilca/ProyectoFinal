﻿#ExternalChecksum("..\..\VotarDignidades.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","25346C9A97F2F376D16FD7455C70EFB2")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Principal
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell


'''<summary>
'''VotarDignidades
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class VotarDignidades
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\VotarDignidades.xaml",18)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents GridLista35 As System.Windows.Controls.DataGrid
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\VotarDignidades.xaml",25)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents GridLista23 As System.Windows.Controls.DataGrid
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\VotarDignidades.xaml",30)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents GridLista6 As System.Windows.Controls.DataGrid
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\VotarDignidades.xaml",35)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents GridLista10 As System.Windows.Controls.DataGrid
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\VotarDignidades.xaml",40)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents label As System.Windows.Controls.Label
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/Principal;component/votardignidades.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\VotarDignidades.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            
            #ExternalSource("..\..\VotarDignidades.xaml",8)
            AddHandler CType(target,VotarDignidades).Loaded, New System.Windows.RoutedEventHandler(AddressOf Me.Window_Loaded)
            
            #End ExternalSource
            
            #ExternalSource("..\..\VotarDignidades.xaml",8)
            AddHandler CType(target,VotarDignidades).Closing, New System.ComponentModel.CancelEventHandler(AddressOf Me.Window_Closing)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 2) Then
            Me.GridLista35 = CType(target,System.Windows.Controls.DataGrid)
            Return
        End If
        If (connectionId = 3) Then
            Me.GridLista23 = CType(target,System.Windows.Controls.DataGrid)
            Return
        End If
        If (connectionId = 4) Then
            Me.GridLista6 = CType(target,System.Windows.Controls.DataGrid)
            Return
        End If
        If (connectionId = 5) Then
            Me.GridLista10 = CType(target,System.Windows.Controls.DataGrid)
            Return
        End If
        If (connectionId = 6) Then
            Me.label = CType(target,System.Windows.Controls.Label)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class

