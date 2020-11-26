namespace burger_emperor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.burgerLabel = new System.Windows.Forms.Label();
            this.fryLabel = new System.Windows.Forms.Label();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.burgerBox = new System.Windows.Forms.TextBox();
            this.fryBox = new System.Windows.Forms.TextBox();
            this.drinkBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.fulltotalLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changenumber = new System.Windows.Forms.Label();
            this.RecieptButton = new System.Windows.Forms.Button();
            this.RecieptLabel = new System.Windows.Forms.Label();
            this.neworderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // burgerLabel
            // 
            this.burgerLabel.AutoSize = true;
            this.burgerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerLabel.Location = new System.Drawing.Point(27, 27);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(65, 20);
            this.burgerLabel.TabIndex = 0;
            this.burgerLabel.Text = "Burgers";
            // 
            // fryLabel
            // 
            this.fryLabel.AutoSize = true;
            this.fryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fryLabel.Location = new System.Drawing.Point(27, 68);
            this.fryLabel.Name = "fryLabel";
            this.fryLabel.Size = new System.Drawing.Size(44, 20);
            this.fryLabel.TabIndex = 1;
            this.fryLabel.Text = "Fries";
            // 
            // drinkLabel
            // 
            this.drinkLabel.AutoSize = true;
            this.drinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkLabel.Location = new System.Drawing.Point(27, 109);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(54, 20);
            this.drinkLabel.TabIndex = 2;
            this.drinkLabel.Text = "Drinks";
            // 
            // burgerBox
            // 
            this.burgerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerBox.Location = new System.Drawing.Point(116, 29);
            this.burgerBox.Name = "burgerBox";
            this.burgerBox.Size = new System.Drawing.Size(90, 23);
            this.burgerBox.TabIndex = 3;
            // 
            // fryBox
            // 
            this.fryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fryBox.Location = new System.Drawing.Point(116, 68);
            this.fryBox.Name = "fryBox";
            this.fryBox.Size = new System.Drawing.Size(90, 23);
            this.fryBox.TabIndex = 4;
            // 
            // drinkBox
            // 
            this.drinkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkBox.Location = new System.Drawing.Point(116, 111);
            this.drinkBox.Name = "drinkBox";
            this.drinkBox.Size = new System.Drawing.Size(90, 23);
            this.drinkBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate Totals";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(31, 206);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(71, 18);
            this.subtotalLabel.TabIndex = 7;
            this.subtotalLabel.Text = "Sub Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(31, 271);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(40, 17);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total";
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLabel.Location = new System.Drawing.Point(123, 208);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(0, 16);
            this.subLabel.TabIndex = 10;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(123, 238);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(0, 16);
            this.taxLabel.TabIndex = 11;
            // 
            // fulltotalLabel
            // 
            this.fulltotalLabel.AutoSize = true;
            this.fulltotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fulltotalLabel.Location = new System.Drawing.Point(123, 271);
            this.fulltotalLabel.Name = "fulltotalLabel";
            this.fulltotalLabel.Size = new System.Drawing.Size(0, 16);
            this.fulltotalLabel.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(19, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ggjhhgshgsjghkjshgjksjghjshgjhghsjhgj";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(22, 327);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(77, 20);
            this.tenderedLabel.TabIndex = 14;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedBox
            // 
            this.tenderedBox.Location = new System.Drawing.Point(116, 327);
            this.tenderedBox.Name = "tenderedBox";
            this.tenderedBox.Size = new System.Drawing.Size(90, 20);
            this.tenderedBox.TabIndex = 15;
            // 
            // changeButton
            // 
            this.changeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(26, 360);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(180, 27);
            this.changeButton.TabIndex = 16;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(23, 403);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(59, 18);
            this.changeLabel.TabIndex = 17;
            this.changeLabel.Text = "Change";
            // 
            // changenumber
            // 
            this.changenumber.AutoSize = true;
            this.changenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changenumber.Location = new System.Drawing.Point(138, 408);
            this.changenumber.Name = "changenumber";
            this.changenumber.Size = new System.Drawing.Size(0, 16);
            this.changenumber.TabIndex = 18;
            // 
            // RecieptButton
            // 
            this.RecieptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RecieptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecieptButton.Location = new System.Drawing.Point(26, 438);
            this.RecieptButton.Name = "RecieptButton";
            this.RecieptButton.Size = new System.Drawing.Size(180, 35);
            this.RecieptButton.TabIndex = 19;
            this.RecieptButton.Text = "Print Reciept";
            this.RecieptButton.UseVisualStyleBackColor = true;
            this.RecieptButton.Click += new System.EventHandler(this.RecieptButton_Click);
            // 
            // RecieptLabel
            // 
            this.RecieptLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RecieptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RecieptLabel.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecieptLabel.Location = new System.Drawing.Point(274, 9);
            this.RecieptLabel.Name = "RecieptLabel";
            this.RecieptLabel.Size = new System.Drawing.Size(329, 415);
            this.RecieptLabel.TabIndex = 20;
            // 
            // neworderButton
            // 
            this.neworderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.neworderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neworderButton.Location = new System.Drawing.Point(274, 438);
            this.neworderButton.Name = "neworderButton";
            this.neworderButton.Size = new System.Drawing.Size(329, 35);
            this.neworderButton.TabIndex = 21;
            this.neworderButton.Text = "New Order";
            this.neworderButton.UseVisualStyleBackColor = true;
            this.neworderButton.Click += new System.EventHandler(this.neworderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(659, 485);
            this.Controls.Add(this.neworderButton);
            this.Controls.Add(this.RecieptLabel);
            this.Controls.Add(this.RecieptButton);
            this.Controls.Add(this.changenumber);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedBox);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fulltotalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.drinkBox);
            this.Controls.Add(this.fryBox);
            this.Controls.Add(this.burgerBox);
            this.Controls.Add(this.drinkLabel);
            this.Controls.Add(this.fryLabel);
            this.Controls.Add(this.burgerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Burger Emperor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.Label fryLabel;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.TextBox burgerBox;
        private System.Windows.Forms.TextBox fryBox;
        private System.Windows.Forms.TextBox drinkBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label fulltotalLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changenumber;
        private System.Windows.Forms.Button RecieptButton;
        private System.Windows.Forms.Label RecieptLabel;
        private System.Windows.Forms.Button neworderButton;
    }
}

