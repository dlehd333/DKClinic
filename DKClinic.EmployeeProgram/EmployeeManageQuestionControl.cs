﻿using DKClinic.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DKClinic.EmployeeProgram
{
    public partial class EmployeeManageQuestionControl : BaseUC
    {
        public EmployeeManageQuestionControl()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            EmployeeSelectFunctionControl employeeSelectFunctionControl = new EmployeeSelectFunctionControl();
            OnbtnCancelClicked(employeeSelectFunctionControl);
        }
    }
}
