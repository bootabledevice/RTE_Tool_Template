using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XRPCLib;
using XDevkitPlusPlus;

namespace RTE_Tool_Template
{
    public partial class Form1 : Form
    {

        XRPC Jtag = new XRPC();

        public Form1()
        {
            InitializeComponent();
        }

        private void connectConsole_Click(object sender, EventArgs e)
        {
            try
            {
                Jtag.Connect();
                if (Jtag.activeConnection == true)
                {
                    MessageBox.Show("Connected To Console", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("XRPC Connection Failed", "Connected Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("XBDM Connection Failed", "Connected Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //C1 (0x00000000, 0x00000000)
        //    MemoryAdd,  Value
        //

        private void c1_Click(object sender, EventArgs e)
        {
            Jtag.xbCon.DebugTarget.WriteUInt32(0x00000000, 0x00000000);
        }

        //C2 (0x00000000, 0x00000000)
        //    MemoryAdd,  Value
        //

        private void c2_Click(object sender, EventArgs e)
        {
            Jtag.xbCon.DebugTarget.WriteUInt32(0x00000000, 0x00000000);
        }

        //C3 (0x00000000, 0x00000000)
        //    MemoryAdd,  Value
        //Timer Interval = 100MS

        private void c3_Click(object sender, EventArgs e)
        {
            if (c3Timer.Enabled)
            {
                c3Timer.Stop();
                c3Status.Text = "Not Active";
            }
            else
            {
                c3Timer.Start();
                c3Status.Text = "Active";
            }
        }

        private void c3Timer_Tick(object sender, EventArgs e)
        {
            Jtag.xbCon.DebugTarget.WriteUInt32(0x00000000, 0x00000000);
        }

        //C4 (0x00000000, 0x00000000)
        //    MemoryAdd,  Value
        //Timer Interval = 100MS

        private void c4_Click(object sender, EventArgs e)
        {
            if (c4Timer.Enabled)
            {
                c4Timer.Stop();
                c4Status.Text = "Not Active";
            }
            else
            {
                c4Timer.Start();
                c4Status.Text = "Active";
            }
        }

        private void c4Timer_Tick(object sender, EventArgs e)
        {
            Jtag.xbCon.DebugTarget.WriteUInt32(0x00000000, 0x00000000);
        }
    }
}
