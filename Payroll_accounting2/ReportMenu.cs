﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_accounting2
{
    public partial class ReportMenu : Form
    {
        public ReportMenu()
        {
            InitializeComponent();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportSalaryDepartment reportSalaryDepartment = new ReportSalaryDepartment();
            reportSalaryDepartment.Show(this);
        }
    }
}
