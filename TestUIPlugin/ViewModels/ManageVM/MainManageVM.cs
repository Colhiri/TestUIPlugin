using AutoCAD_2022_Plugin1.Services;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AutoCAD_2022_Plugin1.ViewModels.ManageVM
{
    public class MainManageVM : MainVM
    {
        public ObservableCollection<DummyViewModel> tabs { get; set; }

        private void EnabledForms()
        {
            // Проверяем доступность первой вкладки, если она заблокирована удалением Layout,
            // то блокируем вторую вкладку, выставляя значение доступности.
            bool TabEnabledVP;
            bool check = tabs.Where(x => x.Header == "Lay").Select(x => x.VM.CheckTabEnabled).First();
            if (check == false)
            {
                TabEnabledVP = false;
            }
            else
            {
                TabEnabledVP = true;
            }
            tabs.Where(x => x.Header == "VP").Select(x => x.VM).First().CheckTabEnabled = TabEnabledVP;
            OnPropertyChanged(nameof(IMyTabContentViewModel.CheckTabEnabled));
        }
        public MainManageVM()
        {
            tabs = new ObservableCollection<DummyViewModel>();
            tabs.Add(new DummyViewModel("Lay", new ManageLayoutVM()));
            tabs.Add(new DummyViewModel("VP", new ManageVIewportVM()));
        }

        private string _ActiveTab;
        public string ActiveTab
        {
            get 
            {
                return _ActiveTab; 
            }
            set
            {
                _ActiveTab = value;
                EnabledForms();
            }
        }

        private void ActionTest() { }
        private RelayCommand _Test;
        public RelayCommand Test
        {
            get
            {
                if (_Test == null)
                {
                    _Test = new RelayCommand(o => ActionTest(), null);
                }
                return _Test;
            }
        }
    }

    public class DummyViewModel
    {
        public IMyTabContentViewModel VM { get; set; }
        public string Header { get; set; }

        public DummyViewModel(string HeaderTab, IMyTabContentViewModel VM)
        {
            this.Header = HeaderTab;
            this.VM = VM;
        }
    }

    public interface IMyTabContentViewModel
    {
        bool CheckTabEnabled { get; set; }
    }
}