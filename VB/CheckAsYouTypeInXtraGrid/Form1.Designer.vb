Namespace CheckAsYouTypeInXtraGrid
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.TimeMark = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.Notes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.repositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.spellChecker1 = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
            Me.sharedDictionaryStorage1 = New DevExpress.XtraSpellChecker.SharedDictionaryStorage(Me.components)
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemTextEdit1, Me.repositoryItemDateEdit1, Me.repositoryItemTimeEdit1, Me.repositoryItemMemoEdit1, Me.repositoryItemDateEdit2})
            Me.gridControl1.Size = New System.Drawing.Size(587, 369)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.TimeMark, Me.Notes, Me.ID})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsCustomization.AllowRowSizing = True
            Me.gridView1.OptionsView.RowAutoHeight = True
            ' 
            ' TimeMark
            ' 
            Me.TimeMark.Caption = "gridTimeMark"
            Me.TimeMark.ColumnEdit = Me.repositoryItemDateEdit2
            Me.TimeMark.DisplayFormat.FormatString = "g"
            Me.TimeMark.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.TimeMark.FieldName = "TimeMark"
            Me.TimeMark.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Me.TimeMark.Name = "TimeMark"
            Me.TimeMark.Visible = True
            Me.TimeMark.VisibleIndex = 0
            Me.TimeMark.Width = 139
            ' 
            ' repositoryItemDateEdit2
            ' 
            Me.repositoryItemDateEdit2.AutoHeight = False
            Me.repositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2"
            ' 
            ' Notes
            ' 
            Me.Notes.Caption = "gridNotes"
            Me.Notes.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.Notes.FieldName = "Note"
            Me.Notes.Name = "Notes"
            Me.Notes.Visible = True
            Me.Notes.VisibleIndex = 1
            Me.Notes.Width = 428
            ' 
            ' ID
            ' 
            Me.ID.Caption = "gridId"
            Me.ID.FieldName = "Id"
            Me.ID.Name = "ID"
            ' 
            ' repositoryItemTextEdit1
            ' 
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' repositoryItemDateEdit1
            ' 
            Me.repositoryItemDateEdit1.AutoHeight = False
            Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
            ' 
            ' repositoryItemTimeEdit1
            ' 
            Me.repositoryItemTimeEdit1.AutoHeight = False
            Me.repositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1"
            ' 
            ' repositoryItemMemoEdit1
            ' 
            Me.repositoryItemMemoEdit1.LinesCount = 10
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            ' 
            ' spellChecker1
            ' 
            Me.spellChecker1.Culture = New System.Globalization.CultureInfo("en-US")
            Me.spellChecker1.ParentContainer = Nothing
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(587, 369)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private TimeMark As DevExpress.XtraGrid.Columns.GridColumn
        Private Notes As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Private repositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Private ID As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Private spellChecker1 As DevExpress.XtraSpellChecker.SpellChecker
        Private sharedDictionaryStorage1 As DevExpress.XtraSpellChecker.SharedDictionaryStorage
    End Class
End Namespace

