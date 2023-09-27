using CovadisBackendApp.Managers;
using DTO.DailySnack;
using DTO.Order;
using System.Net.Http;
using System.Reflection;

namespace CovadisBackendApp
{
    public partial class Form1 : Form
    {
        private OrderManager OrderManager;
        private HttpClient httpClient;
        private Dailymanager dailysnackmanager;
        //private Form2 form2;

        private ICollection<InfoOrderInfoResponse> orders;
        private int allEaters;
        private int count;
        //public event EventHandler? SelectedIndexChanged;
        private DailySnackResponse dailySnack;


        public Form1()
        {
            InitializeComponent();
            httpClient = new HttpClient();

            OrderManager = new OrderManager(httpClient);
            //BestellingManager = new BestellingManager(httpClient);

            dailysnackmanager = new Dailymanager(httpClient);

        }

        //onLoad
        private void Form1_Load(object sender, EventArgs e)
        {
            update();

        }
        
        //updates / refreshes data on screen
        private void update()
        {
            allEaters = OrderManager.GetEaterCount();
            dailySnack = dailysnackmanager.GetDailySnackForToday();
            orders = OrderManager.GetAllOrders();

            aantal.Text = "" + allEaters;
            snack.Text = "" + dailySnack.Name;
            listBox1.DataSource = orders;
            listBox1.DisplayMember = "email";

        }
        
        //goes to second form
        private void goToForm()
        {
            //wait for 2 renders to load the form when index is changed
            if (count > 2)
            {
                Form2 form2 = new Form2((InfoOrderInfoResponse)listBox1.SelectedItem);
                form2.ShowDialog();
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //prevents unneccesary refreshes
            count++;
            goToForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void naam_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //Save Daily Snack
        private void button1_Click(object sender, EventArgs e)
        {
            var naam = dailynaam.Text;
            var datum = datumpicker.Value;

            var dailysnack = new DailySnackWrite()
            {
                Date = datum,
                Name = naam
            };
            dailysnackmanager.SaveDailysnack(dailysnack);

            dailynaam.Text = "";
        }

        private void aantal_Click(object sender, EventArgs e)
        {

        }

        private void snack_Click(object sender, EventArgs e)
        {

        }

        private void Dailysnack_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            count = 0;
            update();
        }

        //Delete daily snack
        private void button6_Click(object sender, EventArgs e)
        {
            count = 0;
            dailysnackmanager.DeleteDailysnack(dailySnack.Id);
            update();
        }

        private void dailynaam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}