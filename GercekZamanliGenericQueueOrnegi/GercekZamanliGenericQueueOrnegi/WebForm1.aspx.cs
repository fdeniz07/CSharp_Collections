using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GercekZamanliGenericQueueOrnegi
{
    /* Programin Amaci
     * Bir gise programi tasarliyoruz
     * Buraya gelen müsteriler birer Token (sira no) aliyor (bunun icin PrintToken butonuna basiyor)
     * Daha sonrasinda her gisenin kendi ekraninin var oldugunu varsayarak, ilgili gise görevlisi kendi ekranindaki sayac (Next) butonuna basarak siradaki müsteriyi kendisine cagirtiyor.
     * Cagrilan müsterilen listeden eksiliyor ve en son cagrilan müsteri ana ekrandaki text alanina düsüyor
     * Butün islemler Session tarafindan depolanip, yönetiliyor.
     * Her buton icin ayri ayri kod blogu yazmak yerine bir tane Private Method (ServNextCustomer) yazdik ve butonlarin click event i üzerinden bu metodu cagirdik.
     */

    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TokenQueue"] == null)
            {
                Queue<int> queueTokens = new Queue<int>();
                Session["TokenQueue"] = queueTokens;
            }
        }

        protected void btnPrintToken_Click(object sender, EventArgs e)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            lblCurrentStatus.Text = "There are " + tokenQueue.Count.ToString() + " customers before you in the queue";

            if (Session["LastTokenNumberIssued"] == null)
            {
                Session["LastTokenNumberIssued"] = 0;
            }

            int nextTokenNumberIssueed = (int)Session["LastTokenNumberIssued"] + 1;
            Session["LastTokenNumberIssued"] = nextTokenNumberIssueed;
            tokenQueue.Enqueue(nextTokenNumberIssueed);
            AddTokensToListBox(tokenQueue);
        }

        private void AddTokensToListBox(Queue<int> tokenQueue)
        {
            listTokens.Items.Clear();
            foreach (int token in tokenQueue)
            {
                listTokens.Items.Add(token.ToString());
            }
        }

        private void ServNextCustomer(TextBox textbox, int counterNumber)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            if (tokenQueue.Count == 0)
            {
                textbox.Text = "No Customers in the Queue";
            }
            else
            {
                int tokenNumberToBeServed = tokenQueue.Dequeue();
                textbox.Text = tokenNumberToBeServed.ToString();
                txtNextToken.Text = "Token Number: " + tokenNumberToBeServed.ToString() + " Please go to Counter " + counterNumber.ToString();
                AddTokensToListBox(tokenQueue);
            }
        }

        protected void btnCounter1_Click(object sender, EventArgs e)
        {
            ServNextCustomer(txtCounter1, 1);
        }

        protected void btnCounter2_Click(object sender, EventArgs e)
        {
            ServNextCustomer(txtCounter2, 2);
        }

        protected void btnCounter3_Click(object sender, EventArgs e)
        {
            ServNextCustomer(txtCounter3, 3);
        }
    }
}