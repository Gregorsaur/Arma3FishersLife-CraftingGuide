namespace Arma3FishersLifeCraftingGuide.UserControls
{
    partial class CraftingVehicleParts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDebug = new System.Windows.Forms.Label();
            this.buttonPartsSteel = new System.Windows.Forms.Button();
            this.buttonPartsOther = new System.Windows.Forms.Button();
            this.buttonPartsAluminum = new System.Windows.Forms.Button();
            this.groupBoxSelectValues = new System.Windows.Forms.GroupBox();
            this.radioButtonOres = new System.Windows.Forms.RadioButton();
            this.radioButtonSheets = new System.Windows.Forms.RadioButton();
            this.radioButtonIngots = new System.Windows.Forms.RadioButton();
            this.radioButtonPallets = new System.Windows.Forms.RadioButton();
            this.groupBoxSelectValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDebug
            // 
            this.labelDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelDebug.ForeColor = System.Drawing.Color.White;
            this.labelDebug.Location = new System.Drawing.Point(168, 171);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(808, 336);
            this.labelDebug.TabIndex = 6;
            this.labelDebug.Text = "Coming in v2.0: Vehicle Parts Recipe";
            // 
            // buttonPartsSteel
            // 
            this.buttonPartsSteel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPartsSteel.FlatAppearance.BorderSize = 0;
            this.buttonPartsSteel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPartsSteel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonPartsSteel.Location = new System.Drawing.Point(8, 8);
            this.buttonPartsSteel.Name = "buttonPartsSteel";
            this.buttonPartsSteel.Size = new System.Drawing.Size(200, 52);
            this.buttonPartsSteel.TabIndex = 7;
            this.buttonPartsSteel.Text = "Steel Parts";
            this.buttonPartsSteel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPartsSteel.UseVisualStyleBackColor = true;
            this.buttonPartsSteel.Visible = false;
            this.buttonPartsSteel.Click += new System.EventHandler(this.ButtonPartsSteel_Click);
            // 
            // buttonPartsOther
            // 
            this.buttonPartsOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPartsOther.FlatAppearance.BorderSize = 0;
            this.buttonPartsOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPartsOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonPartsOther.Location = new System.Drawing.Point(424, 8);
            this.buttonPartsOther.Name = "buttonPartsOther";
            this.buttonPartsOther.Size = new System.Drawing.Size(200, 52);
            this.buttonPartsOther.TabIndex = 8;
            this.buttonPartsOther.Text = "Other Parts";
            this.buttonPartsOther.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPartsOther.UseVisualStyleBackColor = true;
            this.buttonPartsOther.Visible = false;
            this.buttonPartsOther.Click += new System.EventHandler(this.ButtonPartsOther_Click);
            // 
            // buttonPartsAluminum
            // 
            this.buttonPartsAluminum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPartsAluminum.FlatAppearance.BorderSize = 0;
            this.buttonPartsAluminum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPartsAluminum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonPartsAluminum.Location = new System.Drawing.Point(216, 8);
            this.buttonPartsAluminum.Name = "buttonPartsAluminum";
            this.buttonPartsAluminum.Size = new System.Drawing.Size(200, 52);
            this.buttonPartsAluminum.TabIndex = 9;
            this.buttonPartsAluminum.Text = "Aluminum Parts";
            this.buttonPartsAluminum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPartsAluminum.UseVisualStyleBackColor = true;
            this.buttonPartsAluminum.Visible = false;
            this.buttonPartsAluminum.Click += new System.EventHandler(this.ButtonPartsAluminum_Click);
            // 
            // groupBoxSelectValues
            // 
            this.groupBoxSelectValues.Controls.Add(this.radioButtonOres);
            this.groupBoxSelectValues.Controls.Add(this.radioButtonSheets);
            this.groupBoxSelectValues.Controls.Add(this.radioButtonIngots);
            this.groupBoxSelectValues.Controls.Add(this.radioButtonPallets);
            this.groupBoxSelectValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxSelectValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBoxSelectValues.Location = new System.Drawing.Point(632, 8);
            this.groupBoxSelectValues.Name = "groupBoxSelectValues";
            this.groupBoxSelectValues.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxSelectValues.Size = new System.Drawing.Size(376, 112);
            this.groupBoxSelectValues.TabIndex = 10;
            this.groupBoxSelectValues.TabStop = false;
            this.groupBoxSelectValues.Visible = false;
            // 
            // radioButtonOres
            // 
            this.radioButtonOres.AutoSize = true;
            this.radioButtonOres.Location = new System.Drawing.Point(101, 69);
            this.radioButtonOres.Name = "radioButtonOres";
            this.radioButtonOres.Size = new System.Drawing.Size(69, 28);
            this.radioButtonOres.TabIndex = 3;
            this.radioButtonOres.TabStop = true;
            this.radioButtonOres.Text = "Ores";
            this.radioButtonOres.UseVisualStyleBackColor = true;
            // 
            // radioButtonSheets
            // 
            this.radioButtonSheets.AutoSize = true;
            this.radioButtonSheets.Location = new System.Drawing.Point(5, 69);
            this.radioButtonSheets.Name = "radioButtonSheets";
            this.radioButtonSheets.Size = new System.Drawing.Size(86, 28);
            this.radioButtonSheets.TabIndex = 2;
            this.radioButtonSheets.TabStop = true;
            this.radioButtonSheets.Text = "Sheets";
            this.radioButtonSheets.UseVisualStyleBackColor = true;
            // 
            // radioButtonIngots
            // 
            this.radioButtonIngots.AutoSize = true;
            this.radioButtonIngots.Location = new System.Drawing.Point(109, 29);
            this.radioButtonIngots.Name = "radioButtonIngots";
            this.radioButtonIngots.Size = new System.Drawing.Size(78, 28);
            this.radioButtonIngots.TabIndex = 1;
            this.radioButtonIngots.TabStop = true;
            this.radioButtonIngots.Text = "Ingots";
            this.radioButtonIngots.UseVisualStyleBackColor = true;
            // 
            // radioButtonPallets
            // 
            this.radioButtonPallets.AutoSize = true;
            this.radioButtonPallets.Location = new System.Drawing.Point(5, 29);
            this.radioButtonPallets.Name = "radioButtonPallets";
            this.radioButtonPallets.Size = new System.Drawing.Size(82, 28);
            this.radioButtonPallets.TabIndex = 0;
            this.radioButtonPallets.TabStop = true;
            this.radioButtonPallets.Text = "Pallets";
            this.radioButtonPallets.UseVisualStyleBackColor = true;
            // 
            // CraftingVehicleParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.groupBoxSelectValues);
            this.Controls.Add(this.buttonPartsAluminum);
            this.Controls.Add(this.buttonPartsOther);
            this.Controls.Add(this.buttonPartsSteel);
            this.Controls.Add(this.labelDebug);
            this.Name = "CraftingVehicleParts";
            this.Size = new System.Drawing.Size(1020, 520);
            this.groupBoxSelectValues.ResumeLayout(false);
            this.groupBoxSelectValues.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelDebug;
        private System.Windows.Forms.Button buttonPartsSteel;
        private System.Windows.Forms.Button buttonPartsOther;
        private System.Windows.Forms.Button buttonPartsAluminum;
        private System.Windows.Forms.GroupBox groupBoxSelectValues;
        private System.Windows.Forms.RadioButton radioButtonOres;
        private System.Windows.Forms.RadioButton radioButtonSheets;
        private System.Windows.Forms.RadioButton radioButtonIngots;
        private System.Windows.Forms.RadioButton radioButtonPallets;
    }
}
