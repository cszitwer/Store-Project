using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreProject
{
    public partial class storeGUI : Form
    {
        User thisUser;
        DataClasses1DataContext db;
        decimal maxBalance = 50;
        DateTime date = new DateTime(2000, 1, 1, 0, 0, 0); //'2000-01-01 00:00:00.000'
        public storeGUI()
        {
            InitializeComponent();
            Tabs.TabPages.Remove(tabPage2);
            Tabs.TabPages.Remove(tabPage3);
            Tabs.TabPages.Remove(tabPage4);
            Tabs.TabPages.Remove(tabPage5);
        }
        

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (thisUser == null || !thisUser.loggedIn)
            {
                if(emailText != null && passwordText.Text != null)
                {
                    db = new DataClasses1DataContext();
                    var user = db.authorizedusers.Where(u => u.email == emailText.Text && u.userPassword == passwordText.Text);
                    if(user.Count() == 1)
                    {
                        Tabs.TabPages.Add(tabPage2);
                        Tabs.TabPages.Add(tabPage3);
                        Tabs.TabPages.Add(tabPage4);
                        Tabs.TabPages.Add(tabPage5);
                        successfulLogin.Text = "You are successfully logged in";
                        loginButton.Text = "Logout";
                        thisUser = new User(emailText.Text, passwordText.Text, user.First().id, user.First().balance ?? 0);
                        emailText.Text = null;
                        passwordText.Text = null;
                    }
                    else
                    {
                        successfulLogin.Text = "You entered invalid data";
                    }
                }
                else
                {
                    successfulLogin.Text = "Please fill out all fields";
                }
               
            }
            else
            {
                successfulLogin.Text = "You are successfully logged out";
                loginButton.Text = "Login";
                db.Dispose();
                thisUser = null;
                emailText.Text = null;
                passwordText.Text = null;
                Tabs.TabPages.Remove(tabPage2);
                Tabs.TabPages.Remove(tabPage3);
                Tabs.TabPages.Remove(tabPage4);
                Tabs.TabPages.Remove(tabPage5);

            }
        }

        private void Tabs_Click(object sender, EventArgs e)
        {
            var products = db.Items;
            TableLayoutPanel t = new TableLayoutPanel();
            if (Tabs.SelectedTab == tabPage2)
            {
                Tabs.SelectedTab.Controls.Clear();
                Label itemLabel = new Label();
                itemLabel.Text = "Items:";
                itemLabel.Font = new Font("Comic Sans", 10, FontStyle.Bold);
                t.Controls.Add(itemLabel, 0, 0);
                int row = 1;
                foreach (var product in products)
                {
                    t.AutoSize = true;
                    Label itemName = new Label();
                    itemName.Text = product.itemName;
                    itemName.Font = new Font("Comic Sans", 12, FontStyle.Regular);
                    itemName.AutoSize = true;
                    Label itemCost = new Label();
                    itemCost.Text = "$ " + product.itemCost;
                    itemCost.Font = new Font("Comic Sans", 12, FontStyle.Regular);
                    t.Controls.Add(itemName, 0, row);
                    t.Controls.Add(itemCost, 1, row);
                    Button btn = new Button();
                    btn.Text = "Add to cart";
                    t.Controls.Add(btn, 2, row);
                    btn.Click += new EventHandler((b, clickEvent) => AddToCart(b, clickEvent, product.id));
                    row++;

                }
                Tabs.SelectedTab.Controls.Add(t);
            }
            if (Tabs.SelectedTab == tabPage3)
            {
                Tabs.SelectedTab.Controls.Clear();
                t = new TableLayoutPanel();
                Label cartLabel = new Label();
                cartLabel.Text = "My Cart:";
                cartLabel.Font = new Font("Comic Sans", 10, FontStyle.Bold);
                t.Controls.Add(cartLabel, 0, 0);
                int row = 1; 
                if (thisUser != null && thisUser.loggedIn)
                {
                    var query = db.orders.Where(o => o.customerID == thisUser.userId && o.datePurchased == date);

                    decimal total = 0;
                    foreach(var order in query)
                    {
                        Label lbl = new Label();
                        lbl.AutoSize = true;
                        lbl.Text += order.Item.itemName + " " + order.Item.itemCost + " " + order.quantity;

                        t.Controls.Add(lbl, 0, row);
                        Button btn = new Button();
                        btn.Text = "Remove";
                        t.Controls.Add(btn, 1, row++);
                        btn.Click += new EventHandler((b, clickEvent) => RemoveFromCart(b, clickEvent, order.ItemID));
                        total += order.Item.itemCost;
                    }
                    Label balancelbl = new Label();
                    balancelbl.Text = "Balance: " + thisUser.userBalance;
                    balancelbl.Font = new Font("Comic Sans", 10, FontStyle.Bold);
                    balancelbl.AutoSize = true;
                    TextBox amount = new TextBox();
                    Button paybill = new Button();
                    paybill.Text = "Pay Bill";
                    paybill.Click += new EventHandler((b, clickEvent) => PayBill(b, clickEvent, amount));
                                        
                    t.Controls.Add(balancelbl, 4, 0);
                    t.Controls.Add(amount, 4, 1);
                    t.Controls.Add(paybill, 4, 2);
                    
                    Button purchaseButton = new Button();
                    purchaseButton.Text = "Purchase";
                    Label unsucessfulPurchase = new Label();
                    t.Controls.Add(unsucessfulPurchase, 0, row + 1);
                    purchaseButton.Click += new EventHandler((b, clickEvent) => PurchaseOrder(b, clickEvent, total, unsucessfulPurchase));
                    t.Controls.Add(purchaseButton, 0, row);
                    t.AutoSize = true;
                    Tabs.SelectedTab.Controls.Add(t);
                }
            }
            if(Tabs.SelectedTab == tabPage4)
            {
                Tabs.SelectedTab.Controls.Clear();
                t = new TableLayoutPanel();
                var orders = db.orders.Where(o => o.customerID == thisUser.userId && o.datePurchased != date).GroupBy( o => o.datePurchased);
                int row = 0;
                foreach(var po in orders)
                {
                    Label purchaseOrder = new Label();
                    purchaseOrder.Text = "\nPurchase Order on date: " + po.Key;
                    purchaseOrder.Font = new Font("Comic Sans", 10, FontStyle.Bold);
                    purchaseOrder.AutoSize = true;
                    t.Controls.Add(purchaseOrder, 0, row++);
                    decimal total = 0; 
                    foreach (var order in po)
                    {
                        Label orderInfo = new Label();
                        orderInfo.Text = order.quantity + " " + order.Item.itemName;
                        orderInfo.AutoSize = true;
                        orderInfo.Font = new Font("Comic Sans", 10, FontStyle.Regular);
                        total += order.Item.itemCost * order.quantity;
                        t.Controls.Add(orderInfo, 0, row++);
                    }
                    Label totalPurchasePrice = new Label();
                    totalPurchasePrice.Text = "Total Purchase Cost: " + total;
                    totalPurchasePrice.AutoSize = true;
                    totalPurchasePrice.Font = new Font("Comic Sans", 8, FontStyle.Italic);
                    t.Controls.Add(totalPurchasePrice, 0, row++);
                    
                }
                t.AutoSize = true;
                tabPage4.AutoScroll = true;
                Tabs.SelectedTab.Controls.Add(t);

            }
            if(Tabs.SelectedTab == tabPage5)
            {
                splitContainer2.Panel2.Controls.Clear();
                splitContainer2.Panel1.Controls.Clear();
                t = new TableLayoutPanel();
                TableLayoutPanel t2 = new TableLayoutPanel();

                t.AutoSize = true;
                t2.AutoSize = true;

                TextBox date1 = new TextBox();
                TextBox date2 = new TextBox();
                t.Controls.Add(date1, 0, 0);
                t.Controls.Add(date2, 1, 0);
                Button dateRange = new Button();
                dateRange.Text = "Within Date Range";
                dateRange.AutoSize = true;
                dateRange.Click += new EventHandler((b, buttonClick) => GetDateRange(b, buttonClick, date1.Text, date2.Text, t, dateRange));
                t.Controls.Add(dateRange, 0, 1);
                splitContainer2.Panel1.Controls.Add(t);

                TextBox price1 = new TextBox();
                TextBox price2 = new TextBox();
                t2.Controls.Add(price1, 0, 0);
                t2.Controls.Add(price2, 1, 0);
                Button priceRange = new Button();
                priceRange.Text = "Within price range";
                priceRange.AutoSize = true;
                priceRange.Click += new EventHandler((b, buttonClick) => GetPriceRange(b, buttonClick, price1.Text, price2.Text, t2, priceRange));
                t2.Controls.Add(priceRange, 0, 1);
                splitContainer2.Panel2.Controls.Add(t2);

            

            }
            

        }

        private void GetPriceRange(object b, EventArgs buttonClick, string text1, string text2, TableLayoutPanel t2, Button p)
        {
            t2.Controls.Remove(p);
            var ordersPutTogether = db.orders.Where(o => o.customerID == thisUser.userId && o.datePurchased != date).GroupBy(o => o.datePurchased);
            var item = db.Items;
            int row = 4; 
            foreach(var purchaseOrder in ordersPutTogether)
            {
                decimal total = 0;
                foreach(var po in purchaseOrder)
                {
                    decimal price = item.Where(i => i.id == po.ItemID).First().itemCost;
                    total += po.quantity * price;
                }
                if (total >= Decimal.Parse(text1) && total <= Decimal.Parse(text2))
                {
                    Label orderLabel = new Label();
                    orderLabel.Text = "Purchase Order on date: " + purchaseOrder.Key + " " + "Price: " + total;
                    orderLabel.AutoSize = true;
                    t2.Controls.Add(orderLabel, 0, row++);
                }
            }
            splitContainer2.Panel2.Controls.Add(t2);
            splitContainer2.Panel2.AutoScroll = true;

        }

        private void GetDateRange(object b, EventArgs buttonClick, String date1, String date2, TableLayoutPanel t1,Button daterange)
        {
            t1.Controls.Remove(daterange);
            var ordersPutTogether = db.orders.Where(o => o.customerID == thisUser.userId && o.datePurchased <= DateTime.Parse(date2) && o.datePurchased >= DateTime.Parse(date1)).GroupBy(o => o.datePurchased);
            int row = 4;
            foreach(var orderDate in ordersPutTogether)
            {
                Label orderLabel = new Label();
                orderLabel.Text = "Purchase Order on date: " + orderDate.Key;
                orderLabel.AutoSize = true;
                t1.Controls.Add(orderLabel, 0, row++);
            }
            splitContainer2.Panel1.Controls.Add(t1);
            splitContainer2.Panel1.AutoScroll = true;
        }

        private void PayBill(object b, EventArgs clickEvent, TextBox amount)
        {
            if(amount.Text != "")
            {
                db.authorizedusers.Where(i => i.id == thisUser.userId).First().balance -= Convert.ToDecimal(amount.Text);
                db.SubmitChanges();
                thisUser.userBalance -= Convert.ToDecimal(amount.Text);
            }
        }

        private void PurchaseOrder(object b, EventArgs clickEvent, decimal total, Label unsucessfulPurchase)
        {
            if(!(thisUser.userBalance > maxBalance))
            {
                var orders = db.orders.Where(o => o.customerID == thisUser.userId && o.datePurchased == date);
                DateTime today = DateTime.Now;
                decimal cost = 0;
                foreach (var o in orders)
                {
                    int itemId = o.ItemID;
                    int quantity = o.quantity;
                    db.orders.DeleteOnSubmit(o);
                    order newOrder = new order()
                    {
                        customerID = thisUser.userId,
                        ItemID = itemId,
                        quantity = quantity,
                        datePurchased = today
                    };
                    db.orders.InsertOnSubmit(newOrder);
                    cost += o.Item.itemCost * quantity;
                    db.SubmitChanges();

                }
                thisUser.userBalance += cost;
                db.SubmitChanges();

            }
            else
            {
                unsucessfulPurchase.Text = "Your balance is over the max balance\n which is " + maxBalance;
                unsucessfulPurchase.AutoSize = true;
            }
        }

        private void AddToCart(Object sender, EventArgs e, int product)
        {
            
            var orderItem = db.orders.Where(o => o.customerID == thisUser.userId && o.ItemID == product && o.datePurchased == date);
            int quantity = 1;
            if (orderItem.Count() > 0)
            {
                quantity = orderItem.First().quantity + 1;
                db.orders.DeleteOnSubmit(orderItem.First());
            }

            try
            {
                order newOrder = new order()
                {
                    customerID = thisUser.userId,
                    ItemID = product,
                    quantity = quantity,
                    datePurchased = date
                };

                db.orders.InsertOnSubmit(newOrder);
                db.SubmitChanges();
            }
            catch { };
            
        }

        private void RemoveFromCart(Object sender, EventArgs e, int product)
        {
            
            var orders = db.orders;
            var deleteItem = orders.Where(o => o.customerID == thisUser.userId && o.ItemID == product);
            try
            {
                db.orders.DeleteOnSubmit(deleteItem.First());
                db.SubmitChanges();
            }
            catch { };

        }

      
    }
}
