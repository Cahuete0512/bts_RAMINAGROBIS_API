﻿using EMI_RA.API.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace EMI_RA.WPF
{
    /// <summary>
    /// Logique d'interaction pour Adherent.xaml
    /// </summary>
    public partial class Adherent : Page
    {
        #region Adherent
        public Adherent()
        {
            InitializeComponent();
        }
        #endregion

        #region Window_Loaded
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Ce serait mieux de mettre l'URL dans un fichier de config plutôt qu'en dur ici
            var clientApi = new Client("https://localhost:5001/", new HttpClient());

            //programmation asynchrone en C#
            var adherents = await clientApi.AdherentsAllAsync();

            liste.ItemsSource = adherents;
        }
        #endregion
    }
}
