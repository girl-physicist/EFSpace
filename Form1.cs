using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFSpace
{
    public partial class Form1 : Form
    {
        private double _h;
        private double _m;
        private double _r;

        private const double G = 6.65e+6;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ShowDada();
        }

        private List<Planet> GetPlanetData()
        {
            using (var db = new PlanetContext())
            {
                //// создаем два объекта User
                //Planet planet1 = new Planet() { Name = "Земля", M = 555e+10, R = 55e+5 };

                //// добавляем их в бд
                //db.Planetses.Add(planet1);
                //db.SaveChanges();
                var planets = db.Planetses.ToList();
                return planets;
            }
        }

        private void ShowDada()
        {
            comboBoxPlanet.DataSource = GetPlanetData();
            comboBoxPlanet.DisplayMember = "Name";
            comboBoxPlanet.ValueMember = "Id";
        }
        private void ButtonGetData_Click(object sender, EventArgs e)
        {
            var planets =  GetPlanetData();
            _h = double.Parse(textBoxH.Text);
            var id =int.Parse(comboBoxPlanet.SelectedValue.ToString());
             _m = planets.FirstOrDefault(f => f.Id == id).M;
            _r= planets.FirstOrDefault(f => f.Id == id).R;
        }

        private void ButtonUpdatePlanetList_Click(object sender, EventArgs e)
        {
            ShowDada();
        }

        private (double, double) CalcVelosity()
        {

            var v1=1.1;
            var v2=2.1;
            return (v1,v2);
        }

        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            textBoxV1.Text = CalcVelosity().Item1.ToString();
            textBoxV2.Text = CalcVelosity().Item2.ToString();
        }

        private void ButtonUpdateDBData_Click(object sender, EventArgs e)
        {
            var fm2 = new Form2();
            fm2.Show();
        }
    }
}



