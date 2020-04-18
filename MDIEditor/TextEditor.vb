'Program : text Editor
'Author : Kunal Goyal
'Date : 17/04/2020
'Description: A basic text editor created with vb with most functionalities.


Option Strict On
Imports System.IO

Public Class frmTextEditor
#Region "Declarations"

    Dim isEdited As Boolean = False ' Variable to tell whether the current file is edited or not
    Dim filePath As String = String.Empty ' Variable to store the path to save location of file

#End Region

#Region "Startup Sub Procedures"

    ''' <summary>
    ''' As soon as the form loads change the title of form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmTextEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Text Editor By Kunal Goyal"
    End Sub

    ''' <summary>
    ''' When there is changes in textbox set isEdited true and change the title text of form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtText_TextChanged(sender As Object, e As EventArgs) Handles txtText.TextChanged
        isEdited = True
        Me.Text = "Text Editor"
    End Sub

#End Region

#Region "File Option Sub Procedures"

    ''' <summary>
    ''' Whenever the new button in file option is accessed
    ''' </summary>

    Friend Sub FileNew()
        ConfirmClose() 'Calls the Function to check if the there is unsaved text in textbox

        ' If the text is not edited or changed
        If isEdited = False Then
            txtText.Text = String.Empty
            isEdited = False
            filePath = String.Empty
            Me.Text = "Text Editor By Kunal Goyal"
            txtText.Enabled = True
        End If

    End Sub

    ''' <summary>
    ''' Whenever the open button in file option is accessed
    ''' </summary>

    Friend Sub FileOpen()
        ConfirmClose() 'Calls the Function to check if the there is unsaved text in textbox

        ' If the text is not edited or changed
        If isEdited = False Then

            opdOpen.Filter = "Text Files | *.txt|Word Document|*.docx|All Files|*.*" 'Setting the filter to access only text and docx files
            opdOpen.Title = "Open File" 'Setting the title of dialog box

            'Showing the dialog box
            If opdOpen.ShowDialog() = DialogResult.OK Then
                filePath = opdOpen.FileName 'Setting the filePath to the chosen file path 

                ' reads the data and tranfer it to text editor
                Dim openFile As New FileStream(filePath, FileMode.Open, FileAccess.Read)
                Dim fileReader As New StreamReader(openFile)
                txtText.Text = fileReader.ReadToEnd()
                fileReader.Close()

                'Sets the tile as text editor and location of file and change edited sstatus to false
                Me.Text = "Text Editor " & filePath
                isEdited = False
            End If

        End If

    End Sub

    ''' <summary>
    ''' Whenever the save As button in file option is accessed
    ''' </summary>

    Friend Sub FileSaveAs()

        ' If the text is edited or changed
        If Not isEdited = False Then
            sfdSave.Filter = "Text Files | *.txt|Word Document|*.docx|All Files|*.*" 'Setting the filter to save file as text or docx files
            sfdSave.Title = "Save File As" 'Setting the title of dialog box

            'Showing the dialog box
            If sfdSave.ShowDialog() = DialogResult.OK Then
                filePath = sfdSave.FileName 'Setting the filePath to the chosen file path 

                ' writes the data text editor to the filePATH FILE
                Dim saveFile As New FileStream(filePath, FileMode.Create, FileAccess.Write)
                Dim fileWriter As New StreamWriter(saveFile)
                fileWriter.Write(txtText.Text)
                fileWriter.Close()

                'Sets the tile as text editor and location of file and change edited sstatus to false
                Me.Text = "Text Editor " & filePath
                isEdited = False
            End If
        End If
    End Sub

    ''' <summary>
    ''' Whenever the save button in file option is accessed
    ''' </summary>

    Friend Sub FileSave()

        ' If the text is edited or changed
        If Not isEdited = False Then

            ' iF the file path is not empty overwrites the content to same file and sets edited status to false
            If Not filePath = String.Empty Then
                Dim write As New StreamWriter(filePath)
                write.Write(txtText.Text)
                write.Close()

                isEdited = False
            Else
                FileSaveAs() 'If filePath is empty call the save As functionality
            End If

        End If
    End Sub

    ''' <summary>
    ''' Whenever the close button in file option is accessed
    ''' </summary>

    Friend Sub FileClose()

        ConfirmClose() 'Calls the Function to check if the there is unsaved text in textbox

        'If the file is not edited reste the form and disable the text box
        If isEdited = False Then
            txtText.Text = String.Empty
            isEdited = False
            filePath = String.Empty
            Me.Text = "Text Editor By Kunal Goyal"
            txtText.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Whenever the exit button in file option is accessed
    ''' </summary>

    Friend Sub FileExit()
        ConfirmClose() 'Calls the Function to check if the there is unsaved text in textbox

        'If edited status is false close the form
        If isEdited = False Then
            Me.Close()
        End If
    End Sub

#End Region

#Region "Edit Option Sub Procedures"

    ''' <summary>
    ''' Whenever the Copy button in Edit option is accessed
    ''' </summary>

    Friend Sub EditCopy()
        Clipboard.Clear() 'Clears the clipboard

        'If the text is selected copies it to clipboard
        If Not txtText.SelectedText = "" Then
            My.Computer.Clipboard.SetText(txtText.SelectedText)
        End If
    End Sub

    ''' <summary>
    ''' Whenever the Cut button in Edit option is accessed
    ''' </summary>

    Friend Sub EditCut()
        Clipboard.Clear() 'Clears the clipboard

        'If the text is selected copies it to clipboard and clear the textbox
        If Not txtText.SelectedText = "" Then
            My.Computer.Clipboard.SetText(txtText.SelectedText)
            txtText.SelectedText = String.Empty
        End If
    End Sub

    ''' <summary>
    ''' Whenever the Paste button in Edit option is accessed takes the content of clipboard and paste it into the text box
    ''' </summary>

    Friend Sub EditPaste()
        txtText.SelectedText = My.Computer.Clipboard.GetText()
    End Sub

#End Region



#Region "Function procedure"

    ''' <summary>
    ''' Sub procedure to confirm what user wants if the edited status is true
    ''' </summary>
    Sub ConfirmClose()

        ' If the edited status is true ask user what they want to do with the file
        If isEdited = True Then
            ' Displaying a MsgBox with yesnocancel style to ask what they want to do with current file and storing there answer into a integer variable
            Dim ans As Integer = MsgBox("There are unsaved changes" & vbCrLf & "Do you want to save them?", vbYesNoCancel)

            If ans = vbYes Then ' If the user says yes call the save button event handler
                FileSave()
            ElseIf ans = vbCancel Then 'If the ans is cancel that is user want to stay in this file then edited status is true
                isEdited = True
            Else ' If the user doen't want to save the file reset the editor
                txtText.Text = String.Empty
                isEdited = False
                filePath = String.Empty
                Me.Text = "Text Editor By Kunal Goyal"
            End If
        End If

    End Sub

#End Region

End Class
