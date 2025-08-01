using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSBooking.Domain.Entity.Package;
using DSBooking.Presentation.View.Interface;

namespace DSBooking.Presentation.View
{
    public partial class PackageControlView : UserControl, IPackageControlView
    {
        public PackageControlView()
        {
            InitializeComponent();
        }

        public Control Control => this;

        public event EventHandler<Package>? OnSelectedPackage;

        public void ShowPackages(IEnumerable<Package> packages)
        {
            packageDataGridView.DataSource = packages;
            packageDataGridView.Refresh();
        }
    }
}
