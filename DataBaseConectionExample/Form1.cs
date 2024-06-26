using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseConectionExample
{
    public partial class Form1 : Form
    {
        ExampleDataBaseEntities entities = new ExampleDataBaseEntities();
        public Form1()
        {
            InitializeComponent();
            updateUserListView();
            
        }

        private void add_BTN_Click(object sender, EventArgs e)
        {

            if (AreAllTextBoxesFromGroupBoxValid(add_GB))
            {
                add_BTN.Enabled = false;
                string addBtnOldText = add_BTN.Text;
                add_BTN.Text = "Please Wait...";

                Users user = new Users();
                user.user_name = user_name_add_TB.Text;
                user.user_surname = user_surname_add_TB.Text;
                entities.Users.Add(user);
                entities.SaveChanges();

                ClearAllTextBoxesFromGropBox(add_GB);
                updateUserListView();
                add_BTN.Text = addBtnOldText;
                add_BTN.Enabled = true;
                MessageBox.Show("Added with succes!");
            }
            else
            {
                MessageBox.Show("Invalid Values!");
            }
        }

        private void updateUserListView()
        {
            users_LW.SelectedItems.Clear();
            users_LW.Items.Clear();
            var users = from user in entities.Users
                        //where true = true
                        select user;
            foreach ( var user in users )
            {
                ListViewItem listViewItem = new ListViewItem(user.user_id.ToString());
                listViewItem.SubItems.Add(user.user_name.ToString());
                listViewItem.SubItems.Add(user.user_surname.ToString());

                users_LW.Items.Add(listViewItem);
            }
        }

        int selectedUserId = -1;
        private void users_LW_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (users_LW.SelectedItems.Count > 0)
            {
                selectedUserId = int.Parse(users_LW.SelectedItems[0].SubItems[0].Text);
                var user = entities.Users.SingleOrDefault(u => u.user_id == selectedUserId);

                user_name_update_TB.Text = user.user_name;
                user_surname_update_TB.Text = user.user_surname;

                EnableUpdateGB(true);
                EnableDeleteGB(true);
            }
            else
            {
                selectedUserId = -1;

                ClearAllTextBoxesFromGropBox(update_GB);

                EnableUpdateGB(false);
                EnableDeleteGB(false);
            }
        }

        private void delete_BTN_Click(object sender, EventArgs e)
        {
            if(selectedUserId != -1)
            {
                var user = entities.Users.SingleOrDefault(u => u.user_id == selectedUserId);
               
                entities.Users.Remove(user);
                entities.SaveChanges();
                MessageBox.Show("Deleted with succes!");
                updateUserListView();
            }
            else
            {
                MessageBox.Show("User not Selected!");
            }
        }
        
        private void update_BTN_Click(object sender, EventArgs e)
        {
            if(selectedUserId != -1)
            {
                if (AreAllTextBoxesFromGroupBoxValid(update_GB))
                {
                    update_BTN.Enabled = false;
                    string btnOldText = update_BTN.Text;
                    update_BTN.Text = "Please Wait...";

                    var user = entities.Users.SingleOrDefault(u => u.user_id == selectedUserId);
                    user.user_name = user_name_update_TB.Text;
                    user.user_surname = user_surname_update_TB.Text;
                    entities.SaveChanges();

                    ClearAllTextBoxesFromGropBox(update_GB);
                    updateUserListView();
                    update_BTN.Text = btnOldText;
                    //update_BTN.Enabled = true;
                    MessageBox.Show("Updated with succes!");
                }
                else
                {
                    MessageBox.Show("Invalid Values!");
                }
            }
            else
            {
                MessageBox.Show("User not Selected!");
            }
        }
       
        private void EnableUpdateGB(bool boolean)
        {
            List<TextBox> textBoxes = update_GB.Controls.OfType<TextBox>().ToList();
            List<Button> buttons = update_GB.Controls.OfType<Button>().ToList();

            foreach(TextBox textBox in textBoxes)
            {
                textBox.Enabled = boolean;
            }

            foreach(Button button in buttons)
            {
                button.Enabled = boolean;
            }
        }

        private void EnableDeleteGB(bool boolean)
        {
            delete_BTN.Enabled = boolean;
        }

        private bool AreAllTextBoxesFromGroupBoxValid(GroupBox groupBox)
        {
            List<TextBox> textBoxes = groupBox.Controls.OfType<TextBox>().ToList();
            foreach (TextBox textBox in textBoxes)
            {
                if (!IsTextBoxTextValid(textBox.Text))
                    return false;
            }
            return true;
        }

        private void ClearAllTextBoxesFromGropBox(GroupBox groupBox)
        {
            List<TextBox> textBoxes = groupBox.Controls.OfType<TextBox>().ToList();
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = "";
            }
        }

        private bool IsTextBoxTextValid(string text)
        {
            if (text.Equals("") || text.Equals(null))
                return false;
            return true;
        }

        
    }
}
