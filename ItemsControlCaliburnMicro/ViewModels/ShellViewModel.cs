using Caliburn.Micro;
using ItemsControlCaliburnMicro.Common;
using System;
using System.Linq;
using System.Windows;

namespace ItemsControlCaliburnMicro.ViewModels
{
    class ShellViewModel : Conductor<IScreen>.Collection.OneActive
    {
        private BindableCollection<NameValue> _settings;
        public BindableCollection<NameValue> Settings =>
            _settings ?? (_settings = new BindableCollection<NameValue>());

        public ShellViewModel()
        {
            Settings.NotifyItemPropertyChanged((sender, EventArgs) =>
                NotifyOfPropertyChange(() => CanShowValues));

            Settings.Add(new NameValue { Name = "Server Hostname" });
            Settings.Add(new NameValue { Name = "Database Name" });
            Settings.Add(new NameValue { Name = "Database User" });
            Settings.Add(new NameValue { Name = "Database Password" });
        }

        public bool CanShowValues => Validate();
        public void ShowValues()
        {
            var message = string.Empty;
            foreach(var setting in Settings)
            {
                message += $"{setting.Name}: {setting.Value}{Environment.NewLine}";
            }

            MessageBox.Show(message);
        }

        private bool Validate() =>
            Settings.Where(s => string.IsNullOrWhiteSpace(s.Value)).Any() == false;
    }
}
