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
            
            string st�rstaTal = label2.SelectItem.ToString();
            int st�rst = int.Parse(st�rstaTal);
            Random r = new Random();
            datornsTal = r.Next(1, st�rst + 1);

            
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
                antalGissningar + " f�rs�k.";
                button2.Enabled = true;

                textBox2.Text = datornsTal.ToString();
                textBox5.AppendText(antalGissningar + "F�rs�k\n");

            }

            else if (gissatTal < datornsTal)
            {
                textBox4.Text = "F�r l�gt. F�rs�k igen.";
            }
            else
            {
                textBox4.Text = "F�r h�gt. F�rs�k igen";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}