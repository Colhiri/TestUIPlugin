using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;

namespace AutoCAD_2022_Plugin1.ViewModels.ManageVM
{
    public class MainManageVM : MainVM
    {
        public ObservableCollection<DummyViewModel> tabs { get; set; }
        public bool EnabledForms
        {
            get
            {
                // Cast<IMyTabContentViewModel>().
                return tabs.Where(x => x.Header == "Lay").Select(x => x.VM.CheckTabEnabled).First();
            }
        }
        public MainManageVM()
        {
            tabs = new ObservableCollection<DummyViewModel>();
            tabs.Add(new DummyViewModel("Lay", new ManageLayoutVM()));
            tabs.Add(new DummyViewModel("VP", new ManageVIewportVM()));
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