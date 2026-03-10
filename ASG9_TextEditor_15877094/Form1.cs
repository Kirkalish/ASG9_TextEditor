using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASG9_TextEditor_15877094
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addTextButton_Click(object sender, EventArgs e)
        {
            pushToUndoStack();

            String[] arrayString = getStringArrayFromData();

            String prefix = beginTextBox.Text + "";
            String postfix = endTextBox.Text + "";


            String tempString = "";

            // Loop through the string array
            foreach (String line in arrayString)
            {
                tempString = tempString + prefix + line + postfix + Environment.NewLine;
            }

            // remove the last CRLF
            tempString = tempString.Substring(0, tempString.Length - 2);

            dataTextBox.Text = tempString;
        }

        private String[] getStringArrayFromData()
        {
            String[] arrayString;
            String temp = dataTextBox.Text;
            temp = temp.Replace("\r\n", "\n");
            arrayString = temp.Split('\n');

            return arrayString;
        }

        private void ascendingButton_Click(object sender, EventArgs e)
        {
            pushToUndoStack();

            // Load into list, search the list, put it back into the textbox
            String orig = dataTextBox.Text;

            String[] arrayString = getStringArrayFromData();

            Array.Sort(arrayString, StringComparer.InvariantCulture);

            // Remove the Duplicates
            if (dupesCheckBox.Checked)
                arrayString = arrayString.Distinct().ToArray();

            // load the array back into the textbox

            String tempString = "";
            int counter = 0;
            foreach (String line in arrayString)
            {
                //tempString = tempString + line + "!";
                counter++;
                tempString = tempString + line + Environment.NewLine;
            }

            // remove the last Newline 
            tempString = tempString.Substring(0, tempString.Length - 2);

            dataTextBox.Text = tempString;

        }

        private void descendingButton_Click(object sender, EventArgs e)
        {
            pushToUndoStack();

            // Load into list, search the list, put it back into the textbox

            String[] arrayString = getStringArrayFromData();

            Array.Sort(arrayString, StringComparer.InvariantCulture);
            Array.Reverse(arrayString);

            // Remove the Duplicates
            if (dupesCheckBox.Checked)
                arrayString = arrayString.Distinct().ToArray();


            // load the array back into the textbox

            String tempString = "";

            foreach (String line in arrayString)
            {
                tempString += line + Environment.NewLine;
            }

            // remove the last Newline 
            tempString = tempString.Substring(0, tempString.Length - 2);


            dataTextBox.Text = tempString;
        }

        private void btnAddText_Click(object sender, EventArgs e)
        {
            pushToUndoStack();

            String[] arrayString = getStringArrayFromData();

            String prefix = beginTextBox.Text + "";
            String postfix = endTextBox.Text + "";


            String tempString = "";

            // Loop through the string array
            foreach (String line in arrayString)
            {
                tempString = tempString + prefix + line + postfix + Environment.NewLine;
            }

            // remove the last CRLF
            tempString = tempString.Substring(0, tempString.Length - 2);

            dataTextBox.Text = tempString;
        }

        private void clipBoardButton_Click(object sender, EventArgs e)
        {
            if (dataTextBox.Text != null)
            {
                Clipboard.SetText(dataTextBox.Text);
            }
            
        }

        private void crlfButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("[CRLF]");
        }

        private void tabButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("[TAB]");
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            pushToUndoStack();

            String temp = dataTextBox.Text;
            String find = searchTextBox.Text;
            String replace = replaceTextBox.Text;

            //  FIND:  Look for special chars
            if (find.IndexOf("[CRLF]") > -1)
                find = find.Replace("[CRLF]", Environment.NewLine);

            if (find.IndexOf("[TAB]") > -1)
                find = find.Replace("[TAB]", "\t");

            // REPLACE:  Look for special chars
            if (replace.IndexOf("[CRLF]") > -1)
                replace = replace.Replace("[CRLF]", Environment.NewLine);

            if (replace.IndexOf("[TAB]") > -1)
                replace = replace.Replace("[TAB]", "\t");


            if (find.Length > 0)
            {
                temp = temp.Replace(find, replace);
                dataTextBox.Text = temp;
            }

        }

        Stack<String> undoStack = new Stack<String>();
        Stack<String> redoStack = new Stack<String>();

        private void pushToUndoStack()
        {
            String lastItem = "";

            if (undoStack.Count > 0)
                lastItem = undoStack.Peek();

            if (dataTextBox.Text != lastItem)
                undoStack.Push(dataTextBox.Text);
        }


        private void popFromUndoStack()
        {
            if (undoStack.Count > 0)
                dataTextBox.Text = undoStack.Pop();

        }

        private void pushToRedoStack()
        {
            String lastItem = "";

            if (redoStack.Count > 0)
                lastItem = redoStack.Peek();

            if (dataTextBox.Text != lastItem)
                redoStack.Push(dataTextBox.Text);
        }


        private void popFromRedoStack()
        {
            if (redoStack.Count > 0)
                dataTextBox.Text = redoStack.Pop();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            pushToUndoStack();
            popFromRedoStack();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            pushToRedoStack();
            popFromUndoStack();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pushToUndoStack();
            dataTextBox.Clear();

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            pushToUndoStack();
            string[] arrayString = getStringArrayFromData();

            string foundString = "";
            string notFoundString = "";

            foreach (String temp in arrayString)
            {

                if (temp.Contains(findTextBox.Text))
                {
                    foundString = foundString + temp + Environment.NewLine;

                }
                else if (!temp.Contains(findTextBox.Text))
                {
                    notFoundString = notFoundString + temp + Environment.NewLine;

                }

            }

            // you both a juicy found and not found string.

            // which do you display

            if (exludeMatchingCheckBox.Checked)
                dataTextBox.Text = notFoundString;
            else
                dataTextBox.Text = foundString;



        }

        private void withButton_Click(object sender, EventArgs e)
        {
            pushToUndoStack();
            withQuotes();
        }

        private void withQuotes()
        {
            String[] arrayString = getStringArrayFromData();

            string quote = "'";
            string tempString = "in(";
            bool hasInStatment = false;

            foreach (String line in arrayString)
            {
                if (hasInStatment == false)
                {
                    tempString = tempString + quote + line;
                    hasInStatment = true;
                }
                else
                {
                    tempString = tempString + quote + "," + quote + line;
                }

            }
            tempString = tempString + quote + ")";
            tempString = tempString.Replace(",)", ")");
            dataTextBox.Text = tempString;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            pushToUndoStack();
            withoutQuotes();
        }

        private void withoutQuotes()
        {
            String[] arrayString = getStringArrayFromData();


            string tempString = "in(";
            bool hasInStatment = false;

            foreach (String line in arrayString)
            {
                if (hasInStatment == false)
                {
                    tempString = tempString + line;
                    hasInStatment = true;
                }
                else
                {
                    tempString = tempString + "," + line;
                }

            }
            tempString = tempString + ")";
            tempString = tempString.Replace(",)", ")");
            dataTextBox.Text = tempString;
        }


    }
}

