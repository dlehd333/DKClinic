﻿
namespace DKClinic.Employee
{
    partial class empChangePw
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbNewPw = new System.Windows.Forms.TextBox();
            this.txbNewPwCheck = new System.Windows.Forms.TextBox();
            this.txbOldPw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(190, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(190, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "PW확인";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(190, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 50);
            this.label3.TabIndex = 0;
            this.label3.Text = "신규PW";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(190, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 50);
            this.label4.TabIndex = 0;
            this.label4.Text = "기존PW";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOK.Location = new System.Drawing.Point(250, 600);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 80);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(606, 600);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 80);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txbName.Location = new System.Drawing.Point(466, 92);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(350, 53);
            this.txbName.TabIndex = 1;
            // 
            // txbNewPw
            // 
            this.txbNewPw.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txbNewPw.Location = new System.Drawing.Point(466, 332);
            this.txbNewPw.Name = "txbNewPw";
            this.txbNewPw.PasswordChar = '*';
            this.txbNewPw.Size = new System.Drawing.Size(350, 53);
            this.txbNewPw.TabIndex = 3;
            // 
            // txbNewPwCheck
            // 
            this.txbNewPwCheck.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txbNewPwCheck.Location = new System.Drawing.Point(466, 452);
            this.txbNewPwCheck.Name = "txbNewPwCheck";
            this.txbNewPwCheck.PasswordChar = '*';
            this.txbNewPwCheck.Size = new System.Drawing.Size(350, 53);
            this.txbNewPwCheck.TabIndex = 4;
            // 
            // txbOldPw
            // 
            this.txbOldPw.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txbOldPw.Location = new System.Drawing.Point(466, 212);
            this.txbOldPw.Name = "txbOldPw";
            this.txbOldPw.PasswordChar = '*';
            this.txbOldPw.Size = new System.Drawing.Size(350, 53);
            this.txbOldPw.TabIndex = 2;
            // 
            // empChangePw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.txbOldPw);
            this.Controls.Add(this.txbNewPwCheck);
            this.Controls.Add(this.txbNewPw);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "empChangePw";
            this.Text = "empChangePw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbNewPw;
        private System.Windows.Forms.TextBox txbNewPwCheck;
        private System.Windows.Forms.TextBox txbOldPw;
    }
}