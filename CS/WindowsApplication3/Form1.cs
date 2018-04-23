using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using System.Reflection;
using DevExpress.LookAndFeel;


namespace WindowsApplication3 {
    public partial class Form1: XtraForm {
        public Form1() {
            InitializeComponent();
            renameEditor.Parent = xtraTabControl1;
            renameEditor.BackColor = LookAndFeelHelper.GetSystemColor(UserLookAndFeel.Default.ActiveLookAndFeel,
                SystemColors.Control);
        }
     
        private void OnXtraTabControlDoubleClick(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left && e.Clicks == 2) {
                XtraTabControl tabControl = sender as XtraTabControl;
                XtraTabHitInfo hitInfo = tabControl.CalcHitInfo(e.Location);
                XtraTabPage tabPage = tabControl.SelectedTabPage;
                if(hitInfo.HitTest == XtraTabHitTest.PageHeader) 
                    SetUpRenameEditor(tabPage);
            }
        }

        private void SetUpRenameEditor(XtraTabPage tabPage) {
            renameEditor.Visible = true;
            renameEditor.Bounds = GetRenameEditorBounds(tabPage);
            renameEditor.Text = tabPage.Text;
            renameEditor.Select();
            renameEditor.SelectAll();
        }

        private Rectangle GetRenameEditorBounds(XtraTabPage tabPage) {
            PropertyInfo pr = tabPage.GetType().GetProperty("PageViewInfo", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            BaseTabPageViewInfo tabInfo = pr.GetValue(tabPage, null) as BaseTabPageViewInfo;
            Rectangle rect = tabInfo.Bounds;
               return new Rectangle(rect.X + 2, rect.Y + 2, rect.Width - 4, rect.Height - 2);
        }

        private void OnRenameEditorKeyDown(object sender, KeyEventArgs e) {
            if(e.KeyData == Keys.Enter) {
                xtraTabControl1.SelectedTabPage.Text = renameEditor.Text;
                renameEditor.Visible = false;
            }
        }
    }
}
