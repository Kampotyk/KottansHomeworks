using MyFirstProject1;
using System;
using System.Windows.Forms;

namespace MyFirstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime enteredDate = new DateTime(Convert.ToInt32(textBox1.Text), 1, 1);
            textBox1.Text = enteredDate.isLeapYear().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var json = new System.Net.WebClient().DownloadString("https://randomuser.me/api/");
            RandomUser user = Newtonsoft.Json.JsonConvert.DeserializeObject<RandomUser>(json);
            textBox1.Text = user.results[0].name.first + " " + user.results[0].name.last;
        }
    }
}
