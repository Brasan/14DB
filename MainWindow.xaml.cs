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
using System.Diagnostics;
using charImport;

namespace _14DB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Setup.CreateDirectories();
            InitializeComponent();
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void charImportBtn_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Button clicked");
            CharImporter import = new CharImporter();
            //TODO: Control validity of importId
            import.ImportCharacter(importIdBox.Text);
        }
    }
}
