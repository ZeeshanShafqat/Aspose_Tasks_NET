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
Imports System.Xml
Imports System

Namespace VisualBasic.Projects
	Public Class ExtendedAttributes
		Public Shared Sub Run()
			' The path to the documents directory.
			Dim dataDir As String = RunExamples.GetDataDir_Projects()

			Dim prj As New Project(dataDir & "ExtendedAttributes.mpp")
			Dim eads As ExtendedAttributeDefinitionCollection = prj.ExtendedAttributes

			' Create extended attribute definition
			Dim ead As New ExtendedAttributeDefinition()
			ead.FieldId = (CInt(Fix(ExtendedAttributeTask.Start7))).ToString()
			ead.FieldName = "Start7"
			eads.Add(ead)

			' Get zero index task
			Dim tsk As Task = prj.RootTask.Children.GetById(1)
			Dim eas As ExtendedAttributeCollection = tsk.ExtendedAttributes

			Dim dateTimeFormat As String = "yyyy-MM-ddTHH:mm:ss"
			Dim ea As New ExtendedAttribute()
			ea.FieldId = ead.FieldId
			ea.Value = XmlConvert.ToString(DateTime.Now, dateTimeFormat)
			eas.Add(ea)
		End Sub
	End Class
End Namespace