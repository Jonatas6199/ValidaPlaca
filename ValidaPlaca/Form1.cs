namespace ValidaPlaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (ValidaPlaca(txtPlaca.Text))
                MessageBox.Show("Placa V�lida");
            else
                MessageBox.Show("Placa Inv�lida");

            Database.SalvarPlacaDeCarro(txtPlaca.Text);
        }

        private bool ValidaPlaca(string placa)
        {
            if(string.IsNullOrEmpty(placa) || placa.Length!=8)
                return false;
            else
            {
                string inicioDaPlaca = placa.Substring(0, 3);
                string finalDaPlaca = placa.Substring(4);
                if (placa[3]!= '-' || !inicioDaPlaca.All(char.IsLetter) || !finalDaPlaca.All(char.IsDigit))
                    return false;
                else
                    return true;
            }
        }
    }
}
