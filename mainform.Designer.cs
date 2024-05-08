namespace fast_food
{
    partial class mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.labeluser = new System.Windows.Forms.Label();
            this.btnmax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnexit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnmin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.rightPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnhome = new Guna.UI2.WinForms.Guna2Button();
            this.btnorder = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsting = new Guna.UI2.WinForms.Guna2Button();
            this.btnkitchen = new Guna.UI2.WinForms.Guna2Button();
            this.btnpos = new Guna.UI2.WinForms.Guna2Button();
            this.btnstaff = new Guna.UI2.WinForms.Guna2Button();
            this.btncategory = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.topPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.labeluser);
            this.topPanel.Controls.Add(this.btnmax);
            this.topPanel.Controls.Add(this.btnexit);
            this.topPanel.Controls.Add(this.btnmin);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.FillColor = System.Drawing.Color.Gainsboro;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(828, 52);
            this.topPanel.TabIndex = 0;
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.BackColor = System.Drawing.Color.Transparent;
            this.labeluser.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluser.Location = new System.Drawing.Point(12, 12);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(55, 23);
            this.labeluser.TabIndex = 3;
            this.labeluser.Text = "label3";
            // 
            // btnmax
            // 
            this.btnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnmax.CustomClick = true;
            this.btnmax.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnmax.IconColor = System.Drawing.Color.White;
            this.btnmax.Location = new System.Drawing.Point(729, 12);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(45, 29);
            this.btnmax.TabIndex = 2;
            // 
            // btnexit
            // 
            this.btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexit.CustomClick = true;
            this.btnexit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnexit.IconColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(780, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(45, 29);
            this.btnexit.TabIndex = 1;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnmin.CustomClick = true;
            this.btnmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnmin.IconColor = System.Drawing.Color.White;
            this.btnmin.Location = new System.Drawing.Point(678, 12);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(45, 29);
            this.btnmin.TabIndex = 0;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.White;
            this.rightPanel.Controls.Add(this.guna2Button1);
            this.rightPanel.Controls.Add(this.btnhome);
            this.rightPanel.Controls.Add(this.btnorder);
            this.rightPanel.Controls.Add(this.btnsting);
            this.rightPanel.Controls.Add(this.btnkitchen);
            this.rightPanel.Controls.Add(this.btnpos);
            this.rightPanel.Controls.Add(this.btnstaff);
            this.rightPanel.Controls.Add(this.btncategory);
            this.rightPanel.Controls.Add(this.label1);
            this.rightPanel.Controls.Add(this.guna2PictureBox1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.rightPanel.Location = new System.Drawing.Point(638, 52);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(190, 546);
            this.rightPanel.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomizableEdges.BottomRight = false;
            this.guna2Button1.CustomizableEdges.TopRight = false;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2Button1.Font = new System.Drawing.Font("B Jadid", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::fast_food.Properties.Resources.icons8_table_100;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(5, 0);
            this.guna2Button1.Location = new System.Drawing.Point(6, 233);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.Text = "میز ها";
            this.guna2Button1.TextOffset = new System.Drawing.Point(8, 0);
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnhome
            // 
            this.btnhome.Animated = true;
            this.btnhome.AutoRoundedCorners = true;
            this.btnhome.BackColor = System.Drawing.Color.Transparent;
            this.btnhome.BorderRadius = 21;
            this.btnhome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnhome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhome.CustomizableEdges.BottomRight = false;
            this.btnhome.CustomizableEdges.TopRight = false;
            this.btnhome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnhome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnhome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnhome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnhome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnhome.Font = new System.Drawing.Font("B Jadid", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.Image = global::fast_food.Properties.Resources.icons8_home_240;
            this.btnhome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnhome.Location = new System.Drawing.Point(6, 143);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(180, 45);
            this.btnhome.TabIndex = 3;
            this.btnhome.Text = "خانه";
            this.btnhome.TextOffset = new System.Drawing.Point(20, 0);
            this.btnhome.UseTransparentBackground = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnorder
            // 
            this.btnorder.Animated = true;
            this.btnorder.AutoRoundedCorners = true;
            this.btnorder.BackColor = System.Drawing.Color.Transparent;
            this.btnorder.BorderRadius = 21;
            this.btnorder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnorder.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnorder.CustomizableEdges.BottomRight = false;
            this.btnorder.CustomizableEdges.TopRight = false;
            this.btnorder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnorder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnorder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnorder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnorder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnorder.Font = new System.Drawing.Font("B Jadid", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnorder.ForeColor = System.Drawing.Color.White;
            this.btnorder.Image = global::fast_food.Properties.Resources.icons8_order_96;
            this.btnorder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnorder.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnorder.Location = new System.Drawing.Point(6, 323);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(180, 45);
            this.btnorder.TabIndex = 5;
            this.btnorder.Text = "محصولات";
            this.btnorder.TextOffset = new System.Drawing.Point(8, 0);
            this.btnorder.UseTransparentBackground = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Jadid", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "فست فود چهل سی";
            // 
            // btnsting
            // 
            this.btnsting.Animated = true;
            this.btnsting.AutoRoundedCorners = true;
            this.btnsting.BackColor = System.Drawing.Color.Transparent;
            this.btnsting.BorderRadius = 21;
            this.btnsting.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnsting.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnsting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsting.CustomizableEdges.BottomRight = false;
            this.btnsting.CustomizableEdges.TopRight = false;
            this.btnsting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnsting.Font = new System.Drawing.Font("B Jadid", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnsting.ForeColor = System.Drawing.Color.White;
            this.btnsting.Image = global::fast_food.Properties.Resources.icons8_setting_96;
            this.btnsting.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnsting.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnsting.Location = new System.Drawing.Point(6, 458);
            this.btnsting.Name = "btnsting";
            this.btnsting.Size = new System.Drawing.Size(180, 45);
            this.btnsting.TabIndex = 9;
            this.btnsting.Text = "تنظیمات";
            this.btnsting.TextOffset = new System.Drawing.Point(8, 0);
            this.btnsting.UseTransparentBackground = true;
            // 
            // btnkitchen
            // 
            this.btnkitchen.Animated = true;
            this.btnkitchen.AutoRoundedCorners = true;
            this.btnkitchen.BackColor = System.Drawing.Color.Transparent;
            this.btnkitchen.BorderRadius = 21;
            this.btnkitchen.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnkitchen.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnkitchen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkitchen.CustomizableEdges.BottomRight = false;
            this.btnkitchen.CustomizableEdges.TopRight = false;
            this.btnkitchen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnkitchen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnkitchen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnkitchen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnkitchen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnkitchen.Font = new System.Drawing.Font("B Jadid", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnkitchen.ForeColor = System.Drawing.Color.White;
            this.btnkitchen.Image = global::fast_food.Properties.Resources.icons8_kitchen_60;
            this.btnkitchen.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnkitchen.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnkitchen.Location = new System.Drawing.Point(6, 413);
            this.btnkitchen.Name = "btnkitchen";
            this.btnkitchen.Size = new System.Drawing.Size(180, 45);
            this.btnkitchen.TabIndex = 8;
            this.btnkitchen.Text = "آشپز خانه";
            this.btnkitchen.TextOffset = new System.Drawing.Point(8, 0);
            this.btnkitchen.UseTransparentBackground = true;
            this.btnkitchen.Click += new System.EventHandler(this.btnkitchen_Click);
            // 
            // btnpos
            // 
            this.btnpos.Animated = true;
            this.btnpos.AutoRoundedCorners = true;
            this.btnpos.BackColor = System.Drawing.Color.Transparent;
            this.btnpos.BorderRadius = 21;
            this.btnpos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnpos.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnpos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpos.CustomizableEdges.BottomRight = false;
            this.btnpos.CustomizableEdges.TopRight = false;
            this.btnpos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnpos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnpos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnpos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnpos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnpos.Font = new System.Drawing.Font("B Jadid", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnpos.ForeColor = System.Drawing.Color.White;
            this.btnpos.Image = global::fast_food.Properties.Resources.icons8_pos_96;
            this.btnpos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnpos.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnpos.Location = new System.Drawing.Point(6, 368);
            this.btnpos.Name = "btnpos";
            this.btnpos.Size = new System.Drawing.Size(180, 45);
            this.btnpos.TabIndex = 7;
            this.btnpos.Text = "کارت خوان";
            this.btnpos.TextOffset = new System.Drawing.Point(8, 0);
            this.btnpos.UseTransparentBackground = true;
            this.btnpos.Click += new System.EventHandler(this.btnpos_Click);
            // 
            // btnstaff
            // 
            this.btnstaff.Animated = true;
            this.btnstaff.AutoRoundedCorners = true;
            this.btnstaff.BackColor = System.Drawing.Color.Transparent;
            this.btnstaff.BorderRadius = 21;
            this.btnstaff.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnstaff.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnstaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstaff.CustomizableEdges.BottomRight = false;
            this.btnstaff.CustomizableEdges.TopRight = false;
            this.btnstaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnstaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnstaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnstaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnstaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnstaff.Font = new System.Drawing.Font("B Jadid", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnstaff.ForeColor = System.Drawing.Color.White;
            this.btnstaff.Image = global::fast_food.Properties.Resources.icons8_staff_100;
            this.btnstaff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnstaff.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnstaff.Location = new System.Drawing.Point(6, 278);
            this.btnstaff.Name = "btnstaff";
            this.btnstaff.Size = new System.Drawing.Size(180, 45);
            this.btnstaff.TabIndex = 6;
            this.btnstaff.Text = "کارکنان";
            this.btnstaff.TextOffset = new System.Drawing.Point(8, 0);
            this.btnstaff.UseTransparentBackground = true;
            this.btnstaff.Click += new System.EventHandler(this.btnstaff_Click);
            // 
            // btncategory
            // 
            this.btncategory.Animated = true;
            this.btncategory.AutoRoundedCorners = true;
            this.btncategory.BackColor = System.Drawing.Color.Transparent;
            this.btncategory.BorderRadius = 21;
            this.btncategory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btncategory.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btncategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncategory.CustomizableEdges.BottomRight = false;
            this.btncategory.CustomizableEdges.TopRight = false;
            this.btncategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btncategory.Font = new System.Drawing.Font("B Jadid", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btncategory.ForeColor = System.Drawing.Color.White;
            this.btncategory.Image = global::fast_food.Properties.Resources.icons8_category_64;
            this.btncategory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncategory.ImageOffset = new System.Drawing.Point(5, 0);
            this.btncategory.Location = new System.Drawing.Point(6, 188);
            this.btncategory.Name = "btncategory";
            this.btncategory.Size = new System.Drawing.Size(180, 45);
            this.btncategory.TabIndex = 4;
            this.btncategory.Text = "دسته بندی";
            this.btncategory.TextOffset = new System.Drawing.Point(8, 0);
            this.btncategory.UseTransparentBackground = true;
            this.btncategory.Click += new System.EventHandler(this.btncategory_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::fast_food.Properties.Resources._4030;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(47, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(102, 90);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.ForeColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 52);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(638, 546);
            this.guna2Panel1.TabIndex = 2;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 598);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("B Kamran", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainform";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "mainform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainform_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private Guna.UI2.WinForms.Guna2Panel rightPanel;
        private Guna.UI2.WinForms.Guna2ControlBox btnmax;
        private Guna.UI2.WinForms.Guna2ControlBox btnexit;
        private Guna.UI2.WinForms.Guna2ControlBox btnmin;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnhome;
        private Guna.UI2.WinForms.Guna2Button btnstaff;
        private Guna.UI2.WinForms.Guna2Button btnorder;
        private Guna.UI2.WinForms.Guna2Button btncategory;
        private Guna.UI2.WinForms.Guna2Button btnkitchen;
        private Guna.UI2.WinForms.Guna2Button btnpos;
        private System.Windows.Forms.Label labeluser;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnsting;
    }
}