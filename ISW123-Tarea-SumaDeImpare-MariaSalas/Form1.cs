namespace ISW123_Tarea_SumaDeImpare_MariaSalas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            lstSalida.Items.Clear();
            int hasta = (int)nudHasta.Value;  // 3
            int s = 0;

            for (int i = 1; i <= hasta; i++)
            {
                if (i % 2 == 1)  // ¿i es impar?
                {
                    s += i;
                    lstSalida.Items.Add($"i = {i} -> impar -> s = {s}");
                }
                else
                {
                    lstSalida.Items.Add($"i = {i} -> par, no suma -> s = {s}");
                }
            }

            lstSalida.Items.Add($"Resultado: {s}");
        }
    }
}
