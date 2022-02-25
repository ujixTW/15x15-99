using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Test20220225.Models;
using Test20220225.Managers;

namespace Test20220225
{
    public partial class InputFrom : System.Web.UI.Page
    {
        private NumberManager _mgr = new NumberManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            if (!this.CheckInput())
                return;
            string baseNumberText = this.txtBaseNumber.Text.Trim();
            string coefficientNumberText = this.txtCoefficientNumber.Text.Trim();

            int baseNumber;
            int coefficientNumber;

            NumberContent model = new NumberContent();
            if (int.TryParse(baseNumberText, out baseNumber))
                model.BaseNumber = baseNumber;
            if (int.TryParse(coefficientNumberText, out coefficientNumber))
                model.CoefficientNumber = coefficientNumber;

            _mgr.CreateNumberContent(model);
            this.ltlMessage.Text = "輸入成功";
            string url= $"DisplayForm.aspx";
            Response.Redirect(url);
        }
        public bool CheckInput()
        {
            List<string> msgList = new List<string>();
            if (string.IsNullOrWhiteSpace(this.txtBaseNumber.Text))
                msgList.Add("請填入基數");
            if (string.IsNullOrWhiteSpace(this.txtCoefficientNumber.Text))
                msgList.Add("請填入係數");
            //整數
            if (!string.IsNullOrWhiteSpace(this.txtBaseNumber.Text))
            {
                int baseNum;
                if (!int.TryParse(this.txtBaseNumber.Text, out baseNum))
                    msgList.Add("基數為整數數字，並介於 1 ~ 15 之間");
                else if (baseNum < 1 || baseNum > 15)
                    msgList.Add("基數為整數數字，並介於 1 ~ 15 之間");
            }
            //係數
            if (!string.IsNullOrWhiteSpace(this.txtCoefficientNumber.Text))
            {
                int baseNum;
                if (!int.TryParse(this.txtCoefficientNumber.Text, out baseNum))
                    msgList.Add("係數為整數數字，並介於 1 ~ 15 之間");
                else if (baseNum < 1 || baseNum > 15)
                    msgList.Add("係數為整數數字，並介於 1 ~ 15 之間");
            }
            if (msgList.Count > 0)
            {
                string allError = string.Join("<br/>", msgList);
                this.ltlMessage.Text = allError;
                return false;
            }
            return true;
        }
    }
}