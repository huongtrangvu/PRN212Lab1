﻿using System;
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
using BusinessObjects;
using Services;

namespace ProductManagement
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly IAccountService accountService;

        public LoginWindow()
        {
            InitializeComponent();
            accountService = new AccountService();

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            AccountMember acc = accountService.GetAccountById(txtUser.Text);
            if(acc != null && acc.MemberPassword.Equals(txtPass.Password) && acc.MemberRole==1) { 
                this.Hide();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("You are not permission !");
            }
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
