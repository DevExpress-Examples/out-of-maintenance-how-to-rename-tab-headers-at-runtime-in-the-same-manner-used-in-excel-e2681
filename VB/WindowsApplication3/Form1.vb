Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo
Imports System.Reflection
Imports DevExpress.LookAndFeel


Namespace WindowsApplication3
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			renameEditor.Parent = xtraTabControl1
			renameEditor.BackColor = LookAndFeelHelper.GetSystemColor(UserLookAndFeel.Default.ActiveLookAndFeel, SystemColors.Control)
		End Sub

		Private Sub OnXtraTabControlDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles xtraTabControl1.MouseDown
			If e.Button = MouseButtons.Left AndAlso e.Clicks = 2 Then
				Dim tabControl As XtraTabControl = TryCast(sender, XtraTabControl)
				Dim hitInfo As XtraTabHitInfo = tabControl.CalcHitInfo(e.Location)
				Dim tabPage As XtraTabPage = tabControl.SelectedTabPage
				If hitInfo.HitTest = XtraTabHitTest.PageHeader Then
					SetUpRenameEditor(tabPage)
				End If
			End If
		End Sub

		Private Sub SetUpRenameEditor(ByVal tabPage As XtraTabPage)
			renameEditor.Visible = True
			renameEditor.Bounds = GetRenameEditorBounds(tabPage)
			renameEditor.Text = tabPage.Text
			renameEditor.Select()
			renameEditor.SelectAll()
		End Sub

		Private Function GetRenameEditorBounds(ByVal tabPage As XtraTabPage) As Rectangle
			Dim pr As PropertyInfo = tabPage.GetType().GetProperty("PageViewInfo", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
			Dim tabInfo As BaseTabPageViewInfo = TryCast(pr.GetValue(tabPage, Nothing), BaseTabPageViewInfo)
			Dim rect As Rectangle = tabInfo.Bounds
			   Return New Rectangle(rect.X + 2, rect.Y + 2, rect.Width - 4, rect.Height - 2)
		End Function

		Private Sub OnRenameEditorKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles renameEditor.KeyDown
			If e.KeyData = Keys.Enter Then
				xtraTabControl1.SelectedTabPage.Text = renameEditor.Text
				renameEditor.Visible = False
			End If
		End Sub
	End Class
End Namespace
