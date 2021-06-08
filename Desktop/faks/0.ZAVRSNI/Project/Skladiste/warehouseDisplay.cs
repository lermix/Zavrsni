using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste
{
    public partial class warehouseDisplay : Form
    {
        List<DragButton> buttons = new List<DragButton>();

        public warehouseDisplay()
        {
            InitializeComponent();
            buttonControls.enableDrag = false;
            buttonControls.enableAdd = false;
            GraphicalInterfaceInfo.gui = panel1;
            GraphicalInterfaceInfo.guiButtons = new List<DragButton>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            buttonControls.enableAdd = true;
            foreach (var item in GraphicalInterfaceInfo.guiButtons)
            {
                Console.WriteLine(item.id);

            }

        }

        private void MouseClicked(object sender, MouseEventArgs e)
        {
            if (buttonControls.enableAdd)
            {
                DragButton btn = new DragButton();
                btn.Text = "test";
                if(buttons.Count == 0) { btn.id = 0; }
                else { btn.id = buttons.Max(button => button.id) + 1; btn.id++;  }
                GraphicalInterfaceInfo.guiButtons.Add(btn);
                btn.Location = new System.Drawing.Point(PointToClient(Cursor.Position).X, PointToClient(Cursor.Position).Y);
                this.Controls.Add(btn);
                btn.BringToFront();
                //btn.Image = System.Drawing.Image.FromFile(@"C:\Users\Alen\Desktop\faks\0.ZAVRSNI\images\container.png");

                buttonControls.enableAdd = false;
            }
            
        }

        private void btnDragEnable_Click(object sender, EventArgs e)
        {
            if (buttonControls.enableDrag)
            {
                buttonControls.enableDrag = false;
            }
            else
            {
                buttonControls.enableDrag = true;
            }

        }

        private void warehouseDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
