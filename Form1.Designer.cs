namespace CardDatabase
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.PokemonButton = new System.Windows.Forms.Button();
            this.YGOButton = new System.Windows.Forms.Button();
            this.MTGButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(118, 267);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(122, 30);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Test Connection";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.connectClick);
            // 
            // PokemonButton
            // 
            this.PokemonButton.Image = global::CardDatabase.Properties.Resources.PokemonButton;
            this.PokemonButton.Location = new System.Drawing.Point(67, 109);
            this.PokemonButton.Margin = new System.Windows.Forms.Padding(1);
            this.PokemonButton.Name = "PokemonButton";
            this.PokemonButton.Size = new System.Drawing.Size(219, 60);
            this.PokemonButton.TabIndex = 12;
            this.PokemonButton.UseVisualStyleBackColor = true;
            this.PokemonButton.Click += new System.EventHandler(this.PokemonButton_Click);
            // 
            // YGOButton
            // 
            this.YGOButton.Image = global::CardDatabase.Properties.Resources.YGOButton;
            this.YGOButton.Location = new System.Drawing.Point(67, 30);
            this.YGOButton.Margin = new System.Windows.Forms.Padding(1);
            this.YGOButton.Name = "YGOButton";
            this.YGOButton.Size = new System.Drawing.Size(219, 60);
            this.YGOButton.TabIndex = 11;
            this.YGOButton.UseVisualStyleBackColor = true;
            this.YGOButton.Click += new System.EventHandler(this.YGOButton_Click);
            // 
            // MTGButton
            // 
            this.MTGButton.Image = global::CardDatabase.Properties.Resources.MTGButton;
            this.MTGButton.Location = new System.Drawing.Point(67, 189);
            this.MTGButton.Margin = new System.Windows.Forms.Padding(1);
            this.MTGButton.Name = "MTGButton";
            this.MTGButton.Size = new System.Drawing.Size(219, 60);
            this.MTGButton.TabIndex = 11;
            this.MTGButton.UseVisualStyleBackColor = true;
            this.MTGButton.Click += new System.EventHandler(this.MTGButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(360, 330);
            this.Controls.Add(this.PokemonButton);
            this.Controls.Add(this.YGOButton);
            this.Controls.Add(this.MTGButton);
            this.Controls.Add(this.btnConnect);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Card Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button MTGButton;
        private System.Windows.Forms.Button YGOButton;
        private System.Windows.Forms.Button PokemonButton;
    }
}

