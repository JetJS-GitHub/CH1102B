using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 使用LoadFile()方法来加载文件，
 * 在加载过程利用Find()方法来查找特定的字符串，
 * 并把此特定字符串予以格式设置后，显示于RichTextBox文本框上，
 * 再调用SaveFile()方法存储。*/

namespace CH1102B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Example for GitHub

        private void btnOpen_Click(object sender, EventArgs e)
        {
            btnOpen.Visible = false;	//隐藏按钮控件
            //文本框大小根据窗体来扩充
            displayRTF.Dock = DockStyle.Fill;
            string target = "独行天才";//查找字符串
            int begin = 1;//设置欲查找字符串的起始位置
            int count =1;
            //载入文件
            displayRTF.LoadFile("D:\\Jet\\VS\\Visual C# 2013 Demo" +
             "\\CH11\\DemoA.rtf");
            //获取加载文件的总字符串长度
            int result = displayRTF.TextLength;

            //字符串总长是否大于字符位置
            while (result > begin)
            {
                //获取找到第一个字符串的索引位置
                int outcome = SearchText(target, begin);
                //(outcome>=0)?begin = outcome+1:begin+=outcome;
                if (outcome < 0)
                {
                    break;
                }
                else
                MessageBox.Show("第 " + count.ToString() + "字符，索引编号：" + outcome.ToString());
                begin = outcome + 1;
                count++;
                
            }
            //存储文件
            displayRTF.SaveFile("D:\\Jet\\VS\\Visual C# 2013 Demo" +
               "\\CH11\\DemoB.rtf",
                  RichTextBoxStreamType.RichText);
        }

        //查找字符串的方法——传入字符串和起始位置
        public int SearchText(string word, int start)
        {
            //没有找到符合的字符串时返回-1
            int searchresult = -1;
            //有字符串和起始位置才进一步查找
            if (word.Length > 0 && start >= 0)
            {
                //Find()方法进行字符串查找，None要找到相似即可
                int MatchText = displayRTF.Find(word, start,
                   RichTextBoxFinds.None);
                //找到符合的字符串，将字号设为14，字体为粗体
                displayRTF.SelectionFont = new Font(
                   "楷体", 14, FontStyle.Bold);
                //符合的字符串重设字体颜色
                displayRTF.SelectionColor = Color.Purple;
                if (MatchText >= 0)
                    searchresult = MatchText;
            }
            return searchresult;
        }
    }
}
