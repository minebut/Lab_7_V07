namespace LAB_7_BUTOK
{
    public partial class Form_Point_Kinematics : Form
    {

        public Form_Point_Kinematics()
        {
            InitializeComponent();
            Velocity_textBox.Visible = false;
            Acceleration_textBox.Visible = false;
        }
        private void UpdateValue()
        {
            labelA.Text = $"A= {hScrollBarA.Value}";
            labelB.Text = $"B= {hScrollBarB.Value}";
            double a = hScrollBarA.Value;
            double b = hScrollBarB.Value;
            Lable_form1.Text = $"x = {a}*{b}cos(pi*{b}*t)";
            Lable_form2.Text = $"y = {a}*{b}sin(pi*{b}*t)";

            double Velocity = a * Math.PI * (b * b);
            Velocity_textBox.Text = $"Швидкість = {Velocity,5:F3}";

            double Acceleration = a * (Math.PI * Math.PI) * (b * b * b);
            Acceleration_textBox.Text = $" Прискорення = {Acceleration,5:F3}";

        }

        private void hScrollBarA_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateValue();
        }

        private void hScrollBarB_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateValue();
        }

        private void VelocityButoon_Click(object sender, EventArgs e)
        {
            Velocity_textBox.Visible = !Velocity_textBox.Visible;

        }

        private void Acceleration_Button_Click(object sender, EventArgs e)
        {
            Acceleration_textBox.Visible = !Acceleration_textBox.Visible;
        }

        private void Exit_Butoon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
