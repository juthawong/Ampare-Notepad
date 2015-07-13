Imports System.Drawing.Printing
Public Class Form1
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        AmpareTextBox.Clear()
    End Sub
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog
            dlg.Title = "Open Ampare Rich Text Files"
            dlg.Filter = "Rich Text Files (*.ampare)|*.ampare"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                AmpareTextBox.LoadFile(dlg.FileName)
            End If
        Catch ex As Exception : End Try

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        Try
            Dim dlg As SaveFileDialog = New SaveFileDialog
            dlg.Title = "Save Ampare Rich Text Files"
            dlg.Filter = "Ampare Rich Text Files (*.ampare)|*.ampare"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                AmpareTextBox.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText)
            End If
        Catch ex As Exception : End Try

    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        AmpareTextBox.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        AmpareTextBox.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        AmpareTextBox.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        AmpareTextBox.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        AmpareTextBox.Paste()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        AmpareTextBox.Clear()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        AmpareTextBox.SelectAll()
    End Sub

    Private Sub TimeDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AmpareTextBox.Paste()
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        Try
            Dim dlg As FontDialog = New FontDialog
            dlg.Font = AmpareTextBox.Font
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                AmpareTextBox.Font = dlg.Font
            End If
        Catch ex As Exception : End Try

    End Sub

    Private Sub ColourToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColourToolStripMenuItem.Click
        Try
            Dim dlg As ColorDialog = New ColorDialog
            dlg.Color = AmpareTextBox.ForeColor
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                AmpareTextBox.ForeColor = dlg.Color
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub WordwrapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordwrapToolStripMenuItem.Click
        AmpareTextBox.WordWrap = True
    End Sub

    Private Sub DisaleWordwrapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisaleWordwrapToolStripMenuItem.Click
        AmpareTextBox.WordWrap = False
    End Sub

    Private Sub SeeMoreOptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeeMoreOptionToolStripMenuItem.Click
        StatusBarToolStripMenuItem.PerformClick()
    End Sub

    Private Sub HowToUseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HowToUseToolStripMenuItem.Click
        Howandme.Show()
    End Sub

    Private Sub SpeakToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeakToolStripMenuItem.Click
        Dim Ampare
        Ampare = CreateObject("sapi.spvoice")
        Ampare.speak(AmpareTextBox.Text)
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusBarToolStripMenuItem.Click
        StatusStrip1.Visible = True
    End Sub

    Private Sub ContactToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactToolStripMenuItem.Click
        MsgBox("Contact Ampare:juthawong@hotmail.com", MsgBoxStyle.Information)
    End Sub

    Private Sub AboutMeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutMeToolStripMenuItem.Click
        Howandme.Show()
    End Sub

    Private Sub FeatureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeatureToolStripMenuItem.Click
        Dim j As String = "http://juthawong.page.tl/"
        Process.Start(j)
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.ControlKey And Keys.O Then
            OpenToolStripMenuItem.PerformClick()
        ElseIf e.KeyCode = Keys.Control And Keys.S Then
            SaveAsToolStripMenuItem.PerformClick()
        ElseIf e.KeyCode = Keys.F1 Then
            StatusBarToolStripMenuItem.PerformClick()
        ElseIf e.KeyCode = Keys.Control And Keys.C Then
            CopyToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AmpareTextBox.ContextMenuStrip = ContextMenuStrip1
    End Sub

    Private Sub FontToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem1.Click
        FontToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ColourToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColourToolStripMenuItem1.Click
        ColourToolStripMenuItem.PerformClick()
    End Sub

    Private Sub CopyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem1.Click

    End Sub
End Class
