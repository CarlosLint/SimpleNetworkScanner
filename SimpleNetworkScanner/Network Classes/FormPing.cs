﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleNetworkScanner.Network_Classes
{
    public partial class FormPing : Form
    {
        private List<IPAddress> TARGETS;

        public FormPing(string formHead)
        {
            InitializeComponent();
            TARGETS = FormSession.TARGETS;
            Text = formHead;
        }

        private void FormPing_Load(object sender, EventArgs e)
        {

        }
    }
}