﻿using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
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

namespace IconPacks_Vs_mahapps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            MinHeight = 400;
            MinWidth = 600;

            PreviewMouseDoubleClick+= delegate
            {
                if(SizeToContent == SizeToContent.Manual)
                {
                    SizeToContent = SizeToContent.WidthAndHeight;
                    Background = Brushes.DimGray;

                }
                else
                {
                    SizeToContent = SizeToContent.Manual;
                    Background = Brushes.Green;
                }
            };
            Content = new uc_LiveChart_Test();

        }

       

       async private void Test_Click(object sender, RoutedEventArgs e)
        {
           var prg =  await this.ShowProgressAsync($"Window Size Mode is:  {this.SizeToContent.ToString()}", "", true);
            prg.Canceled += async delegate
            {
                await prg.CloseAsync();
            };
        }
    }
}
