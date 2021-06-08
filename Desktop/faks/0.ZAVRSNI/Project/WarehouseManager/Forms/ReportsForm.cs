using DatabaseManagers;
using Models;
using Models.Reports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManager.DataHolders;
using WarehouseManager.Managers;
using static Models.Enums;

namespace WarehouseManager.Forms
{
    public partial class ReportsForm : Form
    {
        Dictionary<Enums.ReportTypes, string> reportsNames;
        Dictionary<Enums.ReportTypes, Type> reportTypesClassType;
        bool filterSet = false;
        Type selectedType;        

        public ReportsForm()
        {
            InitializeComponent();

            reportTypesClassType = new Dictionary<ReportTypes, Type>();
            reportTypesClassType.Add(ReportTypes.route, typeof(RouteDisplay));
            reportTypesClassType.Add(ReportTypes.vehicle, typeof(VehicleReport));
            reportTypesClassType.Add(ReportTypes.worker, typeof(WorkerReport));
            reportTypesClassType.Add(ReportTypes.received, typeof(ReceiveReport));
            reportTypesClassType.Add(ReportTypes.intermediateWarehouse, typeof(IWReport));
            reportTypesClassType.Add(ReportTypes.returned, typeof(ReturnToSupplierReport));
            reportTypesClassType.Add(ReportTypes.writeOff, typeof(WriteOffReport));

        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            cmbSearchOption.Items.AddRange(Enum.GetValues(typeof(SearchOption)).Cast<Enum>().ToArray());
            cmbReport.Items.AddRange(Enum.GetValues(typeof(ReportTypes)).Cast<Enum>().ToArray());

            dtpTo.ValueChanged += new EventHandler(picker_ValueChanged);
            dtpFrom.ValueChanged += new EventHandler(picker_ValueChanged);
        }

        private void picker_ValueChanged(object sender, EventArgs e)
        {
            getValuesFromDatabase();
            SetDgvValues();
        }

        private void cmbReport_TextChanged(object sender, EventArgs e)
        {            
            selectedType = reportTypesClassType[(ReportTypes)cmbReport.SelectedItem];

            cmbWhere.Items.Clear();
            cmbWhere.Items.AddRange(selectedType.GetProperties());
            cmbWhere.ValueMember = "name";

            cmbSearchOption.Enabled = true;
            cmbWhere.Enabled = true;

            getValuesFromDatabase();

            SetDgvValues();
        }

