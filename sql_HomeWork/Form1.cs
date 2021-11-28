using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql_HomeWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private FrmKategori _frmKategori;
        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_frmKategori == null || _frmKategori.IsDisposed)
            {
                _frmKategori = new FrmKategori();
            }
            //_frmKategori.MdiParent= this;
            _frmKategori.WindowState = FormWindowState.Maximized;
            _frmKategori.Show();
        }
        private FrmUrunler _frmUrunler;
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmUrunler==null || _frmUrunler.IsDisposed)
            {
                _frmUrunler = new FrmUrunler();
            }
            //_frmUrunler.MdiParent= this;
            _frmUrunler.WindowState = FormWindowState.Maximized;
            _frmUrunler.Show();
        }
    }
}
