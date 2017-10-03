using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Lists
{
    class ObservableCollections
    {
        ObservableCollection<string> names = new 
            ObservableCollection<string>
            {
                "DVS Ram",
                "Aditya",
                "Srinath"
            };
        public static  void OCMain()
        {
            var oc = new ObservableCollections();
            oc.names.CollectionChanged += OnCollectionChanded;
            oc.names.Add("kishor");
        }

        private static void OnCollectionChanded(object sender,NotifyCollectionChangedEventArgs e)
        { }
    }
}
