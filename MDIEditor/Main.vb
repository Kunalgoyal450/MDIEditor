'Program : MDI Editor
'Author : Kunal Goyal
'Date : 17/04/2020
'Description: A multi form editor


Option Strict On
Imports System.IO

Public Class frmMain
    ''' <summary>
    ''' Opening the car inventory form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OpenCarInventory(sender As Object, e As EventArgs) Handles mnuWindowsOpenCarForm.Click, btnToolCarInventory.Click

        Dim carForm As New frmCarInventory 'Creating a new form of Car Inventory
        carForm.MdiParent = Me ' Making it a child form
        carForm.Show()

    End Sub
    ''' <summary>
    ''' Opening average units shipped form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OpenAverageUnits(sender As Object, e As EventArgs) Handles mnuWindowsOPenAverageForm.Click, btnToolAverageUnits.Click
        Dim averageUnitsForm As New frmAverageUnitsShippedByEmployee 'Creating a new form of Average units shipped
        averageUnitsForm.MdiParent = Me ' Making it a child form
        averageUnitsForm.Show()
    End Sub
    ''' <summary>
    ''' View as cascade
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowsCascade_Click(sender As Object, e As EventArgs) Handles mnuWindowsCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub
    ''' <summary>
    ''' VIeew as Horizonntal tile
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowsHorizontal_Click(sender As Object, e As EventArgs) Handles mnuWindowsHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
    ''' <summary>
    ''' View as vertical tile
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowsvertical_Click(sender As Object, e As EventArgs) Handles mnuWindowsvertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
    ''' <summary>
    ''' Code  for all the new option
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NewFile(sender As Object, e As EventArgs) Handles mnuFileNew.Click, mnuWindowsOpenText.Click, btnToolNew.Click

        ' If the current active form is text editor
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            CType(ActiveMdiChild, frmTextEditor).FileNew()
        Else ' creating a new text editor form
            Dim newTextEditor As New frmTextEditor
            newTextEditor.MdiParent = Me
            newTextEditor.Show()
        End If

    End Sub
    ''' <summary>
    ''' Code for all open option
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFIleOpen_Click(sender As Object, e As EventArgs) Handles mnuFIleOpen.Click, btnToolOpen.Click
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            CType(ActiveMdiChild, frmTextEditor).FileOpen()
        Else
            Dim filePath As String
            opdOpen.Filter = "Text Files | *.txt|Word Document|*.docx|All Files|*.*" 'Setting the filter to access only text and docx files
            opdOpen.Title = "Open File" 'Setting the title of dialog box

            'Showing the dialog box
            If opdOpen.ShowDialog() = DialogResult.OK Then
                filePath = opdOpen.FileName 'Setting the filePath to the chosen file path 
                Dim newTextEditor As New frmTextEditor
                ' reads the data and tranfer it to text editor
                Dim openFile As New FileStream(filePath, FileMode.Open, FileAccess.Read)
                Dim fileReader As New StreamReader(openFile)
                newTextEditor.txtText.Text = fileReader.ReadToEnd()
                fileReader.Close()

                newTextEditor.MdiParent = Me
                newTextEditor.Show()

                'Sets the tile as text editor and location of file and change edited sstatus to false
                newTextEditor.Text = "Text Editor " & filePath

            End If
        End If
    End Sub
    ''' <summary>
    ''' Code for save option
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click, btnToolSave.Click
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            CType(ActiveMdiChild, frmTextEditor).FileSave()
        Else
            MessageBox.Show("Cannot save the current form.")
        End If
    End Sub
    ''' <summary>
    ''' Code for save as
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            CType(ActiveMdiChild, frmTextEditor).FileSaveAs()
        Else
            MessageBox.Show("Cannot save the current form.")
        End If
    End Sub
    ''' <summary>
    ''' Code for close
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click

        If MdiChildren.Count > 0 Then

            If TypeOf (ActiveMdiChild) Is frmTextEditor Then
                CType(ActiveMdiChild, frmTextEditor).FileClose()
            Else
                ActiveMdiChild.Close()
            End If

        End If

    End Sub
    ''' <summary>
    ''' Code for  exit
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' Code for copy
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            CType(ActiveMdiChild, frmTextEditor).EditCopy()
        Else
            MessageBox.Show("Cannot copy from the current form.")
        End If
    End Sub
    ''' <summary>
    ''' Code for cut
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEditCut_Click(sender As Object, e As EventArgs) Handles mnuEditCut.Click
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            CType(ActiveMdiChild, frmTextEditor).EditCut()
        Else
            MessageBox.Show("Cannot cut from the current form.")
        End If

    End Sub
    ''' <summary>
    ''' Code for paste
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            CType(ActiveMdiChild, frmTextEditor).EditPaste()
        Else
            MessageBox.Show("Cannot paste in the current form.")
        End If

    End Sub



#Region "Help Option Sub Procedures"

    ''' <summary>
    ''' Whenever the About button in Help option is accessed show the information in a message box
    ''' </summary>
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        MessageBox.Show("NETD 2202" & vbCrLf & vbCrLf & "LAB 6" & vbCrLf & vbCrLf & "Kunal Goyal")
    End Sub



#End Region
End Class
