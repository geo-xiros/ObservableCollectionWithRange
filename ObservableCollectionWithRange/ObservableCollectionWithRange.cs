using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ObservableCollectionWithRange
{
    partial class Program
    {
        public class ObservableCollectionWithRange<T> : ObservableCollection<T>
        {
            #region Constructors
            public ObservableCollectionWithRange() : base() { }

            public ObservableCollectionWithRange(List<T> list)
                : base(list)
            {

            }
            public ObservableCollectionWithRange(IEnumerable<T> collection) : base(collection)
            {

            }

            #endregion Constructors

            public void AddRange(IEnumerable<T> items)
            {
                foreach (var item in items)
                {
                    Items.Add(item);
                }

                OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            }

        }
    }
}
