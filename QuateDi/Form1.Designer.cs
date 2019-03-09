namespace QuateDi
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Connect = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Img = new System.Windows.Forms.PictureBox();
            this.Quate = new System.Windows.Forms.RichTextBox();
            this.select = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.five = new System.Windows.Forms.RadioButton();
            this.tenn = new System.Windows.Forms.RadioButton();
            this.there = new System.Windows.Forms.RadioButton();
            this.checkCr1 = new System.Windows.Forms.CheckBox();
            this.OneMin = new System.Windows.Forms.RadioButton();
            this.min20 = new System.Windows.Forms.RadioButton();
            this.valPost = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.black = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crheight = new System.Windows.Forms.TextBox();
            this.crwidth = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.randQ = new System.Windows.Forms.RadioButton();
            this.RandomDouble = new System.Windows.Forms.RadioButton();
            this.last = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connect
            // 
            resources.ApplyResources(this.Connect, "Connect");
            this.Connect.Name = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Log
            // 
            resources.ApplyResources(this.Log, "Log");
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id
            // 
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // Img
            // 
            resources.ApplyResources(this.Img, "Img");
            this.Img.Name = "Img";
            this.Img.TabStop = false;
            // 
            // Quate
            // 
            this.Quate.HideSelection = false;
            resources.ApplyResources(this.Quate, "Quate");
            this.Quate.Name = "Quate";
            this.Quate.ReadOnly = true;
            // 
            // select
            // 
            this.select.FormattingEnabled = true;
            this.select.Items.AddRange(new object[] {
            resources.GetString("select.Items"),
            resources.GetString("select.Items1"),
            resources.GetString("select.Items2"),
            resources.GetString("select.Items3"),
            resources.GetString("select.Items4"),
            resources.GetString("select.Items5"),
            resources.GetString("select.Items6"),
            resources.GetString("select.Items7"),
            resources.GetString("select.Items8"),
            resources.GetString("select.Items9"),
            resources.GetString("select.Items10"),
            resources.GetString("select.Items11"),
            resources.GetString("select.Items12"),
            resources.GetString("select.Items13"),
            resources.GetString("select.Items14"),
            resources.GetString("select.Items15"),
            resources.GetString("select.Items16"),
            resources.GetString("select.Items17"),
            resources.GetString("select.Items18"),
            resources.GetString("select.Items19"),
            resources.GetString("select.Items20"),
            resources.GetString("select.Items21"),
            resources.GetString("select.Items22"),
            resources.GetString("select.Items23"),
            resources.GetString("select.Items24"),
            resources.GetString("select.Items25"),
            resources.GetString("select.Items26"),
            resources.GetString("select.Items27"),
            resources.GetString("select.Items28"),
            resources.GetString("select.Items29"),
            resources.GetString("select.Items30"),
            resources.GetString("select.Items31"),
            resources.GetString("select.Items32"),
            resources.GetString("select.Items33"),
            resources.GetString("select.Items34"),
            resources.GetString("select.Items35"),
            resources.GetString("select.Items36"),
            resources.GetString("select.Items37"),
            resources.GetString("select.Items38"),
            resources.GetString("select.Items39"),
            resources.GetString("select.Items40"),
            resources.GetString("select.Items41"),
            resources.GetString("select.Items42"),
            resources.GetString("select.Items43"),
            resources.GetString("select.Items44"),
            resources.GetString("select.Items45"),
            resources.GetString("select.Items46"),
            resources.GetString("select.Items47"),
            resources.GetString("select.Items48")});
            resources.ApplyResources(this.select, "select");
            this.select.Name = "select";
            this.select.SelectedIndexChanged += new System.EventHandler(this.select_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // five
            // 
            resources.ApplyResources(this.five, "five");
            this.five.Name = "five";
            this.five.UseVisualStyleBackColor = true;
            this.five.CheckedChanged += new System.EventHandler(this.five_CheckedChanged);
            // 
            // tenn
            // 
            resources.ApplyResources(this.tenn, "tenn");
            this.tenn.Name = "tenn";
            this.tenn.UseVisualStyleBackColor = true;
            this.tenn.CheckedChanged += new System.EventHandler(this.tenn_CheckedChanged);
            // 
            // there
            // 
            resources.ApplyResources(this.there, "there");
            this.there.Name = "there";
            this.there.UseVisualStyleBackColor = true;
            this.there.CheckedChanged += new System.EventHandler(this.there_CheckedChanged);
            // 
            // checkCr1
            // 
            resources.ApplyResources(this.checkCr1, "checkCr1");
            this.checkCr1.Name = "checkCr1";
            this.checkCr1.UseVisualStyleBackColor = true;
            // 
            // OneMin
            // 
            resources.ApplyResources(this.OneMin, "OneMin");
            this.OneMin.Name = "OneMin";
            this.OneMin.UseVisualStyleBackColor = true;
            this.OneMin.CheckedChanged += new System.EventHandler(this.OneMin_CheckedChanged);
            // 
            // min20
            // 
            resources.ApplyResources(this.min20, "min20");
            this.min20.Name = "min20";
            this.min20.UseVisualStyleBackColor = true;
            this.min20.CheckedChanged += new System.EventHandler(this.min20_CheckedChanged);
            // 
            // valPost
            // 
            resources.ApplyResources(this.valPost, "valPost");
            this.valPost.Name = "valPost";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tenn);
            this.groupBox1.Controls.Add(this.there);
            this.groupBox1.Controls.Add(this.OneMin);
            this.groupBox1.Controls.Add(this.min20);
            this.groupBox1.Controls.Add(this.five);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.black);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.crheight);
            this.groupBox2.Controls.Add(this.crwidth);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // black
            // 
            resources.ApplyResources(this.black, "black");
            this.black.Name = "black";
            this.black.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // crheight
            // 
            resources.ApplyResources(this.crheight, "crheight");
            this.crheight.Name = "crheight";
            // 
            // crwidth
            // 
            resources.ApplyResources(this.crwidth, "crwidth");
            this.crwidth.Name = "crwidth";
            // 
            // timer2
            // 
            this.timer2.Interval = 300000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // randQ
            // 
            resources.ApplyResources(this.randQ, "randQ");
            this.randQ.Name = "randQ";
            this.randQ.UseVisualStyleBackColor = true;
            this.randQ.CheckedChanged += new System.EventHandler(this.randQ_CheckedChanged);
            // 
            // RandomDouble
            // 
            resources.ApplyResources(this.RandomDouble, "RandomDouble");
            this.RandomDouble.Name = "RandomDouble";
            this.RandomDouble.UseVisualStyleBackColor = true;
            // 
            // last
            // 
            resources.ApplyResources(this.last, "last");
            this.last.Name = "last";
            this.last.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.last);
            this.Controls.Add(this.RandomDouble);
            this.Controls.Add(this.randQ);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.valPost);
            this.Controls.Add(this.checkCr1);
            this.Controls.Add(this.select);
            this.Controls.Add(this.Quate);
            this.Controls.Add(this.Img);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Img)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.RichTextBox Log;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox Img;
        private System.Windows.Forms.RichTextBox Quate;
        private System.Windows.Forms.ComboBox select;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton five;
        private System.Windows.Forms.RadioButton tenn;
        private System.Windows.Forms.RadioButton there;
        private System.Windows.Forms.CheckBox checkCr1;
        private System.Windows.Forms.RadioButton OneMin;
        private System.Windows.Forms.RadioButton min20;
        private System.Windows.Forms.Label valPost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox crheight;
        private System.Windows.Forms.TextBox crwidth;
        private System.Windows.Forms.RadioButton black;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton randQ;
        private System.Windows.Forms.RadioButton RandomDouble;
        private System.Windows.Forms.CheckBox last;
    }
}

