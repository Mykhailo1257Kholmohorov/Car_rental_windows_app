﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities1 _db;
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntities1();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            //var cars = _db.TypesOfCars.ToList();

            // Select Id as CarId and name as CarName from TypesOfCars
            //var cars = _db.TypesOfCars
            //    .Select(q => new { CarId = q.id, CarName = q.Make })
            //    .ToList();

            var cars = _db.TypesOfCars
                .Select(q => new
                {
                    Make = q.Make, 
                    Model = q.Model,
                    VIN = q.VIN,
                    Year = q.Year, 
                    LicensePlateNumber = q.LicensePlateNumber
                })
                .ToList();

            gvVehicleList.DataSource = cars;
            //gvVehicleList.Columns[0].HeaderText = "ID";
            //gvVehicleList.Columns[1].HeaderText = "Name";

        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {

        }
    }
}