        private void checkSearchOptions(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbWhere.Text) || string.IsNullOrEmpty(cmbSearchOption.Text))
            {
                tboxValue.Enabled = false;
            }
            else
            {
                tboxValue.Enabled = true;
            }
        }

        private void tboxValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tboxValue.Text))
            {
                filterSet = false;
            }
            else
            {
                filterSet = true;
            }

            SetDgvValues();
        
        }

        public void SetDgvValues()
        {
            Type selectedListClass = typeof(GenericListHolder<>);
            Type selectedList = selectedListClass.MakeGenericType(selectedType);
            Type searchManagerClass = typeof(SearchManager);            

            switch ((ReportTypes)cmbReport.SelectedItem)
            {
                case ReportTypes.vehicle:
                    selectedList.GetMethod("setList").Invoke(selectedListClass, new object[] 
                        { ReportHolder.vehicleReports});
                    break;
                case ReportTypes.worker:
                    selectedList.GetMethod("setList").Invoke(selectedListClass, new object[]
                        { ReportHolder.workerReports});
                    break;
                case ReportTypes.route:
                    selectedList.GetMethod("setList").Invoke(selectedListClass, new object[] 
                        { ReportHolder.routeDisplays });
                    break;
                case ReportTypes.received:
                    selectedList.GetMethod("setList").Invoke(selectedListClass, new object[]
                        { ReportHolder.receiveReports });
                    break;
                case ReportTypes.intermediateWarehouse:
                    selectedList.GetMethod("setList").Invoke(selectedListClass, new object[]
                        { ReportHolder.iWReports });
                    break;
                case ReportTypes.returned:
                    selectedList.GetMethod("setList").Invoke(selectedListClass, new object[]
                        { ReportHolder.returnReports });
                    break;
                case ReportTypes.writeOff:
                    selectedList.GetMethod("setList").Invoke(selectedListClass, new object[]
                        { ReportHolder.writeOffReports });
                    break;
                default:
                    break;
            }

            

            if (dtpFrom.Value.Date <= dtpTo.Value.Date)
            {
                if (filterSet)
                {
                    foreach (SearchOption searchOption in Enum.GetValues(typeof(SearchOption)).Cast<Enum>().ToArray())
                    {
                        if ((SearchOption)cmbSearchOption.SelectedItem == searchOption)
                        {
                            dgv.DataSource = searchManagerClass.GetMethod(searchOption.ToString())
                                .MakeGenericMethod(selectedType)
                                .Invoke(searchManagerClass, new object[]
                                {
                                    tboxValue.Text,
                                    cmbWhere.Text,
                                    selectedList.GetMethod("GetList").Invoke(selectedListClass, new object[] { })
                                }); ;
                            break;
                        }
                    }                                                            
                }
                else
                {
                    dgv.DataSource = selectedList.GetMethod("GetList").Invoke(selectedListClass, new object[] { });
                }
            }
            else
            {
                MessageBox.Show("Date from must be before date to");
            }
        }

        private void getValuesFromDatabase()
        {
            try
            {
                switch ((ReportTypes)cmbReport.SelectedItem)
                {
                    case ReportTypes.vehicle:
                        ReportHolder.vehicleReports = ReportClient.GetVehicleReport(dtpFrom.Value, dtpTo.Value);
                        break;
                    case ReportTypes.worker:
                        ReportHolder.workerReports = ReportClient.GetWorkerReport(dtpFrom.Value, dtpTo.Value);
                        break;
                    case ReportTypes.route:
                        ReportHolder.routeDisplays = RouteHelper.makeRoutesDisplayable(
                            DeliveryClient.GetRoutes())
                            .FindAll((elem) =>
                                elem.startDate.Date >= dtpFrom.Value.Date &&
                                elem.startDate <= dtpTo.Value.Date);
                        break;
                    case ReportTypes.received:
                        ReportHolder.receiveReports = ReportClient.GetReceiveReport(dtpFrom.Value, dtpTo.Value);
                        break;
                    case ReportTypes.intermediateWarehouse:
                        ReportHolder.iWReports = ReportClient.GetIWReport(dtpFrom.Value, dtpTo.Value);
                        break;
                    case ReportTypes.returned:
                        ReportHolder.returnReports = ReportClient.GetReturnToSupplierReport(dtpFrom.Value, dtpTo.Value);
                        break;
                    case ReportTypes.writeOff:
                        ReportHolder.writeOffReports = ReportClient.GetWriteOffReport(dtpFrom.Value, dtpTo.Value);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to get values from database");
            }
            
        }

        private void btnPdfExport_Click(object sender, EventArgs e)
        {
            string saveLocation = "";

            if (string.IsNullOrEmpty(tboxFileName.Text))
            {
                MessageBox.Show("Please enter file name");
                return;
            }

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    saveLocation = fbd.SelectedPath + @"\" + tboxFileName.Text + ".pdf";
                }
            }
            if (string.IsNullOrEmpty(saveLocation))
            {
                return;
            }

            Type pdfManagerClass = typeof(PDFManager);
            pdfManagerClass.GetMethod("createPDFfromList")
                                .MakeGenericMethod(selectedType)
                                .Invoke(pdfManagerClass, new object[]
                                {
                                    dgv.DataSource,
                                    tboxFileName.Text, 
                                    saveLocation                                    
                                }); ;           
        }
    }
}
