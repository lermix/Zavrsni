using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Object that represents DragButton but as DragButton derives from Form.Button it has to 
    /// be in Form aplication where it is used as such. But to save it in database we don't need
    /// all button properties so we use this class to put DragButton to database
    /// </summary>
    public class DragButtonTransfer
    {
        public int Tag;
        public string Text;
        public string Name;
        public int Left;
        public int Top;
        public Enums.ButtonTypes Type;

    }
}
