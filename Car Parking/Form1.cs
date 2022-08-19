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
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Collections;

namespace Car_Parking
{
    
    public partial class CarParking : Form
    {
        //Create a list RegoPlate
        //Q2 A list<> data structure of data type "string
        List<string> RegoPlate = new List<string>();
        string currentFileName = "";
       
        //Bindingsourece is an intermediate link between the list and the list box, it encapsulate the data source for a form 
        BindingSource bs = new BindingSource();

        public CarParking()
        {
            InitializeComponent();
            bs.DataSource = RegoPlate; //Intermidate binding source variable with RegoPlate data source
        }
        private bool ValidName(string checkThisName)
        {
            //Not allow duplicated plate to exist in the list box
            if (RegoPlate.Exists(duplicate => duplicate.Equals(checkThisName)))
                return false;
            else
                return true;
        }

        //Q13 Tag: Create a tag method
        private void Tag()
        {
           //Create a tag method wih a prefix "Z" added in front
            if (listBoxPlate.SelectedIndex != -1)
            {
                RegoPlate[listBoxPlate.SelectedIndex] = "Z: " + listBoxPlate.SelectedItem;
            }
        }
        //Q13 Tag: When a rego plate is selected from the list box and "tagged", an additional character value
        //"Z" will be prefixed to the rego plate.
        private void buttonTag_Click(object sender, EventArgs e)
        {
           //Create a string which is the item selected from the list box
            string selectedText = (string)listBoxPlate.SelectedItem; 

           //If the selected item started with the prefix "Z", remove the prefix
            if (selectedText.StartsWith("Z") && (listBoxPlate.SelectedIndex >= 0))
           {
               RegoPlate.Add(selectedText.TrimStart('Z',':',' '));
               RegoPlate.ToList();
               RegoPlate.RemoveAt(listBoxPlate.SelectedIndex);
               RegoPlate.Remove(textBoxInput.Text);
               toolStripStatusLabel1.Text = ("Untagged");
           }
           //Import the tag method to tag the selected item in the list box
           else 
           {
               Tag();
               toolStripStatusLabel1.Text = "Tagged";
           }
           //Q9 Display and Sort: Sorted automatically in the list box by using built-in list sort method
            RegoPlate.Sort();
            textBoxInput.Clear();
            textBoxInput.Focus();
            //Tell the list box to update using the current version of rego plate list
            listBoxPlate.DataSource = bs;
            //Not changing string type to other type. Using string in the update >> false
            //Call ResetBindings to update the textboxes, only values have changed
            bs.ResetBindings(false);
        }
        //Q10 Binary Search: Using binary search to search for the plate in the list
        private void buttonBinarySearch_Click(object sender, EventArgs e)
        {
            //Using built-in BinarySearch method to find the target entered in the text box
            if (!string.IsNullOrWhiteSpace(textBoxInput.Text))
            {
               RegoPlate.Sort();
               if (RegoPlate.BinarySearch(textBoxInput.Text) >= 0)
                   toolStripStatusLabel1.Text = ("Found");
               else
                    toolStripStatusLabel1.Text = ("Not found");
                    textBoxInput.Clear();
            }
            else
            {
                toolStripStatusLabel1.Text = ("Please enter a plate");
            }
            textBoxInput.Clear();
            textBoxInput.Focus();
        }
        //Q11 Linear Search: Using linear search to search for the plate in the list
        private void buttonLinearSearch_Click(object sender, EventArgs e)
        {
            string target= textBoxInput.Text;
            bool found = false;

            //Using linear search to find the target
            if (!string.IsNullOrWhiteSpace(textBoxInput.Text))
            {
                for (int x = 0; x < listBoxPlate.Items.Count; x++)
                {
                    if (listBoxPlate.Items.Contains(target))
                    {
                      toolStripStatusLabel1.Text = ("Found");
                      found = true;
                      break;
                    }
                }
                if (!found)
                {
                    toolStripStatusLabel1.Text = ("Not found");
                }
                textBoxInput.Clear();
                textBoxInput.Focus();
            }
             else
             {
                toolStripStatusLabel1.Text = ("Please enter a plate");
                textBoxInput.Clear();
                textBoxInput.Focus();
            }
        }

        //Q3 Open: Load the data into the list<>.
        //When the open button is clicked, the user can select different data from pre-saved text files.
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //Displays a standard dislog box that prompts the user to open a file.
            string textFileName;
            OpenFileDialog openTextFile = new OpenFileDialog();//Creat an OpenFileDialog control object
            openTextFile.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            //Restrict the file type
            openTextFile.Filter = "txt flies (*.txt)|*.txt";
            DialogResult sr = openTextFile.ShowDialog();//ShowDialog method displays the OpenFileDialog

            if (sr == DialogResult.OK)
            {
                //Read the content of the file
                textFileName = openTextFile.FileName;
                //Set the current file name as the open file name
                currentFileName = textFileName;
                toolStripStatusLabel1.Text = ("File opened");
            }
            else
            {
                return;
            }
            try
            {
                RegoPlate.Clear();
                using (StreamReader reader = new StreamReader(File.OpenRead(textFileName)))
                {
                    //If it is not end of stream, keep reading the text file
                    while (!reader.EndOfStream)
                    {
                        RegoPlate.Add(reader.ReadLine());//Read one line a time
                        listBoxPlate.DataSource = bs;
                        bs.ResetBindings(false);
                    }
                }
            }
            catch (IOException)
            {
                toolStripStatusLabel1.Text = ("File not openned");
            }
        }
        //Q4 Enter: To add a rego plate to the list<>
        //The user will type the data value into the TextBox and click the Add button
        //The data will be added to the list<> and the TextBox will be cleared.
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Set up the rego plate pattern as number(1-9) + three capital characters+ "-" + three characters in a row
            string pattern = @"^[0-9][A-Z][A-Z][A-Z]-\d{3}$";

