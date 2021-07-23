using System;

namespace GeneralComputing.ViewModel
{
    using System.Linq;
    using System.Text;
    using System.ComponentModel;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public class BaseViewModel : INotifyPropertyChanged
    {
        private bool loading = false;

        public bool Loading

        {
            get { return loading; }

            set { SetProperty(ref loading, value); }
        }

        private string title;

        public string Title

        {
            get { return title; }

            set { SetProperty(ref title, value); }
        }

        protected bool SetProperty<T>(ref T backingStore, T value,

            [CallerMemberName] string propertyName = "",

            Action onChanged = null)

        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))

                return false;

            backingStore = value;

            onChanged?.Invoke();

            OnPropertyChanged(propertyName);

            return true;
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")

        {
            var changed = PropertyChanged;

            if (changed == null)

                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion INotifyPropertyChanged
    }
}