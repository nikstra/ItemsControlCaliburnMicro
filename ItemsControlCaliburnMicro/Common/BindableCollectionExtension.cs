using Caliburn.Micro;
using System;
using System.ComponentModel;

namespace ItemsControlCaliburnMicro.Common
{
    public static class BindableCollectionExtension
    {
        public static void NotifyItemPropertyChanged<T>(
            this BindableCollection<T> bindableCollection,
            Action<T, PropertyChangedEventArgs> callBackAction)
                where T : INotifyPropertyChanged
        {
            bindableCollection.CollectionChanged += (sender, args) =>
            {
                if (args.NewItems == null)
                {
                    return;
                }

                foreach (T item in args.NewItems)
                {
                    item.PropertyChanged += (obj, eventArgs) =>
                    {
                        callBackAction((T)obj, eventArgs);
                    };
                }
            };
        }
    }
}
