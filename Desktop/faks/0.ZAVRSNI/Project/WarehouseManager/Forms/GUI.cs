using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManager.Controlers;
using WarehouseManager.Objects;
using WarehouseManager.DataHolders;
using DatabaseManagers;
using WarehouseManager.Managers;
using Models;
using System.Drawing.Drawing2D;

namespace WarehouseManager.Forms
{
    public partial class GUI : Form
    {

        //Collection buttons
        /// <summary>
        /// Dictionary<ollectionButtonId, UnitButtons>
        /// Starting display is first index rest are all collectionButtons(buttons that contain buttons)
        /// Starting display is treated as collectionButton
        /// </summary>
        Dictionary<int, List<DragButton>> collectionButtons;

        //AllButtonsBuutns
        Dictionary<int, DragButton> allButtons;

        /// <summary>
        /// Contains ID-s of buttons pressed, at the top is last pressed button.
        /// If stack count is 1 then use starting collection.
        /// At key 0 is starting collection      
        /// </summary>
        Stack<int> buttonsStack;

        bool searchActive;


        public GUI()
        {
            InitializeComponent();

            //When enabled buttons can be draged
            ButtonControl.enableDrag = false;
            //When enabled allow creating new buutons upon clicking on GUI panel
            ButtonControl.enableAdd = false;

            //Define what is used for GUI 
            Controlers.PropertiesControl.GUI = panelGUI;

            //Push default GUI
            buttonsStack = new Stack<int>();
            buttonsStack.Push(0);
            lblCurrentButtonID.Text = "default/";

            //Create collection buttons instance
            collectionButtons = new Dictionary<int, List<DragButton>>();

            allButtons = new Dictionary<int, DragButton>();

            
            

        }

        private void GUI_Load(object sender, EventArgs e)
        {
            //Get all buttons
            List<DragButton> allDragButtons = new List<DragButton>();
            try
            {
                allDragButtons = Mapper.mapTransferButtonsToDragButtons(ButtonsClient.GetButtons());
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to get units from database");
            }
             
            foreach (DragButton item in allDragButtons)
            {
                //Add mouseDown event 
                if (item.Type.ToString() == "Unit") //For unit
                {
                    item.MouseDown += unitPressed;
                }
                else //For collection
                {
                    item.MouseDown += collectionPressed;
                    collectionButtons.Add(int.Parse(item.Tag.ToString()), new List<DragButton>());
                }
                
                allButtons.Add(int.Parse(item.Tag.ToString()), item);                                                                                
            }

            //Get Collection buttons and create collection button map
            try
            {
                foreach (ButtonConnection buttonConnection in ButtonsClient.GetButtonConnections())
                {
                    //Colection button list doesn't contain this collection
                    if (!collectionButtons.Select(elem => elem.Key).Contains(buttonConnection.CollectionButtonId))
                    {
                        //Add this collection to collection list 
                        collectionButtons.Add(buttonConnection.CollectionButtonId, new List<DragButton>());
                    }

                    //Check if unit button exist
                    if (allButtons.Select(elem => elem.Key).Contains(buttonConnection.UnitButtonID))
                    {
                        //Add connected unit to that collection
                        collectionButtons[buttonConnection.CollectionButtonId].Add(allButtons[buttonConnection.UnitButtonID]);
                    }
                    else
                    {
                        MessageBox.Show("Fatal error: unit lost (No unit was found with that connection)");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error fetching collectiong buttons");
            }
            

            foreach (DragButton item in collectionButtons[0])
            {
                //Add button to panel [display it]
                panelGUI.Controls.Add(item);
                item.BringToFront();
            }

            //Remove back button
            btnBackFromChild.Visible = false;

            //Disable cmbFound
            cmbFoundProducts.Enabled = false;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBoxAddName.Text) || string.IsNullOrEmpty(cmbAddType.Text))
            {
                MessageBox.Show("All fields must be added");
            }
            else
            {
                ButtonControl.enableAdd = true;
            }
        }

