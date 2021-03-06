﻿using GUI.Home;
using Logic.Services;
using Microsoft.Windows.Themes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace GUI.Login
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private const string _errorMsg = "Inloggningen misslyckades";

        private LoginService _loginService;
        public LoginPage()
        {
            InitializeComponent();

            _loginService = new LoginService();
            ShowsNavigationUI = false;
        }

        private void SignIn_Button(object sender, RoutedEventArgs e)
        {
            string username = this.tbUsername.Text;
            string password = this.pbPassword.Password;

            bool successful = _loginService.Login(username, password);

            if (successful)
            {

                HomePage homePage = new HomePage();

                this.NavigationService.Navigate(homePage);
            }
            else
            {

                MessageBox.Show(_errorMsg);
                this.tbUsername.Clear();
                this.pbPassword.Clear();
            }
            
        }
        private void Close_Button(object sender, RoutedEventArgs e)
        {
            
        }
        

    }
}
