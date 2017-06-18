using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Versleutelen
{
    /*
    Opdracht 3: Versleutelen
    Maak een programma dat 
    1) Het versleutelen van teksten mogelijk maakt 
    2) dat als txt document bewaard kan worden. 
    3) lever ook een decryptie programma in.    
    Slim algoritmiseren is hier het belangrijkst.

    Oplossing: elke input wordt vervangen door een nieuw karakter (bijv. "abc" wordt vervangen door "def") 
    er wordt gebruik gemaakt van meerdere random gesorteerde alfabetten. 
    vervolgens wordt bijv. de letter a in random geselecteerde alfabet 3 opgezocht     
    vervolgens wordt adhv een random gegenereerd getal een nieuw character geselecteerd, x aantal plaatsen van de oorspronkelijke positie
    bijv. : 
        1) input van gebruiker is "a"
        2) random gekozen alfabet is 3
        3) positie (in lijst) van "a" in alfabet is 20
        4) random gegenereerd getal is: 5
        5) karakter op plaats (20 + 5) = 25 is "G"
        6) "a" wordt vervangen door "G"
    Om het decrypten voor iemand die de sleutels heeft te bemoeilijken worden er twee alfabetten gebruikt; 
        > de input op "even" posities wordt vervangen door karakters uit random alfabet 1
        > de input op "oneven" posities wordt vervangen door karakters uit random alfabet 2 
        > (overigens kunnen dit door kans dezelfde alfabetten zijn, hoewel de kans dat dit niet zo is, veel groter is)
        > hierdoor kan het voorkomen dat een gebruikersinput van "ab" wordt vervangen door "kk". Op die manier wordt het ontsleutelen veel moeilijker
    */

    public partial class versleutelForm : Form
    {
        public versleutelForm()
        {
            InitializeComponent();
        }

        string inputFileExport, inputFileExportText; // creeeren een txt bestand 
        string outputFileExport, outputFileExportText; // creeeren een txt bestand 
        string originalInput, decryptedInput; // input van de gebruiker
        int extra = 62, randomAdd, randomList, randomListTwo, randomAddKey, listOneKey, listTwoKey, masterKey;
        Random randomNumber = new Random();

        List<string> alfabet = new List<string>(); // er zijn een aantal bestanden met willekeurig gesorteerde alfabetten. er worden random 2 alfabetten gekozen voor de decryptie
        List<string> alfabetTwo = new List<string>();       

        private void versleutelForm_Load(object sender, EventArgs e)
        {
            textBoxOutput.Visible = false;
            textBoxExportOutput.Visible = false;
            textBoxPointers.Visible = false;
            btnExportOutput.Visible = false;
            textBoxMasterKey.Visible = false;
            textBoxKeyOneGen.Visible = false;
            textBoxLoadMasterKey.Visible = false;
            textBoxLoadKeyGen.Visible = false;
            textBoxKeyTwoGen.Visible = false;
            textBoxLoadKeyTwoGen.Visible = false;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            randomAdd = randomNumber.Next(3, 62); // verandering van de positie in de lijst           
            randomList = randomNumber.Next(1, 15); // selectie van alfabet 1
            randomListTwo = randomNumber.Next(1, 15); // selectie van alfabet 2
            textBoxError.Text = "";

            textBoxMasterKey.Visible = true;
            textBoxKeyOneGen.Visible = true;
            textBoxLoadMasterKey.Visible = true;
            textBoxLoadKeyGen.Visible = true;
            textBoxKeyTwoGen.Visible = true;
            textBoxLoadKeyTwoGen.Visible = true;

            textBoxKeyOneGen.Text = Convert.ToString(123 * (randomList * randomList)); // key 1
            textBoxKeyTwoGen.Text = Convert.ToString(3 * (randomListTwo * randomListTwo)); // key 2
            
            randomAddKey = (randomAdd * randomAdd) * (randomList * randomList) - randomList; // masterkey
            textBoxMasterKey.Text = Convert.ToString(randomAddKey);

            originalInput = textBoxInput.Text;

            try
            {
                alfabet = File.ReadAllLines(@"alf" + randomList + ".txt").ToList();
            }
            catch
            {
                goto End;
            }

            try
            {
                alfabetTwo = File.ReadAllLines(@"alf" + randomListTwo + ".txt").ToList();
            }            
            catch
            {
                goto End;
            }

            if (originalInput == "" || originalInput == null)
            {
                goto EndTwo;
            }

            decryptedInput = originalInput;

            StringBuilder strBuilder = new StringBuilder(decryptedInput);

            try
            {
                for (int i = 0; i < decryptedInput.Length; i = i + 2)
                {
                    var character = decryptedInput.ElementAt(i);
                    strBuilder[i] = Convert.ToChar(alfabet.ElementAt(alfabet.IndexOf(Convert.ToString(character)) + (extra) + randomAdd));
                }
                string strBuilderTemp = strBuilder.ToString();

                StringBuilder strBuilderTwo = new StringBuilder(strBuilderTemp);

                for (int i = 1; i < strBuilderTemp.Length; i = i + 2)
                {
                    var character = strBuilderTemp.ElementAt(i);
                    strBuilderTwo[i] = Convert.ToChar(alfabetTwo.ElementAt(alfabetTwo.IndexOf(Convert.ToString(character)) + (extra) + randomAdd));
                }

                textBoxOutput.Visible = true;
                textBoxInput.Text = strBuilderTwo.ToString();
            }
            catch
            {
                goto End;
            }

            End: textBoxError.Text = "Bibliotheek met alfabet is niet gevonden/ niet compleet";
            EndTwo: textBoxError.Text = "Niets om te versleutelen";
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            textBoxOutput.Visible = true;
            textBoxExportOutput.Visible = true;
            textBoxPointers.Visible = true;
            btnExportOutput.Visible = true;
            textBoxError.Text = "";

            originalInput = textBoxInput.Text;

            try
            {
                if (textBoxKeyOneInput.Text == "" || textBoxKeyOneInput.Text == null || textBoxInput.Text == "")
                {
                    goto End;
                }

                double testInput;
                bool inputCorrect = double.TryParse(textBoxKeyOneInput.Text, out testInput);
                if (inputCorrect != true)
                {
                    goto End;
                }
                else
                {
                    double listOneKeyTempOne = (Convert.ToDouble(textBoxKeyOneInput.Text) / 123);
                    double listOneKeyTemp = Math.Sqrt(listOneKeyTempOne);
                    listOneKey = Convert.ToInt32(listOneKeyTemp);
                }
            }
            catch
            {
                goto End;
            }

            try
            {
                if (textBoxKeyTwoInput.Text == "" || textBoxKeyTwoInput.Text == null)
                {
                    goto End;
                }

                double testInput;
                bool inputCorrect = double.TryParse(textBoxKeyTwoInput.Text, out testInput);

                if (inputCorrect != true)
                {
                    goto End;
                }
                else
                {
                    double listTwoKeyTempOne = (Convert.ToDouble(textBoxKeyTwoInput.Text) / 3);
                    double listTwoKeyTemp = Math.Sqrt(listTwoKeyTempOne);
                    listTwoKey = Convert.ToInt32(listTwoKeyTemp);
                }
            }
            catch
            {
                goto End;
            }

            try
            {
                if (textBoxMasterKeyInput.Text == "" || textBoxMasterKeyInput.Text == null)
                {
                    goto End;
                }

                double testInput;
                bool inputCorrect = double.TryParse(textBoxMasterKeyInput.Text, out testInput);

                if (inputCorrect != true)
                {
                    goto End;
                }
                else
                {
                    double masterKeyTempOne = Convert.ToDouble(textBoxMasterKeyInput.Text);
                    double masterKeyTempTwo = (masterKeyTempOne + listOneKey) / listOneKey / listOneKey;
                    double masterkeyTempThree = Math.Sqrt(masterKeyTempTwo);
                    masterKey = Convert.ToInt32(masterkeyTempThree) - 2;
                }
            }
            catch
            {
                goto End;
            }

            try
            {
                alfabet = File.ReadAllLines(@"alf" + listOneKey + ".txt").ToList();
            }
            catch
            {
                textBoxError.Text = "Bibliotheek met alfabet is niet gevonden/ niet compleet";
            }
            
            try
            {
                alfabetTwo = File.ReadAllLines(@"alf" + listTwoKey + ".txt").ToList();
            }
            catch
            {
                textBoxError.Text = "Bibliotheek met alfabet is niet gevonden/ niet compleet";
            }

            StringBuilder strBuilder = new StringBuilder(originalInput);

            try
            {
                for (int i = 0; i < originalInput.Length; i = i + 2)
                {
                    var character = originalInput.ElementAt(i);
                    strBuilder[i] = Convert.ToChar(alfabet.ElementAt(alfabet.IndexOf(Convert.ToString(character)) + (extra) - masterKey));
                }

                string strBuilderTemp = strBuilder.ToString();

                StringBuilder strBuilderTwo = new StringBuilder(strBuilderTemp);

                for (int i = 1; i < strBuilderTemp.Length; i = i + 2)
                {
                    var character = strBuilderTemp.ElementAt(i);
                    strBuilderTwo[i] = Convert.ToChar(alfabetTwo.ElementAt(alfabetTwo.IndexOf(Convert.ToString(character)) + (extra) - masterKey));
                }

                textBoxOutput.Visible = true;
                textBoxOutput.Text = strBuilderTwo.ToString();
            }
            catch
            {
                textBoxError.Text = "Bibliotheek met alfabet is niet gevonden/ niet compleet";
            }
            
            End: textBoxError.Text = "Foutieve input";            
        }

        private void btnExportInput_Click(object sender, EventArgs e)
        {
            try
            {
                inputFileExport = @"ExportVanInput.txt";
                inputFileExportText = textBoxInput.Text;

                File.WriteAllText(inputFileExport, inputFileExportText);
            }
            catch
            {
                textBoxError.Text = "Het exporteren naar ExportVanInput.txt is mislukt";
            }
        }

        private void btnExportOutput_Click(object sender, EventArgs e)
        {
            try
            {
                outputFileExport = @"ExportVanOutput.txt";
                outputFileExportText = textBoxOutput.Text;

                File.WriteAllText(outputFileExport, outputFileExportText);
            }
            catch
            {
                textBoxError.Text = "Het exporteren naar ExportVanOutput.txt is mislukt";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "";
            textBoxOutput.Text = "";
            textBoxMasterKey.Text = "";
            textBoxMasterKeyInput.Text = "";
            textBoxKeyOneGen.Text = "";
            textBoxKeyOneInput.Text = "";
            textBoxKeyTwoGen.Text = "";
            textBoxKeyTwoInput.Text = "";
            textBoxError.Text = "";

            textBoxOutput.Visible = false;
            textBoxExportOutput.Visible = false;
            textBoxPointers.Visible = false;
            btnExportOutput.Visible = false;
            textBoxMasterKey.Visible = false;
            textBoxKeyOneGen.Visible = false;
            textBoxLoadMasterKey.Visible = false;
            textBoxLoadKeyGen.Visible = false;
            textBoxKeyTwoGen.Visible = false;
            textBoxLoadKeyTwoGen.Visible = false;
        }

        private void textBoxError_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxExportOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPointers_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}