            if (string.IsNullOrWhiteSpace(textBoxInput.Text))
            {
                toolStripStatusLabel1.Text = ("Please enter a plate");
            }
            else if (!ValidName(textBoxInput.Text))
            {
                toolStripStatusLabel1.Text = ("The plate is already existed");
            }
            else if (Regex.IsMatch(textBoxInput.Text,pattern)==false)//The rego plate that is entered to the text box has to match the pattern
            {
                toolStripStatusLabel1.Text = ("Please enter a valid plate");
            }
            else
            {
                RegoPlate.Add(textBoxInput.Text);
                toolStripStatusLabel1.Text="Successful";
            }
            listBoxPlate.DataSource = bs;
            RegoPlate.Sort();
            bs.ResetBindings(false);
            textBoxInput.Clear();
            textBoxInput.Focus();
           
            
        }
        //Q5 Leave: To remove rego plate
        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxInput.Text))
            {
                toolStripStatusLabel1.Text = ("Please select or enter a plate");
            }
            //When the plate is entering to the list box, using binary search to search for the plate
            else if (RegoPlate.BinarySearch(textBoxInput.Text) < 0)
            {

               toolStripStatusLabel1.Text = ("The plate cannot be found");
            }
            else
            {
                listBoxPlate.SetSelected(listBoxPlate.SelectedIndex, true);
                //Remove the item in the text box
                RegoPlate.Remove(textBoxInput.Text);
                toolStripStatusLabel1.Text = "Successful";
            }
            listBoxPlate.DataSource = bs;
            bs.ResetBindings(false);
            textBoxInput.Clear();
            textBoxInput.Focus();
        }
        //Q12 Close and Save: Save all the data back to a text file
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Create a SaveFileDialog class
            SaveFileDialog saveTextFileDialoge = new SaveFileDialog();
            saveTextFileDialoge.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            //Restrict the file type as "txt" file type only
            saveTextFileDialoge.Filter = "txt flies (*.txt)|*.txt";
            DialogResult sr = saveTextFileDialoge.ShowDialog();

            if (sr == DialogResult.OK)
            {
                //Use the SaveTextFile method to write the data into the saving file
                SaveTextFile(saveTextFileDialoge.FileName);
            }
            if (sr == DialogResult.Cancel)
            {
                return;
            }
        }
        //Q12 Create a save method
        private void SaveTextFile(string filename)
        {
           //Create a save method 
            try
            {
                using (StreamWriter writer = new StreamWriter(filename, false))
                {
                    foreach (var plate in RegoPlate)
                    {
                        writer.WriteLine(plate);
                        listBoxPlate.DataSource = bs;
                        bs.ResetBindings(false);
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("File not saved");
            }
        }
        //Q12 Close and Save: A form closing method using the save method so all the data from list<> will
        // written back to the list<>
        private void CarParking_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                // Validate file name and increment the file number after closing it
                if (listBoxPlate.Items != null)
                {
                    //Remove the first 5 characters of the current file name
                    int num = int.Parse(Path.GetFileNameWithoutExtension(currentFileName).Remove(0, 5));
                    num++;
                    string newvalue;
                    if (num <= 9)
                        newvalue = "0" + num.ToString();
                    else
                        newvalue = num.ToString();
                        string newFileName = ("demo_" + newvalue + ".txt");
                        SaveTextFile(newFileName);
                }
            }
            catch
            {
                return;
            }
        }
        //Q6 Edit: Alter the information from the text box to the list box selected plate
        private void buttonEdit_Click(object sender, EventArgs e)
        {

            string pattern = @"^[0-9][A-Z][A-Z][A-Z]-\d{3}$";
            if (string.IsNullOrWhiteSpace(textBoxInput.Text))
            {
                textBoxInput.Focus();
                toolStripStatusLabel1.Text = ("Please enter a plate");
            }
            else if (!ValidName(textBoxInput.Text))
            {

                textBoxInput.Focus();
                toolStripStatusLabel1.Text = ("The plate is already existed");
            }
            else if (Regex.IsMatch(textBoxInput.Text, pattern) == false)
            {
                textBoxInput.Focus();
                toolStripStatusLabel1.Text = ("This is not a valid plate");
            }
            else
            {
                //Replace the plate in the text box with the selected item
                RegoPlate[listBoxPlate.SelectedIndex] = textBoxInput.Text;
                RegoPlate.Sort();
                toolStripStatusLabel1.Text = ("Successful");
            }
            listBoxPlate.DataSource = bs;
            bs.ResetBindings(false);
            textBoxInput.Clear();
            textBoxInput.Focus();
        }
        //Q7 Reset: Clear all the data items from the list<>
        private void buttonReset_Click(object sender, EventArgs e)
        {
           //Clear all the data in the rego plate list box
            RegoPlate.Clear();
            bs.ResetBindings(false);
            textBoxInput.Clear();
            toolStripStatusLabel1.Text = ("Reset");


        }
        //Q8 Single Data Display: Create a single click method
        //When a data item is selected from the list box on the left, the information is displayed
        //in the text box on the right
        private void listBoxPlate_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Show the list box selected item into the text box
            if (listBoxPlate.SelectedItem != null)
            {
                textBoxInput.Text = listBoxPlate.SelectedItem.ToString();
            }
        }

    }
}
