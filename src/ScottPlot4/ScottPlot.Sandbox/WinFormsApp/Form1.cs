﻿using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        readonly Random Rand = new(0);

        public Form1()
        {
            InitializeComponent();
            formsPlot1.Refresh();
            formsPlot1.MouseMove += FormsPlot1_MouseMove;
        }

        private void FormsPlot1_MouseMove(object sender, MouseEventArgs e)
        {
            formsPlot1.Refresh(skipIfCurrentlyRendering: true);
            int depth = new System.Diagnostics.StackTrace().FrameCount;
            label1.Text = $"Stack depth: {depth}";
            progressBar1.Value = depth;
        }
    }
}
