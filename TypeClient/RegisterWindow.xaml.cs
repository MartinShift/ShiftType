﻿using TypeClient.ViewModels;
using System.Globalization;
using System;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace TypeClient
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
            DataContext = new RegisterWindowViewModel()
            {
                window = this,
            };

        }
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var securePassword = new SecureString();
            if (DataContext != null)
            { securePassword = ((PasswordBox)sender).SecurePassword; }
            if (securePassword == null)
            {
                return;
            }
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                ((dynamic)DataContext).Password = Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
        private void PasswordBox_ConfirmPasswordChanged(object sender, RoutedEventArgs e)
        {
            var securePassword = new SecureString();
            if (DataContext != null)
            { securePassword = ((PasswordBox)sender).SecurePassword; }
            if (securePassword == null)
            {
                return;
            }
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                ((dynamic)DataContext).ConfirmPassword = Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
        private Storyboard shimmerStoryboard;
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            StartShimmerAnimation(button);
        }
        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            StopShimmerAnimation(button);
        }
        private void StartShimmerAnimation(Button button)
        {
            shimmerStoryboard = new Storyboard();
            DoubleAnimation animation = new DoubleAnimation()
            {
                From = 1,
                To = 0.5,
                Duration = TimeSpan.FromSeconds(0.5),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            Storyboard.SetTarget(animation, button);
            Storyboard.SetTargetProperty(animation, new PropertyPath(OpacityProperty));

            shimmerStoryboard.Children.Add(animation);
            button.BeginStoryboard(shimmerStoryboard);
        }
        private void StopShimmerAnimation(Button button)
        {
            if (shimmerStoryboard != null)
            {
                button.BeginStoryboard(shimmerStoryboard);
                shimmerStoryboard.Stop();
                button.Resources.Remove("ShimmerAnimation");
                shimmerStoryboard = null;
            }
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
