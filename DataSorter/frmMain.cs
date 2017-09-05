﻿using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.Sheets.v4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSorter
{
    public partial class frmMain : Form
    {
        List<AppointmentModel> _importResults = null;

        public frmMain()
        {
            InitializeComponent();

            txtCSVPath.Text = Properties.Settings.Default.CSVPath;
            txtHTMLPath.Text = Properties.Settings.Default.HTMLPath;
            txtDelimiter.Text = Properties.Settings.Default.Delimiter;

            txtAppName.Text = Properties.Settings.Default.AppName;
            txtEndCell.Text = Properties.Settings.Default.EndCell;
            txtSheetId.Text = Properties.Settings.Default.SheetId;
            txtStartCell.Text = Properties.Settings.Default.StartCell;
            txtSheetName.Text = Properties.Settings.Default.SheetName;



        }

        private void btnSelectCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV Files|*.csv";
            ofd.Title = "Select CSV File Saved From Google Sheets";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() != DialogResult.OK) return;
            txtCSVPath.Text = ofd.FileName;
            Properties.Settings.Default.CSVPath = txtCSVPath.Text;
            Properties.Settings.Default.Save();
        }

        private void btnSelectHTML_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "HTML Files|*.html";
            ofd.Title = "Select HTML File to Save";
            ofd.AddExtension = true;
            ofd.CreatePrompt = true;
            if (ofd.ShowDialog() != DialogResult.OK) return;
            txtHTMLPath.Text = ofd.FileName;
            Properties.Settings.Default.HTMLPath = txtHTMLPath.Text;
            Properties.Settings.Default.Save();
        }

        private void txtDelimiter_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (!string.IsNullOrEmpty(tb.Text))
            {
                Properties.Settings.Default.Delimiter = tb.Text;
                Properties.Settings.Default.Save();
            }
        }


        private List<AppointmentModel> ReadFromCSV()
        {
            try
            {
                var dataList = new List<AppointmentModel>();
                var reader = File.OpenText(Properties.Settings.Default.CSVPath);
                var line = reader.ReadLine();
                bool isFirst = true;
                while (line != null)
                {
                    if (isFirst)
                    {
                        isFirst = false;
                    }
                    else
                    {
                        dataList.Add(new AppointmentModel(line.Split(Convert.ToChar(Properties.Settings.Default.Delimiter))));
                    }

                    line = reader.ReadLine();
                }
                dataList.RemoveAll(x => string.IsNullOrEmpty(x.CreditUnionName));
                return dataList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading CSV File" + Environment.NewLine + ex.Message, "Error Reading CSV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        private void btnCreateHTML_Click(object sender, EventArgs e)
        {
            if (_importResults == null)
            {
                MessageBox.Show("You need to import your data first!", "Data Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var sb = new StringBuilder(WebPieces.Start);
            sb.AppendLine(WebPieces.CSS);


            foreach (var stateGroup in _importResults.Where(x => x.Confirmed).GroupBy(x => x.State).OrderBy(x => x.Key))
            {
                sb.AppendLine("<h2 class=\"underline\">" + stateGroup.Key + "</h2>");
                sb.AppendLine("<div class=\"break major\"></div>");
                foreach (var congressGroup in stateGroup.GroupBy(x => x.Congressman).OrderBy(x => x.Key))
                {
                    foreach (var dateGroup in congressGroup.GroupBy(x => new { x.CombinedDate, x.Location }).OrderBy(x => x.Key.CombinedDate))
                    {
                        sb.AppendLine("<div class=\"indent-left\">");
                        sb.AppendLine("<div class=\"width-100\">");
                        sb.AppendLine("<span class=\"span-block italics larger\">" + congressGroup.Key + "</span>");
                        sb.AppendLine("<span class=\"span-block indent\">" + dateGroup.Key.CombinedDate.ToString("dddd") + ", " + dateGroup.Key.CombinedDate.ToShortDateString() + ", " + dateGroup.Key.CombinedDate.ToShortTimeString() + "</span>");
                        sb.AppendLine("<span class=\"span-block indent\">" + dateGroup.Key.Location + "</span>");
                        sb.AppendLine("</div>");
                        sb.AppendLine("<ul>");
                        foreach (var fcu in dateGroup.GroupBy(x => x.CreditUnionName).OrderBy(x => x.Key))
                        {
                            sb.AppendLine("<li>" + fcu.Key + "</li>");
                        }
                        sb.AppendLine("</ul>");
                        sb.AppendLine("<div class=\"break minor\"></div>");
                        sb.AppendLine("</div>");
                    }

                }
            }

            sb.Append(WebPieces.End);
            var writer = File.CreateText(Properties.Settings.Default.HTMLPath);
            writer.WriteLine(sb.ToString());
            writer.Close();
            System.Diagnostics.Process.Start(Properties.Settings.Default.HTMLPath);
        }

        private void txtSheetId_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (!string.IsNullOrEmpty(tb.Text))
            {
                Properties.Settings.Default.SheetId = tb.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void txtAppName_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (!string.IsNullOrEmpty(tb.Text))
            {
                Properties.Settings.Default.AppName = tb.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void txtSheetName_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (!string.IsNullOrEmpty(tb.Text))
            {
                Properties.Settings.Default.SheetName = tb.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void txtStartCell_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (!string.IsNullOrEmpty(tb.Text))
            {
                Properties.Settings.Default.StartCell = tb.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void txtEndCell_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (!string.IsNullOrEmpty(tb.Text))
            {
                Properties.Settings.Default.EndCell = tb.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void btnReadFromGoogle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.AppName))
            {
                MessageBox.Show("App Name Required", "App Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.SheetId))
            {
                MessageBox.Show("Sheet Id Required", "Sheet Id Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.SheetName))
            {
                MessageBox.Show("Sheet Name Required", "Sheet Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.StartCell))
            {
                MessageBox.Show("Start Cell Required", "Start Cell Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.EndCell))
            {
                MessageBox.Show("End Cell Required", "End Cell Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            _importResults = ImportFromGoogle();
            if (_importResults != null)
            {
                dgvImport.DataSource = _importResults;
                tcMain.SelectedTab = tpReviewData;
            }
            else
            {
                dgvImport.DataSource = null;
            }

        }
        private List<AppointmentModel> ImportFromGoogle()
        {
            try
            {
                UserCredential cred = null;

                var sheetQuery = Properties.Settings.Default.SheetName + "!" + Properties.Settings.Default.StartCell + ":" + Properties.Settings.Default.EndCell;
                using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
                {
                    string credPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    credPath = Path.Combine(credPath, ".credentials/sheets.googleapis.com-sheets-test.json");
                    cred = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets,
                        new string[1] { SheetsService.Scope.SpreadsheetsReadonly },
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                }
                var service = new SheetsService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = cred,
                    ApplicationName = Properties.Settings.Default.AppName,
                });

                SpreadsheetsResource.ValuesResource.GetRequest req = service.Spreadsheets.Values.Get(Properties.Settings.Default.SheetId, sheetQuery);
                var modelList = new List<AppointmentModel>();
                var resp = req.Execute();
                if (resp.Values != null && resp.Values.Count > 0)
                {
                    foreach (var row in resp.Values)
                    {
                        modelList.Add(new AppointmentModel(row.ToArray()));
                    }
                }
                return modelList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Query Google" + Environment.NewLine + ex.ToString());
                return null;
            }

        }
        private void btnReadCSV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.HTMLPath))
            {
                MessageBox.Show("HTML Path Required", "HTML Path Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.CSVPath))
            {
                MessageBox.Show("CSV Path Required", "CSV Path Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.Delimiter))
            {
                MessageBox.Show("CSV Delimiter Required", "CSV Delimiter Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            _importResults = ReadFromCSV();
            if (_importResults != null)
            {
                dgvImport.DataSource = _importResults;
                tcMain.SelectedTab = tpReviewData;
            }
            else
            {
                dgvImport.DataSource = null;
            }

        }
    }
}