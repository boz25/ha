using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class Ha : System.Web.UI.Page
{
    private static int num = 0;
    ArrayList haWords = new ArrayList();
    static ArrayList times = new ArrayList();
    protected void Page_Load(object sender, EventArgs e)
    {
        ImageButton1.ImageUrl = "image/haraw.jpg";
        Label2.Text = "已经为长者续" + num.ToString() + "秒";
        Label3.Text = "让我们接受精神的洗礼：<br>";
        ImageButton1.ToolTip = "不要等到他不在了，你们才觉得欠他一秒";
        addWords();

    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton1.ImageUrl = "image/ha.gif";
        num++;
        // Label2.Text = "你成功为长者续一秒,共为长者续" +num.ToString() + "秒";
        Random ran = new Random();
        int temp = ran.Next(0, haWords.Count);
        Label3.Text += haWords[temp].ToString();
        // audio.Src = "voice/"+temp.ToString()+".m4a";
        //利用ip统计每个人的点击次数
        string hostname = System.Net.Dns.GetHostName();
        string clientIP = System.Net.Dns.GetHostAddresses(hostname).GetValue(0).ToString();
        Boolean flag = true;
        foreach (clicktimes c in times)
        {
            if (c.ip == clientIP)
            {
                c.count++;
                flag = false;
                Label2.Text = "你成功为长者续一秒,共为长者续" + num.ToString() + "秒<br>hhhh" + c.count.ToString();
                break;
            }
        }
        if (flag)
        {
            times.Add(new clicktimes(clientIP, 1));
            Label2.Text = "你成功为长者续一秒,共为长者续" + num.ToString() + "秒<br>1";
        }
    }
    protected void addWords()
    {
        haWords.Add("人呐，就都不知道自己不可以预料！");
        haWords.Add("你们搞得这个东西啊，excited");
        haWords.Add("你们不要见得风就是雨，我是见得多识得广了");
        haWords.Add("中国有一句老话叫“闷声发大财”");
        haWords.Add("我感觉你们媒体界还要学习一个");
        haWords.Add("你们就有一个好，那就是跑起来比谁都快");
        haWords.Add("一个人的命运啊，当然要靠自我奋斗，但是也要考虑历史的行程");
        haWords.Add("我说另请高明吧，我实在也不是谦虚。");
        haWords.Add("很惭愧，就做了一点微小的工作，谢谢大家！");
        haWords.Add("到了89年初的时候，我在想我估计也快退休了，我想我应该去当教授。");
        haWords.Add("我绝对不知道，我作为一个上海市委书记怎么把我选到北京去了。");
        haWords.Add("我今天就得罪你们一下了");
        haWords.Add("我没有说要钦定，没有一点点这个意思");
        haWords.Add("一句话都不说，这是坠吼的");
        haWords.Add("当然按照香港基本法去产生，但是，中央的决定也是很重要的");
        haWords.Add("到时候，中央会表态的");
    }
}
class clicktimes
{
    public string ip;
    public int count;
    public clicktimes(string value, int c)
    {
        this.ip = value;
        this.count = c;
    }
};
