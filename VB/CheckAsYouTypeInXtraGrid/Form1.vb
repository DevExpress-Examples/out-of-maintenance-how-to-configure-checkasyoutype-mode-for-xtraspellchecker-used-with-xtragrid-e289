Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Collections
Imports DevExpress.XtraSpellChecker
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors

Namespace CheckAsYouTypeInXtraGrid
	Partial Public Class Form1
		Inherits Form
		Private checkedEditor As BaseEdit
		Public Sub New()
			InitializeComponent()

			Dim listDataSource As New ArrayList()
			listDataSource.Add(New Record(1, "Text to to check" & Constants.vbCrLf & "Und much more aficial infomation", System.DateTime.Now))
			gridControl1.DataSource = listDataSource
'			#Region "#spellinit"
			' Subscribe to the event
			AddHandler gridView1.ShownEditor, AddressOf gridView1_ShownEditor

			' Load dictionaries
			Dim wordsPath As String = "Dictionaries\en_US.dic"
			Dim grammarPath As String = "Dictionaries\en_US.aff"
			Dim culture As New System.Globalization.CultureInfo("en-US")
			Dim dict As New SpellCheckerOpenOfficeDictionary(wordsPath, grammarPath, culture)
			sharedDictionaryStorage1.Dictionaries.Add(dict)
			spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType
			spellChecker1.CheckAsYouTypeOptions.Color = Color.Magenta
'			#End Region ' #spellinit
		End Sub
		#Region "#showneditor"
		Private Sub gridView1_ShownEditor(ByVal sender As Object, ByVal e As EventArgs)
			Dim activeEditor As BaseEdit = Me.gridView1.ActiveEditor
			If activeEditor Is Nothing OrElse (Not spellChecker1.CanCheck(activeEditor)) OrElse Object.ReferenceEquals(checkedEditor, activeEditor) Then
				Return
			End If
			spellChecker1.Check(activeEditor)
			spellChecker1.SetShowSpellCheckMenu(activeEditor, True)
			checkedEditor = activeEditor
		End Sub
		#End Region ' #showneditor=
	End Class
End Namespace