using DeepNaiWorkshop_6001.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepNaiWorkshop_6001.controller
{
    class MainFormController
    {
        private MainForm mainForm;
        public MainFormController(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public MainFormController()
        {
            mainForm = new MainForm();
        }

        public void Start()
        {
            //test
            mainForm.InitMedia();


            //-----end---------test



            mainForm.Show();
        }

    }
}
