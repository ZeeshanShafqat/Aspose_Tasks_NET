'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Tasks
Imports Aspose.Tasks.Saving
Imports Aspose.Tasks.Visualization

Namespace RollingUpGanttChartBarsExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			Dim options As New PdfSaveOptions()
			options.PresentationFormat = PresentationFormat.GanttChart
			options.FitContent = True
			options.RollUpGanttBars = True
			options.DrawNonWorkingTime = True
			options.PageSize = PageSize.A3
			Dim file As String = dataDir & "project.mpp"
			Dim resFile As String = dataDir & "output.pdf"
			Dim project As New Project(file)
			For i As Integer = 14 To 23
				project.GetTaskById(i).HideBar = False
			Next i
			project.Save(resFile, options)

		End Sub
	End Class
End Namespace