namespace programa_de_manutencao_de_aeronaves
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialTabControl4 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.materialTabSelector3 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabControl3 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.cond_combo = new MaterialSkin.Controls.MaterialComboBox();
            this.pn_text = new MaterialSkin.Controls.MaterialTextBox();
            this.sn_text = new MaterialSkin.Controls.MaterialTextBox();
            this.part_desc = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.matricula_txt = new MaterialSkin.Controls.MaterialTextBox2();
            this.frota_combo = new MaterialSkin.Controls.MaterialComboBox();
            this.inseriraeronave = new MaterialSkin.Controls.MaterialButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialMaskedTextBox1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.tabPage3.SuspendLayout();
            this.materialTabControl4.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.materialTabControl3.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.materialTabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "aviao-alt.png");
            this.imageList1.Images.SetKeyName(1, "ferramentas.png");
            this.imageList1.Images.SetKeyName(2, "motor.png");
            // 
            // mySqlCommandBuilder1
            // 
            this.mySqlCommandBuilder1.DataAdapter = null;
            this.mySqlCommandBuilder1.QuotePrefix = "`";
            this.mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialTabSelector3);
            this.tabPage3.Controls.Add(this.materialTabControl4);
            this.tabPage3.ImageKey = "ferramentas.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(862, 388);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manutenções";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialTabControl4
            // 
            this.materialTabControl4.Controls.Add(this.tabPage8);
            this.materialTabControl4.Controls.Add(this.tabPage9);
            this.materialTabControl4.Depth = 0;
            this.materialTabControl4.Location = new System.Drawing.Point(6, 41);
            this.materialTabControl4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl4.Multiline = true;
            this.materialTabControl4.Name = "materialTabControl4";
            this.materialTabControl4.SelectedIndex = 0;
            this.materialTabControl4.Size = new System.Drawing.Size(836, 345);
            this.materialTabControl4.TabIndex = 2;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(828, 319);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Cadastro";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.dataGridView3);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(828, 319);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Consulta";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(11, 38);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(806, 242);
            this.dataGridView3.TabIndex = 1;
            // 
            // materialTabSelector3
            // 
            this.materialTabSelector3.BaseTabControl = this.materialTabControl4;
            this.materialTabSelector3.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector3.Depth = 0;
            this.materialTabSelector3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector3.Location = new System.Drawing.Point(0, -5);
            this.materialTabSelector3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector3.Name = "materialTabSelector3";
            this.materialTabSelector3.Size = new System.Drawing.Size(890, 40);
            this.materialTabSelector3.TabIndex = 3;
            this.materialTabSelector3.Text = "materialTabSelector3";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialTabSelector2);
            this.tabPage2.Controls.Add(this.materialTabControl3);
            this.tabPage2.ImageKey = "motor.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(862, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Partes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialTabControl3
            // 
            this.materialTabControl3.Controls.Add(this.tabPage6);
            this.materialTabControl3.Controls.Add(this.tabPage7);
            this.materialTabControl3.Depth = 0;
            this.materialTabControl3.Location = new System.Drawing.Point(6, 41);
            this.materialTabControl3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl3.Multiline = true;
            this.materialTabControl3.Name = "materialTabControl3";
            this.materialTabControl3.SelectedIndex = 0;
            this.materialTabControl3.Size = new System.Drawing.Size(836, 345);
            this.materialTabControl3.TabIndex = 2;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.materialButton2);
            this.tabPage7.Controls.Add(this.part_desc);
            this.tabPage7.Controls.Add(this.sn_text);
            this.tabPage7.Controls.Add(this.pn_text);
            this.tabPage7.Controls.Add(this.cond_combo);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(828, 319);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Cadastro";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // cond_combo
            // 
            this.cond_combo.AutoResize = false;
            this.cond_combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cond_combo.Depth = 0;
            this.cond_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cond_combo.DropDownHeight = 174;
            this.cond_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cond_combo.DropDownWidth = 121;
            this.cond_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cond_combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cond_combo.FormattingEnabled = true;
            this.cond_combo.Hint = "Condition";
            this.cond_combo.IntegralHeight = false;
            this.cond_combo.ItemHeight = 43;
            this.cond_combo.Items.AddRange(new object[] {
            "Inspected",
            "New",
            "Overhaul"});
            this.cond_combo.Location = new System.Drawing.Point(574, 185);
            this.cond_combo.MaxDropDownItems = 4;
            this.cond_combo.MouseState = MaterialSkin.MouseState.OUT;
            this.cond_combo.Name = "cond_combo";
            this.cond_combo.Size = new System.Drawing.Size(235, 49);
            this.cond_combo.StartIndex = 0;
            this.cond_combo.TabIndex = 0;
            // 
            // pn_text
            // 
            this.pn_text.AnimateReadOnly = false;
            this.pn_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pn_text.Depth = 0;
            this.pn_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pn_text.Hint = "Part Number";
            this.pn_text.LeadingIcon = null;
            this.pn_text.Location = new System.Drawing.Point(23, 184);
            this.pn_text.MaxLength = 40;
            this.pn_text.MouseState = MaterialSkin.MouseState.OUT;
            this.pn_text.Multiline = false;
            this.pn_text.Name = "pn_text";
            this.pn_text.Size = new System.Drawing.Size(238, 50);
            this.pn_text.TabIndex = 2;
            this.pn_text.Text = "";
            this.pn_text.TrailingIcon = null;
            // 
            // sn_text
            // 
            this.sn_text.AnimateReadOnly = false;
            this.sn_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sn_text.Depth = 0;
            this.sn_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sn_text.Hint = "Serial Number";
            this.sn_text.LeadingIcon = null;
            this.sn_text.Location = new System.Drawing.Point(290, 184);
            this.sn_text.MaxLength = 40;
            this.sn_text.MouseState = MaterialSkin.MouseState.OUT;
            this.sn_text.Multiline = false;
            this.sn_text.Name = "sn_text";
            this.sn_text.Size = new System.Drawing.Size(238, 50);
            this.sn_text.TabIndex = 3;
            this.sn_text.Text = "";
            this.sn_text.TrailingIcon = null;
            // 
            // part_desc
            // 
            this.part_desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.part_desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.part_desc.Depth = 0;
            this.part_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.part_desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.part_desc.Hint = "Part Description";
            this.part_desc.Location = new System.Drawing.Point(23, 43);
            this.part_desc.MaxLength = 40;
            this.part_desc.MouseState = MaterialSkin.MouseState.HOVER;
            this.part_desc.Name = "part_desc";
            this.part_desc.Size = new System.Drawing.Size(238, 111);
            this.part_desc.TabIndex = 4;
            this.part_desc.Text = "";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(374, 274);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(76, 36);
            this.materialButton2.TabIndex = 5;
            this.materialButton2.Text = "Inserir";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.materialTextBox2);
            this.tabPage6.Controls.Add(this.materialTextBox1);
            this.tabPage6.Controls.Add(this.dataGridView2);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(828, 319);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Consulta";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Location = new System.Drawing.Point(135, 83);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(537, 215);
            this.dataGridView2.TabIndex = 1;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "Part Number";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(10, 18);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(278, 50);
            this.materialTextBox1.TabIndex = 2;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("materialTextBox1.TrailingIcon")));
            this.materialTextBox1.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.Hint = "Serial Number";
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(489, 17);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(278, 50);
            this.materialTextBox2.TabIndex = 3;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("materialTextBox2.TrailingIcon")));
            this.materialTextBox2.TextChanged += new System.EventHandler(this.materialTextBox2_TextChanged);
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = this.materialTabControl3;
            this.materialTabSelector2.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector2.Location = new System.Drawing.Point(0, -5);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(890, 40);
            this.materialTabSelector2.TabIndex = 3;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialTabSelector1);
            this.tabPage1.Controls.Add(this.materialTabControl2);
            this.tabPage1.ImageKey = "aviao-alt.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(862, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aeronaves";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.tabPage4);
            this.materialTabControl2.Controls.Add(this.tabPage5);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Location = new System.Drawing.Point(6, 41);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Multiline = true;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(852, 342);
            this.materialTabControl2.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.inseriraeronave);
            this.tabPage5.Controls.Add(this.frota_combo);
            this.tabPage5.Controls.Add(this.matricula_txt);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(828, 316);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Cadastro";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // matricula_txt
            // 
            this.matricula_txt.AnimateReadOnly = false;
            this.matricula_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.matricula_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.matricula_txt.Depth = 0;
            this.matricula_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.matricula_txt.HideSelection = true;
            this.matricula_txt.Hint = "Matrícula da Aeronave";
            this.matricula_txt.LeadingIcon = null;
            this.matricula_txt.Location = new System.Drawing.Point(6, 93);
            this.matricula_txt.MaxLength = 32767;
            this.matricula_txt.MouseState = MaterialSkin.MouseState.OUT;
            this.matricula_txt.Name = "matricula_txt";
            this.matricula_txt.PasswordChar = '\0';
            this.matricula_txt.PrefixSuffixText = null;
            this.matricula_txt.ReadOnly = false;
            this.matricula_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.matricula_txt.SelectedText = "";
            this.matricula_txt.SelectionLength = 0;
            this.matricula_txt.SelectionStart = 0;
            this.matricula_txt.ShortcutsEnabled = true;
            this.matricula_txt.Size = new System.Drawing.Size(250, 48);
            this.matricula_txt.TabIndex = 0;
            this.matricula_txt.TabStop = false;
            this.matricula_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.matricula_txt.TrailingIcon = null;
            this.matricula_txt.UseSystemPasswordChar = false;
            // 
            // frota_combo
            // 
            this.frota_combo.AutoResize = false;
            this.frota_combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.frota_combo.Depth = 0;
            this.frota_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.frota_combo.DropDownHeight = 174;
            this.frota_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.frota_combo.DropDownWidth = 121;
            this.frota_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.frota_combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.frota_combo.FormattingEnabled = true;
            this.frota_combo.IntegralHeight = false;
            this.frota_combo.ItemHeight = 43;
            this.frota_combo.Items.AddRange(new object[] {
            "S76",
            "H135",
            "H155",
            "AW139",
            "AW189"});
            this.frota_combo.Location = new System.Drawing.Point(584, 92);
            this.frota_combo.MaxDropDownItems = 4;
            this.frota_combo.MouseState = MaterialSkin.MouseState.OUT;
            this.frota_combo.Name = "frota_combo";
            this.frota_combo.Size = new System.Drawing.Size(238, 49);
            this.frota_combo.StartIndex = 0;
            this.frota_combo.TabIndex = 1;
            // 
            // inseriraeronave
            // 
            this.inseriraeronave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inseriraeronave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.inseriraeronave.Depth = 0;
            this.inseriraeronave.HighEmphasis = true;
            this.inseriraeronave.Icon = null;
            this.inseriraeronave.Location = new System.Drawing.Point(320, 261);
            this.inseriraeronave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.inseriraeronave.MouseState = MaterialSkin.MouseState.HOVER;
            this.inseriraeronave.Name = "inseriraeronave";
            this.inseriraeronave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.inseriraeronave.Size = new System.Drawing.Size(76, 36);
            this.inseriraeronave.TabIndex = 2;
            this.inseriraeronave.Text = "Inserir";
            this.inseriraeronave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.inseriraeronave.UseAccentColor = false;
            this.inseriraeronave.UseVisualStyleBackColor = true;
            this.inseriraeronave.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.materialButton1);
            this.tabPage4.Controls.Add(this.materialFloatingActionButton1);
            this.tabPage4.Controls.Add(this.materialComboBox1);
            this.tabPage4.Controls.Add(this.materialMaskedTextBox1);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(844, 316);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Consulta";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(69, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(537, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // materialMaskedTextBox1
            // 
            this.materialMaskedTextBox1.AllowPromptAsInput = true;
            this.materialMaskedTextBox1.AnimateReadOnly = false;
            this.materialMaskedTextBox1.AsciiOnly = false;
            this.materialMaskedTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox1.BeepOnError = false;
            this.materialMaskedTextBox1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.Depth = 0;
            this.materialMaskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox1.HelperText = "Digite aqui para filtrar pela matrícula da aeronave.";
            this.materialMaskedTextBox1.HidePromptOnLeave = false;
            this.materialMaskedTextBox1.HideSelection = true;
            this.materialMaskedTextBox1.Hint = "Matrícula da Aeronave";
            this.materialMaskedTextBox1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox1.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("materialMaskedTextBox1.LeadingIcon")));
            this.materialMaskedTextBox1.Location = new System.Drawing.Point(10, 18);
            this.materialMaskedTextBox1.Mask = "";
            this.materialMaskedTextBox1.MaxLength = 32767;
            this.materialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            this.materialMaskedTextBox1.PasswordChar = '\0';
            this.materialMaskedTextBox1.PrefixSuffixText = null;
            this.materialMaskedTextBox1.PromptChar = '_';
            this.materialMaskedTextBox1.ReadOnly = false;
            this.materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox1.ResetOnPrompt = true;
            this.materialMaskedTextBox1.ResetOnSpace = true;
            this.materialMaskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox1.SelectedText = "";
            this.materialMaskedTextBox1.SelectionLength = 0;
            this.materialMaskedTextBox1.SelectionStart = 0;
            this.materialMaskedTextBox1.ShortcutsEnabled = true;
            this.materialMaskedTextBox1.Size = new System.Drawing.Size(258, 48);
            this.materialMaskedTextBox1.SkipLiterals = true;
            this.materialMaskedTextBox1.TabIndex = 1;
            this.materialMaskedTextBox1.TabStop = false;
            this.materialMaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.TrailingIcon = null;
            this.materialMaskedTextBox1.UseSystemPasswordChar = false;
            this.materialMaskedTextBox1.ValidatingType = null;
            this.materialMaskedTextBox1.TextChanged += new System.EventHandler(this.materialMaskedTextBox1_TextChanged);
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "S76",
            "H135",
            "H155",
            "AW139",
            "AW189"});
            this.materialComboBox1.Location = new System.Drawing.Point(489, 17);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(242, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 2;
            this.materialComboBox1.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // materialFloatingActionButton1
            // 
            this.materialFloatingActionButton1.Depth = 0;
            this.materialFloatingActionButton1.Icon = null;
            this.materialFloatingActionButton1.Location = new System.Drawing.Point(751, 22);
            this.materialFloatingActionButton1.Mini = true;
            this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.Size = new System.Drawing.Size(40, 40);
            this.materialFloatingActionButton1.TabIndex = 3;
            this.materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.UseVisualStyleBackColor = true;
            this.materialFloatingActionButton1.Click += new System.EventHandler(this.materialFloatingActionButton1_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl2;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, -5);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(890, 40);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 67);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(870, 415);
            this.materialTabControl1.TabIndex = 0;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(679, 117);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(149, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Gerar Relatório";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 488);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 3);
            this.Sizable = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.materialTabControl4.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.materialTabControl3.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.materialTabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ImageList imageList1;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector3;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl4;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl3;
        private System.Windows.Forms.TabPage tabPage6;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage7;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox part_desc;
        private MaterialSkin.Controls.MaterialTextBox sn_text;
        private MaterialSkin.Controls.MaterialTextBox pn_text;
        private MaterialSkin.Controls.MaterialComboBox cond_combo;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage5;
        private MaterialSkin.Controls.MaterialButton inseriraeronave;
        private MaterialSkin.Controls.MaterialComboBox frota_combo;
        private MaterialSkin.Controls.MaterialTextBox2 matricula_txt;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}

