using InformaticsTrainerApp.View_Interfaces;
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
    public partial class TeacherModeView : Form, ITeacherModeView
    {
        private readonly ApplicationContext context;

        public TeacherModeView(ApplicationContext context)
        {
            this.context = context;
            InitializeComponent();
            InitializeComponent();
        }

        public new void Show()
        {
            context.MainForm = this;
            Application.Run(context);
        }
    }
}
