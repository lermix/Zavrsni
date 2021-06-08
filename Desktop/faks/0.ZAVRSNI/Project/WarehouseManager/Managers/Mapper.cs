using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Objects;

namespace WarehouseManager.Managers
{
    class Mapper
    {
        public static List<DragButton> mapTransferButtonsToDragButtons(List<DragButtonTransfer> transferButtons)
        {
            List<DragButton> returnList = new List<DragButton>();
            foreach (DragButtonTransfer btnTransfer in transferButtons)
            {
                DragButton btnDrag = new DragButton();
                btnDrag.Tag = btnTransfer.Tag;
                btnDrag.Text = btnTransfer.Text;
                btnDrag.Name = btnTransfer.Name;
                btnDrag.Left = btnTransfer.Left;
                btnDrag.Top = btnTransfer.Top;
                btnDrag.Type = btnTransfer.Type;
                returnList.Add(btnDrag);
            }

            return returnList;
        }

        public static DragButtonTransfer mapDragButtonToTransferButton(DragButton btnDrag)
        {            

                DragButtonTransfer btnTransfer = new DragButtonTransfer();
                btnTransfer.Tag = int.Parse(btnDrag.Tag.ToString());
                btnTransfer.Text = btnDrag.Text;
                btnTransfer.Name = btnDrag.Name;
                btnTransfer.Left = btnDrag.Left;
                btnTransfer.Top = btnDrag.Top;
                btnTransfer.Type = btnDrag.Type;                        

            return btnTransfer;
        }        


    }
}
