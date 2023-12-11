﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace channelInspection.UI.Control
{
    public partial class TopBar : UserControl
    {
        public TopBar()
        {
            InitializeComponent();
            b창닫기.Click += B창닫기_Click;
        }

        public void Init()
        {
            this.deviceLamp1.Init();
        }

        private void B창닫기_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
