using AutoCAD_2022_Plugin1.ViewModels.ManageVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestUIPlugin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainManageVM _Data;
        public MainWindow()
        {
            InitializeComponent();
            _Data = new MainManageVM();
            DataContext = _Data;
        }

        public void DoneCommand(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void CancelCommand(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
