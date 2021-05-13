using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbtLarge.Select();

            
        }

        private void lstv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lstv1.View = View.Details;
            //lstv1.GridLines = true;
            //lstv1.FullRowSelect = true;

            //lstv1.Columns.Add("Mã Trà", 50);
            //lstv1.Columns.Add("Tên Trà", 150);
            //lstv1.Columns.Add("Đơn giá", 150);

            
        }

        void LoadImg()
        {
            List<string> ListImage = new List<string>() { "TS001", "TS002", "TS003", "TS004", "TS005", "TS006", "TS007", "TS008", "TS009", "TS010",
                                "TS011", "TS012", "TS013", "TS014", "TS015", "TS016", "TS017", "TS018", };

            
        }

        private void rbtLarge_CheckedChanged(object sender, EventArgs e)
        {
            lstv1.View = View.LargeIcon;
        }

        private void rbtSmall_CheckedChanged(object sender, EventArgs e)
        {
            lstv1.View = View.SmallIcon;
        }

        private void rbtDetails_CheckedChanged(object sender, EventArgs e)
        {
            lstv1.View = View.Details;
        }

        private void rbtList_CheckedChanged(object sender, EventArgs e)
        {
            lstv1.View = View.List;
        }

        private void rbtTile_CheckedChanged(object sender, EventArgs e)
        {
            lstv1.View = View.Tile;
        }

        private void ReadFile()
        {
            List<string> lstTraSua = new List<string>();
            lstTraSua.Clear();

            string folderPath = @"D:\khoawf\khoaWF\khoaWF\LTWindows_Lab08\TRASUA";
            string line;
            //string[] spitter;
            
            StreamReader srd = new StreamReader(folderPath + "//DSTraSua.txt");
            while((line = srd.ReadLine()) != null)
            {
                
            }

        }
    }
}
