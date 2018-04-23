Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication3
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
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.renameEditor = New DevExpress.XtraEditors.TextEdit()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.renameEditor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Black"
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(495, 366)
			Me.xtraTabControl1.TabIndex = 0
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2, Me.xtraTabPage3, Me.xtraTabPage4, Me.xtraTabPage5})
'			Me.xtraTabControl1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.OnXtraTabControlDoubleClick);
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.renameEditor)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(490, 337)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' renameEditor
			' 
			Me.renameEditor.Location = New System.Drawing.Point(35, 53)
			Me.renameEditor.Name = "renameEditor"
			Me.renameEditor.Properties.Appearance.BackColor = System.Drawing.Color.White
			Me.renameEditor.Properties.Appearance.Options.UseBackColor = True
			Me.renameEditor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.renameEditor.Size = New System.Drawing.Size(100, 20)
			Me.renameEditor.TabIndex = 0
			Me.renameEditor.Visible = False
'			Me.renameEditor.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.OnRenameEditorKeyDown);
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(490, 337)
			Me.xtraTabPage2.Text = "xtraTabPage2"
			' 
			' xtraTabPage3
			' 
			Me.xtraTabPage3.Name = "xtraTabPage3"
			Me.xtraTabPage3.Size = New System.Drawing.Size(490, 337)
			Me.xtraTabPage3.Text = "xtraTabPage3"
			' 
			' xtraTabPage4
			' 
			Me.xtraTabPage4.Name = "xtraTabPage4"
			Me.xtraTabPage4.Size = New System.Drawing.Size(490, 337)
			Me.xtraTabPage4.Text = "xtraTabPage4"
			' 
			' xtraTabPage5
			' 
			Me.xtraTabPage5.Name = "xtraTabPage5"
			Me.xtraTabPage5.Size = New System.Drawing.Size(490, 337)
			Me.xtraTabPage5.Text = "xtraTabPage5"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(495, 366)
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "Form1"
			Me.Text = "How to rename tab headers"
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.renameEditor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private WithEvents xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage3 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage4 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage5 As DevExpress.XtraTab.XtraTabPage
		Private WithEvents renameEditor As DevExpress.XtraEditors.TextEdit
	End Class
End Namespace

