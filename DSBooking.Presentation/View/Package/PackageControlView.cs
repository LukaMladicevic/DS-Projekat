using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSBooking.Application.DTO.Package;

namespace DSBooking.Presentation.View.Package
{
    public partial class PackageControlView : UserControl, IPackageControlView
    {
        public PackageControlView()
        {
            InitializeComponent();

            packageDataGridView.ScrollBars = ScrollBars.None;
        }

        public Control Control => this;

        public event EventHandler<PackageDTO>? OnSelectedPackage;
        public event EventHandler? OnViewLoad;

        public void ShowPackages(IEnumerable<PackageDTO> packages)
        {
            packageDataGridView.DataSource = packages;
            packageDataGridView.Refresh();
        }

        private void PackageControlView_Load(object sender, EventArgs e)
        {
            OnViewLoad?.Invoke(this, EventArgs.Empty);
        }
    }
}
