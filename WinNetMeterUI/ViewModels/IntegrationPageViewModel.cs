﻿using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WinNetMeter.Core.Helper;

namespace WinNetMeterUI.ViewModels
{
    public class IntegrationPageViewModel : BindableBase
    {
        private ShellController shellController;
        private Integration integration;
        private bool _showShellOnTaskbar;

        public bool ShowShellOnTaskbar
        {
            get { return _showShellOnTaskbar; }
            set
            {
                SetProperty(ref _showShellOnTaskbar, value);
                ShellBehaviour(_showShellOnTaskbar);
            }
        }

        public DelegateCommand RegisterShellCommand { get; set; }
        public DelegateCommand UninstallShellCommand { get; set; }

        public IntegrationPageViewModel()
        {
            shellController = new ShellController();
            integration = new Integration();

            RegisterShellCommand = new DelegateCommand(RegisterShell);
            UninstallShellCommand = new DelegateCommand(UninstallShell);
        }

        private void RegisterShell()
        {
            shellController.hideDeskband();
            integration.ReinstallToolbar();
            MessageBox.Show("Re-Register Shell Integration Successfully.", "WinNetMeter Integration",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void UninstallShell()
        {
            shellController.hideDeskband();
            integration.UninstallToolbar();
            MessageBox.Show("Uninstall Shell Integration Successfully.", "WinNetMeter Integration",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ShellBehaviour(bool isShow)
        {
            if (isShow)
            {
                //                MessageBox.Show("Shell shown");
                shellController.callDeskband();
            }
            else
            {
                shellController.hideDeskband();
                //                MessageBox.Show("Shell hidden");
            }
        }
    }
}