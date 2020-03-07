using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            // カラム数を指定
            dataGridView1.ColumnCount = 5;

            // カラム名を指定
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 500;
            dataGridView1.RowTemplate.Height = 60;

            dataGridView1.Columns[0].HeaderText = "商品名";
            dataGridView1.Columns[1].HeaderText = "価格(\\)";
            dataGridView1.Columns[2].HeaderText = "画像1";
            dataGridView1.Columns[3].HeaderText = "画像2";
            dataGridView1.Columns[4].HeaderText = "商品URL";

            // データを追加
            dataGridView1.Rows.Add("ワイヤレスイヤホン", 19800, "", "", "https://www.amazon.co.jp/%E3%82%A4%E3%83%A4%E3%83%9B%E3%83%B3%E3%83%BB%E3%83%98%E3%83%83%E3%83%89%E3%83%9B%E3%83%B3-%E3%82%AB%E3%83%8A%E3%83%AB-%E3%82%AA%E3%83%BC%E3%83%90%E3%83%BC%E3%83%98%E3%83%83%E3%83%89-%E3%82%AA%E3%83%BC%E3%83%87%E3%82%A3%E3%82%AA/b?ie=UTF8&node=3477981&ref_=sd_allcat_elec_head");
            dataGridView1.Rows.Add("USBケーブル", 550, "", "", "https://www.amazon.co.jp/b/?node=2151851051&ref_=Oct_s9_apbd_odnav_hd_bw_b2LcqFn_1&pf_rd_r=3BKMK2M8860V6D798Y8R&pf_rd_p=3e66d1b6-2198-5d30-b7c9-0ccf7dfb92bf&pf_rd_s=merchandised-search-12&pf_rd_t=BROWSE&pf_rd_i=2151826051");
            dataGridView1.Rows.Add("変換コネクタ", 4580, "", "", "https://www.amazon.co.jp/s?k=%E5%A4%89%E6%8F%9B&i=computers&rh=n%3A2127209051%2Cn%3A2151826051%2Cn%3A2151830051&dc&__mk_ja_JP=%E3%82%AB%E3%82%BF%E3%82%AB%E3%83%8A&qid=1583545277&rnid=2127210051&ref=sr_nr_n_2");
        }

        private void GetCategory(string url, string[] category_array)
        {
            int cnt, tail, i;
            var sComboCategory = new string[1024];

            MatchCollection match_category = Regex.Matches(url, "popover-category-name");

            cnt = 0;
            foreach(Match m in match_category)
            {
                int index = m.Index; // 発見した文字列の開始位置
                category_array[cnt] = url.Substring(index);
                cnt++;
            }

            for (i = 0; i < cnt; i++)
            {
                tail = category_array[i].IndexOf("<");
                sComboCategory[i] = category_array[i].Substring(23, tail - 23);

                combo_category1.Items.Add(sComboCategory[i]);
                combo_category2.Items.Add(sComboCategory[i]);
                combo_category3.Items.Add(sComboCategory[i]);
                combo_category4.Items.Add(sComboCategory[i]);
            }
        }

        private void SetCategoryToCombo(string[] category_array)
        {
            int cnt, i;

            cnt = category_array.Count();
            for (i = 0; i < cnt; i++)
            {
                combo_category1.Items.Add(category_array[cnt]);
            }
        }

        private void label_category1_Click(object sender, EventArgs e)
        {

        }

        private void button1_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
