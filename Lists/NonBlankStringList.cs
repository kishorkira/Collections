using System;
using System.Collections.ObjectModel;

namespace Lists
{
    class NonBlankStringList:Collection<string>
    {

        protected override void InsertItem(int index, string item)
        {
            if (string.IsNullOrWhiteSpace(item))
                throw new ArgumentException("Elements of NonBlankStringList does not store null or white space");
            base.InsertItem(index, item);
        }

        protected override void SetItem(int index, string item)
        {
            if (string.IsNullOrWhiteSpace(item))
                throw new ArgumentException("Elements of NonBlankStringList does not store null or white space");
            base.SetItem(index, item);
        }
    }
}
