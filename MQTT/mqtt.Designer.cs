namespace MQTT
{
    partial class mqtt
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            this.label9 = new System.Windows.Forms.Label();
            this.tbRecvMessage = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.btnConnectControl = new System.Windows.Forms.Button();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.tbPw = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(12, 6);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(65, 12);
            label7.TabIndex = 15;
            label7.Text = "Messages";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(15, 110);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 12);
            label4.TabIndex = 7;
            label4.Text = "PassWord";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(15, 83);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 12);
            label3.TabIndex = 4;
            label3.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 29);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(16, 12);
            label2.TabIndex = 3;
            label2.Text = "IP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 56);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(27, 12);
            label1.TabIndex = 1;
            label1.Text = "Port";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 306);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(41, 12);
            label5.TabIndex = 19;
            label5.Text = "Memo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            label6.Location = new System.Drawing.Point(79, 9);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(485, 12);
            label6.TabIndex = 20;
            label6.Text = "────────────────────────────────────────";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            label8.Location = new System.Drawing.Point(55, 306);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(509, 12);
            label8.TabIndex = 21;
            label8.Text = "──────────────────────────────────────────";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            label10.Location = new System.Drawing.Point(607, 306);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(197, 12);
            label10.TabIndex = 24;
            label10.Text = "────────────────";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(570, 306);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(33, 12);
            label11.TabIndex = 23;
            label11.Text = "Save";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(63, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "─────────────";
            // 
            // tbRecvMessage
            // 
            this.tbRecvMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecvMessage.Font = new System.Drawing.Font("굴림", 13F);
            this.tbRecvMessage.Location = new System.Drawing.Point(12, 27);
            this.tbRecvMessage.Multiline = true;
            this.tbRecvMessage.Name = "tbRecvMessage";
            this.tbRecvMessage.Size = new System.Drawing.Size(550, 250);
            this.tbRecvMessage.TabIndex = 14;
            // 
            // tbStatus
            // 
            this.tbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatus.Enabled = false;
            this.tbStatus.Location = new System.Drawing.Point(572, 237);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(232, 40);
            this.tbStatus.TabIndex = 12;
            // 
            // btnConnectControl
            // 
            this.btnConnectControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectControl.Location = new System.Drawing.Point(572, 196);
            this.btnConnectControl.Name = "btnConnectControl";
            this.btnConnectControl.Size = new System.Drawing.Size(232, 35);
            this.btnConnectControl.TabIndex = 1;
            this.btnConnectControl.Text = "연결";
            this.btnConnectControl.UseVisualStyleBackColor = true;
            this.btnConnectControl.Click += new System.EventHandler(this.btnConnectControl_Click);
            // 
            // gbSettings
            // 
            this.gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSettings.Controls.Add(this.label9);
            this.gbSettings.Controls.Add(label4);
            this.gbSettings.Controls.Add(this.tbPw);
            this.gbSettings.Controls.Add(this.tbId);
            this.gbSettings.Controls.Add(label3);
            this.gbSettings.Controls.Add(this.tbPort);
            this.gbSettings.Controls.Add(this.tbIp);
            this.gbSettings.Controls.Add(label2);
            this.gbSettings.Controls.Add(label1);
            this.gbSettings.Location = new System.Drawing.Point(572, 55);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(230, 135);
            this.gbSettings.TabIndex = 16;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // tbPw
            // 
            this.tbPw.Location = new System.Drawing.Point(96, 107);
            this.tbPw.Name = "tbPw";
            this.tbPw.PasswordChar = '*';
            this.tbPw.Size = new System.Drawing.Size(128, 21);
            this.tbPw.TabIndex = 6;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(96, 80);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(128, 21);
            this.tbId.TabIndex = 5;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(96, 53);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(128, 21);
            this.tbPort.TabIndex = 2;
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(96, 26);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(128, 21);
            this.tbIp.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::MQTT.Properties.Resources.보이스키보드_로고;
            this.pictureBox1.Location = new System.Drawing.Point(609, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // tbMemo
            // 
            this.tbMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMemo.Font = new System.Drawing.Font("굴림", 13F);
            this.tbMemo.Location = new System.Drawing.Point(12, 332);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(550, 117);
            this.tbMemo.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(572, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(232, 35);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "저장(*.txt)";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(572, 373);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(232, 35);
            this.btnCopy.TabIndex = 26;
            this.btnCopy.Text = "전체 복사";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(572, 414);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(232, 35);
            this.btnRemove.TabIndex = 27;
            this.btnRemove.Text = "전체 지우기";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // mqtt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 461);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(label10);
            this.Controls.Add(label11);
            this.Controls.Add(label8);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(this.tbMemo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.btnConnectControl);
            this.Controls.Add(label7);
            this.Controls.Add(this.tbRecvMessage);
            this.Controls.Add(this.tbStatus);
            this.MinimumSize = new System.Drawing.Size(500, 380);
            this.Name = "mqtt";
            this.ShowIcon = false;
            this.Text = "Voice Keyboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mqtt_FormClosing);
            this.Load += new System.EventHandler(this.mqtt_Load);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRecvMessage;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Button btnConnectControl;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.TextBox tbPw;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnRemove;
    }
}

