using System.Windows.Controls;
using System.Windows;
using AutoCAD_2022_Plugin1.ViewModels.ManageVM;
using AutoCAD_2022_Plugin1.ViewModels;

namespace AutoCAD_2022_Plugin1.Services
{
    public class MyViewSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object inItem, DependencyObject container)
        {
            IMyTabContentViewModel checkingTemplate = (inItem as DummyViewModel).VM;

            if (checkingTemplate == null)
            {
                return LayoutTemplate;
            }
            if (checkingTemplate is ManageLayoutVM)
            {
                return LayoutTemplate;
            }
            if (checkingTemplate is ManageVIewportVM)
            {
                return ViewportTemplate;
            }
            return LayoutTemplate;
        }

        public DataTemplate LayoutTemplate { get; set; }
        public DataTemplate ViewportTemplate { get; set; }

    }
}
