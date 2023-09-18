using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Businescope.TaskManager.Utility
{
    public static class ExceptionHandler
    {
        /// <summary>
        /// Обработчик неизвестной ошибки (Отображение окна с ошибкой + Логирование)
        /// </summary>
        /// <param name="ex">Пойманное исключение</param>
        /// <param name="caption">Заголовок окна</param>
        public static void Unknown(Exception ex, string caption = "Ошибка", bool isShowMessageBox = true)
        {
            Program.logger.Error(ex.Message);

            if (isShowMessageBox)
            {
                MessageBox.Show(ex.Message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обработчик неизвестной ошибки (Отображение окна с ошибкой + Логирование)
        /// </summary>
        /// <param name="message">Сообщение окна</param>
        /// <param name="caption">Заголовок окна</param>
        public static void Unknown(string message, string caption = "Ошибка", bool isShowMessageBox = true)
        {
            Program.logger.Error(message);

            if (isShowMessageBox)
            {
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
