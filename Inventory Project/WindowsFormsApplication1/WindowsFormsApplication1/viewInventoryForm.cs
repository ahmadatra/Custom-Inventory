// Ahmad Atra
// Inventory Management
// 1/11/2018
// Uses MSACCESS Database

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class viewInventoryForm : Form
    {
        ListViewItem item;
        string connectionInfo, version;
        OleDbConnection connection;
        int sortCondition, consoleCondition;
        String consoleSelector = null;
        String sortSelector = null;
        string id = null;
        string title = null;
        string console = null;
        string quantity = null;
        string qty = "Qty: ";
        String[] consoleList = { "ALL", "GBA", "GBC", "GC", "PS1", "PS2", "PS3", "XBOX", "X360" };
        String[] consoleListForTotal = { "GBA", "GBC", "GC", "PS1", "PS2", "PS3", "XBOX", "X360" };
        String[] sortList = {  "Default", "Console", "Quantity" };

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public viewInventoryForm()
        {
            InitializeComponent();

            sortCondition = -1;
            consoleCondition = -1;

            connectionInfo = string.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;", version, "Inventory.accdb");

            //connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; DATA SOURCE= C:\Users\Blank Blank\Desktop\Inventory Project\Inventory.accdb");//Inventory.accdb");
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; DATA SOURCE= " + Environment.CurrentDirectory + "\\Inventory.accdb");//Inventory.accdb");

            //connection.Open();

            //Setup the combobox with all the systems covered in the database
            foreach (String console in consoleList)
                ConsoleSelectorBox.Items.Add(console);

            //Setup the combobox with all ways to sort
            foreach (String sortMethod in sortList)
                SortSelectorBox.Items.Add(sortMethod);

            //selects a certain console to ensure that the query ran is associated to this
            consoleSelector = this.ConsoleSelectorBox.GetItemText(this.ConsoleSelectorBox.SelectedItem);

            //selects a certain console to ensure that the query ran is associated to this
            sortSelector = this.SortSelectorBox.GetItemText(this.SortSelectorBox.SelectedItem);

            //disable search button when we first open the view inventory
            if(ConsoleSelectorBox.SelectedIndex == -1 || SortSelectorBox.SelectedIndex == -1)
                SearchButton.Enabled = false;
            
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void PrintTotalOfAllConsoles(String ConsoleSelectorCondition)
        {
            //Clear the view before before outputting the info
            TotalTitleslistView1.Items.Clear();

            if(ConsoleSelectorCondition == "ALL" || ConsoleSelectorBox.SelectedIndex == -1)
            {
                OleDbCommand command2 = new OleDbCommand("Select Sum(Quantity) FROM Inventory", connection);
                OleDbDataReader newreaderTotal;

                foreach (String console in consoleListForTotal) 
                {
                    OleDbCommand command = new OleDbCommand("Select Sum(Quantity) FROM Inventory WHERE Console = ?", connection);

                    OleDbParameter consoleParameter = new OleDbParameter();
                    consoleParameter.Value = console;
                    command.Parameters.Add(consoleParameter);

                    OleDbDataReader newreader = command.ExecuteReader();

                    //Print the total for each console
                    while (newreader.Read())
                    {
                        item = new ListViewItem(console);
                        item.SubItems.Add(newreader[0].ToString());
                        TotalTitleslistView1.Items.Add(item);
                    }
                }

                newreaderTotal = command2.ExecuteReader();
                //run the query to print the total of all consoles together
                while (newreaderTotal.Read())
                {
                    item = new ListViewItem("Total");
                    item.SubItems.Add(newreaderTotal[0].ToString());
                    TotalTitleslistView1.Items.Add(item);
                }

            }
            else
            {
                OleDbCommand command = new OleDbCommand("Select Sum(Quantity) FROM Inventory WHERE Console = ?", connection);

                OleDbParameter consoleParameter = new OleDbParameter();
                consoleParameter.Value = ConsoleSelectorCondition;
                command.Parameters.Add(consoleParameter);

                OleDbDataReader newreader = command.ExecuteReader();

                while (newreader.Read())
                {
                    item = new ListViewItem(ConsoleSelectorCondition);
                    item.SubItems.Add(newreader[0].ToString());
                    TotalTitleslistView1.Items.Add(item);
                }
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void ReadAndPrintToList(OleDbDataReader reader)
        {

            while (reader.Read())
            {

                id = reader[0].ToString();
                title = reader[3].ToString();
                console = reader[1].ToString();
                quantity = reader[2].ToString();

                item = new ListViewItem(id);
                item.SubItems.Add(console);
                item.SubItems.Add(title);
                item.SubItems.Add(quantity);
                TitlelistView1.Items.Add(item);
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            //check and setup the sort and console conditions
            sortCondition = SortSelectorBox.SelectedIndex;
            consoleCondition = ConsoleSelectorBox.SelectedIndex;

            //Clear all previous text in list
            TitlelistView1.Items.Clear();

            connection.Open();
            OleDbDataReader reader = null;

            OleDbCommand oleDbCommand;

            //selects a certain console to ensure that the query ran is associated to this
            consoleSelector = this.ConsoleSelectorBox.GetItemText(this.ConsoleSelectorBox.SelectedItem);
            //selects a certain way to sort all retreived data
            sortSelector = this.SortSelectorBox.GetItemText(this.SortSelectorBox.SelectedItem);

            if(consoleSelector == "ALL")
            {
                //Base case to run query to retreive all games from inventory
                if(sortSelector == "Default")
                {
                    oleDbCommand = new OleDbCommand("Select * FROM Inventory ORDER BY Title ASC", connection);

                    reader = oleDbCommand.ExecuteReader();

                    ReadAndPrintToList(reader);

                    PrintTotalOfAllConsoles(consoleSelector);

                }
                else if(sortSelector == "Quantity")
                {
                    oleDbCommand = new OleDbCommand("Select * FROM Inventory ORDER BY Quantity + 0 DESC, Title ASC", connection);

                    reader = oleDbCommand.ExecuteReader();

                    ReadAndPrintToList(reader);
                    PrintTotalOfAllConsoles(consoleSelector);
                }
                else if(sortSelector == "Console")
                {
                    oleDbCommand = new OleDbCommand("Select * FROM Inventory ORDER BY Console, Title", connection);

                    OleDbParameter sortParameter = new OleDbParameter();
                    sortParameter.Value = sortSelector;
                    oleDbCommand.Parameters.Add(sortParameter);
                    

                    reader = oleDbCommand.ExecuteReader();

                    ReadAndPrintToList(reader);
                    PrintTotalOfAllConsoles(consoleSelector);
                }
                //if nothing is selected then run base code
                else
                {
                    oleDbCommand = new OleDbCommand("Select * FROM Inventory ORDER BY Title ASC", connection);

                    reader = oleDbCommand.ExecuteReader();

                    ReadAndPrintToList(reader);

                    PrintTotalOfAllConsoles(consoleSelector);
                }

                //THIS CODE IS TO OUTPUT THE TOTAL FOR ALL CONSOLES

            }
            //If we are specifying the console for load all button
            else
            {
                //if no input from drop down lists for console or sort then run base code
                if((sortCondition == -1 && consoleCondition == -1) || (sortCondition == -1 && consoleCondition != -1) || (sortCondition != -1 && consoleCondition == -1))
                {
                    oleDbCommand = new OleDbCommand("Select * FROM Inventory ORDER BY Title ASC", connection);

                    reader = oleDbCommand.ExecuteReader();

                    ReadAndPrintToList(reader);
                    PrintTotalOfAllConsoles(consoleSelector);
                }
                else if (sortSelector == "Default")
                {
                    oleDbCommand = new OleDbCommand("Select * FROM Inventory WHERE Console = ? ORDER BY Title ASC", connection);

                    //Add sort and console option as parameter to avoid sql injection
                    OleDbParameter consoleParameter = new OleDbParameter();
                    consoleParameter.Value = consoleSelector;
                    oleDbCommand.Parameters.Add(consoleParameter);

                    reader = oleDbCommand.ExecuteReader();

                    ReadAndPrintToList(reader);
                    PrintTotalOfAllConsoles(consoleSelector);
                }
                else if(sortSelector == "Quantity")
                {
                    oleDbCommand = new OleDbCommand("Select * FROM Inventory WHERE Console = ? ORDER BY Quantity+0 DESC, Title ASC", connection);

                    //Add sort and console option as parameter to avoid sql injection
                    OleDbParameter consoleParameter = new OleDbParameter();
                    consoleParameter.Value = consoleSelector;
                    oleDbCommand.Parameters.Add(consoleParameter);

                    reader = oleDbCommand.ExecuteReader();

                    ReadAndPrintToList(reader);
                    PrintTotalOfAllConsoles(consoleSelector);
                }
            }

            connection.Close();
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void SearchButton_Click(object sender, EventArgs e)
        {
            //selects a certain console to ensure that the query ran is associated to this
            consoleSelector = this.ConsoleSelectorBox.GetItemText(this.ConsoleSelectorBox.SelectedItem);
            sortSelector = this.SortSelectorBox.GetItemText(this.SortSelectorBox.SelectedItem);

            //gets the game title from the text box
            string titlename = SearchTextBox.Text;

            //open connection to database and create a reader to read in results of query
            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand oleDbCommand;

            //clean the listbox to show new output
            //Titles.Items.Clear();
            TitlelistView1.Items.Clear();

            if (consoleSelector == "ALL" )
            {
                if(sortSelector == "Default")
                {
                    //Uses substrings
                    oleDbCommand = new OleDbCommand("Select * FROM Inventory WHERE INSTR(Title, ?) > 0 ORDER BY Title ASC", connection);

                    //to avoid risk of sql injection, we are going to pass in the title as a parameter rather than directly as a string
                    OleDbParameter p1 = new OleDbParameter();
                    oleDbCommand.Parameters.Add(p1);
                    p1.Value = titlename;

                    reader = oleDbCommand.ExecuteReader();

                    ReadAndPrintToList(reader);
                }
                else if(sortSelector == "Quantity")
                {
                    //Uses substrings
                    oleDbCommand = new OleDbCommand("Select * FROM Inventory WHERE (INSTR(Title, ?) > 0) ORDER BY Quantity + 0 DESC", connection);

                    //to avoid risk of sql injection, we are going to pass in the title as a parameter rather than directly as a string
                    OleDbParameter titleParameter = new OleDbParameter();
                    titleParameter.Value = titlename;
                    oleDbCommand.Parameters.Add(titleParameter);
                    

                    reader = oleDbCommand.ExecuteReader();

                    ReadAndPrintToList(reader);
                }
                else
                {
                    //Uses substrings
                    oleDbCommand = new OleDbCommand("Select * FROM Inventory WHERE INSTR(Title, ?) > 0 ORDER BY Console, Title", connection);

                    //to avoid risk of sql injection, we are going to pass in the title as a parameter rather than directly as a string
                    OleDbParameter titleParameter = new OleDbParameter();
                    oleDbCommand.Parameters.Add(titleParameter);
                    titleParameter.Value = titlename;

                    reader = oleDbCommand.ExecuteReader();

                    ReadAndPrintToList(reader);
                }

                connection.Close();

            }

            else if( consoleSelector != "ALL")
            {
                if(sortSelector == "Quantity")
                {
                    //Uses substrings
                    oleDbCommand = new OleDbCommand("Select * FROM Inventory WHERE INSTR(Title, ?) > 0 AND Console = ? ORDER BY Quantity + 0 DESC, Title ASC", connection);

                    //to avoid risk of sql injection, we are going to pass in the title as a parameter rather than directly as a string
                    OleDbParameter titleParameter = new OleDbParameter();
                    OleDbParameter consoleParameter = new OleDbParameter();

                    oleDbCommand.Parameters.Add(titleParameter);
                    oleDbCommand.Parameters.Add(consoleParameter);

                    titleParameter.Value = titlename;
                    consoleParameter.Value = consoleSelector;

                    reader = oleDbCommand.ExecuteReader();

                    ReadAndPrintToList(reader);
                }
                else
                {
                    //Uses substrings
                    oleDbCommand = new OleDbCommand("Select * FROM Inventory WHERE INSTR(Title, ?) > 0 AND Console = ? ORDER BY Title ASC", connection);

                    //to avoid risk of sql injection, we are going to pass in the title as a parameter rather than directly as a string
                    OleDbParameter titleParameter = new OleDbParameter();
                    OleDbParameter consoleParameter = new OleDbParameter();

                    oleDbCommand.Parameters.Add(titleParameter);
                    oleDbCommand.Parameters.Add(consoleParameter);

                    titleParameter.Value = titlename;
                    consoleParameter.Value = consoleSelector;

                    reader = oleDbCommand.ExecuteReader();

                    ReadAndPrintToList(reader);
                }
            }

            //Close database connection after task is accomplished (Title Search in this instance) 
            connection.Close();
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //This button allows us to switch to the edit form
        private void SwitchToEdit_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Hide();

            editInventoryForm editForm = new editInventoryForm();
            editForm.Show();
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void ConsoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SortSelectorBox.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(SearchTextBox.Text) && ConsoleSelectorBox.SelectedIndex != -1)
                SearchButton.Enabled = true;

            //retreive current console selected
            consoleSelector = this.ConsoleSelectorBox.GetItemText(this.ConsoleSelectorBox.SelectedItem); ;

            //quick solution to remove any unnecessary options to user
            if (consoleSelector != "ALL")
                SortSelectorBox.Items.Remove("Console");
            else if(SortSelectorBox.Items.Contains("Console") && consoleSelector == "ALL")
            {
                
            }
            else
            {
                SortSelectorBox.Items.Add("Console");
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if(SortSelectorBox.SelectedIndex != -1 && ConsoleSelectorBox.SelectedIndex != -1)
                SearchButton.Enabled = !string.IsNullOrWhiteSpace(SearchTextBox.Text);
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void Clear_Click(object sender, EventArgs e)
        {
            TitlelistView1.Items.Clear();
            TotalTitleslistView1.Items.Clear();
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void SortSelectorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortSelectorBox.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(SearchTextBox.Text) && ConsoleSelectorBox.SelectedIndex != -1)
                SearchButton.Enabled = true;
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void TitlelistView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void viewInventoryForm_Load(object sender, EventArgs e)
        {

        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void TitlesBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
