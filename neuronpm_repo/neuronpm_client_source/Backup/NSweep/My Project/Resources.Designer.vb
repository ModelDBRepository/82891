﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50215.44
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

<Assembly: Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope:="member", Target:="My.Resources.Resources.get_ResourceManager():System.Resources.ResourceManager"),  _
 Assembly: Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope:="member", Target:="My.Resources.Resources.get_Culture():System.Globalization.CultureInfo"),  _
 Assembly: Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope:="member", Target:="My.Resources.Resources.set_Culture(System.Globalization.CultureInfo):Void")> 

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleName()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If (resourceMan Is Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("neuronPM.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        Friend ReadOnly Property dirona_abolineata() As System.Drawing.Bitmap
            Get
                Return CType(ResourceManager.GetObject("dirona_abolineata", resourceCulture),System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property melibe() As System.Drawing.Bitmap
            Get
                Return CType(ResourceManager.GetObject("melibe", resourceCulture),System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to /* load the standard hoc files we need */
        '''load_file(&quot;stdlib.hoc&quot;)
        '''load_file(&quot;family.hoc&quot;)
        '''load_file(&quot;shapebox.hoc&quot;)
        '''load_file(&quot;pointbsr.hoc&quot;, &quot;PointBrowser&quot;)
        '''load_file(&quot;wingroup.hoc&quot;)
        '''load_file(&quot;stdrun.hoc&quot;)
        '''load_file(&quot;inserter.hoc&quot;)
        '''load_file(&quot;pointman.hoc&quot;)
        '''print &quot;WINSWEEP - INIT - standard libraries opened&quot;
        '''
        '''/* load and initialize the sweep data structures */
        '''chdir(winsweepdirectory)
        '''load_file(&quot;sweeptypes.hoc&quot;)
        '''objref plist
        '''plist = new ParameterList()
        '''print &quot;WINSWEEP - INIT - parameter ty [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property sweep() As String
            Get
                Return ResourceManager.GetString("sweep", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to begintemplate Parameter
        '''	public name, type, ubound, level, value, base, increment
        '''
        '''	strdef name, type
        '''	objref vallist
        '''
        '''	proc init() {localobj vallist
        '''		level = 0
        '''		name = $s1
        '''		type = $s2
        '''		if (strcmp(type, &quot;list&quot;) == 0) {
        '''			vallist = new Vector()
        '''			vallist.append($o3)
        '''			ubound = vallist.size() - 1
        '''			return
        '''		}	
        '''
        '''		if (strcmp(type, &quot;exp&quot;) == 0) {
        '''			ubound = $3
        '''			expbase = $4
        '''			expstart = $5
        '''			return
        '''		}
        '''
        '''		ubound = $3
        '''		slope = $4
        '''		intercept = $5
        '''	}
        '''
        '''	func increment() { [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property sweeptypes() As String
            Get
                Return ResourceManager.GetString("sweeptypes", resourceCulture)
            End Get
        End Property
        
        Friend ReadOnly Property title() As System.Drawing.Bitmap
            Get
                Return CType(ResourceManager.GetObject("title", resourceCulture),System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property Tochuina() As System.Drawing.Bitmap
            Get
                Return CType(ResourceManager.GetObject("Tochuina", resourceCulture),System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property tritonia() As System.Drawing.Bitmap
            Get
                Return CType(ResourceManager.GetObject("tritonia", resourceCulture),System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
