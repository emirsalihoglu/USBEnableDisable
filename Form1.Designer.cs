namespace USBEnableDisable
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButtonEnable = new System.Windows.Forms.RadioButton();
            this.radioButtonDisable = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.radioButtonReadOnly = new System.Windows.Forms.RadioButton();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonReadAndWrite = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonCheckDevice = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonEnable
            // 
            this.radioButtonEnable.AutoSize = true;
            this.radioButtonEnable.Location = new System.Drawing.Point(6, 29);
            this.radioButtonEnable.Name = "radioButtonEnable";
            this.radioButtonEnable.Size = new System.Drawing.Size(58, 17);
            this.radioButtonEnable.TabIndex = 0;
            this.radioButtonEnable.TabStop = true;
            this.radioButtonEnable.Text = "Enable";
            this.radioButtonEnable.UseVisualStyleBackColor = true;
            this.radioButtonEnable.CheckedChanged += new System.EventHandler(this.radioButtonEnable_CheckedChanged);
            // 
            // radioButtonDisable
            // 
            this.radioButtonDisable.AutoSize = true;
            this.radioButtonDisable.Location = new System.Drawing.Point(6, 62);
            this.radioButtonDisable.Name = "radioButtonDisable";
            this.radioButtonDisable.Size = new System.Drawing.Size(60, 17);
            this.radioButtonDisable.TabIndex = 1;
            this.radioButtonDisable.TabStop = true;
            this.radioButtonDisable.Text = "Disable";
            this.radioButtonDisable.UseVisualStyleBackColor = true;
            this.radioButtonDisable.CheckedChanged += new System.EventHandler(this.radioButtonDisable_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonEnable);
            this.groupBox1.Controls.Add(this.radioButtonDisable);
            this.groupBox1.Location = new System.Drawing.Point(27, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enable/Disable";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(27, 290);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // radioButtonReadOnly
            // 
            this.radioButtonReadOnly.AutoSize = true;
            this.radioButtonReadOnly.Location = new System.Drawing.Point(6, 31);
            this.radioButtonReadOnly.Name = "radioButtonReadOnly";
            this.radioButtonReadOnly.Size = new System.Drawing.Size(105, 17);
            this.radioButtonReadOnly.TabIndex = 4;
            this.radioButtonReadOnly.TabStop = true;
            this.radioButtonReadOnly.Text = "Make Read-Only";
            this.radioButtonReadOnly.UseVisualStyleBackColor = true;
            this.radioButtonReadOnly.CheckedChanged += new System.EventHandler(this.radioButtonreadonly_CheckedChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(152, 290);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonReadAndWrite);
            this.groupBox2.Controls.Add(this.radioButtonReadOnly);
            this.groupBox2.Location = new System.Drawing.Point(27, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Read/Write";
            // 
            // radioButtonReadAndWrite
            // 
            this.radioButtonReadAndWrite.AutoSize = true;
            this.radioButtonReadAndWrite.Location = new System.Drawing.Point(6, 65);
            this.radioButtonReadAndWrite.Name = "radioButtonReadAndWrite";
            this.radioButtonReadAndWrite.Size = new System.Drawing.Size(131, 17);
            this.radioButtonReadAndWrite.TabIndex = 5;
            this.radioButtonReadAndWrite.TabStop = true;
            this.radioButtonReadAndWrite.Text = "Make Read And Write";
            this.radioButtonReadAndWrite.UseVisualStyleBackColor = true;
            this.radioButtonReadAndWrite.CheckedChanged += new System.EventHandler(this.radioButtonReadAndWrite_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(261, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 251);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "USB Enable/Disable";
            this.notifyIcon1.Visible = true;
            // 
            // buttonCheckDevice
            // 
            this.buttonCheckDevice.Location = new System.Drawing.Point(303, 290);
            this.buttonCheckDevice.Name = "buttonCheckDevice";
            this.buttonCheckDevice.Size = new System.Drawing.Size(93, 23);
            this.buttonCheckDevice.TabIndex = 9;
            this.buttonCheckDevice.Text = "Check Devices";
            this.buttonCheckDevice.UseVisualStyleBackColor = true;
            this.buttonCheckDevice.Click += new System.EventHandler(this.buttonCheckDevice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 346);
            this.Controls.Add(this.buttonCheckDevice);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "USB Enable/Disable";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonEnable;
        private System.Windows.Forms.RadioButton radioButtonDisable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.RadioButton radioButtonReadOnly;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonReadAndWrite;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button buttonCheckDevice;
    }
}

