using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using System.Net.Http.Json;

namespace InventoryApp
{
    public partial class InventoryManagementSystem : Form
    {
        HttpClient client = new HttpClient();

        // Tracks the primary key of the selected item behind the scenes
        private int selectedItemId = 0;

        public InventoryManagementSystem()
        {
            InitializeComponent();

            client.BaseAddress = new Uri("http://localhost:5261/");
            dataGridView1.DataError += (s, e) => { e.ThrowException = false; };
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                var items = await client.GetFromJsonAsync<List<Item>>("api/items");
                dataGridView1.DataSource = items;

                // HIGH-VISIBILITY COLOR ALERTS
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["StockQuantity"].Value != null && row.Cells["LowStockThreshold"].Value != null)
                    {
                        int stock = Convert.ToInt32(row.Cells["StockQuantity"].Value);
                        int threshold = Convert.ToInt32(row.Cells["LowStockThreshold"].Value);

                        if (stock <= threshold)
                        {
                            // Turns the low stock rows a vibrant light coral pink with deep red text
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 221, 221);
                            row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(194, 24, 7);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }


        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid price number.");
                return;
            }
            if (!int.TryParse(txtQuantity.Text, out int qty) || !int.TryParse(txtThreshold.Text, out int threshold))
            {
                MessageBox.Show("Please enter valid whole numbers for Stock and Low Stock fields.");
                return;
            }

            Item item = new Item()
            {
                Name = txtName.Text,
                Code = txtCode.Text,
                Brand = txtBrand.Text,
                UnitPrice = price,
                StockQuantity = qty,
                LowStockThreshold = threshold
            };

            var response = await client.PostAsJsonAsync("api/items", item);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Item Added Successfully!");
                btnLoad_Click(sender, e);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedItemId == 0)
            {
                MessageBox.Show("Please click on a row in the table first before deleting.");
                return;
            }

            // Confirms drop operation using structural id variable
            var response = await client.DeleteAsync($"api/items/{selectedItemId}");

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Item Deleted Successfully!");
                selectedItemId = 0; // Clear selected tracker
                btnLoad_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Delete Failed. Verify database records.");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedItemId == 0)
            {
                MessageBox.Show("Please click on a row in the table first before updating.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid price number.");
                return;
            }
            if (!int.TryParse(txtQuantity.Text, out int qty) || !int.TryParse(txtThreshold.Text, out int threshold))
            {
                MessageBox.Show("Please enter valid whole numbers for Stock and Low Stock fields.");
                return;
            }

            Item item = new Item()
            {
                Id = selectedItemId, // Keep the same identity primary key
                Name = txtName.Text,
                Code = txtCode.Text, // Users can now change the code layout text safely!
                Brand = txtBrand.Text,
                UnitPrice = price,
                StockQuantity = qty,
                LowStockThreshold = threshold
            };

            // Hits the database targeting the selected ID key parameter directly
            var response = await client.PutAsJsonAsync($"api/items/{selectedItemId}", item);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Inventory Updated Successfully!");
                btnLoad_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Update Failed. Please check the item or server status.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Safely extract and store the primary key from the hidden or visible Id column
                if (row.Cells["Id"].Value != null)
                {
                    selectedItemId = Convert.ToInt32(row.Cells["Id"].Value);
                }

                txtName.Text = row.Cells["Name"].Value?.ToString();
                txtCode.Text = row.Cells["Code"].Value?.ToString();
                txtBrand.Text = row.Cells["Brand"].Value?.ToString();
                txtPrice.Text = row.Cells["UnitPrice"].Value?.ToString();
                txtQuantity.Text = row.Cells["StockQuantity"].Value?.ToString();
                txtThreshold.Text = row.Cells["LowStockThreshold"].Value?.ToString();
            }
        }

        private void Title_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void InventoryManagementSystem_Load(object sender, EventArgs e) { }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
