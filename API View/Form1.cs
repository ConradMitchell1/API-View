using System.Collections.Immutable;
using Newtonsoft.Json.Linq;


namespace API_View
{
    public partial class Form1 : Form
    {
        HttpClient elClient = new HttpClient();
        string path = "https://engineering-task.elancoapps.com/api/";
        //Set RGB Colours of buttons for easier change
        int buttonColR = 73;
        int buttonColG = 160;
        int buttonColB = 120;
        bool firstTime = true;


        public Form1()
        {
            
            elClient.BaseAddress = new Uri(path);
            InitializeComponent();

            //Set the Controls colors.
            pnlSide.BackColor = Color.FromArgb(33, 104, 105);
            pnlHeader.BackColor = Color.FromArgb(31, 36, 33);

            lblOrder.BackColor = Color.FromArgb(156, 197, 161);
            lblOrder.ForeColor = Color.FromArgb(33, 104, 105);

            cmbSortType.BackColor = Color.FromArgb(162, 166, 164);
            cmbDetails.BackColor = Color.FromArgb(162, 166, 164);

            dataGridView1.GridColor = Color.FromArgb(buttonColR, buttonColG, buttonColB);
            
            btnAppDetails.BackColor = Color.FromArgb(buttonColR, buttonColG, buttonColB);
            btnGetApplications.BackColor = Color.FromArgb(buttonColR, buttonColG, buttonColB);
            btnResourceDetails.BackColor = Color.FromArgb(buttonColR, buttonColG, buttonColB);
            btnGetResources.BackColor = Color.FromArgb(buttonColR, buttonColG, buttonColB);




        }
        private void btnAppDetails_Click(object sender, EventArgs e)
        {
            //Gets data of an Application from the API.
            GetData("applications/", txtAppDetails.Text);
        }

        private void btnGetApplications_Click(object sender, EventArgs e)
        {
            //Get a list of applications from the API
            GetSource("applications/");

        }

        private void btnResourceDetails_Click(object sender, EventArgs e)
        {
            //Gets data of a Resource from the API.
            GetData("resources/", txtAppDetails.Text);
        }

        private void btnGetResources_Click(object sender, EventArgs e)
        {
            //Gets a list of Resources from the API.
            GetSource("resources/");

        }

        private void GetData(string finalPath, string name)
        {
            //If the textbox isn't blank
            if (name != "")
            {
                HttpResponseMessage response = elClient.GetAsync(finalPath + name).Result; //Get the response of application/resource and the name of.
                if (response.IsSuccessStatusCode) //If response code is 200
                {
                    //stores the data using the class objects AppDetails.
                    var app = response.Content.ReadAsAsync<IEnumerable<AppDetails>>().Result;
                    //Check if the user wants the data sorted.
                    switch (cmbSortType.Text)
                    {
                        //Sorts the columns by ascending/descending order based off the combobox.
                        case "Ascending":
                            app = SortAppsAscending(app, cmbDetails.Text);
                            break;
                        case "Descending":
                            app = SortAppsDescending(app, cmbDetails.Text);
                            break;
                        default:
                            break;
                    }
                    //Displays data in the form.
                    dataGridView1.DataSource = app;
                    

                }
                else
                {
                    MessageBox.Show(response.ToString()); //Show the error
                }
            }
            else
            {
                MessageBox.Show("Error: Input box is Empty, please type a resource or application name.");
            }
            

            
        }

        private void GetSource(string sourcePath)
        {
            HttpResponseMessage response = elClient.GetAsync(sourcePath).Result;
            JToken json = JToken.Parse(response.Content.ReadAsStringAsync().Result); //Organises the Json.
   
            MessageBox.Show(json.ToString());
        }
        private static ImmutableArray<AppDetails> SortAppsAscending(IEnumerable<AppDetails> apps, string property)
        {
            //Checks the combobox to see what column to order by ascending.
            switch (property)
            {
                case "ConsumedQuantity":
                    return apps.OrderBy(a => a.ConsumedQuantity).ToImmutableArray();
                case "Cost":
                    return apps.OrderBy(a => a.Cost).ToImmutableArray();
                case "Date":
                    return apps.OrderBy(a => a.Date).ToImmutableArray();
                case "MeterCategory":
                    return apps.OrderBy(a => a.MeterCategory).ToImmutableArray();
                case "ResourceGroup":
                    return apps.OrderBy(a => a.ResourceGroup).ToImmutableArray();
                case "ResourceLocation":
                    return apps.OrderBy(a => a.ResourceLocation).ToImmutableArray();
                case "UnitOfMeasure":
                    return apps.OrderBy(a => a.UnitOfMeasure).ToImmutableArray();
                case "Location":
                    return apps.OrderBy(a => a.Location).ToImmutableArray();
                case "ServiceName":
                    return apps.OrderBy(a => a.ServiceName).ToImmutableArray();
                default:
                    return apps.ToImmutableArray();
            }
        }

        private static ImmutableArray<AppDetails> SortAppsDescending(IEnumerable<AppDetails> apps, string property)
        {
            //Checks the combobox to see what column to order by ascending.
            switch (property)
            {
                case "ConsumedQuantity":
                    return apps.OrderByDescending(a => a.ConsumedQuantity).ToImmutableArray();
                case "Cost":
                    return apps.OrderByDescending(a => a.Cost).ToImmutableArray();
                case "Date":
                    return apps.OrderByDescending(a => a.Date).ToImmutableArray();
                case "MeterCategory":
                    return apps.OrderByDescending(a => a.MeterCategory).ToImmutableArray();
                case "ResourceGroup":
                    return apps.OrderByDescending(a => a.ResourceGroup).ToImmutableArray();
                case "ResourceLocation":
                    return apps.OrderByDescending(a => a.ResourceLocation).ToImmutableArray();
                case "UnitOfMeasure":
                    return apps.OrderByDescending(a => a.UnitOfMeasure).ToImmutableArray();
                case "Location":
                    return apps.OrderByDescending(a => a.Location).ToImmutableArray();
                case "ServiceName":
                    return apps.OrderByDescending(a => a.ServiceName).ToImmutableArray();
                default:
                    return apps.ToImmutableArray();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return; // skip header row


            if (e.ColumnIndex % 2 == 0) // even column
            {
                e.CellStyle.BackColor = Color.FromArgb(224, 255, 217); // set the colour to Light Green
            }
            else // odd column
            {
                e.CellStyle.BackColor = Color.FromArgb(255, 255, 255); // set the color to White
            }
        }

        private void txtAppDetails_Click(object sender, EventArgs e)
        {
            if (firstTime) 
            {
                firstTime = false;
                txtAppDetails.Clear();
                txtAppDetails.Font = new Font(txtAppDetails.Font.Name, 12F);
            }
            
        }
    }

}