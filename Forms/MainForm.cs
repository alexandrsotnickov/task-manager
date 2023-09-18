using Businescope.TaskManager.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Businescope.TaskManager
{
    public partial class MainForm : Form
    {
        EProcesses processesList = new EProcesses();
        DataTable dt = new DataTable();

        int selectedRowIndex = 0;
        int selectedColumnIndex = 0;
        int firstVisibleRow = 0;
        int firstVisibleCol = 0;

        bool isPaused = false;
        public MainForm()
        {
            Program.logger.Info("Запуск приложения...");
            InitializeComponent();
            typeof(DataGridView).InvokeMember(
                "DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null,
                processesDataGridView,
                new object[] { true }
            );
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            dt = processesList.CreateProcessesTable();
            processesDataGridView.DataSource = dt;

            countProcessesLabel.Text = $"Запущено процессов: {processesDataGridView.RowCount.ToString()}";

            firstVisibleRow = processesDataGridView.FirstDisplayedScrollingRowIndex;
            firstVisibleCol = processesDataGridView.FirstDisplayedScrollingColumnIndex;

            StartNoSortableModeDatagridView();

            if (!isPaused)
            {
                refreshGridViewTimer.Start();
            }
            Program.logger.Info("Приложение запущено");

        }

        //Таймер, который обновляет грид раз в секунду (не считая выполнения методов)
        private void refreshGridViewTimer_Tick(object sender, EventArgs e)
        {
            refreshGridViewTimer.Stop();
            UpdateDataGridView();
        }

        //Обновление DataTable со списком процессов в отдельном поток и перерисовка грида в основном

        private async void UpdateDataGridView() 
        {
            await Task.Run(() =>
            {
                dt = processesList.CreateProcessesTable();

            });

            firstVisibleRow = processesDataGridView.FirstDisplayedScrollingRowIndex;
            firstVisibleCol = processesDataGridView.FirstDisplayedScrollingColumnIndex;

            if (!isPaused)
            {
                processesDataGridView.DataSource = dt;
            }
            

            countProcessesLabel.Text =$"Запущено процессов: {processesDataGridView.RowCount.ToString()}";

            StartNoSortableModeDatagridView();

            if (selectedRowIndex >= 0 && selectedRowIndex < processesDataGridView.RowCount)
            {
                processesDataGridView.CurrentCell = processesDataGridView[selectedColumnIndex, selectedRowIndex];
                processesDataGridView.Rows[selectedRowIndex].Selected = true;
            }

            if (firstVisibleRow >= 0 && firstVisibleCol >= 0)
            {
                processesDataGridView.FirstDisplayedScrollingRowIndex = firstVisibleRow;
                processesDataGridView.FirstDisplayedScrollingColumnIndex = firstVisibleCol;
            }
            if (!isPaused)
            {
                refreshGridViewTimer.Start();
            }

        }
        private void processesDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRowIndex = processesDataGridView.CurrentCell.RowIndex;
            selectedColumnIndex = processesDataGridView.CurrentCell.ColumnIndex;
            if (e.RowIndex >= 0)
            {
                processesDataGridView.Rows[e.RowIndex].Selected = true;
            }
        }

        //Этот метод запрещает использовать сортировку в гриде
        private void StartNoSortableModeDatagridView()
        {
            foreach (DataGridViewColumn column in processesDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void processesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.logger.Info($"Запрос пользователя на получение информации о процессе {processesDataGridView.CurrentRow.Cells[0].Value}" +
                $" (ID: {processesDataGridView.CurrentRow.Cells[1].Value})");
            InfoAboutProcessForm infoAboutProcessForm = new InfoAboutProcessForm(
                Convert.ToInt32(processesDataGridView.CurrentRow.Cells[1].Value));
            infoAboutProcessForm.ShowDialog();
        }

        private void pauseUpdateButton_Click(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                refreshGridViewTimer.Stop();
                isPaused = true;
                pauseUpdateButton.Text = "Продолжить обновление данных";
                Program.logger.Info("Обновление данных на форме со списком процессов приостановлено");
            }
            else
            {
                refreshGridViewTimer.Start();
                isPaused = false;
                pauseUpdateButton.Text = "Приостановить обновление данных";
                Program.logger.Info("Обновление данных на форме со списком процессов запущено");
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.logger.Info("Работа приложения завершена");
        }
    } 
}
