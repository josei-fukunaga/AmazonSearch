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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_keyword = new System.Windows.Forms.Label();
            this.label_category1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_keyword = new System.Windows.Forms.TextBox();
            this.combo_category1 = new System.Windows.Forms.ComboBox();
            this.label_price_low = new System.Windows.Forms.Label();
            this.label_price_high = new System.Windows.Forms.Label();
            this.textBox_price_low = new System.Windows.Forms.TextBox();
            this.textBox_price_high = new System.Windows.Forms.TextBox();
            this.label_yen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.button1_close = new System.Windows.Forms.Button();
            this.comboBox_alias1 = new System.Windows.Forms.ComboBox();
            this.checkBox_price = new System.Windows.Forms.CheckBox();
            this.button_ExcelOutput = new System.Windows.Forms.Button();
            this.comboBox_image = new System.Windows.Forms.ComboBox();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.LinkURL = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_keyword
            // 
            this.label_keyword.AutoSize = true;
            this.label_keyword.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_keyword.Location = new System.Drawing.Point(8, 35);
            this.label_keyword.Name = "label_keyword";
            this.label_keyword.Size = new System.Drawing.Size(152, 22);
            this.label_keyword.TabIndex = 0;
            this.label_keyword.Text = "検索キーワード：";
            // 
            // label_category1
            // 
            this.label_category1.AutoSize = true;
            this.label_category1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_category1.Location = new System.Drawing.Point(58, 108);
            this.label_category1.Name = "label_category1";
            this.label_category1.Size = new System.Drawing.Size(102, 22);
            this.label_category1.TabIndex = 1;
            this.label_category1.Text = "カテゴリー：";
            this.label_category1.Click += new System.EventHandler(this.label_category1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Price,
            this.Image,
            this.LinkURL});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1554, 745);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // textBox_keyword
            // 
            this.textBox_keyword.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_keyword.Location = new System.Drawing.Point(188, 32);
            this.textBox_keyword.Name = "textBox_keyword";
            this.textBox_keyword.Size = new System.Drawing.Size(897, 29);
            this.textBox_keyword.TabIndex = 7;
            this.textBox_keyword.TextChanged += new System.EventHandler(this.textBox_keyword_TextChanged);
            // 
            // combo_category1
            // 
            this.combo_category1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_category1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.combo_category1.FormattingEnabled = true;
            this.combo_category1.Location = new System.Drawing.Point(188, 105);
            this.combo_category1.Name = "combo_category1";
            this.combo_category1.Size = new System.Drawing.Size(543, 30);
            this.combo_category1.TabIndex = 12;
            this.combo_category1.SelectedIndexChanged += new System.EventHandler(this.combo_category1_SelectedIndexChanged);
            // 
            // label_price_low
            // 
            this.label_price_low.AutoSize = true;
            this.label_price_low.Enabled = false;
            this.label_price_low.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_price_low.Location = new System.Drawing.Point(1062, 94);
            this.label_price_low.Name = "label_price_low";
            this.label_price_low.Size = new System.Drawing.Size(53, 18);
            this.label_price_low.TabIndex = 16;
            this.label_price_low.Text = "最低：";
            // 
            // label_price_high
            // 
            this.label_price_high.AutoSize = true;
            this.label_price_high.Enabled = false;
            this.label_price_high.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_price_high.Location = new System.Drawing.Point(1259, 94);
            this.label_price_high.Name = "label_price_high";
            this.label_price_high.Size = new System.Drawing.Size(53, 18);
            this.label_price_high.TabIndex = 17;
            this.label_price_high.Text = "最高：";
            // 
            // textBox_price_low
            // 
            this.textBox_price_low.Enabled = false;
            this.textBox_price_low.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_price_low.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox_price_low.Location = new System.Drawing.Point(1009, 120);
            this.textBox_price_low.Name = "textBox_price_low";
            this.textBox_price_low.Size = new System.Drawing.Size(153, 29);
            this.textBox_price_low.TabIndex = 18;
            this.textBox_price_low.WordWrap = false;
            // 
            // textBox_price_high
            // 
            this.textBox_price_high.Enabled = false;
            this.textBox_price_high.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_price_high.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox_price_high.Location = new System.Drawing.Point(1206, 120);
            this.textBox_price_high.Name = "textBox_price_high";
            this.textBox_price_high.Size = new System.Drawing.Size(153, 29);
            this.textBox_price_high.TabIndex = 19;
            this.textBox_price_high.WordWrap = false;
            // 
            // label_yen
            // 
            this.label_yen.AutoSize = true;
            this.label_yen.Enabled = false;
            this.label_yen.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_yen.Location = new System.Drawing.Point(1365, 123);
            this.label_yen.Name = "label_yen";
            this.label_yen.Size = new System.Drawing.Size(32, 22);
            this.label_yen.TabIndex = 21;
            this.label_yen.Text = "円";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(1171, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "～";
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_search.Location = new System.Drawing.Point(1445, 21);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(121, 36);
            this.button_search.TabIndex = 23;
            this.button_search.Text = "検索";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button1_close
            // 
            this.button1_close.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1_close.Location = new System.Drawing.Point(1445, 68);
            this.button1_close.Name = "button1_close";
            this.button1_close.Size = new System.Drawing.Size(121, 33);
            this.button1_close.TabIndex = 26;
            this.button1_close.Text = "終了";
            this.button1_close.UseVisualStyleBackColor = true;
            this.button1_close.Click += new System.EventHandler(this.button1_close_Click);
            // 
            // comboBox_alias1
            // 
            this.comboBox_alias1.FormattingEnabled = true;
            this.comboBox_alias1.Location = new System.Drawing.Point(760, 126);
            this.comboBox_alias1.Name = "comboBox_alias1";
            this.comboBox_alias1.Size = new System.Drawing.Size(121, 26);
            this.comboBox_alias1.TabIndex = 27;
            this.comboBox_alias1.Visible = false;
            // 
            // checkBox_price
            // 
            this.checkBox_price.AutoSize = true;
            this.checkBox_price.Location = new System.Drawing.Point(913, 123);
            this.checkBox_price.Name = "checkBox_price";
            this.checkBox_price.Size = new System.Drawing.Size(79, 22);
            this.checkBox_price.TabIndex = 28;
            this.checkBox_price.Text = "価格：";
            this.checkBox_price.UseVisualStyleBackColor = true;
            this.checkBox_price.Click += new System.EventHandler(this.checkBox_price_Click);
            // 
            // button_ExcelOutput
            // 
            this.button_ExcelOutput.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_ExcelOutput.Location = new System.Drawing.Point(1445, 112);
            this.button_ExcelOutput.Name = "button_ExcelOutput";
            this.button_ExcelOutput.Size = new System.Drawing.Size(121, 33);
            this.button_ExcelOutput.TabIndex = 29;
            this.button_ExcelOutput.Text = "Excel出力";
            this.button_ExcelOutput.UseVisualStyleBackColor = true;
            this.button_ExcelOutput.Click += new System.EventHandler(this.button_ExcelOutput_Click);
            // 
            // comboBox_image
            // 
            this.comboBox_image.FormattingEnabled = true;
            this.comboBox_image.Location = new System.Drawing.Point(760, 86);
            this.comboBox_image.Name = "comboBox_image";
            this.comboBox_image.Size = new System.Drawing.Size(122, 26);
            this.comboBox_image.TabIndex = 30;
            this.comboBox_image.Visible = false;
            // 
            // Product
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Product.DefaultCellStyle = dataGridViewCellStyle2;
            this.Product.HeaderText = "商品名";
            this.Product.MinimumWidth = 8;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 150;
            // 
            // Price
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Price.DefaultCellStyle = dataGridViewCellStyle3;
            this.Price.HeaderText = "価格";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 150;
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Image.HeaderText = "画像";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.MinimumWidth = 8;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 50;
            // 
            // LinkURL
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LinkURL.DefaultCellStyle = dataGridViewCellStyle4;
            this.LinkURL.HeaderText = "商品URL";
            this.LinkURL.MinimumWidth = 8;
            this.LinkURL.Name = "LinkURL";
            this.LinkURL.ReadOnly = true;
            this.LinkURL.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 924);
            this.Controls.Add(this.comboBox_image);
            this.Controls.Add(this.button_ExcelOutput);
            this.Controls.Add(this.checkBox_price);
            this.Controls.Add(this.comboBox_alias1);
            this.Controls.Add(this.button1_close);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_yen);
            this.Controls.Add(this.textBox_price_high);
            this.Controls.Add(this.textBox_price_low);
            this.Controls.Add(this.label_price_high);
            this.Controls.Add(this.label_price_low);
            this.Controls.Add(this.combo_category1);
            this.Controls.Add(this.textBox_keyword);
            this.Controls.Add(this.dataGridView1);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_keyword;
        private System.Windows.Forms.ComboBox combo_category1;
        private System.Windows.Forms.Label label_price_low;
        private System.Windows.Forms.Label label_price_high;
        private System.Windows.Forms.TextBox textBox_price_low;
        private System.Windows.Forms.TextBox textBox_price_high;
        private System.Windows.Forms.Label label_yen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button1_close;
        private System.Windows.Forms.ComboBox comboBox_alias1;
        private System.Windows.Forms.CheckBox checkBox_price;
        private System.Windows.Forms.Button button_ExcelOutput;
        private System.Windows.Forms.ComboBox comboBox_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewLinkColumn LinkURL;
    }
}

