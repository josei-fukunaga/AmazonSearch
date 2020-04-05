using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AmazonSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_keyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sURL;
            var sCategory = new string[1024];
            var scr = new SampleScraping();

            sURL = "https://www.amazon.co.jp/gp/site-directory?ref_=nav_em_T1_0_2_2_20__fullstore";
            string sHtml = scr.GetHtml(sURL);
            GetCategory(sHtml, sCategory);

            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView1.RowHeadersWidth = 40;

            // カラム数を指定
            //dataGridView1.ColumnCount = 4;

            // カラムのサイズ指定
            dataGridView1.Columns[0].Width = 400; //商品名
            dataGridView1.Columns[1].Width = 100; //価格(\)
            dataGridView1.Columns[2].Width = 100; //画像
            dataGridView1.Columns[3].Width = 500; //商品URL
            dataGridView1.RowTemplate.Height = 60;

            dataGridView1.Columns[1].DefaultCellStyle.Format = "c";
            dataGridView1.Columns[2].DefaultCellStyle.NullValue = null;
        }

        public void GetCategory(string url, string[] category_array)
        {
            int cnt, top, tail, i;
            var sComboCategory = new string[1024];
            var sCtegoryAlias = new string[1024];

            MatchCollection match_category = Regex.Matches(url, "option value=");

            cnt = 0;
            foreach(Match m in match_category)
            {
                int index = m.Index; // 発見した文字列の開始位置
                category_array[cnt] = url.Substring(index);
                cnt++;
            }

            combo_category1.Items.Add("すべて");
            comboBox_alias1.Items.Add("aps");

            for (i = 0; i < cnt; i++)
            {
                int sub;

                top = category_array[i].IndexOf(">");
                tail = category_array[i].IndexOf("</option>");
                sComboCategory[i] = category_array[i].Substring(top + 1, tail - top - 1);

                top = category_array[i].IndexOf("search-alias=");
                tail = category_array[i].IndexOf("\">");
                sCtegoryAlias[i] = category_array[i].Substring(top + 13, tail - top - 13);

                sub = (sComboCategory[i].IndexOf("&#160;&#160;&#160;"));
                if (sub != -1)
                {
                    string work = sComboCategory[i];
                    sComboCategory[i] = work.Replace("&#160;&#160;&#160;", "└ ");
                }

                combo_category1.Items.Add(sComboCategory[i]);
                comboBox_alias1.Items.Add(sCtegoryAlias[i]);
            }
        }

        private void label_category1_Click(object sender, EventArgs e)
        {

        }

        private void button1_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string sURL_Category, sURL_Item, sURL;
            string sPrice;
            var sCategory = new string[1024];
            var scr = new SampleScraping();

            sURL_Category = "http://www.amazon.co.jp/gp/search/?__mk_ja_JP=%83J%83%5E%83J%83i&url=search-alias%3D";
            sURL_Item = "&field-keywords=";

            if (checkBox_price.Checked == true)
            {
                if (!PriceCheck())
                {
                    return;
                }
                else
                {
                    sPrice = "&low-price=" + Convert.ToInt32(textBox_price_low.Text) + "&high-price=" + Convert.ToInt32(textBox_price_high.Text);
                }
            }
            else
            {
                sPrice = "";
            }

            sURL = sURL_Category + comboBox_alias1.Text + sURL_Item + textBox_keyword.Text + sPrice + "&emi=AN1VRQENFRJN5";

            //System.Diagnostics.Process.Start(sURL);
            string sHtml = scr.GetHtml(sURL);

            int next, tail;
            string work;

            dataGridView1.Rows.Clear();

            while (true)
            {
                if(!SetDataToGrid(sHtml))
                {
                    break;
                }

                next = sHtml.IndexOf("<li class=\"a-last\"><a href=\"");
                if (next == -1)
                {
                    break;
                }
                else
                {
                    tail = sHtml.IndexOf(">次へ");
                    work = System.Web.HttpUtility.UrlDecode(sHtml.Substring(next + 28, tail - next - 29));
                }

                sHtml = scr.GetHtml("https://amazon.co.jp" + work);
            }
        }

        private bool PriceCheck()
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox_price_low.Text, @"^\d+$"))
            {
                MessageBox.Show("最低価格には数値を入力してください。");
                textBox_price_low.Focus();
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox_price_high.Text, @"^\d+$"))
            {
                MessageBox.Show("最高価格には数値を入力してください。");
                textBox_price_high.Focus();
                return false;
            }

            int high = Convert.ToInt32(textBox_price_high.Text);
            int low = Convert.ToInt32(textBox_price_low.Text);

            if(low > high)
            {
                MessageBox.Show("最低価格が最高価格を超えています。");
                textBox_price_low.Focus();
                return false;
            }

            return true;
        }

        private void combo_category1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_alias1.SelectedIndex = combo_category1.SelectedIndex;
        }

        private bool SetDataToGrid(string sHtml)
        {
            int cnt, row_count, tail;
            string work1, work2;
            var sLink = new string[4096];
            var sImage = new string[4096];
            var sItemName = new string[4096];
            var sPrice = new string[4096];

            var sGridLink = new string[4096];
            var sGridImage = new string[4096];
            var sGridItemName = new string[4096];
            var sGridPrice = new string[4096];

            if (sHtml.IndexOf("の結果は見つかりませんでした") != -1)
            {
               MessageBox.Show("検索結果がありません");
               return false;
            }

            if (sHtml.IndexOf("つの結果を見る") != -1)
            {
                MessageBox.Show("すべてのカテゴリーから検索してください\nまたは、価格設定を変更してください");
                return false;
            }

            //Link
            MatchCollection match_category = Regex.Matches(sHtml, "<a class=\"a-link-normal\" target=\"_blank\" href=\"");
            cnt = 0;
            row_count = 0;
            foreach (Match m in match_category)
            {
                int index = m.Index; // 発見した文字列の開始位置

                sLink[cnt] = sHtml.Substring(index);

                tail = sLink[cnt].IndexOf(">");
                work1 = System.Web.HttpUtility.UrlDecode(sLink[cnt].Substring(47, tail - 48));
                work2 = work1.Replace("amp;", "");

                cnt++;

                if( !work2.Contains("customerReviews"))
                {
                    sGridLink[row_count] = "https://amazon.co.jp" + work2;
                    //dataGridView1.Rows.Add("", "", "", "", sGridLink[cnt]);
                    row_count++;
                }
            }

            //Image
            match_category = Regex.Matches(sHtml, "<img src=\"https://m.media-amazon.com/images/");
            cnt = 0;
            foreach (Match m in match_category)
            {
                int index = m.Index; // 発見した文字列の開始位置
                sImage[cnt] = sHtml.Substring(index);

                tail = sImage[cnt].IndexOf("class=\"s-image\"");
                work1 = System.Web.HttpUtility.UrlDecode(sImage[cnt].Substring(1, tail - 28));
                work2 = work1.Replace("img src=\"", "");

                sGridImage[cnt] = work2;

                cnt++;
            }

            //ItemtName
            match_category = Regex.Matches(sHtml, "class=\"s-image\"\n                         alt=\"");
            cnt = 0;
            foreach (Match m in match_category)
            {
                int index = m.Index; // 発見した文字列の開始位置
                sItemName[cnt] = sHtml.Substring(index);

                tail = sItemName[cnt].IndexOf("\n                         srcset=");
                work1 = System.Web.HttpUtility.UrlDecode(sItemName[cnt].Substring(46, tail - 47));

                sGridItemName[cnt] = work1;

                cnt++;
            }

            //Price
            match_category = Regex.Matches(sHtml, "a-price-whole\">");
            cnt = 0;
            foreach (Match m in match_category)
            {
                int index = m.Index; // 発見した文字列の開始位置
                sPrice[cnt] = sHtml.Substring(index);

                tail = sPrice[cnt].IndexOf("</span></span></span>");
                work1 = System.Web.HttpUtility.UrlDecode(sPrice[cnt].Substring(15, tail - 15));

                sGridPrice[cnt] = work1;

                cnt++;
            }

            for (int i = 0; i < row_count; i++)
            {
                WebClient wc = new WebClient();
                Stream stream = wc.OpenRead(sGridImage[i]);
                dataGridView1.Rows.Add(sGridItemName[i], sGridPrice[i], new Bitmap(stream), sGridLink[i]);
                comboBox_image.Items.Add(sGridImage[i]);
                stream.Close();
            }

            return true;
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //列ヘッダーかどうか調べる
            if (e.ColumnIndex < 0 && e.RowIndex >= 0)
            {
                //セルを描画する
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All);

                //行番号を描画する範囲を決定する
                //e.AdvancedBorderStyleやe.CellStyle.Paddingは無視しています
                Rectangle indexRect = e.CellBounds;
                indexRect.Inflate(-2, -2);
                //行番号を描画する
                TextRenderer.DrawText(e.Graphics,
                    (e.RowIndex + 1).ToString(),
                    e.CellStyle.Font,
                    indexRect,
                    e.CellStyle.ForeColor,
                    TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
                //描画が完了したことを知らせる
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex != 3)
            {
                return;
            }

            string sURL = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            System.Diagnostics.Process.Start(sURL);
        }

        private void checkBox_price_Click(object sender, EventArgs e)
        {
            if (checkBox_price.Checked == true)
            {
                label_price_low.Enabled = true;
                label_price_high.Enabled = true;
                label1.Enabled = true;
                label_yen.Enabled = true;

                textBox_price_low.Enabled = true;
                textBox_price_high.Enabled = true;
            }
            else
            {
                label_price_low.Enabled = false;
                label_price_high.Enabled = false;
                label1.Enabled = false;
                label_yen.Enabled = false;

                textBox_price_low.Enabled = false;
                textBox_price_high.Enabled = false;
            }
        }

        private void button_ExcelOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog
            {
                Title = "ファイルを保存する",
                InitialDirectory = @"C:\Users\Administrator\Desktop",
                FileName = @"output.csv",
                Filter = "CSV(カンマ付き)|*.csv"
            };

            DialogResult output = save.ShowDialog();

            if(output != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            using (StreamWriter writer = new StreamWriter(save.FileName, false, Encoding.GetEncoding("shift_Jis")))
            {
                int row = dataGridView1.RowCount;
                int colunms = dataGridView1.ColumnCount;

                List<string> strList = new List<string>();

                strList.Add("No.");
                for (int k = 0; k < colunms; k++)
                {
                    strList.Add(dataGridView1.Columns[k].HeaderCell.Value.ToString());
                }

                string[] strHeader = strList.ToArray();

                string strCsvData2 = string.Join("\t", strHeader);
                writer.WriteLine(strCsvData2);

                for (int i = 0; i < row; i++)
                {
                    int no;
                    strList = new List<string>();

                    no = i + 1;
                    strList.Add(no.ToString());
                    for (int j = 0; j < colunms; j++)
                    {
                        if(j != 2)
                        {
                            strList.Add(dataGridView1[j, i].Value.ToString());
                        }
                        else
                        {
                            strList.Add((string)comboBox_image.Items[i]);
                        }
                    }

                    string[] strArray = strList.ToArray();

                    string strCsvData = string.Join("\t", strArray);
                    writer.WriteLine(strCsvData);
                }
            }
        }
    }
}
