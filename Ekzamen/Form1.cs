using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekzamen {
    public partial class Form1 : Form {
        private List<Помещение> Помещения1 = new List<Помещение>();
        private List<Помещение> Помещения2 = new List<Помещение>();

        public Form1() {
            InitializeComponent();
            Помещения1.Add(new Помещение() {
                Номер = 1,
                Тип = "Тренажерный зал",
                Название = "Мужской тренажерный зал"
            });
            Помещения1.Add(new Помещение() {
                Номер = 2,
                Тип = "Тренажерный зал",
                Название = "Женский тренажерный зал"
            });
            Помещения1.Add(new Помещение() {
                Номер = 4,
                Тип = "Теннисный зал",
                Название = "Большой теннисный зал"
            });
            Помещения1.Add(new Помещение() {
                Номер = 5,
                Тип = "Баскетбольный зал",
                Название = "Баскетбольный зал"
            });
            Помещения2 = new List<Помещение>(Помещения1);
            dataGridView1.DataSource = Помещения2;
        }

        private void Poisk_Click(object sender, EventArgs e) {
            dataGridView1.DataSource = Помещения1.Where(x => x.Название.ToLower().Contains(textBox1.Text.ToLower())).ToList();
        }

        private void Zbros_Click(object sender, EventArgs e) {
            dataGridView1.DataSource = Помещения2;
        }
    }

    public class Помещение {
        public int Номер { get; set; }
        public string Название { get; set; }
        public string Тип { get; set; }
    }
}