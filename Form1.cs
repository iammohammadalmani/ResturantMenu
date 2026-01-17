namespace OOPlabProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void drinks_Click(object sender, EventArgs e)
        {
            Drinks drinks = new Drinks();
            drinks.Show();

        }

        private void Appetizers_Click(object sender, EventArgs e)
        {
            Appetizers appetizersForm = new Appetizers();
            appetizersForm.Show();
        }

        private void mainCourses_Click(object sender, EventArgs e)
        {
            Main_Course mainCourse = new Main_Course();
            mainCourse.Show();
        }

        private void desserts_Click(object sender, EventArgs e)
        {
            Desserts desserts = new Desserts();
            desserts.Show();
        }
    }
}
