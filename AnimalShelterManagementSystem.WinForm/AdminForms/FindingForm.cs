﻿using AnimalShelterManagementSystem.Data;
using AnimalShelterManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelterManagementSystem.WinForm.AdminForms
{
    public partial class FindingForm : DevExpress.XtraEditors.XtraForm
    {
        private FindingReport findingReport;
        public FindingForm()
        {
            InitializeComponent();
            findingReport = new FindingReport();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }
        public FindingForm(FindingReport findingReport)
        {
            InitializeComponent();
            this.findingReport = findingReport;
            cbxSpecies.SelectedItem = findingReport.Species;
            dteDate.DateTime = findingReport.Date;
            txbPlace.Text = findingReport.Place;
            rdgIsInShelter.EditValue = findingReport.IsInShelter? 1 : 0;
            btnAdd.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Helpers.Helpers.SureToDelete() == false)
                return;

            DataRepository.FindingReport.Delete(findingReport);
            Close();
            return;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            findingReport.FindingReportId = DataRepository.FindingReport.GetMaxId() + 1;
            findingReport.Species = (int)((SpeciesType)Enum.Parse(typeof(SpeciesType), cbxSpecies.Text));
            findingReport.Date = dteDate.DateTime;
            findingReport.Place = txbPlace.Text;
            findingReport.IsInShelter = Convert.ToBoolean(rdgIsInShelter.EditValue);
            DataRepository.FindingReport.Insert(findingReport);
            Close();
            return;


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            findingReport.Species = (int)((SpeciesType)Enum.Parse(typeof(SpeciesType), cbxSpecies.Text));
            findingReport.Date = dteDate.DateTime;
            findingReport.Place = txbPlace.Text;
            findingReport.IsInShelter = Convert.ToBoolean(rdgIsInShelter.EditValue);
            DataRepository.FindingReport.Update(findingReport);
            Close();
            return;

        }

        private void FindingForm_Load(object sender, EventArgs e)
        {
            cbxSpecies.DataSource = Enum.GetValues(typeof(SpeciesType));
        }
    }
}
