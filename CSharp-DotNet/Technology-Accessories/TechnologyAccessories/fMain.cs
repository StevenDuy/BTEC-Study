using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.Security.AccessControl;
using System.Reflection.PortableExecutable;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing.Imaging;

namespace TechnologyAccessories
{
    public partial class fMain : Form
    {
        private string userRole;
        private OpenFileDialog openFileDialog;

        public fMain(string role)
        {
            InitializeComponent();

            userRole = role;
            SetPermissions();

            LoadData();

            openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select a Product Image"
            };

            lvPro.Columns.Add("Product ID", 200, HorizontalAlignment.Center);
            lvPro.Columns.Add("Product Name", 200, HorizontalAlignment.Center);
            lvPro.Columns.Add("Quantity", 200, HorizontalAlignment.Center);
            lvPro.Columns.Add("Price", 200, HorizontalAlignment.Center);

            lvCus.Columns.Add("Customer ID", 200, HorizontalAlignment.Center);
            lvCus.Columns.Add("Customer Name", 200, HorizontalAlignment.Center);
            lvCus.Columns.Add("Customer Address", 200, HorizontalAlignment.Center);
            lvCus.Columns.Add("Customer Phone", 200, HorizontalAlignment.Center);

            lvEm.Columns.Add("Employee ID", 200, HorizontalAlignment.Center);
            lvEm.Columns.Add("Employee Name", 200, HorizontalAlignment.Center);
            lvEm.Columns.Add("Employee Role", 200, HorizontalAlignment.Center);
            lvEm.Columns.Add("Employee Address", 200, HorizontalAlignment.Center);
            lvEm.Columns.Add("Employee Phone", 200, HorizontalAlignment.Center);
            lvEm.Columns.Add("Employee Username", 200, HorizontalAlignment.Center);
            lvEm.Columns.Add("Employee Password", 200, HorizontalAlignment.Center);

            lvOr.Columns.Add("Order ID", 100, HorizontalAlignment.Center);
            lvOr.Columns.Add("Product ID", 100, HorizontalAlignment.Center);
            lvOr.Columns.Add("Product Name", 200, HorizontalAlignment.Center);
            lvOr.Columns.Add("Customer ID", 100, HorizontalAlignment.Center);
            lvOr.Columns.Add("Customer Name", 200, HorizontalAlignment.Center);
            lvOr.Columns.Add("Employee Name", 200, HorizontalAlignment.Center);
            lvOr.Columns.Add("Date", 200, HorizontalAlignment.Center);
            lvOr.Columns.Add("Amount", 100, HorizontalAlignment.Center);
            lvOr.Columns.Add("Price", 100, HorizontalAlignment.Center);
            lvOr.Columns.Add("Total Price", 100, HorizontalAlignment.Center);
        }

        private void EnableAllTabs()
        {
            foreach (TabPage tab in tpMain.TabPages)
            {
                tab.Enabled = true;
            }
        }

        private void DisableAllTabsExcept(params TabPage[] allowedTabs)
        {
            foreach (TabPage tab in tpMain.TabPages)
            {
                tab.Enabled = false;
            }

            foreach (TabPage allowedTab in allowedTabs)
            {
                allowedTab.Enabled = true;
            }
        }

        private void SetPermissions()
        {
            switch (userRole)
            {
                case "Admin":
                    EnableAllTabs();
                    break;
                case "Warehouse":
                    DisableAllTabsExcept(tpPro);
                    tpMain.SelectTab(tpPro);
                    break;
                case "Sale":
                    DisableAllTabsExcept(tpCus, tpOr);
                    tpMain.SelectTab(tpCus);
                    break;
                default:
                    this.Close();
                    break;
            }
        }

