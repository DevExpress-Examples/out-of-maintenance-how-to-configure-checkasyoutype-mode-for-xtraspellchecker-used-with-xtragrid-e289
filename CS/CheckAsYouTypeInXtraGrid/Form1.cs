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
        public Form1()
        {
            InitializeComponent();

            ArrayList listDataSource = new ArrayList();
            listDataSource.Add(new Record(1, "Text to to check\r\nUnd much more aficial infomation", System.DateTime.Now));
            listDataSource.Add(new Record(2, "Text to to check", System.DateTime.Now.AddMinutes(1)));
            listDataSource.Add(new Record(3, "Text to check", System.DateTime.Now.AddMinutes(2)));
            gridControl1.DataSource = listDataSource;
            #region #spellinit
            // Subscribe to the event
            gridView1.ShownEditor += gridView1_ShownEditor;

            // Load dictionaries.
            // Default dictionaries for US English are shipped with XtraSpellChecker. You can uncomment the code below to use this project's dictionaries instead. 
            //string wordsPath = "Dictionaries\\en_US.dic";
            //string grammarPath = "Dictionaries\\en_US.aff";
            //System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            //SpellCheckerOpenOfficeDictionary dict = new SpellCheckerOpenOfficeDictionary(wordsPath, grammarPath, culture);
            //sharedDictionaryStorage1.Dictionaries.Add(dict);

            // Switch to the check-as-you-type mode.
            spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType;
            //spellChecker1.
            spellChecker1.CheckAsYouTypeOptions.Color = Color.Magenta;
            #endregion #spellinit
        }        
        #region #showneditor
        BaseEdit checkedEditor;
        private void gridView1_ShownEditor(object sender, EventArgs e)
        {
            BaseEdit activeEditor = gridView1.ActiveEditor;
            if (activeEditor == null || !spellChecker1.CanCheck(activeEditor))
                return;
            spellChecker1.SetShowSpellCheckMenu(gridView1.ActiveEditor, true);
            if (!object.ReferenceEquals(checkedEditor, gridView1.ActiveEditor))
            {
                spellChecker1.Check(activeEditor);
                checkedEditor = gridView1.ActiveEditor;
            }
        }
        #endregion #showneditor
    }
}