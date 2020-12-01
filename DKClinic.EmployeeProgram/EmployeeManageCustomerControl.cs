﻿using DKClinic.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DKClinic.EmployeeProgram
{
    public partial class EmployeeManageCustomerControl : BaseUC
    {
        public Employee CurrentEmployeeInHere { get; set; }

        public EmployeeManageCustomerControl()
        {
            InitializeComponent();
            Title = "환자 정보 관리";

            customerBindingSource.DataSource = Dao.Customer.GetWithGenderName();
        }

        public EmployeeManageCustomerControl(Employee employee) : this()
        {
            CurrentEmployeeInHere = employee;
        }

        public Customer SelectedCustomerData { get; set; }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            EmployeeSelectFunctionControl esfc = new EmployeeSelectFunctionControl(CurrentEmployeeInHere);
            OnbtnCancelClicked(esfc);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SelectedCustomerData = new Customer();//선택된 회원 정보 저장용 변수
            SelectedCustomerData = customerBindingSource.Current as Customer;

            //삭제 확인 메세지
            if (WinformUtility.AskSure($"삭제 후 등록을 원하시면 문진표를 다시 작성해야 합니다.\n정말 삭제하시겠습니까?\n"))
                Dao.Customer.Delete(SelectedCustomerData);
            else
                return;

            //데이터 삭제 후 gridview reflash
            customerBindingSource.DataSource = Dao.Customer.GetWithGenderName();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SelectedCustomerData = new Customer();//선택된 회원 정보 저장용 변수
            SelectedCustomerData = customerBindingSource.Current as Customer;

            EmployeeUpdateCustomerInfoForm OpenUpdateCustomerInfo = new EmployeeUpdateCustomerInfoForm(SelectedCustomerData);//수정 폼 열기 위한 변수선언과 전달값(선택된 행 값)전달
            OpenUpdateCustomerInfo.ShowDialog();//수정 창 열기

            //데이터 수정 후 gridview refresh
            customerBindingSource.DataSource = Dao.Customer.GetWithGenderName();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            bgwSearch.RunWorkerAsync(txbName.Text);
        }

        private void bgwSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            string name = e.Argument.ToString();
            
            Thread.Sleep(1000);// BackgroundWork 테스트를 위한 딜레이

            List<Customer> namelist;

            if (name == "")
                namelist = Dao.Customer.GetWithGenderName();
            else
            {
                namelist = Dao.Customer.GetByName(name);
            }
           
            e.Result = namelist;
        }

        private void bgwSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            customerBindingSource.DataSource = (List<Customer>)e.Result;
            Cursor = Cursors.Arrow;
        }
    }
}