        private void LoadData()
        {
            string connectionString = "Data Source=MSI\\MASTERMOS;Initial Catalog=TechnologyAccessories;Integrated Security=True";
            string queryPro = "SELECT * FROM Product";

            using (SqlConnection connectionPro = new SqlConnection(connectionString))
            {
                connectionPro.Open();
                SqlCommand commandPro = new SqlCommand(queryPro, connectionPro);
                SqlDataAdapter dataAdapterPro = new SqlDataAdapter(commandPro);
                DataTable dataTablePro = new DataTable();
                dataAdapterPro.Fill(dataTablePro);
                connectionPro.Close();

                //temp table
                originalProDataTable = dataTablePro.Copy();

                lvPro.View = View.Details;
                lvPro.Items.Clear();

                // Add item in loadlist
                foreach (DataRow row in dataTablePro.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < dataTablePro.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    lvPro.Items.Add(item);
                }
            }

            string queryProduct = "SELECT ProductID, ProductName, Price FROM Product";
            using (SqlConnection connectionProduct = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapterProduct = new SqlDataAdapter(queryProduct, connectionProduct);
                DataTable dataTableProduct = new DataTable();
                dataAdapterProduct.Fill(dataTableProduct);

                cbbOrProNa.DisplayMember = "ProductName";
                cbbOrProNa.ValueMember = "ProductID";
                cbbOrProNa.DataSource = dataTableProduct;
            }

            string queryCus = "SELECT * FROM Customer";

            using (SqlConnection ConnectionCus = new SqlConnection(connectionString))
            {
                ConnectionCus.Open();
                SqlCommand commandCus = new SqlCommand(queryCus, ConnectionCus);
                SqlDataAdapter dataAdapterCus = new SqlDataAdapter(commandCus);
                DataTable dataTableCus = new DataTable();
                dataAdapterCus.Fill(dataTableCus);
                ConnectionCus.Close();

                originalCusDataTable = dataTableCus.Copy();

                lvCus.View = View.Details;
                lvCus.Items.Clear();

                foreach (DataRow row in dataTableCus.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < dataTableCus.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    lvCus.Items.Add(item);
                }
            }

            string queryCustomer = "SELECT CustomerID, Name FROM Customer";
            using (SqlConnection connectionCustomer = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapterCustomer = new SqlDataAdapter(queryCustomer, connectionCustomer);
                DataTable dataTableCustomer = new DataTable();
                dataAdapterCustomer.Fill(dataTableCustomer);
                cbbOrCusNa.DisplayMember = "Name";
                cbbOrCusNa.ValueMember = "CustomerID";
                cbbOrCusNa.DataSource = dataTableCustomer;
            }

            string queryEm = "SELECT * FROM Employee";

            using (SqlConnection ConnectionEm = new SqlConnection(connectionString))
            {
                ConnectionEm.Open();
                SqlCommand commandEm = new SqlCommand(queryEm, ConnectionEm);
                SqlDataAdapter dataAdapterEm = new SqlDataAdapter(commandEm);
                DataTable dataTableEm = new DataTable();
                dataAdapterEm.Fill(dataTableEm);
                ConnectionEm.Close();

                originalEmDataTable = dataTableEm.Copy();

                lvEm.View = View.Details;
                lvEm.Items.Clear();

                foreach (DataRow row in dataTableEm.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < dataTableEm.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    lvEm.Items.Add(item);
                }
            }

            string queryEmployee = "SELECT EmployeeID, EmployeeName FROM Employee";
            using (SqlConnection connectionEmployee = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapterEmployee = new SqlDataAdapter(queryEmployee, connectionEmployee);
                DataTable dataTableEmployee = new DataTable(); dataAdapterEmployee.Fill(dataTableEmployee);
                cbbOrEmNa.DisplayMember = "EmployeeName";
                cbbOrEmNa.ValueMember = "EmployeeID";
                cbbOrEmNa.DataSource = dataTableEmployee;
            }

            string queryOrder = "SELECT * FROM [Order]";

            using (SqlConnection connectionOrder = new SqlConnection(connectionString))
            {
                connectionOrder.Open();
                SqlCommand commandOrder = new SqlCommand(queryOrder, connectionOrder);
                SqlDataAdapter dataAdapterOrder = new SqlDataAdapter(commandOrder);
                DataTable dataTableOrder = new DataTable();
                dataAdapterOrder.Fill(dataTableOrder);
                connectionOrder.Close();

                originalOrDataTable = dataTableOrder.Copy();

                lvOr.View = View.Details;
                lvOr.Items.Clear();

                // Add item in loadlist
                foreach (DataRow row in dataTableOrder.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < dataTableOrder.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    lvOr.Items.Add(item);
                }
            }
        }

        //GET IMAGE INPUT

