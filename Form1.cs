namespace dictionaries
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> contacts = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string phoneNumber = phoneNumberTextBox.Text.Trim();

            if (name != "" && phoneNumber != "")
            {
                if (!contacts.ContainsKey(phoneNumber))
                {
                    contacts.Add(phoneNumber, name);
                    RefreshContactList();
                }
                else
                {
                    MessageBox.Show("Цей номер вже існує в списку контактів.", "Помилка");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть ім'я та номер телефону.", "Помилка");
            }
        }

        private void RefreshContactList()
        {
            contactListBox.Items.Clear();
            foreach (var contact in contacts)
            {
                contactListBox.Items.Add(contact.Key + ":" + contact.Value);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (contactListBox.SelectedIndex != -1)
            {
                string selectedContact = contactListBox.SelectedItem.ToString();
                string[] parts = selectedContact.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                string oldPhoneNumber = parts[0].Trim();

                if (contacts.ContainsKey(oldPhoneNumber))
                {
                    string newName = nameTextBox.Text.Trim();
                    string newPhoneNumber = phoneNumberTextBox.Text.Trim();

                    if (!contacts.ContainsKey(newPhoneNumber) || newPhoneNumber == oldPhoneNumber)
                    {
                        contacts.Remove(oldPhoneNumber);
                        contacts[newPhoneNumber] = newName;
                        RefreshContactList();
                    }
                    else
                    {
                        MessageBox.Show("Цей номер вже існує в списку контактів.", "Помилка");
                    }
                }
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (contactListBox.SelectedIndex != -1)
            {
                string selectedContact = contactListBox.SelectedItem.ToString();
                string phoneNumber = selectedContact.Split(':')[0].Trim();

                if (contacts.ContainsKey(phoneNumber))
                {
                    contacts.Remove(phoneNumber);
                    RefreshContactList();
                }
            }
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.Trim().ToLower();
            contactListBox.Items.Clear();

            foreach (var contact in contacts)
            {
                if (contact.Key.ToLower().Contains(searchText) || contact.Value.ToLower().Contains(searchText))
                {
                    contactListBox.Items.Add(contact.Key + ":" + contact.Value);
                }
            }
        }

        private void contactListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (contactListBox.SelectedIndex != -1)
            {
                string selectedContact = contactListBox.SelectedItem.ToString();
                string[] parts = selectedContact.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                string phoneNumber = parts[0].Trim();

                if (contacts.ContainsKey(phoneNumber))
                {
                    nameTextBox.Text = contacts[phoneNumber];
                    phoneNumberTextBox.Text = phoneNumber;
                }
            }
        }
    }
}
