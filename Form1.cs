using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //step 1:Add a button to the form
            //step 2: Add a Click event handler for the button
            //step 3: In the Click event handler, show a message box
            //step 4: Run the application and click the button to see the message box
            //step 5:use your browser control to navigate to a URL enterd in the text 


            webBrowser1.Navigate(textBox1.Text);

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
