using System;
using System.IO;
using System.Threading.Tasks;

namespace TulScan.ViewModel.Helpers
{
    public class BrotherPrinterHelper
    {
        public Task PrintAssetLabel(string assetNumber)
        {
            string strFilePath = Path.GetDirectoryName(Environment.ProcessPath) + @"\Assets\AssetLabel.lbx";
            var domain = Properties.Settings.Default.DomainName;

            bpac.DocumentClass doc = new();
            doc.Open(strFilePath);

            //get objects text and change it to the asset variable that was created from JiraHelper.
            //F1 and F2 being the objectname on the brother labael
            var shrtAssetNumber = assetNumber.Replace("ASSET-", "");
            doc.GetObject("F1").Text = shrtAssetNumber;
            doc.GetObject("F2").Text = $"https://{domain}/jira/browse/{assetNumber}";

            doc.StartPrint("", bpac.PrintOptionConstants.bpoDefault);
            doc.PrintOut(1, bpac.PrintOptionConstants.bpoDefault);
            doc.EndPrint();
            doc.Close();
            return Task.CompletedTask;
        }
    }
}
