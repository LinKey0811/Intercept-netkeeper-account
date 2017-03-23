namespace INA_by_cs
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.start = new System.Windows.Forms.Button();
            this.accBox = new System.Windows.Forms.TextBox();
            this.rdial = new System.Windows.Forms.Button();
            this.psBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cdset = new System.Windows.Forms.GroupBox();
            this.mBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtPsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtIPBox = new System.Windows.Forms.TextBox();
            this.rtAccBox = new System.Windows.Forms.TextBox();
            this.rtset = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cdset.SuspendLayout();
            this.rtset.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.start.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.start.Location = new System.Drawing.Point(175, 49);
            this.start.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(77, 22);
            this.start.TabIndex = 0;
            this.start.Text = "开始截获";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // accBox
            // 
            this.accBox.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accBox.Location = new System.Drawing.Point(77, 25);
            this.accBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.accBox.Name = "accBox";
            this.accBox.Size = new System.Drawing.Size(172, 20);
            this.accBox.TabIndex = 1;
            this.accBox.TextChanged += new System.EventHandler(this.accBox_TextChanged);
            // 
            // rdial
            // 
            this.rdial.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdial.Location = new System.Drawing.Point(175, 74);
            this.rdial.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rdial.Name = "rdial";
            this.rdial.Size = new System.Drawing.Size(77, 22);
            this.rdial.TabIndex = 3;
            this.rdial.Text = "路由器拨号";
            this.rdial.UseVisualStyleBackColor = true;
            this.rdial.Click += new System.EventHandler(this.rdial_Click);
            // 
            // psBox
            // 
            this.psBox.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.psBox.Location = new System.Drawing.Point(77, 49);
            this.psBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.psBox.Name = "psBox";
            this.psBox.Size = new System.Drawing.Size(90, 22);
            this.psBox.TabIndex = 12;
            this.psBox.TextChanged += new System.EventHandler(this.psBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(16, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "宽带账号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(16, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "宽带密码";
            // 
            // cdset
            // 
            this.cdset.Controls.Add(this.label5);
            this.cdset.Controls.Add(this.psBox);
            this.cdset.Controls.Add(this.label4);
            this.cdset.Controls.Add(this.accBox);
            this.cdset.Controls.Add(this.start);
            this.cdset.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cdset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cdset.Location = new System.Drawing.Point(7, 13);
            this.cdset.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cdset.Name = "cdset";
            this.cdset.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cdset.Size = new System.Drawing.Size(264, 83);
            this.cdset.TabIndex = 19;
            this.cdset.TabStop = false;
            this.cdset.Text = "宽带相关设置";
            this.cdset.Enter += new System.EventHandler(this.cdset_Enter);
            // 
            // mBox
            // 
            this.mBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mBox.Font = new System.Drawing.Font("方正细圆简体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mBox.Location = new System.Drawing.Point(7, 209);
            this.mBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.mBox.Name = "mBox";
            this.mBox.ReadOnly = true;
            this.mBox.Size = new System.Drawing.Size(263, 51);
            this.mBox.TabIndex = 18;
            this.mBox.Text = "消息提醒";
            this.mBox.TextChanged += new System.EventHandler(this.mBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(12, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = " 设置网址 ";
            // 
            // rtPsBox
            // 
            this.rtPsBox.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtPsBox.Location = new System.Drawing.Point(77, 49);
            this.rtPsBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rtPsBox.Name = "rtPsBox";
            this.rtPsBox.Size = new System.Drawing.Size(90, 20);
            this.rtPsBox.TabIndex = 21;
            this.rtPsBox.Text = "admin";
            this.rtPsBox.TextChanged += new System.EventHandler(this.rtPsBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "登录用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = " 登录密码 ";
            // 
            // rtIPBox
            // 
            this.rtIPBox.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtIPBox.Location = new System.Drawing.Point(77, 74);
            this.rtIPBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rtIPBox.Name = "rtIPBox";
            this.rtIPBox.Size = new System.Drawing.Size(90, 20);
            this.rtIPBox.TabIndex = 20;
            this.rtIPBox.Text = "192.168.1.1";
            this.rtIPBox.TextChanged += new System.EventHandler(this.rtIPBox_TextChanged);
            // 
            // rtAccBox
            // 
            this.rtAccBox.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtAccBox.Location = new System.Drawing.Point(77, 23);
            this.rtAccBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rtAccBox.Name = "rtAccBox";
            this.rtAccBox.Size = new System.Drawing.Size(90, 20);
            this.rtAccBox.TabIndex = 22;
            this.rtAccBox.Text = "admin";
            this.rtAccBox.TextChanged += new System.EventHandler(this.rtAccBox_TextChanged);
            // 
            // rtset
            // 
            this.rtset.Controls.Add(this.rtPsBox);
            this.rtset.Controls.Add(this.save);
            this.rtset.Controls.Add(this.rdial);
            this.rtset.Controls.Add(this.rtAccBox);
            this.rtset.Controls.Add(this.reset);
            this.rtset.Controls.Add(this.label6);
            this.rtset.Controls.Add(this.label2);
            this.rtset.Controls.Add(this.rtIPBox);
            this.rtset.Controls.Add(this.label3);
            this.rtset.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtset.Location = new System.Drawing.Point(7, 101);
            this.rtset.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rtset.Name = "rtset";
            this.rtset.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rtset.Size = new System.Drawing.Size(264, 104);
            this.rtset.TabIndex = 26;
            this.rtset.TabStop = false;
            this.rtset.Text = "路由相关设置";
            this.rtset.Enter += new System.EventHandler(this.rtset_Enter);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.save.Location = new System.Drawing.Point(175, 49);
            this.save.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(77, 20);
            this.save.TabIndex = 31;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reset.Location = new System.Drawing.Point(175, 23);
            this.reset.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(77, 22);
            this.reset.TabIndex = 30;
            this.reset.Text = "重置";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Location = new System.Drawing.Point(0, 263);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(280, 20);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "< Made by LinKey 点击访问GitHub主页 >";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AccessibleName = "NetHelper";
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(279, 289);
            this.Controls.Add(this.mBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cdset);
            this.Controls.Add(this.rtset);
            this.Font = new System.Drawing.Font("方正舒体简体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NetHelper v1.0 by LinKey";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.INA_Load);
            this.cdset.ResumeLayout(false);
            this.cdset.PerformLayout();
            this.rtset.ResumeLayout(false);
            this.rtset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox accBox;
        private System.Windows.Forms.Button rdial;
        private System.Windows.Forms.TextBox psBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox cdset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rtPsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rtIPBox;
        private System.Windows.Forms.TextBox rtAccBox;
        private System.Windows.Forms.GroupBox rtset;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RichTextBox mBox;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button save;
    }
}

