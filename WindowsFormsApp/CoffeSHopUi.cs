using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class CoffeSHopUi : Form
    {
        public CoffeSHopUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            String name,adress,orderItem;
            int contactNo;
            name=customernameTextBox.Text;
            contactNo=Convert.ToInt16(contactNoTextBox.Text);
            adress=AddressTextBox.Text;
            orderItem=orderComboBox.Text;
            string total = "";
            
            int quantity = Convert.ToInt16(quantityTextBox.Text);

           
           if (orderComboBox.Text == "Black")
            {
                total = Convert.ToString(120 * quantity);
                MessageBox.Show(total);
            }
            else if (orderComboBox.Text == "Cold")
            {
                total = Convert.ToString(100*quantity);
                MessageBox.Show(total);
            }
            else if (orderComboBox.Text == "Hot")
            {
                total = Convert.ToString(90 * quantity);
                MessageBox.Show(total);
            }
            else if (orderComboBox.Text == "Regular")
            {
                total = Convert.ToString(80 * quantity);
                MessageBox.Show(total);
            }
            else
            {
                MessageBox.Show("Please choose any item");
            }

           showRichTextBox.Text = ("------Order Info------" + "\n" + "Customer Name:" + name + "\n" + "Contact no:" + 
               contactNo + "\n" + "CustomerAddress:" + adress + "\n" + "Order item:" + orderItem + "\n" + "Quantity:" + 
               quantity + "\n" + "Total:"+total+"\n"+"=====Thanks,come again=====");

        }

       

        
    }
}
