using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas3
{
    public partial class Form1 : Form, INotifyPropertyChanged
    {
        string ActiveForm;
        List<FormPict> frmPict = new List<FormPict>();
        List<ToolStripMenuItem> TsItem = new List<ToolStripMenuItem>();
        ToolStripMenuItem Ts;
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
            ToolStripMenuItem item = (ToolStripMenuItem)menuStrip1.Items["windowToolStripMenuItem"];
            foreach (ToolStripMenuItem itemchecked in item.DropDownItems)
            {
                if (!itemchecked.Text.Equals(v))
                    itemchecked.Checked = false;
                else
                    itemchecked.Checked = true;
            }
        }
        public string ActiveForm1
        {
            get
            {
                return ActiveForm;
            }
            set
            {
                ActiveForm = value;
                OnPropertyChanged(ActiveForm1);
            }
        }
        public Form1()
        {
            InitializeComponent();
            FormPict FP;
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                frmPict.Add(new FormPict(this)
                {
                    Text = System.IO.Path.GetFileName(openFileDialog1.FileName),
                    MdiParent = this
                });
                frmPict[frmPict.Count - 1].setpic(Image.FromFile(openFileDialog1.FileName));
                frmPict[frmPict.Count - 1].Show();
                ToolStripMenuItem item = (ToolStripMenuItem)menuStrip1.Items["windowToolStripMenuItem"];
                foreach (ToolStripMenuItem itemchecked in item.DropDownItems)
                {
                    itemchecked.Checked = false;
                }
                TsItem.Add(new ToolStripMenuItem(null,null,ItemClick)
                {
                    Text = System.IO.Path.GetFileName(openFileDialog1.FileName), Checked = true
                });
                item.DropDownItems.Add(TsItem[TsItem.Count - 1]);
               }
            }
        private void ItemClick(object sender, EventArgs e)
        {
            var tms = (ToolStripMenuItem)sender;
            for (int i = 0; i < frmPict.Count; i++)
            {
                if (String.Equals(frmPict[i].Text,tms.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    frmPict[i].Activate();
                }
            }
        }
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            FormPict tempChild = (FormPict)this.ActiveMdiChild;
            tempChild.Putarkanan();
        }
        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            FormPict tempChild = (FormPict)this.ActiveMdiChild;
            tempChild.Putarkiri();
        }
        private int AllDegree;
        public int AllDegree1
        {
            get
            {
                return AllDegree;
            }

            set
            {
                AllDegree = value;
            }
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            FormPict tempChild = (FormPict)this.ActiveMdiChild;
            tempChild.Zoomin();
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            FormPict tempChild = (FormPict)this.ActiveMdiChild;
            tempChild.Zoomout();
        }
        private int AllZoom;
        public int AllZoom1
        {
            get
            {
                return AllZoom;
            }

            set
            {
                AllZoom = value;
            }
        }
    }
}