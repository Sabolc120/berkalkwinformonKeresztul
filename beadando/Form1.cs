using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beadando
{
    public partial class Form1 : Form
    {
        string specialChar = @"|!#$%&/()=?»«@£§€{}.-;~`'<>_,Đ[]íłŁß¤\Ä÷×˙´´˝¨¸";
        static bool isValid = false;
        public Form1()
        {
            InitializeComponent();
            buttonWrite.Enabled = false;
            salaryNormalNumeric.Enabled = false;
        }

        private void calculateItButton_Click(object sender, EventArgs e)
        {
            checkBoxMarried.Enabled = false;
            twentyFive.Enabled = false;
            if (!nev.Equals(" ")) buttonWrite.Enabled = true;
            if (position.Text.Equals("")) MessageBox.Show("A pozició nem lehet üres, kérem töltsön be egy munkavállalói poziciót!");
            double brutto = Convert.ToInt32(salaryNormalNumeric.Value);
            Calculator szamolo = new Calculator(brutto);
            if (!twentyFive.Checked && isValid)
            {
                szamolo.Calculating();
                string username = "";
                username = nev.Text;
                nev.Text = szamolo.Nev;
                salarySZJA.Value = Convert.ToInt32(szamolo.SZJA);
                salaryTBA.Value = Convert.ToInt32(szamolo.TBA);
                salaryNetto.Value = Convert.ToInt32(szamolo.netto);
                nev.Text = username;
                if (checkBoxMarried.Checked) salaryNetto.Value += 5000;
            }
            else if(twentyFive.Checked && isValid)
            {
                salarySZJA.Enabled = false;
                szamolo.twentyFiveCalculating();
                string username = "";
                username = nev.Text;
                nev.Text = szamolo.Nev;
                salarySZJA.Value = Convert.ToInt32(szamolo.SZJA);
                salaryTBA.Value = Convert.ToInt32(szamolo.TBA);
                salaryNetto.Value = Convert.ToInt32(szamolo.netto);
                nev.Text = username;
                if (checkBoxMarried.Checked) salaryNetto.Value += 5000;
            }
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            try
            { 
                double brutto = Convert.ToInt32(salaryNormalNumeric.Value);
                Printcs iro = new Printcs(brutto);
                iro.Nev = nev.Text;
                iro.SZJA = Convert.ToInt32(salarySZJA.Value);
                iro.SZJA = Convert.ToInt32(salarySZJA.Value);
                iro.TBA = Convert.ToInt32(salaryTBA.Value);
                iro.brutto = Convert.ToInt32(salaryNormalNumeric.Value);
                iro.netto = Convert.ToInt32(salaryNetto.Value);
                iro.printIt();
                MessageBox.Show("Sikeres mentés.");
            }
            catch
            {
                MessageBox.Show("Sikertelen mentés.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DomainUpDown.DomainUpDownItemCollection collection = this.position.Items;
            collection.Add("Senior");
            collection.Add("Medior");
            collection.Add("Junior");
            collection.Add("Gyakornok");
        }
        private void positionButton_Click(object sender, EventArgs e)
        {
            bool hasSpecial = false;
            char[] stringtoChar = nev.Text.ToCharArray();
            foreach(var item in specialChar)
            {
                if (stringtoChar.Contains(item))
                {
                    MessageBox.Show("A névben nem lehetnek különleges karakterek!");
                    buttonWrite.Enabled = false;
                    hasSpecial = true;
                    break;
                }
            }
            for (int i = 0; i < stringtoChar.Length; i++)
            {
                if (stringtoChar[i].Equals('1') || stringtoChar[i].Equals('2') || stringtoChar[i].Equals('3') || stringtoChar[i].Equals('4') ||
                    stringtoChar[i].Equals('5') || stringtoChar[i].Equals('6') || stringtoChar[i].Equals('7') || stringtoChar[i].Equals('8') ||
                    stringtoChar[i].Equals('9'))
                {
                    isValid = false;
                    MessageBox.Show("A felhasználónév nem tartalmazhat számokat!");
                    buttonWrite.Enabled = false;
                    break;
                }
                else if(hasSpecial == false) isValid = true;
            }
            if (isValid == false)
            {
                calculateItButton.Enabled = false;
            }
            else calculateItButton.Enabled = true;
            salaryNormalNumeric.Enabled = true;
            if (isValid)
            {
                switch (position.Text)
                {
                    case "Gyakornok":
                        salaryNormalNumeric.Minimum = 200000;
                        salaryNormalNumeric.Value = 200000;
                        break;
                    case "Junior":
                        salaryNormalNumeric.Minimum = 400000;
                        salaryNormalNumeric.Value = 400000;
                        break;
                    case "Senior":
                        salaryNormalNumeric.Minimum = 750000;
                        salaryNormalNumeric.Value = 750000;
                        break;
                    case "Medior":
                        salaryNormalNumeric.Minimum = 450000;
                        salaryNormalNumeric.Value = 450000;
                        break;
                }
            }
        }
        private void restartButton_Click(object sender, EventArgs e)
        {
            salaryNetto.Value = 0;
            salaryNormalNumeric.Minimum = 0;
            salaryNormalNumeric.Value = 0;
            salarySZJA.Value = 0;
            salaryTBA.Value = 0;
            calculateItButton.Enabled = true;
            salaryNormalNumeric.Enabled = true;
            checkBoxMarried.Enabled = true;
            twentyFive.Enabled = true;
            nev.Text = "";
            position.Text = "";
            buttonWrite.Enabled = true;
        }
    }
}
