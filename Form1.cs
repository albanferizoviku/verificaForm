using MySql.Data.MySqlClient;

namespace Verifica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttoninserisci_Click(object sender, EventArgs e)
        {
            String connectionString = "server=localhost;database=windows_form;uid=windows_form;pwd=windows_form";
            MySqlConnection cnn;
            cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd;
        }

        private void buttonmodifica_Click(object sender, EventArgs e)
        {
            Form1 formInsert = new Form1();
            formInsert.ShowDialog();
        }

        private void buttonelimina_Click(object sender, EventArgs e)
        {
            Form1 form1formInsert = new Form1();
            form1formInsert.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Form1 form1Insert = new Form1();
            form1Insert.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Form1 form1Insert = new Form1();
            form1Insert.ShowDialog();
        }

    }
}
