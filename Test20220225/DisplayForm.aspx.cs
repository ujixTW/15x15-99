using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Test20220225.Managers;
using Test20220225.Models;

namespace Test20220225
{
    public partial class DisplayForm : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            NumberManager mgr = new NumberManager();
            List<NumberContent> nuberList = mgr.GetNumberList();

            HGrow(nuberList);
        }

        private void HGrow(List<NumberContent> _numList)
        {
            string tableText = string.Empty;
            tableText +=
                "<table border='0' cellspacing='0'>" +
                "<tr>";
            foreach (NumberContent content in _numList)
            {
                if (content.ID != 1 &&
                    content.ID % 4 == 1)
                {
                    tableText += "</tr><tr>";
                }
                int baseNum = content.BaseNumber;
                string bodyText =
                    $"<td>" +
                    $"<table border='1' cellspacing='0'>" +
                    "<tr>" +
                    $"<th>基數 {content.BaseNumber}</th>" +
                    $"</tr>" +
                    $"<tr><td class='bodyTable'>";
                for (int i = 1; i < content.CoefficientNumber + 1; i++)
                {
                    bodyText += $"<p>{baseNum} * {i} = {baseNum * i}</p>";
                }
                bodyText += "</td></tr></table></td>";
                tableText += bodyText;
            }

            tableText += "</tr>" + "</table>";
            this.ltlNum2.Text = tableText;
        }
    }
}