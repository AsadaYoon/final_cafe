﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_cafe.GUI
{
    public partial class Menu : Form
    {

        private string customername;
        private string CustomerName
        {
           get { return customername; }
           set { customername = value; }
        }
        private string customerID;
        private string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        private string customertype;
        private string CustomerType
        {
            get { return customertype; }
            set { customertype = value; }
        }
        private string gender;
        private string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private string customertelno;
        private string CustomerTelNo
        {
            get { return customertelno; }
            set { customertelno = value; }
        }


        public Menu(string CustomerName, string CustomerID, string CustomerType, string Gender, string CustomerTelNo)
        {
            InitializeComponent();
            this.CustomerName = CustomerName;
            this.CustomerID = CustomerID;
            this.CustomerType = CustomerType;
            this.Gender = Gender;
            this.CustomerTelNo = CustomerTelNo;
            this.name.Text = string.Format("{0} {1}", CustomerID, CustomerName);
        }

        public Menu()
        {
            InitializeComponent();
        }


        private void X_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LOGIN login = new LOGIN();
            login.ShowDialog();
        }
    }
}

