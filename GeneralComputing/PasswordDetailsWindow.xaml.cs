using GeneralComputing.ViewModels;
using MahApps.Metro.Controls;
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
using System.Windows.Shapes;

namespace GeneralComputing
{
    /// <summary>
    /// Interaction logic for PasswordDetailsWindow.xaml
    /// </summary>
    public partial class PasswordDetailsWindow : MetroWindow
    {
        public PasswordDetailsWindow()
        {
            this.DataContext = new PasswordDetailsViewModel(this);
            InitializeComponent();
        }
    }
}
