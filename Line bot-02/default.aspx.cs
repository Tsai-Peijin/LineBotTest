using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Line_bot_02
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
    }
}