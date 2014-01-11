﻿using NuGet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KerbalWinDownloader
{
    public partial class Form1 : Form
    {
        PackageManager _PackageManager;
        IProjectManager _ProjectManager;
        IPackageRepository _PackageRepository;

        public Form1()
        {
            InitializeComponent();

            

            var kerbalPath = ConfigurationManager.AppSettings.Get("kerbalInstallPath");
            var serverUrl = ConfigurationManager.AppSettings.Get("kerbalModServer");
            txtKerbalPath.Text = kerbalPath;

            var modCacheDirectory = kerbalPath + @"\ModCache";


            _PackageRepository = PackageRepositoryFactory.Default.CreateRepository(serverUrl);
           
            //_PackageManager = new PackageManager(
            //    _PackageRepository,
            //    new DefaultPackagePathResolver(serverUrl),
            //    new PhysicalFileSystem(kerbalPath + @"\test"),
            //    new SharedPackageRepository(kerbalPath + @"\GameData")
            //);
            _PackageManager = new PackageManager(_PackageRepository, kerbalPath + @"\GameData");

            _ProjectManager = new ProjectManager(_PackageRepository,
                new DefaultPackagePathResolver(serverUrl),
                new KerbalProjectSystem(kerbalPath),
                new LocalPackageRepository(modCacheDirectory));

            if (!Directory.Exists(modCacheDirectory))
            {
                Directory.CreateDirectory(modCacheDirectory);
            }
            
            lstAvailableMods.DisplayMember = "Description";
            lstAvailableMods.ValueMember = "Id";

            lstInstalledMods.DisplayMember = "Description";
            lstInstalledMods.ValueMember = "Id";
            RefreshModLists();
        }

        private void lstAvailableMods_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            var package = lstAvailableMods.SelectedItem as IPackage;
            //packageManager.InstallPackage(package, true, true);
            //_PackageManager.LocalRepository.
            var existingPackages = _ProjectManager.LocalRepository.FindPackagesById(package.Id);
            if (existingPackages.Any())
                _ProjectManager.RemovePackageReference(package, true, false);
                //_ProjectManager.UninstallPackage(package.Id);
            
            //_PackageManager.InstallPackage(package, true, true);
            _ProjectManager.AddPackageReference(package, false, true);
            

            RefreshModLists();
        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {
            var package = lstInstalledMods.SelectedItem as IPackage;
            //_ProjectManager.UninstallPackage(lstInstalledMods.SelectedItem as IPackage);
            _ProjectManager.RemovePackageReference(package, true, false);
            RefreshModLists();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtKerbalPath.Text = folderBrowserDialog1.SelectedPath;

            }
        }

        private void RefreshModLists()
        {
            var packages = _PackageRepository.GetPackages();
            lstAvailableMods.DataSource = packages.ToList();

            var installedPackages = _ProjectManager.LocalRepository.GetPackages();
            lstInstalledMods.DataSource = installedPackages.ToList();
        }
     
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtKerbalPath.Text))
            {
                ConfigurationManager.AppSettings.Set("kerbalInstallPath", txtKerbalPath.Text);
            }
        }

        private void btnUpdateMod_Click(object sender, EventArgs e)
        {
            var package = lstInstalledMods.SelectedItem as IPackage;
            var foundPackage = _PackageRepository.FindPackage(package.Id);
            _PackageManager.UpdatePackage(package.Id, foundPackage.Version, true, true);
            //_PackageManager.UpdatePackage(package.Id, true, true);
            RefreshModLists();
        }
    }
}