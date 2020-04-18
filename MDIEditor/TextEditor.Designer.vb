<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.ttpTextEditor = New System.Windows.Forms.ToolTip(Me.components)
        Me.opdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'txtText
        '
        Me.txtText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtText.Location = New System.Drawing.Point(0, 0)
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(800, 450)
        Me.txtText.TabIndex = 1
        Me.ttpTextEditor.SetToolTip(Me.txtText, "Enetr the Text here.")
        '
        'opdOpen
        '
        Me.opdOpen.FileName = "OpenFileDialog1"
        Me.opdOpen.Title = "Open"
        '
        'sfdSave
        '
        Me.sfdSave.Title = "Save"
        '
        'frmTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtText)
        Me.Name = "frmTextEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Editor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtText As TextBox
    Friend WithEvents ttpTextEditor As ToolTip
    Friend WithEvents opdOpen As OpenFileDialog
    Friend WithEvents sfdSave As SaveFileDialog
End Class
