namespace Projekt
{
    public partial class Form1 : Form
    {
        int datornsTal;
        int antalGissningar;

        public Form1()
        {
            InitializeComponent();
          
           label2.Items.Add(10);
            label2.Items.Add(20);
           
           label2.SelectedItem = label2.Items[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string störstaTal = label2.SelectItem.ToString();
            int störst = int.Parse(störstaTal);
            Random r = new Random();
            datornsTal = r.Next(1, störst + 1);

            
            button3.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;

           
            textBox2.Text = "??";
          
            antalGissningar = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            antalGissningar++;
            string gissa = textBox3.Text;
            int gissatTal = int.Parse(gissa);

            if (gissatTal == datornsTal)
            {
                textBox4.Text = "Korrekt efter" +
                antalGissningar + " försök.";
                button2.Enabled = true;

                textBox2.Text = datornsTal.ToString();
                textBox5.AppendText(antalGissningar + "Försök\n");

            }

            else if (gissatTal < datornsTal)
            {
                textBox4.Text = "För lågt. Försök igen.";
            }
            else
            {
                textBox4.Text = "För högt. Försök igen";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}