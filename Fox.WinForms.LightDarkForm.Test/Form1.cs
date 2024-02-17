namespace Fox.WinForms.LightDarkForm.Test
{
    public partial class Form1 : LightDarkForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            new Form2().Show();

            await Task.Delay(1000);
            new Form3().Show();
        }
    }
}
