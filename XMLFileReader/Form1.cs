using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace XMLFileReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this is a test code.
        }


        //Event to sort the Xml file.
        private void ReadBt_Click(object sender, EventArgs e)
        {

            //Select an Xml file to the program.--------------------------------------------------------------------------                                                
            openFileDialog1.ShowDialog();                                                                               //
                                                                                                                        //
            DialogueInterface.Instance.Preload(openFileDialog1.FileName);                                               //
            //------------------------------------------------------------------------------------------------------------


            //To initiate the sorting for Xml tags------------------------------------------------------------------------
                                                                                                                        //
            SortedList<int, string> dialogueOrder = DialogueInterface.Instance.GetDialogue(SceneTB.Text);               //
                                                                                                                        //
            //------------------------------------------------------------------------------------------------------------


            //Find the Key and the Value from the reader------------------------------------------------------------------
            foreach (KeyValuePair<int,string> kvp in dialogueOrder)                                                     //
            {                                                                                                           //
                textBox1.Text += "key: " + kvp.Key + " ";                                                               //
                textBox1.Text += "value: " + kvp.Value + Environment.NewLine;                                           //
            }                                                                                                           //
        }   //------------------------------------------------------------------------------------------------------------


        //This event does the same but just for getting description node.
        private void DescBT_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            DialogueInterface.Instance.Preload(openFileDialog1.FileName);

            string desc = DialogueInterface.Instance.GetDescription(SceneTB.Text);

            textBox1.Text = desc;
        }
    }
}
