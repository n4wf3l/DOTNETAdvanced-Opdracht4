namespace DOTNETAdvanced_Opdracht4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titel = new System.Windows.Forms.TextBox();
            this.toevoegen = new System.Windows.Forms.Button();
            this.volgende = new System.Windows.Forms.Button();
            this.achteraan = new System.Windows.Forms.Button();
            this.verwijder = new System.Windows.Forms.Button();
            this.toonmbox = new System.Windows.Forms.Button();
            this.toonform = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.info = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titel
            // 
            this.titel.Location = new System.Drawing.Point(129, 27);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(329, 23);
            this.titel.TabIndex = 0;
            this.titel.TextChanged += new System.EventHandler(this.titel_TextChanged);
            // 
            // toevoegen
            // 
            this.toevoegen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toevoegen.Location = new System.Drawing.Point(504, 15);
            this.toevoegen.Name = "toevoegen";
            this.toevoegen.Size = new System.Drawing.Size(102, 44);
            this.toevoegen.TabIndex = 2;
            this.toevoegen.Text = "Toevoegen";
            this.toevoegen.UseVisualStyleBackColor = false;
            this.toevoegen.Click += new System.EventHandler(this.toevoegen_Click);
            // 
            // volgende
            // 
            this.volgende.BackColor = System.Drawing.Color.White;
            this.volgende.Location = new System.Drawing.Point(528, 65);
            this.volgende.Name = "volgende";
            this.volgende.Size = new System.Drawing.Size(78, 32);
            this.volgende.TabIndex = 3;
            this.volgende.Text = "Volgende";
            this.volgende.UseVisualStyleBackColor = false;
            this.volgende.Click += new System.EventHandler(this.volgende_Click_1);
            // 
            // achteraan
            // 
            this.achteraan.Location = new System.Drawing.Point(516, 103);
            this.achteraan.Name = "achteraan";
            this.achteraan.Size = new System.Drawing.Size(90, 32);
            this.achteraan.TabIndex = 4;
            this.achteraan.Text = "Zet Achteraan";
            this.achteraan.UseVisualStyleBackColor = true;
            this.achteraan.Click += new System.EventHandler(this.achteraan_Click_1);
            // 
            // verwijder
            // 
            this.verwijder.Location = new System.Drawing.Point(504, 141);
            this.verwijder.Name = "verwijder";
            this.verwijder.Size = new System.Drawing.Size(102, 32);
            this.verwijder.TabIndex = 5;
            this.verwijder.Text = "Taak Verwijderen";
            this.verwijder.UseVisualStyleBackColor = true;
            this.verwijder.Click += new System.EventHandler(this.verwijder_Click_1);
            // 
            // toonmbox
            // 
            this.toonmbox.BackColor = System.Drawing.Color.Red;
            this.toonmbox.Location = new System.Drawing.Point(523, 196);
            this.toonmbox.Name = "toonmbox";
            this.toonmbox.Size = new System.Drawing.Size(83, 42);
            this.toonmbox.TabIndex = 6;
            this.toonmbox.Text = "Toon in messageBox";
            this.toonmbox.UseVisualStyleBackColor = false;
            this.toonmbox.Click += new System.EventHandler(this.toonmbox_Click_1);
            // 
            // toonform
            // 
            this.toonform.BackColor = System.Drawing.Color.Red;
            this.toonform.Location = new System.Drawing.Point(523, 244);
            this.toonform.Name = "toonform";
            this.toonform.Size = new System.Drawing.Size(83, 42);
            this.toonform.TabIndex = 7;
            this.toonform.Text = "Toon in form";
            this.toonform.UseVisualStyleBackColor = false;
            this.toonform.Click += new System.EventHandler(this.toonform_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(71, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Taak";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.Color.MintCream;
            this.checkBox.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox.Location = new System.Drawing.Point(40, 61);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(65, 21);
            this.checkBox.TabIndex = 10;
            this.checkBox.Text = "Datum";
            this.checkBox.UseVisualStyleBackColor = false;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(129, 89);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(329, 149);
            this.info.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Beschrijving";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(617, 303);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.info);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toonform);
            this.Controls.Add(this.toonmbox);
            this.Controls.Add(this.verwijder);
            this.Controls.Add(this.achteraan);
            this.Controls.Add(this.volgende);
            this.Controls.Add(this.toevoegen);
            this.Controls.Add(this.titel);
            this.Name = "Form1";
            this.Text = "TeDoen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox titel;
        private Button toevoegen;
        private Button volgende;
        private Button achteraan;
        private Button verwijder;
        private Button toonmbox;
        private Button toonform;
        private Label label1;
        private CheckBox checkBox;
        private DateTimePicker dateTimePicker1;
        private TextBox info;
        private Label label2;
    }
}