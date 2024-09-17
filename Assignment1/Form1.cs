namespace Assignment1
{
    public partial class Form1 : Form
    {
        private const double RATE = 10.50;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void summarizeButton_Click(object sender, EventArgs e)
        {
            try
            {
                int hours;
                double total;
                String firstName = firstNameTextBox.Text;
                String lastName = lastNameTextBox.Text;
                String show;


                hours = int.Parse(hoursWorkedTextBox.Text);

                total = hours * RATE;


                show = $"{firstName} {lastName} worked {hours.ToString()} hours at ${RATE} an hour for a total of ${total}";

                displayTextLabel.Text = show;
                displayTextLabel.ForeColor = Color.Black;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                displayTextLabel.ForeColor = Color.Red;
            }
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            hoursWorkedTextBox.Clear();
            displayTextLabel.Text = "";
        }
    }
}
