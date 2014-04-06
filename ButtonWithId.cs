using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4 {
    public class ButtonWithId : Button {
        public int id;
        public int ItemId {
            get { return id; }
            set { id = value; }
        }
    }
}
