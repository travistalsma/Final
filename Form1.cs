using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Runtime.Versioning;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Star_Wars_API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {

        }

        // Get planet button that reveals information on the planet with the ID entered into the textbox. 
        public async void button1_Click(object sender, EventArgs e)
        {
            JSONHelper JSON1 = new JSONHelper();
            Planet planet = await JSON1.GetPlanet(textBox1.Text);
            textBox3.Text = planet.name;
            textBox4.Text = planet.rotation_period;
            textBox5.Text = planet.orbital_period;
            textBox6.Text = planet.diameter;
            textBox7.Text = planet.climate;
            textBox8.Text = planet.gravity;
            textBox9.Text = planet.terrain;
            textBox10.Text = planet.surface_water;
            textBox11.Text = planet.population;
        }

        // Get person button that reveals information on the person with the ID entered into the textbox.
        public async void button2_Click(object sender, EventArgs e)
        {
            JSONHelper JSON2 = new JSONHelper();
            Person person = await JSON2.GetPerson(textBox2.Text);
            textBox12.Text = person.name;
            textBox13.Text = person.height;
            textBox14.Text = person.mass;
            textBox15.Text = person.hair_color;
            textBox16.Text = person.skin_color;
            textBox17.Text = person.eye_color;
            textBox18.Text = person.birth_year;
            textBox19.Text = person.gender;
            textBox20.Text = person.homeworld;
        }

        // Get species button that should, but does not, reveal all information available for all species. 
        private async void button3_Click(object sender, EventArgs e)
        {
            AllSpecies allSpecies = await JSONHelper.GetAllSpecies();
            listBox1.DataSource = allSpecies.results;
            listBox1.DisplayMember = "name";

            //listBox1.DisplayMember = "name" + "classification";
            //listBox1.DisplayMember = "classification";
            //listBox1.DisplayMember = "name, classification";
            //listBox1.DisplayMember = "";
            //listBox1.DisplayMember = allSpecies.results.ToString();
            //listBox1.DisplayMember = allSpecies.ToString();
            //listBox1.DisplayMember = Species;
        }

        // Get random button that takes a random person, planet, and starship for some fun. 
        private async void button4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Person person = new Person();
            Planet planet = new Planet();
            Starships starships = new Starships();

            int randperson = random.Next(1, 88);
            string per = randperson.ToString();
            Person pers = await person.GetPerson(per);
            textBox21.Text = pers.name;

            int randplanet = random.Next(1, 62);
            string pla = randplanet.ToString();
            Planet plan = await planet.GetPlanet(pla);
            textBox22.Text = plan.name;

            int randstarship = random.Next(1, 10);
            string sta = randstarship.ToString();
            Starships star = await starships.GetStarships(sta);
            textBox23.Text = star.name;
        }

        // Mostly just text boxes below this point. 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
