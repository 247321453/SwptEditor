using SwptSaveLib;
using SwptSaveLib.ValueTypes;
using System;

namespace SwptSaveLib
{
    public class Item
    {
        //Position,Name,Surfix,Prefix
        public string ID
        {
            get => "" + _id; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _id = 0;
                }
                else
                {
                    _id = int.Parse(value);
                }
            }
        }
        private int _id;
        public int Id { get => _id; }
        public SaveProperty Name { get; private set; }
        public SaveProperty Position { get; private set; }
        private SaveProperty _prefix, _surfix;

        private SaveFile mSaveFile;

        public Item(SaveFile save)
        {
            mSaveFile = save;
        }
        public Item(SaveFile save, SaveProperty val)
        {
            mSaveFile = save;
            SetName(val);
        }

        public void SetSurfix(SaveProperty val)
        {
            _surfix = val;
        }
        /// <summary>
        /// name+{id}
        /// </summary>
        /// <param name="val"></param>
        public void SetName(SaveProperty val)
        {
            Name = val;
            if (this._id == 0)
            {
                this._id = int.Parse(val.Name.Substring(4));
            }
        }
        public void SetPrefix(SaveProperty val)
        {
            _prefix = val;
        }
        /// <summary>
        /// xy+id
        /// </summary>
        /// <param name="position"></param>
        public void SetPosition(SaveProperty position)
        {
            Position = position;
            if (this._id == 0)
            {
                this._id = int.Parse(position.Name.Substring(2));
            }
        }

        public SaveProperty GetPrefix(bool create)
        {
            if (_prefix == null && create)
            {
                _prefix = new SaveProperty("prefix" + ID, new StringValue());
                int index;
                if (_surfix != null)
                {
                    index = mSaveFile.IndexOfProperty(_surfix);
                }
                else
                {
                    index = mSaveFile.IndexOfProperty(Name);
                }
                mSaveFile.InsertProperty(index, _prefix);
            }
            return _prefix;
        }

        public void DeletePrefix() {
            if (_prefix == null) {
                return;
            }
            int index = mSaveFile.IndexOfProperty(_prefix);
            if (index >= 0)
            {
                mSaveFile.RemoveProperty(index);
            }
            _prefix = null;
        }
        public SaveProperty GetSurfix(bool create)
        {
            if (_surfix == null && create)
            {
                _surfix = new SaveProperty("surfix" + ID, new StringValue());
                int index = mSaveFile.IndexOfProperty(Name);
                mSaveFile.InsertProperty(index, _surfix);
            }
            return _surfix;
        }

        public void DeleteSurfix()
        {
            if (_surfix == null)
            {
                return;
            }
            int index = mSaveFile.IndexOfProperty(_surfix);
            if (index >= 0)
            {
                mSaveFile.RemoveProperty(index);
            }
            _surfix = null;
        }
    }
}
