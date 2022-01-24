
namespace WORDLE
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.txt9 = new System.Windows.Forms.TextBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt15 = new System.Windows.Forms.TextBox();
            this.txt14 = new System.Windows.Forms.TextBox();
            this.txt13 = new System.Windows.Forms.TextBox();
            this.txt12 = new System.Windows.Forms.TextBox();
            this.txt11 = new System.Windows.Forms.TextBox();
            this.txt20 = new System.Windows.Forms.TextBox();
            this.txt19 = new System.Windows.Forms.TextBox();
            this.txt18 = new System.Windows.Forms.TextBox();
            this.txt17 = new System.Windows.Forms.TextBox();
            this.txt16 = new System.Windows.Forms.TextBox();
            this.txt25 = new System.Windows.Forms.TextBox();
            this.txt24 = new System.Windows.Forms.TextBox();
            this.txt23 = new System.Windows.Forms.TextBox();
            this.txt22 = new System.Windows.Forms.TextBox();
            this.txt21 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvlcounter = new System.Windows.Forms.Label();
            this.losecontrol = new System.Windows.Forms.Timer(this.components);
            this.txt26 = new System.Windows.Forms.TextBox();
            this.txt27 = new System.Windows.Forms.TextBox();
            this.txt28 = new System.Windows.Forms.TextBox();
            this.txt29 = new System.Windows.Forms.TextBox();
            this.txt30 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.Color.DimGray;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt1.ForeColor = System.Drawing.Color.White;
            this.txt1.Location = new System.Drawing.Point(12, 99);
            this.txt1.MaxLength = 1;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(64, 65);
            this.txt1.TabIndex = 0;
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt1.TextChanged += new System.EventHandler(this.Texts);
            this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.Color.DimGray;
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt2.ForeColor = System.Drawing.Color.White;
            this.txt2.Location = new System.Drawing.Point(82, 99);
            this.txt2.MaxLength = 1;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(64, 65);
            this.txt2.TabIndex = 1;
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt2.TextChanged += new System.EventHandler(this.Texts);
            this.txt2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt3
            // 
            this.txt3.BackColor = System.Drawing.Color.DimGray;
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt3.ForeColor = System.Drawing.Color.White;
            this.txt3.Location = new System.Drawing.Point(152, 99);
            this.txt3.MaxLength = 1;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(64, 65);
            this.txt3.TabIndex = 2;
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt3.TextChanged += new System.EventHandler(this.Texts);
            this.txt3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt4
            // 
            this.txt4.BackColor = System.Drawing.Color.DimGray;
            this.txt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt4.ForeColor = System.Drawing.Color.White;
            this.txt4.Location = new System.Drawing.Point(222, 99);
            this.txt4.MaxLength = 1;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(64, 65);
            this.txt4.TabIndex = 3;
            this.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt4.TextChanged += new System.EventHandler(this.Texts);
            this.txt4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt5
            // 
            this.txt5.BackColor = System.Drawing.Color.DimGray;
            this.txt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt5.ForeColor = System.Drawing.Color.White;
            this.txt5.Location = new System.Drawing.Point(292, 99);
            this.txt5.MaxLength = 1;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(64, 65);
            this.txt5.TabIndex = 4;
            this.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt5.TextChanged += new System.EventHandler(this.Texts);
            this.txt5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt10
            // 
            this.txt10.BackColor = System.Drawing.Color.DimGray;
            this.txt10.Enabled = false;
            this.txt10.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt10.ForeColor = System.Drawing.Color.White;
            this.txt10.Location = new System.Drawing.Point(292, 170);
            this.txt10.MaxLength = 1;
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(64, 65);
            this.txt10.TabIndex = 9;
            this.txt10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt10.TextChanged += new System.EventHandler(this.Texts);
            this.txt10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt9
            // 
            this.txt9.BackColor = System.Drawing.Color.DimGray;
            this.txt9.Enabled = false;
            this.txt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt9.ForeColor = System.Drawing.Color.White;
            this.txt9.Location = new System.Drawing.Point(222, 170);
            this.txt9.MaxLength = 1;
            this.txt9.Name = "txt9";
            this.txt9.Size = new System.Drawing.Size(64, 65);
            this.txt9.TabIndex = 8;
            this.txt9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt9.TextChanged += new System.EventHandler(this.Texts);
            this.txt9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt8
            // 
            this.txt8.BackColor = System.Drawing.Color.DimGray;
            this.txt8.Enabled = false;
            this.txt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt8.ForeColor = System.Drawing.Color.White;
            this.txt8.Location = new System.Drawing.Point(152, 170);
            this.txt8.MaxLength = 1;
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(64, 65);
            this.txt8.TabIndex = 7;
            this.txt8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt8.TextChanged += new System.EventHandler(this.Texts);
            this.txt8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt7
            // 
            this.txt7.BackColor = System.Drawing.Color.DimGray;
            this.txt7.Enabled = false;
            this.txt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt7.ForeColor = System.Drawing.Color.White;
            this.txt7.Location = new System.Drawing.Point(82, 170);
            this.txt7.MaxLength = 1;
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(64, 65);
            this.txt7.TabIndex = 6;
            this.txt7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt7.TextChanged += new System.EventHandler(this.Texts);
            this.txt7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt6
            // 
            this.txt6.BackColor = System.Drawing.Color.DimGray;
            this.txt6.Enabled = false;
            this.txt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt6.ForeColor = System.Drawing.Color.White;
            this.txt6.Location = new System.Drawing.Point(12, 170);
            this.txt6.MaxLength = 1;
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(64, 65);
            this.txt6.TabIndex = 5;
            this.txt6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt6.TextChanged += new System.EventHandler(this.Texts);
            this.txt6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt15
            // 
            this.txt15.BackColor = System.Drawing.Color.DimGray;
            this.txt15.Enabled = false;
            this.txt15.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt15.ForeColor = System.Drawing.Color.White;
            this.txt15.Location = new System.Drawing.Point(292, 241);
            this.txt15.MaxLength = 1;
            this.txt15.Name = "txt15";
            this.txt15.Size = new System.Drawing.Size(64, 65);
            this.txt15.TabIndex = 14;
            this.txt15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt15.TextChanged += new System.EventHandler(this.Texts);
            this.txt15.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt14
            // 
            this.txt14.BackColor = System.Drawing.Color.DimGray;
            this.txt14.Enabled = false;
            this.txt14.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt14.ForeColor = System.Drawing.Color.White;
            this.txt14.Location = new System.Drawing.Point(222, 241);
            this.txt14.MaxLength = 1;
            this.txt14.Name = "txt14";
            this.txt14.Size = new System.Drawing.Size(64, 65);
            this.txt14.TabIndex = 13;
            this.txt14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt14.TextChanged += new System.EventHandler(this.Texts);
            this.txt14.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt13
            // 
            this.txt13.BackColor = System.Drawing.Color.DimGray;
            this.txt13.Enabled = false;
            this.txt13.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt13.ForeColor = System.Drawing.Color.White;
            this.txt13.Location = new System.Drawing.Point(152, 241);
            this.txt13.MaxLength = 1;
            this.txt13.Name = "txt13";
            this.txt13.Size = new System.Drawing.Size(64, 65);
            this.txt13.TabIndex = 12;
            this.txt13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt13.TextChanged += new System.EventHandler(this.Texts);
            this.txt13.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt12
            // 
            this.txt12.BackColor = System.Drawing.Color.DimGray;
            this.txt12.Enabled = false;
            this.txt12.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt12.ForeColor = System.Drawing.Color.White;
            this.txt12.Location = new System.Drawing.Point(82, 241);
            this.txt12.MaxLength = 1;
            this.txt12.Name = "txt12";
            this.txt12.Size = new System.Drawing.Size(64, 65);
            this.txt12.TabIndex = 11;
            this.txt12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt12.TextChanged += new System.EventHandler(this.Texts);
            this.txt12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt11
            // 
            this.txt11.BackColor = System.Drawing.Color.DimGray;
            this.txt11.Enabled = false;
            this.txt11.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt11.ForeColor = System.Drawing.Color.White;
            this.txt11.Location = new System.Drawing.Point(12, 241);
            this.txt11.MaxLength = 1;
            this.txt11.Name = "txt11";
            this.txt11.Size = new System.Drawing.Size(64, 65);
            this.txt11.TabIndex = 10;
            this.txt11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt11.TextChanged += new System.EventHandler(this.Texts);
            this.txt11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt20
            // 
            this.txt20.BackColor = System.Drawing.Color.DimGray;
            this.txt20.Enabled = false;
            this.txt20.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt20.ForeColor = System.Drawing.Color.White;
            this.txt20.Location = new System.Drawing.Point(292, 312);
            this.txt20.MaxLength = 1;
            this.txt20.Name = "txt20";
            this.txt20.Size = new System.Drawing.Size(64, 65);
            this.txt20.TabIndex = 19;
            this.txt20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt20.TextChanged += new System.EventHandler(this.Texts);
            this.txt20.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt19
            // 
            this.txt19.BackColor = System.Drawing.Color.DimGray;
            this.txt19.Enabled = false;
            this.txt19.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt19.ForeColor = System.Drawing.Color.White;
            this.txt19.Location = new System.Drawing.Point(222, 312);
            this.txt19.MaxLength = 1;
            this.txt19.Name = "txt19";
            this.txt19.Size = new System.Drawing.Size(64, 65);
            this.txt19.TabIndex = 18;
            this.txt19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt19.TextChanged += new System.EventHandler(this.Texts);
            this.txt19.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt18
            // 
            this.txt18.BackColor = System.Drawing.Color.DimGray;
            this.txt18.Enabled = false;
            this.txt18.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt18.ForeColor = System.Drawing.Color.White;
            this.txt18.Location = new System.Drawing.Point(152, 312);
            this.txt18.MaxLength = 1;
            this.txt18.Name = "txt18";
            this.txt18.Size = new System.Drawing.Size(64, 65);
            this.txt18.TabIndex = 17;
            this.txt18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt18.TextChanged += new System.EventHandler(this.Texts);
            this.txt18.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt17
            // 
            this.txt17.BackColor = System.Drawing.Color.DimGray;
            this.txt17.Enabled = false;
            this.txt17.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt17.ForeColor = System.Drawing.Color.White;
            this.txt17.Location = new System.Drawing.Point(82, 312);
            this.txt17.MaxLength = 1;
            this.txt17.Name = "txt17";
            this.txt17.Size = new System.Drawing.Size(64, 65);
            this.txt17.TabIndex = 16;
            this.txt17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt17.TextChanged += new System.EventHandler(this.Texts);
            this.txt17.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt16
            // 
            this.txt16.BackColor = System.Drawing.Color.DimGray;
            this.txt16.Enabled = false;
            this.txt16.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt16.ForeColor = System.Drawing.Color.White;
            this.txt16.Location = new System.Drawing.Point(12, 312);
            this.txt16.MaxLength = 1;
            this.txt16.Name = "txt16";
            this.txt16.Size = new System.Drawing.Size(64, 65);
            this.txt16.TabIndex = 15;
            this.txt16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt16.TextChanged += new System.EventHandler(this.Texts);
            this.txt16.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt25
            // 
            this.txt25.BackColor = System.Drawing.Color.DimGray;
            this.txt25.Enabled = false;
            this.txt25.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt25.ForeColor = System.Drawing.Color.White;
            this.txt25.Location = new System.Drawing.Point(292, 383);
            this.txt25.MaxLength = 1;
            this.txt25.Name = "txt25";
            this.txt25.Size = new System.Drawing.Size(64, 65);
            this.txt25.TabIndex = 24;
            this.txt25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt25.TextChanged += new System.EventHandler(this.Texts);
            this.txt25.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt24
            // 
            this.txt24.BackColor = System.Drawing.Color.DimGray;
            this.txt24.Enabled = false;
            this.txt24.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt24.ForeColor = System.Drawing.Color.White;
            this.txt24.Location = new System.Drawing.Point(222, 383);
            this.txt24.MaxLength = 1;
            this.txt24.Name = "txt24";
            this.txt24.Size = new System.Drawing.Size(64, 65);
            this.txt24.TabIndex = 23;
            this.txt24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt24.TextChanged += new System.EventHandler(this.Texts);
            this.txt24.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt23
            // 
            this.txt23.BackColor = System.Drawing.Color.DimGray;
            this.txt23.Enabled = false;
            this.txt23.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt23.ForeColor = System.Drawing.Color.White;
            this.txt23.Location = new System.Drawing.Point(152, 383);
            this.txt23.MaxLength = 1;
            this.txt23.Name = "txt23";
            this.txt23.Size = new System.Drawing.Size(64, 65);
            this.txt23.TabIndex = 22;
            this.txt23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt23.TextChanged += new System.EventHandler(this.Texts);
            this.txt23.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt22
            // 
            this.txt22.BackColor = System.Drawing.Color.DimGray;
            this.txt22.Enabled = false;
            this.txt22.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt22.ForeColor = System.Drawing.Color.White;
            this.txt22.Location = new System.Drawing.Point(82, 383);
            this.txt22.MaxLength = 1;
            this.txt22.Name = "txt22";
            this.txt22.Size = new System.Drawing.Size(64, 65);
            this.txt22.TabIndex = 21;
            this.txt22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt22.TextChanged += new System.EventHandler(this.Texts);
            this.txt22.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt21
            // 
            this.txt21.BackColor = System.Drawing.Color.DimGray;
            this.txt21.Enabled = false;
            this.txt21.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt21.ForeColor = System.Drawing.Color.White;
            this.txt21.Location = new System.Drawing.Point(12, 383);
            this.txt21.MaxLength = 1;
            this.txt21.Name = "txt21";
            this.txt21.Size = new System.Drawing.Size(64, 65);
            this.txt21.TabIndex = 20;
            this.txt21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt21.TextChanged += new System.EventHandler(this.Texts);
            this.txt21.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 47);
            this.panel1.TabIndex = 25;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(318, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 47);
            this.button1.TabIndex = 27;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 44);
            this.label1.TabIndex = 26;
            this.label1.Text = "WORDLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ali Kanıberk tarafından tasarlanmıştır.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lvlcounter
            // 
            this.lvlcounter.AutoSize = true;
            this.lvlcounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvlcounter.ForeColor = System.Drawing.Color.Brown;
            this.lvlcounter.Location = new System.Drawing.Point(3, 50);
            this.lvlcounter.Name = "lvlcounter";
            this.lvlcounter.Size = new System.Drawing.Size(289, 46);
            this.lvlcounter.TabIndex = 27;
            this.lvlcounter.Text = "LEVEL 1/5395";
            // 
            // losecontrol
            // 
            this.losecontrol.Enabled = true;
            this.losecontrol.Interval = 3000;
            this.losecontrol.Tick += new System.EventHandler(this.losecontrol_Tick);
            // 
            // txt26
            // 
            this.txt26.BackColor = System.Drawing.Color.DimGray;
            this.txt26.Enabled = false;
            this.txt26.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt26.ForeColor = System.Drawing.Color.White;
            this.txt26.Location = new System.Drawing.Point(12, 454);
            this.txt26.MaxLength = 1;
            this.txt26.Name = "txt26";
            this.txt26.Size = new System.Drawing.Size(64, 65);
            this.txt26.TabIndex = 20;
            this.txt26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt26.TextChanged += new System.EventHandler(this.Texts);
            this.txt26.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt27
            // 
            this.txt27.BackColor = System.Drawing.Color.DimGray;
            this.txt27.Enabled = false;
            this.txt27.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt27.ForeColor = System.Drawing.Color.White;
            this.txt27.Location = new System.Drawing.Point(82, 454);
            this.txt27.MaxLength = 1;
            this.txt27.Name = "txt27";
            this.txt27.Size = new System.Drawing.Size(64, 65);
            this.txt27.TabIndex = 21;
            this.txt27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt27.TextChanged += new System.EventHandler(this.Texts);
            this.txt27.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt28
            // 
            this.txt28.BackColor = System.Drawing.Color.DimGray;
            this.txt28.Enabled = false;
            this.txt28.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt28.ForeColor = System.Drawing.Color.White;
            this.txt28.Location = new System.Drawing.Point(152, 454);
            this.txt28.MaxLength = 1;
            this.txt28.Name = "txt28";
            this.txt28.Size = new System.Drawing.Size(64, 65);
            this.txt28.TabIndex = 22;
            this.txt28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt28.TextChanged += new System.EventHandler(this.Texts);
            this.txt28.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt29
            // 
            this.txt29.BackColor = System.Drawing.Color.DimGray;
            this.txt29.Enabled = false;
            this.txt29.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt29.ForeColor = System.Drawing.Color.White;
            this.txt29.Location = new System.Drawing.Point(222, 454);
            this.txt29.MaxLength = 1;
            this.txt29.Name = "txt29";
            this.txt29.Size = new System.Drawing.Size(64, 65);
            this.txt29.TabIndex = 23;
            this.txt29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt29.TextChanged += new System.EventHandler(this.Texts);
            this.txt29.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // txt30
            // 
            this.txt30.BackColor = System.Drawing.Color.DimGray;
            this.txt30.Enabled = false;
            this.txt30.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt30.ForeColor = System.Drawing.Color.White;
            this.txt30.Location = new System.Drawing.Point(292, 454);
            this.txt30.MaxLength = 1;
            this.txt30.Name = "txt30";
            this.txt30.Size = new System.Drawing.Size(64, 65);
            this.txt30.TabIndex = 24;
            this.txt30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt30.TextChanged += new System.EventHandler(this.Texts);
            this.txt30.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextsControl);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(369, 551);
            this.Controls.Add(this.lvlcounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt30);
            this.Controls.Add(this.txt25);
            this.Controls.Add(this.txt29);
            this.Controls.Add(this.txt24);
            this.Controls.Add(this.txt28);
            this.Controls.Add(this.txt27);
            this.Controls.Add(this.txt23);
            this.Controls.Add(this.txt26);
            this.Controls.Add(this.txt22);
            this.Controls.Add(this.txt21);
            this.Controls.Add(this.txt20);
            this.Controls.Add(this.txt19);
            this.Controls.Add(this.txt18);
            this.Controls.Add(this.txt17);
            this.Controls.Add(this.txt16);
            this.Controls.Add(this.txt15);
            this.Controls.Add(this.txt14);
            this.Controls.Add(this.txt13);
            this.Controls.Add(this.txt12);
            this.Controls.Add(this.txt11);
            this.Controls.Add(this.txt10);
            this.Controls.Add(this.txt9);
            this.Controls.Add(this.txt8);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WORDLE";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.TextBox txt9;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt15;
        private System.Windows.Forms.TextBox txt14;
        private System.Windows.Forms.TextBox txt13;
        private System.Windows.Forms.TextBox txt12;
        private System.Windows.Forms.TextBox txt11;
        private System.Windows.Forms.TextBox txt20;
        private System.Windows.Forms.TextBox txt19;
        private System.Windows.Forms.TextBox txt18;
        private System.Windows.Forms.TextBox txt17;
        private System.Windows.Forms.TextBox txt16;
        private System.Windows.Forms.TextBox txt25;
        private System.Windows.Forms.TextBox txt24;
        private System.Windows.Forms.TextBox txt23;
        private System.Windows.Forms.TextBox txt22;
        private System.Windows.Forms.TextBox txt21;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lvlcounter;
        private System.Windows.Forms.Timer losecontrol;
        private System.Windows.Forms.TextBox txt26;
        private System.Windows.Forms.TextBox txt27;
        private System.Windows.Forms.TextBox txt28;
        private System.Windows.Forms.TextBox txt29;
        private System.Windows.Forms.TextBox txt30;
    }
}

