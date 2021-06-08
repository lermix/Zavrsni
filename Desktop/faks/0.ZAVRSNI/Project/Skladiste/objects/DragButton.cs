using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste
{
    class DragButton:Button
    {
        public int id { get; set; }   

        public DragButton()
        {
            MouseDown += DragButton_MouseDown;
            MouseMove += DragButton_MouseMove;
        }

        Point buttonStartPoint { get; set; }

        void DragButton_MouseDown(object sender, MouseEventArgs mouseData)
        {
            buttonStartPoint = mouseData.Location;
        }

        void DragButton_MouseMove(object sender, MouseEventArgs mouseData)
        {
            if (mouseData.Button == MouseButtons.Left && buttonControls.enableDrag)
            {
                int left = 0; //distance between button and left end of panel
                if (this.Left >= 0 && this.Right <= GraphicalInterfaceInfo.gui.Width+10)
                    left = this.Left + (mouseData.X - buttonStartPoint.X); 

                left = Math.Min(GraphicalInterfaceInfo.gui.Width - this.Width, left); //if left > max left set as max left
                left = Math.Max(10, left); //must be greater than 10 so there is some space between button and end of panel
                this.Left = left;
            }
            if (mouseData.Button == MouseButtons.Left && buttonControls.enableDrag)
            {
                int top = 0; //distance between button and top of panel
                if (this.Top >= 0 && this.Bottom <= GraphicalInterfaceInfo.gui.Height + 10)
                    top = this.Top + (mouseData.Y - buttonStartPoint.Y);

                top = Math.Min(GraphicalInterfaceInfo.gui.Height - this.Height, top); //if top > max top set as max top
                top = Math.Max(0, top);//must be greater than 10 so there is some space between button and end of panel
                this.Top = top + 10;
            }
        }

    }

    
}
