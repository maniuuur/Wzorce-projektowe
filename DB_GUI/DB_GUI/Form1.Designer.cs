namespace DB_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv = new System.Windows.Forms.ListView();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.delButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.ipTB = new System.Windows.Forms.TextBox();
            this.portTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.pwTB = new System.Windows.Forms.TextBox();
            this.dbTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lv.Location = new System.Drawing.Point(106, 124);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(347, 227);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged);
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(459, 35);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 1;
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(459, 163);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(121, 33);
            this.delButton.TabIndex = 3;
            this.delButton.Text = "Del";
            this.delButton.UseVisualStyleBackColor = true;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(459, 241);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(121, 33);
            this.sortButton.TabIndex = 5;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(459, 124);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(121, 33);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.connectButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.connectButton.Location = new System.Drawing.Point(321, 62);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(100, 20);
            this.connectButton.TabIndex = 7;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(459, 202);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(121, 33);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // ipTB
            // 
            this.ipTB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ipTB.Location = new System.Drawing.Point(109, 36);
            this.ipTB.Name = "ipTB";
            this.ipTB.Size = new System.Drawing.Size(100, 20);
            this.ipTB.TabIndex = 9;
            this.ipTB.Enter += new System.EventHandler(this.ipTB_Enter);
            this.ipTB.Leave += new System.EventHandler(this.ipTB_Leave);
            // 
            // portTB
            // 
            this.portTB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.portTB.Location = new System.Drawing.Point(109, 62);
            this.portTB.Name = "portTB";
            this.portTB.Size = new System.Drawing.Size(100, 20);
            this.portTB.TabIndex = 10;
            this.portTB.Enter += new System.EventHandler(this.portTB_Enter);
            this.portTB.Leave += new System.EventHandler(this.portTB_Leave);
            // 
            // usernameTB
            // 
            this.usernameTB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.usernameTB.Location = new System.Drawing.Point(215, 36);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(100, 20);
            this.usernameTB.TabIndex = 11;
            this.usernameTB.Enter += new System.EventHandler(this.usernameTB_Enter);
            this.usernameTB.Leave += new System.EventHandler(this.usernameTB_Leave);
            // 
            // pwTB
            // 
            this.pwTB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pwTB.Location = new System.Drawing.Point(215, 62);
            this.pwTB.Name = "pwTB";
            this.pwTB.Size = new System.Drawing.Size(100, 20);
            this.pwTB.TabIndex = 12;
            this.pwTB.Enter += new System.EventHandler(this.pwTB_Enter);
            this.pwTB.Leave += new System.EventHandler(this.pwTB_Leave);
            // 
            // dbTB
            // 
            this.dbTB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dbTB.Location = new System.Drawing.Point(321, 36);
            this.dbTB.Name = "dbTB";
            this.dbTB.Size = new System.Drawing.Size(100, 20);
            this.dbTB.TabIndex = 14;
            this.dbTB.Enter += new System.EventHandler(this.dbTB_Enter);
            this.dbTB.Leave += new System.EventHandler(this.dbTB_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enter data here:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbTB);
            this.Controls.Add(this.pwTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.portTB);
            this.Controls.Add(this.ipTB);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.lv);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox ipTB;
        private System.Windows.Forms.TextBox portTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox pwTB;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox dbTB;
        private System.Windows.Forms.Label label1;
    }
}

