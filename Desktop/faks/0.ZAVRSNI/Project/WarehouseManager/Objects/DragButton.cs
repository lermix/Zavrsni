using Microsoft.VisualBasic.Compatibility.VB6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WarehouseManager.Controlers;
using Models;


namespace WarehouseManager.Objects
{
    /// <summary>
    /// Button tag is used to save ID
    /// </summary>
    class DragButton : Button
    {        
        private Point buttonStartPoint { get; set; }        
        public Enums.ButtonTypes Type { get; set; }            

        public DragButton(Enums.ButtonTypes type)
        {
            this.Type = type;
            buttonStartPoint = this.Location;
            
            MouseMove += DragButton_MouseMove;
            
        }

        public DragButton()
        {
            buttonStartPoint = this.Location;

            MouseMove += DragButton_MouseMove;
        }


        void DragButton_MouseMove(object sender, MouseEventArgs mouseData)
        {
            if (mouseData.Button == MouseButtons.Left && ButtonControl.enableDrag)
            {
                //LEFT RIGHT
                int left = 0; //distance between button and left end of panel
                if (this.Left >= 0 && this.Right <= PropertiesControl.GUI.Width + 10)
                    left = this.Left + (mouseData.X - buttonStartPoint.X);

                left = Math.Min(PropertiesControl.GUI.Width - this.Width, left); //if left > max left set as max left
                left = Math.Max(0, left); //must be greater than 0 so there is some space between button and end of panel
                this.Left = left;

                //UP DOWN
                int top = 0; //distance between button and top of panel
                if (this.Top >= 0 && this.Bottom <= PropertiesControl.GUI.Height + 10)
                    top = this.Top + (mouseData.Y - buttonStartPoint.Y);

                top = Math.Min(PropertiesControl.GUI.Height - this.Height, top); //if top > max top set as max top
                top = Math.Max(0, top);//must be greater than 0 so there is some space between button and end of panel
                this.Top = top ;
            }
        }
    }
}
