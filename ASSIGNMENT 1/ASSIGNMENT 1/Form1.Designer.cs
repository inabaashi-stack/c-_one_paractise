namespace ASSIGNMENT_1
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
            this.dayofweekpromt = new System.Windows.Forms.Label();
            this.dayofweek = new System.Windows.Forms.TextBox();
            this.monthpromt = new System.Windows.Forms.Label();
            this.dayofmonthpromt = new System.Windows.Forms.Label();
            this.yearpromt = new System.Windows.Forms.Label();
            this.showdateboton = new System.Windows.Forms.Button();
            this.clearbotton = new System.Windows.Forms.Button();
            this.exitbuton = new System.Windows.Forms.Button();
            this.monthtextbox = new System.Windows.Forms.TextBox();
            this.dayofmonthtextbox = new System.Windows.Forms.TextBox();
            this.yeartextbox = new System.Windows.Forms.TextBox();
            this.dateoutput = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dayofweekpromt
            // 
            this.dayofweekpromt.AutoSize = true;
            this.dayofweekpromt.Location = new System.Drawing.Point(132, 57);
            this.dayofweekpromt.Name = "dayofweekpromt";
            this.dayofweekpromt.Size = new System.Drawing.Size(163, 20);
            this.dayofweekpromt.TabIndex = 0;
            this.dayofweekpromt.Text = "Enter day of the week";
            // 
            // dayofweek
            // 
            this.dayofweek.Location = new System.Drawing.Point(369, 51);
            this.dayofweek.Name = "dayofweek";
            this.dayofweek.Size = new System.Drawing.Size(188, 26);
            this.dayofweek.TabIndex = 1;
            // 
            // monthpromt
            // 
            this.monthpromt.AutoSize = true;
            this.monthpromt.Location = new System.Drawing.Point(82, 97);
            this.monthpromt.Name = "monthpromt";
            this.monthpromt.Size = new System.Drawing.Size(213, 20);
            this.monthpromt.TabIndex = 6;
            this.monthpromt.Text = "Enter the name of the month";
            // 
            // dayofmonthpromt
            // 
            this.dayofmonthpromt.AutoSize = true;
            this.dayofmonthpromt.Location = new System.Drawing.Point(66, 148);
            this.dayofmonthpromt.Name = "dayofmonthpromt";
            this.dayofmonthpromt.Size = new System.Drawing.Size(229, 20);
            this.dayofmonthpromt.TabIndex = 7;
            this.dayofmonthpromt.Text = "Enter the numeric of the month";
            // 
            // yearpromt
            // 
            this.yearpromt.AutoSize = true;
            this.yearpromt.Location = new System.Drawing.Point(186, 204);
            this.yearpromt.Name = "yearpromt";
            this.yearpromt.Size = new System.Drawing.Size(109, 20);
            this.yearpromt.TabIndex = 8;
            this.yearpromt.Text = "Enter the year";
            // 
            // showdateboton
            // 
            this.showdateboton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.showdateboton.Location = new System.Drawing.Point(414, 444);
            this.showdateboton.Name = "showdateboton";
            this.showdateboton.Size = new System.Drawing.Size(106, 52);
            this.showdateboton.TabIndex = 9;
            this.showdateboton.Text = " show date";
            this.showdateboton.UseVisualStyleBackColor = false;
            this.showdateboton.Click += new System.EventHandler(this.shiwdateboton_Click);
            // 
            // clearbotton
            // 
            this.clearbotton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clearbotton.Location = new System.Drawing.Point(540, 444);
            this.clearbotton.Name = "clearbotton";
            this.clearbotton.Size = new System.Drawing.Size(96, 52);
            this.clearbotton.TabIndex = 10;
            this.clearbotton.Text = "Clear";
            this.clearbotton.UseVisualStyleBackColor = false;
            this.clearbotton.Click += new System.EventHandler(this.clearbotton_Click);
            // 
            // exitbuton
            // 
            this.exitbuton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.exitbuton.Location = new System.Drawing.Point(659, 444);
            this.exitbuton.Name = "exitbuton";
            this.exitbuton.Size = new System.Drawing.Size(93, 52);
            this.exitbuton.TabIndex = 11;
            this.exitbuton.Text = "Exit";
            this.exitbuton.UseVisualStyleBackColor = false;
            this.exitbuton.Click += new System.EventHandler(this.exitbuton_Click);
            // 
            // monthtextbox
            // 
            this.monthtextbox.Location = new System.Drawing.Point(369, 94);
            this.monthtextbox.Name = "monthtextbox";
            this.monthtextbox.Size = new System.Drawing.Size(188, 26);
            this.monthtextbox.TabIndex = 12;
            this.monthtextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // dayofmonthtextbox
            // 
            this.dayofmonthtextbox.Location = new System.Drawing.Point(369, 148);
            this.dayofmonthtextbox.Name = "dayofmonthtextbox";
            this.dayofmonthtextbox.Size = new System.Drawing.Size(188, 26);
            this.dayofmonthtextbox.TabIndex = 13;
            // 
            // yeartextbox
            // 
            this.yeartextbox.Location = new System.Drawing.Point(369, 204);
            this.yeartextbox.Name = "yeartextbox";
            this.yeartextbox.Size = new System.Drawing.Size(188, 26);
            this.yeartextbox.TabIndex = 14;
            this.yeartextbox.TextChanged += new System.EventHandler(this.yeartextbox_TextChanged);
            // 
            // dateoutput
            // 
            this.dateoutput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dateoutput.Location = new System.Drawing.Point(410, 341);
            this.dateoutput.Name = "dateoutput";
            this.dateoutput.Size = new System.Drawing.Size(416, 50);
            this.dateoutput.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.monthpromt);
            this.groupBox1.Controls.Add(this.dayofweekpromt);
            this.groupBox1.Controls.Add(this.yeartextbox);
            this.groupBox1.Controls.Add(this.dayofweek);
            this.groupBox1.Controls.Add(this.dayofmonthtextbox);
            this.groupBox1.Controls.Add(this.dayofmonthpromt);
            this.groupBox1.Controls.Add(this.monthtextbox);
            this.groupBox1.Controls.Add(this.yearpromt);
            this.groupBox1.Location = new System.Drawing.Point(148, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 317);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1237, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateoutput);
            this.Controls.Add(this.exitbuton);
            this.Controls.Add(this.clearbotton);
            this.Controls.Add(this.showdateboton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dayofweekpromt;
        private System.Windows.Forms.TextBox dayofweek;
        private System.Windows.Forms.Label monthpromt;
        private System.Windows.Forms.Label dayofmonthpromt;
        private System.Windows.Forms.Label yearpromt;
        private System.Windows.Forms.Button showdateboton;
        private System.Windows.Forms.Button clearbotton;
        private System.Windows.Forms.Button exitbuton;
        private System.Windows.Forms.TextBox monthtextbox;
        private System.Windows.Forms.TextBox dayofmonthtextbox;
        private System.Windows.Forms.TextBox yeartextbox;
        private System.Windows.Forms.Label dateoutput;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

