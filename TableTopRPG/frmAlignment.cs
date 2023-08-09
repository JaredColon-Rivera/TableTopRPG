using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTopRPG
{
    public partial class frmAlignment : Form
    {
        public frmAlignment()
        {
            InitializeComponent();
        }

        string confirmedAlignment = "";

        private void searchAPI(Button btn)
        {
            string toLowerAlignment = btn.Text.ToLower();
            string formattedAlignment = "";
            if(toLowerAlignment.Contains(" "))
                formattedAlignment = toLowerAlignment.Replace(" ", "-");
            else 
                formattedAlignment = toLowerAlignment;

            string searchAlignment = "api/alignments/" + formattedAlignment;
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://www.dnd5eapi.co/");
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.GetAsync(searchAlignment).Result;
            var data = response.Content.ReadAsStringAsync().Result;

            // ClassChoice.Root apiInfo = JsonSerializer.Deserialize<ClassChoice.Root>(data);
            AlignmentChoice apiInfo = JsonSerializer.Deserialize<AlignmentChoice>(data);
            // txtAPIBox.Text = apiInfo.name;
            txtAlignmentDesc.Text = apiInfo.desc;
            confirmedAlignment = btn.Text;
        }

        private void btnChaoticEvil_Click(object sender, EventArgs e)
        {
            searchAPI(btnChaoticEvil);
        }

        private void btnNeutralEvil_Click(object sender, EventArgs e)
        {
            searchAPI(btnNeutralEvil);
        }

        private void btnLawfulEvil_Click(object sender, EventArgs e)
        {
            searchAPI(btnLawfulEvil);
        }

        private void btnChaoticNeutral_Click(object sender, EventArgs e)
        {
            searchAPI(btnChaoticNeutral);
        }

        private void btnNeutral_Click(object sender, EventArgs e)
        {
            searchAPI(btnNeutral);
        }

        private void btnLawfulNeutral_Click(object sender, EventArgs e)
        {
            searchAPI(btnLawfulNeutral);
        }

        private void btnChaoticGood_Click(object sender, EventArgs e)
        {
            searchAPI(btnChaoticGood);
        }

        private void btnNeutralGood_Click(object sender, EventArgs e)
        {
            searchAPI(btnNeutralGood);
        }

        private void btnLawfulGood_Click(object sender, EventArgs e)
        {
            searchAPI(btnLawfulGood);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Tag = "Alignment|" + confirmedAlignment;
            this.DialogResult = DialogResult.OK;
        }
    }
}
