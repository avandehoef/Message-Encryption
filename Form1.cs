using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Ionic.Zip;

namespace Versleutelen
{

    /*
    Opdracht 3: Versleutelen
    Maak een programma dat 
    1) Het versleutelen van teksten mogelijk maakt 
    2) dat als txt document bewaard kan worden. 
    3) lever ook een decryptie programma in.
    
    Slim algoritmiseren is hier het belangrijkst.
    */

    public partial class versleutelForm : Form
    {
        public versleutelForm()
        {
            InitializeComponent();
        }

        string originalInputFile;
        string inputFileExport;
        string inputFileExportText;
        string outputFileExport;
        string outputFileExportText;
        string decryptedInputFile;
        string originalInput;
        string decryptedInput;
        StreamReader reader = null;
        ZipFile zip = new ZipFile();
        Random randomNumber = new Random();
        Random randomNumberTwo = new Random();
        int randomOne;
        int randomTwo;
        string unpackDirectory = Directory.GetCurrentDirectory();
        
        private void versleutelForm_Load(object sender, EventArgs e)
        {
            textBoxOutput.Visible = false;
            textBoxExportOutput.Visible = false;
            textBoxPointers.Visible = false;
            btnExportOutput.Visible = false;
            textBoxMasterKey.Visible = false;
            textBoxKeyGen.Visible = false;
            textBoxLoadMasterKey.Visible = false;
            textBoxLoadKeyGen.Visible = false;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            randomOne = randomNumber.Next(1, 52);
            randomTwo = randomNumberTwo.Next(13, 1998);

            textBoxMasterKey.Visible = true;
            textBoxKeyGen.Visible = true;
            textBoxLoadMasterKey.Visible = true;
            textBoxLoadKeyGen.Visible = true;

            textBoxMasterKey.Text = Convert.ToInt16(Math.Sqrt(randomTwo)) + "fvPcw55d" + randomTwo + 9;
            textBoxKeyGen.Text = Convert.ToString(randomOne);
            
            originalInputFile = @"original.txt";
            decryptedInputFile = @"decryptedInput.txt";

            originalInput = textBoxInput.Text;

            File.WriteAllText(originalInputFile, originalInput);

            using (var zip = new ZipFile())
            {
                zip.Password = Convert.ToInt16(Math.Sqrt(randomTwo)) + "fvPcw55d" + randomTwo + 9;
                zip.AddFile(originalInputFile);
                zip.Save(@"coded.zip");
            }
            File.Delete(originalInputFile);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            textBoxOutput.Visible = true;
            textBoxExportOutput.Visible = true;
            textBoxPointers.Visible = true;
            btnExportOutput.Visible = true;
            string codedZIp = @"coded.zip";            

            using (zip = ZipFile.Read(codedZIp))
            {
                zip.Password = textBoxMasterKeyInput.Text;
                zip.ExtractAll(unpackDirectory, ExtractExistingFileAction.OverwriteSilently);                
            }
            textBoxOutput.Text = File.ReadAllText(originalInputFile);
            textBoxInput.Text = "";
            File.Delete(originalInputFile);
        }

        private void btnExportInput_Click(object sender, EventArgs e)
        {
            inputFileExport = @"ExportVanInput.txt";
            inputFileExportText = textBoxInput.Text;

            File.WriteAllText(inputFileExport, inputFileExportText);
        }

        private void btnExportOutput_Click(object sender, EventArgs e)
        {
            outputFileExport = @"ExportVanOutput.txt";
            outputFileExportText = textBoxOutput.Text;

            File.WriteAllText(outputFileExport, outputFileExportText);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "";
            textBoxOutput.Text = "";
            textBoxMasterKey.Text = "";
            textBoxMasterKeyInput.Text = "";
            textBoxKeyGen.Text = "";
            textBoxKeyInput.Text = "";

            textBoxOutput.Visible = false;
            textBoxExportOutput.Visible = false;
            textBoxPointers.Visible = false;
            btnExportOutput.Visible = false;
            textBoxMasterKey.Visible = false;
            textBoxKeyGen.Visible = false;
            textBoxLoadMasterKey.Visible = false;
            textBoxLoadKeyGen.Visible = false;
        }
    }
}


//try
//{
//    using (reader = new StreamReader(bestand))
//        while (!reader.EndOfStream)
//        {
//            var line = reader.ReadLine();
//            Console.WriteLine(line);
//        }
//}
//catch (Exception fout)
//{
//    Console.WriteLine(fout.Message);
//    Console.ReadKey();
//}

