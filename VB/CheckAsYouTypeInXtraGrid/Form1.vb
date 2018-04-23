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

        Public Sub New()
            InitializeComponent()

            Dim listDataSource As New ArrayList()
            listDataSource.Add(New Record(1, "Text to to check" & ControlChars.CrLf & "Und much more aficial infomation", Date.Now))
            listDataSource.Add(New Record(2, "Text to to check", Date.Now.AddMinutes(1)))
            listDataSource.Add(New Record(3, "Text to check", Date.Now.AddMinutes(2)))
            gridControl1.DataSource = listDataSource
'            #Region "#spellinit"
            ' Subscribe to the event
            AddHandler gridView1.ShownEditor, AddressOf gridView1_ShownEditor

            ' Load dictionaries.
            ' Default dictionaries for US English are shipped with XtraSpellChecker. You can uncomment the code below to use this project's dictionaries instead. 
            'string wordsPath = "Dictionaries\\en_US.dic";
            'string grammarPath = "Dictionaries\\en_US.aff";
            'System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            'SpellCheckerOpenOfficeDictionary dict = new SpellCheckerOpenOfficeDictionary(wordsPath, grammarPath, culture);
            'sharedDictionaryStorage1.Dictionaries.Add(dict);

            ' Switch to the check-as-you-type mode.
            spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType
            'spellChecker1.
            spellChecker1.CheckAsYouTypeOptions.Color = Color.Magenta
'            #End Region ' #spellinit
        End Sub

#Region "#showneditor"
        Private checkedEditor As BaseEdit
        Private Sub gridView1_ShownEditor(ByVal sender As Object, ByVal e As EventArgs)
            Dim activeEditor As BaseEdit = gridView1.ActiveEditor
            If activeEditor Is Nothing OrElse (Not spellChecker1.CanCheck(activeEditor)) Then
                Return
            End If
            spellChecker1.SetShowSpellCheckMenu(gridView1.ActiveEditor, True)
            If Not Object.ReferenceEquals(checkedEditor, gridView1.ActiveEditor) Then
                spellChecker1.Check(activeEditor)
                checkedEditor = gridView1.ActiveEditor
            End If
        End Sub
#End Region ' #showneditor
    End Class
End Namespace