        //Mouse clicked inside GUI panel, create dragButton object
        private void MouseClicked(object sender, MouseEventArgs e)
        {
            if (ButtonControl.enableAdd)
            {
                int btnId;
                if (allButtons.Count!=0)
                {
                    btnId = allButtons.Keys.Max() > collectionButtons.Keys.Max() ? allButtons.Keys.Max() + 1 : collectionButtons.Keys.Max() + 1;
                }
                else
                {
                    btnId = collectionButtons.Keys.Max() + 1;
                }

                //Creating StorageCollection button
                if (cmbAddType.Text == "Storage collection")
                {                                       
                    //Create collection button
                    DragButton dragButton = new DragButton(Enums.ButtonTypes.Collection);
                    dragButton.Text = tBoxAddName.Text;
                    dragButton.Name = "btnCollection_" + btnId.ToString();
                    dragButton.Tag = btnId;
                    dragButton.Location = new System.Drawing.Point(PointToClient(Cursor.Position).X, PointToClient(Cursor.Position).Y);
                    dragButton.MouseDown += collectionPressed; //When button is clicked

                    //Add button to panel [display it]
                    panelGUI.Controls.Add(dragButton);
                    dragButton.BringToFront();                    

                    //Add button to it's collection  [to all btns]
                    collectionButtons[buttonsStack.Peek()].Add(dragButton);

                    //Create this button collection [this collection]
                    collectionButtons.Add(btnId, new List<DragButton>());

                    //Add to all buttns [database]
                    try{ButtonsClient.AddButtonToAllButtons(Mapper.mapDragButtonToTransferButton(dragButton));}
                    catch (Exception){MessageBox.Show("Failed to add to database");}

                    //Add to all buttons [holder]
                    allButtons.Add(btnId, dragButton);

                    //Create new connnection
                    ButtonConnection connection = new ButtonConnection
                    {
                        ConnectionID = ButtonConnectionHolder.connections.Count == 0 ? 0 : ButtonConnectionHolder.connections.Max(elem => elem.ConnectionID) + 1,
                        CollectionButtonId = buttonsStack.Peek(),
                        UnitButtonID = btnId
                    };

                    //Add connection to database, so we know in which layer it is [database]
                    try
                    {
                        ButtonsClient.AddButtonConnection(connection);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Failed to add to database");
                    }
                    

                    //Add connection to connection holder
                    ButtonConnectionHolder.connections.Add(connection);

                    //Push on stack [stack]
                    buttonsStack.Push(btnId);

                    panelGUI.Controls.Clear();

                    //make backbtn visible
                    btnBackFromChild.Visible = true;
                }
                else
                {                   
                    //Create Unit button
                    DragButton dragButton = new DragButton(Enums.ButtonTypes.Unit);
                    dragButton.Text = tBoxAddName.Text;
                    dragButton.Name = "btnUnit_" + btnId.ToString();
                    dragButton.Tag = btnId;
                    dragButton.Location = new System.Drawing.Point(PointToClient(Cursor.Position).X, PointToClient(Cursor.Position).Y);
                    dragButton.MouseDown += unitPressed; //When button is clicked
                 
                    //Add button to panel [display it]
                    panelGUI.Controls.Add(dragButton);
                    dragButton.BringToFront();

                    //Add UnitButton to it's collectionButton [list]
                    collectionButtons[buttonsStack.Peek()].Add(dragButton);

                    //Add button to allButtons [list]
                    allButtons.Add(btnId, dragButton);

                    //Add button to database, all buttons table [database]
                    try
                    {
                        ButtonsClient.AddButtonToAllButtons(Mapper.mapDragButtonToTransferButton(dragButton));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Failed to add to database");
                    }


                    //Create new connnection
                    ButtonConnection connection = new ButtonConnection
                    {
                        ConnectionID = ButtonConnectionHolder.connections.Count == 0 ? 0 : ButtonConnectionHolder.connections.Max(elem => elem.ConnectionID) + 1,
                        CollectionButtonId = buttonsStack.Peek(),
                        UnitButtonID = btnId
                    };

                    try
                    {
                        //Add connection to database, so we know in which layer it is [database]
                        ButtonsClient.AddButtonConnection(connection);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Failed to add to database");
                    }                                        

                    //Add connection to connection holder [Holder]
                    ButtonConnectionHolder.connections.Add(connection);

                }                                                

                
                //btn.Image = System.Drawing.Image.FromFile(@"C:\Users\Alen\Desktop\faks\0.ZAVRSNI\images\container.png");
                ButtonControl.enableAdd = false;                
            }
        }

