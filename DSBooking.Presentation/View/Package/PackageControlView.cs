using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DSBooking.Domain.Object.Package;

namespace DSBooking.Presentation.View.Package
{
    public partial class PackageControlView : UserControl, IPackageControlView
    {
        private readonly BindingSource _bindingSource = new BindingSource();

        public PackageControlView()
        {
            InitializeComponent();

            packageDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            packageDataGridView.MultiSelect = false;
            packageDataGridView.ReadOnly = true; 
            packageDataGridView.RowHeadersVisible = false;
            packageDataGridView.AutoGenerateColumns = false;
            packageDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            packageDataGridView.AllowUserToAddRows = false;
            packageDataGridView.DataSource = _bindingSource;
            packageDataGridView.ScrollBars = ScrollBars.None;

            packageDataGridView.Columns.Clear();

            packageDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                ReadOnly = true,
                Width = 50
            });

            packageDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Name",
                DataPropertyName = "Name",
                ReadOnly = true
            });

            packageDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Description",
                HeaderText = "Description",
                DataPropertyName = "Description", 
                ReadOnly = true
            });

            packageDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Price",
                DataPropertyName = "Price",
                ReadOnly = true,
                Width = 80
            });

            var bookCol = new DataGridViewButtonColumn
            {
                Name = "BookButton",
                HeaderText = "Action",
                Text = "Book",
                UseColumnTextForButtonValue = true,
                ReadOnly = false,
                Width = 100
            };
            packageDataGridView.Columns.Add(bookCol);

            packageDataGridView.CellContentClick += PackageDataGridView_CellContentClick;
            packageDataGridView.CellMouseDown += PackageDataGridView_CellMouseDown;
            packageDataGridView.DataBindingComplete += PackageDataGridView_DataBindingComplete;

            this.Load += PackageControlView_Load;
        }

        public Control Control => this;

        public event EventHandler<PackageObject>? OnSelectedPackage;

        public event EventHandler? OnViewLoad;

        public void ShowPackages(IEnumerable<PackageObject> packages)
        {
            _bindingSource.DataSource = packages?.ToList() ?? new List<PackageObject>();
            packageDataGridView.Refresh();
        }

        private void PackageControlView_Load(object? sender, EventArgs e)
        {
            OnViewLoad?.Invoke(this, EventArgs.Empty);
        }

        private void PackageDataGridView_CellMouseDown(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.Button != MouseButtons.Left) return;

            try
            {
                packageDataGridView.CurrentCell = packageDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                packageDataGridView.Rows[e.RowIndex].Selected = true;
                packageDataGridView.Focus();
            }
            catch
            {
            }
        }

        private void PackageDataGridView_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            packageDataGridView.ClearSelection();
        }

        private void PackageDataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            HandleButtonClick(sender as DataGridView, e);
        }

        private void PackageDataGridView_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            HandleButtonClick(sender as DataGridView, e);
        }

        private void HandleButtonClick(DataGridView? grid, DataGridViewCellEventArgs e)
        {
            if (grid == null) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var col = grid.Columns[e.ColumnIndex];
            if (col == null) return;

            if (col.Name == "BookButton")
            {
                var pkg = grid.Rows[e.RowIndex].DataBoundItem as PackageObject;
                if (pkg != null)
                {
                    OnSelectedPackage?.Invoke(this, pkg);
                }
            }
        }

        private void packageDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
