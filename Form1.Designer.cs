namespace AmazonSearch
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_keyword = new System.Windows.Forms.Label();
            this.label_category1 = new System.Windows.Forms.Label();
            this.label_category2 = new System.Windows.Forms.Label();
            this.label_category3 = new System.Windows.Forms.Label();
            this.label_category4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_keyword = new System.Windows.Forms.TextBox();
            this.check_category1 = new System.Windows.Forms.CheckBox();
            this.check_category2 = new System.Windows.Forms.CheckBox();
            this.check_category3 = new System.Windows.Forms.CheckBox();
            this.check_category4 = new System.Windows.Forms.CheckBox();
            this.combo_category1 = new System.Windows.Forms.ComboBox();
            this.combo_category2 = new System.Windows.Forms.ComboBox();
            this.combo_category3 = new System.Windows.Forms.ComboBox();
            this.combo_category4 = new System.Windows.Forms.ComboBox();
            this.label_price1 = new System.Windows.Forms.Label();
            this.label_price2 = new System.Windows.Forms.Label();
            this.textBox_price1 = new System.Windows.Forms.TextBox();
            this.textBox_price2 = new System.Windows.Forms.TextBox();
            this.label_yen1 = new System.Windows.Forms.Label();
            this.label_yen2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.label_quanity = new System.Windows.Forms.Label();
            this.textBox_quanity = new System.Windows.Forms.TextBox();
            this.button1_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_keyword
            // 
            this.label_keyword.AutoSize = true;
            this.label_keyword.Location = new System.Drawing.Point(23, 24);
            this.label_keyword.Name = "label_keyword";
            this.label_keyword.Size = new System.Drawing.Size(125, 18);
            this.label_keyword.TabIndex = 0;
            this.label_keyword.Text = "検索キーワード：";
            // 
            // label_category1
            // 
            this.label_category1.AutoSize = true;
            this.label_category1.Location = new System.Drawing.Point(52, 61);
            this.label_category1.Name = "label_category1";
            this.label_category1.Size = new System.Drawing.Size(96, 18);
            this.label_category1.TabIndex = 1;
            this.label_category1.Text = "カテゴリー１：";
            this.label_category1.Click += new System.EventHandler(this.label_category1_Click);
            // 
            // label_category2
            // 
            this.label_category2.AutoSize = true;
            this.label_category2.Location = new System.Drawing.Point(52, 90);
            this.label_category2.Name = "label_category2";
            this.label_category2.Size = new System.Drawing.Size(96, 18);
            this.label_category2.TabIndex = 2;
            this.label_category2.Text = "カテゴリー２：";
            // 
            // label_category3
            // 
            this.label_category3.AutoSize = true;
            this.label_category3.Location = new System.Drawing.Point(52, 122);
            this.label_category3.Name = "label_category3";
            this.label_category3.Size = new System.Drawing.Size(96, 18);
            this.label_category3.TabIndex = 3;
            this.label_category3.Text = "カテゴリー３：";
            // 
            // label_category4
            // 
            this.label_category4.AutoSize = true;
            this.label_category4.Location = new System.Drawing.Point(52, 151);
            this.label_category4.Name = "label_category4";
            this.label_category4.Size = new System.Drawing.Size(96, 18);
            this.label_category4.TabIndex = 4;
            this.label_category4.Text = "カテゴリー４：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1204, 535);
            this.dataGridView1.TabIndex = 6;
            // 
            // textBox_keyword
            // 
            this.textBox_keyword.Location = new System.Drawing.Point(154, 17);
            this.textBox_keyword.Name = "textBox_keyword";
            this.textBox_keyword.Size = new System.Drawing.Size(897, 25);
            this.textBox_keyword.TabIndex = 7;
            this.textBox_keyword.TextChanged += new System.EventHandler(this.textBox_keyword_TextChanged);
            // 
            // check_category1
            // 
            this.check_category1.AutoSize = true;
            this.check_category1.Location = new System.Drawing.Point(24, 58);
            this.check_category1.Name = "check_category1";
            this.check_category1.Size = new System.Drawing.Size(22, 21);
            this.check_category1.TabIndex = 8;
            this.check_category1.UseVisualStyleBackColor = true;
            // 
            // check_category2
            // 
            this.check_category2.AutoSize = true;
            this.check_category2.Location = new System.Drawing.Point(24, 90);
            this.check_category2.Name = "check_category2";
            this.check_category2.Size = new System.Drawing.Size(22, 21);
            this.check_category2.TabIndex = 9;
            this.check_category2.UseVisualStyleBackColor = true;
            // 
            // check_category3
            // 
            this.check_category3.AutoSize = true;
            this.check_category3.Location = new System.Drawing.Point(24, 119);
            this.check_category3.Name = "check_category3";
            this.check_category3.Size = new System.Drawing.Size(22, 21);
            this.check_category3.TabIndex = 10;
            this.check_category3.UseVisualStyleBackColor = true;
            // 
            // check_category4
            // 
            this.check_category4.AutoSize = true;
            this.check_category4.Location = new System.Drawing.Point(24, 151);
            this.check_category4.Name = "check_category4";
            this.check_category4.Size = new System.Drawing.Size(22, 21);
            this.check_category4.TabIndex = 11;
            this.check_category4.UseVisualStyleBackColor = true;
            // 
            // combo_category1
            // 
            this.combo_category1.FormattingEnabled = true;
            this.combo_category1.Location = new System.Drawing.Point(154, 53);
            this.combo_category1.Name = "combo_category1";
            this.combo_category1.Size = new System.Drawing.Size(448, 26);
            this.combo_category1.TabIndex = 12;
            // 
            // combo_category2
            // 
            this.combo_category2.FormattingEnabled = true;
            this.combo_category2.Location = new System.Drawing.Point(154, 87);
            this.combo_category2.Name = "combo_category2";
            this.combo_category2.Size = new System.Drawing.Size(448, 26);
            this.combo_category2.TabIndex = 13;
            // 
            // combo_category3
            // 
            this.combo_category3.FormattingEnabled = true;
            this.combo_category3.Location = new System.Drawing.Point(154, 119);
            this.combo_category3.Name = "combo_category3";
            this.combo_category3.Size = new System.Drawing.Size(448, 26);
            this.combo_category3.TabIndex = 14;
            // 
            // combo_category4
            // 
            this.combo_category4.FormattingEnabled = true;
            this.combo_category4.Location = new System.Drawing.Point(154, 151);
            this.combo_category4.Name = "combo_category4";
            this.combo_category4.Size = new System.Drawing.Size(448, 26);
            this.combo_category4.TabIndex = 15;
            // 
            // label_price1
            // 
            this.label_price1.AutoSize = true;
            this.label_price1.Location = new System.Drawing.Point(803, 102);
            this.label_price1.Name = "label_price1";
            this.label_price1.Size = new System.Drawing.Size(89, 18);
            this.label_price1.TabIndex = 16;
            this.label_price1.Text = "最低価格：";
            // 
            // label_price2
            // 
            this.label_price2.AutoSize = true;
            this.label_price2.Location = new System.Drawing.Point(803, 154);
            this.label_price2.Name = "label_price2";
            this.label_price2.Size = new System.Drawing.Size(89, 18);
            this.label_price2.TabIndex = 17;
            this.label_price2.Text = "最高価格：";
            // 
            // textBox_price1
            // 
            this.textBox_price1.Location = new System.Drawing.Point(898, 95);
            this.textBox_price1.Name = "textBox_price1";
            this.textBox_price1.Size = new System.Drawing.Size(153, 25);
            this.textBox_price1.TabIndex = 18;
            // 
            // textBox_price2
            // 
            this.textBox_price2.Location = new System.Drawing.Point(898, 152);
            this.textBox_price2.Name = "textBox_price2";
            this.textBox_price2.Size = new System.Drawing.Size(153, 25);
            this.textBox_price2.TabIndex = 19;
            // 
            // label_yen1
            // 
            this.label_yen1.AutoSize = true;
            this.label_yen1.Location = new System.Drawing.Point(1057, 90);
            this.label_yen1.Name = "label_yen1";
            this.label_yen1.Size = new System.Drawing.Size(26, 18);
            this.label_yen1.TabIndex = 20;
            this.label_yen1.Text = "円";
            // 
            // label_yen2
            // 
            this.label_yen2.AutoSize = true;
            this.label_yen2.Location = new System.Drawing.Point(1057, 155);
            this.label_yen2.Name = "label_yen2";
            this.label_yen2.Size = new System.Drawing.Size(26, 18);
            this.label_yen2.TabIndex = 21;
            this.label_yen2.Text = "円";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(964, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "│";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(1123, 53);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 49);
            this.button_search.TabIndex = 23;
            this.button_search.Text = "検索";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // label_quanity
            // 
            this.label_quanity.AutoSize = true;
            this.label_quanity.Location = new System.Drawing.Point(839, 58);
            this.label_quanity.Name = "label_quanity";
            this.label_quanity.Size = new System.Drawing.Size(53, 18);
            this.label_quanity.TabIndex = 24;
            this.label_quanity.Text = "数量：";
            // 
            // textBox_quanity
            // 
            this.textBox_quanity.Location = new System.Drawing.Point(899, 53);
            this.textBox_quanity.Name = "textBox_quanity";
            this.textBox_quanity.Size = new System.Drawing.Size(100, 25);
            this.textBox_quanity.TabIndex = 25;
            // 
            // button1_close
            // 
            this.button1_close.Location = new System.Drawing.Point(1123, 128);
            this.button1_close.Name = "button1_close";
            this.button1_close.Size = new System.Drawing.Size(75, 49);
            this.button1_close.TabIndex = 26;
            this.button1_close.Text = "終了";
            this.button1_close.UseVisualStyleBackColor = true;
            this.button1_close.Click += new System.EventHandler(this.button1_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 744);
            this.Controls.Add(this.button1_close);
            this.Controls.Add(this.textBox_quanity);
            this.Controls.Add(this.label_quanity);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_yen2);
            this.Controls.Add(this.label_yen1);
            this.Controls.Add(this.textBox_price2);
            this.Controls.Add(this.textBox_price1);
            this.Controls.Add(this.label_price2);
            this.Controls.Add(this.label_price1);
            this.Controls.Add(this.combo_category4);
            this.Controls.Add(this.combo_category3);
            this.Controls.Add(this.combo_category2);
            this.Controls.Add(this.combo_category1);
            this.Controls.Add(this.check_category4);
            this.Controls.Add(this.check_category3);
            this.Controls.Add(this.check_category2);
            this.Controls.Add(this.check_category1);
            this.Controls.Add(this.textBox_keyword);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_category4);
            this.Controls.Add(this.label_category3);
            this.Controls.Add(this.label_category2);
            this.Controls.Add(this.label_category1);
            this.Controls.Add(this.label_keyword);
            this.Name = "Form1";
            this.Text = "Amazon検索サービス";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_keyword;
        private System.Windows.Forms.Label label_category1;
        private System.Windows.Forms.Label label_category2;
        private System.Windows.Forms.Label label_category3;
        private System.Windows.Forms.Label label_category4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_keyword;
        private System.Windows.Forms.CheckBox check_category1;
        private System.Windows.Forms.CheckBox check_category2;
        private System.Windows.Forms.CheckBox check_category3;
        private System.Windows.Forms.CheckBox check_category4;
        private System.Windows.Forms.ComboBox combo_category1;
        private System.Windows.Forms.ComboBox combo_category2;
        private System.Windows.Forms.ComboBox combo_category3;
        private System.Windows.Forms.ComboBox combo_category4;
        private System.Windows.Forms.Label label_price1;
        private System.Windows.Forms.Label label_price2;
        private System.Windows.Forms.TextBox textBox_price1;
        private System.Windows.Forms.TextBox textBox_price2;
        private System.Windows.Forms.Label label_yen1;
        private System.Windows.Forms.Label label_yen2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label_quanity;
        private System.Windows.Forms.TextBox textBox_quanity;
        private System.Windows.Forms.Button button1_close;
    }
}

