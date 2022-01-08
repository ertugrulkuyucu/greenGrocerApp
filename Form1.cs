using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenGrocerApp
{
    public partial class Form1 : Form
    {
        object[,,] products = new object[2, 4, 2];

        #region Methods

        void removeInList (int indexType, int indexName)
        {
            if ((int)products[indexType, indexName, 1] > 0)
            {
            int quantity = Convert.ToInt32(quantityTextBox.Text);
            int temp = (int)products[indexType, indexName, 1];
            temp -= Convert.ToInt32(quantity);
            products[indexType, indexName, 1] = temp;
            if (salesRadioButton.Checked)
            {
                MessageBox.Show("Sold products! " + quantity + " kg " + products[indexType, indexName, 0]);

                if (productTypeComboBox.SelectedItem == "Fruit")
                {
                    Print(0);
                }
                else if (productTypeComboBox.SelectedItem == "Vegetable")
                {
                    Print(1);
                }
            }
            else
                MessageBox.Show("Sweepings products! " + quantity + " kg " + products[indexType, indexName, 0]);
            }
            else
            {
                MessageBox.Show("Product out is stock! Firstly add stock!");
            }
        }

        void addInList (int indexType, int indexName)
        {
            int quantity = Convert.ToInt32(quantityTextBox.Text);
            int temp = (int)products[indexType, indexName, 1];
            temp += Convert.ToInt32(quantity);
            products[indexType, indexName, 1] = temp;
            MessageBox.Show("Added products! " + quantity + " kg " + products[indexType, indexName, 0]);
        }

        void NameDeclare()
        {
            if (productTypeComboBox.SelectedItem == "Fruit")
            {
                productNameComboBox.Items.Add("Apple");
                productNameComboBox.Items.Add("Banana");
                productNameComboBox.Items.Add("Strawberry");
                productNameComboBox.Items.Add("Kiwi");
            }
            else
            {
                productNameComboBox.Items.Add("Cucumber");
                productNameComboBox.Items.Add("Onion");
                productNameComboBox.Items.Add("Tomato");
                productNameComboBox.Items.Add("Aubergine");
            }
        }

        void Print(int index)
        {
            productListBox.Items.Clear();

            for (int i = 0; i < products.GetLength(1); i++)
            {
                productListBox.Items.Add(products[index, i, 0] + "\t" + products[index, i, 1]);
            }
        }

        #endregion               

        public Form1()
        {
            InitializeComponent();
            products[0, 0, 0] = "Apple            ";
            products[0, 1, 0] = "Banana     ";
            products[0, 2, 0] = "Strawberry";
            products[0, 3, 0] = "Kiwi               ";
            products[1, 0, 0] = "Cucumber   ";
            products[1, 1, 0] = "Onion          ";
            products[1, 2, 0] = "Tomato     ";
            products[1, 3, 0] = "Aubergine  ";

            products[0, 0, 1] = 0;
            products[0, 1, 1] = 0;
            products[0, 2, 1] = 0;
            products[0, 3, 1] = 0;
            products[1, 0, 1] = 0;
            products[1, 1, 1] = 0;
            products[1, 2, 1] = 0;
            products[1, 3, 1] = 0;
        }

        private void stockRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            productTypeComboBox.Text = "";
            productNameComboBox.Items.Clear();
            productNameComboBox.Text = "";
            productListBox.Visible = false;
            stockEntryButton.Visible = true;
            sweepingsEntryButton.Visible = true;
            entryPanel.Visible = false;
            entryPanel.Text = "Please Select Procces Type !";
        }

        private void saveStock_Click(object sender, EventArgs e)
        {
            if (entryPanel.Text == "Stock")
            {
                switch (productNameComboBox.SelectedItem)
                {
                  case "Apple":
                      addInList(0, 0);
                      break;
                  case "Banana":
                      addInList(0, 1);
                      break;
                  case "Strawberry":
                      addInList(0, 2);
                      break;
                  case "Kiwi":
                      addInList(0, 3);
                      break;
                  case "Cucumber":
                      addInList(1, 0);
                      break;
                  case "Onion":
                      addInList(1, 1);
                      break;
                  case "Tomato":
                      addInList(1, 2);
                      break;
                  default:
                      addInList(1, 3);
                      break;
                }
            }
            //sweepings products               
            else
            {
                switch (productNameComboBox.SelectedItem)
                {
                    case "Apple":
                        removeInList(0, 0);
                        break;
                    case "Banana":
                        removeInList(0, 1);
                        break;
                    case "Strawberry":
                        removeInList(0, 2);
                        break;
                    case "Kiwi":
                        removeInList(0, 3);
                        break;
                    case "Cucumber":
                        removeInList(1, 0);
                        break;
                    case "Onion":
                        removeInList(1, 1);
                        break;
                    case "Tomato":
                        removeInList(1, 2);
                        break;
                    default:
                        removeInList(1, 3);
                        break;
                }
            }    
            
            // Actually sweepings and sales doing same proccess. and i removed else if unders.
            //else if (salesRadioButton.Checked)

        }

        private void salesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            productTypeComboBox.Text = "";
            productNameComboBox.Items.Clear();
            productNameComboBox.Text = "";
            productListBox.Visible = true;
            stockEntryButton.Visible = false;
            sweepingsEntryButton.Visible = false;
            entryPanel.Text = "Sales";
            saveButton.Text = "Sales";
            entryPanel.Visible = true;
            
            NameDeclare();
        }

        private void stockEntryButton_Click(object sender, EventArgs e)
        {
            entryPanel.Text = "Stock";
            entryPanel.Visible = true;
            saveButton.Text = "Stocking";
        }

        private void sweepingsEntryButton_Click(object sender, EventArgs e)
        {
            entryPanel.Text = "Sweepings";
            entryPanel.Visible = true;
            saveButton.Text = "Sweepings";
        }

        private void productTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            productNameComboBox.Items.Clear();
            productNameComboBox.Text = "";

            NameDeclare();

            if (salesRadioButton.Checked)
            {
                if (productTypeComboBox.SelectedItem == "Fruit")                
                    Print(0);
                
                else if (productTypeComboBox.SelectedItem == "Vegetable")               
                    Print(1);                
            }
        }        
    }
}
