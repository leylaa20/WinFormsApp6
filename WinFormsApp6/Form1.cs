using System.Text.Json;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            string filePath = $"{textBox2.Text}.json";
            if (!File.Exists(filePath))
            {
                MessageBox.Show("There is no file");
                return;
            }

            var readJsonStr = File.ReadAllText(filePath);
            Class? clas = JsonSerializer.Deserialize<Class>(readJsonStr) ?? null;

            if (clas == null)
            {
                MessageBox.Show("No data exists");
                return;
            }

            richTextBox1.Text = clas.Text;
            comboBox1.Text = clas.Font;
            comboBox2.Text = clas.Size;
            comboBox3.Text = clas.Color;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string filePath = $"{textBox3.Text}.json";
            if (File.Exists(filePath))
                MessageBox.Show("File already exists, enter another name");            

            var JsonStr = JsonSerializer.Serialize(new Class(richTextBox1.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text));

            File.WriteAllText(filePath, JsonStr);
            MessageBox.Show("Data successfully added");
        }

        private void btn_bold_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null) return;

            FontStyle style = richTextBox1.SelectionFont.Style;

            if (richTextBox1.SelectionFont.Bold) style &= ~FontStyle.Bold;
            else style |= FontStyle.Bold;

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void btn_underline_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null) return;

            FontStyle style = richTextBox1.SelectionFont.Style;

            if (richTextBox1.SelectionFont.Underline) style &= ~FontStyle.Underline;
            else style |= FontStyle.Underline;

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void btn_italic_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null) return;

            FontStyle style = richTextBox1.SelectionFont.Style;

            if (richTextBox1.SelectionFont.Italic) style &= ~FontStyle.Italic;
            else style |= FontStyle.Italic;

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }


        private void btn_left_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btn_center_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
                comboBox1.Items.Add(font.Name.ToString());

            comboBox2.Items.Add(8);
            comboBox2.Items.Add(9);
            comboBox2.Items.Add(10);
            comboBox2.Items.Add(11);
            comboBox2.Items.Add(12);
            comboBox2.Items.Add(14);
            comboBox2.Items.Add(16);
            comboBox2.Items.Add(18);
            comboBox2.Items.Add(20);
            comboBox2.Items.Add(22);
            comboBox2.Items.Add(24);
            comboBox2.Items.Add(26);
            comboBox2.Items.Add(28);
            comboBox2.Items.Add(36);
            comboBox2.Items.Add(48);
            comboBox2.Items.Add(72);


            foreach (var color in typeof(Color).GetProperties())
                comboBox3.Items.Add(color.Name);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 1;
            richTextBox1.SelectionFont = new Font(comboBox1.SelectedItem.ToString(), Convert.ToInt32(comboBox2.SelectedItem), FontStyle.Regular);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(comboBox1.SelectedItem.ToString(), Convert.ToInt32(comboBox2.SelectedItem), FontStyle.Regular);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color color = Color.FromName(comboBox3.Text);
            richTextBox1.SelectionColor = color;
        }
    }
}