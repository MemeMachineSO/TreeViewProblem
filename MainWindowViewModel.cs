using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TreeViewProblem.ViewModels;

namespace TreeViewProblem
{
    public class MainWindowViewModel : ObservableObject
    {
        public ObservableCollection<KeyViewModel> Keys { get; set; } = new();

        public ICommand TreeViewItemExpanded
            => new RelayCommand(() => MessageBox.Show(""));

        public MainWindowViewModel()
        {
            Keys.Add(new KeyViewModel("Item1"));
            Keys.Add(new KeyViewModel("Item2"));
            Keys.Add(new KeyViewModel("Item3"));
            Keys.Add(new KeyViewModel("Item4"));
            Keys.Add(new KeyViewModel("Item5"));
        }
    }
}
