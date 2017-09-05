using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using System.Windows.Forms;
namespace DataSorter
{
    class Program
    {
        public const string AppName = "Sheets Test";
        public const string SheetId = "1d35X8k_0TZ8q02WwLHlEViV4Nb6ZiJ4VS9YiDzNFIXc";
        public static string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        //sheets api key
        //AIzaSyB0XWVcuOIhYPVw4miF1FT6TdssHt7Xr7o

        //oauth client id
        //697751519570-htsksih7595i6hle45o41objmt3qitkr.apps.googleusercontent.com
        //oauth client secret
        //AiAEHMuXO277YtnyKPjhDOsd

        private static List<AppointmentModel> ReadGoogle()
        {
            UserCredential cred = null;
            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/sheets.googleapis.com-sheets-test.json");
                cred = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = cred,
                ApplicationName = AppName,
            });

            SpreadsheetsResource.ValuesResource.GetRequest req = service.Spreadsheets.Values.Get(SheetId, "Individual MOC List!A2:O435");

            var resp = req.Execute();
            if (resp.Values != null && resp.Values.Count > 0)
            {
                foreach (var row in resp.Values)
                {

                }
            }
            return null;
        }

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());

            //var bears = ReadGoogle();

            //var filePath = AppDomain.CurrentDomain.BaseDirectory + "\\schedule.csv";
            //var outPath = AppDomain.CurrentDomain.BaseDirectory + "\\Schedule.html";
            //if (File.Exists(outPath)) File.Delete(outPath);
            //char delimiter = '|';

            //var dataList = new List<DataModel>();
            //var reader = File.OpenText(filePath);
            //var line = reader.ReadLine();
            //bool isFirst = true;
            //while (line != null)
            //{
            //    if (isFirst)
            //    {
            //        isFirst = false;
            //    }
            //    else
            //    {
            //        dataList.Add(new DataModel(line.Split(delimiter)));
            //    }

            //    line = reader.ReadLine();
            //}
            //dataList.RemoveAll(x => string.IsNullOrEmpty(x.CreditUnionName));
            //var sb = new StringBuilder(WebPieces.Start);
            //sb.AppendLine(WebPieces.CSS);


            //foreach (var stateGroup in dataList.GroupBy(x => x.State).OrderBy(x => x.Key))
            //{
            //    sb.AppendLine("<h2 class=\"underline\">" + stateGroup.Key + "</h2>");
            //    sb.AppendLine("<div class=\"break major\"></div>");
            //    foreach (var congressGroup in stateGroup.GroupBy(x => x.Congressman).OrderBy(x => x.Key))
            //    {
            //        foreach (var dateGroup in congressGroup.GroupBy(x => new { x.CombinedDate, x.Location }).OrderBy(x => x.Key.CombinedDate))
            //        {
            //            sb.AppendLine("<div class=\"indent-left\">");
            //            sb.AppendLine("<div class=\"width-100\">");
            //            sb.AppendLine("<span class=\"span-block italics larger\">" + congressGroup.Key + "</span>");
            //            sb.AppendLine("<span class=\"span-block indent\">DAY OF WEEK" + "," + dateGroup.Key.CombinedDate.Date.ToShortDateString() + "</span>");
            //            sb.AppendLine("<span class=\"span-block indent\">" + dateGroup.Key.CombinedDate.ToShortTimeString() + "</span>");
            //            sb.AppendLine("<span class=\"span-block indent\">" + dateGroup.Key.Location + "</span>");
            //            sb.AppendLine("</div>");
            //            sb.AppendLine("<ul>");
            //            foreach (var fcu in dateGroup.GroupBy(x => x.CreditUnionName).OrderBy(x => x.Key))
            //            {
            //                sb.AppendLine("<li>" + fcu.Key + "</li>");
            //            }
            //            sb.AppendLine("</ul>");
            //            sb.AppendLine("<div class=\"break minor\"></div>");
            //            sb.AppendLine("</div>");
            //        }

            //    }
            //}

            //sb.Append(WebPieces.End);
            //var writer = File.CreateText(outPath);
            //writer.WriteLine(sb.ToString());
            //writer.Close();
            //System.Diagnostics.Process.Start(outPath);
        }
    }
}
