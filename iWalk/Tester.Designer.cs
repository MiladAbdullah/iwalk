namespace iWalk
{
    partial class Tester
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
            this.components = new System.ComponentModel.Container();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.showTimer = new System.Windows.Forms.Timer(this.components);
            this.OriginalLabel = new System.Windows.Forms.Label();
            this.faceDetecteLabel = new System.Windows.Forms.Label();
            this.faceBox = new System.Windows.Forms.PictureBox();
            this.eyeDetectedLabel = new System.Windows.Forms.Label();
            this.eyeBox = new System.Windows.Forms.PictureBox();
            this.eyeBallDetectLabel = new System.Windows.Forms.Label();
            this.ballBox = new System.Windows.Forms.PictureBox();
            this.confGroup = new System.Windows.Forms.GroupBox();
            this.stopBtm = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.portConnector = new System.Windows.Forms.Button();
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.eyeballDetectButton = new System.Windows.Forms.Button();
            this.eyeDetectBtm = new System.Windows.Forms.Button();
            this.faceDetectButton = new System.Windows.Forms.Button();
            this.camLabel = new System.Windows.Forms.Label();
            this.camBox = new System.Windows.Forms.ComboBox();
            this.delayer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballBox)).BeginInit();
            this.confGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBox
            // 
            this.pBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox.Location = new System.Drawing.Point(12, 29);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(241, 190);
            this.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox.TabIndex = 0;
            this.pBox.TabStop = false;
            this.pBox.Click += new System.EventHandler(this.pBox_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(80, 63);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(111, 32);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start Camera";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // showTimer
            // 
            this.showTimer.Interval = 1;
            this.showTimer.Tick += new System.EventHandler(this.showTimer_Tick);
            // 
            // OriginalLabel
            // 
            this.OriginalLabel.AutoSize = true;
            this.OriginalLabel.Location = new System.Drawing.Point(12, 13);
            this.OriginalLabel.Name = "OriginalLabel";
            this.OriginalLabel.Size = new System.Drawing.Size(42, 13);
            this.OriginalLabel.TabIndex = 2;
            this.OriginalLabel.Text = "Original";
            // 
            // faceDetecteLabel
            // 
            this.faceDetecteLabel.AutoSize = true;
            this.faceDetecteLabel.Location = new System.Drawing.Point(259, 13);
            this.faceDetecteLabel.Name = "faceDetecteLabel";
            this.faceDetecteLabel.Size = new System.Drawing.Size(78, 13);
            this.faceDetecteLabel.TabIndex = 4;
            this.faceDetecteLabel.Text = "Detected Face";
            // 
            // faceBox
            // 
            this.faceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.faceBox.Location = new System.Drawing.Point(259, 29);
            this.faceBox.Name = "faceBox";
            this.faceBox.Size = new System.Drawing.Size(241, 190);
            this.faceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.faceBox.TabIndex = 3;
            this.faceBox.TabStop = false;
            // 
            // eyeDetectedLabel
            // 
            this.eyeDetectedLabel.AutoSize = true;
            this.eyeDetectedLabel.Location = new System.Drawing.Point(15, 225);
            this.eyeDetectedLabel.Name = "eyeDetectedLabel";
            this.eyeDetectedLabel.Size = new System.Drawing.Size(72, 13);
            this.eyeDetectedLabel.TabIndex = 6;
            this.eyeDetectedLabel.Text = "Detected Eye";
            // 
            // eyeBox
            // 
            this.eyeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eyeBox.Location = new System.Drawing.Point(15, 241);
            this.eyeBox.Name = "eyeBox";
            this.eyeBox.Size = new System.Drawing.Size(241, 190);
            this.eyeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyeBox.TabIndex = 5;
            this.eyeBox.TabStop = false;
            // 
            // eyeBallDetectLabel
            // 
            this.eyeBallDetectLabel.AutoSize = true;
            this.eyeBallDetectLabel.Location = new System.Drawing.Point(259, 225);
            this.eyeBallDetectLabel.Name = "eyeBallDetectLabel";
            this.eyeBallDetectLabel.Size = new System.Drawing.Size(92, 13);
            this.eyeBallDetectLabel.TabIndex = 8;
            this.eyeBallDetectLabel.Text = "Detected Eye Ball";
            // 
            // ballBox
            // 
            this.ballBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ballBox.Location = new System.Drawing.Point(262, 241);
            this.ballBox.Name = "ballBox";
            this.ballBox.Size = new System.Drawing.Size(241, 190);
            this.ballBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ballBox.TabIndex = 7;
            this.ballBox.TabStop = false;
            // 
            // confGroup
            // 
            this.confGroup.Controls.Add(this.stopBtm);
            this.confGroup.Controls.Add(this.rightButton);
            this.confGroup.Controls.Add(this.LeftButton);
            this.confGroup.Controls.Add(this.upButton);
            this.confGroup.Controls.Add(this.portConnector);
            this.confGroup.Controls.Add(this.PortBox);
            this.confGroup.Controls.Add(this.eyeballDetectButton);
            this.confGroup.Controls.Add(this.eyeDetectBtm);
            this.confGroup.Controls.Add(this.faceDetectButton);
            this.confGroup.Controls.Add(this.camLabel);
            this.confGroup.Controls.Add(this.camBox);
            this.confGroup.Controls.Add(this.Start);
            this.confGroup.Location = new System.Drawing.Point(509, 12);
            this.confGroup.Name = "confGroup";
            this.confGroup.Size = new System.Drawing.Size(197, 419);
            this.confGroup.TabIndex = 9;
            this.confGroup.TabStop = false;
            this.confGroup.Text = "Configurations";
            // 
            // stopBtm
            // 
            this.stopBtm.Location = new System.Drawing.Point(53, 390);
            this.stopBtm.Name = "stopBtm";
            this.stopBtm.Size = new System.Drawing.Size(75, 23);
            this.stopBtm.TabIndex = 18;
            this.stopBtm.Text = "Stop";
            this.stopBtm.UseVisualStyleBackColor = true;
            this.stopBtm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stopBtm_MouseDown);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(116, 350);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 23);
            this.rightButton.TabIndex = 18;
            this.rightButton.Text = "Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rightButton_MouseDown);
            this.rightButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rightButton_MouseUp);
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(9, 350);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(75, 23);
            this.LeftButton.TabIndex = 18;
            this.LeftButton.Text = "Left";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            this.LeftButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftButton_MouseDown);
            this.LeftButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftButton_MouseUp);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(53, 305);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(75, 23);
            this.upButton.TabIndex = 18;
            this.upButton.Text = "Forward";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.upButton_MouseDown);
            this.upButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.upButton_MouseUp);
            // 
            // portConnector
            // 
            this.portConnector.Location = new System.Drawing.Point(116, 237);
            this.portConnector.Name = "portConnector";
            this.portConnector.Size = new System.Drawing.Size(75, 23);
            this.portConnector.TabIndex = 17;
            this.portConnector.Text = "Connect";
            this.portConnector.UseVisualStyleBackColor = true;
            this.portConnector.Click += new System.EventHandler(this.portConnector_Click);
            // 
            // PortBox
            // 
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Location = new System.Drawing.Point(9, 210);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(184, 21);
            this.PortBox.TabIndex = 16;
            // 
            // eyeballDetectButton
            // 
            this.eyeballDetectButton.Location = new System.Drawing.Point(80, 175);
            this.eyeballDetectButton.Name = "eyeballDetectButton";
            this.eyeballDetectButton.Size = new System.Drawing.Size(111, 32);
            this.eyeballDetectButton.TabIndex = 13;
            this.eyeballDetectButton.Text = "Start EyeBall Detect";
            this.eyeballDetectButton.UseVisualStyleBackColor = true;
            this.eyeballDetectButton.Click += new System.EventHandler(this.eyeballDetectButton_Click);
            // 
            // eyeDetectBtm
            // 
            this.eyeDetectBtm.Location = new System.Drawing.Point(80, 139);
            this.eyeDetectBtm.Name = "eyeDetectBtm";
            this.eyeDetectBtm.Size = new System.Drawing.Size(111, 32);
            this.eyeDetectBtm.TabIndex = 12;
            this.eyeDetectBtm.Text = "Start Eye Detect";
            this.eyeDetectBtm.UseVisualStyleBackColor = true;
            this.eyeDetectBtm.Click += new System.EventHandler(this.eyeDetectBtm_Click);
            // 
            // faceDetectButton
            // 
            this.faceDetectButton.Location = new System.Drawing.Point(80, 101);
            this.faceDetectButton.Name = "faceDetectButton";
            this.faceDetectButton.Size = new System.Drawing.Size(111, 32);
            this.faceDetectButton.TabIndex = 11;
            this.faceDetectButton.Text = "Start Face Detect";
            this.faceDetectButton.UseVisualStyleBackColor = true;
            this.faceDetectButton.Click += new System.EventHandler(this.faceDetectButton_Click);
            // 
            // camLabel
            // 
            this.camLabel.AutoSize = true;
            this.camLabel.Location = new System.Drawing.Point(6, 20);
            this.camLabel.Name = "camLabel";
            this.camLabel.Size = new System.Drawing.Size(51, 13);
            this.camLabel.TabIndex = 10;
            this.camLabel.Text = "Cameras:";
            // 
            // camBox
            // 
            this.camBox.FormattingEnabled = true;
            this.camBox.Location = new System.Drawing.Point(7, 36);
            this.camBox.Name = "camBox";
            this.camBox.Size = new System.Drawing.Size(184, 21);
            this.camBox.TabIndex = 2;
            // 
            // delayer
            // 
            this.delayer.Interval = 1000;
            this.delayer.Tick += new System.EventHandler(this.delayer_Tick);
            // 
            // Tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 443);
            this.Controls.Add(this.confGroup);
            this.Controls.Add(this.eyeBallDetectLabel);
            this.Controls.Add(this.ballBox);
            this.Controls.Add(this.eyeDetectedLabel);
            this.Controls.Add(this.eyeBox);
            this.Controls.Add(this.faceDetecteLabel);
            this.Controls.Add(this.faceBox);
            this.Controls.Add(this.OriginalLabel);
            this.Controls.Add(this.pBox);
            this.Name = "Tester";
            this.Text = "Tester";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tester_FormClosed);
            this.Load += new System.EventHandler(this.Tester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballBox)).EndInit();
            this.confGroup.ResumeLayout(false);
            this.confGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer showTimer;
        private System.Windows.Forms.Label OriginalLabel;
        private System.Windows.Forms.Label faceDetecteLabel;
        private System.Windows.Forms.PictureBox faceBox;
        private System.Windows.Forms.Label eyeDetectedLabel;
        private System.Windows.Forms.PictureBox eyeBox;
        private System.Windows.Forms.Label eyeBallDetectLabel;
        private System.Windows.Forms.PictureBox ballBox;
        private System.Windows.Forms.GroupBox confGroup;
        private System.Windows.Forms.Label camLabel;
        private System.Windows.Forms.ComboBox camBox;
        private System.Windows.Forms.Button faceDetectButton;
        private System.Windows.Forms.Button eyeballDetectButton;
        private System.Windows.Forms.Button eyeDetectBtm;
        private System.Windows.Forms.ComboBox PortBox;
        private System.Windows.Forms.Button portConnector;
        private System.Windows.Forms.Timer delayer;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button stopBtm;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button LeftButton;
    }
}