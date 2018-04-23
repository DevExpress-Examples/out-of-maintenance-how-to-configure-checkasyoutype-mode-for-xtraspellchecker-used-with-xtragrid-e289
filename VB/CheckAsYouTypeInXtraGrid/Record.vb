Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace CheckAsYouTypeInXtraGrid
	Public Class Record
		Private _Id As Integer
		Private _Note As String
		Private _TimeMark As DateTime

		Public Sub New(ByVal id As Integer, ByVal note As String, ByVal timemark As DateTime)
			Me._Id = id
			Me._Note = note
			Me._TimeMark = timemark
		End Sub

		Public Property TimeMark() As DateTime
			Get
				Return _TimeMark
			End Get
			Set(ByVal value As DateTime)
				_TimeMark = value
			End Set
		End Property

		Public Property Id() As Integer
			Get
				Return _Id
			End Get
			Set(ByVal value As Integer)
				_Id = value
			End Set
		End Property

		Public Property Note() As String
			Get
				Return _Note
			End Get
			Set(ByVal value As String)
				_Note = value
			End Set
		End Property
	End Class
End Namespace
