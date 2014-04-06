using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4 {
    public partial class SalesFormDialog : Form {
        private string saleName = "";
        private int saleValue = 0;

        private int currentOffset = 0;

        private DBAdaptor db;

        public SalesFormDialog(IWin32Window owner) {
            InitializeComponent();
            db = new DBAdaptor();
            redrawSales();

            if (this.ShowDialog(owner) == DialogResult.OK) {
                // HAHAHA
            }
            db.closeConnection();
            this.Dispose();
          
        }

        private void redrawSales() {
            prevBtn.Enabled = true;
            nextBtn.Enabled = true;
            if (currentOffset == 0) prevBtn.Enabled = false;
            saleBox.Controls.Clear();
            
            List<DataTypes.Sale> saleList = db.getSales(currentOffset, 12);
            foreach (DataTypes.Sale sale in saleList) {
                addSaleButton(sale.id, sale.name);
            }
            if (saleList.Count < 12) nextBtn.Enabled = false;
        }


        public void addSaleButton(int id, string name) {
            ButtonWithId btn = new ButtonWithId();
            btn.Width = 120;
            btn.Height = 50;
            btn.ItemId = id;
            btn.Text = name;
            btn.Click += (sender, evnt) => { saleClickCallback(((ButtonWithId)sender).ItemId); };

            // COULD GO OFF THE SCREEN
            Point lctn = saleBox.DisplayRectangle.Location;
            int initY = lctn.Y;
            int initX = 20;
            int row = (int)(saleBox.Controls.Count / 3);
            int col = saleBox.Controls.Count - (row * 3);
            lctn.Y = initY + row * 60;
            lctn.X = initX + col * 130;
            btn.Location = lctn;
            saleBox.Controls.Add(btn);
        }

        private void saleClickCallback(int id) {
            DataTypes.Sale sale = new DataTypes.Sale();
            if (id != 0) sale = db.getSaleById(id);
            saleValue = sale.value;
            saleName = sale.name;
            this.Dispose();
        }
      

        private void saleManualBtn_Click(object sender, EventArgs e) {
            NumericInputDialog nid = new NumericInputDialog(this);
            saleValue = (int) nid.getResult();
            saleName = "Custom sale";
            this.Dispose();
        }

        public int getSaleValue() {
            return saleValue;
        }

        public string getSaleName() {
            return saleName;
        }

        private void nextBtn_Click(object sender, EventArgs e) {
            currentOffset = currentOffset + 12;
            redrawSales();
        }

        private void prevBtn_Click(object sender, EventArgs e) {
            currentOffset = currentOffset - 12;
            if (currentOffset < 0) currentOffset = 0;
            redrawSales();
        }
    }
}
