using InformaticsTrainerApp.Vew_Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformaticsTrainerApp.Views
{
    /*
    1.  interface
    2.  presenter
    3.  model
    4.  view
    */
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();

            button1.Click += (sender, args) => Invoke(StudentModeClicked);
        }

        public void OpenStudentMode()
        {
            label1.Text = "finish it!";
        }

        public void OpenTeacherMode()
        {

        }

        public void OpenHelp()
        {

        }

        public void Exit()
        {

        }

        public event Action StudentModeClicked;
        public event Action TeacherModeClicked;
        public event Action HelpClicked;
        public event Action ExitClicked;

        private void Invoke(Action action)
        {
            if (action != null) action();
        }
    }
}
