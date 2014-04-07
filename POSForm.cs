using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace WindowsFormsApplication4 {
    public partial class POSForm : Form {
        private StringReader myReader;
        private DBAdaptor db;
        private List<DataTypes.Good> currentOrder;
        private int currentSale = 0;
        private int currentSaleIndexInReceipt = -1; // NOT THERE YET
        private int currentOffset = 0;
        private int currentBevOffset = 0;
        public POSForm() {

            InitializeComponent();
            button4.Enabled = false;
            button4.Visible = false;
            button5.Enabled = false;
            button5.Visible = false;
            button6.Enabled = false;
            button6.Visible = false;
            db = new DBAdaptor();
            drawGoods();
            currentOrder = new List<DataTypes.Good>();
            /*
            List<DataTypes.Good> itemsList = db.getAllItems();
            
            foreach (DataTypes.Good goodey in itemsList) {
                addGoodButton(goodey.id, goodey.imageURL);
            }
            */
        }

        public void addGoodButton(int id, string imageURL, string name) {
            ButtonWithId btn = new ButtonWithId();
            if (imageURL == "") imageURL = @"C:\Users\Tiasa Mondol\Pictures\Capture.JPG";
            btn.Image = Image.FromFile(imageURL);
           
            btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn.Width = 120;
            btn.Height = 120;
            btn.ItemId = id;
            btn.Text=name;
            btn.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            btn.Click += (sender, evnt) => { itemClickCallback(((ButtonWithId)sender).ItemId); };

            // Doesn't go off screen now
            Point lctn = goodsBox.DisplayRectangle.Location;
            int initY = lctn.Y;
            int initX = 30;
            int row = (int)(goodsBox.Controls.Count / 5);
            int col = goodsBox.Controls.Count - (row*5);
            lctn.Y = initY + row * 130;
            lctn.X = initX + col * 130;
            btn.Location = lctn;

            goodsBox.Controls.Add(btn);
        }

        private void drawGoods()
        {
            button2.Enabled = true;
            button3.Enabled = true;
            if (currentOffset == 0) button2.Enabled = false;
            goodsBox.Controls.Clear();

            List<DataTypes.Good> itemsList = db.getGoods(currentOffset,20);

            foreach (DataTypes.Good goodey in itemsList)
            {
                addGoodButton(goodey.id, goodey.imageURL, goodey.name);
            }
            if (itemsList.Count < 20) button3.Enabled = false;
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            currentOffset = currentOffset + 20;
            drawGoods();
        }

       private void button2_Click_1(object sender, EventArgs e)
        {
            currentOffset = currentOffset - 20;
            if (currentOffset < 0) currentOffset = 0;
            drawGoods();
        }
       private void drawBeverage()
       {
           button4.Enabled = true;
           button5.Enabled = true;
           if (currentBevOffset == 0) button4.Enabled = false;
           goodsBox.Controls.Clear();

           List<DataTypes.Good> itemsList = db.getBeverage(currentBevOffset, 20);

           foreach (DataTypes.Good goodey in itemsList)
           {
               addGoodButton(goodey.id, goodey.imageURL, goodey.name);
           }
           if (itemsList.Count < 20) button5.Enabled = false;
       }
        // SALE PANEL
        private void btnSale_Click(object sender, EventArgs e) {
            SalesFormDialog sfd = new SalesFormDialog(this);
            if (sfd.getSaleValue() <= 0) {
                // CANCELLED
                MessageBox.Show("No Sale Selected");
                return;
            } else if (sfd.getSaleValue() > 100) {
                // CHECK FOR > 100  - MEANS DB CRAZEH
                MessageBox.Show("DB ERROR");
                return;
            }
            if (currentSaleIndexInReceipt != -1) {
                recieptListBox.Items.RemoveAt(currentSaleIndexInReceipt);
            }

            currentSale = sfd.getSaleValue();
            currentSaleIndexInReceipt = recieptListBox.Items.Add(sfd.getSaleName() + ", " + sfd.getSaleValue() + "%");
            recalculateTotal();
        }


        private void goodManualBtn_Click(object sender, EventArgs e) {
            NumericInputDialog nid = new NumericInputDialog(this);
            DataTypes.Good goodey = db.getItemById((int)nid.getResult());
            if (goodey != null) {
                // DO MAGIC HERE AS WELL
                MessageBox.Show(goodey.name);
            } else MessageBox.Show("Item not found!");
        }

        private void button1_Click(object sender, EventArgs e) {
            button2.Enabled = false;
            button2.Visible = false;
            button3.Enabled = false;
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button6.Enabled = true;
            currentBevOffset = 0;
            drawBeverage();
        }

        private void itemClickCallback(int id) {
            // THIS FUNCTION IS CALLED WHENEVER USER CLICKS THE ITEM BUTTON
            DataTypes.Good item = db.getItemById(id);
            currentOrder.Add(item);
            recieptListBox.Items.Add(item.name + "     " + item.price);
            recalculateTotal();
            //MessageBox.Show("You clicked " + id);
        }

        private void recalculateTotal() {
            double total = 0;
            foreach (DataTypes.Good thingy in currentOrder) {
                total += thingy.price;
            }
            if (currentSale != 0) total = total - (total / 100 * currentSale);
            printButton.Text = "Total: " + total;
        }

        private void printButton_Click(object sender, EventArgs e) {
            // SAVE CURRENT ORDER TO DB
            db.saveOrder(currentOrder, currentSale);
            currentOrder = new List<DataTypes.Good>();
            currentSale = 0;
            currentSaleIndexInReceipt = -1; // NO SALE FOR YOU
            recieptListBox.Items.Clear();
        }

        private void btnDelLast_Click(object sender, EventArgs e) {
            if (currentOrder.Count == 0) return;
            currentOrder.RemoveAt(currentOrder.Count-1);
            // RECALCULATE SALE ITEM POSITION IN RECIEPT!!!
            redrawReciept();
        }

        private void redrawReciept() {
            string currentSaleString = recieptListBox.Items[currentSaleIndexInReceipt].ToString();
            recieptListBox.Items.Clear();
            foreach (DataTypes.Good thingy in currentOrder) {
                recieptListBox.Items.Add(thingy.name + "     " + thingy.price);
            }
            recieptListBox.Items.Add(currentSaleString);

            recalculateTotal();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentBevOffset = currentBevOffset - 20;
            if (currentBevOffset < 0) currentBevOffset = 0;
            drawBeverage();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentBevOffset = currentBevOffset + 20;
            drawBeverage();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button1.Enabled = true;
            button4.Enabled = false;
            button4.Visible = false;
            button5.Enabled = false;
            button5.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            button6.Visible = false;
            button6.Enabled = false;
            currentOffset = 0;
            drawGoods();
        }

       protected void printDocument1_PrintPage(object sender,System.Drawing.Printing.PrintPageEventArgs ev)
  {
      float linesPerPage = 0;
      float yPosition = 0;
      int count = 0;
      float leftMargin = ev.MarginBounds.Left;
      float topMargin = ev.MarginBounds.Top;
      string line = null;
     Font printFont = this.recieptListBox.Font;
     SolidBrush myBrush = new SolidBrush(Color.Black);
 
     // Work out the number of lines per page, using the MarginBounds.
      linesPerPage =
         ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

     // Iterate over the string using the StringReader, printing each line.
      while (count < linesPerPage && ((line = myReader.ReadLine()) != null))
     {
         // calculate the next line position based on
         // the height of the font according to the printing device
          yPosition = topMargin + (count * printFont.GetHeight(ev.Graphics));
 
         // draw the next line in the rich edit control
  
         ev.Graphics.DrawString(line, printFont,
                                myBrush, leftMargin,
                                yPosition, new StringFormat());
         count++;
     }
 
     // If there are more lines, print another page.
     if (line != null)
         ev.HasMorePages = true;
     else
         ev.HasMorePages = false;
 
     myBrush.Dispose();
 }

        
        

        

        
         

    }
}
