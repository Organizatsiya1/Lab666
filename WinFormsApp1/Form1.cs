using Model;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRunDemo_Click(object sender, EventArgs e)
        {
            string result = "";

            var employee = new Scientist
            {
                Name = "Иванов И.А.",
                BaseSalary = 100000
            };

            result += "ПАТТЕРН СТРАТЕГИЯ \r\n\r\n";

            employee.BankService = new Sberbank();
            result += $"Сбербанк (1%): {employee.CalculateSalary():F2} руб.\r\n";

            employee.BankService = new GZBank();
            result += $"Газпромбанк (1.5%): {employee.CalculateSalary():F2} руб.\r\n\r\n";

            result += "ПАТТЕРН ДЕКОРАТОР \r\n\r\n";

            result += "Без характеристик: " + employee.GetInfo() + "\r\n\r\n";

            var withEnglish = new IntermediateEnglishSertificate(employee)
            {
                ExaminationTitle = "TOEFL",
                YearOfSertificate = 2023
            };
            result += "С английским: " + withEnglish.GetInfo() + "\r\n\r\n";

            var withDegree = new AcademicDegree(withEnglish)
            {
                DissertationTitle = "ИИ",
                Year = 2026,
                ScienceArea = "Информатика"
            };
            result += "С английским и степенью: " + withDegree.GetInfo() + "\r\n\r\n";

            result += "ВЫПОЛНЕНО";

            txtResult.Text = result;
        }
    }
}
