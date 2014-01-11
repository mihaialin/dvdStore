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

namespace dvdStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static dvd[] dvdList = new dvd[5];
        public static int listIndex = 0;
        public static int maxIndex = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
                      
        }

        public class dvd { 
            private String dvdTitle;
            private int releaseYear;
            private String publisher;
            private double viewerRating;
            private String[] languages = new String[3];

            public String getDvdTitle() {
                return dvdTitle;
            }
            public int getReleaseYear() {
                return releaseYear;
            }
            public String getPublisher() {
                return publisher;
            }
            public double getViewerRating() {
                return viewerRating;
            }
            public String[] getLanguages() {
                return languages;
            }
            public string getLanguageAtIndex(int index) {
                return languages[index];
            }
            public string getSerializedLanguages() {
                return languages[0] + "," + languages[1]; 
            }
            public void setLanguageAtIndex(int index, string lang) {
                languages[index] = lang;
            }
            public void setDvdTitle(String title) {
                dvdTitle = title;
            }
            public void setReleaseYear(int year) {
                releaseYear = year;
            }
            public void setPublisher(String pub) {
                publisher = pub;
            }
            public void setViewerRating(double vr) {
                viewerRating = vr;
            }
            public void setLanguages(String[] lang){
                languages = lang;
            }

        }

        private void load_button_Click(object sender, EventArgs e)
        {
            
            
            string outPath = @"C:\Facultate\dvdStore.txt";
            FileStream inputFile = new FileStream(outPath, FileMode.Open, FileAccess.Read);
            StreamReader inStream = new StreamReader(inputFile);

            string line;
            int counter = 0;
            while ((line = inStream.ReadLine()) != null)
            {
                dvdList[counter] = new dvd();
                string[] dvdData = line.Split(';');
                dvdList[counter].setDvdTitle(dvdData[0]);
                dvdList[counter].setReleaseYear(Convert.ToInt32(dvdData[1]));
                dvdList[counter].setPublisher(dvdData[2]);
                dvdList[counter].setViewerRating(Convert.ToDouble(dvdData[3]));
                String[] langs = dvdData[4].Split(',');
                dvdList[counter].setLanguages(langs);
                maxIndex = counter;
                counter++;
                
            }
            displayValues();
            inStream.Close();
            inputFile.Close();
        }

        public void displayValues() {
            languageList.Items.Clear();
            dvdTitleBox.Text = dvdList[listIndex].getDvdTitle();
            releaseYear.Text = (dvdList[listIndex].getReleaseYear()).ToString();
            publisher.Text = dvdList[listIndex].getPublisher();
            viewerRating.Text = (dvdList[listIndex].getViewerRating()).ToString();
            foreach(string item in dvdList[listIndex].getLanguages()){
                languageList.Items.Add(item);
            }

        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (listIndex > 0) {
                listIndex--;
            }
            
            displayValues();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (listIndex < maxIndex)
            {
                listIndex++;
            }
            
            displayValues();
        }

        private void languageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int newLangIndex = Convert.ToInt32(languageList.GetItemText(languageList.SelectedIndex));
            newLanguage.Text = dvdList[listIndex].getLanguageAtIndex(newLangIndex);
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
         
            int newLangIndex = Convert.ToInt32(languageList.GetItemText(languageList.SelectedIndex));
            if (newLangIndex >= 0) {
                dvdList[listIndex].setLanguageAtIndex(newLangIndex, newLanguage.Text);
                dvdList[listIndex].setDvdTitle(dvdTitleBox.Text);
            }
          
            if (((Convert.ToInt32(releaseYear.Text) < 1912) || (Convert.ToInt32(releaseYear.Text) > 2014)))
            {
                System.Windows.Forms.MessageBox.Show("Invalid year");
            }
            else {
                dvdList[listIndex].setReleaseYear(Convert.ToInt32(releaseYear.Text));
            }
            
            dvdList[listIndex].setPublisher(publisher.Text);
            dvdList[listIndex].setViewerRating(Convert.ToDouble(viewerRating.Text));

            displayValues();
        }

        public void saveDVDList() {
            string outPath = @"C:\Facultate\dvdStore.txt";
            FileStream inputFile = new FileStream(outPath, FileMode.Open, FileAccess.Write);
            StreamWriter inStream = new StreamWriter(inputFile);
            inputFile.Flush();
            int i=0;
            while (i < maxIndex) {
                inStream.WriteLine(dvdList[i].getDvdTitle() + ";" + (dvdList[i].getReleaseYear()).ToString() + ";" + dvdList[i].getPublisher() + ";" + (dvdList[i].getViewerRating()).ToString() + ";" + dvdList[i].getSerializedLanguages());
                i++;
            }
            inStream.Close();
            inputFile.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveDVDList();
        }
    }
}