        private byte[] GetImageBytes(Image image)
        {
            if (image == null)
            {
                return null;
            }
            using (MemoryStream ms = new MemoryStream())
            {
                ImageCodecInfo jpgEncoder = GetEncoderInfo("image/jpeg");
                if (jpgEncoder == null)
                {
                    throw new InvalidOperationException("Could not find JPEG encoder.");
                }
                EncoderParameters encoderParameters = new EncoderParameters(1);
                encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);
                image.Save(ms, jpgEncoder, encoderParameters);
                return ms.ToArray();
            }
        }

        private ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            ImageCodecInfo[] encoders = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo encoder in encoders)
            {
                if (encoder.MimeType == mimeType)
                {
                    return encoder;
                }
            }
            return null;
        }


        private byte[] currentImageFile;
        private bool isImageUpdated = false;

        private void btBro_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbPro.Image = Image.FromFile(ofd.FileName);
                    currentImageFile = GetImageBytes(pbPro.Image);
                    isImageUpdated = true;
                }
            }
        }

        //GET IMAGE DATABASE TO CAST

        private byte[] GetImageFromDatabase(int productId)
        {
            byte[] imageData = null;
            string connectionString = "Data Source=MSI\\MASTERMOS;Initial Catalog=TechnologyAccessories;Integrated Security=True";
            string query = "SELECT ImageFile FROM Product WHERE ProductID = @ProductID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductID", productId);

                // Ensure ImageFile column exists in your database schema
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() && !reader.IsDBNull(0))
                    {
                        imageData = (byte[])reader["ImageFile"];
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image from database: " + ex.Message);
                }
            }

            return imageData;
        }

        //PRODUCT ADD

        private void btProAdd_Click(object sender, EventArgs e)
        {

            string productName = tbProNa.Text;
            if (!int.TryParse(tbProQua.Text, out int quantity))
            {
                MessageBox.Show("Invalid quantity format.", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!decimal.TryParse(tbProPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid price format.", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!decimal.TryParse(tbPup.Text, out decimal purchasePrice))
            {
                MessageBox.Show("Invalid purchase price format.", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            byte[] imageFile = GetImageBytes(new Bitmap(pbPro.Image)); // Sử dụng một bản sao của hình ảnh để tránh lỗi GDI+

            string connectionString = "Data Source=MSI\\MASTERMOS;Initial Catalog=TechnologyAccessories;Integrated Security=True";
            string query = "INSERT INTO Product (ProductName, Quantity, Price, ImageFile, PurchasePrice) VALUES (@ProductName, @Quantity, @Price, @ImageFile, @PurchasePrice)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@ImageFile", imageFile ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@PurchasePrice", purchasePrice);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Add successfully!", "System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding product: " + ex.Message);
                    }
                }
            }

            LoadData(); // Reload data to reflect changes
        }

        //PRODUCT UPDATE

        private void btProUp_Click(object sender, EventArgs e)
        {
            if (lvPro.SelectedItems.Count > 0)
            {
                ListViewItem item = lvPro.SelectedItems[0];
                if (!int.TryParse(item.SubItems[0].Text, out int productId))
                {
                    MessageBox.Show("Invalid product ID.", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string productName = tbProNa.Text;
                if (!int.TryParse(tbProQua.Text, out int quantity))
                {
                    MessageBox.Show("Invalid quantity format.", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(tbProPrice.Text, out decimal price))
                {
                    MessageBox.Show("Invalid price format.", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(tbPup.Text, out decimal purchasePrice)) // Ensure you have a textbox for PurchasePrice
                {
                    MessageBox.Show("Invalid purchase price format.", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                byte[] imageFile = isImageUpdated ? GetImageBytes(new Bitmap(pbPro.Image)) : currentImageFile;

                string connectionString = "Data Source=MSI\\MASTERMOS;Initial Catalog=TechnologyAccessories;Integrated Security=True";
                string query = "UPDATE Product SET ProductName = @ProductName, Quantity = @Quantity, Price = @Price, PurchasePrice = @PurchasePrice, ImageFile = CONVERT(varbinary(max), @ImageFile) WHERE ProductID = @ProductID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ProductID", productId);
                            command.Parameters.AddWithValue("@ProductName", productName);
                            command.Parameters.AddWithValue("@Quantity", quantity);
                            command.Parameters.AddWithValue("@Price", price);
                            command.Parameters.AddWithValue("@PurchasePrice", purchasePrice); // Add the PurchasePrice parameter
                            command.Parameters.AddWithValue("@ImageFile", (object)imageFile ?? DBNull.Value);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Update Successfully!", "System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    LoadData();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL error: {ex.Message}", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"General error: {ex.Message}", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You must choose a product first!", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //PRODUCT DELETE

        private void btProDel_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI\\MASTERMOS;Initial Catalog=TechnologyAccessories;Integrated Security=True";

            if (lvPro.SelectedItems.Count > 0)
            {
                int productId = int.Parse(lvPro.SelectedItems[0].SubItems[0].Text);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Product WHERE ProductID = @ProductID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Delete successfully!", "System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadData();
            }
            else
            {
                MessageBox.Show("You must choose product to delete!", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //PRODUCT SEARCHING

        private DataTable originalProDataTable;

        private void tbProSearch_TextChanged(object sender, EventArgs e)
        {
            string searchProText = tbProSearch.Text.ToLower();
            lvPro.Items.Clear();
            foreach (DataRow row in originalProDataTable.Rows)
            {
                bool match = row.ItemArray.Any(field => field.ToString().ToLower().Contains(searchProText));
                if (match)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < originalProDataTable.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    lvPro.Items.Add(item);
                }
            }
            if (string.IsNullOrEmpty(searchProText))
            {
                LoadData();
            }
        }

        //PRODUCT SORTING

        private void lvPro_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewItemComparer sorter = lvPro.ListViewItemSorter as ListViewItemComparer;

            if (sorter == null)
            {
                sorter = new ListViewItemComparer(e.Column);
                lvPro.ListViewItemSorter = sorter;
            }
            if (e.Column == sorter.SortColumn)
            {
                sorter.Order = sorter.Order == Microsoft.Data.SqlClient.SortOrder.Ascending ? Microsoft.Data.SqlClient.SortOrder.Descending : Microsoft.Data.SqlClient.SortOrder.Ascending;
            }
            else
            {
                sorter.SortColumn = e.Column;
                sorter.Order = Microsoft.Data.SqlClient.SortOrder.Ascending;
            }
            lvPro.Sort();
        }

        public class ListViewItemComparer : IComparer
        {
            public int SortColumn { get; set; }
            public Microsoft.Data.SqlClient.SortOrder Order { get; set; }

            public ListViewItemComparer(int column)
            {
                SortColumn = column;
                Order = Microsoft.Data.SqlClient.SortOrder.Ascending;
            }

            public int Compare(object x, object y)
            {
                ListViewItem itemX = x as ListViewItem;
                ListViewItem itemY = y as ListViewItem;

                string valueX = itemX.SubItems[SortColumn].Text;
                string valueY = itemY.SubItems[SortColumn].Text;

                int result;

                if (decimal.TryParse(valueX, out decimal decimalX) && decimal.TryParse(valueY, out decimal decimalY))
                {
                    result = decimalX.CompareTo(decimalY);
                }
                else
                {
                    result = string.Compare(valueX, valueY);
                }

                if (Order == Microsoft.Data.SqlClient.SortOrder.Descending)
                {
                    result = -result;
                }

                return result;
            }
        }

        //PRODUCT CHOOSING

        private void lvPro_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvPro.SelectedItems.Count > 0)
            {
                ListViewItem item = lvPro.SelectedItems[0];
                tbProNa.Text = item.SubItems[1].Text;
                tbProQua.Text = item.SubItems[2].Text;
                tbProPrice.Text = item.SubItems[3].Text;
                tbPup.Text = item.SubItems[5].Text;
                byte[] imageData = GetImageFromDatabase(int.Parse(item.SubItems[0].Text));

                if (pbPro.Image != null)
                {
                    pbPro.Image.Dispose();
                    pbPro.Image = null;
                }

                if (imageData != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pbPro.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pbPro.Image = null;
                }
            }
        }

        //PRODUCT EXPORT

        private void Export_Click(object sender, EventArgs e)
        {

            if (lvPro.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select row!");
                return;
            }

            if (lvPro.SelectedItems.Count > 0)
            {
                ListViewItem item = lvPro.SelectedItems[0];
                int productId = int.Parse(item.SubItems[0].Text);
                string productName = item.SubItems[1].Text;

                string connectionString = "Data Source=MSI\\MASTERMOS;Initial Catalog=TechnologyAccessories;Integrated Security=True";
                StringBuilder productDetails = new StringBuilder();
                productDetails.AppendLine($"Product ID: {productId}");
                productDetails.AppendLine($"Product Name: {productName}");

                decimal totalSoldAmount = 0;
                decimal totalRevenue = 0;
                decimal purchasePrice = 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string productQuery = "SELECT PurchasePrice FROM Product WHERE ProductID = @productId";
                    using (SqlCommand command = new SqlCommand(productQuery, connection))
                    {
                        command.Parameters.AddWithValue("@productId", productId);
                        purchasePrice = (decimal)command.ExecuteScalar();
                    }

                    string orderQuery = "SELECT OrderID, OrderDate, OrderCustomerName, OrderAmount, OrderPrice FROM [Order] WHERE OrderProductID = @productId";
                    using (SqlCommand command = new SqlCommand(orderQuery, connection))
                    {
                        command.Parameters.AddWithValue("@productId", productId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Dictionary<DateTime, List<string>> ordersByDate = new Dictionary<DateTime, List<string>>();
                            Dictionary<DateTime, int> totalAmountByDate = new Dictionary<DateTime, int>();

                            while (reader.Read())
                            {
                                int orderId = reader.GetInt32(0);
                                DateTime orderDate = reader.GetDateTime(1);
                                string customerName = reader.GetString(2);
                                int amount = reader.GetInt32(3);
                                decimal price = reader.GetDecimal(4);

                                string orderInfo = $"Order ID: {orderId}\nCustomer Name: {customerName}\nAmount: {amount}\nPrice: {price:C}\n";

                                if (!ordersByDate.ContainsKey(orderDate.Date))
                                {
                                    ordersByDate[orderDate.Date] = new List<string>();
                                    totalAmountByDate[orderDate.Date] = 0;
                                }
                                ordersByDate[orderDate.Date].Add(orderInfo);
                                totalAmountByDate[orderDate.Date] += amount;

                                totalSoldAmount += amount;
                                totalRevenue += (price - purchasePrice) * amount;
                            }

                            foreach (var date in ordersByDate.Keys)
                            {
                                productDetails.AppendLine($"\nOrders on {date.ToShortDateString()} (Total Amount: {totalAmountByDate[date]}):");
                                foreach (var orderInfo in ordersByDate[date])
                                {
                                    productDetails.AppendLine(orderInfo);
                                }
                            }
                            productDetails.AppendLine($"Total Sold Amount: {totalSoldAmount}");
                            productDetails.AppendLine($"Total Revenue: {totalRevenue:C}");
                        }
                    }
                }

                frmTotalRevenue frmTotalRevenue = new frmTotalRevenue(productDetails.ToString());
                frmTotalRevenue.ShowDialog();
            }
        }

        //CUSTOMER ADD BUTTON

        private void btCusAdd_Click(object sender, EventArgs e)
        {
            string customerName = tbCusNa.Text;
            string customerAddress = tbCusAdd.Text;
            int customerPhone = int.Parse(tbCusPh.Text);

            string connectionString = "Data Source=MSI\\MASTERMOS;Initial Catalog=TechnologyAccessories;Integrated Security=True";
            string query = "INSERT INTO Customer (Name, Address, Phone) VALUES (@CustomerName, @CustomerAddress, @CustomerPhone)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.Parameters.AddWithValue("@CustomerAddress", customerAddress);
                    command.Parameters.AddWithValue("@CustomerPhone", customerPhone);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Add successfully!", "System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding Customer: " + ex.Message);
                    }
                }
            }
            LoadData();
        }

        //CUSTOMER UPDATE BUTTON

        private void btCusUp_Click(object sender, EventArgs e)
        {
            if (lvCus.SelectedItems.Count > 0)
            {
                ListViewItem item = lvCus.SelectedItems[0];
                int customerId = int.Parse(item.SubItems[0].Text);
                string customerName = tbCusNa.Text;
                string customerAddress = tbCusAdd.Text;
                string customerPhone = tbCusPh.Text;

                string connectionString = "Data Source=MSI\\MASTERMOS;Initial Catalog=TechnologyAccessories;Integrated Security=True";
                string query = "UPDATE Customer SET Name = @CustomerName, Address = @CustomerAddress, Phone = @CustomerPhone WHERE CustomerID = @CustomerID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerId);
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        command.Parameters.AddWithValue("@CustomerAddress", customerAddress);
                        command.Parameters.AddWithValue("@CustomerPhone", customerPhone);

                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Update successfully!", "System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("You must choose customer first!", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //CUSTOMER DELETE

        private void btCusDel_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI\\MASTERMOS;Initial Catalog=TechnologyAccessories;Integrated Security=True";

            if (lvCus.SelectedItems.Count > 0)
            {
                int customerId = int.Parse(lvCus.SelectedItems[0].SubItems[0].Text);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Customer WHERE CustomerID = @CustomerID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Delete successfully!", "System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("You must choose customer first!", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selectAllCustomersQuery = "SELECT CustomerID FROM Customer ORDER BY CustomerID";
                List<int> customerIds = new List<int>();
                using (SqlCommand command = new SqlCommand(selectAllCustomersQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customerIds.Add(reader.GetInt32(0));
                        }
                    }
                }

                int newId = 1;
                foreach (int customerId in customerIds)
                {
                    string updateCustomerIdQuery = "UPDATE Customer SET CustomerID = @newId WHERE CustomerID = @customerId";
                    using (SqlCommand command = new SqlCommand(updateCustomerIdQuery, connection))
                    {
                        command.Parameters.AddWithValue("@newId", newId);
                        command.Parameters.AddWithValue("@customerId", customerId);
                        command.ExecuteNonQuery();
                    }
                    newId++;
                }

                string resetIdentityQuery = "DBCC CHECKIDENT ('Customer', RESEED, " + (newId - 1) + ")";
                using (SqlCommand command = new SqlCommand(resetIdentityQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        //CUSTOMER SEARCHING

        private DataTable originalCusDataTable;

        private void tbCusSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbCusSearch.Text.ToLower();
            lvCus.Items.Clear();
            foreach (DataRow row in originalCusDataTable.Rows)
            {
                bool match = row.ItemArray.Any(field => field.ToString().ToLower().Contains(searchText));
                if (match)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < originalCusDataTable.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    lvCus.Items.Add(item);
                }
            }
            if (string.IsNullOrEmpty(searchText))
            {
                LoadData();
            }
        }

        //CUSTOMER SORTING

        private void lvCus_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewItemComparer sorter = lvCus.ListViewItemSorter as ListViewItemComparer;

            if (sorter == null)
            {
                sorter = new ListViewItemComparer(e.Column);
                lvCus.ListViewItemSorter = sorter;
            }
            if (e.Column == sorter.SortColumn)
            {
                sorter.Order = sorter.Order == Microsoft.Data.SqlClient.SortOrder.Ascending ? Microsoft.Data.SqlClient.SortOrder.Descending : Microsoft.Data.SqlClient.SortOrder.Ascending;
            }
            else
            {
                sorter.SortColumn = e.Column;
                sorter.Order = Microsoft.Data.SqlClient.SortOrder.Ascending;
            }
            lvCus.Sort();
        }

        //CUSTOMER CHOOSING

        private void lvCus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCus.SelectedItems.Count > 0)
            {
                ListViewItem item = lvCus.SelectedItems[0];
                tbCusNa.Text = item.SubItems[1].Text;
                tbCusAdd.Text = item.SubItems[2].Text;
                tbCusPh.Text = item.SubItems[3].Text;
            }
        }

        //CUSTOMER EXPORT

        private void btCusEx_Click(object sender, EventArgs e)
        {
            if (lvCus.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select row!");
                return;
            }

            if (lvCus.SelectedItems.Count > 0)
            {
                ListViewItem item = lvCus.SelectedItems[0];
                string customerId = item.SubItems[0].Text;
                string customerName = item.SubItems[1].Text;
                string customerAddress = item.SubItems[2].Text;
                string customerPhone = item.SubItems[3].Text;

                string connectionString = "Data Source=MSI\\MASTERMOS;Initial Catalog=TechnologyAccessories;Integrated Security=True";
                StringBuilder orderDetails = new StringBuilder();
                orderDetails.AppendLine($"ID: {customerId}");
                orderDetails.AppendLine($"Name: {customerName}");
                orderDetails.AppendLine($"Address: {customerAddress}");
                orderDetails.AppendLine($"Phone: {customerPhone}\n");

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT OrderID, OrderProductID, OrderProductName, OrderAmount, OrderDate, OrderPrice, OrderBill FROM [Order] WHERE OrderCustomerName = @customerName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@customerName", customerName);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Dictionary<DateTime, List<string>> ordersByDate = new Dictionary<DateTime, List<string>>();
                            Dictionary<DateTime, int> totalAmountByDate = new Dictionary<DateTime, int>();
                            decimal totalBill = 0;

                            while (reader.Read())
                            {
                                int orderId = reader.GetInt32(0);
                                int productId = reader.GetInt32(1);
                                string productName = reader.GetString(2);
                                int amount = reader.GetInt32(3);
                                DateTime orderDate = reader.GetDateTime(4);
                                decimal price = reader.GetDecimal(5);
                                decimal orderBill = reader.GetDecimal(6);

                                string orderInfo = $"Order ID: {orderId}\nProduct ID: {productId}\nProduct Name: {productName}\nAmount: {amount}\nPrice: {price:C}\nTotal Bill: {orderBill:C}";
                                if (!ordersByDate.ContainsKey(orderDate.Date))
                                {
                                    ordersByDate[orderDate.Date] = new List<string>();
                                    totalAmountByDate[orderDate.Date] = 0;
                                }
                                ordersByDate[orderDate.Date].Add(orderInfo);
                                totalAmountByDate[orderDate.Date] += amount;
                                totalBill += orderBill;
                            }
                            orderDetails.AppendLine($"Order Information:");
                            foreach (var date in ordersByDate.Keys)
                            {
                                orderDetails.AppendLine($"\nOn: {date.ToShortDateString()}");
                                foreach (var orderInfo in ordersByDate[date])
                                {
                                    orderDetails.AppendLine(orderInfo);
                                }
                            }
                            orderDetails.AppendLine($"\nTotal Purchased Amount: {totalBill:C}");
                            RichTextBox richTextBox = new RichTextBox();
                            richTextBox.AppendText(orderDetails.ToString());
                        }
                    }
                }
                frmTotalRevenue frmTotalRevenue = new frmTotalRevenue(orderDetails.ToString());
                frmTotalRevenue.ShowDialog();
            }
        }

        //EMPLOYEE ADD

        private void btEmAdd_Click(object sender, EventArgs e)
        {
            string username = tbEmUser.Text;
            string password = tbEmPass.Text;
            string employeeName = tbEmNa.Text;
            string employeeRole = cbbEmRo.Text;
            string employeeAddress = tbEmAdd.Text;
            string employeePhone = tbEmPh.Text;

            string connectionString = "Data Source=MSI\\MASTERMOS;Initial Catalog=TechnologyAccessories;Integrated Security=True";
            string query = "INSERT INTO Employee (Username, Password, EmployeeName, EmployeeRole, EmployeeAddress, EmployeePhone) " + "VALUES (@Username, @Password, @EmployeeName, @EmployeeRole, @EmployeeAddress, @EmployeePhone)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@EmployeeName", employeeName);
                    command.Parameters.AddWithValue("@EmployeeRole", employeeRole);
                    command.Parameters.AddWithValue("@EmployeeAddress", employeeAddress);
                    command.Parameters.AddWithValue("@EmployeePhone", employeePhone);

                    connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Registration successful!", "System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error registering: " + ex.Message);
                    }
                    LoadData();
                }
            }
        }

        //EMPLOYEE UPDATE

        private void btEmUp_Click(object sender, EventArgs e)
        {
            if (lvEm.SelectedItems.Count > 0)
            {
                ListViewItem item = lvEm.SelectedItems[0];
                int EmId = int.Parse(item.SubItems[0].Text);
                string EmNa = tbEmNa.Text;
                string EmRo = cbbEmRo.Text;
                string EmAd = tbEmAdd.Text;
                string EmPh = tbEmPh.Text;
                string EmUser = tbEmUser.Text;
                string EmPass = tbEmPass.Text;

                string connectionString = "Data Source=MSI\\MASTERMOS;Initial Catalog=TechnologyAccessories;Integrated Security=True";
                string query = "UPDATE Employee SET EmployeeName = @EmployeeName, EmployeeRole = @EmployeeRole, EmployeeAddress = @EmployeeAddress, EmployeePhone = @EmployeePhone, Username = @Username, Password = @Password WHERE EmployeeID = @EmployeeID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", EmId);
                        command.Parameters.AddWithValue("@EmployeeName", EmNa);
                        command.Parameters.AddWithValue("@EmployeeRole", EmRo);
                        command.Parameters.AddWithValue("@EmployeeAddress", EmAd);
                        command.Parameters.AddWithValue("@EmployeePhone", EmPh);
                        command.Parameters.AddWithValue("@Username", EmUser);
                        command.Parameters.AddWithValue("@Password", EmPass);

                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Employee updated successfully.", "System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("You must choose employee first!", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //EMPLOYEE DELETE

        private void btEmDel_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI\\MASTERMOS;Initial Catalog=TechnologyAccessories;Integrated Security=True";

            if (lvEm.SelectedItems.Count > 0)
            {
                int emId = int.Parse(lvEm.SelectedItems[0].SubItems[0].Text);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmployeeID", emId);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Delete successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("You must choose employee first!", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //EMPLOYEE SEARCHING

        private DataTable originalEmDataTable;

        private void tbEmSearch_TextChanged(object sender, EventArgs e)
        {
            string searchEmText = tbEmSearch.Text.ToLower();
            lvEm.Items.Clear();
            foreach (DataRow row in originalEmDataTable.Rows)
            {
                bool match = row.ItemArray.Any(field => field.ToString().ToLower().Contains(searchEmText));
                if (match)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < originalProDataTable.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    lvEm.Items.Add(item);
                }
            }
            if (string.IsNullOrEmpty(searchEmText))
            {
                LoadData();
            }
        }

        //EMPLOYEE SORTING

        private void lvEm_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewItemComparer sorter = lvEm.ListViewItemSorter as ListViewItemComparer;

            if (sorter == null)
            {
                sorter = new ListViewItemComparer(e.Column);
                lvEm.ListViewItemSorter = sorter;
            }
            if (e.Column == sorter.SortColumn)
            {
                sorter.Order = sorter.Order == Microsoft.Data.SqlClient.SortOrder.Ascending ? Microsoft.Data.SqlClient.SortOrder.Descending : Microsoft.Data.SqlClient.SortOrder.Ascending;
            }
            else
            {
                sorter.SortColumn = e.Column;
                sorter.Order = Microsoft.Data.SqlClient.SortOrder.Ascending;
            }
            lvEm.Sort();
        }

        // EMPLOYEE CHOOSING

        private void lvEm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEm.SelectedItems.Count > 0)
            {
                ListViewItem item = lvEm.SelectedItems[0];
                tbEmNa.Text = item.SubItems[1].Text;
                cbbEmRo.Text = item.SubItems[2].Text;
                tbEmAdd.Text = item.SubItems[3].Text;
                tbEmPh.Text = item.SubItems[4].Text;
                tbEmUser.Text = item.SubItems[5].Text;
                tbEmPass.Text = item.SubItems[6].Text;
            }
        }

        //ORDER ADD

        private void btOrAdd_Click(object sender, EventArgs e)
        {
            int productId = (int)cbbOrProNa.SelectedValue;
            int customerId = (int)cbbOrCusNa.SelectedValue;
            int employeeId = (int)cbbOrEmNa.SelectedValue;
            DateTime orderDate = dtpkDate.Value;
            int amount = int.Parse(tbOrA.Text);
            decimal price = decimal.Parse(tbOrP.Text);
            decimal totalBill = decimal.Parse(tbTotalBill.Text);

            string connectionString = "Data Source=MSI\\MASTERMOS;Initial Catalog=TechnologyAccessories;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string checkQuantityQuery = "SELECT Quantity FROM Product WHERE ProductID = @productId";
                int availableQuantity;
                using (SqlCommand command = new SqlCommand(checkQuantityQuery, connection))
                {
                    command.Parameters.AddWithValue("@productId", productId);
                    availableQuantity = (int)command.ExecuteScalar();
                }
                if (amount > availableQuantity)
                {
                    MessageBox.Show("The quantity ordered exceeds the quantity available. Please enter a quantity less than or equal to: " + availableQuantity, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string insertOrderQuery = "INSERT INTO [Order] (OrderProductID, OrderProductName, OrderCustomerID, OrderCustomerName, OrderEmployee, OrderDate, OrderAmount, OrderPrice, OrderBill) " + "VALUES (@productId, @productName, @customerId, @customerName, @employeeName, @orderDate, @amount, @price, @totalBill)";
                using (SqlCommand command = new SqlCommand(insertOrderQuery, connection))
                {
                    command.Parameters.AddWithValue("@productId", productId); command.Parameters.AddWithValue("@productName", cbbOrProNa.Text);
                    command.Parameters.AddWithValue("@customerId", customerId); command.Parameters.AddWithValue("@customerName", cbbOrCusNa.Text);
                    command.Parameters.AddWithValue("@employeeName", cbbOrEmNa.Text); command.Parameters.AddWithValue("@orderDate", orderDate);
                    command.Parameters.AddWithValue("@amount", amount);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@totalBill", totalBill);

                    command.ExecuteNonQuery();
                }

                string updateProductQuery = "UPDATE Product SET Quantity = Quantity - @amount WHERE ProductID = @productId";
                using (SqlCommand command = new SqlCommand(updateProductQuery, connection))
                {
                    command.Parameters.AddWithValue("@amount", amount);
                    command.Parameters.AddWithValue("@productId", productId);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Add data successfully and update product quantity!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        //ORDER UPDATE

        private void btOrUp_Click(object sender, EventArgs e)
        {
            if (selectedOrderId == -1)
            {
                MessageBox.Show("Please select an order to update!", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int productId = int.Parse(tbOrProID.Text);
                string productName = cbbOrProNa.Text;
                int customerId = int.Parse(tbOrCusID.Text);
                string customerName = cbbOrCusNa.Text;
                int employeeId = (int)cbbOrEmNa.SelectedValue;
                DateTime orderDate = dtpkDate.Value;
                int newAmount = int.Parse(tbOrA.Text);
                decimal price = decimal.Parse(tbOrP.Text);
                decimal totalBill = decimal.Parse(tbTotalBill.Text);

                string connectionString = "Data Source=MSI\\MASTERMOS;Initial Catalog=TechnologyAccessories;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectOldAmountQuery = "SELECT OrderAmount FROM [Order] WHERE OrderID = @orderId AND OrderProductID = @productId";
                    int oldAmount;
                    using (SqlCommand command = new SqlCommand(selectOldAmountQuery, connection))
                    {
                        command.Parameters.AddWithValue("@orderId", selectedOrderId);
                        command.Parameters.AddWithValue("@productId", productId);
                        oldAmount = (int)command.ExecuteScalar();
                    }

                    string updateProductRestoreQuery = "UPDATE Product SET Quantity = Quantity + @oldAmount WHERE ProductID = @productId";
                    using (SqlCommand command = new SqlCommand(updateProductRestoreQuery, connection))
                    {
                        command.Parameters.AddWithValue("@oldAmount", oldAmount);
                        command.Parameters.AddWithValue("@productId", productId);
                        command.ExecuteNonQuery();
                    }

                    string checkQuantityQuery = "SELECT Quantity FROM Product WHERE ProductID = @productId";
                    int availableQuantity;
                    using (SqlCommand command = new SqlCommand(checkQuantityQuery, connection))
                    {
                        command.Parameters.AddWithValue("@productId", productId);
                        availableQuantity = (int)command.ExecuteScalar();
                    }

                    if (newAmount > availableQuantity)
                    {
                        MessageBox.Show("The quantity ordered exceeds the quantity available. Please enter a quantity less than or equal to: " + availableQuantity, "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string updateOrderQuery = "UPDATE [Order] SET OrderProductID = @productId, OrderProductName = @productName, OrderCustomerID = @customerId, " + "OrderCustomerName = @customerName, OrderEmployee = @employeeName, OrderDate = @orderDate, OrderAmount = @newAmount, " + "OrderPrice = @price, OrderBill = @totalBill WHERE OrderID = @orderId";
                    using (SqlCommand command = new SqlCommand(updateOrderQuery, connection))
                    {
                        command.Parameters.AddWithValue("@orderId", selectedOrderId);
                        command.Parameters.AddWithValue("@productId", productId);
                        command.Parameters.AddWithValue("@productName", cbbOrProNa.Text);
                        command.Parameters.AddWithValue("@customerId", customerId);
                        command.Parameters.AddWithValue("@customerName", cbbOrCusNa.Text);
                        command.Parameters.AddWithValue("@employeeName", cbbOrEmNa.Text);
                        command.Parameters.AddWithValue("@orderDate", orderDate);
                        command.Parameters.AddWithValue("@newAmount", newAmount);
                        command.Parameters.AddWithValue("@price", price);
                        command.Parameters.AddWithValue("@totalBill", totalBill);
                        command.ExecuteNonQuery();
                    }

                    string updateProductQuery = "UPDATE Product SET Quantity = Quantity - @newAmount WHERE ProductID = @productId";
                    using (SqlCommand command = new SqlCommand(updateProductQuery, connection))
                    {
                        command.Parameters.AddWithValue("@newAmount", newAmount);
                        command.Parameters.AddWithValue("@productId", productId);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Data update successful and product quantity update!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "From", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //ORDER DELETE

        private void btOrDel_Click(object sender, EventArgs e)
        {

            if (selectedOrderId == -1)
            {
                MessageBox.Show("Please select the order to delete.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = "Data Source=MSI\\MASTERMOS;Initial Catalog=TechnologyAccessories;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectOrderQuery = "SELECT OrderProductID, OrderAmount FROM [Order] WHERE OrderID = @orderId";
                    using (SqlCommand command = new SqlCommand(selectOrderQuery, connection))
                    {
                        command.Parameters.AddWithValue("@orderId", selectedOrderId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int productId = reader.GetInt32(0);
                                int amount = reader.GetInt32(1);

                                connection.Close();
                                connection.Open();

                                string updateProductRestoreQuery = "UPDATE Product SET Quantity = Quantity + @amount WHERE ProductID = @productId";
                                using (SqlCommand updateCommand = new SqlCommand(updateProductRestoreQuery, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@amount", amount);
                                    updateCommand.Parameters.AddWithValue("@productId", productId);
                                    updateCommand.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    connection.Close();
                    connection.Open();

                    string deleteOrderQuery = "DELETE FROM [Order] WHERE OrderID = @orderId";
                    using (SqlCommand command = new SqlCommand(deleteOrderQuery, connection))
                    {
                        command.Parameters.AddWithValue("@orderId", selectedOrderId);
                        command.ExecuteNonQuery();
                    }

                    lvOr.Items.Remove(lvOr.SelectedItems[0]);

                    MessageBox.Show("Delete data successfully and refund product quantity!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "From", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int selectedOrderId = -1;
        private void lvOr_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                int orderId = int.Parse(e.Item.SubItems[0].Text);
                btOrDel.Enabled = true;

                this.selectedOrderId = orderId;
            }
            else
            {
                btOrDel.Enabled = false;
                this.selectedOrderId = -1;
            }
        }

        //ORDER SEARCHING

        private DataTable originalOrDataTable;

        private void tbOrSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbOrSearch.Text.ToLower();
            lvOr.Items.Clear();
            foreach (DataRow row in originalOrDataTable.Rows)
            {
                bool match = row.ItemArray.Any(field => field.ToString().ToLower().Contains(searchText));
                if (match)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < originalOrDataTable.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    lvOr.Items.Add(item);
                }
            }
            if (string.IsNullOrEmpty(searchText))
            {
                LoadData();
            }
        }

        //ORDER SORTING

        private void lvOr_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewItemComparer sorter = lvOr.ListViewItemSorter as ListViewItemComparer;

            if (sorter == null)
            {
                sorter = new ListViewItemComparer(e.Column);
                lvOr.ListViewItemSorter = sorter;
            }
            if (e.Column == sorter.SortColumn)
            {
                sorter.Order = sorter.Order == Microsoft.Data.SqlClient.SortOrder.Ascending ? Microsoft.Data.SqlClient.SortOrder.Descending : Microsoft.Data.SqlClient.SortOrder.Ascending;
            }
            else
            {
                sorter.SortColumn = e.Column;
                sorter.Order = Microsoft.Data.SqlClient.SortOrder.Ascending;
            }
            lvOr.Sort();
        }

        //ORDER CHOOSING
        private void cbbOrProNa_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbOrA.Clear();

            if (cbbOrProNa.SelectedValue != null && cbbOrProNa.SelectedItem != null)
            {
                tbOrProID.Text = cbbOrProNa.SelectedValue.ToString();

                DataRowView selectedRow = cbbOrProNa.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    tbOrP.Text = selectedRow["Price"].ToString();
                }
            }
        }

        private void cbbOrCusNa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbOrCusNa.SelectedValue != null)
            {
                tbOrCusID.Text = cbbOrCusNa.SelectedValue.ToString();
            }
        }

        private void tbOrA_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(tbOrP.Text, out decimal price) && int.TryParse(tbOrA.Text, out int amount))
            {
                decimal totalBill = price * amount; tbTotalBill.Text = totalBill.ToString("0.00");
            }
            else
            {
                tbTotalBill.Text = "0.00";
            }
        }
        private void lvOr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvOr.SelectedItems.Count > 0)
            {
                ListViewItem item = lvOr.SelectedItems[0];
                tbOrProID.Text = item.SubItems[1].Text;
                cbbOrProNa.Text = item.SubItems[2].Text;
                tbOrCusID.Text = item.SubItems[3].Text;
                cbbOrCusNa.Text = item.SubItems[4].Text;
                cbbOrEmNa.Text = item.SubItems[5].Text;
                dtpkDate.Text = item.SubItems[6].Text;
                tbOrA.Text = item.SubItems[7].Text;
                tbOrP.Text = item.SubItems[8].Text;
                tbTotalBill.Text = item.SubItems[9].Text;
            }
        }

        private void tpMain_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!e.TabPage.Enabled)
            {
                MessageBox.Show("You do not have permission to access this tab.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void tbProQua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (tbProQua.Text.Length >= 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbProPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (tbProPrice.Text.Length >= 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (tbProPrice.Text.Length >= 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCusPh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (tbProPrice.Text.Length >= 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbEmPh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (tbProPrice.Text.Length >= 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbOrA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (tbProPrice.Text.Length >= 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