        private void collectionPressed(object sender, MouseEventArgs e)
        {
            if (!ButtonControl.enableDrag)
            {
                if (!ButtonControl.enableDelete)
                {
                    int btnId = (int)((Button)sender).Tag;
                    buttonsStack.Push(btnId);

                    panelGUI.Controls.Clear();

                    foreach (var item in collectionButtons[btnId])
                    {
                        panelGUI.Controls.Add(item);
                    }

                    btnBackFromChild.Visible = true;

                    lblCurrentButtonID.Text = "";
                    foreach (int id in buttonsStack)
                    {                        
                        lblCurrentButtonID.Text += ($"/{allButtons[id].Text}");
                    }

                    if (searchActive)
                    {
                        Search();
                    }
                }
                else
                {
                    DragButton btnPressed = (DragButton)sender;
                    DialogResult dialogResult = MessageBox.Show("Delete?", btnPressed.Name, MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        if (collectionButtons[int.Parse(btnPressed.Tag.ToString())].Count > 0)
                        {
                            MessageBox.Show("To delete collection you must first delete all units it contains");
                            return;
                        }
                        try
                        {
                            ButtonsClient.DeleteButtonConnection(int.Parse(btnPressed.Tag.ToString()));
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Failed to delete");
                        }

                        allButtons.Remove(int.Parse(btnPressed.Tag.ToString()));
                        collectionButtons[buttonsStack.Peek()].Remove(btnPressed);
                        panelGUI.Controls.Remove(btnPressed);

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }                
            }
            
        }

        private void unitPressed(object sender, MouseEventArgs e)
        {
            if (!ButtonControl.enableDrag)
            {
                if (!ButtonControl.enableDelete)
                {
                    DragButton btnPressed = (DragButton)sender;

                    this.Hide();
                    //Send pressed button ID
                    StorageUnitTable unitTable = new StorageUnitTable(int.Parse(btnPressed.Tag.ToString()));
                    unitTable.Location = this.Location;
                    unitTable.StartPosition = this.StartPosition;
                    unitTable.FormClosing += delegate { this.Show(); };
                    unitTable.ShowDialog();
                }
                else
                {
                    DragButton btnPressed = (DragButton)sender;
                    DialogResult dialogResult = MessageBox.Show("Delete?", btnPressed.Name, MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        try
                        {
                            ButtonsClient.DeleteButtonConnection(int.Parse(btnPressed.Tag.ToString()));
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Failed to delete");
                        }
                        
                        allButtons.Remove(int.Parse(btnPressed.Tag.ToString()));
                        collectionButtons[buttonsStack.Peek()].Remove(btnPressed);
                        panelGUI.Controls.Remove(btnPressed);

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    
                }                
            }
            
        }

        private void btnAllowDrag_Click(object sender, EventArgs e)
        {
            if (ButtonControl.enableDrag)
            {
                ButtonControl.enableDrag = false;
                checkBoxDragEnabled.Checked = false;
            }
            else
            {
                ButtonControl.enableDrag = true;
                checkBoxDragEnabled.Checked = true;
            }
                
        }

        private void btnBackFromChild_Click(object sender, EventArgs e)
        {
            panelGUI.Controls.Clear();

            if (buttonsStack.Count == 2)
            {
                btnBackFromChild.Visible = false;
            }
            buttonsStack.Pop();

            foreach (var item in collectionButtons[buttonsStack.Peek()])
            {
                panelGUI.Controls.Add(item);
            }

            lblCurrentButtonID.Text = "";
            foreach (int id in buttonsStack)
            {
                lblCurrentButtonID.Text += ($"/{allButtons[id].Text}");
            }
        }


            private void limitTo255Chars(object sender, KeyPressEventArgs e)
        {
            // only allow one decimal point
            if (((sender as TextBox).Text.Count() > 254))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbSearchProperty.Text))
            {
                MessageBox.Show("You have to choose which property you want to search!");
            }
            else
            {
                Search();
            }




            
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            foreach (var collection in collectionButtons.Values)
            {
                foreach (DragButton item in collection)
                {
                    item.BackColor = Color.FromArgb(224, 224, 224);
                }
            }

            panelGUI.Controls.Clear();

            foreach (DragButton item in collectionButtons[buttonsStack.Peek()])
            {
                panelGUI.Controls.Add(item);
            }

            searchActive = false;

            cmbFoundProducts.DataSource = null;
            cmbFoundProducts.Enabled = false;
        }

        private void Search()
        {
            List<Product> foundProducts = new List<Product>();

            foreach (Product product in ProductsHolder.products)
            {
                string searchedProperty = product.GetType().GetProperty(cmbSearchProperty.Text).GetValue(product).ToString();
                if (searchedProperty.IndexOf(tBoxSearchValue.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    foundProducts.Add(product);
                }
            }
            List<int> buttonsIDs = new List<int>();

            cmbFoundProducts.Enabled = true;
            cmbFoundProducts.DataSource = foundProducts.Select(p => p.name).ToList();

            try
            {
                buttonsIDs = Managers.GuiSearchManager.GetButtonsContaining(foundProducts);
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem with search manager, check your database connection");
            }
            

            panelGUI.Controls.Clear();

            foreach (DragButton item in collectionButtons[buttonsStack.Peek()])
            {
                if (buttonsIDs.Contains(int.Parse(item.Tag.ToString())))
                {
                    item.BackColor = Color.Red;
                }
                panelGUI.Controls.Add(item);
            }

            
            searchActive = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {            
            if (ButtonControl.enableDelete)
            {
                ButtonControl.enableDelete = false;
                checkBoxDeleteEnabled.Checked = false;
            }
            else
            {
                MessageBox.Show("Deleting a unit or collection deletes all that it contains");
                ButtonControl.enableDelete = true;
                checkBoxDeleteEnabled.Checked = true;
            }
        }

        private void GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save buttons
            for (int i = 0; i < allButtons.Count; i++)
            {
                ButtonsClient.AddButtonToAllButtons(Mapper.mapDragButtonToTransferButton(allButtons[i]));
            }

        }
    }
}
