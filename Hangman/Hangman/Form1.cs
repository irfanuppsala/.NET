using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        int guessNumber = 1; //Ökar med 1 för varje felgissing så att nästa bild visas.
        char guess; //char innehåller ETT tecken och här lagras den bokstav som du gissar på.
        string rightAnswer = null; //Här lagras rätt ord. Här försvinner bokstäver när du gissar rätt.
        string rightAnswer2 = null; //Här lagras också rätt ord men denna här försvinner inte bokstäver. Denna
                                    //variabel används när vi gissar på hela ordet
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGissa_Click(object sender, EventArgs e)
        {
            guess = char.Parse(txtGuess.Text.ToLower()); //Här gör man sin gissning med en bokstav.
            txtGuess.Clear();

            //För varje gissning som är fel så blir man mer hängd.
            //guessNumber ökar med ett för varje felgissning så att rätt bild laddas.

            if (!rightAnswer.Contains(guess) && guessNumber == 1)
                pictureBox1.Load("fel1.gif");
            if (!rightAnswer.Contains(guess) && guessNumber == 2)
                pictureBox1.Load("fel2.gif");
            if (!rightAnswer.Contains(guess) && guessNumber == 3)
                pictureBox1.Load("fel3.gif");
            if (!rightAnswer.Contains(guess) && guessNumber == 4)
                pictureBox1.Load("fel4.gif");

            if (!rightAnswer.Contains(guess) && guessNumber == 5) //Efter 5 gissningar så är man hängd
            {
                pictureBox1.Load("fel5.gif");
                btnGissa.Enabled = false;
                lblSlutResultat.Text = "Sorry, du är hängd! Rätt svar var " + rightAnswer2;
            }

            if (!rightAnswer.Contains(guess)) //Om gissningen INTE är rätt ökas guessNumber för nästa bild.
                guessNumber++;

            else if (rightAnswer.Contains(guess)) //Om gissningen ÄR rätt så minskas bokstäver att gissa p
            {
                //Om ordet innehåller mer än en bokstav av samma sort, ser denna till att alla visas.
                while (rightAnswer.IndexOf(guess) != -1)
                {
                    lblShowLetters.Text += guess.ToString();
                    int index = rightAnswer.IndexOf(guess); //Tar reda på indexet för bokstaven du gissade på
                    if (index != -1) //Om det inte är tomt på bokstäver
                    {
                        if (rightAnswer.Length == 1)
                            btnGissa.Enabled = false;
                        rightAnswer = rightAnswer.Remove(index, 1); //"Index" är numret för bokstaven, "1" är hur
                    } //många bokstäver som ska tas bort
                    else
                        btnGissa.Enabled = false;
                }//End of while
            }
        }

        private void btnNyttOrd_Click(object sender, EventArgs e)
        {
            //Det rätta svaret lägg i en variabel för att minska för varje rätt bokstav.
            rightAnswer = txtTheWord.Text.ToLower();
            //Rätt svar läggs även i en variabel som INTE minskar. Denna variabel visas om man gissar rätt ord.
            rightAnswer2 = txtTheWord.Text;
            txtTheWord.Clear();

            int wordLength = rightAnswer2.Length; //Räknar anta lord i sträng
            for (int i = 1; i <= wordLength; i++) // Går igenom varje
            {
                label1.Text += "_ "; // För varje bokstav i ordet ritas ett streck.
            }

        }

        private void btnGissaHelaOrdet_Click(object sender, EventArgs e)
        {
            if (txtGuessTheWord.Text.Equals(rightAnswer2))
                lblSlutResultat.Text = "Du gissade rätt ord: " + rightAnswer2;
            else
            {
                pictureBox1.Load("fel5.gif");
                btnGissa.Enabled = false;
                lblSlutResultat.Text = "Sorry, du är hängd! Rätt svar var " + rightAnswer2;
            }
        }

        string returnWordSwedish()
        {
            Random rnd1 = new Random();
            string[] allLines = File.ReadAllLines("C:\\Bibliotek\\Swedish.txt");
            string rightWord = allLines[rnd1.Next(allLines.Length)];
            return rightWord;
        }
    }
}
 

