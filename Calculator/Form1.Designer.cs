namespace Calculator
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
            sifir = new Button();
            label1 = new Label();
            dord = new Button();
            yeddi = new Button();
            iki = new Button();
            bes = new Button();
            bir = new Button();
            sekkiz = new Button();
            uc = new Button();
            alti = new Button();
            doqquz = new Button();
            beraber = new Button();
            bol = new Button();
            plus = new Button();
            cx = new Button();
            vur = new Button();
            delete = new Button();
            SuspendLayout();
            // 
            // sifir
            // 
            sifir.Location = new Point(12, 328);
            sifir.Name = "sifir";
            sifir.Size = new Size(77, 49);
            sifir.TabIndex = 0;
            sifir.Text = "0";
            sifir.UseVisualStyleBackColor = true;
            sifir.Click += sifir_Click;
            // 
            // label1
            // 
            label1.Location = new Point(2, 33);
            label1.Name = "label1";
            label1.Size = new Size(367, 60);
            label1.TabIndex = 1;
            label1.Text = "0";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dord
            // 
            dord.Location = new Point(12, 218);
            dord.Name = "dord";
            dord.Size = new Size(77, 49);
            dord.TabIndex = 2;
            dord.Text = "4";
            dord.UseVisualStyleBackColor = true;
            dord.Click += dord_Click;
            // 
            // yeddi
            // 
            yeddi.Location = new Point(12, 163);
            yeddi.Name = "yeddi";
            yeddi.Size = new Size(77, 49);
            yeddi.TabIndex = 3;
            yeddi.Text = "7";
            yeddi.UseVisualStyleBackColor = true;
            yeddi.Click += yeddi_Click;
            // 
            // iki
            // 
            iki.Location = new Point(95, 273);
            iki.Name = "iki";
            iki.Size = new Size(77, 49);
            iki.TabIndex = 4;
            iki.Text = "2";
            iki.UseVisualStyleBackColor = true;
            iki.Click += iki_Click;
            // 
            // bes
            // 
            bes.Location = new Point(95, 218);
            bes.Name = "bes";
            bes.Size = new Size(77, 49);
            bes.TabIndex = 5;
            bes.Text = "5";
            bes.UseVisualStyleBackColor = true;
            bes.Click += bes_Click;
            // 
            // bir
            // 
            bir.Location = new Point(12, 273);
            bir.Name = "bir";
            bir.Size = new Size(77, 49);
            bir.TabIndex = 6;
            bir.Text = "1";
            bir.UseVisualStyleBackColor = true;
            bir.Click += bir_Click;
            // 
            // sekkiz
            // 
            sekkiz.Location = new Point(95, 163);
            sekkiz.Name = "sekkiz";
            sekkiz.Size = new Size(77, 49);
            sekkiz.TabIndex = 7;
            sekkiz.Text = "8";
            sekkiz.UseVisualStyleBackColor = true;
            sekkiz.Click += sekkiz_Click;
            // 
            // uc
            // 
            uc.Location = new Point(178, 273);
            uc.Name = "uc";
            uc.Size = new Size(77, 49);
            uc.TabIndex = 8;
            uc.Text = "3";
            uc.UseVisualStyleBackColor = true;
            uc.Click += uc_Click;
            // 
            // alti
            // 
            alti.Location = new Point(178, 218);
            alti.Name = "alti";
            alti.Size = new Size(77, 49);
            alti.TabIndex = 9;
            alti.Text = "6";
            alti.UseVisualStyleBackColor = true;
            alti.Click += alti_Click;
            // 
            // doqquz
            // 
            doqquz.Location = new Point(178, 163);
            doqquz.Name = "doqquz";
            doqquz.Size = new Size(77, 49);
            doqquz.TabIndex = 10;
            doqquz.Text = "9";
            doqquz.UseVisualStyleBackColor = true;
            doqquz.Click += doqquz_Click;
            // 
            // beraber
            // 
            beraber.Location = new Point(178, 328);
            beraber.Name = "beraber";
            beraber.Size = new Size(77, 49);
            beraber.TabIndex = 11;
            beraber.Text = "=";
            beraber.UseVisualStyleBackColor = true;
            beraber.Click += beraber_Click;
            // 
            // bol
            // 
            bol.Location = new Point(261, 163);
            bol.Name = "bol";
            bol.Size = new Size(77, 49);
            bol.TabIndex = 12;
            bol.Text = "/";
            bol.UseVisualStyleBackColor = true;
            bol.Click += bol_Click;
            // 
            // plus
            // 
            plus.Location = new Point(261, 328);
            plus.Name = "plus";
            plus.Size = new Size(77, 49);
            plus.TabIndex = 13;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // cx
            // 
            cx.Location = new Point(261, 273);
            cx.Name = "cx";
            cx.Size = new Size(77, 49);
            cx.TabIndex = 14;
            cx.Text = "-";
            cx.UseVisualStyleBackColor = true;
            cx.Click += cx_Click;
            // 
            // vur
            // 
            vur.Location = new Point(261, 218);
            vur.Name = "vur";
            vur.Size = new Size(77, 49);
            vur.TabIndex = 15;
            vur.Text = "*";
            vur.UseVisualStyleBackColor = true;
            vur.Click += vur_Click;
            // 
            // delete
            // 
            delete.Location = new Point(95, 328);
            delete.Name = "delete";
            delete.Size = new Size(77, 49);
            delete.TabIndex = 16;
            delete.Text = "CE";
            delete.UseVisualStyleBackColor = true;
            delete.Click += button16_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 381);
            Controls.Add(delete);
            Controls.Add(vur);
            Controls.Add(cx);
            Controls.Add(plus);
            Controls.Add(bol);
            Controls.Add(beraber);
            Controls.Add(doqquz);
            Controls.Add(alti);
            Controls.Add(uc);
            Controls.Add(sekkiz);
            Controls.Add(bir);
            Controls.Add(bes);
            Controls.Add(iki);
            Controls.Add(yeddi);
            Controls.Add(dord);
            Controls.Add(label1);
            Controls.Add(sifir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button sifir;
        private Label label1;
        private Button dord;
        private Button yeddi;
        private Button iki;
        private Button bes;
        private Button bir;
        private Button sekkiz;
        private Button uc;
        private Button alti;
        private Button doqquz;
        private Button beraber;
        private Button bol;
        private Button plus;
        private Button cx;
        private Button vur;
        private Button delete;
    }
}
