using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMaterial.SelectedIndex = 0;
            txtWidth.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCalculate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                int width = int.Parse(txtWidth.Text.Trim());
                int height = int.Parse(txtHeight.Text.Trim());
                int quantity = int.Parse(txtQuantity.Text.Trim());
                string material = cmbMaterial.SelectedItem.ToString();

                double price = CalculatePrice(width, height, material);
                double total = price * quantity;
                MessageBox.Show($"Общая стоимость: {total} рублей.", "Жалюзи");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double CalculatePrice(int width, int height, string material)
        {
            double price = 0;

            switch (material)
            {
                case "Пластик":
                    price = 50 * (width + height);
                    break;
                case "Алюминий":
                    price = 100 * (width + height);
                    break;
                case "Соломка":
                    price = 30 * (width + height);
                    break;
                case "Текстиль":
                    price = 70 * (width + height);
                    break;
            }

            return price;
        }
    }
}