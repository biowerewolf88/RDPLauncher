using System.Reflection;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDPLauncher
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            var version = Assembly.GetExecutingAssembly().GetName().Version;

            lblInfo.Text =
    $@"RDP Launcher  |  Версия: {version}  |  {RuntimeInformation.FrameworkDescription}  |  {RuntimeInformation.OSArchitecture}

Автоматический запуск RDP с выбором основного или резервного сервера.

FAQ
• Не подключается? Нажмите ""Обновить"".
• Cервера недоступны? Бегом к администратору с презентом.
• Изменить список рабочих мест? Отредактируйте config.ini.
• Проверка через ip:port! Редактируется в config.ini.

     © Мажаев Владимир, e-mail: biowerewolf@mail.ru, 2026";
        }
    }
}
