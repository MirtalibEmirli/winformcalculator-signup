namespace Lesson3Forms
{
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            load = new Button();
            save = new Button();
            name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            fname = new TextBox();
            country = new TextBox();
            sname = new TextBox();
            city = new TextBox();
            number = new TextBox();
            label7 = new Label();
            dt = new DateTimePicker();
            female = new RadioButton();
            male = new RadioButton();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // load
            // 
            load.FlatStyle = FlatStyle.Popup;
            load.Location = new Point(390, 26);
            load.Name = "load";
            load.Size = new Size(94, 29);
            load.TabIndex = 0;
            load.Text = "Load";
            load.UseVisualStyleBackColor = true;
            load.Click += load_Click;
            // 
            // save
            // 
            save.Cursor = Cursors.Hand;
            save.FlatStyle = FlatStyle.Popup;
            save.Location = new Point(31, 512);
            save.Name = "save";
            save.Size = new Size(413, 29);
            save.TabIndex = 1;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // name
            // 
            name.Location = new Point(176, 28);
            name.Name = "name";
            name.PlaceholderText = "Name";
            name.Size = new Size(158, 27);
            name.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 58);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 3;
            label1.Text = "RegistrationForm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 159);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 115);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 5;
            label3.Text = "Fathername";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 199);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 6;
            label4.Text = "Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 243);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 7;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 280);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 8;
            label6.Text = "Number";
            // 
            // fname
            // 
            fname.Location = new Point(176, 108);
            fname.Name = "fname";
            fname.Size = new Size(125, 27);
            fname.TabIndex = 9;
            // 
            // country
            // 
            country.Location = new Point(176, 192);
            country.Name = "country";
            country.Size = new Size(125, 27);
            country.TabIndex = 10;
            // 
            // sname
            // 
            sname.Location = new Point(176, 152);
            sname.Name = "sname";
            sname.Size = new Size(125, 27);
            sname.TabIndex = 11;
            // 
            // city
            // 
            city.Location = new Point(176, 236);
            city.Name = "city";
            city.Size = new Size(125, 27);
            city.TabIndex = 12;
            // 
            // number
            // 
            number.Location = new Point(176, 273);
            number.Name = "number";
            number.Size = new Size(125, 27);
            number.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 332);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 14;
            label7.Text = "Birthdate";
            // 
            // dt
            // 
            dt.Format = DateTimePickerFormat.Short;
            dt.Location = new Point(176, 327);
            dt.Name = "dt";
            dt.Size = new Size(250, 27);
            dt.TabIndex = 15;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(319, 401);
            female.Name = "female";
            female.Size = new Size(78, 24);
            female.TabIndex = 1;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(191, 401);
            male.Name = "male";
            male.Size = new Size(63, 24);
            male.TabIndex = 0;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 401);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 17;
            label8.Text = "Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(133, 461);
            label9.Name = "label9";
            label9.Size = new Size(13, 20);
            label9.TabIndex = 18;
            label9.Text = " ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 562);
            Controls.Add(label9);
            Controls.Add(female);
            Controls.Add(label8);
            Controls.Add(male);
            Controls.Add(dt);
            Controls.Add(label7);
            Controls.Add(number);
            Controls.Add(city);
            Controls.Add(sname);
            Controls.Add(country);
            Controls.Add(fname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(name);
            Controls.Add(save);
            Controls.Add(load);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button load;
        private Button save;
        private TextBox name;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox fname;
        private TextBox country;
        private TextBox sname;
        private TextBox city;
        private TextBox number;
        private Label label7;
        private DateTimePicker dt;
        private RadioButton female;
        private RadioButton male;
        private Label label8;
        private Label label9;
    }
}
