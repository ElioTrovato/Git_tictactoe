namespace TicTacToe2
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.C1 = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A1 = new System.Windows.Forms.Button();
            this.Exit = new MaterialSkin.Controls.MaterialFlatButton();
            this.New = new MaterialSkin.Controls.MaterialFlatButton();
            this.x_win_count = new MaterialSkin.Controls.MaterialLabel();
            this.draw_count = new MaterialSkin.Controls.MaterialLabel();
            this.o_win_count = new MaterialSkin.Controls.MaterialLabel();
            this.p2 = new MaterialSkin.Controls.MaterialLabel();
            this.p1 = new MaterialSkin.Controls.MaterialLabel();
            this.Reset = new MaterialSkin.Controls.MaterialFlatButton();
            this.PvsC = new MaterialSkin.Controls.MaterialRadioButton();
            this.PvsP = new MaterialSkin.Controls.MaterialRadioButton();
            this.label = new System.Windows.Forms.Label();
            this.draw = new MaterialSkin.Controls.MaterialLabel();
            this.test = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.C1);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.C3);
            this.panel1.Controls.Add(this.C2);
            this.panel1.Controls.Add(this.B1);
            this.panel1.Controls.Add(this.B2);
            this.panel1.Controls.Add(this.B3);
            this.panel1.Controls.Add(this.A2);
            this.panel1.Controls.Add(this.A3);
            this.panel1.Controls.Add(this.A1);
            this.panel1.Location = new System.Drawing.Point(0, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 324);
            this.panel1.TabIndex = 3;
            // 
            // materialLabel4
            // 
            this.materialLabel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(102, -1);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(7, 325);
            this.materialLabel4.TabIndex = 12;
            // 
            // materialLabel3
            // 
            this.materialLabel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(222, -1);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(7, 325);
            this.materialLabel3.TabIndex = 11;
            // 
            // materialLabel2
            // 
            this.materialLabel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(-1, 223);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(339, 7);
            this.materialLabel2.TabIndex = 10;
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.Chartreuse;
            this.C1.FlatAppearance.BorderSize = 0;
            this.C1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.C1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C1.Font = new System.Drawing.Font("Ravie", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.C1.Location = new System.Drawing.Point(3, 223);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(106, 101);
            this.C1.TabIndex = 9;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.button_click);
            this.C1.MouseEnter += new System.EventHandler(this.button_enter);
            this.C1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // materialLabel1
            // 
            this.materialLabel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(-1, 103);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(339, 7);
            this.materialLabel1.TabIndex = 4;
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.Chartreuse;
            this.C3.FlatAppearance.BorderSize = 0;
            this.C3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.C3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C3.Font = new System.Drawing.Font("Ravie", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.C3.Location = new System.Drawing.Point(226, 233);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(106, 91);
            this.C3.TabIndex = 8;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.button_click);
            this.C3.MouseEnter += new System.EventHandler(this.button_enter);
            this.C3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.Chartreuse;
            this.C2.FlatAppearance.BorderSize = 0;
            this.C2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.C2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C2.Font = new System.Drawing.Font("Ravie", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.C2.Location = new System.Drawing.Point(115, 233);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(105, 91);
            this.C2.TabIndex = 7;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.button_click);
            this.C2.MouseEnter += new System.EventHandler(this.button_enter);
            this.C2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.Chartreuse;
            this.B1.FlatAppearance.BorderSize = 0;
            this.B1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B1.Font = new System.Drawing.Font("Ravie", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.B1.Location = new System.Drawing.Point(3, 113);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(93, 107);
            this.B1.TabIndex = 6;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.button_click);
            this.B1.MouseEnter += new System.EventHandler(this.button_enter);
            this.B1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.Chartreuse;
            this.B2.FlatAppearance.BorderSize = 0;
            this.B2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2.Font = new System.Drawing.Font("Ravie", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.B2.Location = new System.Drawing.Point(115, 113);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(105, 107);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.button_click);
            this.B2.MouseEnter += new System.EventHandler(this.button_enter);
            this.B2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.Chartreuse;
            this.B3.FlatAppearance.BorderSize = 0;
            this.B3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B3.Font = new System.Drawing.Font("Ravie", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.B3.Location = new System.Drawing.Point(226, 113);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(106, 107);
            this.B3.TabIndex = 4;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.button_click);
            this.B3.MouseEnter += new System.EventHandler(this.button_enter);
            this.B3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.Chartreuse;
            this.A2.FlatAppearance.BorderSize = 0;
            this.A2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.A2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.A2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A2.Font = new System.Drawing.Font("Ravie", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.A2.Location = new System.Drawing.Point(115, 3);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(101, 97);
            this.A2.TabIndex = 3;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.button_click);
            this.A2.MouseEnter += new System.EventHandler(this.button_enter);
            this.A2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.Chartreuse;
            this.A3.FlatAppearance.BorderSize = 0;
            this.A3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.A3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A3.Font = new System.Drawing.Font("Ravie", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.A3.Location = new System.Drawing.Point(235, 3);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(97, 97);
            this.A3.TabIndex = 2;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.button_click);
            this.A3.MouseEnter += new System.EventHandler(this.button_enter);
            this.A3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.Chartreuse;
            this.A1.FlatAppearance.BorderSize = 0;
            this.A1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.A1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.A1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A1.Font = new System.Drawing.Font("Ravie", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.A1.Location = new System.Drawing.Point(3, 3);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(93, 97);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.button_click);
            this.A1.MouseEnter += new System.EventHandler(this.button_enter);
            this.A1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Exit.BackColor = System.Drawing.SystemColors.Control;
            this.Exit.Depth = 0;
            this.Exit.Icon = null;
            this.Exit.Location = new System.Drawing.Point(354, 449);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Exit.MouseState = MaterialSkin.MouseState.HOVER;
            this.Exit.Name = "Exit";
            this.Exit.Primary = false;
            this.Exit.Size = new System.Drawing.Size(58, 36);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "EXIT";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // New
            // 
            this.New.AutoSize = true;
            this.New.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.New.BackColor = System.Drawing.SystemColors.ControlDark;
            this.New.Depth = 0;
            this.New.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.Icon = null;
            this.New.Location = new System.Drawing.Point(354, 401);
            this.New.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.New.MouseState = MaterialSkin.MouseState.HOVER;
            this.New.Name = "New";
            this.New.Primary = false;
            this.New.Size = new System.Drawing.Size(59, 36);
            this.New.TabIndex = 6;
            this.New.Text = "NEW";
            this.New.UseVisualStyleBackColor = false;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // x_win_count
            // 
            this.x_win_count.AutoSize = true;
            this.x_win_count.Depth = 0;
            this.x_win_count.Font = new System.Drawing.Font("Roboto", 11F);
            this.x_win_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.x_win_count.Location = new System.Drawing.Point(412, 94);
            this.x_win_count.MouseState = MaterialSkin.MouseState.HOVER;
            this.x_win_count.Name = "x_win_count";
            this.x_win_count.Size = new System.Drawing.Size(21, 24);
            this.x_win_count.TabIndex = 7;
            this.x_win_count.Text = "0";
            // 
            // draw_count
            // 
            this.draw_count.AutoSize = true;
            this.draw_count.Depth = 0;
            this.draw_count.Font = new System.Drawing.Font("Roboto", 11F);
            this.draw_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.draw_count.Location = new System.Drawing.Point(412, 118);
            this.draw_count.MouseState = MaterialSkin.MouseState.HOVER;
            this.draw_count.Name = "draw_count";
            this.draw_count.Size = new System.Drawing.Size(21, 24);
            this.draw_count.TabIndex = 8;
            this.draw_count.Text = "0";
            // 
            // o_win_count
            // 
            this.o_win_count.AutoSize = true;
            this.o_win_count.Depth = 0;
            this.o_win_count.Font = new System.Drawing.Font("Roboto", 11F);
            this.o_win_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.o_win_count.Location = new System.Drawing.Point(412, 142);
            this.o_win_count.MouseState = MaterialSkin.MouseState.HOVER;
            this.o_win_count.Name = "o_win_count";
            this.o_win_count.Size = new System.Drawing.Size(21, 24);
            this.o_win_count.TabIndex = 9;
            this.o_win_count.Text = "0";
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Depth = 0;
            this.p2.Font = new System.Drawing.Font("Roboto", 11F);
            this.p2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.p2.Location = new System.Drawing.Point(254, 94);
            this.p2.MouseState = MaterialSkin.MouseState.HOVER;
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(78, 24);
            this.p2.TabIndex = 10;
            this.p2.Text = "Player 1";
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Depth = 0;
            this.p1.Font = new System.Drawing.Font("Roboto", 11F);
            this.p1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.p1.Location = new System.Drawing.Point(254, 142);
            this.p1.MouseState = MaterialSkin.MouseState.HOVER;
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(78, 24);
            this.p1.TabIndex = 11;
            this.p1.Text = "Player 2";
            // 
            // Reset
            // 
            this.Reset.AutoSize = true;
            this.Reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Reset.Depth = 0;
            this.Reset.Icon = null;
            this.Reset.Location = new System.Drawing.Point(354, 353);
            this.Reset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Reset.MouseState = MaterialSkin.MouseState.HOVER;
            this.Reset.Name = "Reset";
            this.Reset.Primary = false;
            this.Reset.Size = new System.Drawing.Size(73, 36);
            this.Reset.TabIndex = 12;
            this.Reset.Text = "RESET";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // PvsC
            // 
            this.PvsC.AutoSize = true;
            this.PvsC.Checked = true;
            this.PvsC.Depth = 0;
            this.PvsC.Font = new System.Drawing.Font("Roboto", 10F);
            this.PvsC.Location = new System.Drawing.Point(354, 222);
            this.PvsC.Margin = new System.Windows.Forms.Padding(0);
            this.PvsC.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PvsC.MouseState = MaterialSkin.MouseState.HOVER;
            this.PvsC.Name = "PvsC";
            this.PvsC.Ripple = true;
            this.PvsC.Size = new System.Drawing.Size(79, 30);
            this.PvsC.TabIndex = 13;
            this.PvsC.TabStop = true;
            this.PvsC.Text = "1vsPC";
            this.PvsC.UseVisualStyleBackColor = true;
            this.PvsC.CheckedChanged += new System.EventHandler(this.PvsC_CheckedChanged);
            // 
            // PvsP
            // 
            this.PvsP.AutoSize = true;
            this.PvsP.Depth = 0;
            this.PvsP.Font = new System.Drawing.Font("Roboto", 10F);
            this.PvsP.Location = new System.Drawing.Point(354, 262);
            this.PvsP.Margin = new System.Windows.Forms.Padding(0);
            this.PvsP.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PvsP.MouseState = MaterialSkin.MouseState.HOVER;
            this.PvsP.Name = "PvsP";
            this.PvsP.Ripple = true;
            this.PvsP.Size = new System.Drawing.Size(67, 30);
            this.PvsP.TabIndex = 14;
            this.PvsP.Text = "1vs1";
            this.PvsP.UseVisualStyleBackColor = true;
            this.PvsP.CheckedChanged += new System.EventHandler(this.PvsP_CheckedChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Coral;
            this.label.Location = new System.Drawing.Point(1, 110);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 32);
            this.label.TabIndex = 16;
            // 
            // draw
            // 
            this.draw.AutoSize = true;
            this.draw.Depth = 0;
            this.draw.Font = new System.Drawing.Font("Roboto", 11F);
            this.draw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.draw.Location = new System.Drawing.Point(254, 118);
            this.draw.MouseState = MaterialSkin.MouseState.HOVER;
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(52, 24);
            this.draw.TabIndex = 17;
            this.draw.Text = "Draw";
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Depth = 0;
            this.test.Font = new System.Drawing.Font("Roboto", 11F);
            this.test.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.test.Location = new System.Drawing.Point(33, 118);
            this.test.MouseState = MaterialSkin.MouseState.HOVER;
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(0, 24);
            this.test.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 505);
            this.Controls.Add(this.test);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.label);
            this.Controls.Add(this.PvsP);
            this.Controls.Add(this.PvsC);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.o_win_count);
            this.Controls.Add(this.draw_count);
            this.Controls.Add(this.x_win_count);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(464, 505);
            this.MinimumSize = new System.Drawing.Size(464, 505);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton Exit;
        private MaterialSkin.Controls.MaterialFlatButton New;
        private MaterialSkin.Controls.MaterialLabel x_win_count;
        private MaterialSkin.Controls.MaterialLabel draw_count;
        private MaterialSkin.Controls.MaterialLabel o_win_count;
        private MaterialSkin.Controls.MaterialLabel p2;
        private MaterialSkin.Controls.MaterialLabel p1;
        private MaterialSkin.Controls.MaterialFlatButton Reset;
        private MaterialSkin.Controls.MaterialRadioButton PvsC;
        private MaterialSkin.Controls.MaterialRadioButton PvsP;
        private System.Windows.Forms.Label label;
        private MaterialSkin.Controls.MaterialLabel draw;
        private MaterialSkin.Controls.MaterialLabel test;
    }
}

