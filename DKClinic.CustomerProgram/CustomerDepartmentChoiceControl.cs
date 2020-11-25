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

namespace DKClinic.CustomerProgram
{
    public partial class CustomerDepartmentChoiceControl : BaseUC
    {
        public CustomerDepartmentChoiceControl()
        {
            InitializeComponent();
        }

        CustomerQuestionnareControl custQuestionnare = new CustomerQuestionnareControl();

        private void btnMG_Click(object sender, EventArgs e)
        {
            Department department = Dao.Department.GetByPK(1);
            OnDepartmentToQuestionare(department, custQuestionnare);
        }
        private void btnNU_Click(object sender, EventArgs e)
        {
            Department department = Dao.Department.GetByPK(2);
            OnDepartmentToQuestionare(department, custQuestionnare);
        }
        private void btnDR_Click(object sender, EventArgs e)
        {
            Department department = Dao.Department.GetByPK(3);
            OnDepartmentToQuestionare(department, custQuestionnare);
        }
        private void btnFM_Click(object sender, EventArgs e)
        {
            Department department = Dao.Department.GetByPK(4);
            OnDepartmentToQuestionare(department, custQuestionnare);
        }

        #region DepartmentToQuestionare event things for C# 3.0
        public event EventHandler<DepartmentToQuestionareEventArgs> DepartmentToQuestionare;

        protected virtual void OnDepartmentToQuestionare(DepartmentToQuestionareEventArgs e)
        {
            if (DepartmentToQuestionare != null)
                DepartmentToQuestionare(this, e);
        }

        private DepartmentToQuestionareEventArgs OnDepartmentToQuestionare(Department department, CustomerQuestionnareControl custQuestionnare)
        {
            DepartmentToQuestionareEventArgs args = new DepartmentToQuestionareEventArgs(department, custQuestionnare);
            OnDepartmentToQuestionare(args);

            return args;
        }

        private DepartmentToQuestionareEventArgs OnDepartmentToQuestionareForOut()
        {
            DepartmentToQuestionareEventArgs args = new DepartmentToQuestionareEventArgs();
            OnDepartmentToQuestionare(args);

            return args;
        }

        public class DepartmentToQuestionareEventArgs : EventArgs
        {
            public Department Department { get; set; }
            public CustomerQuestionnareControl CustQuestionnare { get; set; }

            public DepartmentToQuestionareEventArgs()
            {
            }

            public DepartmentToQuestionareEventArgs(Department department, CustomerQuestionnareControl custQuestionnare)
            {
                Department = department;
                CustQuestionnare = custQuestionnare;
            }
        }
        #endregion
    }

}
