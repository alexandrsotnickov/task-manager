using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Businescope.TaskManager.Entities
{
    public class EProcesses
    {
        EProcess eProcess = new EProcess();
        public static DataTable previousProcessesTable = new DataTable();

        /// <summary>
        /// Сохраняет в DataTable список процессов с названием и id, а также пишет в лог названия запущенных и закрытых процессов
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable CreateProcessesTable()
        {
            DataTable processesTable = new DataTable();
            
            processesTable.Columns.Add("Имя процесса", typeof(string));
            processesTable.Columns.Add("ID процесса", typeof(int));

            Process[] processes = Process.GetProcesses();
            foreach(Process process in processes)
            {
                DataRow row = processesTable.NewRow();

                try
                {
                    row["Имя процесса"] = process.ProcessName;
                    row["ID процесса"] = process.Id;
                   
                    processesTable.Rows.Add(row);
                }
                catch
                {
                    row.Delete();
                }
            }

            if (previousProcessesTable.Rows.Count > 0)
            {
                foreach (DataRow previousRow in previousProcessesTable.Rows)
                {
                    int processId = (int)previousRow["ID процесса"];
                    DataRow[] selectedRows = processesTable.Select($"[ID процесса] = {processId}");

                    if (selectedRows.Length == 0)
                    {
                        string processName = previousRow["Имя процесса"].ToString();
                        string logMessage = $"Процесс '{processName}' (ID: {processId}) был закрыт.";
                        Program.logger.Info(logMessage);
                    }
                }
                foreach (DataRow row in processesTable.Rows)
                {
                    int processId = (int)row["ID процесса"];
                    DataRow[] matchingRows = previousProcessesTable.Select($"[ID процесса] = {processId}");

                    if (matchingRows.Length == 0)
                    {
                        string processName = row["Имя процесса"].ToString();
                        string logMessage = $"Запущен новый процесс '{processName}' (ID: {processId}).";
                        Program.logger.Info(logMessage);
                    }
                }
            }

            previousProcessesTable = processesTable;

            return processesTable;
        }
    }
}
