<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnToolNew = New System.Windows.Forms.ToolStripButton()
        Me.btnToolOpen = New System.Windows.Forms.ToolStripButton()
        Me.btnToolSave = New System.Windows.Forms.ToolStripButton()
        Me.btnToolCarInventory = New System.Windows.Forms.ToolStripButton()
        Me.btnToolAverageUnits = New System.Windows.Forms.ToolStripButton()
        Me.tlStrip = New System.Windows.Forms.ToolStrip()
        Me.mnuFIle = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFIleOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsvertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsOpenCarForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsOpenText = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsOPenAverageForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.opdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.tlStrip.SuspendLayout()
        Me.mnuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnToolNew
        '
        Me.btnToolNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolNew.Image = Global.MDIEditor.My.Resources.Resources.icons8_new_file_50
        Me.btnToolNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolNew.Name = "btnToolNew"
        Me.btnToolNew.Size = New System.Drawing.Size(29, 28)
        Me.btnToolNew.Text = "New File"
        '
        'btnToolOpen
        '
        Me.btnToolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolOpen.Image = Global.MDIEditor.My.Resources.Resources.icons8_open_file_under_cursor_50
        Me.btnToolOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolOpen.Name = "btnToolOpen"
        Me.btnToolOpen.Size = New System.Drawing.Size(29, 28)
        Me.btnToolOpen.Text = "Open File"
        '
        'btnToolSave
        '
        Me.btnToolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolSave.Image = Global.MDIEditor.My.Resources.Resources.icons8_save_50
        Me.btnToolSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolSave.Name = "btnToolSave"
        Me.btnToolSave.Size = New System.Drawing.Size(29, 28)
        Me.btnToolSave.Text = "Save File"
        '
        'btnToolCarInventory
        '
        Me.btnToolCarInventory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolCarInventory.Image = Global.MDIEditor.My.Resources.Resources.icons8_car_badge_50
        Me.btnToolCarInventory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolCarInventory.Name = "btnToolCarInventory"
        Me.btnToolCarInventory.Size = New System.Drawing.Size(29, 28)
        Me.btnToolCarInventory.Text = "Car Inventory"
        '
        'btnToolAverageUnits
        '
        Me.btnToolAverageUnits.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolAverageUnits.Image = Global.MDIEditor.My.Resources.Resources.icons8_shipped_50
        Me.btnToolAverageUnits.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolAverageUnits.Name = "btnToolAverageUnits"
        Me.btnToolAverageUnits.Size = New System.Drawing.Size(29, 28)
        Me.btnToolAverageUnits.Text = "Average Units"
        '
        'tlStrip
        '
        Me.tlStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnToolNew, Me.btnToolOpen, Me.btnToolSave, Me.btnToolCarInventory, Me.btnToolAverageUnits})
        Me.tlStrip.Location = New System.Drawing.Point(0, 28)
        Me.tlStrip.Name = "tlStrip"
        Me.tlStrip.Size = New System.Drawing.Size(1000, 27)
        Me.tlStrip.TabIndex = 2
        Me.tlStrip.Text = "ToolStrip1"
        '
        'mnuFIle
        '
        Me.mnuFIle.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFIleOpen, Me.mnuFileSave, Me.mnuFileSaveAs, Me.mnuFileClose, Me.mnuFileExit})
        Me.mnuFIle.Name = "mnuFIle"
        Me.mnuFIle.Size = New System.Drawing.Size(46, 24)
        Me.mnuFIle.Text = "&File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Image = Global.MDIEditor.My.Resources.Resources.icons8_new_file_50
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuFileNew.Size = New System.Drawing.Size(181, 26)
        Me.mnuFileNew.Text = "&New"
        '
        'mnuFIleOpen
        '
        Me.mnuFIleOpen.Image = Global.MDIEditor.My.Resources.Resources.icons8_open_file_under_cursor_50
        Me.mnuFIleOpen.Name = "mnuFIleOpen"
        Me.mnuFIleOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFIleOpen.Size = New System.Drawing.Size(224, 26)
        Me.mnuFIleOpen.Text = "&Open"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Image = Global.MDIEditor.My.Resources.Resources.icons8_save_50
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(181, 26)
        Me.mnuFileSave.Text = "&Save"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Image = Global.MDIEditor.My.Resources.Resources.icons8_save_as_50
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(181, 26)
        Me.mnuFileSaveAs.Text = "Save &As"
        '
        'mnuFileClose
        '
        Me.mnuFileClose.Name = "mnuFileClose"
        Me.mnuFileClose.Size = New System.Drawing.Size(181, 26)
        Me.mnuFileClose.Text = "&Close"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(181, 26)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditCopy, Me.mnuEditCut, Me.mnuEditPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(49, 26)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuEditCopy.Size = New System.Drawing.Size(177, 26)
        Me.mnuEditCopy.Text = "&Copy"
        '
        'mnuEditCut
        '
        Me.mnuEditCut.Name = "mnuEditCut"
        Me.mnuEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuEditCut.Size = New System.Drawing.Size(177, 26)
        Me.mnuEditCut.Text = "C&ut"
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuEditPaste.Size = New System.Drawing.Size(177, 26)
        Me.mnuEditPaste.Text = "&Paste"
        '
        'mnuWindows
        '
        Me.mnuWindows.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuWindowsCascade, Me.mnuWindowsHorizontal, Me.mnuWindowsvertical, Me.mnuWindowsOpenCarForm, Me.mnuWindowsOpenText, Me.mnuWindowsOPenAverageForm})
        Me.mnuWindows.Name = "mnuWindows"
        Me.mnuWindows.Size = New System.Drawing.Size(84, 26)
        Me.mnuWindows.Text = "&Windows"
        '
        'mnuWindowsCascade
        '
        Me.mnuWindowsCascade.Name = "mnuWindowsCascade"
        Me.mnuWindowsCascade.Size = New System.Drawing.Size(197, 26)
        Me.mnuWindowsCascade.Text = "Casca&de"
        '
        'mnuWindowsHorizontal
        '
        Me.mnuWindowsHorizontal.Name = "mnuWindowsHorizontal"
        Me.mnuWindowsHorizontal.Size = New System.Drawing.Size(197, 26)
        Me.mnuWindowsHorizontal.Text = "Tile &Horizontal"
        '
        'mnuWindowsvertical
        '
        Me.mnuWindowsvertical.Name = "mnuWindowsvertical"
        Me.mnuWindowsvertical.Size = New System.Drawing.Size(197, 26)
        Me.mnuWindowsvertical.Text = "Tile &Vertical"
        '
        'mnuWindowsOpenCarForm
        '
        Me.mnuWindowsOpenCarForm.Image = Global.MDIEditor.My.Resources.Resources.icons8_car_badge_50
        Me.mnuWindowsOpenCarForm.Name = "mnuWindowsOpenCarForm"
        Me.mnuWindowsOpenCarForm.Size = New System.Drawing.Size(197, 26)
        Me.mnuWindowsOpenCarForm.Text = "Car &Inventory"
        '
        'mnuWindowsOpenText
        '
        Me.mnuWindowsOpenText.Image = Global.MDIEditor.My.Resources.Resources.icons8_new_file_50
        Me.mnuWindowsOpenText.Name = "mnuWindowsOpenText"
        Me.mnuWindowsOpenText.Size = New System.Drawing.Size(197, 26)
        Me.mnuWindowsOpenText.Text = "&New Text Editor"
        '
        'mnuWindowsOPenAverageForm
        '
        Me.mnuWindowsOPenAverageForm.Image = Global.MDIEditor.My.Resources.Resources.icons8_shipped_50
        Me.mnuWindowsOPenAverageForm.Name = "mnuWindowsOPenAverageForm"
        Me.mnuWindowsOPenAverageForm.Size = New System.Drawing.Size(197, 26)
        Me.mnuWindowsOPenAverageForm.Text = "&Average Units"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(55, 26)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuHelpAbout.Size = New System.Drawing.Size(157, 26)
        Me.mnuHelpAbout.Text = "A&bout"
        '
        'mnuStrip
        '
        Me.mnuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFIle, Me.mnuEdit, Me.mnuWindows, Me.mnuHelp})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(1000, 28)
        Me.mnuStrip.TabIndex = 1
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'opdOpen
        '
        Me.opdOpen.FileName = "OpenFileDialog1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 771)
        Me.Controls.Add(Me.tlStrip)
        Me.Controls.Add(Me.mnuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuStrip
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.tlStrip.ResumeLayout(False)
        Me.tlStrip.PerformLayout()
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnToolNew As ToolStripButton
    Friend WithEvents btnToolOpen As ToolStripButton
    Friend WithEvents btnToolSave As ToolStripButton
    Friend WithEvents btnToolCarInventory As ToolStripButton
    Friend WithEvents btnToolAverageUnits As ToolStripButton
    Friend WithEvents tlStrip As ToolStrip
    Friend WithEvents mnuFIle As ToolStripMenuItem
    Friend WithEvents mnuFileNew As ToolStripMenuItem
    Friend WithEvents mnuFIleOpen As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As ToolStripMenuItem
    Friend WithEvents mnuFileClose As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuEditCopy As ToolStripMenuItem
    Friend WithEvents mnuEditCut As ToolStripMenuItem
    Friend WithEvents mnuEditPaste As ToolStripMenuItem
    Friend WithEvents mnuWindows As ToolStripMenuItem
    Friend WithEvents mnuWindowsCascade As ToolStripMenuItem
    Friend WithEvents mnuWindowsHorizontal As ToolStripMenuItem
    Friend WithEvents mnuWindowsvertical As ToolStripMenuItem
    Friend WithEvents mnuWindowsOpenCarForm As ToolStripMenuItem
    Friend WithEvents mnuWindowsOpenText As ToolStripMenuItem
    Friend WithEvents mnuWindowsOPenAverageForm As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents opdOpen As OpenFileDialog
End Class
