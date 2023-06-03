using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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

namespace PrimalTheta_Editor.GameProjects
{
    /// <summary>
    /// Interaction logic for ProjectBrowsingDialogue.xaml
    /// </summary>
    public partial class ProjectBrowsingDialogue : Window
    {
        public ProjectBrowsingDialogue()
        {
            InitializeComponent();
        }

        private void openProjectButton_Click(object sender, RoutedEventArgs e)
        {
            openProjectButton.IsEnabled = true;
            createProjectButton.IsEnabled = false;
            resourcesButton.IsEnabled = false;
            // highlighted project on right side is opened up
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //if (openFileDialog.ShowDialog() == true)
            //{
            //    txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
            //}
        }

        private void createProjectButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void resourcesButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void settingsButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
