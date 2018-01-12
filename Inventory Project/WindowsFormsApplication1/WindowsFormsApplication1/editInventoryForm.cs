// Ahmad Atra
// Inventory Management
// 1/11/2018
// Uses MSACCESS Database

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class editInventoryForm : Form
    {
        int index = 0;
        string functionSelector;
        string consoleSelector;
        string quantitySelected;
        string connectionInfo, version;
        OleDbConnection connection;

        //strings used to print out the info and move to the textboxes
        string consoleHighlighted, titleHighlighted;
        ListViewItem previewItem = new ListViewItem();

        //---------------------------------------------------------------------------------------------------------
        public void getDetailsFromListviewAndUpdateQuantityForm( )
        {
            if (listView1.SelectedItems.Count > 0)
            {
                previewItem = listView1.Items[listView1.SelectedIndices[0]];
                //get the console and title
                consoleHighlighted = previewItem.SubItems[1].Text;
                titleHighlighted = previewItem.SubItems[2].Text;
            }

            UpdateQuantityChangeForms(consoleHighlighted, titleHighlighted);
        }

        //---------------------------------------------------------------------------------------------------------
        private void UpdateQuantityChangeForms(String console, String title)
        {
            TitleTextBox.Text = title;
            ConsoleSelectorBox.Text = console;
        }

        //---------------------------------------------------------------------------------------------------------
        public void UpdateQuantityQuery()
        {
            //Create command to hold query
            OleDbCommand updateQuery  =new OleDbCommand("UPDATE Inventory SET Quantity = ? WHERE Title = ?", connection);

            OleDbParameter quantityParameter = new OleDbParameter();
            quantityParameter.Value = ChangeQuantityTextBox.Text;
            updateQuery.Parameters.Add(quantityParameter);

            OleDbParameter TitleParameter = new OleDbParameter();
            TitleParameter.Value = TitleTextBox.Text;
            updateQuery.Parameters.Add(TitleParameter);

            connection.Open();
            updateQuery.ExecuteScalar();

            connection.ResetState();
            connection.Close();

        }

        //---------------------------------------------------------------------------------------------------------
        public void PrintToListView(OleDbDataReader reader)
        {
            listView1.Clear();

            while (reader.Read())
            {
                previewItem = new ListViewItem(reader[0].ToString());
                previewItem.SubItems.Add(reader[1].ToString());
                previewItem.SubItems.Add(reader[3].ToString());
                previewItem.SubItems.Add(reader[2].ToString());
                listView1.Items.Add(previewItem);
            }
        }

        //---------------------------------------------------------------------------------------------------------
        public void PreviewInventory()
        {
            listView1.Items.Clear();

            connection.Open();

            OleDbCommand printInventoryBasedOnConsole = new OleDbCommand("Select * FROM Inventory WHERE Console = ? ORDER BY Title ASC", connection);

            functionSelector = this.SelectorBox.GetItemText(this.SelectorBox.SelectedItem);
            if (functionSelector == "Update Quantity")
            {
                OleDbParameter consoleParameter = new OleDbParameter();
                consoleParameter.Value = ConsoleSelectorBox.SelectedItem.ToString();
                printInventoryBasedOnConsole.Parameters.Add(consoleParameter);
            }
            else if( functionSelector == "Add Game")
            {
                OleDbParameter consoleParameter = new OleDbParameter();
                consoleParameter.Value = ConsoleSelectorBox2.SelectedItem.ToString();
                printInventoryBasedOnConsole.Parameters.Add(consoleParameter);
            }
            //print everything to listview1
            OleDbDataReader newreader = printInventoryBasedOnConsole.ExecuteReader();

            while (newreader.Read())
            {
                previewItem = new ListViewItem(newreader[0].ToString());
                previewItem.SubItems.Add(newreader[1].ToString());
                previewItem.SubItems.Add(newreader[3].ToString());
                previewItem.SubItems.Add(newreader[2].ToString());
                listView1.Items.Add(previewItem);
            }

            connection.Close();
        }

        //---------------------------------------------------------------------------------------------------------
        public void SetupConnection()
        {
            connectionInfo = string.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;", version , "Inventory.accdb");

            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; DATA SOURCE= "+ Environment.CurrentDirectory +"\\Inventory.accdb");
        }

        //---------------------------------------------------------------------------------------------------------
        //Enables the update quantity functionality 
        public void EnableUpdateQuantity()
        {
            TitleTextBox.Enabled = true;
            ConsoleSelectorBox.Enabled = true;
            ChangeQuantityTextBox.Enabled = true;
        }

        //---------------------------------------------------------------------------------------------------------
        //Disables the update quantity functionality 
        public void DisableUpdateQuantity()
        {
            TitleTextBox.Enabled = false;
            ConsoleSelectorBox.Enabled = false;
            ChangeQuantityTextBox.Enabled = false;
            UpdateQuantityButton.Enabled = false;
        }

        //---------------------------------------------------------------------------------------------------------
        //Enables the add game functionality 
        public void EnableAddGame()
        {
            TitleTextBox2.Enabled = true;
            ConsoleSelectorBox2.Enabled = true;
            AddGameQuantityTextBox.Enabled = true;
        }

        //---------------------------------------------------------------------------------------------------------
        //Disables the add game functionality 
        public void DisableAddGame()
        {
            TitleTextBox2.Enabled = false;
            ConsoleSelectorBox2.Enabled = false;
            AddGameButton.Enabled = false;
            AddGameQuantityTextBox.Enabled = false;
        }

        //---------------------------------------------------------------------------------------------------------
        //Disables all functionality in windows form
        public void DisableAll()
        {
            DisableAddGame();
            DisableUpdateQuantity();
        }

        //---------------------------------------------------------------------------------------------------------
        public void CheckIfAllFormsAreFilled()
        {
            if(!string.IsNullOrWhiteSpace(TitleTextBox.Text) && !string.IsNullOrWhiteSpace(ChangeQuantityTextBox.Text) && ConsoleSelectorBox.SelectedIndex != -1)
            {
                UpdateQuantityButton.Enabled = true;
            }
            else
            {
                UpdateQuantityButton.Enabled = false;
            }
        }
        //---------------------------------------------------------------------------------------------------------
        public void CheckIfAllFormsAreFilledAddGame()
        {
            if (!string.IsNullOrWhiteSpace(TitleTextBox2.Text) && !string.IsNullOrWhiteSpace(AddGameQuantityTextBox.Text) && ConsoleSelectorBox2.SelectedIndex != -1)
            {
                AddGameButton.Enabled = true;
            }
            else
            {
                AddGameButton.Enabled = false;
            }
        }

        //---------------------------------------------------------------------------------------------------------
        private void CheckIfAllFormsAreFilledForAddGame()
        {
            if (!string.IsNullOrWhiteSpace(TitleTextBox2.Text) && ConsoleSelectorBox2.SelectedIndex != -1)
            {
                AddGameButton.Enabled = true;
            }
            else
            {
                AddGameButton.Enabled = false;
            }
        }

        //---------------------------------------------------------------------------------------------------------
        public editInventoryForm()
        {
            InitializeComponent();

            DisableAll();

            ChangeQuantityTextBox.MaxLength = 2;

            SetupConnection();
        }

        //---------------------------------------------------------------------------------------------------------
        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        //---------------------------------------------------------------------------------------------------------
        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            viewInventoryForm inventoryForm = new viewInventoryForm();
            inventoryForm.Show();

        }

        //---------------------------------------------------------------------------------------------------------
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //---------------------------------------------------------------------------------------------------------
        private void SelectorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            functionSelector = this.SelectorBox.GetItemText(this.SelectorBox.SelectedItem);
            if (functionSelector == "Add Game")
            {
                EnableAddGame();
                DisableUpdateQuantity();
            }
            else if(functionSelector == "Update Quantity")
            {
                EnableUpdateQuantity();
                DisableAddGame();
            }
            else
            {
                DisableAll();
            }
        }

        //---------------------------------------------------------------------------------------------------------
        private void ADDQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!System.Text.RegularExpressions.Regex.IsMatch( ChangeQuantityTextBox.Text, "[ ^ 0-9]"))
            {
                ChangeQuantityTextBox.Text = "";
            }

            CheckIfAllFormsAreFilledAddGame();
        }

        //---------------------------------------------------------------------------------------------------------
        private void UpdateQuantityButton_Click(object sender, EventArgs e)
        {

            //Setup and open connection
            SetupConnection();
            //Create update query and execute it
            UpdateQuantityQuery();

            //Cleans the listview
            listView1.Items.Clear();

            //Print new data to listview
            PreviewInventory();
        }

        //---------------------------------------------------------------------------------------------------------
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDetailsFromListviewAndUpdateQuantityForm();
        }

        //---------------------------------------------------------------------------------------------------------
        private void AddGameButton_Click(object sender, EventArgs e)
        {
            //create add game query and setup parameters
            OleDbCommand AddGameQuery = new OleDbCommand("INSERT INTO Inventory (Console, Quantity, Title) Values(?, ?, ?)", connection);


            OleDbParameter consoleParameter = new OleDbParameter();
            consoleParameter.Value = ConsoleSelectorBox2.Text;
            AddGameQuery.Parameters.Add(consoleParameter);

            OleDbParameter quantityParameter = new OleDbParameter();
            quantityParameter.Value = AddGameQuantityTextBox.Text;
            AddGameQuery.Parameters.Add(quantityParameter);

            OleDbParameter TitleParameter = new OleDbParameter();
            TitleParameter.Value = TitleTextBox2.Text;
            AddGameQuery.Parameters.Add(TitleParameter);

            //open connection
            connection.Open();

            //execute query
            AddGameQuery.ExecuteScalar();

            connection.ResetState();
            //close connection
            connection.Close();

            PreviewInventory();
        }

        //---------------------------------------------------------------------------------------------------------
        private void AddGameQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch( AddGameQuantityTextBox.Text, "[ ^ 0-9]"))
            {
                ChangeQuantityTextBox.Text = "";
            }

            CheckIfAllFormsAreFilledAddGame();
        }
        
        //---------------------------------------------------------------------------------------------------------
        private void ConsoleSelectorBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckIfAllFormsAreFilledAddGame();
        }

        //---------------------------------------------------------------------------------------------------------
        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        //---------------------------------------------------------------------------------------------------------
        private void ViewInventoryButton_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Hide();

            viewInventoryForm viewForm = new viewInventoryForm();
            viewForm.Show();
        }

        //---------------------------------------------------------------------------------------------------------
        private void TitleTextBox2_TextChanged(object sender, EventArgs e)
        {
            CheckIfAllFormsAreFilledAddGame();
        }

        //---------------------------------------------------------------------------------------------------------
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckIfAllFormsAreFilled();
        }

        //---------------------------------------------------------------------------------------------------------
        private void ConsoleSelectorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckIfAllFormsAreFilled();
            PreviewInventory();
        }
        //---------------------------------------------------------------------------------------------------------


    }
}
