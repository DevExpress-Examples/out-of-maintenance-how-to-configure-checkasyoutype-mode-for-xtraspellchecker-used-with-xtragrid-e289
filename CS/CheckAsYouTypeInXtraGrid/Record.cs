using System;
using System.Collections.Generic;
using System.Text;

namespace CheckAsYouTypeInXtraGrid
{
    public class Record
    {
        private int _Id;
        private string _Note;
        private DateTime _TimeMark;

        public Record(int id, string note, DateTime timemark)
        {
            this._Id = id;
            this._Note = note;
            this._TimeMark = timemark;
        }                                   

        public DateTime TimeMark
        {
            get { return _TimeMark; }
            set { _TimeMark = value; }
        }

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Note
        {
            get { return _Note; }
            set { _Note = value; }
        }
    }
}
