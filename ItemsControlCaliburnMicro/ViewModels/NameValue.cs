using Caliburn.Micro;

namespace ItemsControlCaliburnMicro.ViewModels
{
    class NameValue : PropertyChangedBase
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

        private string _value;
        public string Value
        {
            get => _value;
            set
            {
                _value = value;
                NotifyOfPropertyChange(() => Value);
            }
        }

    }
}
