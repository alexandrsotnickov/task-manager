using Businescope.TaskManager.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Businescope.TaskManager.Entities
{
    public class EProcess
    {
        
        
        [DisplayName("Имя процесса")]
        public string Name { get; set; }
        [DisplayName("Id процесса")]
        public int Id { get; set; }
        [DisplayName("Использование процессора %")]
        public string CpuLoad { get; set; }

        [DisplayName("Дата запуска процесса")]
        public DateTime StartTime { get; set; }
        
        [DisplayName("Объем памяти (активный частный рабочий набор) К")]
        public long RamLoadKb { get; set; }

        /// <summary>
        /// Получение информации об использовании процессора процессом
        /// </summary>
        /// <param name="process"></param>
        /// <returns></returns>
        public double GetCpuLoad(Process process)
        {
            double cpuLoad = 0;

            var scope = new ManagementScope("\\\\.\\root\\cimv2");
            scope.Connect();

            // create a query to get the CPU and memory usage
            var query = new SelectQuery("SELECT * FROM Win32_PerfFormattedData_PerfProc_Process WHERE IDProcess = " + process.Id);

            // execute the query
            var searcher = new ManagementObjectSearcher(scope, query);
            var results = searcher.Get();

            // loop through the results and get the CPU and memory usage
            foreach (var result in results)
            {
                cpuLoad = Convert.ToDouble(result["PercentProcessorTime"]);
            }

            return cpuLoad;
        }

        /// <summary>
        /// Получение информации об объеме памяти процесса (активный частный рабочий набор) в Килобайтах
        /// </summary>
        /// <param name="process"></param>
        /// <returns></returns>
        public long GetRamLoad(Process process)
        {
            var valueActiveRamInBytes = new PerformanceCounter("Process", "Working Set - Private", process.ProcessName);
            return valueActiveRamInBytes.RawValue / 1024;
        }
        /// <summary>
        /// Получение информации о процессе
        /// </summary>
        /// <param name="processId"></param>
        /// <returns></returns>
        public EProcess GetProcessInfo(int processId)
        {
            EProcess processInfo = new EProcess();
            Process process = Process.GetProcessById(processId);

            processInfo.Name = process.ProcessName;
            processInfo.Id = processId;
            processInfo.CpuLoad = GetCpuLoad(process).ToString();
            processInfo.StartTime = process.StartTime;
            processInfo.RamLoadKb = GetRamLoad(process);

            return processInfo;

        }
    }
}
