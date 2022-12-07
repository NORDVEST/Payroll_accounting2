using System;
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
    public partial class TableWork : Form
    {
        public TableWork()
        {
            InitializeComponent();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void departmentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departmentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.payroll_accounting2DataSet);

        }

        private void TableWork_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "payroll_accounting2DataSet.Tariff_schedule". При необходимости она может быть перемещена или удалена.
            this.tariff_scheduleTableAdapter.Fill(this.payroll_accounting2DataSet.Tariff_schedule);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "payroll_accounting2DataSet.working_days". При необходимости она может быть перемещена или удалена.
            this.working_daysTableAdapter.Fill(this.payroll_accounting2DataSet.working_days);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "payroll_accounting2DataSet.Allowances". При необходимости она может быть перемещена или удалена.
            this.allowancesTableAdapter.Fill(this.payroll_accounting2DataSet.Allowances);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "payroll_accounting2DataSet.Deductions". При необходимости она может быть перемещена или удалена.
            this.deductionsTableAdapter.Fill(this.payroll_accounting2DataSet.Deductions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "payroll_accounting2DataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.payroll_accounting2DataSet.Workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "payroll_accounting2DataSet.Positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.payroll_accounting2DataSet.Positions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "payroll_accounting2DataSet.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.payroll_accounting2DataSet.Departments);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableWork tableWork = new TableWork();
            tableWork.Show();
        }
    }
}
