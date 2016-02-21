using InformaticsTrainerApp.Tools;
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

            openStudentModeButton.Click += (sender, args) => Invoke(StudentModeClicked);
            openTeacherModeButton.Click += (sender, args) => Invoke(TeacherModeClicked);
        }

        public void OpenStudentMode()
        {
            FormUtils.OpenFormAndSaveHierarchy(this, new StudentModeView());//, new Presenters.StudentModePresenter);
        }

        public void OpenTeacherMode()
        {
            
        }

        public void OpenHelp()
        {

        }

        public void Show()
        {
            ShowDialog();
        }

        public void Exit()
        {
            Close();
        }





        //--------------ACTIONS-----------------
        
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
