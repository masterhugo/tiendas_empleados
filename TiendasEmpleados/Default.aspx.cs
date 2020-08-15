using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections;
using TiendasEmpleados.Models;

namespace TiendasEmpleados
{
    public partial class _Default : Page
    {
        private static readonly HttpClient client = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            RunAsync();
            if (!IsPostBack)
            {

                ArrayList values = new ArrayList();

                values.Add("Item 1");
                values.Add("Item 2");
                values.Add("Item 3");
                values.Add("Item 4");
                values.Add("Item 5");
                values.Add("Item 6");

                ListBox1.DataSource = values;
                ListBox1.DataBind();

            }
        }
        void SubmitBtn_Click(Object sender, EventArgs e)
        {
            int a;
            if (ListBox1.SelectedIndex > -1)
                a = 1;


        }
        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost:58836/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        static async Task<Cargo> getCargos()
        {
            Cargo cargo = null;
            HttpResponseMessage response = await client.GetAsync("api/cargo");
            if (response.IsSuccessStatusCode)
            {
                cargo = await response.Content.ReadAsAsync<Cargo>();
            }
            return cargo;
        }
    }
}