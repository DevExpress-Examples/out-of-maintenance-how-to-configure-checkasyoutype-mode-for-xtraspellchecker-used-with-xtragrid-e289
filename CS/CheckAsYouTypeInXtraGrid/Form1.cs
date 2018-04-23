using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using DevExpress.XtraSpellChecker;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;

namespace CheckAsYouTypeInXtraGrid
{
    public partial class Form1 : Form
    {
        BaseEdit checkedEditor;
        public Form1()
        {
            InitializeComponent();

            ArrayList listDataSource = new ArrayList();
            listDataSource.Add(new Record(1, "Text to to check\r\nUnd much more aficial infomation", System.DateTime.Now));
            gridControl1.DataSource = listDataSource;
            #region #spellinit
            // Subscribe to the event
            gridView1.ShownEditor += gridView1_ShownEditor;

            // Load dictionaries
            string wordsPath = "Dictionaries\\en_US.dic";
            string grammarPath = "Dictionaries\\en_US.aff";
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            SpellCheckerOpenOfficeDictionary dict = new SpellCheckerOpenOfficeDictionary(wordsPath, grammarPath, culture);
            sharedDictionaryStorage1.Dictionaries.Add(dict);
            spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType;
            spellChecker1.CheckAsYouTypeOptions.Color = Color.Magenta;
            #endregion #spellinit
        }
        #region #showneditor
        private void gridView1_ShownEditor(object sender, EventArgs e)
        {
            BaseEdit activeEditor = this.gridView1.ActiveEditor;
            if (activeEditor == null || !spellChecker1.CanCheck(activeEditor) || Object.ReferenceEquals(checkedEditor, activeEditor))
                return;
            spellChecker1.Check(activeEditor);
            spellChecker1.SetShowSpellCheckMenu(activeEditor, true);
            checkedEditor = activeEditor;
        }
        #endregion #showneditor=
    }
}