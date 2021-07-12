using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Form1 : Form
    {
        private readonly UsuarioLogic _usuarioLogic;
        public Form1()
        {
            InitializeComponent();
            _usuarioLogic = new UsuarioLogic();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsBoxUsers.DataSource = new List<string>() { _usuarioLogic.GetOne(1).Nombre };
        }
    }
}
