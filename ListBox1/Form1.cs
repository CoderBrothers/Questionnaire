using System;
using System.Text.RegularExpressions;

namespace ListBox1
{
    public partial class DataBase : Form
    {
        public DataBase()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            nameTBX.Clear();
            surnameTBX.Clear();
            telTBX.Clear();
            emailTBX.Clear();
        }
        //List<string> list = new();
        private void addBTN_Click(object sender, EventArgs e)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(emailTBX.Text, pattern, RegexOptions.IgnoreCase);
            if (!string.IsNullOrWhiteSpace(nameTBX.Text) &&
                !string.IsNullOrWhiteSpace(surnameTBX.Text) &&
                isMatch.Success)
            {
                Person person = new()
                {
                    Name = nameTBX.Text,
                    Surname = surnameTBX.Text,
                    Phone = telTBX.Text,
                    Email = emailTBX.Text,
                };
                peopleLBX.Items.Add(person);
                Clear();
            }
            else MessageBox.Show("¬ведите корректные данные");
            Person tmp = Change();
        }

        private Person Change()
        {
            throw new NotImplementedException();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            peopleLBX.Items.Remove(peopleLBX.SelectedItem);
        }

        private void peopleLBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (peopleLBX.SelectedIndex == -1) return;
            Person tmp = peopleLBX.SelectedItem as Person;
            nameTBX.Text = tmp.Name;
            surnameTBX.Text=tmp.Surname;
            telTBX.Text = tmp.Phone;
            emailTBX.Text = tmp.Email;
        }

        private void change_Click(object sender, EventArgs e)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(emailTBX.Text, pattern, RegexOptions.IgnoreCase);
            if (!string.IsNullOrWhiteSpace(nameTBX.Text) &&
                !string.IsNullOrWhiteSpace(surnameTBX.Text) &&
                isMatch.Success)
            {
                int index = peopleLBX.SelectedIndex;
                Person person = peopleLBX.SelectedItem as Person;
                person.Name = nameTBX.Text;
                person.Surname = surnameTBX.Text;
                person.Phone = telTBX.Text;
                person.Email = emailTBX.Text;
                peopleLBX.Items[index] = person;
            }
            else MessageBox.Show("¬ведите корректные данные");
            Person tmp = Change();
        }
        private void Change(object sender, EventArgs e)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(emailTBX.Text, pattern, RegexOptions.IgnoreCase);
            if (!string.IsNullOrWhiteSpace(nameTBX.Text) &&
                !string.IsNullOrWhiteSpace(surnameTBX.Text) &&
                isMatch.Success)
            {
                int index = peopleLBX.SelectedIndex;
                Person person = peopleLBX.SelectedItem as Person;
                person.Name = nameTBX.Text;
                person.Surname = surnameTBX.Text;
                person.Phone = telTBX.Text;
                person.Email = emailTBX.Text;
                peopleLBX.Items[index] = person;
            }
            else null;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(emailTBX.Text, pattern, RegexOptions.IgnoreCase);
            if (!string.IsNullOrWhiteSpace(nameTBX.Text) &&
                !string.IsNullOrWhiteSpace(surnameTBX.Text) &&
                isMatch.Success) 
            {
                string result = string.Empty;
                result += $"{nameLbl.Text}: {nameTBX.Text}\n";
                result += $"{surnameLbl.Text}: {surnameTBX.Text}\n";
                result += $"{telLbl.Text}: {telTBX.Text}\n";
                result += $"{emailLbl.Text}: {emailTBX.Text}\n";
                MessageBox.Show(result);
                SaveFileDialog sfd = new();
                sfd.Filter = "Text files(*.txt)|*.txt|Secret files(*.secret)|*.secret|All files(*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.Cancel) return;
                string filename = sfd.FileName;
                File.WriteAllText(filename, result);
                MessageBox.Show("‘айл сохранен");
            }
            else MessageBox.Show("¬ведите корректные данные");
        }
    }
}