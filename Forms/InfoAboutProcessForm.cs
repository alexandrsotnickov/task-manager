using Businescope.TaskManager.Entities;
using Businescope.TaskManager.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Businescope.TaskManager
{
    public partial class InfoAboutProcessForm : Form
    {
        EProcess eProcess = new EProcess();
        int id = 0;
        bool isPaused = false;
        public InfoAboutProcessForm(int processId)
        {
            InitializeComponent();
            id = processId;
        }

        private void InfoAboutProcessForm_Load(object sender, EventArgs e)
        {
            try
            {
                eProcess = eProcess.GetProcessInfo(id);
                processInfoPropertyGrid.SelectedObject = eProcess;
                updateInfoTimer.Start();

            }
            catch(Exception ex)
            {
                ExceptionHandler.Unknown(ex);
                this.Close();
            }
            
        }

        //Этот таймер обновляет данные процесса раз в 1 с.

        private void updateInfoTimer_Tick(object sender, EventArgs e)
        {
            updateInfoTimer.Stop();
            UpdatePropertyGrid();
            

        }

        //Метод асинхронно изменяет данные процесса и обновляет PropertyGrid в главном потоке
        private async void UpdatePropertyGrid()
        {
            try
            {
                await Task.Run(() =>
                {
                    eProcess = eProcess.GetProcessInfo(id);

                });
                if (!isPaused)
                {
                    processInfoPropertyGrid.SelectedObject = null;
                    processInfoPropertyGrid.SelectedObject = eProcess;
                    updateInfoTimer.Start();
                }
            }
            catch(Exception ex)
            {
                ExceptionHandler.Unknown(ex);
                this.Close();
            }

        }

        private void pauseUpdateButton_Click(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                updateInfoTimer.Stop();
                isPaused = true;
                pauseUpdateButton.Text = "Продолжить обновление данных";
                Program.logger.Info("Обновление данных на форме расширенной информации о процессе приостановлено");
            }
            else
            {
                updateInfoTimer.Start();
                isPaused = false;
                pauseUpdateButton.Text = "Приостановить обновление данных";
                Program.logger.Info("Обновление данных на форме расширенной информации о процессе запущено");
            }
        }
    }
}
