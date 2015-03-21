using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Threading;
using System.Diagnostics;

namespace Startup_Program
{
    public partial class ManagerInSystemTrayForm : Form
    {
        #region Global Variables
        NotifyIcon managerNotifyIcon;
        Icon managmentIcon;
        SpeechSynthesizer synth = new SpeechSynthesizer();
        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        #endregion

        public ManagerInSystemTrayForm()
        {


            synth.SpeakAsync("Hello " + userName + ". System Manager Started");
            InitializeComponent();

            //Load icons from files in usable objects
            managmentIcon = new Icon("Management.ico");

            //Creat the icons and assign+show the manager icon
            managerNotifyIcon = new NotifyIcon();
            managerNotifyIcon.Icon = managmentIcon;
            managerNotifyIcon.Visible = true;


            MenuItem progNameMenuItem = new MenuItem("System Manager v0.1 DEV");
            MenuItem startHDDLEDMenuItem = new MenuItem("Start HDDLED Program");
            MenuItem quitMenuItem = new MenuItem("Quit");
            ContextMenu contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(quitMenuItem);
            contextMenu.MenuItems.Add(startHDDLEDMenuItem);
            contextMenu.MenuItems.Add(progNameMenuItem);

            managerNotifyIcon.ContextMenu = contextMenu;
            quitMenuItem.Click += quitMenuItem_Click;
            startHDDLEDMenuItem.Click += startHDDLEDMenuItem_Click;

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;




        }

        

        #region Menu Click Methods (NOT DONE)
        /// <summary>
        /// Quits the application when click on from the managment icon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void quitMenuItem_Click(object sender, EventArgs e)
        {
            synth.Speak("Hard drive l e d program exiting");
            synth.Speak("Program exiting");
            managerNotifyIcon.Dispose();
            this.Close();
        }
        /// <summary>
        /// Starts the HDDLED program, which is in HDDLED.cs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void startHDDLEDMenuItem_Click(object sender, EventArgs e)
        {
            //Starts the HDDLED form and program
            new HDDLED();
            //Announces that the program started successfully
            synth.SpeakAsync("Hard drive l e d program has started sucessfully");
        }
        #endregion
    }
}
     