using System.Threading.Tasks.Dataflow;

namespace lab4inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void button1_Load_Click(object sender, EventArgs e)
        {
            Pikachu pikachu = new Pikachu();
            label_name.Text = pikachu.Name();
            pictureBox1.Image = lab4inheritance.Properties.Resources._025;
        }

        private void button2_Load_Click(object sender, EventArgs e)
        {
            jolteon jolteon = new jolteon();
            label_name.Text = jolteon.Name();
            pictureBox1.Image = lab4inheritance.Properties.Resources.jolteon;
        }

        private void button3_Load_Click(object sender, EventArgs e)
        {
            Nine Nine = new Nine();
            label_name.Text = Nine.Name();
            pictureBox1.Image = lab4inheritance.Properties.Resources.Nine;
        }

        private void button4_Load_Click(object sender, EventArgs e)
        {
            Persian Persian = new Persian();
            label_name.Text = Persian.Name();
            pictureBox1.Image = lab4inheritance.Properties.Resources.Persian;
        }

        private void button5_load_Click(object sender, EventArgs e)
        {
            Dragonite Dragonite = new Dragonite();
            label_name.Text = Dragonite.Name();
            pictureBox1.Image = lab4inheritance.Properties.Resources.Dragonite;
        }

        private void button6_load_Click(object sender, EventArgs e)
        {
            Snorunt Snorunt = new Snorunt();
            label_name.Text = Snorunt.Name();
            pictureBox1.Image = lab4inheritance.Properties.Resources.Snorunt;
        }
    }
}
