namespace CardDatabase
{
    partial class pokemonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pokemonForm));
            this.btnInsertCard = new System.Windows.Forms.Button();
            this.btnUpdateSet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExtras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSetCard = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.btnFindSet = new System.Windows.Forms.Button();
            this.txtFindSet = new System.Windows.Forms.TextBox();
            this.txtAddSet = new System.Windows.Forms.TextBox();
            this.btnAddSet = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnLoadSets = new System.Windows.Forms.Button();
            this.cardImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertCard
            // 
            this.btnInsertCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertCard.Location = new System.Drawing.Point(297, 283);
            this.btnInsertCard.Name = "btnInsertCard";
            this.btnInsertCard.Size = new System.Drawing.Size(90, 29);
            this.btnInsertCard.TabIndex = 29;
            this.btnInsertCard.Text = "Insert Card";
            this.btnInsertCard.UseVisualStyleBackColor = true;
            this.btnInsertCard.Click += new System.EventHandler(this.findSetClick);
            // 
            // btnUpdateSet
            // 
            this.btnUpdateSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSet.Location = new System.Drawing.Point(297, 238);
            this.btnUpdateSet.Name = "btnUpdateSet";
            this.btnUpdateSet.Size = new System.Drawing.Size(90, 29);
            this.btnUpdateSet.TabIndex = 28;
            this.btnUpdateSet.Text = "Update Set";
            this.btnUpdateSet.UseVisualStyleBackColor = true;
            this.btnUpdateSet.Click += new System.EventHandler(this.updateClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Extras:";
            // 
            // txtExtras
            // 
            this.txtExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtras.Location = new System.Drawing.Point(331, 169);
            this.txtExtras.Name = "txtExtras";
            this.txtExtras.Size = new System.Drawing.Size(100, 23);
            this.txtExtras.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Set Card:";
            // 
            // txtSetCard
            // 
            this.txtSetCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetCard.Location = new System.Drawing.Point(331, 124);
            this.txtSetCard.Name = "txtSetCard";
            this.txtSetCard.Size = new System.Drawing.Size(100, 23);
            this.txtSetCard.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name:";
            // 
            // txtCardName
            // 
            this.txtCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardName.Location = new System.Drawing.Point(331, 78);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(100, 23);
            this.txtCardName.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Number:";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.Location = new System.Drawing.Point(331, 33);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(100, 23);
            this.txtCardNumber.TabIndex = 20;
            // 
            // btnFindSet
            // 
            this.btnFindSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindSet.Location = new System.Drawing.Point(142, 384);
            this.btnFindSet.Name = "btnFindSet";
            this.btnFindSet.Size = new System.Drawing.Size(75, 23);
            this.btnFindSet.TabIndex = 19;
            this.btnFindSet.Text = "Find Set";
            this.btnFindSet.UseVisualStyleBackColor = true;
            this.btnFindSet.Click += new System.EventHandler(this.findSetClick);
            // 
            // txtFindSet
            // 
            this.txtFindSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindSet.Location = new System.Drawing.Point(129, 355);
            this.txtFindSet.Name = "txtFindSet";
            this.txtFindSet.Size = new System.Drawing.Size(100, 23);
            this.txtFindSet.TabIndex = 18;
            // 
            // txtAddSet
            // 
            this.txtAddSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddSet.Location = new System.Drawing.Point(17, 355);
            this.txtAddSet.Name = "txtAddSet";
            this.txtAddSet.Size = new System.Drawing.Size(100, 23);
            this.txtAddSet.TabIndex = 17;
            // 
            // btnAddSet
            // 
            this.btnAddSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSet.Location = new System.Drawing.Point(29, 384);
            this.btnAddSet.Name = "btnAddSet";
            this.btnAddSet.Size = new System.Drawing.Size(75, 23);
            this.btnAddSet.TabIndex = 16;
            this.btnAddSet.Text = "Add Set";
            this.btnAddSet.UseVisualStyleBackColor = true;
            this.btnAddSet.Click += new System.EventHandler(this.loadSetsClick);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(17, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 308);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnLoadSets
            // 
            this.btnLoadSets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSets.Location = new System.Drawing.Point(81, 326);
            this.btnLoadSets.Name = "btnLoadSets";
            this.btnLoadSets.Size = new System.Drawing.Size(84, 23);
            this.btnLoadSets.TabIndex = 46;
            this.btnLoadSets.Text = "Load Sets";
            this.btnLoadSets.UseVisualStyleBackColor = true;
            this.btnLoadSets.Click += new System.EventHandler(this.loadSetsClick);
            // 
            // cardImg
            // 
            this.cardImg.Image = ((System.Drawing.Image)(resources.GetObject("cardImg.Image")));
            this.cardImg.InitialImage = null;
            this.cardImg.Location = new System.Drawing.Point(447, 12);
            this.cardImg.Name = "cardImg";
            this.cardImg.Size = new System.Drawing.Size(250, 350);
            this.cardImg.TabIndex = 47;
            this.cardImg.TabStop = false;
            // 
            // pokemonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 417);
            this.Controls.Add(this.cardImg);
            this.Controls.Add(this.btnLoadSets);
            this.Controls.Add(this.btnInsertCard);
            this.Controls.Add(this.btnUpdateSet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExtras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSetCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCardName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.btnFindSet);
            this.Controls.Add(this.txtFindSet);
            this.Controls.Add(this.txtAddSet);
            this.Controls.Add(this.btnAddSet);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pokemonForm";
            this.Text = "Pokemon";
            this.Load += new System.EventHandler(this.pokemonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertCard;
        private System.Windows.Forms.Button btnUpdateSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExtras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSetCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Button btnFindSet;
        private System.Windows.Forms.TextBox txtFindSet;
        private System.Windows.Forms.TextBox txtAddSet;
        private System.Windows.Forms.Button btnAddSet;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnLoadSets;
        private System.Windows.Forms.PictureBox cardImg;
    }
}