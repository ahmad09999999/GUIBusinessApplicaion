﻿using Buisnessapplication.BL;
using Buisnessapplication.DL;
using GraphicalUserInterface_Application.ManagerFuntion_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalUserInterface_Application.GUI.ManagerFuntion_Form
{
    public partial class DeleteReports_form : Form
    {
        public DeleteReports_form()
        {
            InitializeComponent();
        }

        private void DeleteReports_form_Load(object sender, EventArgs e)
        {
            List<MonthyReportBL> reportsList = Manager_BL.GetReports();

            dataGridView1.Columns.Add("Date", "Date");

            dataGridView1.Columns.Add("Borrow Books", "Borrow Books");
            dataGridView1.Columns.Add("Loans", "Loans");
            dataGridView1.Columns.Add("Lost Books", "Lost Books");

            dataGridView1.Columns["Date"].Width = 170;
            dataGridView1.Columns["Borrow Books"].Width = 170;
            dataGridView1.Columns["Loans"].Width = 170;
            dataGridView1.Columns["Lost Books"].Width = 170;

            foreach (MonthyReportBL report in reportsList)
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell dateCell = new DataGridViewTextBoxCell();
                dateCell.Value = report.GetDate();
                row.Cells.Add(dateCell);



                DataGridViewCell borrowBooksCell = new DataGridViewTextBoxCell();
                borrowBooksCell.Value = report.GetBorrowBooks();
                row.Cells.Add(borrowBooksCell);

                DataGridViewCell loansCell = new DataGridViewTextBoxCell();
                loansCell.Value = report.GetLoans();
                row.Cells.Add(loansCell);

                DataGridViewCell lostBooksCell = new DataGridViewTextBoxCell();
                lostBooksCell.Value = report.GetLostBooks();
                row.Cells.Add(lostBooksCell);

                dataGridView1.Rows.Add(row);
            }

            dataGridView1.ReadOnly = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = textBox1.Text;
            bool check = MonthlyReportDL.DeleteReport(date);
            if (check)
            {

                MonthlyReportDL.DeleteDataReportsInFile(GenerateReportsForm.pathReport, Manager_BL.GetReports());
                label8.Visible = true;

            }
            else
            {
                MessageBox.Show("Invalid Input. Please try again.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f=new FormMangerMenu();
            f.Show();
            this.Hide();
        }
    }
}
