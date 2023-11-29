using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Net.Http.Headers;

namespace trivia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Delia Dabelea\\Documents\\LoginData.mdf\";Integrated Security=True;Connect Timeout=30");

        private void Login_Click(object sender, EventArgs e)
        {
            string password, username;
            username = txtbx_user.Text;
            password = txtbx_password.Text;
            try
            {
                string querry = "SELECT * FROM [dbo].[Table] WHERE CONVERT(VARCHAR, Username) ='" + username + "' AND CONVERT(VARCHAR, PassWord) = '" + password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, connection);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = txtbx_user.Text;
                    password = txtbx_password.Text;
                    label1.Visible = false;
                    txtbx_password.Visible = false;
                    txtbx_user.Visible = false;
                    Login.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    button1.Visible = true;
                    button2.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex.Message);
                MessageBox.Show("Invalid Credentials");


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game game1 = new Game();
            this.Hide();
            game1.ShowDialog();
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbx_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}