namespace ComRoverV1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.labelStaticDistance = new System.Windows.Forms.Label();
            this.comPortBox = new System.Windows.Forms.TextBox();
            this.labelCOMPortNumber = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonDeconnexion = new System.Windows.Forms.Button();
            this.serialDistanceValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUp.Location = new System.Drawing.Point(123, 30);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(100, 100);
            this.buttonUp.TabIndex = 0;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRight.Location = new System.Drawing.Point(229, 136);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(100, 100);
            this.buttonRight.TabIndex = 1;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStop.BackgroundImage")));
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStop.Location = new System.Drawing.Point(123, 136);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(100, 100);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDown.Location = new System.Drawing.Point(123, 242);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(100, 100);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLeft.Location = new System.Drawing.Point(17, 136);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(100, 100);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // labelStaticDistance
            // 
            this.labelStaticDistance.AutoSize = true;
            this.labelStaticDistance.Location = new System.Drawing.Point(417, 147);
            this.labelStaticDistance.Name = "labelStaticDistance";
            this.labelStaticDistance.Size = new System.Drawing.Size(99, 17);
            this.labelStaticDistance.TabIndex = 5;
            this.labelStaticDistance.Text = "Distance (cm):";
            this.labelStaticDistance.Click += new System.EventHandler(this.labelStaticDistance_Click);
            // 
            // comPortBox
            // 
            this.comPortBox.Location = new System.Drawing.Point(522, 173);
            this.comPortBox.Name = "comPortBox";
            this.comPortBox.Size = new System.Drawing.Size(24, 22);
            this.comPortBox.TabIndex = 7;
            this.comPortBox.Text = "4";
            this.comPortBox.TextChanged += new System.EventHandler(this.comPortBox_TextChanged);
            // 
            // labelCOMPortNumber
            // 
            this.labelCOMPortNumber.AutoSize = true;
            this.labelCOMPortNumber.Location = new System.Drawing.Point(477, 173);
            this.labelCOMPortNumber.Name = "labelCOMPortNumber";
            this.labelCOMPortNumber.Size = new System.Drawing.Size(39, 17);
            this.labelCOMPortNumber.TabIndex = 8;
            this.labelCOMPortNumber.Text = "COM";
            this.labelCOMPortNumber.Click += new System.EventHandler(this.labelCOMPortNumber_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(359, 338);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(106, 23);
            this.buttonGo.TabIndex = 9;
            this.buttonGo.Text = "GO!";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.Location = new System.Drawing.Point(498, 338);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(107, 23);
            this.buttonDeconnexion.TabIndex = 10;
            this.buttonDeconnexion.Text = "Déconnexion";
            this.buttonDeconnexion.UseVisualStyleBackColor = true;
            this.buttonDeconnexion.Click += new System.EventHandler(this.buttonDeconnexion_Click);
            // 
            // serialDistanceValue
            // 
            this.serialDistanceValue.Location = new System.Drawing.Point(522, 147);
            this.serialDistanceValue.Name = "serialDistanceValue";
            this.serialDistanceValue.Size = new System.Drawing.Size(55, 22);
            this.serialDistanceValue.TabIndex = 11;
            this.serialDistanceValue.TextChanged += new System.EventHandler(this.serialDistanceValue_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.serialDistanceValue);
            this.Controls.Add(this.buttonDeconnexion);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.labelCOMPortNumber);
            this.Controls.Add(this.comPortBox);
            this.Controls.Add(this.labelStaticDistance);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonUp);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "ComRoverV1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Label labelStaticDistance;
        private System.Windows.Forms.TextBox comPortBox;
        private System.Windows.Forms.Label labelCOMPortNumber;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonDeconnexion;
        public System.Windows.Forms.TextBox serialDistanceValue;
    }
}

