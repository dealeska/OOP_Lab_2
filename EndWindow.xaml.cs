using System;
using System.Windows;

namespace OOP_Lab_2
{
    /// <summary>
    /// Логика взаимодействия для EndWindow.xamlм
    /// </summary>
    public partial class EndWindow : Window
    {
        public EndWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
