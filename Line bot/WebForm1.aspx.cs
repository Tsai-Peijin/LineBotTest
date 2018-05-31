using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Line_bot
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("bNEH6O/X0Z9MnZ6jT0vJLj9UH3X2sh1X0lUf9/0dHQesHvJXXgoQ4B9hcYDv3BagruM9NVyudrHc50ZlYTibz1NKgN4+KZZMtjb7XK22OxFPrIsHY+C5uwf4bQIMcvf4/IYgA6HKmfUL3u089GC77AdB04t89/1O/w1cDnyilFU=");
            bot.PushMessage("Ufbf4c69ecb785709273c7fd859a9c048","你好~");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string time = new DateTime().ToString();
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("bNEH6O/X0Z9MnZ6jT0vJLj9UH3X2sh1X0lUf9/0dHQesHvJXXgoQ4B9hcYDv3BagruM9NVyudrHc50ZlYTibz1NKgN4+KZZMtjb7XK22OxFPrIsHY+C5uwf4bQIMcvf4/IYgA6HKmfUL3u089GC77AdB04t89/1O/w1cDnyilFU=");
            bot.PushMessage("Ufbf4c69ecb785709273c7fd859a9c048", 1, 122);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string time = new DateTime().ToString();
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("bNEH6O/X0Z9MnZ6jT0vJLj9UH3X2sh1X0lUf9/0dHQesHvJXXgoQ4B9hcYDv3BagruM9NVyudrHc50ZlYTibz1NKgN4+KZZMtjb7XK22OxFPrIsHY+C5uwf4bQIMcvf4/IYgA6HKmfUL3u089GC77AdB04t89/1O/w1cDnyilFU=");
            bot.PushMessage("Ufbf4c69ecb785709273c7fd859a9c048", new Uri("https://maoup.com.tw/wp-content/uploads/2016/01/160128-1.png"));
        }
    }
}