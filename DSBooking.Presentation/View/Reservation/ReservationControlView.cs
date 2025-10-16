using DSBooking.Domain.Object.Reservation;
using DSBooking.Presentation.View.Reservation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace DSBooking.Presentation.View.Reservation
{
    public partial class ReservationControlView : UserControl, IReservationControlView
    {
        private readonly BindingSource _bindingSource = new BindingSource();

        private class ReservationRow
        {
            public int Id { get; set; }
            public string GuestName { get; set; } = "";
            public DateTime? DateOfReservation { get; set; }
            public string PackageName { get; set; } = "";
            public string PackageTypeName { get; set; } = "";
            public ReservationObject Original { get; set; } = null!;
        }

        public ReservationControlView()
        {
            InitializeComponent();

            reservationsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reservationsGridView.MultiSelect = false;
            reservationsGridView.ReadOnly = true; 
            reservationsGridView.RowHeadersVisible = false;
            reservationsGridView.AutoGenerateColumns = false;
            reservationsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            reservationsGridView.AllowUserToAddRows = false;
            reservationsGridView.DataSource = _bindingSource;
            reservationsGridView.ScrollBars = ScrollBars.None;
            reservationsGridView.Enabled = true;

            reservationsGridView.Columns.Clear();

            reservationsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "GuestName",
                HeaderText = "Guest",
                DataPropertyName = "GuestName",
                ReadOnly = true
            });

            reservationsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PackageName",
                HeaderText = "Package name",
                DataPropertyName = "PackageName",
                ReadOnly = true,
                Width = 120
            });

            reservationsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PackageTypeName",
                HeaderText = "Type",
                DataPropertyName = "PackageTypeName",
                ReadOnly = true,
                Width = 120
            });


            var deleteCol = new DataGridViewButtonColumn
            {
                Name = "DeleteButton",
                HeaderText = "",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                ReadOnly = false,
                Width = 100
            };
            reservationsGridView.Columns.Add(deleteCol);

            reservationsGridView.CellContentClick += ReservationsGridView_CellContentClick;
            reservationsGridView.CellMouseDown += ReservationsGridView_CellMouseDown;
            reservationsGridView.DataBindingComplete += ReservationsGridView_DataBindingComplete;

            this.Load += ReservationControlView_Load;
        }

        public Control Control => this;

        public event EventHandler<ReservationObject>? OnSelectedReservation;

        public event EventHandler? OnViewLoad;

        public void ShowReservations(IEnumerable<ReservationObject> reservations)
        {
            //_bindingSource.DataSource = reservations?.ToList() ?? new List<ReservationObject>();
            //foreach (var r in reservations)
            //{
            //    MessageBox.Show($"[DEBUG] Reservation Id={r.Id}, client name={r.Client.FirstName}, package={r.Package.Name}, type={r.Package.PackageTypeName}");
            //} 
            //reservationsGridView.Refresh();

            var list = (reservations ?? Enumerable.Empty<ReservationObject>()).ToList();

            var viewList = list.Select(r => new ReservationRow
            {
                Id = r.Id,
                GuestName = r.Client != null
                    ? string.Join(" ", new[] { r.Client.FirstName, r.Client.LastName }.Where(s => !string.IsNullOrWhiteSpace(s)))
                    : "(no client)",
                DateOfReservation = r.DateOfReservation,
                PackageName = r.Package?.Name ?? "(no package)",
                PackageTypeName = r.Package?.PackageTypeName ?? "(no type)",
                Original = r
            }).ToList();

            _bindingSource.DataSource = viewList;
            reservationsGridView.Refresh();
        }

        private void ReservationControlView_Load(object? sender, EventArgs e)
        {
            OnViewLoad?.Invoke(this, EventArgs.Empty);
        }

        private void ReservationsGridView_CellMouseDown(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.Button != MouseButtons.Left) return;

            try
            {
                reservationsGridView.CurrentCell = reservationsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                reservationsGridView.Rows[e.RowIndex].Selected = true;
                reservationsGridView.Focus();
            }
            catch
            {
            }
        }

        private void ReservationsGridView_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            reservationsGridView.ClearSelection();
        }

        private void ReservationsGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            HandleButtonClick(sender as DataGridView, e);
        }

        private void ReservationsGridView_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            HandleButtonClick(sender as DataGridView, e);
        }

        private void HandleButtonClick(DataGridView? grid, DataGridViewCellEventArgs e)
        {
            if (grid == null) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var col = grid.Columns[e.ColumnIndex];
            if (col == null) return;

            if (col.Name == "DeleteButton")
            {
                // previously cast to ReservationObject which is wrong:
                // var res = grid.Rows[e.RowIndex].DataBoundItem as ReservationObject;

                var row = grid.Rows[e.RowIndex].DataBoundItem as ReservationRow;
                if (row != null && row.Original != null)
                {
                    OnSelectedReservation?.Invoke(this, row.Original);
                }
            }
        }


        private void reservationsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void reservationsGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
