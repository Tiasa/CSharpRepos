using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4 {
    class DataTypes {

        public class Good {
            public int id;
            public string name;
            public string imageURL;
            public double price;
        }

        public class Sale {
            public int id;
            public string name;
            public int value;
        }

    }
}
