using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Line_bot_03
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "rkuoSc02kr6wSJ01uasSVZqwTsjRE9b3aIFR68HnW5CaKG1eOp+HAkpLfok8RgaoruM9NVyudrHc50ZlYTibz1NKgN4+KZZMtjb7XK22OxEcexUO9DwDZb4rQPuKc+GqiZrbgfeHqg+B7+GGzkSbNwdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId= "Ufbf4c69ecb785709273c7fd859a9c048";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, $"測試 {DateTime.Now.ToString()} ! ");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, 1,2);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);

            //建立actions，作為ButtonTemplate的用戶回覆行為
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageActon() { label = "標題-文字回覆", text = "回覆文字" });
            actions.Add(new isRock.LineBot.UriActon() { label = "標題-開啟URL", uri = new Uri("http://www.google.com") });
            actions.Add(new isRock.LineBot.PostbackActon() { label = "標題-發生postack", data = "abc=aaa&def=111" });

            var ButtonTempalteMsg = new isRock.LineBot.ButtonsTemplate()
            {
                title = "選項",
                text = "請選擇其中之一",
                altText = "請在手機上檢視",
                thumbnailImageUrl = new Uri("https://maoup.com.tw/wp-content/uploads/2016/01/160128-1.png"),
                actions=actions
            };
            bot.PushMessage(AdminUserId,ButtonTempalteMsg);

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
             var bot = new Bot(channelAccessToken);

            //建立actions，作為ButtonTemplate的用戶回覆行為
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageActon() { label = "Yes", text = "Yes" });
            actions.Add(new isRock.LineBot.MessageActon() { label = "No", text = "No" });

            var ConfirmTemplate = new isRock.LineBot.ConfirmTemplate()
            {
                text = "請選擇其中之一",
                altText = "請在手機上檢視",
                actions=actions
            };
            bot.PushMessage(AdminUserId, ConfirmTemplate);

        }
    }
}