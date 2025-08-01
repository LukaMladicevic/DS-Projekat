﻿using DSBooking.Domain.Entity.Client;
using DSBooking.Domain.Entity.Reservation;
using DSBooking.Presentation.View.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSBooking.Presentation.View
{
    public partial class ReservationControlView : UserControl, IReservationControlView
    {
        public ReservationControlView()
        {
            InitializeComponent();
        }

        public Control Control => this;

        public event EventHandler<Reservation>? OnSelectedReservation;

        public void ShowReservations(IEnumerable<Reservation> reservations)
        {
            reservationsGridView.DataSource = reservations;
            reservationsGridView.Refresh();
        }
    }
}
