using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using DAL;
using BLL;
using Raven.Client;

namespace UI
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        PersonBLL bll;
        IDocumentStore docStore;

        public void opensession() {
            using (var session = docStore.OpenSession()) {
                var people = session.Query<Person>();
                GridView.DataSource = people;
            }
        }
        public RadForm1()
        {
            InitializeComponent();
            bll = new PersonBLL();
            docStore = ConnectDB.createstore();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Person person = new Person
            {
                LastName = lastname_add.Text.Trim(),
                FirstName = firstname_add.Text.Trim()
            };
            string message = "";
            if (bll.add(person, out message))
            {
                
                // GridView.Refresh();
                opensession();
                MessageBox.Show(message);
            }
            else {
                MessageBox.Show(message);
                lastname_add.Focus();
            }
            

        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            
            opensession();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            
            string personID = ID_update.Text.Trim();
            string message = "";
            string LastName = lastname_update.Text.Trim();
            string FirstName = firstname_update.Text.Trim();
            
            
                if (bll.update(personID, LastName, FirstName, out message))
                {
                opensession();
                    MessageBox.Show(message);
                }
                else {
                    MessageBox.Show(message);
                }
            
           
           
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            string personID = GridView.Rows[GridView.CurrentRow.Index].Cells[0].Value.ToString();
            string message = "";
            if (bll.delete(personID, out message))
            {
                opensession();
                MessageBox.Show(message);
            }
            else {
                MessageBox.Show(message);
            }

        }

        private void sel_button_Click(object sender, EventArgs e)
        {
            
            string personID = ID_sel.Text.Trim();
            string message = "";
            BindingList<Person> list = new BindingList<Person>();
            if (bll.getinfo(personID, out message)) {
                using (var session = docStore.OpenSession()) {
                    Person people = session.Load<Person>(personID);
                    list.Add(people);                 
                    GridView.DataSource = list;
                }
            }
            else{
                MessageBox.Show(message);
                opensession();
            }
            
           
            
        }
    }
}
