using Calc;

namespace Session_11
{
    public partial class MainForm : Form
        //test 
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void Menu_PetClick(object sender, EventArgs e)
        {
            PetForm petForm = new PetForm();
            petForm.ShowDialog();
        }
    }
}