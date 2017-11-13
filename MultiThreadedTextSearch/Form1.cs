using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Author: Nidhi Vaishnav
 * Course: Human Computer Interaction : CS 6326 Fall 2017
 * netid: 170030
 * */

//main form
namespace MultiThreadedTextSearch
{
    public partial class myForm : Form
    {
        //initializing variable
        int myIndex = 0;
        string[] prevRow = new string[3];
        string[] searchMsgStr = {"searching.", "searching..", "searching...", "searching...." };
        
        //myForm
        public myForm()
        {
            InitializeComponent();
        }
        
        //initializing form
        private void initializeForm()
        {
            //initializing variables
            filePath.Text = "";
            filePath.Focus();
            this.textFound.Visible = false;
            this.lineCounted.Visible = false;
            this.textFoundLbl.Visible = false;
            this.lineCounted.Visible = false;
            this.uniqueLineText.Visible = false;
            this.uniqueLineTextLbl.Visible = false;
            displayLv.Items.Clear();
            searchCancelBtn.Text = "Search";
        }


        //on the click of browse button, you should able to browse the file,
        //and add file to filePath text box
        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "C# Corner Open File Dialog";
            fileDialog.InitialDirectory = @"c:\";
            fileDialog.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = fileDialog.FileName;
                showMessage("file has been browsed");
            }
        }

        /// Method displays the given message in the status bar. 
        /// It also resets the text color to Black indicating a normal message is being displayed.
        private void showMessage(String message)
        {
            toolStripStatusLbl.Text = message;
            toolStripStatusLbl.ForeColor = Color.Black;
        }

        /// Method displays the given error in the status bar. 
        /// It also resets the text color to red indicating a normal message is being displayed.
        private void showError(String error)
        {
            toolStripStatusLbl.Text = error;
            toolStripStatusLbl.ForeColor = Color.Red;
        }


        //this event handler thread is called when the background thread is finishes
        //This method runs on the main thread
        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //print error message
            if (e.Error != null)
            {
                showError("Error " + e.Error.Message);
            }
            //print cancel message
            else if (e.Cancelled)
            {
                showMessage("Text search is canceled");
            }
            //declare completion
            else
            {
                showMessage("Text search is completed :)");
                searchCancelBtn.Text = "Search";
            }
        }

        //This event handler runs on the main thread
        //it gets the detail from other thread when progressReport() is called from child thread
        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Words.CurrentState state = (Words.CurrentState)e.UserState;
            
            //adding items in the listview with line data and word count
            //if no words are found, do nothing in listview
            if (state.wordsMatched!=0){
                //get data in row for list view
                string[] row = { myIndex.ToString(), state.lineNo.ToString(), state.lineData.ToString() };
                //match current line with previous line, if they are not same than only add line
                //in the list vew
                if (!row.SequenceEqual(prevRow))
                {
                    myIndex += 1;
                    row[0] = myIndex.ToString();
                    var listViewItem = new ListViewItem(row);
                    try
                    {
                        displayLv.Items.Add(listViewItem);
                    }
                    catch (Exception exception)
                    {
                        Console.Out.Write(exception.StackTrace);
                    }

                    if (displayLv.Items.Count > 0)
                    {
                        //Ensure that the newly added record at the end is always visible.
                        displayLv.EnsureVisible(displayLv.Items.Count - 1);
                    }
                    //update prevRow with current row
                    prevRow = new string[] { myIndex.ToString(), state.lineNo.ToString(), state.lineData.ToString() }; ;
                }

            }
            //displaying searching message
            int searchIndex = myIndex % 4;
            showMessage(searchMsgStr[searchIndex]);

            //updating labels
            this.lineCounted.Text = state.linesCounted.ToString();
            this.textFound.Text = state.wordsMatched.ToString();
            this.uniqueLineText.Text = myIndex.ToString();
            
        }

        //This event handler is where actual work is done
        //This method works on the background thread
        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //get the background worker object that raise the event
            System.ComponentModel.BackgroundWorker worker;
            worker = (System.ComponentModel.BackgroundWorker)sender;

            //Get the words objects and call the main method
            Words WC = (Words)e.Argument;
            WC.CountWords(worker, e);

        }

        //This method runs on the main thread
        private void StartThread()
        {
            //making data visible once thread has started
            this.textFoundLbl.Visible = true;
            this.lineCountedLbl.Visible = true;
            this.uniqueLineTextLbl.Visible = true;

            this.textFound.Visible = true;
            this.textFound.Text = "0";
            this.lineCounted.Visible = true;
            this.lineCounted.Text = "0";
            this.uniqueLineText.Visible = true;
            this.uniqueLineText.Text = "0";
          
            myIndex = 0;
          
            //cleaning list view items
            displayLv.Items.Clear();

            //show searching Message
            int searchIndex = myIndex % 4;
            showMessage(searchMsgStr[searchIndex]);
            //Initialize the object that the background worker calls
            Words WC = new Words();
            WC.CompareString = this.searchText.Text;
            WC.SourceFile = this.filePath.Text;

            //start the asynchronous operation
            bgWorker.RunWorkerAsync(WC);
        }

        private void searchCancelBtn_Click(object sender, EventArgs e)
        {

            //showMessage(searchCancelBtn.Text);
            if (searchCancelBtn.Text == "Search"){
                
                if (string.IsNullOrEmpty(filePath.Text) )
                {
                    showError("Please provide the file Path");
                }
                else if (string.IsNullOrEmpty(searchText.Text))
                {
                    showError("Please provide the text that should be searched");
                }
                else
                {
                    //change text of button to Cancel
                    searchCancelBtn.Text = "Cancel";

                    //start thread
                    StartThread();
                }
            }
            else
            {
                //change text of button to Search
                searchCancelBtn.Text = "Search";
                //cancel the asynchronous operation
                this.bgWorker.CancelAsync();
            }
        }
    }
}
