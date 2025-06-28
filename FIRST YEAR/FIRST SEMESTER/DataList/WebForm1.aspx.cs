using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static DataList.WebForm1;

namespace DataList
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        // Product class definition
        public class Product
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        // Simulated data source
        private static List<Product> products = new List<Product>
        {
            new Product { ID = 1, Name = "Product 1", Price = 10.00M },
            new Product { ID = 2, Name = "Product 2", Price = 20.00M },
            new Product { ID = 3, Name = "Product 3", Price = 15.00M }
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }

        private void BindData()
        {
            ProductDataList.DataSource = products;
            ProductDataList.DataBind();
        }

        protected void ProductDataList_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                // Set the edit item index to the selected item's index
                ProductDataList.EditItemIndex = e.Item.ItemIndex;
                BindData();
            }
            else if (e.CommandName == "Update")
            {
                // Get the updated values from the edit template
                TextBox txtName = (TextBox)e.Item.FindControl("txtName");
                TextBox txtPrice = (TextBox)e.Item.FindControl("txtPrice");
                Label lblIDEdit = (Label)e.Item.FindControl("lblIDEdit");

                if (txtName != null && txtPrice != null && lblIDEdit != null)
                {
                    int id = Convert.ToInt32(lblIDEdit.Text);
                    string name = txtName.Text;
                    decimal price = 0;
                    
                    // out price means, the result from parsing to decimal will be put in 'price' variable
                    if (decimal.TryParse(txtPrice.Text, out price))
                    {
                        // Update the product in the list
                        Product product = products.FirstOrDefault(p => p.ID == id);
                        if (product != null)
                        {
                            product.Name = name;
                            product.Price = price;
                        }

                        Label1.Text = "Product updated successfully!";
                    }
                    else
                    {
                        Label1.Text = "Invalid price value!";
                    }
                }

                // Reset edit item index and rebind data
                ProductDataList.EditItemIndex = -1;
                BindData();
            }
            else if (e.CommandName == "Cancel")
            {
                // Cancel edit mode
                ProductDataList.EditItemIndex = -1;
                BindData();
            }
        }

        protected void ProductDataList_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            // Optional: Additional logic during item data binding, if required
        }

    }
}
